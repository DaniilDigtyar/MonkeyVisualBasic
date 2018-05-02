<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelModelModificarEliminar
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
        Me.BTEliminarModel = New System.Windows.Forms.Button()
        Me.BTModificarModel = New System.Windows.Forms.Button()
        Me.DGModel = New System.Windows.Forms.DataGridView()
        CType(Me.DGModel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarModel
        '
        Me.BTEliminarModel.BackColor = System.Drawing.Color.White
        Me.BTEliminarModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarModel.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarModel.Location = New System.Drawing.Point(558, 16)
        Me.BTEliminarModel.Name = "BTEliminarModel"
        Me.BTEliminarModel.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarModel.TabIndex = 9
        Me.BTEliminarModel.Text = "Eliminar Model"
        Me.BTEliminarModel.UseVisualStyleBackColor = False
        '
        'BTModificarModel
        '
        Me.BTModificarModel.BackColor = System.Drawing.Color.White
        Me.BTModificarModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarModel.ForeColor = System.Drawing.Color.Black
        Me.BTModificarModel.Location = New System.Drawing.Point(109, 16)
        Me.BTModificarModel.Name = "BTModificarModel"
        Me.BTModificarModel.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarModel.TabIndex = 8
        Me.BTModificarModel.Text = "Modificar Model"
        Me.BTModificarModel.UseVisualStyleBackColor = False
        '
        'DGModel
        '
        Me.DGModel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGModel.Location = New System.Drawing.Point(12, 93)
        Me.DGModel.Name = "DGModel"
        Me.DGModel.Size = New System.Drawing.Size(777, 268)
        Me.DGModel.TabIndex = 7
        '
        'PanelModelModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BTEliminarModel)
        Me.Controls.Add(Me.BTModificarModel)
        Me.Controls.Add(Me.DGModel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelModelModificarEliminar"
        Me.Text = "PanelModelModificarEliminar"
        CType(Me.DGModel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarModel As Button
    Friend WithEvents BTModificarModel As Button
    Friend WithEvents DGModel As DataGridView
End Class
