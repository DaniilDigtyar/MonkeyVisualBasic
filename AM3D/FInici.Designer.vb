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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.Gcode.Location = New System.Drawing.Point(544, 357)
        Me.Gcode.Name = "Gcode"
        Me.Gcode.Size = New System.Drawing.Size(83, 87)
        Me.Gcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Gcode.TabIndex = 8
        Me.Gcode.TabStop = False
        '
        'Models
        '
        Me.Models.Image = CType(resources.GetObject("Models.Image"), System.Drawing.Image)
        Me.Models.Location = New System.Drawing.Point(656, 205)
        Me.Models.Name = "Models"
        Me.Models.Size = New System.Drawing.Size(83, 87)
        Me.Models.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Models.TabIndex = 7
        Me.Models.TabStop = False
        '
        'Bobines
        '
        Me.Bobines.Image = CType(resources.GetObject("Bobines.Image"), System.Drawing.Image)
        Me.Bobines.Location = New System.Drawing.Point(656, 357)
        Me.Bobines.Name = "Bobines"
        Me.Bobines.Size = New System.Drawing.Size(83, 87)
        Me.Bobines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bobines.TabIndex = 6
        Me.Bobines.TabStop = False
        '
        'Usuaris
        '
        Me.Usuaris.Image = CType(resources.GetObject("Usuaris.Image"), System.Drawing.Image)
        Me.Usuaris.Location = New System.Drawing.Point(544, 205)
        Me.Usuaris.Name = "Usuaris"
        Me.Usuaris.Size = New System.Drawing.Size(83, 87)
        Me.Usuaris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Usuaris.TabIndex = 5
        Me.Usuaris.TabStop = False
        '
        'Impressions
        '
        Me.Impressions.Image = CType(resources.GetObject("Impressions.Image"), System.Drawing.Image)
        Me.Impressions.Location = New System.Drawing.Point(151, 205)
        Me.Impressions.Name = "Impressions"
        Me.Impressions.Size = New System.Drawing.Size(83, 87)
        Me.Impressions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Impressions.TabIndex = 10
        Me.Impressions.TabStop = False
        '
        'Impressores
        '
        Me.Impressores.Image = CType(resources.GetObject("Impressores.Image"), System.Drawing.Image)
        Me.Impressores.Location = New System.Drawing.Point(15, 205)
        Me.Impressores.Name = "Impressores"
        Me.Impressores.Size = New System.Drawing.Size(83, 87)
        Me.Impressores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Impressores.TabIndex = 9
        Me.Impressores.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(594, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 31)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Gestió"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 31)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Control"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 31)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Benvingut"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 31)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "NomUsuari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Impressores"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(137, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 22)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Impressions"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(667, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 22)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Models"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(552, 311)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 22)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Usuaris"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(552, 470)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Gcode"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(664, 470)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 22)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Bobines"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(272, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(290, 31)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Aplicacions funcionals:"
        '
        'FInici
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 521)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
