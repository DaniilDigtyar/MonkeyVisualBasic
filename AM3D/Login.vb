Public Class Login
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuari.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxContrasenya.TextChanged

    End Sub

    Private Sub CheckBoxRecordar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRecordar.CheckedChanged

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim authentication As New Authentication
        If (authentication.AuthenticateUser(TextBoxUsuari.Text, TextBoxContrasenya.Text)) Then
            'LOGUE CORRECTO
            MsgBox("Correcto")
        Else
            'LOGUE INCORRECTO
            MsgBox("Incorrecto")
        End If
    End Sub
End Class