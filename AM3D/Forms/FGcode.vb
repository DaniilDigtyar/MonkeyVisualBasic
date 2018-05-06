Public Class FGcode
    Private Sub BTAfegir_Click(sender As Object, e As EventArgs) Handles BTAfegir.Click
        PanelGcodeModificarEliminar.Hide()
        PanelGcodeAfegir.TopLevel = False
        PGcode.Controls.Add(PanelGcodeAfegir)
        PanelGcodeAfegir.Show()
    End Sub

    Private Sub BTModificarEliminar_Click(sender As Object, e As EventArgs) Handles BTModificarEliminar.Click
        PanelGcodeAfegir.Hide()
        PanelGcodeModificarEliminar.TopLevel = False
        PGcode.Controls.Add(PanelGcodeModificarEliminar)
        PanelGcodeModificarEliminar.Show()
    End Sub
End Class