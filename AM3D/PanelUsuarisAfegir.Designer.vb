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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBNickname = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBCongnom = New System.Windows.Forms.TextBox()
        Me.TBContrasenya = New System.Windows.Forms.TextBox()
        Me.TBRContrasenya = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CLBPermisos = New System.Windows.Forms.CheckedListBox()
        Me.BTEsborrar = New System.Windows.Forms.Button()
        Me.BTCrear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom d'usuari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cognoms"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contrasenya"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Repeteix la contrasenya"
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
        Me.TBNom.Location = New System.Drawing.Point(256, 123)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(196, 20)
        Me.TBNom.TabIndex = 9
        '
        'TBCongnom
        '
        Me.TBCongnom.Location = New System.Drawing.Point(256, 190)
        Me.TBCongnom.Name = "TBCongnom"
        Me.TBCongnom.Size = New System.Drawing.Size(196, 20)
        Me.TBCongnom.TabIndex = 10
        '
        'TBContrasenya
        '
        Me.TBContrasenya.Location = New System.Drawing.Point(256, 256)
        Me.TBContrasenya.Name = "TBContrasenya"
        Me.TBContrasenya.Size = New System.Drawing.Size(196, 20)
        Me.TBContrasenya.TabIndex = 11
        '
        'TBRContrasenya
        '
        Me.TBRContrasenya.Location = New System.Drawing.Point(256, 317)
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
        'PanelUsuarisAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 380)
        Me.Controls.Add(Me.BTEsborrar)
        Me.Controls.Add(Me.BTCrear)
        Me.Controls.Add(Me.CLBPermisos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBRContrasenya)
        Me.Controls.Add(Me.TBContrasenya)
        Me.Controls.Add(Me.TBCongnom)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.TBNickname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelUsuarisAfegir"
        Me.Text = "PanelUsuarisAfegir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBNickname As TextBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents TBCongnom As TextBox
    Friend WithEvents TBContrasenya As TextBox
    Friend WithEvents TBRContrasenya As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CLBPermisos As CheckedListBox
    Friend WithEvents BTEsborrar As Button
    Friend WithEvents BTCrear As Button
End Class
