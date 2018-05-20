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

        Dim listaBobines As HashSet(Of Bobines) = New HashSet(Of Bobines)
        Dim bobina As Bobines
        Dim indice As Integer
        Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
        Dim impressores As Impressores

        listaBobines = SQLCommands.SelectAllBobinesFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaImpressores = SQLCommands.SelectAllPrintersFromDatabase(Globals.userCredentials.GetSetBaseDades)
        CanviarBobina.CBImpressora.Items.Clear()
        CanviarBobina.DataGridViewBobina.Rows.Clear()

        For Each impressores In listaImpressores
            CanviarBobina.CBImpressora.Items.Add(impressores.GetSetCodiImpressora)
        Next impressores
        For Each bobina In listaBobines
            CanviarBobina.DataGridViewBobina.Rows.Add(bobina.GetSetCodiBobina, bobina.GetSetTipusMaterial, bobina.GetSetColor, bobina.GetSetMarcaProductora, bobina.GetSetDiametre)
        Next bobina

        For i As Integer = 0 To CanviarBobina.DataGridViewBobina.Rows.Count - 1
            If (CanviarBobina.DataGridViewBobina.Rows(i).Cells(0).Value.ToString.Equals(bobinaSeleccionada)) Then
                indice = CanviarBobina.DataGridViewBobina.Rows(i).Index
            End If
        Next i

        CanviarBobina.DataGridViewBobina.Rows(indice).Selected = True
        CanviarBobina.CBImpressora.Text = impresoraSeleccionada

        CanviarBobina.Show()
    End Sub

    Private Sub BTEliminarImpressora_Click(sender As Object, e As EventArgs) Handles BTEliminarImpressora.Click
        Dim codiImpressora As String
        Dim impressora As Impressores
        Dim indice As Integer
        Dim afectat As Integer = 0
        codiImpressora = DGImpressores.SelectedRows.Item(0).Cells(0).Value
        indice = DGImpressores.SelectedRows.Item(0).Index
        DGImpressores.Rows.RemoveAt(indice)
        impressora = New Impressores(codiImpressora, "", "", "", "", "")
        afectat = SQLCommands.DeleteImpressoresFromDatabaseWhereImpressora(Globals.userCredentials.GetSetBaseDades, impressora)
        If afectat > 0 Then
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGDeleteCorrect)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGDeleteCorrect)
            End If
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGDeleteError)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGDeleteError)
            End If
        End If
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
        Dim listaModels As HashSet(Of Models) = New HashSet(Of Models)
        Dim listaMarca As HashSet(Of Marca) = New HashSet(Of Marca)
        Dim models As Models
        Dim marca As Marca

        impresoraSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(0).Value
        bobinaSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(5).Value
        marcaSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(3).Value
        modelSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(4).Value
        nomSeleccionada = DGImpressores.SelectedRows.Item(0).Cells(1).Value
        ModificarImpressores.CBModel.Items.Clear()
        ModificarImpressores.CBMarca.Items.Clear()
        listaMarca = SQLCommands.SelectAllMarquesFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaModels = SQLCommands.SelectAllModelsFromDatabaseWhere(Globals.userCredentials.GetSetBaseDades, marcaSeleccionada)
        For Each models In listaModels
            ModificarImpressores.CBModel.Items.Add(models.GetSetModel)
        Next models
        For Each marca In listaMarca
            ModificarImpressores.CBMarca.Items.Add(marca.GetSetMarca)
        Next marca

        ModificarImpressores.CBMarca.Text = marcaSeleccionada
        ModificarImpressores.CBModel.Text = modelSeleccionada
        ModificarImpressores.TBNomImpressora.Text = nomSeleccionada
        ModificarImpressores.Show()
    End Sub

    Private Sub PanelLlistaImpressores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class