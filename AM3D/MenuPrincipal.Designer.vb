<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LBGestio = New System.Windows.Forms.Label()
        Me.PanelControl = New System.Windows.Forms.Panel()
        Me.LBControl = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.PictureBox()
        Me.minimizar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBInici = New System.Windows.Forms.Label()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.Impressions = New System.Windows.Forms.PictureBox()
        Me.Impressores = New System.Windows.Forms.PictureBox()
        Me.desplegar = New System.Windows.Forms.PictureBox()
        Me.LBImpressores = New System.Windows.Forms.Label()
        Me.LBImpressions = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelControl.SuspendLayout()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        CType(Me.Impressions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Impressores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.desplegar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.PanelControl)
        Me.Panel1.Controls.Add(Me.cerrar)
        Me.Panel1.Controls.Add(Me.minimizar)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LBInici)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 36)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LBGestio)
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(300, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(82, 33)
        Me.Panel4.TabIndex = 8
        '
        'LBGestio
        '
        Me.LBGestio.AutoSize = True
        Me.LBGestio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBGestio.ForeColor = System.Drawing.Color.White
        Me.LBGestio.Location = New System.Drawing.Point(3, 5)
        Me.LBGestio.Name = "LBGestio"
        Me.LBGestio.Size = New System.Drawing.Size(74, 25)
        Me.LBGestio.TabIndex = 0
        Me.LBGestio.Text = "Gestió"
        '
        'PanelControl
        '
        Me.PanelControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelControl.Controls.Add(Me.LBControl)
        Me.PanelControl.Location = New System.Drawing.Point(190, 2)
        Me.PanelControl.Name = "PanelControl"
        Me.PanelControl.Size = New System.Drawing.Size(82, 33)
        Me.PanelControl.TabIndex = 7
        '
        'LBControl
        '
        Me.LBControl.AutoSize = True
        Me.LBControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBControl.ForeColor = System.Drawing.Color.White
        Me.LBControl.Location = New System.Drawing.Point(0, 6)
        Me.LBControl.Name = "LBControl"
        Me.LBControl.Size = New System.Drawing.Size(81, 25)
        Me.LBControl.TabIndex = 0
        Me.LBControl.Text = "Control"
        '
        'cerrar
        '
        Me.cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cerrar.Image = CType(resources.GetObject("cerrar.Image"), System.Drawing.Image)
        Me.cerrar.Location = New System.Drawing.Point(757, 6)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(28, 27)
        Me.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.cerrar.TabIndex = 5
        Me.cerrar.TabStop = False
        '
        'minimizar
        '
        Me.minimizar.Image = CType(resources.GetObject("minimizar.Image"), System.Drawing.Image)
        Me.minimizar.Location = New System.Drawing.Point(722, 6)
        Me.minimizar.Name = "minimizar"
        Me.minimizar.Size = New System.Drawing.Size(29, 27)
        Me.minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimizar.TabIndex = 6
        Me.minimizar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'LBInici
        '
        Me.LBInici.AutoSize = True
        Me.LBInici.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBInici.ForeColor = System.Drawing.Color.White
        Me.LBInici.Location = New System.Drawing.Point(33, 8)
        Me.LBInici.Name = "LBInici"
        Me.LBInici.Size = New System.Drawing.Size(128, 25)
        Me.LBInici.TabIndex = 3
        Me.LBInici.Text = "AM3D - Inici"
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.DarkGray
        Me.MenuVertical.Controls.Add(Me.LBImpressions)
        Me.MenuVertical.Controls.Add(Me.Impressions)
        Me.MenuVertical.Controls.Add(Me.LBImpressores)
        Me.MenuVertical.Controls.Add(Me.Impressores)
        Me.MenuVertical.Controls.Add(Me.desplegar)
        Me.MenuVertical.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MenuVertical.Location = New System.Drawing.Point(0, 36)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(64, 464)
        Me.MenuVertical.TabIndex = 1
        Me.MenuVertical.Visible = False
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
        'Impressores
        '
        Me.Impressores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.desplegar.Image = CType(resources.GetObject("desplegar.Image"), System.Drawing.Image)
        Me.desplegar.Location = New System.Drawing.Point(7, 422)
        Me.desplegar.Name = "desplegar"
        Me.desplegar.Size = New System.Drawing.Size(50, 39)
        Me.desplegar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.desplegar.TabIndex = 0
        Me.desplegar.TabStop = False
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
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(788, 500)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.Text = "Menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelControl.ResumeLayout(False)
        Me.PanelControl.PerformLayout()
        CType(Me.cerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        Me.MenuVertical.PerformLayout()
        CType(Me.Impressions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Impressores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.desplegar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBInici As Label
    Friend WithEvents cerrar As PictureBox
    Friend WithEvents minimizar As PictureBox
    Friend WithEvents MenuVertical As Panel
    Friend WithEvents PanelControl As Panel
    Friend WithEvents LBControl As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents LBGestio As Label
    Friend WithEvents desplegar As PictureBox
    Friend WithEvents Impressions As PictureBox
    Friend WithEvents Impressores As PictureBox
    Friend WithEvents LBImpressores As Label
    Friend WithEvents LBImpressions As Label
End Class
