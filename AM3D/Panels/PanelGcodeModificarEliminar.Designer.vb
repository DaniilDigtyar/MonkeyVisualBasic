<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelGcodeModificarEliminar
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
        Me.BTEliminarGcode = New System.Windows.Forms.Button()
        Me.BTModificarGcode = New System.Windows.Forms.Button()
        Me.DGGcode = New System.Windows.Forms.DataGridView()
        CType(Me.DGGcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarGcode
        '
        Me.BTEliminarGcode.BackColor = System.Drawing.Color.White
        Me.BTEliminarGcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarGcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarGcode.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarGcode.Location = New System.Drawing.Point(548, 18)
        Me.BTEliminarGcode.Name = "BTEliminarGcode"
        Me.BTEliminarGcode.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarGcode.TabIndex = 9
        Me.BTEliminarGcode.Text = "Eliminar Gcode"
        Me.BTEliminarGcode.UseVisualStyleBackColor = False
        '
        'BTModificarGcode
        '
        Me.BTModificarGcode.BackColor = System.Drawing.Color.White
        Me.BTModificarGcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarGcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarGcode.ForeColor = System.Drawing.Color.Black
        Me.BTModificarGcode.Location = New System.Drawing.Point(99, 18)
        Me.BTModificarGcode.Name = "BTModificarGcode"
        Me.BTModificarGcode.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarGcode.TabIndex = 8
        Me.BTModificarGcode.Text = "Modificar Gcode"
        Me.BTModificarGcode.UseVisualStyleBackColor = False
        '
        'DGGcode
        '
        Me.DGGcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGGcode.Location = New System.Drawing.Point(21, 95)
        Me.DGGcode.Name = "DGGcode"
        Me.DGGcode.Size = New System.Drawing.Size(739, 268)
        Me.DGGcode.TabIndex = 7
        '
        'PanelGcodeModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 380)
        Me.Controls.Add(Me.BTEliminarGcode)
        Me.Controls.Add(Me.BTModificarGcode)
        Me.Controls.Add(Me.DGGcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelGcodeModificarEliminar"
        Me.Text = "PanelGcodeModificarEliminar"
        CType(Me.DGGcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarGcode As Button
    Friend WithEvents BTModificarGcode As Button
    Friend WithEvents DGGcode As DataGridView
End Class
