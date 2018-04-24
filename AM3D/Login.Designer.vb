<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LabelUsuari = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUsuari = New System.Windows.Forms.TextBox()
        Me.TextBoxContrasenya = New System.Windows.Forms.TextBox()
        Me.CheckBoxRecordar = New System.Windows.Forms.CheckBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuSup.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = True
        Me.LabelLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLogo.ForeColor = System.Drawing.Color.White
        Me.LabelLogo.Location = New System.Drawing.Point(31, 4)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(158, 25)
        Me.LabelLogo.TabIndex = 1
        Me.LabelLogo.Text = "AMD3D - Login"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(467, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(442, 7)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(19, 23)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'LabelUsuari
        '
        Me.LabelUsuari.AutoSize = True
        Me.LabelUsuari.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUsuari.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LabelUsuari.Location = New System.Drawing.Point(52, 32)
        Me.LabelUsuari.Name = "LabelUsuari"
        Me.LabelUsuari.Size = New System.Drawing.Size(51, 18)
        Me.LabelUsuari.TabIndex = 5
        Me.LabelUsuari.Text = "Usuari"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label1.Location = New System.Drawing.Point(52, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Contrasenya"
        '
        'TextBoxUsuari
        '
        Me.TextBoxUsuari.BackColor = System.Drawing.Color.Silver
        Me.TextBoxUsuari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUsuari.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsuari.ForeColor = System.Drawing.Color.Black
        Me.TextBoxUsuari.Location = New System.Drawing.Point(6, 56)
        Me.TextBoxUsuari.Name = "TextBoxUsuari"
        Me.TextBoxUsuari.Size = New System.Drawing.Size(379, 24)
        Me.TextBoxUsuari.TabIndex = 7
        '
        'TextBoxContrasenya
        '
        Me.TextBoxContrasenya.BackColor = System.Drawing.Color.Silver
        Me.TextBoxContrasenya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxContrasenya.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxContrasenya.ForeColor = System.Drawing.Color.Black
        Me.TextBoxContrasenya.Location = New System.Drawing.Point(7, 139)
        Me.TextBoxContrasenya.Name = "TextBoxContrasenya"
        Me.TextBoxContrasenya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxContrasenya.Size = New System.Drawing.Size(377, 24)
        Me.TextBoxContrasenya.TabIndex = 8
        '
        'CheckBoxRecordar
        '
        Me.CheckBoxRecordar.AutoSize = True
        Me.CheckBoxRecordar.BackColor = System.Drawing.Color.Silver
        Me.CheckBoxRecordar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBoxRecordar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CheckBoxRecordar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxRecordar.ForeColor = System.Drawing.Color.Black
        Me.CheckBoxRecordar.Location = New System.Drawing.Point(189, 169)
        Me.CheckBoxRecordar.Name = "CheckBoxRecordar"
        Me.CheckBoxRecordar.Size = New System.Drawing.Size(133, 22)
        Me.CheckBoxRecordar.TabIndex = 9
        Me.CheckBoxRecordar.Text = "Recordar usuari"
        Me.CheckBoxRecordar.UseVisualStyleBackColor = False
        '
        'ButtonLogin
        '
        Me.ButtonLogin.BackColor = System.Drawing.Color.Black
        Me.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogin.ForeColor = System.Drawing.Color.White
        Me.ButtonLogin.Location = New System.Drawing.Point(6, 237)
        Me.ButtonLogin.Name = "ButtonLogin"
        Me.ButtonLogin.Size = New System.Drawing.Size(378, 40)
        Me.ButtonLogin.TabIndex = 10
        Me.ButtonLogin.Text = "Entrar"
        Me.ButtonLogin.UseVisualStyleBackColor = False
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Controls.Add(Me.PictureBox1)
        Me.MenuSup.Controls.Add(Me.LabelLogo)
        Me.MenuSup.Controls.Add(Me.PictureBox2)
        Me.MenuSup.Controls.Add(Me.PictureBox4)
        Me.MenuSup.Location = New System.Drawing.Point(0, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(500, 33)
        Me.MenuSup.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.TextBoxContrasenya)
        Me.Panel2.Controls.Add(Me.LabelUsuari)
        Me.Panel2.Controls.Add(Me.ButtonLogin)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CheckBoxRecordar)
        Me.Panel2.Controls.Add(Me.TextBoxUsuari)
        Me.Panel2.Location = New System.Drawing.Point(49, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(400, 290)
        Me.Panel2.TabIndex = 12
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(7, 93)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(500, 396)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuSup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuSup.ResumeLayout(False)
        Me.MenuSup.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelLogo As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents LabelUsuari As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUsuari As TextBox
    Friend WithEvents TextBoxContrasenya As TextBox
    Friend WithEvents CheckBoxRecordar As CheckBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents MenuSup As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
