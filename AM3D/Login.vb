Public Class Login
    'Moviment de l'aplicacio amb el ratoli
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point

    Protected Overrides Sub OnLoad(e As EventArgs)
        TextBoxContrasenya.Text = "12345dani" ' BORRAR

        CBIdioma.Items.Add("Català")
        CBIdioma.Items.Add("English")
        If Globals.lang = "cat" Then
            CBIdioma.Text = "Català"
        Else
            CBIdioma.Text = "English"
        End If

        If My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory + "\nickname.txt") Then
            TextBoxUsuari.Text = My.Computer.FileSystem.ReadAllText(My.Computer.FileSystem.CurrentDirectory + "\nickname.txt")
            CBRecordar.Checked = True
        End If
    End Sub

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

    'Boto sortir
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    'Boto minimitzar
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CBIdioma_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBIdioma.SelectedIndexChanged
        If CBIdioma.SelectedIndex = 0 Then
            globals.lang = "cat"
            Language.setLang()

        End If
        If CBIdioma.SelectedIndex = 1 Then
            globals.lang = "eng"
            Language.setLang()

        End If
    End Sub

    Private Sub CBIdioma_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBIdioma.KeyPress
        e.Handled = True
    End Sub
  
    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim SQLCommands As New SQLCommands
        Try
            TextBoxUsuari.Enabled = False
            TextBoxContrasenya.Enabled = False
            CBRecordar.Enabled = False
            ButtonLogin.Enabled = False

            If (SQLCommands.AuthenticateUser(TextBoxUsuari.Text, TextBoxContrasenya.Text)) Then
                'LOGUE CORRECTO
                Globals.userCredentials = SQLCommands.SelectUserInfo(TextBoxUsuari.Text)
                If CBRecordar.Checked Then
                    Interaction.SaveUserNickname(Globals.userCredentials.GetSetNickname)
                Else
                    TextBoxContrasenya.Text = ""
                End If
                TextBoxContrasenya.Text = ""
                LabelErrorLogin.Visible = False

                MenuPrincipal.Show()
                Me.Hide()
            Else
                LabelErrorLogin.Visible = True

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TextBoxUsuari.Enabled = True
        TextBoxContrasenya.Enabled = True
        CBRecordar.Enabled = True
        ButtonLogin.Enabled = True

    End Sub
End Class