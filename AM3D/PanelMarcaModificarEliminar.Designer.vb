<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelMarcaModificarEliminar
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
        Me.BTEliminarMarca = New System.Windows.Forms.Button()
        Me.BTModificarMarca = New System.Windows.Forms.Button()
        Me.DGMarca = New System.Windows.Forms.DataGridView()
        CType(Me.DGMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarMarca
        '
        Me.BTEliminarMarca.BackColor = System.Drawing.Color.White
        Me.BTEliminarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarMarca.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarMarca.Location = New System.Drawing.Point(558, 16)
        Me.BTEliminarMarca.Name = "BTEliminarMarca"
        Me.BTEliminarMarca.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarMarca.TabIndex = 9
        Me.BTEliminarMarca.Text = "Eliminar Marca"
        Me.BTEliminarMarca.UseVisualStyleBackColor = False
        '
        'BTModificarMarca
        '
        Me.BTModificarMarca.BackColor = System.Drawing.Color.White
        Me.BTModificarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarMarca.ForeColor = System.Drawing.Color.Black
        Me.BTModificarMarca.Location = New System.Drawing.Point(109, 16)
        Me.BTModificarMarca.Name = "BTModificarMarca"
        Me.BTModificarMarca.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarMarca.TabIndex = 8
        Me.BTModificarMarca.Text = "Modificar Marca"
        Me.BTModificarMarca.UseVisualStyleBackColor = False
        '
        'DGMarca
        '
        Me.DGMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMarca.Location = New System.Drawing.Point(31, 93)
        Me.DGMarca.Name = "DGMarca"
        Me.DGMarca.Size = New System.Drawing.Size(739, 268)
        Me.DGMarca.TabIndex = 7
        '
        'PanelMarcaModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BTEliminarMarca)
        Me.Controls.Add(Me.BTModificarMarca)
        Me.Controls.Add(Me.DGMarca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelMarcaModificarEliminar"
        Me.Text = "PanelMarcaModificarEliminar"
        CType(Me.DGMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarMarca As Button
    Friend WithEvents BTModificarMarca As Button
    Friend WithEvents DGMarca As DataGridView
End Class
