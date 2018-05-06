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
        Me.LUsuari = New System.Windows.Forms.Label()
        Me.LContrasenya = New System.Windows.Forms.Label()
        Me.TextBoxUsuari = New System.Windows.Forms.TextBox()
        Me.TextBoxContrasenya = New System.Windows.Forms.TextBox()
        Me.CBRecordar = New System.Windows.Forms.CheckBox()
        Me.ButtonLogin = New System.Windows.Forms.Button()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.CBIdioma = New System.Windows.Forms.ComboBox()
        Me.Lidioma = New System.Windows.Forms.Label()
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
        'LUsuari
        '
        Me.LUsuari.AutoSize = True
        Me.LUsuari.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuari.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LUsuari.Location = New System.Drawing.Point(52, 32)
        Me.LUsuari.Name = "LUsuari"
        Me.LUsuari.Size = New System.Drawing.Size(51, 18)
        Me.LUsuari.TabIndex = 5
        Me.LUsuari.Text = "Usuari"
        '
        'LContrasenya
        '
        Me.LContrasenya.AutoSize = True
        Me.LContrasenya.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContrasenya.ForeColor = System.Drawing.SystemColors.WindowText
        Me.LContrasenya.Location = New System.Drawing.Point(52, 115)
        Me.LContrasenya.Name = "LContrasenya"
        Me.LContrasenya.Size = New System.Drawing.Size(92, 18)
        Me.LContrasenya.TabIndex = 6
        Me.LContrasenya.Text = "Contrasenya"
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
        'CBRecordar
        '
        Me.CBRecordar.AutoSize = True
        Me.CBRecordar.BackColor = System.Drawing.Color.Silver
        Me.CBRecordar.Cursor = System.Windows.Forms.Cursors.Default
        Me.CBRecordar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CBRecordar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRecordar.ForeColor = System.Drawing.Color.Black
        Me.CBRecordar.Location = New System.Drawing.Point(189, 169)
        Me.CBRecordar.Name = "CBRecordar"
        Me.CBRecordar.Size = New System.Drawing.Size(133, 22)
        Me.CBRecordar.TabIndex = 9
        Me.CBRecordar.Text = "Recordar usuari"
        Me.CBRecordar.UseVisualStyleBackColor = False
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
        Me.MenuSup.Controls.Add(Me.CBIdioma)
        Me.MenuSup.Controls.Add(Me.Lidioma)
        Me.MenuSup.Controls.Add(Me.PictureBox1)
        Me.MenuSup.Controls.Add(Me.LabelLogo)
        Me.MenuSup.Controls.Add(Me.PictureBox2)
        Me.MenuSup.Controls.Add(Me.PictureBox4)
        Me.MenuSup.Location = New System.Drawing.Point(0, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(500, 33)
        Me.MenuSup.TabIndex = 11
        '
        'CBIdioma
        '
        Me.CBIdioma.FormattingEnabled = True
        Me.CBIdioma.Location = New System.Drawing.Point(307, 7)
        Me.CBIdioma.Name = "CBIdioma"
        Me.CBIdioma.Size = New System.Drawing.Size(121, 21)
        Me.CBIdioma.TabIndex = 6
        '
        'Lidioma
        '
        Me.Lidioma.AutoSize = True
        Me.Lidioma.ForeColor = System.Drawing.Color.White
        Me.Lidioma.Location = New System.Drawing.Point(241, 11)
        Me.Lidioma.Name = "Lidioma"
        Me.Lidioma.Size = New System.Drawing.Size(38, 13)
        Me.Lidioma.TabIndex = 5
        Me.Lidioma.Text = "Idioma"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.TextBoxContrasenya)
        Me.Panel2.Controls.Add(Me.LUsuari)
        Me.Panel2.Controls.Add(Me.ButtonLogin)
        Me.Panel2.Controls.Add(Me.LContrasenya)
        Me.Panel2.Controls.Add(Me.CBRecordar)
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
    Friend WithEvents LUsuari As Label
    Friend WithEvents LContrasenya As Label
    Friend WithEvents TextBoxUsuari As TextBox
    Friend WithEvents TextBoxContrasenya As TextBox
    Friend WithEvents CBRecordar As CheckBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents MenuSup As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents CBIdioma As ComboBox
    Friend WithEvents Lidioma As Label
End Class
