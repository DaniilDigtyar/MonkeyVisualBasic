Public Class PanelBobinesBobinaModificarEliminar
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public bobinaSeleccionada As Bobines = New Bobines("", "", "", "", 0)
    Private Sub BTModificarBobina_Click(sender As Object, e As EventArgs) Handles BTModificarBobina.Click
        bobinaSeleccionada = New Bobines(DGBobina.SelectedRows.Item(0).Cells(0).Value, DGBobina.SelectedRows.Item(0).Cells(1).Value, DGBobina.SelectedRows.Item(0).Cells(2).Value, DGBobina.SelectedRows.Item(0).Cells(3).Value, DGBobina.SelectedRows.Item(0).Cells(4).Value)
        Dim listaMaterial As HashSet(Of Materials) = New HashSet(Of Materials)
        Dim material As Materials
        Dim indice As Integer = 0

        listaMaterial = SQLCommands.SelectAllMaterialsFromDatabase(Globals.userCredentials.GetSetBaseDades)
        ModificarBobinesBobina.DGMaterial.Rows.Clear()

        For Each material In listaMaterial
            ModificarBobinesBobina.DGMaterial.Rows.Add(material.GetSetTipusMaterial, material.GetSetDescripcio)
        Next material

        Dim listaMarques As HashSet(Of MarquesBobines) = New HashSet(Of MarquesBobines)
        Dim marcaBobina As MarquesBobines

        listaMarques = SQLCommands.SelectAllMarcasBobinasFromDatabase(Globals.userCredentials.GetSetBaseDades)
        ModificarBobinesBobina.DGMarcaProductora.Rows.Clear()

        For Each marcaBobina In listaMarques
            ModificarBobinesBobina.DGMarcaProductora.Rows.Add(marcaBobina.GetSetMarcaProductora)
        Next marcaBobina

        Dim listaColores As HashSet(Of Colors) = New HashSet(Of Colors)
        Dim colorObjeto As Colors

        listaColores = SQLCommands.SelectAllColorsFromDatabase(Globals.userCredentials.GetSetBaseDades)
        ModificarBobinesBobina.DGColor.Rows.Clear()

        For Each colorObjeto In listaColores
            ModificarBobinesBobina.DGColor.Rows.Add(colorObjeto.GetSetColor, colorObjeto.GetSetHex)
            ModificarBobinesBobina.DGColor.Rows(ModificarBobinesBobina.DGColor.Rows.Count - 1).Cells(2).Style.BackColor = Interaction.ConvertToRBG(colorObjeto.GetSetHex)
        Next colorObjeto

        For i As Integer = 0 To ModificarBobinesBobina.DGMaterial.Rows.Count - 1
            If (ModificarBobinesBobina.DGMaterial.Rows(i).Cells(0).Value.ToString.Equals(bobinaSeleccionada.GetSetTipusMaterial)) Then
                indice = ModificarBobinesBobina.DGMaterial.Rows(i).Index
            End If
        Next i
        ModificarBobinesBobina.DGMaterial.Rows(indice).Selected = True
        indice = 0

        For i As Integer = 0 To ModificarBobinesBobina.DGColor.Rows.Count - 1
            If (ModificarBobinesBobina.DGColor.Rows(i).Cells(0).Value.ToString.Equals(bobinaSeleccionada.GetSetColor)) Then
                indice = ModificarBobinesBobina.DGColor.Rows(i).Index
            End If
        Next i
        ModificarBobinesBobina.DGColor.Rows(indice).Selected = True
        indice = 0

        For i As Integer = 0 To ModificarBobinesBobina.DGMarcaProductora.Rows.Count - 1
            If (ModificarBobinesBobina.DGMarcaProductora.Rows(i).Cells(0).Value.ToString.Equals(bobinaSeleccionada.GetSetMarcaProductora)) Then
                indice = ModificarBobinesBobina.DGMarcaProductora.Rows(i).Index
            End If
        Next i
        ModificarBobinesBobina.DGMarcaProductora.Rows(indice).Selected = True


        ModificarBobinesBobina.TBDiametre.Text = bobinaSeleccionada.GetSetDiametre
        ModificarBobinesBobina.Show()
    End Sub

    Private Sub PanelBobinesBobinaModificarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaBobinas As HashSet(Of Bobines) = New HashSet(Of Bobines)
        Dim bobina As Bobines

        listaBobinas = SQLCommands.SelectAllBobinesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each bobina In listaBobinas
            DGBobina.Rows.Add(bobina.GetSetCodiBobina, bobina.GetSetTipusMaterial, bobina.GetSetColor, bobina.GetSetMarcaProductora, bobina.GetSetDiametre)
        Next bobina
    End Sub

    Private Sub BResfrescar_Click(sender As Object, e As EventArgs) Handles BResfrescar.Click
        Dim listaBobinas As HashSet(Of Bobines) = New HashSet(Of Bobines)
        Dim bobina As Bobines

        DGBobina.Rows.Clear()
        listaBobinas = SQLCommands.SelectAllBobinesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each bobina In listaBobinas
            DGBobina.Rows.Add(bobina.GetSetCodiBobina, bobina.GetSetTipusMaterial, bobina.GetSetColor, bobina.GetSetMarcaProductora, bobina.GetSetDiametre)
        Next bobina
    End Sub

    Private Sub BTEliminarBobina_Click(sender As Object, e As EventArgs) Handles BTEliminarBobina.Click
        Dim bobina As Bobines
        Dim indice As Integer
        Dim afectat As Integer = 0

        bobina = New Bobines(DGBobina.SelectedRows.Item(0).Cells(0).Value, DGBobina.SelectedRows.Item(0).Cells(1).Value, DGBobina.SelectedRows.Item(0).Cells(2).Value, DGBobina.SelectedRows.Item(0).Cells(3).Value, DGBobina.SelectedRows.Item(0).Cells(4).Value)
        afectat = SQLCommands.DeleteBobinaFromDatabaseWhereBobina(Globals.userCredentials.GetSetBaseDades, bobina)
        If afectat > 0 Then
            indice = DGBobina.SelectedRows.Item(0).Index
            DGBobina.Rows.RemoveAt(indice)
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
End Class