<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarMarca
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
        Me.TBMarca = New System.Windows.Forms.TextBox()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBMarca
        '
        Me.TBMarca.Location = New System.Drawing.Point(175, 25)
        Me.TBMarca.Name = "TBMarca"
        Me.TBMarca.Size = New System.Drawing.Size(141, 20)
        Me.TBMarca.TabIndex = 34
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(47, 25)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(53, 20)
        Me.LMarca.TabIndex = 33
        Me.LMarca.Text = "Marca"
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(51, 155)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(265, 62)
        Me.BTCancelar.TabIndex = 51
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
        Me.BTModificar.Location = New System.Drawing.Point(51, 80)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(265, 62)
        Me.BTModificar.TabIndex = 50
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = False
        '
        'ModificarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(359, 303)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTModificar)
        Me.Controls.Add(Me.TBMarca)
        Me.Controls.Add(Me.LMarca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarMarca"
        Me.Text = "ModificarMarca"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBMarca As TextBox
    Friend WithEvents LMarca As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTModificar As Button
End Class
