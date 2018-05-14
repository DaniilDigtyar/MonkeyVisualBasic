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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTEliminarColor = New System.Windows.Forms.Button()
        Me.BTModificarColor = New System.Windows.Forms.Button()
        Me.BResfrescar = New System.Windows.Forms.Button()
        Me.DGMarcaProductora = New System.Windows.Forms.DataGridView()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorBackground = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGMarcaProductora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarColor
        '
        Me.BTEliminarColor.BackColor = System.Drawing.Color.White
        Me.BTEliminarColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarColor.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarColor.Location = New System.Drawing.Point(191, 25)
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
        Me.BTModificarColor.Location = New System.Drawing.Point(31, 25)
        Me.BTModificarColor.Name = "BTModificarColor"
        Me.BTModificarColor.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarColor.TabIndex = 8
        Me.BTModificarColor.Text = "Modificar Color"
        Me.BTModificarColor.UseVisualStyleBackColor = False
        '
        'BResfrescar
        '
        Me.BResfrescar.BackColor = System.Drawing.Color.White
        Me.BResfrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BResfrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BResfrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BResfrescar.ForeColor = System.Drawing.Color.Black
        Me.BResfrescar.Location = New System.Drawing.Point(616, 25)
        Me.BResfrescar.Name = "BResfrescar"
        Me.BResfrescar.Size = New System.Drawing.Size(154, 62)
        Me.BResfrescar.TabIndex = 35
        Me.BResfrescar.Text = "Refresca llista"
        Me.BResfrescar.UseVisualStyleBackColor = False
        '
        'DGMarcaProductora
        '
        Me.DGMarcaProductora.AllowUserToAddRows = False
        Me.DGMarcaProductora.AllowUserToDeleteRows = False
        Me.DGMarcaProductora.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMarcaProductora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMarcaProductora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.color, Me.Hex, Me.ColorBackground})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGMarcaProductora.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGMarcaProductora.Location = New System.Drawing.Point(31, 93)
        Me.DGMarcaProductora.MultiSelect = False
        Me.DGMarcaProductora.Name = "DGMarcaProductora"
        Me.DGMarcaProductora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMarcaProductora.Size = New System.Drawing.Size(739, 268)
        Me.DGMarcaProductora.TabIndex = 36
        '
        'color
        '
        Me.color.HeaderText = "Nombre"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        '
        'Hex
        '
        Me.Hex.HeaderText = "Hex"
        Me.Hex.Name = "Hex"
        Me.Hex.ReadOnly = True
        '
        'ColorBackground
        '
        Me.ColorBackground.HeaderText = "Color"
        Me.ColorBackground.Name = "ColorBackground"
        Me.ColorBackground.ReadOnly = True
        '
        'PanelBobinesColorModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.DGMarcaProductora)
        Me.Controls.Add(Me.BResfrescar)
        Me.Controls.Add(Me.BTEliminarColor)
        Me.Controls.Add(Me.BTModificarColor)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesColorModificarEliminar"
        Me.Text = "PanelBobinesColorModificarEliminar"
        CType(Me.DGMarcaProductora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarColor As Button
    Friend WithEvents BTModificarColor As Button
    Friend WithEvents BResfrescar As Button
    Friend WithEvents DGMarcaProductora As DataGridView
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents Hex As DataGridViewTextBoxColumn
    Friend WithEvents ColorBackground As DataGridViewTextBoxColumn
End Class
