Public Class FBobines
    Private Sub BTBobinaAfegir_Click(sender As Object, e As EventArgs) Handles BTBobinaAfegir.Click
        ''PanelBobinesBobinaAfegir.Hide()
        PanelBobinesBobinaModificarEliminar.Hide()
        PanelBobinesColorAfegir.Hide()
        PanelBobinesColorModificarEliminar.Hide()
        PanelBobinesMarcaAfegir.Hide()
        PanelBobinesMarcaModificarEliminar.Hide()
        PanelBobinesMaterialAfegir.Hide()
        PanelBobinesMaterialModificarEliminar.Hide()
        PanelBobinesBobinaAfegir.TopLevel = False
        PBobines.Controls.Add(PanelBobinesBobinaAfegir)
        PanelBobinesBobinaAfegir.Show()
    End Sub

    Private Sub BTColorAfegir_Click(sender As Object, e As EventArgs) Handles BTColorAfegir.Click
        PanelBobinesBobinaAfegir.Hide()
        PanelBobinesBobinaModificarEliminar.Hide()
        ''PanelBobinesColorAfegir.Hide()
        PanelBobinesColorModificarEliminar.Hide()
        PanelBobinesMarcaAfegir.Hide()
        PanelBobinesMarcaModificarEliminar.Hide()
        PanelBobinesMaterialAfegir.Hide()
        PanelBobinesMaterialModificarEliminar.Hide()
        PanelBobinesColorAfegir.TopLevel = False
        PBobines.Controls.Add(PanelBobinesColorAfegir)
        PanelBobinesColorAfegir.Show()
    End Sub

    Private Sub BTBobinaModif_Click(sender As Object, e As EventArgs) Handles BTBobinaModif.Click
        PanelBobinesBobinaAfegir.Hide()
        ''PanelBobinesBobinaModificarEliminar.Hide()
        PanelBobinesColorAfegir.Hide()
        PanelBobinesColorModificarEliminar.Hide()
        PanelBobinesMarcaAfegir.Hide()
        PanelBobinesMarcaModificarEliminar.Hide()
        PanelBobinesMaterialAfegir.Hide()
        PanelBobinesMaterialModificarEliminar.Hide()
        PanelBobinesBobinaModificarEliminar.TopLevel = False
        PBobines.Controls.Add(PanelBobinesBobinaModificarEliminar)
        PanelBobinesBobinaModificarEliminar.Show()
    End Sub

    Private Sub BTColorModif_Click(sender As Object, e As EventArgs) Handles BTColorModif.Click
        PanelBobinesBobinaAfegir.Hide()
        PanelBobinesBobinaModificarEliminar.Hide()
        PanelBobinesColorAfegir.Hide()
        ''PanelBobinesColorModificarEliminar.Hide()
        PanelBobinesMarcaAfegir.Hide()
        PanelBobinesMarcaModificarEliminar.Hide()
        PanelBobinesMaterialAfegir.Hide()
        PanelBobinesMaterialModificarEliminar.Hide()
        PanelBobinesColorModificarEliminar.TopLevel = False
        PBobines.Controls.Add(PanelBobinesColorModificarEliminar)
        PanelBobinesColorModificarEliminar.Show()
    End Sub

    Private Sub BTMarcaModif_Click(sender As Object, e As EventArgs) Handles BTMarcaModif.Click
        PanelBobinesBobinaAfegir.Hide()
        PanelBobinesBobinaModificarEliminar.Hide()
        PanelBobinesColorAfegir.Hide()
        PanelBobinesColorModificarEliminar.Hide()
        PanelBobinesMarcaAfegir.Hide()
        'PanelBobinesMarcaModificarEliminar.Hide()
        PanelBobinesMaterialAfegir.Hide()
        PanelBobinesMaterialModificarEliminar.Hide()
        PanelBobinesMarcaModificarEliminar.TopLevel = False
        PBobines.Controls.Add(PanelBobinesMarcaModificarEliminar)
        PanelBobinesMarcaModificarEliminar.Show()
    End Sub

    Private Sub BTMarcaAfegir_Click(sender As Object, e As EventArgs) Handles BTMarcaAfegir.Click
        PanelBobinesBobinaAfegir.Hide()
        PanelBobinesBobinaModificarEliminar.Hide()
        PanelBobinesColorAfegir.Hide()
        PanelBobinesColorModificarEliminar.Hide()
        ''PanelBobinesMarcaAfegir.Hide()
        PanelBobinesMarcaModificarEliminar.Hide()
        PanelBobinesMaterialAfegir.Hide()
        PanelBobinesMaterialModificarEliminar.Hide()
        PanelBobinesMarcaAfegir.TopLevel = False
        PBobines.Controls.Add(PanelBobinesMarcaAfegir)
        PanelBobinesMarcaAfegir.Show()
    End Sub

    Private Sub BTMaterialModif_Click(sender As Object, e As EventArgs) Handles BTMaterialModif.Click
        PanelBobinesBobinaAfegir.Hide()
        PanelBobinesBobinaModificarEliminar.Hide()
        PanelBobinesColorAfegir.Hide()
        PanelBobinesColorModificarEliminar.Hide()
        PanelBobinesMarcaAfegir.Hide()
        PanelBobinesMarcaModificarEliminar.Hide()
        PanelBobinesMaterialAfegir.Hide()
        'PanelBobinesMaterialModificarEliminar.Hide()
        PanelBobinesMaterialModificarEliminar.TopLevel = False
        PBobines.Controls.Add(PanelBobinesMaterialModificarEliminar)
        PanelBobinesMaterialModificarEliminar.Show()
    End Sub

    Private Sub BTMaterialAfegir_Click(sender As Object, e As EventArgs) Handles BTMaterialAfegir.Click
        PanelBobinesBobinaAfegir.Hide()
        PanelBobinesBobinaModificarEliminar.Hide()
        PanelBobinesColorAfegir.Hide()
        PanelBobinesColorModificarEliminar.Hide()
        PanelBobinesMarcaAfegir.Hide()
        PanelBobinesMarcaModificarEliminar.Hide()
        'PanelBobinesMaterialAfegir.Hide()
        PanelBobinesMaterialModificarEliminar.Hide()
        PanelBobinesMaterialAfegir.TopLevel = False
        PBobines.Controls.Add(PanelBobinesMaterialAfegir)
        PanelBobinesMaterialAfegir.Show()
    End Sub
End Class