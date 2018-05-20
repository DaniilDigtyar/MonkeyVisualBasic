<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MenuVerticalControl = New System.Windows.Forms.Panel()
        Me.LBImpressions = New System.Windows.Forms.Label()
        Me.Impressions = New System.Windows.Forms.PictureBox()
        Me.LBImpressores = New System.Windows.Forms.Label()
        Me.Impressores = New System.Windows.Forms.PictureBox()
        Me.desplegar = New System.Windows.Forms.PictureBox()
        Me.MenuVerticalGestio = New System.Windows.Forms.Panel()
        Me.LBGCode = New System.Windows.Forms.Label()
        Me.LBModelsCar = New System.Windows.Forms.Label()
        Me.Gcode = New System.Windows.Forms.PictureBox()
        Me.Models = New System.Windows.Forms.PictureBox()
        Me.LBBobines = New System.Windows.Forms.Label()
        Me.Bobines = New System.Windows.Forms.PictureBox()
        Me.LBUsuaris = New System.Windows.Forms.Label()
        Me.Usuaris = New System.Windows.Forms.PictureBox()
        Me.desplegar2 = New System.Windows.Forms.PictureBox()
        Me.LBInici = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LBGestio = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.ComboBox()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.LBControl = New System.Windows.Forms.Label()
        Me.LBUser = New System.Windows.Forms.Label()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.MSGBox1 = New System.Windows.Forms.Panel()
        Me.LBMSG1 = New System.Windows.Forms.Label()
        Me.MSGBox2 = New System.Windows.Forms.Panel()
        Me.LBMSG2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MSGBox3 = New System.Windows.Forms.Panel()
        Me.LBMSG3 = New System.Windows.Forms.Label()
        Me.PCont = New System.Windows.Forms.Panel()
        Me.MenuVerticalControl.SuspendLayout()
        CType(Me.Impressions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Impressores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desplegar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVerticalGestio.SuspendLayout()
        CType(Me.Gcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Models, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bobines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usuaris, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desplegar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.MenuSup.SuspendLayout()
        Me.MSGBox1.SuspendLayout()
        Me.MSGBox2.SuspendLayout()
        Me.MSGBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuVerticalControl
        '
        Me.MenuVerticalControl.BackColor = System.Drawing.Color.DarkGray
        Me.MenuVerticalControl.Controls.Add(Me.LBImpressions)
        Me.MenuVerticalControl.Controls.Add(Me.Impressions)
        Me.MenuVerticalControl.Controls.Add(Me.LBImpressores)
        Me.MenuVerticalControl.Controls.Add(Me.Impressores)
        Me.MenuVerticalControl.Controls.Add(Me.desplegar)
        Me.MenuVerticalControl.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuVerticalControl.Location = New System.Drawing.Point(0, 36)
        Me.MenuVerticalControl.Name = "MenuVerticalControl"
        Me.MenuVerticalControl.Size = New System.Drawing.Size(64, 554)
        Me.MenuVerticalControl.TabIndex = 1
        Me.MenuVerticalControl.Visible = False
        '
        'LBImpressions
        '
        Me.LBImpressions.AutoSize = True
        Me.LBImpressions.BackColor = System.Drawing.Color.Transparent
        Me.LBImpressions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBImpressions.ForeColor = System.Drawing.Color.Black
        Me.LBImpressions.Location = New System.Drawing.Point(62, 111)
        Me.LBImpressions.Name = "LBImpressions"
        Me.LBImpressions.Size = New System.Drawing.Size(83, 17)
        Me.LBImpressions.TabIndex = 2
        Me.LBImpressions.Text = "Impressions"
        Me.LBImpressions.Visible = False
        '
        'Impressions
        '
        Me.Impressions.Image = CType(resources.GetObject("Impressions.Image"), System.Drawing.Image)
        Me.Impressions.Location = New System.Drawing.Point(7, 93)
        Me.Impressions.Name = "Impressions"
        Me.Impressions.Size = New System.Drawing.Size(50, 53)
        Me.Impressions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Impressions.TabIndex = 2
        Me.Impressions.TabStop = False
        '
        'LBImpressores
        '
        Me.LBImpressores.AutoSize = True
        Me.LBImpressores.BackColor = System.Drawing.Color.Transparent
        Me.LBImpressores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBImpressores.ForeColor = System.Drawing.Color.Black
        Me.LBImpressores.Location = New System.Drawing.Point(62, 38)
        Me.LBImpressores.Name = "LBImpressores"
        Me.LBImpressores.Size = New System.Drawing.Size(85, 17)
        Me.LBImpressores.TabIndex = 1
        Me.LBImpressores.Text = "Impressores"
        Me.LBImpressores.Visible = False
        '
        'Impressores
        '
        Me.Impressores.Image = CType(resources.GetObject("Impressores.Image"), System.Drawing.Image)
        Me.Impressores.Location = New System.Drawing.Point(7, 21)
        Me.Impressores.Name = "Impressores"
        Me.Impressores.Size = New System.Drawing.Size(50, 53)
        Me.Impressores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Impressores.TabIndex = 1
        Me.Impressores.TabStop = False
        '
        'desplegar
        '
        Me.desplegar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.desplegar.Image = Global.AM3D.My.Resources.Resources.arrows
        Me.desplegar.Location = New System.Drawing.Point(7, 512)
        Me.desplegar.Name = "desplegar"
        Me.desplegar.Size = New System.Drawing.Size(50, 39)
        Me.desplegar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.desplegar.TabIndex = 0
        Me.desplegar.TabStop = False
        '
        'MenuVerticalGestio
        '
        Me.MenuVerticalGestio.BackColor = System.Drawing.Color.DarkGray
        Me.MenuVerticalGestio.Controls.Add(Me.LBGCode)
        Me.MenuVerticalGestio.Controls.Add(Me.LBModelsCar)
        Me.MenuVerticalGestio.Controls.Add(Me.Gcode)
        Me.MenuVerticalGestio.Controls.Add(Me.Models)
        Me.MenuVerticalGestio.Controls.Add(Me.LBBobines)
        Me.MenuVerticalGestio.Controls.Add(Me.Bobines)
        Me.MenuVerticalGestio.Controls.Add(Me.LBUsuaris)
        Me.MenuVerticalGestio.Controls.Add(Me.Usuaris)
        Me.MenuVerticalGestio.Controls.Add(Me.desplegar2)
        Me.MenuVerticalGestio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuVerticalGestio.Location = New System.Drawing.Point(0, 36)
        Me.MenuVerticalGestio.Name = "MenuVerticalGestio"
        Me.MenuVerticalGestio.Size = New System.Drawing.Size(64, 554)
        Me.MenuVerticalGestio.TabIndex = 3
        Me.MenuVerticalGestio.Visible = False
        '
        'LBGCode
        '
        Me.LBGCode.AutoSize = True
        Me.LBGCode.BackColor = System.Drawing.Color.Transparent
        Me.LBGCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBGCode.ForeColor = System.Drawing.Color.Black
        Me.LBGCode.Location = New System.Drawing.Point(62, 252)
        Me.LBGCode.Name = "LBGCode"
        Me.LBGCode.Size = New System.Drawing.Size(52, 17)
        Me.LBGCode.TabIndex = 6
        Me.LBGCode.Text = "GCode"
        Me.LBGCode.Visible = False
        '
        'LBModelsCar
        '
        Me.LBModelsCar.AutoSize = True
        Me.LBModelsCar.BackColor = System.Drawing.Color.Transparent
        Me.LBModelsCar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBModelsCar.ForeColor = System.Drawing.Color.Black
        Me.LBModelsCar.Location = New System.Drawing.Point(62, 181)
        Me.LBModelsCar.Name = "LBModelsCar"
        Me.LBModelsCar.Size = New System.Drawing.Size(53, 17)
        Me.LBModelsCar.TabIndex = 5
        Me.LBModelsCar.Text = "Models"
        Me.LBModelsCar.Visible = False
        '
        'Gcode
        '
        Me.Gcode.Image = CType(resources.GetObject("Gcode.Image"), System.Drawing.Image)
        Me.Gcode.Location = New System.Drawing.Point(7, 231)
        Me.Gcode.Name = "Gcode"
        Me.Gcode.Size = New System.Drawing.Size(50, 53)
        Me.Gcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Gcode.TabIndex = 4
        Me.Gcode.TabStop = False
        '
        'Models
        '
        Me.Models.Image = CType(resources.GetObject("Models.Image"), System.Drawing.Image)
        Me.Models.Location = New System.Drawing.Point(7, 162)
        Me.Models.Name = "Models"
        Me.Models.Size = New System.Drawing.Size(50, 53)
        Me.Models.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Models.TabIndex = 3
        Me.Models.TabStop = False
        '
        'LBBobines
        '
        Me.LBBobines.AutoSize = True
        Me.LBBobines.BackColor = System.Drawing.Color.Transparent
        Me.LBBobines.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBBobines.ForeColor = System.Drawing.Color.Black
        Me.LBBobines.Location = New System.Drawing.Point(62, 111)
        Me.LBBobines.Name = "LBBobines"
        Me.LBBobines.Size = New System.Drawing.Size(59, 17)
        Me.LBBobines.TabIndex = 2
        Me.LBBobines.Text = "Bobines"
        Me.LBBobines.Visible = False
        '
        'Bobines
        '
        Me.Bobines.Image = CType(resources.GetObject("Bobines.Image"), System.Drawing.Image)
        Me.Bobines.Location = New System.Drawing.Point(7, 93)
        Me.Bobines.Name = "Bobines"
        Me.Bobines.Size = New System.Drawing.Size(50, 53)
        Me.Bobines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bobines.TabIndex = 2
        Me.Bobines.TabStop = False
        '
        'LBUsuaris
        '
        Me.LBUsuaris.AutoSize = True
        Me.LBUsuaris.BackColor = System.Drawing.Color.Transparent
        Me.LBUsuaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUsuaris.ForeColor = System.Drawing.Color.Black
        Me.LBUsuaris.Location = New System.Drawing.Point(62, 38)
        Me.LBUsuaris.Name = "LBUsuaris"
        Me.LBUsuaris.Size = New System.Drawing.Size(56, 17)
        Me.LBUsuaris.TabIndex = 1
        Me.LBUsuaris.Text = "Usuaris"
        Me.LBUsuaris.Visible = False
        '
        'Usuaris
        '
        Me.Usuaris.Image = CType(resources.GetObject("Usuaris.Image"), System.Drawing.Image)
        Me.Usuaris.Location = New System.Drawing.Point(7, 21)
        Me.Usuaris.Name = "Usuaris"
        Me.Usuaris.Size = New System.Drawing.Size(50, 53)
        Me.Usuaris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Usuaris.TabIndex = 1
        Me.Usuaris.TabStop = False
        '
        'desplegar2
        '
        Me.desplegar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.desplegar2.Image = Global.AM3D.My.Resources.Resources.arrows
        Me.desplegar2.Location = New System.Drawing.Point(7, 512)
        Me.desplegar2.Name = "desplegar2"
        Me.desplegar2.Size = New System.Drawing.Size(50, 39)
        Me.desplegar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.desplegar2.TabIndex = 0
        Me.desplegar2.TabStop = False
        '
        'LBInici
        '
        Me.LBInici.AutoSize = True
        Me.LBInici.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBInici.ForeColor = System.Drawing.Color.White
        Me.LBInici.Location = New System.Drawing.Point(33, 6)
        Me.LBInici.Name = "LBInici"
        Me.LBInici.Size = New System.Drawing.Size(50, 25)
        Me.LBInici.TabIndex = 0
        Me.LBInici.Text = "Inici"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'minimizar
        '
        Me.minimizar.Image = CType(resources.GetObject("minimizar.Image"), System.Drawing.Image)
        Me.minimizar.Location = New System.Drawing.Point(832, 6)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(29, 27)
        Me.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimizar.TabIndex = 6
        Me.minimizar.TabStop = False
        '
        'cerrar
        '
        Me.cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cerrar.Image = CType(resources.GetObject("cerrar.Image"), System.Drawing.Image)
        Me.cerrar.Location = New System.Drawing.Point(867, 6)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(28, 27)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 5
        Me.cerrar.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.LBGestio)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(223, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(139, 33)
        Me.Panel4.TabIndex = 8
        '
        'LBGestio
        '
        Me.LBGestio.AutoSize = True
        Me.LBGestio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBGestio.ForeColor = System.Drawing.Color.White
        Me.LBGestio.Location = New System.Drawing.Point(3, 6)
        Me.LBGestio.Name = "LBGestio"
        Me.LBGestio.Size = New System.Drawing.Size(74, 25)
        Me.LBGestio.TabIndex = 2
        Me.LBGestio.Text = "Gestió"
        '
        'user
        '
        Me.user.BackColor = System.Drawing.SystemColors.Menu
        Me.user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.user.FormattingEnabled = True
        Me.user.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.user.Location = New System.Drawing.Point(641, 9)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(114, 21)
        Me.user.TabIndex = 3
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Controls.Add(Me.LBControl)
        Me.MenuSup.Controls.Add(Me.LBUser)
        Me.MenuSup.Controls.Add(Me.user)
        Me.MenuSup.Controls.Add(Me.Panel4)
        Me.MenuSup.Controls.Add(Me.PanelControl)
        Me.MenuSup.Controls.Add(Me.cerrar)
        Me.MenuSup.Controls.Add(Me.minimizar)
        Me.MenuSup.Controls.Add(Me.PictureBox1)
        Me.MenuSup.Controls.Add(Me.LBInici)
        Me.MenuSup.Location = New System.Drawing.Point(0, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(898, 36)
        Me.MenuSup.TabIndex = 0
        '
        'LBControl
        '
        Me.LBControl.AutoSize = True
        Me.LBControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBControl.ForeColor = System.Drawing.Color.White
        Me.LBControl.Location = New System.Drawing.Point(117, 6)
        Me.LBControl.Name = "LBControl"
        Me.LBControl.Size = New System.Drawing.Size(81, 25)
        Me.LBControl.TabIndex = 1
        Me.LBControl.Text = "Control"
        '
        'LBUser
        '
        Me.LBUser.AutoSize = True
        Me.LBUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUser.ForeColor = System.Drawing.Color.White
        Me.LBUser.Location = New System.Drawing.Point(576, 10)
        Me.LBUser.Name = "LBUser"
        Me.LBUser.Size = New System.Drawing.Size(41, 15)
        Me.LBUser.TabIndex = 1
        Me.LBUser.Text = "USER"
        '
        'PanelControl
        '
        Me.PanelControl.Location = New System.Drawing.Point(117, 2)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(82, 33)
        Me.PanelControl.TabIndex = 7
        '
        'MSGBox1
        '
        Me.MSGBox1.BackColor = System.Drawing.Color.DarkRed
        Me.MSGBox1.Controls.Add(Me.LBMSG1)
        Me.MSGBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MSGBox1.Location = New System.Drawing.Point(63, 563)
        Me.MSGBox1.Name = "MSGBox1"
        Me.MSGBox1.Size = New System.Drawing.Size(835, 27)
        Me.MSGBox1.TabIndex = 4
        Me.MSGBox1.Visible = False
        '
        'LBMSG1
        '
        Me.LBMSG1.AutoSize = True
        Me.LBMSG1.Location = New System.Drawing.Point(6, 8)
        Me.LBMSG1.Name = "LBMSG1"
        Me.LBMSG1.Size = New System.Drawing.Size(31, 13)
        Me.LBMSG1.TabIndex = 0
        Me.LBMSG1.Text = "MSG"
        Me.LBMSG1.Visible = False
        '
        'MSGBox2
        '
        Me.MSGBox2.BackColor = System.Drawing.Color.DarkRed
        Me.MSGBox2.Controls.Add(Me.LBMSG2)
        Me.MSGBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MSGBox2.Location = New System.Drawing.Point(0, 563)
        Me.MSGBox2.Name = "MSGBox2"
        Me.MSGBox2.Size = New System.Drawing.Size(898, 27)
        Me.MSGBox2.TabIndex = 5
        Me.MSGBox2.Visible = False
        '
        'LBMSG2
        '
        Me.LBMSG2.AutoSize = True
        Me.LBMSG2.Location = New System.Drawing.Point(6, 8)
        Me.LBMSG2.Name = "LBMSG2"
        Me.LBMSG2.Size = New System.Drawing.Size(31, 13)
        Me.LBMSG2.TabIndex = 0
        Me.LBMSG2.Text = "MSG"
        Me.LBMSG2.Visible = False
        '
        'Timer1
        '
        '
        'MSGBox3
        '
        Me.MSGBox3.BackColor = System.Drawing.Color.DarkRed
        Me.MSGBox3.Controls.Add(Me.LBMSG3)
        Me.MSGBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MSGBox3.Location = New System.Drawing.Point(159, 563)
        Me.MSGBox3.Name = "MSGBox3"
        Me.MSGBox3.Size = New System.Drawing.Size(739, 27)
        Me.MSGBox3.TabIndex = 6
        Me.MSGBox3.Visible = False
        '
        'LBMSG3
        '
        Me.LBMSG3.AutoSize = True
        Me.LBMSG3.Location = New System.Drawing.Point(6, 8)
        Me.LBMSG3.Name = "LBMSG3"
        Me.LBMSG3.Size = New System.Drawing.Size(31, 13)
        Me.LBMSG3.TabIndex = 0
        Me.LBMSG3.Text = "MSG"
        Me.LBMSG3.Visible = False
        '
        'PCont
        '
        Me.PCont.BackColor = System.Drawing.Color.White
        Me.PCont.Location = New System.Drawing.Point(72, 36)
        Me.PCont.Name = "PCont"
        Me.PCont.Size = New System.Drawing.Size(826, 521)
        Me.PCont.TabIndex = 7
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(898, 590)
        Me.Controls.Add(Me.MSGBox3)
        Me.Controls.Add(Me.MSGBox2)
        Me.Controls.Add(Me.MSGBox1)
        Me.Controls.Add(Me.MenuVerticalGestio)
        Me.Controls.Add(Me.MenuVerticalControl)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.PCont)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu"
        Me.MenuVerticalControl.ResumeLayout(False)
        Me.MenuVerticalControl.PerformLayout()
        CType(Me.Impressions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Impressores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desplegar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVerticalGestio.ResumeLayout(False)
        Me.MenuVerticalGestio.PerformLayout()
        CType(Me.Gcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Models, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bobines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usuaris, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desplegar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.MenuSup.ResumeLayout(False)
        Me.MenuSup.PerformLayout()
        Me.MSGBox1.ResumeLayout(False)
        Me.MSGBox1.PerformLayout()
        Me.MSGBox2.ResumeLayout(False)
        Me.MSGBox2.PerformLayout()
        Me.MSGBox3.ResumeLayout(False)
        Me.MSGBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuVerticalControl As Panel
    Friend WithEvents desplegar As PictureBox
    Friend WithEvents Impressions As PictureBox
    Friend WithEvents Impressores As PictureBox
    Friend WithEvents LBImpressores As Label
    Friend WithEvents LBImpressions As Label
    Friend WithEvents MenuVerticalGestio As Panel
    Friend WithEvents LBGCode As Label
    Friend WithEvents LBModelsCar As Label
    Friend WithEvents Gcode As PictureBox
    Friend WithEvents Models As PictureBox
    Friend WithEvents LBBobines As Label
    Friend WithEvents Bobines As PictureBox
    Friend WithEvents LBUsuaris As Label
    Friend WithEvents Usuaris As PictureBox
    Friend WithEvents desplegar2 As PictureBox
    Friend WithEvents LBInici As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents cerrar As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LBGestio As Label
    Friend WithEvents user As ComboBox
    Friend WithEvents MenuSup As Panel
    Friend WithEvents LBUser As Label
    Friend WithEvents PanelControl As Panel
    Friend WithEvents LBControl As Label
    Friend WithEvents MSGBox1 As Panel
    Friend WithEvents LBMSG1 As Label
    Friend WithEvents MSGBox2 As Panel
    Friend WithEvents LBMSG2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MSGBox3 As Panel
    Friend WithEvents LBMSG3 As Label
    Friend WithEvents PCont As Panel
End Class
