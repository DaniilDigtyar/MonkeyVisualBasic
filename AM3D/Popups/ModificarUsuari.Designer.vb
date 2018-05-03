<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarUsuari
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
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.TBRContrasenya = New System.Windows.Forms.TextBox()
        Me.TBContrasenya = New System.Windows.Forms.TextBox()
        Me.TBCongnom = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBNickname = New System.Windows.Forms.TextBox()
        Me.LRepeteixContra = New System.Windows.Forms.Label()
        Me.LContrasenya = New System.Windows.Forms.Label()
        Me.LCognom = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LNomUsuari = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.TBCorreu = New System.Windows.Forms.TextBox()
        Me.LCorreu = New System.Windows.Forms.Label()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BTModificar
        '
        Me.BTModificar.BackColor = System.Drawing.Color.White
        Me.BTModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificar.ForeColor = System.Drawing.Color.Black
        Me.BTModificar.Location = New System.Drawing.Point(255, 301)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(196, 62)
        Me.BTModificar.TabIndex = 26
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = False
        '
        'TBRContrasenya
        '
        Me.TBRContrasenya.Location = New System.Drawing.Point(255, 250)
        Me.TBRContrasenya.Name = "TBRContrasenya"
        Me.TBRContrasenya.Size = New System.Drawing.Size(196, 20)
        Me.TBRContrasenya.TabIndex = 25
        '
        'TBContrasenya
        '
        Me.TBContrasenya.Location = New System.Drawing.Point(255, 209)
        Me.TBContrasenya.Name = "TBContrasenya"
        Me.TBContrasenya.Size = New System.Drawing.Size(196, 20)
        Me.TBContrasenya.TabIndex = 24
        '
        'TBCongnom
        '
        Me.TBCongnom.Location = New System.Drawing.Point(255, 121)
        Me.TBCongnom.Name = "TBCongnom"
        Me.TBCongnom.Size = New System.Drawing.Size(196, 20)
        Me.TBCongnom.TabIndex = 23
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(255, 78)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(196, 20)
        Me.TBNom.TabIndex = 22
        '
        'TBNickname
        '
        Me.TBNickname.Location = New System.Drawing.Point(255, 42)
        Me.TBNickname.Name = "TBNickname"
        Me.TBNickname.Size = New System.Drawing.Size(196, 20)
        Me.TBNickname.TabIndex = 21
        '
        'LRepeteixContra
        '
        Me.LRepeteixContra.AutoSize = True
        Me.LRepeteixContra.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRepeteixContra.ForeColor = System.Drawing.Color.Black
        Me.LRepeteixContra.Location = New System.Drawing.Point(23, 244)
        Me.LRepeteixContra.Name = "LRepeteixContra"
        Me.LRepeteixContra.Size = New System.Drawing.Size(220, 25)
        Me.LRepeteixContra.TabIndex = 20
        Me.LRepeteixContra.Text = "Repeteix la contrasenya"
        '
        'LContrasenya
        '
        Me.LContrasenya.AutoSize = True
        Me.LContrasenya.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContrasenya.ForeColor = System.Drawing.Color.Black
        Me.LContrasenya.Location = New System.Drawing.Point(23, 204)
        Me.LContrasenya.Name = "LContrasenya"
        Me.LContrasenya.Size = New System.Drawing.Size(124, 25)
        Me.LContrasenya.TabIndex = 19
        Me.LContrasenya.Text = "Contrasenya"
        '
        'LCognom
        '
        Me.LCognom.AutoSize = True
        Me.LCognom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCognom.ForeColor = System.Drawing.Color.Black
        Me.LCognom.Location = New System.Drawing.Point(21, 116)
        Me.LCognom.Name = "LCognom"
        Me.LCognom.Size = New System.Drawing.Size(97, 25)
        Me.LCognom.TabIndex = 18
        Me.LCognom.Text = "Cognoms"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.ForeColor = System.Drawing.Color.Black
        Me.LNom.Location = New System.Drawing.Point(21, 73)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(53, 25)
        Me.LNom.TabIndex = 17
        Me.LNom.Text = "Nom"
        '
        'LNomUsuari
        '
        Me.LNomUsuari.AutoSize = True
        Me.LNomUsuari.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNomUsuari.ForeColor = System.Drawing.Color.Black
        Me.LNomUsuari.Location = New System.Drawing.Point(21, 36)
        Me.LNomUsuari.Name = "LNomUsuari"
        Me.LNomUsuari.Size = New System.Drawing.Size(126, 25)
        Me.LNomUsuari.TabIndex = 16
        Me.LNomUsuari.Text = "Nom d'usuari"
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(28, 301)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(196, 62)
        Me.BTCancelar.TabIndex = 27
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
        '
        'TBCorreu
        '
        Me.TBCorreu.Location = New System.Drawing.Point(255, 166)
        Me.TBCorreu.Name = "TBCorreu"
        Me.TBCorreu.Size = New System.Drawing.Size(196, 20)
        Me.TBCorreu.TabIndex = 29
        '
        'LCorreu
        '
        Me.LCorreu.AutoSize = True
        Me.LCorreu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreu.ForeColor = System.Drawing.Color.Black
        Me.LCorreu.Location = New System.Drawing.Point(21, 161)
        Me.LCorreu.Name = "LCorreu"
        Me.LCorreu.Size = New System.Drawing.Size(72, 25)
        Me.LCorreu.TabIndex = 28
        Me.LCorreu.Text = "Correu"
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(0, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(481, 19)
        Me.MenuSup.TabIndex = 81
        '
        'ModificarUsuari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 426)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.TBCorreu)
        Me.Controls.Add(Me.LCorreu)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTModificar)
        Me.Controls.Add(Me.TBRContrasenya)
        Me.Controls.Add(Me.TBContrasenya)
        Me.Controls.Add(Me.TBCongnom)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.TBNickname)
        Me.Controls.Add(Me.LRepeteixContra)
        Me.Controls.Add(Me.LContrasenya)
        Me.Controls.Add(Me.LCognom)
        Me.Controls.Add(Me.LNom)
        Me.Controls.Add(Me.LNomUsuari)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarUsuari"
        Me.Text = "ModificarUsuari"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTModificar As Button
    Friend WithEvents TBRContrasenya As TextBox
    Friend WithEvents TBContrasenya As TextBox
    Friend WithEvents TBCongnom As TextBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents TBNickname As TextBox
    Friend WithEvents LRepeteixContra As Label
    Friend WithEvents LContrasenya As Label
    Friend WithEvents LCognom As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LNomUsuari As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents TBCorreu As TextBox
    Friend WithEvents LCorreu As Label
    Friend WithEvents MenuSup As Panel
End Class
