Public Class PanelLlistaImpressores
    Dim SQLCommands As SQLCommands = New SQLCommands()

    Protected Overrides Sub OnLoad(e As EventArgs)
        Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
        Dim impressores As Impressores

        listaImpressores = SQLCommands.SelectAllPrintersFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each impressores In listaImpressores
            DGImpressores.Rows.Add(impressores.GetSetCodiImpressora, impressores.GetSetNomAssignat, impressores.GetSetEstat, impressores.GetSetMarca, impressores.GetSetModel, impressores.GetSetBobinaCarregada)
        Next impressores
    End Sub

    Private Sub BTCambiarBobina_Click(sender As Object, e As EventArgs) Handles BTCambiarBobina.Click
        CanviarBobina.Show()
    End Sub

    Private Sub PanelLlistaImpressores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTEliminarImpressora_Click(sender As Object, e As EventArgs) Handles BTEliminarImpressora.Click
        Dim codiImpressora As String
        Dim impressora As Impressores
        Dim indice As Integer
        codiImpressora = DGImpressores.SelectedRows.Item(0).Cells(0).Value
        indice = DGImpressores.SelectedRows.Item(0).Index
        DGImpressores.Rows.RemoveAt(indice)
        impressora = New Impressores(codiImpressora, "", "", "", "", "")
        SQLCommands.DeletePrinterIntoDatabase(Globals.userCredentials.GetSetBaseDades, impressora)
    End Sub
End Class