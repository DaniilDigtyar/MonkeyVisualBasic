Public Class Login
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuari.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxContrasenya.TextChanged

    End Sub

    Private Sub CheckBoxRecordar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRecordar.CheckedChanged

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim SQLCommands As New SQLCommands
        If (SQLCommands.AuthenticateUser(TextBoxUsuari.Text, TextBoxContrasenya.Text)) Then
            'LOGUE CORRECTO
            SQLCommands.SelectAllFromTable(SQLCommands.SelectUserDatabase(TextBoxUsuari.Text), "bobines")
            MsgBox("Correcto") 'Borrar

        Else
            'LOGUE INCORRECTO
            MsgBox("Incorrecto") 'Borrar
        End If
    End Sub
End Class