Public Class PanelBobinesMaterialModificarEliminar
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public materialSeleccionat As Materials = New Materials("", "")

    Private Sub BTModificarMaterial_Click(sender As Object, e As EventArgs) Handles BTModificarMaterial.Click
        materialSeleccionat = New Materials(DGMaterial.SelectedRows.Item(0).Cells(0).Value, DGMaterial.SelectedRows.Item(0).Cells(1).Value)
        ModificarBobinesMaterial.Show()

    End Sub

    Private Sub PanelBobinesMaterialModificarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaMaterial As HashSet(Of Materials) = New HashSet(Of Materials)
        Dim material As Materials

        listaMaterial = SQLCommands.SelectAllMaterialsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each material In listaMaterial
            DGMaterial.Rows.Add(material.GetSetTipusMaterial, material.GetSetDescripcio)
        Next material
    End Sub

    Private Sub BTEliminarMaterial_Click(sender As Object, e As EventArgs) Handles BTEliminarMaterial.Click
        Dim material As Materials
        Dim indice As Integer
        Dim afectat As Integer = 0

        material = New Materials(DGMaterial.SelectedRows.Item(0).Cells(0).Value, DGMaterial.SelectedRows.Item(0).Cells(1).Value)
        afectat = SQLCommands.DeleteMaterialFromDatabaseWhereMaterial(Globals.userCredentials.GetSetBaseDades, material)
        If afectat > 0 Then
            indice = DGMaterial.SelectedRows.Item(0).Index
            DGMaterial.Rows.RemoveAt(indice)
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
        Dim listaMaterial As HashSet(Of Materials) = New HashSet(Of Materials)
        Dim material As Materials

        DGMaterial.Rows.Clear()
        listaMaterial = SQLCommands.SelectAllMaterialsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each material In listaMaterial
            DGMaterial.Rows.Add(material.GetSetTipusMaterial, material.GetSetDescripcio)
        Next material
    End Sub
End Class