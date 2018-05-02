<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelUsuarisAfegir
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
        Me.LNomUsuari = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LCognom = New System.Windows.Forms.Label()
        Me.LContrasenya = New System.Windows.Forms.Label()
        Me.LRContrasenya = New System.Windows.Forms.Label()
        Me.TBNickname = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBCongnom = New System.Windows.Forms.TextBox()
        Me.TBContrasenya = New System.Windows.Forms.TextBox()
        Me.TBRContrasenya = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CLBPermisos = New System.Windows.Forms.CheckedListBox()
        Me.BTEsborrar = New System.Windows.Forms.Button()
        Me.BTCrear = New System.Windows.Forms.Button()
        Me.TBCorreu = New System.Windows.Forms.TextBox()
        Me.LCorreu = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LNomUsuari
        '
        Me.LNomUsuari.AutoSize = True
        Me.LNomUsuari.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNomUsuari.ForeColor = System.Drawing.Color.Black
        Me.LNomUsuari.Location = New System.Drawing.Point(12, 54)
        Me.LNomUsuari.Name = "LNomUsuari"
        Me.LNomUsuari.Size = New System.Drawing.Size(126, 25)
        Me.LNomUsuari.TabIndex = 1
        Me.LNomUsuari.Text = "Nom d'usuari"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.ForeColor = System.Drawing.Color.Black
        Me.LNom.Location = New System.Drawing.Point(12, 98)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(53, 25)
        Me.LNom.TabIndex = 2
        Me.LNom.Text = "Nom"
        '
        'LCognom
        '
        Me.LCognom.AutoSize = True
        Me.LCognom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCognom.ForeColor = System.Drawing.Color.Black
        Me.LCognom.Location = New System.Drawing.Point(12, 138)
        Me.LCognom.Name = "LCognom"
        Me.LCognom.Size = New System.Drawing.Size(97, 25)
        Me.LCognom.TabIndex = 3
        Me.LCognom.Text = "Cognoms"
        '
        'LContrasenya
        '
        Me.LContrasenya.AutoSize = True
        Me.LContrasenya.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContrasenya.ForeColor = System.Drawing.Color.Black
        Me.LContrasenya.Location = New System.Drawing.Point(12, 233)
        Me.LContrasenya.Name = "LContrasenya"
        Me.LContrasenya.Size = New System.Drawing.Size(124, 25)
        Me.LContrasenya.TabIndex = 4
        Me.LContrasenya.Text = "Contrasenya"
        '
        'LRContrasenya
        '
        Me.LRContrasenya.AutoSize = True
        Me.LRContrasenya.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRContrasenya.ForeColor = System.Drawing.Color.Black
        Me.LRContrasenya.Location = New System.Drawing.Point(12, 281)
        Me.LRContrasenya.Name = "LRContrasenya"
        Me.LRContrasenya.Size = New System.Drawing.Size(220, 25)
        Me.LRContrasenya.TabIndex = 5
        Me.LRContrasenya.Text = "Repeteix la contrasenya"
        '
        'TBNickname
        '
        Me.TBNickname.Location = New System.Drawing.Point(256, 59)
        Me.TBNickname.Name = "TBNickname"
        Me.TBNickname.Size = New System.Drawing.Size(196, 20)
        Me.TBNickname.TabIndex = 8
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(256, 101)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(196, 20)
        Me.TBNom.TabIndex = 9
        '
        'TBCongnom
        '
        Me.TBCongnom.Location = New System.Drawing.Point(256, 141)
        Me.TBCongnom.Name = "TBCongnom"
        Me.TBCongnom.Size = New System.Drawing.Size(196, 20)
        Me.TBCongnom.TabIndex = 10
        '
        'TBContrasenya
        '
        Me.TBContrasenya.Location = New System.Drawing.Point(256, 233)
        Me.TBContrasenya.Name = "TBContrasenya"
        Me.TBContrasenya.Size = New System.Drawing.Size(196, 20)
        Me.TBContrasenya.TabIndex = 11
        '
        'TBRContrasenya
        '
        Me.TBRContrasenya.Location = New System.Drawing.Point(256, 286)
        Me.TBRContrasenya.Name = "TBRContrasenya"
        Me.TBRContrasenya.Size = New System.Drawing.Size(196, 20)
        Me.TBRContrasenya.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(575, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 25)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Permisos"
        '
        'CLBPermisos
        '
        Me.CLBPermisos.FormattingEnabled = True
        Me.CLBPermisos.Location = New System.Drawing.Point(481, 60)
        Me.CLBPermisos.Name = "CLBPermisos"
        Me.CLBPermisos.Size = New System.Drawing.Size(275, 214)
        Me.CLBPermisos.TabIndex = 14
        '
        'BTEsborrar
        '
        Me.BTEsborrar.BackColor = System.Drawing.Color.White
        Me.BTEsborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEsborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEsborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEsborrar.ForeColor = System.Drawing.Color.Black
        Me.BTEsborrar.Location = New System.Drawing.Point(664, 294)
        Me.BTEsborrar.Name = "BTEsborrar"
        Me.BTEsborrar.Size = New System.Drawing.Size(92, 62)
        Me.BTEsborrar.TabIndex = 16
        Me.BTEsborrar.Text = "Esborrar"
        Me.BTEsborrar.UseVisualStyleBackColor = False
        '
        'BTCrear
        '
        Me.BTCrear.BackColor = System.Drawing.Color.White
        Me.BTCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCrear.ForeColor = System.Drawing.Color.Black
        Me.BTCrear.Location = New System.Drawing.Point(481, 294)
        Me.BTCrear.Name = "BTCrear"
        Me.BTCrear.Size = New System.Drawing.Size(92, 62)
        Me.BTCrear.TabIndex = 15
        Me.BTCrear.Text = "Crear"
        Me.BTCrear.UseVisualStyleBackColor = False
        '
        'TBCorreu
        '
        Me.TBCorreu.Location = New System.Drawing.Point(256, 186)
        Me.TBCorreu.Name = "TBCorreu"
        Me.TBCorreu.Size = New System.Drawing.Size(196, 20)
        Me.TBCorreu.TabIndex = 18
        '
        'LCorreu
        '
        Me.LCorreu.AutoSize = True
        Me.LCorreu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreu.ForeColor = System.Drawing.Color.Black
        Me.LCorreu.Location = New System.Drawing.Point(12, 183)
        Me.LCorreu.Name = "LCorreu"
        Me.LCorreu.Size = New System.Drawing.Size(72, 25)
        Me.LCorreu.TabIndex = 17
        Me.LCorreu.Text = "Correu"
        '
        'PanelUsuarisAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 380)
        Me.Controls.Add(Me.TBCorreu)
        Me.Controls.Add(Me.LCorreu)
        Me.Controls.Add(Me.BTEsborrar)
        Me.Controls.Add(Me.BTCrear)
        Me.Controls.Add(Me.CLBPermisos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBRContrasenya)
        Me.Controls.Add(Me.TBContrasenya)
        Me.Controls.Add(Me.TBCongnom)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.TBNickname)
        Me.Controls.Add(Me.LRContrasenya)
        Me.Controls.Add(Me.LContrasenya)
        Me.Controls.Add(Me.LCognom)
        Me.Controls.Add(Me.LNom)
        Me.Controls.Add(Me.LNomUsuari)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelUsuarisAfegir"
        Me.Text = "PanelUsuarisAfegir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNomUsuari As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LCognom As Label
    Friend WithEvents LContrasenya As Label
    Friend WithEvents LRContrasenya As Label
    Friend WithEvents TBNickname As TextBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents TBCongnom As TextBox
    Friend WithEvents TBContrasenya As TextBox
    Friend WithEvents TBRContrasenya As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CLBPermisos As CheckedListBox
    Friend WithEvents BTEsborrar As Button
    Friend WithEvents BTCrear As Button
    Friend WithEvents TBCorreu As TextBox
    Friend WithEvents LCorreu As Label
End Class
