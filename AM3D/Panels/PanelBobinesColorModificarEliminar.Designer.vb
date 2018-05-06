<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBobinesColorModificarEliminar
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
        Me.BTEliminarColor = New System.Windows.Forms.Button()
        Me.BTModificarColor = New System.Windows.Forms.Button()
        Me.DGColor = New System.Windows.Forms.DataGridView()
        CType(Me.DGColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarColor
        '
        Me.BTEliminarColor.BackColor = System.Drawing.Color.White
        Me.BTEliminarColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarColor.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarColor.Location = New System.Drawing.Point(558, 16)
        Me.BTEliminarColor.Name = "BTEliminarColor"
        Me.BTEliminarColor.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarColor.TabIndex = 9
        Me.BTEliminarColor.Text = "Eliminar Color"
        Me.BTEliminarColor.UseVisualStyleBackColor = False
        '
        'BTModificarColor
        '
        Me.BTModificarColor.BackColor = System.Drawing.Color.White
        Me.BTModificarColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarColor.ForeColor = System.Drawing.Color.Black
        Me.BTModificarColor.Location = New System.Drawing.Point(109, 16)
        Me.BTModificarColor.Name = "BTModificarColor"
        Me.BTModificarColor.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarColor.TabIndex = 8
        Me.BTModificarColor.Text = "Modificar Color"
        Me.BTModificarColor.UseVisualStyleBackColor = False
        '
        'DGColor
        '
        Me.DGColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGColor.Location = New System.Drawing.Point(31, 93)
        Me.DGColor.Name = "DGColor"
        Me.DGColor.Size = New System.Drawing.Size(739, 268)
        Me.DGColor.TabIndex = 7
        '
        'PanelBobinesColorModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BTEliminarColor)
        Me.Controls.Add(Me.BTModificarColor)
        Me.Controls.Add(Me.DGColor)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesColorModificarEliminar"
        Me.Text = "PanelBobinesColorModificarEliminar"
        CType(Me.DGColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarColor As Button
    Friend WithEvents BTModificarColor As Button
    Friend WithEvents DGColor As DataGridView
End Class
