Public Class PanelLlistaImpressores
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public impresoraSeleccionada As String
    Public bobinaSeleccionada As String
    Public marcaSeleccionada As String
    Public modelSeleccionada As String
    Public nomSeleccionada As String
    Protected Overrides Sub OnLoad(e As EventArgs)
        Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
        Dim impressores As Impressores

        listaImpressores = SQLCommands.SelectAllPrintersFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each impressores In listaImpressores
            DGImpressores.Rows.Add(impressores.GetSetCodiImpressora, impressores.GetSetNomAssignat, impressores.GetSetEstat, impressores.GetSetMarca, impressores.GetSetModel, impressores.GetSetBobinaCarregada)
        Next impressores
    End Sub

    Private Sub BTCambiarBobina_Click(sender As Object, e As EventArgs) Handles BTCambiarBobina.Click
        impresoraSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(0).Value
        bobinaSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(5).Value
        marcaSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(3).Value
        modelSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(4).Value
        nomSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(1).Value
        CanviarBobina.Show()
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

    Private Sub BResfrescar_Click(sender As Object, e As EventArgs) Handles BResfrescar.Click
        Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
        Dim impressores As Impressores
        DGImpressores.Rows.Clear()
        listaImpressores = SQLCommands.SelectAllPrintersFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each impressores In listaImpressores
            DGImpressores.Rows.Add(impressores.GetSetCodiImpressora, impressores.GetSetNomAssignat, impressores.GetSetEstat, impressores.GetSetMarca, impressores.GetSetModel, impressores.GetSetBobinaCarregada)
        Next impressores
    End Sub

    Private Sub BTModificarImpressora_Click(sender As Object, e As EventArgs) Handles BTModificarImpressora.Click
        impresoraSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(0).Value
        bobinaSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(5).Value
        marcaSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(3).Value
        modelSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(4).Value
        nomSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(1).Value
        ModificarImpressores.Show()
    End Sub
End Class