<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarModel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarModel))
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.LMaterialSup = New System.Windows.Forms.Label()
        Me.TBDiametre = New System.Windows.Forms.TextBox()
        Me.TBResMaxCap = New System.Windows.Forms.TextBox()
        Me.TBResMinCap = New System.Windows.Forms.TextBox()
        Me.TBVelMinExt = New System.Windows.Forms.TextBox()
        Me.TBImpZ = New System.Windows.Forms.TextBox()
        Me.TBAImpY = New System.Windows.Forms.TextBox()
        Me.TBAImpX = New System.Windows.Forms.TextBox()
        Me.TBTempMinLlit = New System.Windows.Forms.TextBox()
        Me.TBTempMaxLlit = New System.Windows.Forms.TextBox()
        Me.TBTempMinExt = New System.Windows.Forms.TextBox()
        Me.TBTempMaxEx = New System.Windows.Forms.TextBox()
        Me.TBExtrusors = New System.Windows.Forms.TextBox()
        Me.TBModel = New System.Windows.Forms.TextBox()
        Me.LDiametre = New System.Windows.Forms.Label()
        Me.LResMaxCapa = New System.Windows.Forms.Label()
        Me.LResMinCapa = New System.Windows.Forms.Label()
        Me.LVelMaxExt = New System.Windows.Forms.Label()
        Me.LAreaY = New System.Windows.Forms.Label()
        Me.LAreaX = New System.Windows.Forms.Label()
        Me.LTempMinLlit = New System.Windows.Forms.Label()
        Me.LTempMaxLlit = New System.Windows.Forms.Label()
        Me.LTempMinExt = New System.Windows.Forms.Label()
        Me.LTempMaxExt = New System.Windows.Forms.Label()
        Me.LNExtru = New System.Windows.Forms.Label()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.LModel = New System.Windows.Forms.Label()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.DGMaterial = New System.Windows.Forms.DataGridView()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.LAreaZ = New System.Windows.Forms.Label()
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(443, 281)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(189, 62)
        Me.BTCancelar.TabIndex = 17
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
        '
        'BTModificar
        '
        Me.BTModificar.BackColor = System.Drawing.Color.White
        Me.BTModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificar.ForeColor = System.Drawing.Color.Black
        Me.BTModificar.Location = New System.Drawing.Point(443, 206)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(189, 62)
        Me.BTModificar.TabIndex = 16
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = False
        '
        'LMaterialSup
        '
        Me.LMaterialSup.AutoSize = True
        Me.LMaterialSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterialSup.ForeColor = System.Drawing.Color.Black
        Me.LMaterialSup.Location = New System.Drawing.Point(439, 159)
        Me.LMaterialSup.Name = "LMaterialSup"
        Me.LMaterialSup.Size = New System.Drawing.Size(131, 20)
        Me.LMaterialSup.TabIndex = 77
        Me.LMaterialSup.Text = "Material Suportat"
        '
        'TBDiametre
        '
        Me.TBDiametre.Location = New System.Drawing.Point(676, 124)
        Me.TBDiametre.MaxLength = 20
        Me.TBDiametre.Name = "TBDiametre"
        Me.TBDiametre.Size = New System.Drawing.Size(106, 20)
        Me.TBDiametre.TabIndex = 14
        '
        'TBResMaxCap
        '
        Me.TBResMaxCap.Location = New System.Drawing.Point(676, 93)
        Me.TBResMaxCap.MaxLength = 20
        Me.TBResMaxCap.Name = "TBResMaxCap"
        Me.TBResMaxCap.Size = New System.Drawing.Size(106, 20)
        Me.TBResMaxCap.TabIndex = 13
        '
        'TBResMinCap
        '
        Me.TBResMinCap.Location = New System.Drawing.Point(676, 60)
        Me.TBResMinCap.MaxLength = 20
        Me.TBResMinCap.Name = "TBResMinCap"
        Me.TBResMinCap.Size = New System.Drawing.Size(106, 20)
        Me.TBResMinCap.TabIndex = 12
        '
        'TBVelMinExt
        '
        Me.TBVelMinExt.Location = New System.Drawing.Point(676, 28)
        Me.TBVelMinExt.MaxLength = 20
        Me.TBVelMinExt.Name = "TBVelMinExt"
        Me.TBVelMinExt.Size = New System.Drawing.Size(106, 20)
        Me.TBVelMinExt.TabIndex = 11
        '
        'TBImpZ
        '
        Me.TBImpZ.Location = New System.Drawing.Point(277, 323)
        Me.TBImpZ.MaxLength = 20
        Me.TBImpZ.Name = "TBImpZ"
        Me.TBImpZ.Size = New System.Drawing.Size(141, 20)
        Me.TBImpZ.TabIndex = 10
        '
        'TBAImpY
        '
        Me.TBAImpY.Location = New System.Drawing.Point(277, 294)
        Me.TBAImpY.MaxLength = 20
        Me.TBAImpY.Name = "TBAImpY"
        Me.TBAImpY.Size = New System.Drawing.Size(141, 20)
        Me.TBAImpY.TabIndex = 9
        '
        'TBAImpX
        '
        Me.TBAImpX.Location = New System.Drawing.Point(277, 265)
        Me.TBAImpX.MaxLength = 20
        Me.TBAImpX.Name = "TBAImpX"
        Me.TBAImpX.Size = New System.Drawing.Size(141, 20)
        Me.TBAImpX.TabIndex = 8
        '
        'TBTempMinLlit
        '
        Me.TBTempMinLlit.Location = New System.Drawing.Point(277, 229)
        Me.TBTempMinLlit.MaxLength = 20
        Me.TBTempMinLlit.Name = "TBTempMinLlit"
        Me.TBTempMinLlit.Size = New System.Drawing.Size(141, 20)
        Me.TBTempMinLlit.TabIndex = 7
        '
        'TBTempMaxLlit
        '
        Me.TBTempMaxLlit.Location = New System.Drawing.Point(277, 194)
        Me.TBTempMaxLlit.MaxLength = 20
        Me.TBTempMaxLlit.Name = "TBTempMaxLlit"
        Me.TBTempMaxLlit.Size = New System.Drawing.Size(141, 20)
        Me.TBTempMaxLlit.TabIndex = 6
        '
        'TBTempMinExt
        '
        Me.TBTempMinExt.Location = New System.Drawing.Point(277, 161)
        Me.TBTempMinExt.MaxLength = 20
        Me.TBTempMinExt.Name = "TBTempMinExt"
        Me.TBTempMinExt.Size = New System.Drawing.Size(141, 20)
        Me.TBTempMinExt.TabIndex = 5
        '
        'TBTempMaxEx
        '
        Me.TBTempMaxEx.Location = New System.Drawing.Point(277, 126)
        Me.TBTempMaxEx.MaxLength = 20
        Me.TBTempMaxEx.Name = "TBTempMaxEx"
        Me.TBTempMaxEx.Size = New System.Drawing.Size(141, 20)
        Me.TBTempMaxEx.TabIndex = 4
        '
        'TBExtrusors
        '
        Me.TBExtrusors.Location = New System.Drawing.Point(277, 93)
        Me.TBExtrusors.MaxLength = 20
        Me.TBExtrusors.Name = "TBExtrusors"
        Me.TBExtrusors.Size = New System.Drawing.Size(141, 20)
        Me.TBExtrusors.TabIndex = 3
        '
        'TBModel
        '
        Me.TBModel.Location = New System.Drawing.Point(277, 58)
        Me.TBModel.MaxLength = 20
        Me.TBModel.Name = "TBModel"
        Me.TBModel.Size = New System.Drawing.Size(141, 20)
        Me.TBModel.TabIndex = 2
        '
        'LDiametre
        '
        Me.LDiametre.AutoSize = True
        Me.LDiametre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDiametre.ForeColor = System.Drawing.Color.Black
        Me.LDiametre.Location = New System.Drawing.Point(438, 124)
        Me.LDiametre.Name = "LDiametre"
        Me.LDiametre.Size = New System.Drawing.Size(156, 20)
        Me.LDiametre.TabIndex = 61
        Me.LDiametre.Text = "Diàmetre de filament"
        '
        'LResMaxCapa
        '
        Me.LResMaxCapa.AutoSize = True
        Me.LResMaxCapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LResMaxCapa.ForeColor = System.Drawing.Color.Black
        Me.LResMaxCapa.Location = New System.Drawing.Point(438, 91)
        Me.LResMaxCapa.Name = "LResMaxCapa"
        Me.LResMaxCapa.Size = New System.Drawing.Size(198, 20)
        Me.LResMaxCapa.TabIndex = 60
        Me.LResMaxCapa.Text = "Resolució máxima de capa"
        '
        'LResMinCapa
        '
        Me.LResMinCapa.AutoSize = True
        Me.LResMinCapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LResMinCapa.ForeColor = System.Drawing.Color.Black
        Me.LResMinCapa.Location = New System.Drawing.Point(438, 58)
        Me.LResMinCapa.Name = "LResMinCapa"
        Me.LResMinCapa.Size = New System.Drawing.Size(194, 20)
        Me.LResMinCapa.TabIndex = 59
        Me.LResMinCapa.Text = "Resolució mínima de capa"
        '
        'LVelMaxExt
        '
        Me.LVelMaxExt.AutoSize = True
        Me.LVelMaxExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVelMaxExt.ForeColor = System.Drawing.Color.Black
        Me.LVelMaxExt.Location = New System.Drawing.Point(438, 26)
        Me.LVelMaxExt.Name = "LVelMaxExt"
        Me.LVelMaxExt.Size = New System.Drawing.Size(218, 20)
        Me.LVelMaxExt.TabIndex = 58
        Me.LVelMaxExt.Text = "Velocitat máxima de l'extrusor"
        '
        'LAreaY
        '
        Me.LAreaY.AutoSize = True
        Me.LAreaY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAreaY.ForeColor = System.Drawing.Color.Black
        Me.LAreaY.Location = New System.Drawing.Point(22, 294)
        Me.LAreaY.Name = "LAreaY"
        Me.LAreaY.Size = New System.Drawing.Size(141, 20)
        Me.LAreaY.TabIndex = 56
        Me.LAreaY.Text = "Area d'impressió Y"
        '
        'LAreaX
        '
        Me.LAreaX.AutoSize = True
        Me.LAreaX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAreaX.ForeColor = System.Drawing.Color.Black
        Me.LAreaX.Location = New System.Drawing.Point(22, 263)
        Me.LAreaX.Name = "LAreaX"
        Me.LAreaX.Size = New System.Drawing.Size(141, 20)
        Me.LAreaX.TabIndex = 55
        Me.LAreaX.Text = "Area d'impressió X"
        '
        'LTempMinLlit
        '
        Me.LTempMinLlit.AutoSize = True
        Me.LTempMinLlit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTempMinLlit.ForeColor = System.Drawing.Color.Black
        Me.LTempMinLlit.Location = New System.Drawing.Point(22, 229)
        Me.LTempMinLlit.Name = "LTempMinLlit"
        Me.LTempMinLlit.Size = New System.Drawing.Size(197, 20)
        Me.LTempMinLlit.TabIndex = 54
        Me.LTempMinLlit.Text = "Temperatura mínima del llit"
        '
        'LTempMaxLlit
        '
        Me.LTempMaxLlit.AutoSize = True
        Me.LTempMaxLlit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTempMaxLlit.ForeColor = System.Drawing.Color.Black
        Me.LTempMaxLlit.Location = New System.Drawing.Point(22, 194)
        Me.LTempMaxLlit.Name = "LTempMaxLlit"
        Me.LTempMaxLlit.Size = New System.Drawing.Size(201, 20)
        Me.LTempMaxLlit.TabIndex = 53
        Me.LTempMaxLlit.Text = "Temperatura máxima del llit"
        '
        'LTempMinExt
        '
        Me.LTempMinExt.AutoSize = True
        Me.LTempMinExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTempMinExt.ForeColor = System.Drawing.Color.Black
        Me.LTempMinExt.Location = New System.Drawing.Point(22, 159)
        Me.LTempMinExt.Name = "LTempMinExt"
        Me.LTempMinExt.Size = New System.Drawing.Size(240, 20)
        Me.LTempMinExt.TabIndex = 52
        Me.LTempMinExt.Text = "Temperatura mínima del extrusor"
        '
        'LTempMaxExt
        '
        Me.LTempMaxExt.AutoSize = True
        Me.LTempMaxExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTempMaxExt.ForeColor = System.Drawing.Color.Black
        Me.LTempMaxExt.Location = New System.Drawing.Point(22, 124)
        Me.LTempMaxExt.Name = "LTempMaxExt"
        Me.LTempMaxExt.Size = New System.Drawing.Size(244, 20)
        Me.LTempMaxExt.TabIndex = 51
        Me.LTempMaxExt.Text = "Temperatura máxima del extrusor"
        '
        'LNExtru
        '
        Me.LNExtru.AutoSize = True
        Me.LNExtru.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNExtru.ForeColor = System.Drawing.Color.Black
        Me.LNExtru.Location = New System.Drawing.Point(22, 91)
        Me.LNExtru.Name = "LNExtru"
        Me.LNExtru.Size = New System.Drawing.Size(97, 20)
        Me.LNExtru.TabIndex = 50
        Me.LNExtru.Text = "Nº Extrusors"
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(22, 26)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(53, 20)
        Me.LMarca.TabIndex = 49
        Me.LMarca.Text = "Marca"
        '
        'LModel
        '
        Me.LModel.AutoSize = True
        Me.LModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModel.ForeColor = System.Drawing.Color.Black
        Me.LModel.Location = New System.Drawing.Point(22, 58)
        Me.LModel.Name = "LModel"
        Me.LModel.Size = New System.Drawing.Size(114, 20)
        Me.LModel.TabIndex = 48
        Me.LModel.Text = "Nom del model"
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(-2, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(803, 19)
        Me.MenuSup.TabIndex = 80
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LabelInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelInfo.Location = New System.Drawing.Point(441, 182)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(0, 18)
        Me.LabelInfo.TabIndex = 81
        '
        'DGMaterial
        '
        Me.DGMaterial.AllowUserToAddRows = False
        Me.DGMaterial.AllowUserToDeleteRows = False
        Me.DGMaterial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.material, Me.descripcio})
        Me.DGMaterial.Location = New System.Drawing.Point(638, 150)
        Me.DGMaterial.MultiSelect = False
        Me.DGMaterial.Name = "DGMaterial"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGMaterial.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMaterial.Size = New System.Drawing.Size(144, 193)
        Me.DGMaterial.TabIndex = 15
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
        'CBMarca
        '
        Me.CBMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Location = New System.Drawing.Point(277, 26)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(141, 21)
        Me.CBMarca.TabIndex = 1
        '
        'LAreaZ
        '
        Me.LAreaZ.AutoSize = True
        Me.LAreaZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAreaZ.ForeColor = System.Drawing.Color.Black
        Me.LAreaZ.Location = New System.Drawing.Point(22, 323)
        Me.LAreaZ.Name = "LAreaZ"
        Me.LAreaZ.Size = New System.Drawing.Size(140, 20)
        Me.LAreaZ.TabIndex = 57
        Me.LAreaZ.Text = "Area d'impressió Z"
        '
        'ModificarModel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 381)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.DGMaterial)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTModificar)
        Me.Controls.Add(Me.LMaterialSup)
        Me.Controls.Add(Me.TBDiametre)
        Me.Controls.Add(Me.TBResMaxCap)
        Me.Controls.Add(Me.TBResMinCap)
        Me.Controls.Add(Me.TBVelMinExt)
        Me.Controls.Add(Me.TBImpZ)
        Me.Controls.Add(Me.TBAImpY)
        Me.Controls.Add(Me.TBAImpX)
        Me.Controls.Add(Me.TBTempMinLlit)
        Me.Controls.Add(Me.TBTempMaxLlit)
        Me.Controls.Add(Me.TBTempMinExt)
        Me.Controls.Add(Me.TBTempMaxEx)
        Me.Controls.Add(Me.TBExtrusors)
        Me.Controls.Add(Me.TBModel)
        Me.Controls.Add(Me.LDiametre)
        Me.Controls.Add(Me.LResMaxCapa)
        Me.Controls.Add(Me.LResMinCapa)
        Me.Controls.Add(Me.LVelMaxExt)
        Me.Controls.Add(Me.LAreaZ)
        Me.Controls.Add(Me.LAreaY)
        Me.Controls.Add(Me.LAreaX)
        Me.Controls.Add(Me.LTempMinLlit)
        Me.Controls.Add(Me.LTempMaxLlit)
        Me.Controls.Add(Me.LTempMinExt)
        Me.Controls.Add(Me.LTempMaxExt)
        Me.Controls.Add(Me.LNExtru)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.LModel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarModel"
        Me.Text = "ModificarModel"
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTModificar As Button
    Friend WithEvents LMaterialSup As Label
    Friend WithEvents TBDiametre As TextBox
    Friend WithEvents TBResMaxCap As TextBox
    Friend WithEvents TBResMinCap As TextBox
    Friend WithEvents TBVelMinExt As TextBox
    Friend WithEvents TBImpZ As TextBox
    Friend WithEvents TBAImpY As TextBox
    Friend WithEvents TBAImpX As TextBox
    Friend WithEvents TBTempMinLlit As TextBox
    Friend WithEvents TBTempMaxLlit As TextBox
    Friend WithEvents TBTempMinExt As TextBox
    Friend WithEvents TBTempMaxEx As TextBox
    Friend WithEvents TBExtrusors As TextBox
    Friend WithEvents TBModel As TextBox
    Friend WithEvents LDiametre As Label
    Friend WithEvents LResMaxCapa As Label
    Friend WithEvents LResMinCapa As Label
    Friend WithEvents LVelMaxExt As Label
    Friend WithEvents LAreaY As Label
    Friend WithEvents LAreaX As Label
    Friend WithEvents LTempMinLlit As Label
    Friend WithEvents LTempMaxLlit As Label
    Friend WithEvents LTempMinExt As Label
    Friend WithEvents LTempMaxExt As Label
    Friend WithEvents LNExtru As Label
    Friend WithEvents LModel As Label
    Friend WithEvents MenuSup As Panel
    Public WithEvents LMarca As Label
    Friend WithEvents LabelInfo As Label
    Friend WithEvents DGMaterial As DataGridView
    Friend WithEvents material As DataGridViewTextBoxColumn
    Friend WithEvents descripcio As DataGridViewTextBoxColumn
    Friend WithEvents CBMarca As ComboBox
    Friend WithEvents LAreaZ As Label
End Class
