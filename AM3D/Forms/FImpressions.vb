Public Class FImpressions
    Dim SQLCommand As New SQLCommands

    Protected Overrides Sub OnLoad(e As EventArgs)
        Try
            Dim listaImpressions As HashSet(Of Impressions) = New HashSet(Of Impressions)
            Dim impressions As Impressions

            listaImpressions = SQLCommand.SelectAllImpressionsFromDatabase(Globals.userCredentials.GetSetBaseDades)

            For Each impressions In listaImpressions
                BTImprimirGCODE.Rows.Add(impressions.GetSetNomGcode, impressions.GetSetNumeroCopia, impressions.GetSetCodiImpresora, impressions.GetSetOrdreImpressio, impressions.GetSetEstat, impressions.GetSetNickname)
            Next impressions
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BTImpressionsPeçaRetirada_Click(sender As Object, e As EventArgs) Handles BTImpressionsPeçaRetirada.Click
        Dim estado As String
        Dim impressions As Impressions
        Dim afectat As Integer
        Dim indice As Integer

        estado = BTImprimirGCODE.SelectedRows.Item(0).Cells(4).Value
        If estado.Equals("ERROR") Or estado.Equals("FINISHED") Then
            Impressions = New Impressions(BTImprimirGCODE.SelectedRows.Item(0).Cells(0).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(1).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(2).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(3).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(4).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(5).Value)
            afectat = SQLCommand.DeleteImpressionsFromDatabaseWhereImpressio(Globals.userCredentials.GetSetBaseDades, Impressions)
            If afectat > 0 Then
                indice = BTImprimirGCODE.SelectedRows.Item(0).Index
                BTImprimirGCODE.Rows.RemoveAt(indice)
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGImpressionsRetirarCorrect)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGImpressionsRetirarCorrect)
                End If
            Else
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGImpressionsRetirarError)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGImpressionsRetirarError)
                End If
            End If
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGImpressionsRetirarErrorSelect)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGImpressionsRetirarErrorSelect)
            End If
        End If
    End Sub

    Private Sub BTImprimirG_Click(sender As Object, e As EventArgs) Handles BTImprimirG.Click
        Dim listaGcodes As HashSet(Of Gcode) = New HashSet(Of Gcode)
        Dim gcode As Gcode
        Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
        Dim impressora As Impressores

        listaImpressores = SQLCommand.SelectAllPrintersFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaGcodes = SQLCommand.SelectAllGcodesFromDatabase(Globals.userCredentials.GetSetBaseDades)
        ImprimirGCODE.CBImpriImpressora.Items.Clear()
        ImprimirGCODE.CBGcode.Items.Clear()

        For Each impressora In listaImpressores
            ImprimirGCODE.CBImpriImpressora.Items.Add(impressora.GetSetCodiImpressora)
        Next impressora

        For Each gcode In listaGcodes
            ImprimirGCODE.CBGcode.Items.Add(gcode.GetSetNomGcode)
        Next gcode
        ImprimirGCODE.Show()
    End Sub

    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Dim impressions As Impressions
        Dim impressioSiguente As Impressions = New Impressions("", 0, "", 0, "", "")
        Dim impressoraImprimiendo As Impressores
        Dim estado As String
        Dim afectat As Integer
        Dim indice As Integer
        Dim siguente As Boolean
        estado = BTImprimirGCODE.SelectedRows.Item(0).Cells(4).Value
        If estado.Equals("WAITING") Or estado.Equals("PRINTING") Then
            If estado.Equals("WAITING") Then
                impressions = New Impressions(BTImprimirGCODE.SelectedRows.Item(0).Cells(0).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(1).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(2).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(3).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(4).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(5).Value)
                afectat = SQLCommand.DeleteImpressionsFromDatabaseWhereImpressio(Globals.userCredentials.GetSetBaseDades, impressions)
                If afectat > 0 Then
                    indice = BTImprimirGCODE.SelectedRows.Item(0).Index
                    BTImprimirGCODE.Rows.RemoveAt(indice)
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.MSGImpressionsCancelarCorrect)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.MSGImpressionsCancelarCorrect)
                    End If
                Else
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.MSGImpressionsCancelarError)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.MSGImpressionsCancelarError)
                    End If
                End If
            Else
                impressions = New Impressions(BTImprimirGCODE.SelectedRows.Item(0).Cells(0).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(1).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(2).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(3).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(4).Value, BTImprimirGCODE.SelectedRows.Item(0).Cells(5).Value)
                impressioSiguente = SQLCommand.SelectNextImpressioFromDatabaseWhereImpressio(Globals.userCredentials.GetSetBaseDades, impressions, siguente)
                If siguente Then
                    SQLCommand.UpdateImpressionsEstatIntoDatabase(Globals.userCredentials.GetSetBaseDades, impressioSiguente, "PRINTING")
                Else
                    impressoraImprimiendo = New Impressores(BTImprimirGCODE.SelectedRows.Item(0).Cells(2).Value, "", "", "", "", "")
                    SQLCommand.UpdateImpressoraEstatIntoDatabase(Globals.userCredentials.GetSetBaseDades, impressoraImprimiendo, "CONNECTED")
                End If
                afectat = SQLCommand.DeleteImpressionsFromDatabaseWhereImpressio(Globals.userCredentials.GetSetBaseDades, impressions)
                If afectat > 0 Then
                    indice = BTImprimirGCODE.SelectedRows.Item(0).Index
                    BTImprimirGCODE.Rows.RemoveAt(indice)
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.MSGImpressionsCancelarCorrect)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.MSGImpressionsCancelarCorrect)
                    End If
                Else
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.MSGImpressionsCancelarError)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.MSGImpressionsCancelarError)
                    End If
                End If
            End If
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGImpressionsCancelarErrorSelect)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGImpressionsCancelarErrorSelect)
            End If
        End If
    End Sub

    Private Sub BResfrescar_Click(sender As Object, e As EventArgs) Handles BResfrescar.Click
        Dim listaImpressions As HashSet(Of Impressions) = New HashSet(Of Impressions)
        Dim impressions As Impressions
        Try
            BTImprimirGCODE.Rows.Clear()
            listaImpressions = SQLCommand.SelectAllImpressionsFromDatabase(Globals.userCredentials.GetSetBaseDades)

            For Each impressions In listaImpressions
                BTImprimirGCODE.Rows.Add(impressions.GetSetNomGcode, impressions.GetSetNumeroCopia, impressions.GetSetCodiImpresora, impressions.GetSetOrdreImpressio, impressions.GetSetEstat, impressions.GetSetNickname)
            Next impressions
        Catch ex As Exception

        End Try
    End Sub
End Class