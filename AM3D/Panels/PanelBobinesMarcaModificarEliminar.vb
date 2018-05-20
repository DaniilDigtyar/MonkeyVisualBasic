Public Class PanelBobinesMarcaModificarEliminar
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public marcaBobinaSeleccionada As MarquesBobines = New MarquesBobines("")

    Private Sub BTModificarMarca_Click(sender As Object, e As EventArgs) Handles BTModificarMarca.Click
        marcaBobinaSeleccionada = New MarquesBobines(DGMarcaProductora.SelectedRows.Item(0).Cells(0).Value)
        ModificarBobinesMarca.TBMarca.Text = marcaBobinaSeleccionada.GetSetMarcaProductora
        ModificarBobinesMarca.Show()
    End Sub

    Private Sub PanelBobinesMarcaModificarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaMarques As HashSet(Of MarquesBobines) = New HashSet(Of MarquesBobines)
        Dim marcaBobina As MarquesBobines

        listaMarques = SQLCommands.SelectAllMarcasBobinasFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each marcaBobina In listaMarques
            DGMarcaProductora.Rows.Add(marcaBobina.GetSetMarcaProductora)
        Next marcaBobina
    End Sub

    Private Sub BTEliminarMarca_Click(sender As Object, e As EventArgs) Handles BTEliminarMarca.Click
        Dim marcaBobina As MarquesBobines
        Dim indice As Integer
        Dim afectat As Integer = 0

        marcaBobina = New MarquesBobines(DGMarcaProductora.SelectedRows.Item(0).Cells(0).Value)
        afectat = SQLCommands.DeleteMarcaBobinaFromDatabaseWhereMarcaBobina(Globals.userCredentials.GetSetBaseDades, marcaBobina)
        If afectat > 0 Then
            indice = DGMarcaProductora.SelectedRows.Item(0).Index
            DGMarcaProductora.Rows.RemoveAt(indice)
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
        Dim listaMarques As HashSet(Of MarquesBobines) = New HashSet(Of MarquesBobines)
        Dim marcaBobina As MarquesBobines

        DGMarcaProductora.Rows.Clear()
        listaMarques = SQLCommands.SelectAllMarcasBobinasFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each marcaBobina In listaMarques
            DGMarcaProductora.Rows.Add(marcaBobina.GetSetMarcaProductora)
        Next marcaBobina
    End Sub
End Class