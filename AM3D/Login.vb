Public Class Login
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBoxUsuari.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBoxContrasenya.TextChanged

    End Sub

    Private Sub CheckBoxRecordar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRecordar.CheckedChanged

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