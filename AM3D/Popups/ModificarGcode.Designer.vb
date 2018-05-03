<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarGcode
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
        Me.LMaterialsSup = New System.Windows.Forms.Label()
        Me.CLBMaterialsSup = New System.Windows.Forms.CheckedListBox()
        Me.TBRuta = New System.Windows.Forms.TextBox()
        Me.LRutaFich = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.TBNomGcode = New System.Windows.Forms.TextBox()
        Me.LNomGcode = New System.Windows.Forms.Label()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'LMaterialsSup
        '
        Me.LMaterialsSup.AutoSize = True
        Me.LMaterialsSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterialsSup.ForeColor = System.Drawing.Color.Black
        Me.LMaterialsSup.Location = New System.Drawing.Point(29, 122)
        Me.LMaterialsSup.Name = "LMaterialsSup"
        Me.LMaterialsSup.Size = New System.Drawing.Size(144, 20)
        Me.LMaterialsSup.TabIndex = 65
        Me.LMaterialsSup.Text = "Materials suportats"
        '
        'CLBMaterialsSup
        '
        Me.CLBMaterialsSup.FormattingEnabled = True
        Me.CLBMaterialsSup.Location = New System.Drawing.Point(189, 122)
        Me.CLBMaterialsSup.Name = "CLBMaterialsSup"
        Me.CLBMaterialsSup.Size = New System.Drawing.Size(231, 319)
        Me.CLBMaterialsSup.TabIndex = 64
        '
        'TBRuta
        '
        Me.TBRuta.Location = New System.Drawing.Point(189, 74)
        Me.TBRuta.Name = "TBRuta"
        Me.TBRuta.Size = New System.Drawing.Size(231, 20)
        Me.TBRuta.TabIndex = 63
        '
        'LRutaFich
        '
        Me.LRutaFich.AutoSize = True
        Me.LRutaFich.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRutaFich.ForeColor = System.Drawing.Color.Black
        Me.LRutaFich.Location = New System.Drawing.Point(29, 74)
        Me.LRutaFich.Name = "LRutaFich"
        Me.LRutaFich.Size = New System.Drawing.Size(107, 20)
        Me.LRutaFich.TabIndex = 62
        Me.LRutaFich.Text = "Ruta del fitxer"
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(33, 544)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(387, 62)
        Me.BTCancelar.TabIndex = 61
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
        '
        'BTModificar
        '
        Me.BTModificar.BackColor = System.Drawing.Color.White
        Me.BTModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificar.ForeColor = System.Drawing.Color.Black
        Me.BTModificar.Location = New System.Drawing.Point(33, 469)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(387, 62)
        Me.BTModificar.TabIndex = 60
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = False
        '
        'TBNomGcode
        '
        Me.TBNomGcode.Location = New System.Drawing.Point(189, 36)
        Me.TBNomGcode.Name = "TBNomGcode"
        Me.TBNomGcode.Size = New System.Drawing.Size(231, 20)
        Me.TBNomGcode.TabIndex = 59
        '
        'LNomGcode
        '
        Me.LNomGcode.AutoSize = True
        Me.LNomGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNomGcode.ForeColor = System.Drawing.Color.Black
        Me.LNomGcode.Location = New System.Drawing.Point(29, 36)
        Me.LNomGcode.Name = "LNomGcode"
        Me.LNomGcode.Size = New System.Drawing.Size(105, 20)
        Me.LNomGcode.TabIndex = 58
        Me.LNomGcode.Text = "Nom GCODE"
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(0, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(443, 19)
        Me.MenuSup.TabIndex = 66
        '
        'ModificarGcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(442, 656)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.LMaterialsSup)
        Me.Controls.Add(Me.CLBMaterialsSup)
        Me.Controls.Add(Me.TBRuta)
        Me.Controls.Add(Me.LRutaFich)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTModificar)
        Me.Controls.Add(Me.TBNomGcode)
        Me.Controls.Add(Me.LNomGcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarGcode"
        Me.Text = "ModificarGcode"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LMaterialsSup As Label
    Friend WithEvents CLBMaterialsSup As CheckedListBox
    Friend WithEvents TBRuta As TextBox
    Friend WithEvents LRutaFich As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTModificar As Button
    Friend WithEvents TBNomGcode As TextBox
    Friend WithEvents LNomGcode As Label
    Friend WithEvents MenuSup As Panel
End Class
