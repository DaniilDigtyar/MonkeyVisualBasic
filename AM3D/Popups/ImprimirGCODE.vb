Public Class ImprimirGCODE
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point
    Dim SQLCommands As New SQLCommands

    Private Sub BTImprimirCancelar_Click(sender As Object, e As EventArgs) Handles BTImprimirCancelar.Click
        Me.Hide()
        CBGcode.Text = ""
        CBImpriImpressora.Text = ""
        TBCopies.Text = 0
    End Sub

    Private Sub ImprimirGCODE_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub MenuSup_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuSup.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub MenuSup_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuSup.MouseMove
        If allowCoolMove = True Then
            Me.Location = New Point(Me.Location.X + e.X - myCoolPoint.X, Me.Location.Y + e.Y - myCoolPoint.Y)
        End If
    End Sub

    Private Sub MenuSup_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuSup.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BTImprimir_Click(sender As Object, e As EventArgs) Handles BTImprimir.Click
        Dim listaImpressions As HashSet(Of Impressions) = New HashSet(Of Impressions)
        Dim print As Impressions
        Dim impressora As Impressores
        Dim nomGcode As String
        Dim copiasTotales As Integer
        Dim codiImpressora As String
        Dim estat As String = ""
        Dim nickname As String
        Dim numeroCopia As Integer
        Dim ordreImpressio As Integer

        Dim i As Integer
        Try
            If CBGcode.SelectedIndex <> -1 And CBImpriImpressora.SelectedIndex <> -1 And TBCopies.Value > 0 Then
                nomGcode = CBGcode.SelectedItem.ToString
                codiImpressora = CBImpriImpressora.SelectedItem.ToString
                nickname = Globals.userCredentials.GetSetNickname
                copiasTotales = TBCopies.Value

                listaImpressions = SQLCommands.SelectPrinterPrintList(Globals.userCredentials.GetSetBaseDades, codiImpressora)
                If listaImpressions.Count > 0 Then
                    'Afegi a la llista
                    print = New Impressions(nomGcode, -1, codiImpressora, -1, estat, nickname)
                    numeroCopia = SQLCommands.SelectCodiCopiaFromImpressionsWhereImpressio(Globals.userCredentials.GetSetBaseDades, print)
                    ordreImpressio = SQLCommands.SelectOrdreImpressioFromImpressionsWhereImpressio(Globals.userCredentials.GetSetBaseDades, print)
                    If numeroCopia <> -1 And ordreImpressio <> -1 Then
                        i = 0
                        While i < copiasTotales
                            i += 1
                            estat = "WAITING"
                            print = New Impressions(nomGcode, numeroCopia + i, codiImpressora, ordreImpressio + i, estat, nickname)
                            SQLCommands.InsertPrintIntoDatabase(Globals.userCredentials.GetSetBaseDades, print)
                        End While
                    ElseIf ordreImpressio <> -1 Then
                        numeroCopia = 0
                        i = 0
                        While i < copiasTotales
                            i += 1
                            estat = "WAITING"
                            print = New Impressions(nomGcode, numeroCopia + i, codiImpressora, ordreImpressio + i, estat, nickname)
                            SQLCommands.InsertPrintIntoDatabase(Globals.userCredentials.GetSetBaseDades, print)
                        End While
                    End If

                Else
                    ' No estaba fent res
                    i = 1
                    estat = "PRINTING"
                    print = New Impressions(nomGcode, i, codiImpressora, i, estat, nickname)
                    impressora = New Impressores(codiImpressora, "", "", "", "", "")
                    SQLCommands.InsertPrintIntoDatabase(Globals.userCredentials.GetSetBaseDades, print)
                    SQLCommands.UpdateImpressoraEstatIntoDatabase(Globals.userCredentials.GetSetBaseDades, impressora, "PRINTING")
                    While i < copiasTotales
                        i += 1
                        estat = "WAITING"
                        print = New Impressions(nomGcode, i, codiImpressora, i, estat, nickname)
                        SQLCommands.InsertPrintIntoDatabase(Globals.userCredentials.GetSetBaseDades, print)
                    End While
                End If
                CBGcode.Text = ""
                CBImpriImpressora.Text = ""
                TBCopies.Text = 0
                Me.Hide()
            Else
                If Globals.lang = "cat" Then
                    LabelInfo.Text = (My.Resources.cat.MSGRellenarError)
                Else
                    LabelInfo.Text = (My.Resources.eng.MSGRellenarError)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class