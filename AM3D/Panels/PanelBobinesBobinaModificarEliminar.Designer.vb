<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBobinesBobinaModificarEliminar
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
        Me.BTEliminarBobina = New System.Windows.Forms.Button()
        Me.BTModificarBobina = New System.Windows.Forms.Button()
        Me.DGBobina = New System.Windows.Forms.DataGridView()
        CType(Me.DGBobina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarBobina
        '
        Me.BTEliminarBobina.BackColor = System.Drawing.Color.White
        Me.BTEliminarBobina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarBobina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarBobina.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarBobina.Location = New System.Drawing.Point(558, 16)
        Me.BTEliminarBobina.Name = "BTEliminarBobina"
        Me.BTEliminarBobina.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarBobina.TabIndex = 9
        Me.BTEliminarBobina.Text = "Eliminar Bobina"
        Me.BTEliminarBobina.UseVisualStyleBackColor = False
        '
        'BTModificarBobina
        '
        Me.BTModificarBobina.BackColor = System.Drawing.Color.White
        Me.BTModificarBobina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarBobina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarBobina.ForeColor = System.Drawing.Color.Black
        Me.BTModificarBobina.Location = New System.Drawing.Point(109, 16)
        Me.BTModificarBobina.Name = "BTModificarBobina"
        Me.BTModificarBobina.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarBobina.TabIndex = 8
        Me.BTModificarBobina.Text = "Modificar Bobina"
        Me.BTModificarBobina.UseVisualStyleBackColor = False
        '
        'DGBobina
        '
        Me.DGBobina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBobina.Location = New System.Drawing.Point(31, 93)
        Me.DGBobina.Name = "DGBobina"
        Me.DGBobina.Size = New System.Drawing.Size(739, 268)
        Me.DGBobina.TabIndex = 7
        '
        'PanelBobinesBobinaModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BTEliminarBobina)
        Me.Controls.Add(Me.BTModificarBobina)
        Me.Controls.Add(Me.DGBobina)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesBobinaModificarEliminar"
        Me.Text = "PanelBobinesBobinaModificarEliminar"
        CType(Me.DGBobina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarBobina As Button
    Friend WithEvents BTModificarBobina As Button
    Friend WithEvents DGBobina As DataGridView
End Class
