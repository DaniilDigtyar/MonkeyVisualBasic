<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FPerfil
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
        Me.TBEmail = New System.Windows.Forms.TextBox()
        Me.TBCognom = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBdni = New System.Windows.Forms.TextBox()
        Me.LEmail = New System.Windows.Forms.Label()
        Me.LCognom = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LDni = New System.Windows.Forms.Label()
        Me.CBModificar = New System.Windows.Forms.CheckBox()
        Me.LCanvContr = New System.Windows.Forms.Label()
        Me.TextBoxRepeteix = New System.Windows.Forms.TextBox()
        Me.TextBoxNova = New System.Windows.Forms.TextBox()
        Me.TextBoxActual = New System.Windows.Forms.TextBox()
        Me.LRContra = New System.Windows.Forms.Label()
        Me.LNova = New System.Windows.Forms.Label()
        Me.LActual = New System.Windows.Forms.Label()
        Me.BTActualitzar = New System.Windows.Forms.Button()
        Me.BTCanviarContra = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LDades = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBEmail
        '
        Me.TBEmail.Enabled = False
        Me.TBEmail.Location = New System.Drawing.Point(228, 222)
        Me.TBEmail.Name = "TBEmail"
        Me.TBEmail.Size = New System.Drawing.Size(179, 20)
        Me.TBEmail.TabIndex = 55
        '
        'TBCognom
        '
        Me.TBCognom.Enabled = False
        Me.TBCognom.Location = New System.Drawing.Point(228, 187)
        Me.TBCognom.Name = "TBCognom"
        Me.TBCognom.Size = New System.Drawing.Size(179, 20)
        Me.TBCognom.TabIndex = 54
        '
        'TBNom
        '
        Me.TBNom.Enabled = False
        Me.TBNom.Location = New System.Drawing.Point(228, 152)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(179, 20)
        Me.TBNom.TabIndex = 53
        '
        'TBdni
        '
        Me.TBdni.Enabled = False
        Me.TBdni.Location = New System.Drawing.Point(228, 119)
        Me.TBdni.Name = "TBdni"
        Me.TBdni.Size = New System.Drawing.Size(179, 20)
        Me.TBdni.TabIndex = 52
        '
        'LEmail
        '
        Me.LEmail.AutoSize = True
        Me.LEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEmail.ForeColor = System.Drawing.Color.Black
        Me.LEmail.Location = New System.Drawing.Point(44, 220)
        Me.LEmail.Name = "LEmail"
        Me.LEmail.Size = New System.Drawing.Size(48, 20)
        Me.LEmail.TabIndex = 51
        Me.LEmail.Text = "Email"
        '
        'LCognom
        '
        Me.LCognom.AutoSize = True
        Me.LCognom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCognom.ForeColor = System.Drawing.Color.Black
        Me.LCognom.Location = New System.Drawing.Point(44, 185)
        Me.LCognom.Name = "LCognom"
        Me.LCognom.Size = New System.Drawing.Size(69, 20)
        Me.LCognom.TabIndex = 50
        Me.LCognom.Text = "Cognom"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.ForeColor = System.Drawing.Color.Black
        Me.LNom.Location = New System.Drawing.Point(44, 150)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(42, 20)
        Me.LNom.TabIndex = 49
        Me.LNom.Text = "Nom"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDni.ForeColor = System.Drawing.Color.Black
        Me.LDni.Location = New System.Drawing.Point(44, 117)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(37, 20)
        Me.LDni.TabIndex = 48
        Me.LDni.Text = "DNI"
        '
        'CBModificar
        '
        Me.CBModificar.AutoSize = True
        Me.CBModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBModificar.Location = New System.Drawing.Point(48, 74)
        Me.CBModificar.Name = "CBModificar"
        Me.CBModificar.Size = New System.Drawing.Size(92, 24)
        Me.CBModificar.TabIndex = 56
        Me.CBModificar.Text = "Modificar"
        Me.CBModificar.UseVisualStyleBackColor = True
        '
        'LCanvContr
        '
        Me.LCanvContr.AutoSize = True
        Me.LCanvContr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCanvContr.ForeColor = System.Drawing.Color.Black
        Me.LCanvContr.Location = New System.Drawing.Point(43, 328)
        Me.LCanvContr.Name = "LCanvContr"
        Me.LCanvContr.Size = New System.Drawing.Size(197, 25)
        Me.LCanvContr.TabIndex = 57
        Me.LCanvContr.Text = "Canviar Contrasenya"
        '
        'TextBoxRepeteix
        '
        Me.TextBoxRepeteix.Location = New System.Drawing.Point(228, 460)
        Me.TextBoxRepeteix.Name = "TextBoxRepeteix"
        Me.TextBoxRepeteix.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxRepeteix.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxRepeteix.TabIndex = 63
        '
        'TextBoxNova
        '
        Me.TextBoxNova.Location = New System.Drawing.Point(228, 425)
        Me.TextBoxNova.Name = "TextBoxNova"
        Me.TextBoxNova.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNova.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxNova.TabIndex = 62
        '
        'TextBoxActual
        '
        Me.TextBoxActual.Location = New System.Drawing.Point(228, 392)
        Me.TextBoxActual.Name = "TextBoxActual"
        Me.TextBoxActual.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxActual.Size = New System.Drawing.Size(179, 20)
        Me.TextBoxActual.TabIndex = 61
        '
        'LRContra
        '
        Me.LRContra.AutoSize = True
        Me.LRContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRContra.ForeColor = System.Drawing.Color.Black
        Me.LRContra.Location = New System.Drawing.Point(44, 458)
        Me.LRContra.Name = "LRContra"
        Me.LRContra.Size = New System.Drawing.Size(179, 20)
        Me.LRContra.TabIndex = 60
        Me.LRContra.Text = "Repeteix la contrasenya"
        '
        'LNova
        '
        Me.LNova.AutoSize = True
        Me.LNova.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNova.ForeColor = System.Drawing.Color.Black
        Me.LNova.Location = New System.Drawing.Point(44, 423)
        Me.LNova.Name = "LNova"
        Me.LNova.Size = New System.Drawing.Size(45, 20)
        Me.LNova.TabIndex = 59
        Me.LNova.Text = "Nova"
        '
        'LActual
        '
        Me.LActual.AutoSize = True
        Me.LActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LActual.ForeColor = System.Drawing.Color.Black
        Me.LActual.Location = New System.Drawing.Point(44, 390)
        Me.LActual.Name = "LActual"
        Me.LActual.Size = New System.Drawing.Size(54, 20)
        Me.LActual.TabIndex = 58
        Me.LActual.Text = "Actual"
        '
        'BTActualitzar
        '
        Me.BTActualitzar.BackColor = System.Drawing.Color.White
        Me.BTActualitzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTActualitzar.Enabled = False
        Me.BTActualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTActualitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTActualitzar.ForeColor = System.Drawing.Color.Black
        Me.BTActualitzar.Location = New System.Drawing.Point(535, 117)
        Me.BTActualitzar.Name = "BTActualitzar"
        Me.BTActualitzar.Size = New System.Drawing.Size(190, 62)
        Me.BTActualitzar.TabIndex = 64
        Me.BTActualitzar.Text = "Actualitzar"
        Me.BTActualitzar.UseVisualStyleBackColor = False
        '
        'BTCanviarContra
        '
        Me.BTCanviarContra.BackColor = System.Drawing.Color.White
        Me.BTCanviarContra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCanviarContra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCanviarContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCanviarContra.ForeColor = System.Drawing.Color.Black
        Me.BTCanviarContra.Location = New System.Drawing.Point(535, 390)
        Me.BTCanviarContra.Name = "BTCanviarContra"
        Me.BTCanviarContra.Size = New System.Drawing.Size(190, 62)
        Me.BTCanviarContra.TabIndex = 65
        Me.BTCanviarContra.Text = "Canviar"
        Me.BTCanviarContra.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(-1, 294)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(743, 10)
        Me.Panel1.TabIndex = 66
        '
        'LDades
        '
        Me.LDades.AutoSize = True
        Me.LDades.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDades.ForeColor = System.Drawing.Color.Black
        Me.LDades.Location = New System.Drawing.Point(43, 20)
        Me.LDades.Name = "LDades"
        Me.LDades.Size = New System.Drawing.Size(69, 25)
        Me.LDades.TabIndex = 67
        Me.LDades.Text = "Dades"
        '
        'FPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 521)
        Me.Controls.Add(Me.LDades)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTCanviarContra)
        Me.Controls.Add(Me.BTActualitzar)
        Me.Controls.Add(Me.TextBoxRepeteix)
        Me.Controls.Add(Me.TextBoxNova)
        Me.Controls.Add(Me.TextBoxActual)
        Me.Controls.Add(Me.LRContra)
        Me.Controls.Add(Me.LNova)
        Me.Controls.Add(Me.LActual)
        Me.Controls.Add(Me.LCanvContr)
        Me.Controls.Add(Me.CBModificar)
        Me.Controls.Add(Me.TBEmail)
        Me.Controls.Add(Me.TBCognom)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.TBdni)
        Me.Controls.Add(Me.LEmail)
        Me.Controls.Add(Me.LCognom)
        Me.Controls.Add(Me.LNom)
        Me.Controls.Add(Me.LDni)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FPerfil"
        Me.Text = "FPerfil"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBEmail As TextBox
    Friend WithEvents TBCognom As TextBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents TBdni As TextBox
    Friend WithEvents LEmail As Label
    Friend WithEvents LCognom As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LDni As Label
    Friend WithEvents CBModificar As CheckBox
    Friend WithEvents LCanvContr As Label
    Friend WithEvents TextBoxRepeteix As TextBox
    Friend WithEvents TextBoxNova As TextBox
    Friend WithEvents TextBoxActual As TextBox
    Friend WithEvents LRContra As Label
    Friend WithEvents LNova As Label
    Friend WithEvents LActual As Label
    Friend WithEvents BTActualitzar As Button
    Friend WithEvents BTCanviarContra As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LDades As Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
