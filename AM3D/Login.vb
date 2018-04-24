Public Class Login
    'Moviment de l'aplicacio amb el ratoli
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point
    Private Sub MenuSup_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuSup.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub MenuSup_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuSup.MouseMove
        If allowCoolMove = True Then
            Me.Location = New Point(Me.Location.X + e.X - myCoolPoint.X, Me.Location.Y + e.Y - myCoolPoint.Y)
        End If
    End Sub

    Private Sub MenuSup_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuSup.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
    End Sub

    'Entrar a l'app
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        MenuPrincipal.Show()
        Me.Hide()
    End Sub

    'Boto sortir
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    'Boto minimitzar
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class