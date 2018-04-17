Public Class MenuPrincipal
    Private Sub PictureBoxArrows_Click(sender As Object, e As EventArgs) Handles PictureBoxArrows.Click
        MenuVertical.Width = 140
        'PictureBoxArrows.Image = AM3D.Resources.Img.arrows_left
    End Sub

    Private Sub LabelControl_Click(sender As Object, e As EventArgs) Handles LabelControl.Click
        MenuVertical.Show()
    End Sub
End Class