Public Class MenuPrincipal
    Dim pos_menu As String
    Dim menu_desplegat As Boolean
    Private Sub desplegar_Click(sender As Object, e As EventArgs) Handles desplegar.Click
        If menu_desplegat = False Then
            desplegar.Image = My.Resources.arrows_left

            menu_desplegat = True
            MenuVertical.Width = 161
            LBImpressions.Visible = True
            LBImpressores.Visible = True
        Else
            desplegar.Image = My.Resources.arrows
            menu_desplegat = False
            MenuVertical.Width = 64
            LBImpressions.Visible = False
            LBImpressores.Visible = False
        End If


        'PictureBoxArrows.Image = AM3D.Resources.Img.arrows_left
    End Sub

    Private Sub LBControl_Click(sender As Object, e As EventArgs) Handles LBControl.Click
        MenuVertical.Show()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        menu_desplegat = False
        desplegar.Image = My.Resources.arrows
    End Sub

    Private Sub LBInici_Click(sender As Object, e As EventArgs) Handles LBInici.Click
        MenuVertical.Visible = False
    End Sub
End Class