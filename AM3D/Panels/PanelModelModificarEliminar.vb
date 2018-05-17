Public Class PanelModelModificarEliminar
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public caracteristicaSeleccionada As New Caracteristiques("", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)

    Private Sub BTModificarModel_Click(sender As Object, e As EventArgs) Handles BTModificarModel.Click
        Dim listaMaterials As HashSet(Of Materials) = New HashSet(Of Materials)
        Dim listaMarca As HashSet(Of Marca) = New HashSet(Of Marca)
        Dim material As Materials
        Dim marca As Marca
        caracteristicaSeleccionada = New Caracteristiques(DGMarca.SelectedRows.Item(0).Cells(0).Value, DGMarca.SelectedRows.Item(0).Cells(1).Value, DGMarca.SelectedRows.Item(0).Cells(2).Value, DGMarca.SelectedRows.Item(0).Cells(3).Value, DGMarca.SelectedRows.Item(0).Cells(4).Value, DGMarca.SelectedRows.Item(0).Cells(5).Value, DGMarca.SelectedRows.Item(0).Cells(6).Value, DGMarca.SelectedRows.Item(0).Cells(7).Value, DGMarca.SelectedRows.Item(0).Cells(8).Value, DGMarca.SelectedRows.Item(0).Cells(9).Value, DGMarca.SelectedRows.Item(0).Cells(10).Value, DGMarca.SelectedRows.Item(0).Cells(11).Value, DGMarca.SelectedRows.Item(0).Cells(12).Value, DGMarca.SelectedRows.Item(0).Cells(13).Value)

        ModificarModel.TBModel.Text = caracteristicaSeleccionada.GetSetModel
        ModificarModel.CBMarca.Text = caracteristicaSeleccionada.GetSetMarca
        ModificarModel.TBExtrusors.Text = caracteristicaSeleccionada.GetSetNumeroExtrusors
        ModificarModel.TBTempMaxEx.Text = caracteristicaSeleccionada.GetSetTemperaturaMaximaExtrusor
        ModificarModel.TBTempMinExt.Text = caracteristicaSeleccionada.GetSetTemperaturaMinimaExtrusor
        ModificarModel.TBTempMaxLlit.Text = caracteristicaSeleccionada.GetSetTemperaturaMaximaLlit
        ModificarModel.TBTempMinLlit.Text = caracteristicaSeleccionada.GetSetTemperaturaMinimaLlit
        ModificarModel.TBImpZ.Text = caracteristicaSeleccionada.GetSetAreaImpresioZ
        ModificarModel.TBAImpY.Text = caracteristicaSeleccionada.GetSetAreaImpresioY
        ModificarModel.TBAImpX.Text = caracteristicaSeleccionada.GetSetAreaImpresioX
        ModificarModel.TBVelMinExt.Text = caracteristicaSeleccionada.GetSetVelocitatMaximaCapcal
        ModificarModel.TBResMinCap.Text = caracteristicaSeleccionada.GetSetResolucioCapaMinima
        ModificarModel.TBResMaxCap.Text = caracteristicaSeleccionada.GetSetResolucioCapaMaxima
        ModificarModel.TBDiametre.Text = caracteristicaSeleccionada.GetSetDiametreFilamentAcceptat



        listaMarca = SQLCommands.SelectAllMarquesFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaMaterials = SQLCommands.SelectAllMaterialsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each marca In listaMarca
            ModificarModel.CBMarca.Items.Add(marca.GetSetMarca)
        Next marca

        For Each material In listaMaterials
            ModificarModel.DGMaterial.Rows.Add(material.GetSetTipusMaterial, material.GetSetDescripcio)
        Next material

        ModificarModel.Show()
    End Sub

    Private Sub PanelModelModificarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaCaracteristiques As HashSet(Of Caracteristiques) = New HashSet(Of Caracteristiques)
        Dim caracteristica As Caracteristiques

        listaCaracteristiques = SQLCommands.SelectAllCaracteristiquesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each caracteristica In listaCaracteristiques
            DGMarca.Rows.Add(caracteristica.GetSetMarca, caracteristica.GetSetModel, caracteristica.GetSetNumeroExtrusors, caracteristica.GetSetTemperaturaMinimaExtrusor, caracteristica.GetSetTemperaturaMaximaExtrusor, caracteristica.GetSetTemperaturaMinimaLlit, caracteristica.GetSetTemperaturaMaximaLlit, caracteristica.GetSetAreaImpresioX, caracteristica.GetSetAreaImpresioY, caracteristica.GetSetAreaImpresioZ, caracteristica.GetSetVelocitatMaximaCapcal, caracteristica.GetSetResolucioCapaMaxima, caracteristica.GetSetResolucioCapaMinima, caracteristica.GetSetDiametreFilamentAcceptat)
        Next caracteristica
    End Sub

    Private Sub BTEliminarModel_Click(sender As Object, e As EventArgs) Handles BTEliminarModel.Click
        Dim caracteristiques As Caracteristiques
        Dim model As Models
        Dim indice As Integer
        Dim afectat As Integer = 0

        model = New Models(DGMarca.SelectedRows.Item(0).Cells(0).Value, DGMarca.SelectedRows.Item(0).Cells(1).Value)

        caracteristiques = New Caracteristiques(model.GetSetMarca, model.GetSetModel, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        afectat = SQLCommands.DeleteModelFromDatabaseWhereModel(Globals.userCredentials.GetSetBaseDades, model)
        If afectat > 0 Then
            indice = DGMarca.SelectedRows.Item(0).Index
            DGMarca.Rows.RemoveAt(indice)
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
        Dim listaCaracteristiques As HashSet(Of Caracteristiques) = New HashSet(Of Caracteristiques)
        Dim caracteristica As Caracteristiques

        DGMarca.Rows.Clear()
        listaCaracteristiques = SQLCommands.SelectAllCaracteristiquesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each caracteristica In listaCaracteristiques
            DGMarca.Rows.Add(caracteristica.GetSetMarca, caracteristica.GetSetModel, caracteristica.GetSetNumeroExtrusors, caracteristica.GetSetTemperaturaMinimaExtrusor, caracteristica.GetSetTemperaturaMaximaExtrusor, caracteristica.GetSetTemperaturaMinimaLlit, caracteristica.GetSetTemperaturaMaximaLlit, caracteristica.GetSetAreaImpresioX, caracteristica.GetSetAreaImpresioY, caracteristica.GetSetAreaImpresioZ, caracteristica.GetSetVelocitatMaximaCapcal, caracteristica.GetSetResolucioCapaMaxima, caracteristica.GetSetResolucioCapaMinima, caracteristica.GetSetDiametreFilamentAcceptat)
        Next caracteristica
    End Sub
End Class