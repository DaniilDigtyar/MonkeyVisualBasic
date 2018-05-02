Public Class FModels
    Private Sub BTModelAfegir_Click(sender As Object, e As EventArgs) Handles BTModelAfegir.Click
        PanelMarcaAfegir.Hide()
        PanelMarcaModificarEliminar.Hide()
        ''PanelModelAfegir.Hide()
        PanelModelModificarEliminar.Hide()
        PanelModelAfegir.TopLevel = False
        PMarcaModel.Controls.Add(PanelModelAfegir)
        PanelModelAfegir.Show()
    End Sub

    Private Sub BTModelModificar_Click(sender As Object, e As EventArgs) Handles BTModelModificar.Click
        PanelMarcaAfegir.Hide()
        PanelMarcaModificarEliminar.Hide()
        PanelModelAfegir.Hide()
        'PanelModelModificarEliminar.Hide()
        PanelModelModificarEliminar.TopLevel = False
        PMarcaModel.Controls.Add(PanelModelModificarEliminar)
        PanelModelModificarEliminar.Show()
    End Sub

    Private Sub BTMarcaAfegir_Click(sender As Object, e As EventArgs) Handles BTMarcaAfegir.Click
        ''PanelMarcaAfegir.Hide()
        PanelMarcaModificarEliminar.Hide()
        PanelModelAfegir.Hide()
        PanelModelModificarEliminar.Hide()
        PanelMarcaAfegir.TopLevel = False
        PMarcaModel.Controls.Add(PanelMarcaAfegir)
        PanelMarcaAfegir.Show()
    End Sub

    Private Sub BTMarcaModificar_Click(sender As Object, e As EventArgs) Handles BTMarcaModificar.Click
        PanelMarcaAfegir.Hide()
        'PanelMarcaModificarEliminar.Hide()
        PanelModelAfegir.Hide()
        PanelModelModificarEliminar.Hide()
        PanelMarcaModificarEliminar.TopLevel = False
        PMarcaModel.Controls.Add(PanelMarcaModificarEliminar)
        PanelMarcaModificarEliminar.Show()
    End Sub
End Class