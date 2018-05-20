Public Class ModificarUsuari
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point
    Dim SQLcommands As SQLCommands = New SQLCommands()

    Private Sub ModificarUsuari_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Me.Hide()
        TBNickname.Text = ""
        TBNom.Text = ""
        TBCongnom.Text = ""
        TBCorreu.Text = ""
        TBContrasenya.Text = ""
        TBRContrasenya.Text = ""
        TBNovaContraseña.Text = ""
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

    Private Sub BTModificar_Click(sender As Object, e As EventArgs) Handles BTModificar.Click
        Dim usuari As Usuaris
        Dim files As Integer


        usuari = New Usuaris(TBNickname.Text, TBContrasenya.Text, TBDni.Text, TBNom.Text, TBCongnom.Text, TBCorreu.Text)
        files = SQLcommands.InsertUserIfExistsUpdate(Globals.userCredentials.GetSetBaseDades, usuari)
        If files > 0 Then
            If Globals.lang = "cat" Then
                LabelInfo.Text = My.Resources.cat.MSGUserUpdateCorrect
            Else
                LabelInfo.Text = My.Resources.eng.MSGUserUpdateCorrect
            End If
        Else
            If Globals.lang = "cat" Then
                LabelInfo.Text = My.Resources.cat.MSGUserUpdateError
            Else
                LabelInfo.Text = My.Resources.eng.MSGUserUpdateError
            End If
        End If
    End Sub

    Private Sub ButtonModConstraseña_Click(sender As Object, e As EventArgs) Handles ButtonModConstraseña.Click
        Try
            Dim afectat As Integer
            If TBContrasenya.Text IsNot "" And TBRContrasenya.Text IsNot "" And TBNovaContraseña.Text IsNot "" Then

                If SQLcommands.AuthenticateUser(Globals.userCredentials.GetSetNickname, TBContrasenya.Text) Then
                    If TBNovaContraseña.Text.Equals(TBRContrasenya.Text) Then

                        afectat = SQLcommands.UpdateUserPassword(Globals.userCredentials.GetSetBaseDades, TBNovaContraseña.Text, Globals.userCredentials.GetSetNickname)
                        If afectat > 0 Then
                            If Globals.lang = "cat" Then
                                LabelInfoContraseña.Text = My.Resources.cat.MSGUserPasswordUpdateCorrect
                            Else
                                LabelInfoContraseña.Text = My.Resources.eng.MSGUserPasswordUpdateCorrect
                            End If
                        Else
                            If Globals.lang = "cat" Then
                                LabelInfoContraseña.Text = My.Resources.cat.MSGUserPasswordUpdateError
                            Else
                                LabelInfoContraseña.Text = My.Resources.eng.MSGUserPasswordUpdateError
                            End If
                        End If
                        TBContrasenya.Text = ""
                        TBNovaContraseña.Text = ""
                        TBRContrasenya.Text = ""
                    Else
                        If Globals.lang = "cat" Then
                            LabelInfoContraseña.Text = My.Resources.cat.MSGUserRepetirError
                        Else
                            LabelInfoContraseña.Text = My.Resources.eng.MSGUserRepetirError
                        End If
                    End If
                Else
                    If Globals.lang = "cat" Then
                        LabelInfoContraseña.Text = My.Resources.cat.MSGUserContrasenyaError
                    Else
                        LabelInfoContraseña.Text = My.Resources.eng.MSGUserContrasenyaError
                    End If
                End If
            Else
                If Globals.lang = "cat" Then
                    LabelInfoContraseña.Text = My.Resources.cat.MSGRellenarError
                Else
                    LabelInfoContraseña.Text = My.Resources.eng.MSGRellenarError
                End If
            End If


        Catch ex As Exception

        End Try
    End Sub
End Class