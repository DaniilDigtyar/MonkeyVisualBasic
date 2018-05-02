<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelLlistaImpressores
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGImpressores = New System.Windows.Forms.DataGridView()
        Me.BTCambiarBobina = New System.Windows.Forms.Button()
        Me.BTModificarImpressora = New System.Windows.Forms.Button()
        Me.BTEliminarImpressora = New System.Windows.Forms.Button()
        CType(Me.DGImpressores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGImpressores
        '
        Me.DGImpressores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGImpressores.Location = New System.Drawing.Point(37, 98)
        Me.DGImpressores.Name = "DGImpressores"
        Me.DGImpressores.Size = New System.Drawing.Size(729, 246)
        Me.DGImpressores.TabIndex = 0
        '
        'BTCambiarBobina
        '
        Me.BTCambiarBobina.BackColor = System.Drawing.Color.White
        Me.BTCambiarBobina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCambiarBobina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCambiarBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCambiarBobina.ForeColor = System.Drawing.Color.Black
        Me.BTCambiarBobina.Location = New System.Drawing.Point(37, 21)
        Me.BTCambiarBobina.Name = "BTCambiarBobina"
        Me.BTCambiarBobina.Size = New System.Drawing.Size(154, 62)
        Me.BTCambiarBobina.TabIndex = 2
        Me.BTCambiarBobina.Text = "Canviar Bobina"
        Me.BTCambiarBobina.UseVisualStyleBackColor = False
        '
        'BTModificarImpressora
        '
        Me.BTModificarImpressora.BackColor = System.Drawing.Color.White
        Me.BTModificarImpressora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarImpressora.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarImpressora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarImpressora.ForeColor = System.Drawing.Color.Black
        Me.BTModificarImpressora.Location = New System.Drawing.Point(326, 21)
        Me.BTModificarImpressora.Name = "BTModificarImpressora"
        Me.BTModificarImpressora.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarImpressora.TabIndex = 3
        Me.BTModificarImpressora.Text = "Modificar impressora"
        Me.BTModificarImpressora.UseVisualStyleBackColor = False
        '
        'BTEliminarImpressora
        '
        Me.BTEliminarImpressora.BackColor = System.Drawing.Color.White
        Me.BTEliminarImpressora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarImpressora.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarImpressora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarImpressora.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarImpressora.Location = New System.Drawing.Point(612, 21)
        Me.BTEliminarImpressora.Name = "BTEliminarImpressora"
        Me.BTEliminarImpressora.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarImpressora.TabIndex = 4
        Me.BTEliminarImpressora.Text = "Eliminar impressora"
        Me.BTEliminarImpressora.UseVisualStyleBackColor = False
        '
        'PanelLlistaImpressores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(802, 374)
        Me.Controls.Add(Me.BTEliminarImpressora)
        Me.Controls.Add(Me.BTModificarImpressora)
        Me.Controls.Add(Me.BTCambiarBobina)
        Me.Controls.Add(Me.DGImpressores)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelLlistaImpressores"
        Me.Text = "PanelLlistaImpressores"
        CType(Me.DGImpressores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGImpressores As DataGridView
    Friend WithEvents BTCambiarBobina As Button
    Friend WithEvents BTModificarImpressora As Button
    Friend WithEvents BTEliminarImpressora As Button
End Class
