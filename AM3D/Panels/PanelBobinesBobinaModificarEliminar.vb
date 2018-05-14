Public Class PanelBobinesBobinaModificarEliminar
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public bobinaSeleccionada As Bobines = New Bobines("", "", "", "", 0)
    Private Sub BTModificarBobina_Click(sender As Object, e As EventArgs) Handles BTModificarBobina.Click
        bobinaSeleccionada = New Bobines(DGBobina.SelectedRows.Item(0).Cells(0).Value, DGBobina.SelectedRows.Item(0).Cells(1).Value, DGBobina.SelectedRows.Item(0).Cells(2).Value, DGBobina.SelectedRows.Item(0).Cells(3).Value, DGBobina.SelectedRows.Item(0).Cells(4).Value)
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