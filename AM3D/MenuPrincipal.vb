Public Class MenuPrincipal
    Dim pos_menu As String
    Dim menu_desplegat As Boolean
    Dim segundos

    'Codi que s'executa quan es mostra per primer cop aquest form
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBUser.Text = Globals.userCredentials.GetSetNickname
        Globals.menu = "home"
        Language.setLang()
        menu_desplegat = False
        desplegar.Image = My.Resources.arrows
    End Sub

    'Tancar
    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
        Login.Close()
    End Sub

    'Minimitzar
    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


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

    'Boto per a desplegar i fer mes gran el menu lateral de Control
    Private Sub desplegar_Click(sender As Object, e As EventArgs) Handles desplegar.Click
        If menu_desplegat = False Then
            desplegar.Image = My.Resources.arrows_left
            menu_desplegat = True
            MenuVerticalControl.Width = 161
            PCont.Width = PCont.Width - 97
            PCont.Left = PCont.Left + 97
            LBImpressions.Visible = True
            LBImpressores.Visible = True
        Else
            desplegar.Image = My.Resources.arrows
            menu_desplegat = False
            MenuVerticalControl.Width = 64
            PCont.Left = PCont.Left - 97
            PCont.Width = PCont.Width + 97
            LBImpressions.Visible = False
            LBImpressores.Visible = False
        End If
        'PictureBoxArrows.Image = AM3D.Resources.Img.arrows_left
    End Sub

    'Boto per a desplegar i fer mes gran el menu lateral de Gestio
    Private Sub desplegar2_Click(sender As Object, e As EventArgs) Handles desplegar2.Click
        If menu_desplegat = False Then
            desplegar2.Image = My.Resources.arrows_left
            menu_desplegat = True
            MenuVerticalGestio.Width = 161
            LBUsuaris.Visible = True
            LBBobines.Visible = True
            LBModelsCar.Visible = True
            LBGCode.Visible = True
            PCont.Width = PCont.Width - 97
            PCont.Left = PCont.Left + 97

        Else
            desplegar2.Image = My.Resources.arrows
            menu_desplegat = False
            MenuVerticalGestio.Width = 64
            PCont.Width = PCont.Width + 97
            PCont.Left = PCont.Left - 97
            LBUsuaris.Visible = False
            LBBobines.Visible = False
            LBModelsCar.Visible = False
            LBGCode.Visible = False
        End If
    End Sub

    'Apartat menu Control
    Private Sub LBControl_Click(sender As Object, e As EventArgs) Handles LBControl.Click
        If menu_desplegat = True Then
            PCont.Width = PCont.Width + 97
            PCont.Left = PCont.Left - 97
        End If

        LBControl.BackColor = Color.Gray
        LBInici.BackColor = Color.Black
        LBGestio.BackColor = Color.Black
        globals.menu = "control"
        desplegar.Image = My.Resources.arrows
        menu_desplegat = False
        MenuVerticalControl.Width = 64
        LBImpressions.Visible = False
        LBImpressores.Visible = False
        MenuVerticalControl.Show()
        MenuVerticalGestio.Hide()
    End Sub
    'Apartat menu Inici
    Public Sub LBInici_Click(sender As Object, e As EventArgs) Handles LBInici.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.DarkGray
        LBControl.BackColor = Color.Black
        LBInici.BackColor = Color.Gray
        LBGestio.BackColor = Color.Black
        PCont.Width = 826
        PCont.Left = 72
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FInici.TopLevel = False
        PCont.Controls.Add(FInici)
        FInici.Show()
        Globals.menu = "home"
        MenuVerticalControl.Visible = False
        MenuVerticalGestio.Visible = False
    End Sub

    'Apartat menu Gestio
    Private Sub LBGestio_Click(sender As Object, e As EventArgs) Handles LBGestio.Click
        If menu_desplegat = True Then
            PCont.Width = PCont.Width + 97
            PCont.Left = PCont.Left - 97
        End If
        LBControl.BackColor = Color.Black
        LBGestio.BackColor = Color.Gray
        LBInici.BackColor = Color.Black
        globals.menu = "gestio"
        desplegar2.Image = My.Resources.arrows
        menu_desplegat = False
        MenuVerticalGestio.Width = 64
        LBUsuaris.Visible = False
        LBBobines.Visible = False
        LBModelsCar.Visible = False
        LBGCode.Visible = False
        MenuVerticalControl.Hide()
        MenuVerticalGestio.Show()
    End Sub

    'DropDown
    Private Sub user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles user.KeyPress
        e.Handled = True
    End Sub

    'Quan es seleciona algo del DropDown
    Private Sub user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles user.SelectedIndexChanged
        'LogOut
        If user.SelectedIndex = 2 Then
            Usuaris.BackColor = Color.DarkGray
            Bobines.BackColor = Color.DarkGray
            Gcode.BackColor = Color.DarkGray
            Models.BackColor = Color.DarkGray
            Impressions.BackColor = Color.DarkGray
            Impressores.BackColor = Color.DarkGray
            LBControl.BackColor = Color.Black
            LBInici.BackColor = Color.Black
            LBGestio.BackColor = Color.Black
            MenuVerticalGestio.Visible = False
            MenuVerticalControl.Visible = False
            Me.Close()
            Login.Show()
        End If
        'Perfil
        If user.SelectedIndex = 0 Then
            Usuaris.BackColor = Color.DarkGray
            Bobines.BackColor = Color.DarkGray
            Gcode.BackColor = Color.DarkGray
            Models.BackColor = Color.DarkGray
            Impressions.BackColor = Color.DarkGray
            Impressores.BackColor = Color.DarkGray
            LBControl.BackColor = Color.Black
            LBInici.BackColor = Color.Black
            LBGestio.BackColor = Color.Black
            MenuVerticalGestio.Visible = False
            MenuVerticalControl.Visible = False
            FUsuaris.Hide()
            FBobines.Hide()
            FCambIdiom.Hide()
            FGcode.Hide()
            FImpressions.Hide()
            FImpressores.Hide()
            FInici.Hide()
            FModels.Hide()
            FPerfil.Hide()
            FUsuaris.Hide()
            FPerfil.TopLevel = False
            PCont.Controls.Add(FPerfil)
            FPerfil.Show()
        End If
        'Canviar idioma
        If user.SelectedIndex = 1 Then
            Usuaris.BackColor = Color.DarkGray
            Bobines.BackColor = Color.DarkGray
            Gcode.BackColor = Color.DarkGray
            Models.BackColor = Color.DarkGray
            Impressions.BackColor = Color.DarkGray
            Impressores.BackColor = Color.DarkGray
            LBControl.BackColor = Color.Black
            LBInici.BackColor = Color.Black
            LBGestio.BackColor = Color.Black
            MenuVerticalGestio.Visible = False
            MenuVerticalControl.Visible = False
            FUsuaris.Hide()
            FBobines.Hide()
            FCambIdiom.Hide()
            FGcode.Hide()
            FImpressions.Hide()
            FImpressores.Hide()
            FInici.Hide()
            FModels.Hide()
            FPerfil.Hide()
            FUsuaris.Hide()
            FCambIdiom.TopLevel = False
            PCont.Controls.Add(FCambIdiom)
            FCambIdiom.Show()
        End If
        'Generar Firxer
        If user.SelectedIndex = 3 Then
            Usuaris.BackColor = Color.DarkGray
            Bobines.BackColor = Color.DarkGray
            Gcode.BackColor = Color.DarkGray
            Models.BackColor = Color.DarkGray
            Impressions.BackColor = Color.DarkGray
            Impressores.BackColor = Color.DarkGray
            LBControl.BackColor = Color.Black
            LBInici.BackColor = Color.Black
            LBGestio.BackColor = Color.Black
            MenuVerticalGestio.Visible = False
            MenuVerticalControl.Visible = False
            If Interaction.GenerateStadisticsFiles() Then
                If Globals.lang = "cat" Then
                    showMSG(My.Resources.cat.MFicheroCorrectos.ToString)
                Else
                    showMSG(My.Resources.eng.MFicheroCorrectos)
                End If

            Else
                If Globals.lang = "cat" Then
                    showMSG(My.Resources.cat.MFicheroError)
                Else
                    showMSG(My.Resources.eng.MFicheroError)
                End If

            End If
        End If

    End Sub

    'Apartat GCODE
    Private Sub LBGCode_Click(sender As Object, e As EventArgs) Handles LBGCode.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.Gray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FGcode.TopLevel = False
        PCont.Controls.Add(FGcode)
        FGcode.Show()
    End Sub

    'Apartat MODELS
    Private Sub LBModelsCar_Click(sender As Object, e As EventArgs) Handles LBModelsCar.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.Gray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FModels.TopLevel = False
        PCont.Controls.Add(FModels)
        FModels.Show()
    End Sub

    'Apartat Bobines
    Private Sub LBBobines_Click(sender As Object, e As EventArgs) Handles LBBobines.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.Gray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FBobines.TopLevel = False
        PCont.Controls.Add(FBobines)
        FBobines.Show()
    End Sub

    'Apartat USUARIS
    Private Sub LBUsuaris_Click(sender As Object, e As EventArgs) Handles LBUsuaris.Click
        Usuaris.BackColor = Color.Gray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FUsuaris.TopLevel = False
        PCont.Controls.Add(FUsuaris)
        FUsuaris.Show()
    End Sub

    'Apartat USUARIS
    Private Sub Usuaris_Click(sender As Object, e As EventArgs) Handles Usuaris.Click
        Usuaris.BackColor = Color.Gray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FUsuaris.TopLevel = False
        PCont.Controls.Add(FUsuaris)
        FUsuaris.Show()
    End Sub

    'Apartat BOBINES
    Private Sub Bobines_Click(sender As Object, e As EventArgs) Handles Bobines.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.Gray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FBobines.TopLevel = False
        PCont.Controls.Add(FBobines)
        FBobines.Show()
    End Sub

    'Apartat MODELS
    Private Sub Models_Click(sender As Object, e As EventArgs) Handles Models.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.Gray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FModels.TopLevel = False
        PCont.Controls.Add(FModels)
        FModels.Show()
    End Sub

    'Apartat GCODE
    Private Sub Gcode_Click(sender As Object, e As EventArgs) Handles Gcode.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.Gray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FGcode.TopLevel = False
        PCont.Controls.Add(FGcode)
        FGcode.Show()
    End Sub

    'Apartat IMORESSIONS
    Private Sub LBImpressions_Click(sender As Object, e As EventArgs) Handles LBImpressions.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.Gray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FImpressions.TopLevel = False
        PCont.Controls.Add(FImpressions)
        FImpressions.Show()
    End Sub

    'Apartat IMPRESSORES
    Private Sub LBImpressores_Click(sender As Object, e As EventArgs) Handles LBImpressores.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.Gray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FImpressores.TopLevel = False
        PCont.Controls.Add(FImpressores)
        FImpressores.Show()
    End Sub

    'Apartat IMPRESSIONS
    Private Sub Impressions_Click(sender As Object, e As EventArgs) Handles Impressions.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.Gray
        Impressores.BackColor = Color.DarkGray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FImpressions.TopLevel = False
        PCont.Controls.Add(FImpressions)
        FImpressions.Show()
    End Sub

    'Apartat IMPRESSORES
    Private Sub Impressores_Click(sender As Object, e As EventArgs) Handles Impressores.Click
        Usuaris.BackColor = Color.DarkGray
        Bobines.BackColor = Color.DarkGray
        Gcode.BackColor = Color.DarkGray
        Models.BackColor = Color.DarkGray
        Impressions.BackColor = Color.DarkGray
        Impressores.BackColor = Color.Gray
        FUsuaris.Hide()
        FBobines.Hide()
        FCambIdiom.Hide()
        FGcode.Hide()
        FImpressions.Hide()
        FImpressores.Hide()
        FInici.Hide()
        FModels.Hide()
        FPerfil.Hide()
        FUsuaris.Hide()
        FImpressores.TopLevel = False
        PCont.Controls.Add(FImpressores)
        FImpressores.Show()
    End Sub

    'Timer que mostrar el missatge d'error
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        segundos += 1
        If globals.menu = "home" Then
            MSGBox1.Visible = False
            MSGBox3.Visible = False
            MSGBox2.Visible = True
            LBMSG1.Visible = False
            LBMSG3.Visible = False
            LBMSG2.Text = globals.msgError
            LBMSG2.Visible = True
        Else
            If menu_desplegat = True Then
                MSGBox1.Visible = False
                MSGBox3.Visible = True
                MSGBox2.Visible = False
                LBMSG3.Text = globals.msgError
                LBMSG1.Visible = False
                LBMSG3.Visible = True
                LBMSG2.Visible = False
            Else
                MSGBox1.Visible = True
                MSGBox3.Visible = False
                MSGBox2.Visible = False
                LBMSG1.Text = globals.msgError
                LBMSG1.Visible = True
                LBMSG3.Visible = False
                LBMSG2.Visible = False
            End If
        End If
        If segundos = 60 Then
            Timer1.Enabled = False
            MSGBox2.Visible = False
            MSGBox1.Visible = False
            MSGBox3.Visible = False
            LBMSG1.Visible = False
            LBMSG2.Visible = False
            LBMSG3.Visible = False
        End If
    End Sub

    'Funcio que mostrar un missatge de error depenent de la variable msg que li passem per parametre. Tambe activa el timer
    Function showMSG(msg As String)
        Globals.msgError = msg
        Timer1.Interval = 100
        segundos = 0
        Timer1.Enabled = True
    End Function

End Class