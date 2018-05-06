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

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBIdioma.Items.Add("Català")
        CBIdioma.Items.Add("English")
        If globals.lang = "cat" Then
            CBIdioma.Text = "Català"
        Else
            CBIdioma.Text = "English"
        End If
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
        Dim userCredentials As Users
        Dim listaUsuaris As HashSet(Of Tenen) = New HashSet(Of Tenen)
        Dim listaPermisos As HashSet(Of Permisos)

        Dim Usuario As Tenen = New Tenen("dani", "a")
        Dim Usuario2 As Tenen = New Tenen("dani", "a")

        listaUsuaris.Add(Usuario2)

        listaUsuaris.Add(Usuario)

        If listaUsuaris(0).GetHashCode.Equals(Usuario.GetHashCode) Then
            MsgBox("Iguales")
        Else
            MsgBox("Diferentes")
        End If

        'If (SQLCommands.AuthenticateUser(TextBoxUsuari.Text, TextBoxContrasenya.Text)) Then
        '    'LOGUE CORRECTO
        '    userCredentials = SQLCommands.SelectUserInfo(TextBoxUsuari.Text)
        '    listaUsuaris = SQLCommands.SelectAllUsersFromDatabase(userCredentials.GetSetBaseDades)
        '    listaPermisos = SQLCommands.SelectAllPermisosFromDatabase(userCredentials.GetSetBaseDades)
        '    For i As Integer = 0 To listaUsuaris.Count() - 1
        '        Console.WriteLine(listaUsuaris(i).GetSetNickname)
        '    Next i

        '    For i As Integer = 0 To listaPermisos.Count() - 1
        '        Console.WriteLine(listaPermisos(i).GetSetCodiPermisos)
        '    Next i
        '    MsgBox("Correcto") 'Borrar

        'Else
        '    'LOGUE INCORRECTO
        '    MsgBox("Incorrecto") 'Borrar
        'End If
    End Sub
End Class