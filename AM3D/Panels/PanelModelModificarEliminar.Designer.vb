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
        Me.DGMarca = New System.Windows.Forms.DataGridView()
        Me.BResfrescar = New System.Windows.Forms.Button()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_extrusors = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temperatura_minima_extrusor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temperatura_maxima_extrusor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temperatura_minima_llit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temperatura_maxima_llit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area_impressio_x = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area_impressio_y = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area_impressio_z = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.velocitat_maxima_capcal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resolucio_capa_maxima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.resolucio_capa_minima = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.diametre_filament_acceptat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarModel
        '
        Me.BTEliminarModel.BackColor = System.Drawing.Color.White
        Me.BTEliminarModel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarModel.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarModel.Location = New System.Drawing.Point(172, 16)
        Me.BTEliminarModel.Name = "BTEliminarModel"
        Me.BTEliminarModel.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarModel.TabIndex = 2
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
        Me.BTModificarModel.Location = New System.Drawing.Point(12, 16)
        Me.BTModificarModel.Name = "BTModificarModel"
        Me.BTModificarModel.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarModel.TabIndex = 1
        Me.BTModificarModel.Text = "Modificar Model"
        Me.BTModificarModel.UseVisualStyleBackColor = False
        '
        'DGMarca
        '
        Me.DGMarca.AllowUserToAddRows = False
        Me.DGMarca.AllowUserToDeleteRows = False
        Me.DGMarca.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMarca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.marca, Me.Model, Me.num_extrusors, Me.temperatura_minima_extrusor, Me.temperatura_maxima_extrusor, Me.temperatura_minima_llit, Me.temperatura_maxima_llit, Me.area_impressio_x, Me.area_impressio_y, Me.area_impressio_z, Me.velocitat_maxima_capcal, Me.resolucio_capa_maxima, Me.resolucio_capa_minima, Me.diametre_filament_acceptat})
        Me.DGMarca.Location = New System.Drawing.Point(12, 84)
        Me.DGMarca.Name = "DGMarca"
        Me.DGMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMarca.Size = New System.Drawing.Size(777, 268)
        Me.DGMarca.TabIndex = 4
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
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'Model
        '
        Me.Model.HeaderText = "Model"
        Me.Model.Name = "Model"
        Me.Model.ReadOnly = True
        '
        'num_extrusors
        '
        Me.num_extrusors.HeaderText = "Nº extrusors"
        Me.num_extrusors.Name = "num_extrusors"
        Me.num_extrusors.ReadOnly = True
        '
        'temperatura_minima_extrusor
        '
        Me.temperatura_minima_extrusor.HeaderText = "Tª Mín. Extrusor"
        Me.temperatura_minima_extrusor.Name = "temperatura_minima_extrusor"
        Me.temperatura_minima_extrusor.ReadOnly = True
        '
        'temperatura_maxima_extrusor
        '
        Me.temperatura_maxima_extrusor.HeaderText = "Tª Màx. Extrusor"
        Me.temperatura_maxima_extrusor.Name = "temperatura_maxima_extrusor"
        Me.temperatura_maxima_extrusor.ReadOnly = True
        '
        'temperatura_minima_llit
        '
        Me.temperatura_minima_llit.HeaderText = "Tª Mín. Llit"
        Me.temperatura_minima_llit.Name = "temperatura_minima_llit"
        Me.temperatura_minima_llit.ReadOnly = True
        '
        'temperatura_maxima_llit
        '
        Me.temperatura_maxima_llit.HeaderText = "Tª Màx. Llit"
        Me.temperatura_maxima_llit.Name = "temperatura_maxima_llit"
        Me.temperatura_maxima_llit.ReadOnly = True
        '
        'area_impressio_x
        '
        Me.area_impressio_x.HeaderText = "Àrea X"
        Me.area_impressio_x.Name = "area_impressio_x"
        Me.area_impressio_x.ReadOnly = True
        '
        'area_impressio_y
        '
        Me.area_impressio_y.HeaderText = "Àrea Y"
        Me.area_impressio_y.Name = "area_impressio_y"
        Me.area_impressio_y.ReadOnly = True
        '
        'area_impressio_z
        '
        Me.area_impressio_z.HeaderText = "Àrea Z"
        Me.area_impressio_z.Name = "area_impressio_z"
        Me.area_impressio_z.ReadOnly = True
        '
        'velocitat_maxima_capcal
        '
        Me.velocitat_maxima_capcal.HeaderText = "Vel. Capçal"
        Me.velocitat_maxima_capcal.Name = "velocitat_maxima_capcal"
        Me.velocitat_maxima_capcal.ReadOnly = True
        '
        'resolucio_capa_maxima
        '
        Me.resolucio_capa_maxima.HeaderText = "Res. Capa Màx."
        Me.resolucio_capa_maxima.Name = "resolucio_capa_maxima"
        Me.resolucio_capa_maxima.ReadOnly = True
        '
        'resolucio_capa_minima
        '
        Me.resolucio_capa_minima.HeaderText = "Res. Capa Mín."
        Me.resolucio_capa_minima.Name = "resolucio_capa_minima"
        Me.resolucio_capa_minima.ReadOnly = True
        '
        'diametre_filament_acceptat
        '
        Me.diametre_filament_acceptat.HeaderText = "Diàmetre Filament"
        Me.diametre_filament_acceptat.Name = "diametre_filament_acceptat"
        Me.diametre_filament_acceptat.ReadOnly = True
        '
        'PanelModelModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BResfrescar)
        Me.Controls.Add(Me.DGMarca)
        Me.Controls.Add(Me.BTEliminarModel)
        Me.Controls.Add(Me.BTModificarModel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelModelModificarEliminar"
        Me.Text = "PanelModelModificarEliminar"
        CType(Me.DGMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarModel As Button
    Friend WithEvents BTModificarModel As Button
    Friend WithEvents DGMarca As DataGridView
    Friend WithEvents BResfrescar As Button
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents num_extrusors As DataGridViewTextBoxColumn
    Friend WithEvents temperatura_minima_extrusor As DataGridViewTextBoxColumn
    Friend WithEvents temperatura_maxima_extrusor As DataGridViewTextBoxColumn
    Friend WithEvents temperatura_minima_llit As DataGridViewTextBoxColumn
    Friend WithEvents temperatura_maxima_llit As DataGridViewTextBoxColumn
    Friend WithEvents area_impressio_x As DataGridViewTextBoxColumn
    Friend WithEvents area_impressio_y As DataGridViewTextBoxColumn
    Friend WithEvents area_impressio_z As DataGridViewTextBoxColumn
    Friend WithEvents velocitat_maxima_capcal As DataGridViewTextBoxColumn
    Friend WithEvents resolucio_capa_maxima As DataGridViewTextBoxColumn
    Friend WithEvents resolucio_capa_minima As DataGridViewTextBoxColumn
    Friend WithEvents diametre_filament_acceptat As DataGridViewTextBoxColumn
End Class
