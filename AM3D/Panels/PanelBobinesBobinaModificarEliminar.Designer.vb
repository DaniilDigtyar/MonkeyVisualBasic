<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelBobinesBobinaModificarEliminar
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
        Me.BTEliminarBobina = New System.Windows.Forms.Button()
        Me.BTModificarBobina = New System.Windows.Forms.Button()
        Me.DGBobina = New System.Windows.Forms.DataGridView()
        Me.codi_bobina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipus_material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca_bobina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diametre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BResfrescar = New System.Windows.Forms.Button()
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
        Me.BTEliminarBobina.Location = New System.Drawing.Point(172, 16)
        Me.BTEliminarBobina.Name = "BTEliminarBobina"
        Me.BTEliminarBobina.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarBobina.TabIndex = 2
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
        Me.BTModificarBobina.Location = New System.Drawing.Point(12, 16)
        Me.BTModificarBobina.Name = "BTModificarBobina"
        Me.BTModificarBobina.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarBobina.TabIndex = 1
        Me.BTModificarBobina.Text = "Modificar Bobina"
        Me.BTModificarBobina.UseVisualStyleBackColor = False
        '
        'DGBobina
        '
        Me.DGBobina.AllowUserToAddRows = False
        Me.DGBobina.AllowUserToDeleteRows = False
        Me.DGBobina.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGBobina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBobina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codi_bobina, Me.tipus_material, Me.Color, Me.Marca_bobina, Me.diametre})
        Me.DGBobina.Location = New System.Drawing.Point(12, 84)
        Me.DGBobina.Name = "DGBobina"
        Me.DGBobina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGBobina.Size = New System.Drawing.Size(777, 280)
        Me.DGBobina.TabIndex = 4
        '
        'codi_bobina
        '
        Me.codi_bobina.HeaderText = "Codi bobina"
        Me.codi_bobina.Name = "codi_bobina"
        Me.codi_bobina.ReadOnly = True
        '
        'tipus_material
        '
        Me.tipus_material.HeaderText = "Tipus Material"
        Me.tipus_material.Name = "tipus_material"
        Me.tipus_material.ReadOnly = True
        '
        'Color
        '
        Me.Color.HeaderText = "Nombre color"
        Me.Color.Name = "Color"
        Me.Color.ReadOnly = True
        '
        'Marca_bobina
        '
        Me.Marca_bobina.HeaderText = "Marca bobina"
        Me.Marca_bobina.Name = "Marca_bobina"
        Me.Marca_bobina.ReadOnly = True
        '
        'diametre
        '
        Me.diametre.HeaderText = "Diametre"
        Me.diametre.Name = "diametre"
        Me.diametre.ReadOnly = True
        '
        'BResfrescar
        '
        Me.BResfrescar.BackColor = System.Drawing.Color.White
        Me.BResfrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BResfrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BResfrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BResfrescar.ForeColor = System.Drawing.Color.Black
        Me.BResfrescar.Location = New System.Drawing.Point(635, 16)
        Me.BResfrescar.Name = "BResfrescar"
        Me.BResfrescar.Size = New System.Drawing.Size(154, 62)
        Me.BResfrescar.TabIndex = 3
        Me.BResfrescar.Text = "Refresca llista"
        Me.BResfrescar.UseVisualStyleBackColor = False
        '
        'PanelBobinesBobinaModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BResfrescar)
        Me.Controls.Add(Me.DGBobina)
        Me.Controls.Add(Me.BTEliminarBobina)
        Me.Controls.Add(Me.BTModificarBobina)
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
    Friend WithEvents codi_bobina As DataGridViewTextBoxColumn
    Friend WithEvents tipus_material As DataGridViewTextBoxColumn
    Friend WithEvents Color As DataGridViewTextBoxColumn
    Friend WithEvents Marca_bobina As DataGridViewTextBoxColumn
    Friend WithEvents diametre As DataGridViewTextBoxColumn
    Friend WithEvents BResfrescar As Button
End Class
