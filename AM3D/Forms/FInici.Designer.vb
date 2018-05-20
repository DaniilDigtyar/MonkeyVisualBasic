<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FInici
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FInici))
        Me.Gcode = New System.Windows.Forms.PictureBox()
        Me.Models = New System.Windows.Forms.PictureBox()
        Me.Bobines = New System.Windows.Forms.PictureBox()
        Me.Usuaris = New System.Windows.Forms.PictureBox()
        Me.Impressions = New System.Windows.Forms.PictureBox()
        Me.Impressores = New System.Windows.Forms.PictureBox()
        Me.LGestio = New System.Windows.Forms.Label()
        Me.LControl = New System.Windows.Forms.Label()
        Me.LBenvingut = New System.Windows.Forms.Label()
        Me.LabelNomUsuari = New System.Windows.Forms.Label()
        Me.LImpressores = New System.Windows.Forms.Label()
        Me.LImpressions = New System.Windows.Forms.Label()
        Me.LModels = New System.Windows.Forms.Label()
        Me.LUsuaris = New System.Windows.Forms.Label()
        Me.LGcode = New System.Windows.Forms.Label()
        Me.LBobines = New System.Windows.Forms.Label()
        Me.LApliFun = New System.Windows.Forms.Label()
        CType(Me.Gcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Models, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bobines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Usuaris, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Impressions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Impressores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Gcode
        '
        Me.Gcode.Image = CType(resources.GetObject("Gcode.Image"), System.Drawing.Image)
        Me.Gcode.Location = New System.Drawing.Point(493, 327)
        Me.Gcode.Name = "Gcode"
        Me.Gcode.Size = New System.Drawing.Size(83, 87)
        Me.Gcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Gcode.TabIndex = 8
        Me.Gcode.TabStop = False
        '
        'Models
        '
        Me.Models.Image = CType(resources.GetObject("Models.Image"), System.Drawing.Image)
        Me.Models.Location = New System.Drawing.Point(605, 203)
        Me.Models.Name = "Models"
        Me.Models.Size = New System.Drawing.Size(83, 87)
        Me.Models.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Models.TabIndex = 7
        Me.Models.TabStop = False
        '
        'Bobines
        '
        Me.Bobines.Image = CType(resources.GetObject("Bobines.Image"), System.Drawing.Image)
        Me.Bobines.Location = New System.Drawing.Point(605, 327)
        Me.Bobines.Name = "Bobines"
        Me.Bobines.Size = New System.Drawing.Size(83, 87)
        Me.Bobines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bobines.TabIndex = 6
        Me.Bobines.TabStop = False
        '
        'Usuaris
        '
        Me.Usuaris.Image = CType(resources.GetObject("Usuaris.Image"), System.Drawing.Image)
        Me.Usuaris.Location = New System.Drawing.Point(493, 203)
        Me.Usuaris.Name = "Usuaris"
        Me.Usuaris.Size = New System.Drawing.Size(83, 87)
        Me.Usuaris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Usuaris.TabIndex = 5
        Me.Usuaris.TabStop = False
        '
        'Impressions
        '
        Me.Impressions.Image = CType(resources.GetObject("Impressions.Image"), System.Drawing.Image)
        Me.Impressions.Location = New System.Drawing.Point(233, 203)
        Me.Impressions.Name = "Impressions"
        Me.Impressions.Size = New System.Drawing.Size(83, 87)
        Me.Impressions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Impressions.TabIndex = 10
        Me.Impressions.TabStop = False
        '
        'Impressores
        '
        Me.Impressores.Image = CType(resources.GetObject("Impressores.Image"), System.Drawing.Image)
        Me.Impressores.Location = New System.Drawing.Point(124, 203)
        Me.Impressores.Name = "Impressores"
        Me.Impressores.Size = New System.Drawing.Size(83, 87)
        Me.Impressores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Impressores.TabIndex = 9
        Me.Impressores.TabStop = False
        '
        'LGestio
        '
        Me.LGestio.AutoSize = True
        Me.LGestio.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGestio.Location = New System.Drawing.Point(546, 155)
        Me.LGestio.Name = "LGestio"
        Me.LGestio.Size = New System.Drawing.Size(93, 31)
        Me.LGestio.TabIndex = 11
        Me.LGestio.Text = "Gestió"
        '
        'LControl
        '
        Me.LControl.AutoSize = True
        Me.LControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LControl.Location = New System.Drawing.Point(172, 155)
        Me.LControl.Name = "LControl"
        Me.LControl.Size = New System.Drawing.Size(102, 31)
        Me.LControl.TabIndex = 12
        Me.LControl.Text = "Control"
        '
        'LBenvingut
        '
        Me.LBenvingut.AutoSize = True
        Me.LBenvingut.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBenvingut.Location = New System.Drawing.Point(276, 9)
        Me.LBenvingut.Name = "LBenvingut"
        Me.LBenvingut.Size = New System.Drawing.Size(173, 31)
        Me.LBenvingut.TabIndex = 13
        Me.LBenvingut.Text = "Benvingut/da"
        '
        'LabelNomUsuari
        '
        Me.LabelNomUsuari.AutoSize = True
        Me.LabelNomUsuari.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomUsuari.Location = New System.Drawing.Point(441, 9)
        Me.LabelNomUsuari.Name = "LabelNomUsuari"
        Me.LabelNomUsuari.Size = New System.Drawing.Size(150, 31)
        Me.LabelNomUsuari.TabIndex = 14
        Me.LabelNomUsuari.Text = "NomUsuari"
        '
        'LImpressores
        '
        Me.LImpressores.AutoSize = True
        Me.LImpressores.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LImpressores.Location = New System.Drawing.Point(110, 293)
        Me.LImpressores.Name = "LImpressores"
        Me.LImpressores.Size = New System.Drawing.Size(107, 22)
        Me.LImpressores.TabIndex = 15
        Me.LImpressores.Text = "Impressores"
        '
        'LImpressions
        '
        Me.LImpressions.AutoSize = True
        Me.LImpressions.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LImpressions.Location = New System.Drawing.Point(223, 293)
        Me.LImpressions.Name = "LImpressions"
        Me.LImpressions.Size = New System.Drawing.Size(105, 22)
        Me.LImpressions.TabIndex = 16
        Me.LImpressions.Text = "Impressions"
        '
        'LModels
        '
        Me.LModels.AutoSize = True
        Me.LModels.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModels.Location = New System.Drawing.Point(614, 293)
        Me.LModels.Name = "LModels"
        Me.LModels.Size = New System.Drawing.Size(67, 22)
        Me.LModels.TabIndex = 17
        Me.LModels.Text = "Models"
        '
        'LUsuaris
        '
        Me.LUsuaris.AutoSize = True
        Me.LUsuaris.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuaris.Location = New System.Drawing.Point(500, 293)
        Me.LUsuaris.Name = "LUsuaris"
        Me.LUsuaris.Size = New System.Drawing.Size(71, 22)
        Me.LUsuaris.TabIndex = 18
        Me.LUsuaris.Text = "Usuaris"
        '
        'LGcode
        '
        Me.LGcode.AutoSize = True
        Me.LGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LGcode.Location = New System.Drawing.Point(503, 418)
        Me.LGcode.Name = "LGcode"
        Me.LGcode.Size = New System.Drawing.Size(63, 22)
        Me.LGcode.TabIndex = 19
        Me.LGcode.Text = "Gcode"
        '
        'LBobines
        '
        Me.LBobines.AutoSize = True
        Me.LBobines.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBobines.Location = New System.Drawing.Point(609, 418)
        Me.LBobines.Name = "LBobines"
        Me.LBobines.Size = New System.Drawing.Size(75, 22)
        Me.LBobines.TabIndex = 20
        Me.LBobines.Text = "Bobines"
        '
        'LApliFun
        '
        Me.LApliFun.AutoSize = True
        Me.LApliFun.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApliFun.Location = New System.Drawing.Point(276, 63)
        Me.LApliFun.Name = "LApliFun"
        Me.LApliFun.Size = New System.Drawing.Size(290, 31)
        Me.LApliFun.TabIndex = 21
        Me.LApliFun.Text = "Aplicacions funcionals:"
        '
        'FInici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 521)
        Me.Controls.Add(Me.LApliFun)
        Me.Controls.Add(Me.LBobines)
        Me.Controls.Add(Me.LGcode)
        Me.Controls.Add(Me.LUsuaris)
        Me.Controls.Add(Me.LModels)
        Me.Controls.Add(Me.LImpressions)
        Me.Controls.Add(Me.LImpressores)
        Me.Controls.Add(Me.LabelNomUsuari)
        Me.Controls.Add(Me.LBenvingut)
        Me.Controls.Add(Me.LControl)
        Me.Controls.Add(Me.LGestio)
        Me.Controls.Add(Me.Impressions)
        Me.Controls.Add(Me.Impressores)
        Me.Controls.Add(Me.Gcode)
        Me.Controls.Add(Me.Models)
        Me.Controls.Add(Me.Bobines)
        Me.Controls.Add(Me.Usuaris)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FInici"
        Me.Text = "INICI"
        CType(Me.Gcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Models, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bobines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Usuaris, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Impressions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Impressores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Gcode As PictureBox
    Friend WithEvents Models As PictureBox
    Friend WithEvents Bobines As PictureBox
    Friend WithEvents Usuaris As PictureBox
    Friend WithEvents Impressions As PictureBox
    Friend WithEvents Impressores As PictureBox
    Friend WithEvents LGestio As Label
    Friend WithEvents LControl As Label
    Friend WithEvents LBenvingut As Label
    Friend WithEvents LabelNomUsuari As Label
    Friend WithEvents LImpressores As Label
    Friend WithEvents LImpressions As Label
    Friend WithEvents LModels As Label
    Friend WithEvents LUsuaris As Label
    Friend WithEvents LGcode As Label
    Friend WithEvents LBobines As Label
    Friend WithEvents LApliFun As Label
End Class
