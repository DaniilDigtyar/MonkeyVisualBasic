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
        Me.DGMarcaProductora = New System.Windows.Forms.DataGridView()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BResfrescar = New System.Windows.Forms.Button()
        CType(Me.DGMarcaProductora, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarMarca
        '
        Me.BTEliminarMarca.BackColor = System.Drawing.Color.White
        Me.BTEliminarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarMarca.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarMarca.Location = New System.Drawing.Point(196, 16)
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
        Me.BTModificarMarca.Location = New System.Drawing.Point(36, 16)
        Me.BTModificarMarca.Name = "BTModificarMarca"
        Me.BTModificarMarca.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarMarca.TabIndex = 11
        Me.BTModificarMarca.Text = "Modificar Marca"
        Me.BTModificarMarca.UseVisualStyleBackColor = False
        '
        'DGMarcaProductora
        '
        Me.DGMarcaProductora.AllowUserToAddRows = False
        Me.DGMarcaProductora.AllowUserToDeleteRows = False
        Me.DGMarcaProductora.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMarcaProductora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMarcaProductora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.marca})
        Me.DGMarcaProductora.Location = New System.Drawing.Point(36, 84)
        Me.DGMarcaProductora.MultiSelect = False
        Me.DGMarcaProductora.Name = "DGMarcaProductora"
        Me.DGMarcaProductora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMarcaProductora.Size = New System.Drawing.Size(739, 268)
        Me.DGMarcaProductora.TabIndex = 32
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 200
        '
        'BResfrescar
        '
        Me.BResfrescar.BackColor = System.Drawing.Color.White
        Me.BResfrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BResfrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BResfrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BResfrescar.ForeColor = System.Drawing.Color.Black
        Me.BResfrescar.Location = New System.Drawing.Point(621, 16)
        Me.BResfrescar.Name = "BResfrescar"
        Me.BResfrescar.Size = New System.Drawing.Size(154, 62)
        Me.BResfrescar.TabIndex = 34
        Me.BResfrescar.Text = "Refresca llista"
        Me.BResfrescar.UseVisualStyleBackColor = False
        '
        'PanelBobinesMarcaModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BResfrescar)
        Me.Controls.Add(Me.DGMarcaProductora)
        Me.Controls.Add(Me.BTEliminarMarca)
        Me.Controls.Add(Me.BTModificarMarca)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesMarcaModificarEliminar"
        Me.Text = "PanelBobinesMarcaModificarEliminar"
        CType(Me.DGMarcaProductora, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarMarca As Button
    Friend WithEvents BTModificarMarca As Button
    Friend WithEvents DGMarcaProductora As DataGridView
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents BResfrescar As Button
End Class
