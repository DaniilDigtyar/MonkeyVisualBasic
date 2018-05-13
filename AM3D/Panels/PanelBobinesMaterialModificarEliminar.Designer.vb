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
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BResfrescar = New System.Windows.Forms.Button()
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
        Me.BTEliminarMaterial.Location = New System.Drawing.Point(189, 16)
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
        Me.BTModificarMaterial.Location = New System.Drawing.Point(29, 16)
        Me.BTModificarMaterial.Name = "BTModificarMaterial"
        Me.BTModificarMaterial.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarMaterial.TabIndex = 11
        Me.BTModificarMaterial.Text = "Modificar Material"
        Me.BTModificarMaterial.UseVisualStyleBackColor = False
        '
        'DGMaterial
        '
        Me.DGMaterial.AllowUserToAddRows = False
        Me.DGMaterial.AllowUserToDeleteRows = False
        Me.DGMaterial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.material, Me.descripcio})
        Me.DGMaterial.Location = New System.Drawing.Point(29, 84)
        Me.DGMaterial.Name = "DGMaterial"
        Me.DGMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMaterial.Size = New System.Drawing.Size(739, 268)
        Me.DGMaterial.TabIndex = 31
        '
        'material
        '
        Me.material.HeaderText = "Material"
        Me.material.Name = "material"
        Me.material.ReadOnly = True
        '
        'descripcio
        '
        Me.descripcio.HeaderText = "Descripció"
        Me.descripcio.Name = "descripcio"
        Me.descripcio.ReadOnly = True
        Me.descripcio.Width = 200
        '
        'BResfrescar
        '
        Me.BResfrescar.BackColor = System.Drawing.Color.White
        Me.BResfrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BResfrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BResfrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BResfrescar.ForeColor = System.Drawing.Color.Black
        Me.BResfrescar.Location = New System.Drawing.Point(614, 16)
        Me.BResfrescar.Name = "BResfrescar"
        Me.BResfrescar.Size = New System.Drawing.Size(154, 62)
        Me.BResfrescar.TabIndex = 33
        Me.BResfrescar.Text = "Refresca llista"
        Me.BResfrescar.UseVisualStyleBackColor = False
        '
        'PanelBobinesMaterialModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BResfrescar)
        Me.Controls.Add(Me.DGMaterial)
        Me.Controls.Add(Me.BTEliminarMaterial)
        Me.Controls.Add(Me.BTModificarMaterial)
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
    Friend WithEvents material As DataGridViewTextBoxColumn
    Friend WithEvents descripcio As DataGridViewTextBoxColumn
    Friend WithEvents BResfrescar As Button
End Class
