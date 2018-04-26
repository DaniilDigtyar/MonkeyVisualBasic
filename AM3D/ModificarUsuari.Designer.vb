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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTModificar
        '
        Me.BTModificar.BackColor = System.Drawing.Color.White
        Me.BTModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificar.ForeColor = System.Drawing.Color.Black
        Me.BTModificar.Location = New System.Drawing.Point(255, 326)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(196, 62)
        Me.BTModificar.TabIndex = 26
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = False
        '
        'TBRContrasenya
        '
        Me.TBRContrasenya.Location = New System.Drawing.Point(255, 264)
        Me.TBRContrasenya.Name = "TBRContrasenya"
        Me.TBRContrasenya.Size = New System.Drawing.Size(196, 20)
        Me.TBRContrasenya.TabIndex = 25
        '
        'TBContrasenya
        '
        Me.TBContrasenya.Location = New System.Drawing.Point(255, 197)
        Me.TBContrasenya.Name = "TBContrasenya"
        Me.TBContrasenya.Size = New System.Drawing.Size(196, 20)
        Me.TBContrasenya.TabIndex = 24
        '
        'TBCongnom
        '
        Me.TBCongnom.Location = New System.Drawing.Point(255, 136)
        Me.TBCongnom.Name = "TBCongnom"
        Me.TBCongnom.Size = New System.Drawing.Size(196, 20)
        Me.TBCongnom.TabIndex = 23
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(255, 83)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(196, 20)
        Me.TBNom.TabIndex = 22
        '
        'TBNickname
        '
        Me.TBNickname.Location = New System.Drawing.Point(255, 30)
        Me.TBNickname.Name = "TBNickname"
        Me.TBNickname.Size = New System.Drawing.Size(196, 20)
        Me.TBNickname.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 25)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Repeteix la contrasenya"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Contrasenya"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(21, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Cognoms"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 25)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nom d'usuari"
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(26, 326)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(196, 62)
        Me.BTCancelar.TabIndex = 27
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
        '
        'ModificarUsuari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 426)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTModificar)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTCancelar As Button
End Class
