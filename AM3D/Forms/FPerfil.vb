Public Class FPerfil
    Dim SQLCommands As SQLCommands = New SQLCommands()

    ''' <summary>
    ''' Al cargar este form cargara la información del usuario en los correspondientes textlabels.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuari As Usuaris
        Try
            usuari = SQLCommands.SelectUserFromDatabaseWhere(Globals.userCredentials.GetSetBaseDades, Globals.userCredentials.GetSetNickname)
            TBdni.Text = usuari.GetSetDNI
            TBNom.Text = usuari.GetSetNom
            TBCognom.Text = usuari.GetSetCognom
            TBEmail.Text = usuari.GetSetEmail
        Catch ex As Exception

        End Try
    End Sub

    ''' <summary>
    ''' Boton de actualización de datos del usuario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTActualitzar_Click(sender As Object, e As EventArgs) Handles BTActualitzar.Click
        Dim usuari As Usuaris
        Dim files As Integer
        usuari = New Usuaris(Globals.userCredentials.GetSetNickname, "", TBdni.Text, TBNom.Text, TBCognom.Text, TBEmail.Text)
        files = SQLCommands.InsertUserIfExistsUpdate(Globals.userCredentials.GetSetBaseDades, usuari)
        If files > 0 Then
            CBModificar.CheckState = CheckState.Unchecked
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGUserUpdateCorrect)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGUserUpdateCorrect)
            End If
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGUserUpdateError)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGUserUpdateError)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Al apretar el boton canviar, hara todas las comprobaciones y si las pasa cambiara la contraseña del usuario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTCanviarContra_Click(sender As Object, e As EventArgs) Handles BTCanviarContra.Click
        Dim afectat As Integer
        If TextBoxActual.Text IsNot "" And TextBoxNova.Text IsNot "" And TextBoxRepeteix.Text IsNot "" Then
            If SQLCommands.AuthenticateUser(Globals.userCredentials.GetSetNickname, TextBoxActual.Text) Then
                If TextBoxNova.Text.Equals(TextBoxRepeteix.Text) Then
                    afectat = SQLCommands.UpdateUserPassword(Globals.userCredentials.GetSetBaseDades, TextBoxNova.Text, Globals.userCredentials.GetSetNickname)
                    If afectat > 0 Then
                        If Globals.lang = "cat" Then
                            MenuPrincipal.showMSG(My.Resources.cat.MSGUserPasswordUpdateCorrect)
                        Else
                            MenuPrincipal.showMSG(My.Resources.eng.MSGUserPasswordUpdateCorrect)
                        End If
                    Else
                        If Globals.lang = "cat" Then
                            MenuPrincipal.showMSG(My.Resources.cat.MSGUserPasswordUpdateError)
                        Else
                            MenuPrincipal.showMSG(My.Resources.eng.MSGUserPasswordUpdateError)
                        End If
                    End If
                    TextBoxActual.Text = ""
                    TextBoxNova.Text = ""
                    TextBoxRepeteix.Text = ""
                Else
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.MSGUserRepetirError)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.MSGUserRepetirError)
                    End If
                End If
            Else
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGUserContrasenyaError)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGUserContrasenyaError)
                End If
            End If
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGRellenarError)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGRellenarError)
            End If
        End If

    End Sub

    ''' <summary>
    ''' Dependiendo del estado del chechbox modificar, se habilitara o no los campos para la modificación.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBModificar_CheckedChanged(sender As Object, e As EventArgs) Handles CBModificar.CheckedChanged
        If CBModificar.CheckState = CheckState.Checked Then
            TBdni.Enabled = True
            TBNom.Enabled = True
            TBCognom.Enabled = True
            TBEmail.Enabled = True
            BTActualitzar.Enabled = True
        ElseIf CBModificar.CheckState = CheckState.Unchecked Then
            TBdni.Enabled = False
            TBNom.Enabled = False
            TBCognom.Enabled = False
            TBEmail.Enabled = False
            BTActualitzar.Enabled = False
        End If
    End Sub

End Class