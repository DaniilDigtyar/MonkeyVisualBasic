Public Class ImprimirGCODE
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point
    Dim SQLCommands As New SQLCommands


    Private Sub BTImprimirCancelar_Click(sender As Object, e As EventArgs) Handles BTImprimirCancelar.Click
        Me.Close()
        CBGcode.Text = ""
        CBImpriImpressora.Text = ""
        TBCopies.Text = 0
    End Sub

    Private Sub ImprimirGCODE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaGcodes As HashSet(Of Gcode) = New HashSet(Of Gcode)
        Dim gcode As Gcode
        Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
        Dim impressora As Impressores

        listaImpressores = SQLCommands.SelectAllPrintersLliureFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaGcodes = SQLCommands.SelectAllGcodesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each impressora In listaImpressores
            CBImpriImpressora.Items.Add(impressora.GetSetCodiImpressora)
        Next impressora

        For Each gcode In listaGcodes
            CBGcode.Items.Add(gcode.GetSetNomGcode)
        Next gcode
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
        Dim printInList As Impressions
        Dim nomGcode As String
        Dim numeroCopias As Integer
        Dim codiImpressora As String
        Dim ordreImpressio As Integer
        Dim estat As String
        Dim nickname As String

        Dim i As Integer
        Try
            nomGcode = CBGcode.SelectedItem.ToString
            codiImpressora = CBImpriImpressora.SelectedItem.ToString
            nickname = Globals.userCredentials.GetSetNickname

            listaImpressions = SQLCommands.SelectPrinterPrintList(Globals.userCredentials.GetSetBaseDades, codiImpressora)
            If listaImpressions.Count > 0 Then
                For Each printInList In listaImpressions

                Next printInList
                'afegi a la llista
            Else
                ' No estaba fent res
                i = 1
                numeroCopias = i
                ordreImpressio = i
                estat = "PRINTING"
                print = New Impressions(nomGcode, numeroCopias, codiImpressora, ordreImpressio, estat, nickname)
                SQLCommands.InsertPrintIntoDatabase(Globals.userCredentials.GetSetBaseDades, print)
                While i < numeroCopias
                    i += 1
                    estat = "WAITING"
                    print = New Impressions(nomGcode, numeroCopias, codiImpressora, ordreImpressio, estat, nickname)
                    SQLCommands.InsertPrintIntoDatabase(Globals.userCredentials.GetSetBaseDades, print)
                End While
            End If



            TBCopies.Text = 0
            print = New Impressions(nomGcode, numeroCopias, codiImpressora, ordreImpressio, estat, nickname)
            SQLCommands.InsertPrintIntoDatabase(Globals.userCredentials.GetSetBaseDades, print)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class