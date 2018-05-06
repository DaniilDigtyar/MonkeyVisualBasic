<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBobinesMaterialModificarEliminar
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
        Me.BTEliminarMaterial = New System.Windows.Forms.Button()
        Me.BTModificarMaterial = New System.Windows.Forms.Button()
        Me.DGMaterial = New System.Windows.Forms.DataGridView()
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarMaterial
        '
        Me.BTEliminarMaterial.BackColor = System.Drawing.Color.White
        Me.BTEliminarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarMaterial.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarMaterial.Location = New System.Drawing.Point(558, 16)
        Me.BTEliminarMaterial.Name = "BTEliminarMaterial"
        Me.BTEliminarMaterial.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarMaterial.TabIndex = 12
        Me.BTEliminarMaterial.Text = "Eliminar Material"
        Me.BTEliminarMaterial.UseVisualStyleBackColor = False
        '
        'BTModificarMaterial
        '
        Me.BTModificarMaterial.BackColor = System.Drawing.Color.White
        Me.BTModificarMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarMaterial.ForeColor = System.Drawing.Color.Black
        Me.BTModificarMaterial.Location = New System.Drawing.Point(109, 16)
        Me.BTModificarMaterial.Name = "BTModificarMaterial"
        Me.BTModificarMaterial.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarMaterial.TabIndex = 11
        Me.BTModificarMaterial.Text = "Modificar Material"
        Me.BTModificarMaterial.UseVisualStyleBackColor = False
        '
        'DGMaterial
        '
        Me.DGMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMaterial.Location = New System.Drawing.Point(31, 93)
        Me.DGMaterial.Name = "DGMaterial"
        Me.DGMaterial.Size = New System.Drawing.Size(739, 268)
        Me.DGMaterial.TabIndex = 10
        '
        'PanelBobinesMaterialModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BTEliminarMaterial)
        Me.Controls.Add(Me.BTModificarMaterial)
        Me.Controls.Add(Me.DGMaterial)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesMaterialModificarEliminar"
        Me.Text = "PanelBobinesMaterialModificarEliminar"
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarMaterial As Button
    Friend WithEvents BTModificarMaterial As Button
    Friend WithEvents DGMaterial As DataGridView
End Class
