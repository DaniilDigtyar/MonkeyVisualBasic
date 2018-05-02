<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelGcodeAfegir
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
        Me.BTBorrar = New System.Windows.Forms.Button()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.TBNomGcode = New System.Windows.Forms.TextBox()
        Me.LNomGcode = New System.Windows.Forms.Label()
        Me.TBRuta = New System.Windows.Forms.TextBox()
        Me.LRuta = New System.Windows.Forms.Label()
        Me.CLBMaterialsSup = New System.Windows.Forms.CheckedListBox()
        Me.LMaterialsSup = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTBorrar
        '
        Me.BTBorrar.BackColor = System.Drawing.Color.White
        Me.BTBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBorrar.ForeColor = System.Drawing.Color.Black
        Me.BTBorrar.Location = New System.Drawing.Point(64, 229)
        Me.BTBorrar.Name = "BTBorrar"
        Me.BTBorrar.Size = New System.Drawing.Size(265, 62)
        Me.BTBorrar.TabIndex = 53
        Me.BTBorrar.Text = "Borrar"
        Me.BTBorrar.UseVisualStyleBackColor = False
        '
        'BTAfegir
        '
        Me.BTAfegir.BackColor = System.Drawing.Color.White
        Me.BTAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTAfegir.Location = New System.Drawing.Point(64, 154)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(265, 62)
        Me.BTAfegir.TabIndex = 52
        Me.BTAfegir.Text = "Afegir"
        Me.BTAfegir.UseVisualStyleBackColor = False
        '
        'TBNomGcode
        '
        Me.TBNomGcode.Location = New System.Drawing.Point(188, 44)
        Me.TBNomGcode.Name = "TBNomGcode"
        Me.TBNomGcode.Size = New System.Drawing.Size(141, 20)
        Me.TBNomGcode.TabIndex = 51
        '
        'LNomGcode
        '
        Me.LNomGcode.AutoSize = True
        Me.LNomGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNomGcode.ForeColor = System.Drawing.Color.Black
        Me.LNomGcode.Location = New System.Drawing.Point(60, 44)
        Me.LNomGcode.Name = "LNomGcode"
        Me.LNomGcode.Size = New System.Drawing.Size(105, 20)
        Me.LNomGcode.TabIndex = 50
        Me.LNomGcode.Text = "Nom GCODE"
        '
        'TBRuta
        '
        Me.TBRuta.Location = New System.Drawing.Point(188, 93)
        Me.TBRuta.Name = "TBRuta"
        Me.TBRuta.Size = New System.Drawing.Size(141, 20)
        Me.TBRuta.TabIndex = 55
        '
        'LRuta
        '
        Me.LRuta.AutoSize = True
        Me.LRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRuta.ForeColor = System.Drawing.Color.Black
        Me.LRuta.Location = New System.Drawing.Point(60, 93)
        Me.LRuta.Name = "LRuta"
        Me.LRuta.Size = New System.Drawing.Size(107, 20)
        Me.LRuta.TabIndex = 54
        Me.LRuta.Text = "Ruta del fitxer"
        '
        'CLBMaterialsSup
        '
        Me.CLBMaterialsSup.FormattingEnabled = True
        Me.CLBMaterialsSup.Location = New System.Drawing.Point(525, 44)
        Me.CLBMaterialsSup.Name = "CLBMaterialsSup"
        Me.CLBMaterialsSup.Size = New System.Drawing.Size(231, 289)
        Me.CLBMaterialsSup.TabIndex = 56
        '
        'LMaterialsSup
        '
        Me.LMaterialsSup.AutoSize = True
        Me.LMaterialsSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterialsSup.ForeColor = System.Drawing.Color.Black
        Me.LMaterialsSup.Location = New System.Drawing.Point(364, 44)
        Me.LMaterialsSup.Name = "LMaterialsSup"
        Me.LMaterialsSup.Size = New System.Drawing.Size(144, 20)
        Me.LMaterialsSup.TabIndex = 57
        Me.LMaterialsSup.Text = "Materials suportats"
        '
        'PanelGcodeAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 380)
        Me.Controls.Add(Me.LMaterialsSup)
        Me.Controls.Add(Me.CLBMaterialsSup)
        Me.Controls.Add(Me.TBRuta)
        Me.Controls.Add(Me.LRuta)
        Me.Controls.Add(Me.BTBorrar)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.TBNomGcode)
        Me.Controls.Add(Me.LNomGcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelGcodeAfegir"
        Me.Text = "PanelGcodeAfegir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTBorrar As Button
    Friend WithEvents BTAfegir As Button
    Friend WithEvents TBNomGcode As TextBox
    Friend WithEvents LNomGcode As Label
    Friend WithEvents TBRuta As TextBox
    Friend WithEvents LRuta As Label
    Friend WithEvents CLBMaterialsSup As CheckedListBox
    Friend WithEvents LMaterialsSup As Label
End Class
