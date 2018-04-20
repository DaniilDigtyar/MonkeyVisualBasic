Public Class MenuPrincipal
    Dim pos_menu As String
    Dim menu_desplegat As Boolean
    Dim segundos
    Private Sub desplegar_Click(sender As Object, e As EventArgs) Handles desplegar.Click
        If menu_desplegat = False Then
            desplegar.Image = My.Resources.arrows_left
            menu_desplegat = True
            MenuVerticalControl.Width = 161
            LBImpressions.Visible = True
            LBImpressores.Visible = True
        Else
            desplegar.Image = My.Resources.arrows
            menu_desplegat = False
            MenuVerticalControl.Width = 64
            LBImpressions.Visible = False
            LBImpressores.Visible = False
        End If
        'PictureBoxArrows.Image = AM3D.Resources.Img.arrows_left
    End Sub

    Private Sub LBControl_Click(sender As Object, e As EventArgs) Handles LBControl.Click
        globals.menu = "control"
        desplegar.Image = My.Resources.arrows
        menu_desplegat = False
        MenuVerticalControl.Width = 64
        LBImpressions.Visible = False
        LBImpressores.Visible = False
        MenuVerticalControl.Show()
        MenuVerticalGestio.Hide()

    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Login.Close()
        globals.menu = "home"
        setLang()
        menu_desplegat = False
        desplegar.Image = My.Resources.arrows
    End Sub

    Private Sub LBInici_Click(sender As Object, e As EventArgs) Handles LBInici.Click
        globals.menu = "home"
        MenuVerticalControl.Visible = False
        MenuVerticalGestio.Visible = False
    End Sub

    Private Sub user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles user.KeyPress
        e.Handled = True
    End Sub

    Private Sub LBGestio_Click(sender As Object, e As EventArgs) Handles LBGestio.Click
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

    Function setLang()
        Dim opcio1 As String
        Dim opcio2 As String
        Dim opcio3 As String
        Dim opcio4 As String
        opcio1 = My.Resources.cat.opcioPerfil
        opcio2 = My.Resources.cat.opcioCambiarIdioma
        opcio3 = My.Resources.cat.opcioSortir
        opcio4 = My.Resources.cat.opcioGenerarEstadistiques
        LBControl.Text = My.Resources.cat.LBControl
        LBGestio.Text = My.Resources.cat.LBGestio
        LBUser.Text = globals.user
        LBImpressions.Text = My.Resources.cat.LBImpressions
        LBImpressores.Text = My.Resources.cat.LBImpressores
        user.Items.Add(opcio1)
        user.Items.Add(opcio2)
        user.Items.Add(opcio3)
        user.Items.Add(opcio4)
    End Function

    Private Sub user_SelectedIndexChanged(sender As Object, e As EventArgs) Handles user.SelectedIndexChanged
        If user.SelectedIndex = 2 Then
            Me.Close()
            Login.Show()
        End If
        If user.SelectedIndex = 0 Then

        End If
        If user.SelectedIndex = 1 Then

        End If
        If user.SelectedIndex = 3 Then
            If generarFitxers() Then

            Else
                showMSG("error")

            End If
        End If

    End Sub


    Function showMSG(msg As String)
        If msg = "error" Then
            globals.msgError = My.Resources.cat.ErrorFitxer
        End If
        Timer1.Interval = 100
        segundos = 0
        Timer1.Enabled = True
    End Function

    Function generarFitxers() As Boolean
        Return False

    End Function

    Private Sub desplegar2_Click(sender As Object, e As EventArgs) Handles desplegar2.Click

        If menu_desplegat = False Then
            desplegar2.Image = My.Resources.arrows_left
            menu_desplegat = True
            MenuVerticalGestio.Width = 161
            LBUsuaris.Visible = True
            LBBobines.Visible = True
            LBModelsCar.Visible = True
            LBGCode.Visible = True
        Else
            desplegar2.Image = My.Resources.arrows
            menu_desplegat = False
            MenuVerticalGestio.Width = 64
            LBUsuaris.Visible = False
            LBBobines.Visible = False
            LBModelsCar.Visible = False
            LBGCode.Visible = False
        End If
    End Sub

    Private Sub LBGCode_Click(sender As Object, e As EventArgs) Handles LBGCode.Click

    End Sub

    Private Sub LBModelsCar_Click(sender As Object, e As EventArgs) Handles LBModelsCar.Click

    End Sub

    Private Sub LBBobines_Click(sender As Object, e As EventArgs) Handles LBBobines.Click

    End Sub

    Private Sub LBUsuaris_Click(sender As Object, e As EventArgs) Handles LBUsuaris.Click

    End Sub

    Private Sub Usuaris_Click(sender As Object, e As EventArgs) Handles Usuaris.Click

    End Sub

    Private Sub Bobines_Click(sender As Object, e As EventArgs) Handles Bobines.Click

    End Sub

    Private Sub Models_Click(sender As Object, e As EventArgs) Handles Models.Click

    End Sub

    Private Sub Gcode_Click(sender As Object, e As EventArgs) Handles Gcode.Click

    End Sub

    Private Sub LBImpressions_Click(sender As Object, e As EventArgs) Handles LBImpressions.Click

    End Sub

    Private Sub LBImpressores_Click(sender As Object, e As EventArgs) Handles LBImpressores.Click

    End Sub

    Private Sub Impressions_Click(sender As Object, e As EventArgs) Handles Impressions.Click

    End Sub

    Private Sub Impressores_Click(sender As Object, e As EventArgs) Handles Impressores.Click

    End Sub

    Private Sub minimizar_Click(sender As Object, e As EventArgs) Handles minimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        segundos += 1
        If globals.menu = "home" Then
            MSGBox1.Visible = False
            MSGBox2.Visible = True
            LBMSG1.Visible = False
            LBMSG2.Text = globals.msgError
            LBMSG2.Visible = True
        Else
            MSGBox1.Visible = True
            MSGBox2.Visible = False
            LBMSG1.Text = globals.msgError
            LBMSG1.Visible = True
            LBMSG2.Visible = False
        End If
        If segundos = 60 Then
            Timer1.Enabled = False
            MSGBox2.Visible = False
            MSGBox1.Visible = False
            LBMSG1.Visible = False
            LBMSG2.Visible = False
        End If
    End Sub
End Class