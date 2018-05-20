Public Class PanelMarcaModificarEliminar
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public marcaSeleccionada As Marca = New Marca("")
    Private Sub BTModificarMarca_Click(sender As Object, e As EventArgs) Handles BTModificarMarca.Click
        marcaSeleccionada = New Marca(DGMarca.SelectedRows.Item(0).Cells(0).Value)
        ModificarMarca.TBMarca.Text = marcaSeleccionada.GetSetMarca
        ModificarMarca.Show()
    End Sub

    Private Sub PanelMarcaModificarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaMarca As HashSet(Of Marca) = New HashSet(Of Marca)
        Dim marca As Marca

        listaMarca = SQLCommands.SelectAllMarquesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each marca In listaMarca
            DGMarca.Rows.Add(marca.GetSetMarca)
        Next marca
    End Sub

    Private Sub BTEliminarMarca_Click(sender As Object, e As EventArgs) Handles BTEliminarMarca.Click
        Dim marca As Marca
        Dim indice As Integer
        Dim afectat As Integer = 0

        marca = New Marca(DGMarca.SelectedRows.Item(0).Cells(0).Value)
        afectat = SQLCommands.DeleteMarcaFromDatabaseWhereMarca(Globals.userCredentials.GetSetBaseDades, marca)
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
        Dim listaMarca As HashSet(Of Marca) = New HashSet(Of Marca)
        Dim marca As Marca

        DGMarca.Rows.Clear()
        listaMarca = SQLCommands.SelectAllMarquesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each marca In listaMarca
            DGMarca.Rows.Add(marca.GetSetMarca)
        Next marca
    End Sub
End Class