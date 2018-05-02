<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBobinesMarcaModificarEliminar
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
        Me.BTEliminarMarca.TabIndex = 12
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
        Me.BTModificarMarca.TabIndex = 11
        Me.BTModificarMarca.Text = "Modificar Marca"
        Me.BTModificarMarca.UseVisualStyleBackColor = False
        '
        'DGMarca
        '
        Me.DGMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMarca.Location = New System.Drawing.Point(31, 93)
        Me.DGMarca.Name = "DGMarca"
        Me.DGMarca.Size = New System.Drawing.Size(739, 268)
        Me.DGMarca.TabIndex = 10
        '
        'PanelBobinesMarcaModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BTEliminarMarca)
        Me.Controls.Add(Me.BTModificarMarca)
        Me.Controls.Add(Me.DGMarca)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesMarcaModificarEliminar"
        Me.Text = "PanelBobinesMarcaModificarEliminar"
        CType(Me.DGMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarMarca As Button
    Friend WithEvents BTModificarMarca As Button
    Friend WithEvents DGMarca As DataGridView
End Class
