Public Class Login
    Protected Overrides Sub OnLoad(e As EventArgs)
        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\nickname.txt") Then
            TextBoxUsuari.Text = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\nickname.txt")
            CheckBoxRecordar.Checked = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuari.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxContrasenya.TextChanged

    End Sub

    Private Sub CheckBoxRecordar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRecordar.CheckedChanged

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim SQLCommands As New SQLCommands
        If (SQLCommands.AuthenticateUser(TextBoxUsuari.Text, TextBoxContrasenya.Text)) Then
            'logue correcto
            Globals.userCredentials = SQLCommands.SelectUserInfo(TextBoxUsuari.Text)
            If CheckBoxRecordar.Checked Then
                Interaction.SaveUserNickname(Globals.userCredentials.GetSetNickname)
            End If
        Else
            'logue incorrecto
        End If
    End Sub
End Class