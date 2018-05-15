<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelModelAfegir
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LModel = New System.Windows.Forms.Label()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.LNExtrusors = New System.Windows.Forms.Label()
        Me.LTempMaxExt = New System.Windows.Forms.Label()
        Me.LTempMinExt = New System.Windows.Forms.Label()
        Me.LTempMinLlit = New System.Windows.Forms.Label()
        Me.LTempMaxLlit = New System.Windows.Forms.Label()
        Me.LAreaX = New System.Windows.Forms.Label()
        Me.LAreaY = New System.Windows.Forms.Label()
        Me.LAreaZ = New System.Windows.Forms.Label()
        Me.LVelMaxExt = New System.Windows.Forms.Label()
        Me.LResMinCapa = New System.Windows.Forms.Label()
        Me.LResMaxCapa = New System.Windows.Forms.Label()
        Me.LDiametreFil = New System.Windows.Forms.Label()
        Me.TBModel = New System.Windows.Forms.TextBox()
        Me.TBExtrusors = New System.Windows.Forms.TextBox()
        Me.TBTempMaxEx = New System.Windows.Forms.TextBox()
        Me.TBTempMinExt = New System.Windows.Forms.TextBox()
        Me.TBTempMaxLlit = New System.Windows.Forms.TextBox()
        Me.TBTempMinLlit = New System.Windows.Forms.TextBox()
        Me.TBAImpX = New System.Windows.Forms.TextBox()
        Me.TBAImpY = New System.Windows.Forms.TextBox()
        Me.TBImpZ = New System.Windows.Forms.TextBox()
        Me.TBVelMaxExt = New System.Windows.Forms.TextBox()
        Me.TBResMinCap = New System.Windows.Forms.TextBox()
        Me.TBResMaxCap = New System.Windows.Forms.TextBox()
        Me.TBDiametre = New System.Windows.Forms.TextBox()
        Me.LMaterialSup = New System.Windows.Forms.Label()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.BTBorrar = New System.Windows.Forms.Button()
        Me.DGMaterial = New System.Windows.Forms.DataGridView()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LModel
        '
        Me.LModel.AutoSize = True
        Me.LModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModel.ForeColor = System.Drawing.Color.Black
        Me.LModel.Location = New System.Drawing.Point(21, 59)
        Me.LModel.Name = "LModel"
        Me.LModel.Size = New System.Drawing.Size(114, 20)
        Me.LModel.TabIndex = 16
        Me.LModel.Text = "Nom del model"
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(21, 26)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(53, 20)
        Me.LMarca.TabIndex = 17
        Me.LMarca.Text = "Marca"
        '
        'LNExtrusors
        '
        Me.LNExtrusors.AutoSize = True
        Me.LNExtrusors.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNExtrusors.ForeColor = System.Drawing.Color.Black
        Me.LNExtrusors.Location = New System.Drawing.Point(21, 92)
        Me.LNExtrusors.Name = "LNExtrusors"
        Me.LNExtrusors.Size = New System.Drawing.Size(97, 20)
        Me.LNExtrusors.TabIndex = 18
        Me.LNExtrusors.Text = "Nº Extrusors"
        '
        'LTempMaxExt
        '
        Me.LTempMaxExt.AutoSize = True
        Me.LTempMaxExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTempMaxExt.ForeColor = System.Drawing.Color.Black
        Me.LTempMaxExt.Location = New System.Drawing.Point(21, 127)
        Me.LTempMaxExt.Name = "LTempMaxExt"
        Me.LTempMaxExt.Size = New System.Drawing.Size(244, 20)
        Me.LTempMaxExt.TabIndex = 19
        Me.LTempMaxExt.Text = "Temperatura máxima del extrusor"
        '
        'LTempMinExt
        '
        Me.LTempMinExt.AutoSize = True
        Me.LTempMinExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTempMinExt.ForeColor = System.Drawing.Color.Black
        Me.LTempMinExt.Location = New System.Drawing.Point(21, 162)
        Me.LTempMinExt.Name = "LTempMinExt"
        Me.LTempMinExt.Size = New System.Drawing.Size(240, 20)
        Me.LTempMinExt.TabIndex = 20
        Me.LTempMinExt.Text = "Temperatura mínima del extrusor"
        '
        'LTempMinLlit
        '
        Me.LTempMinLlit.AutoSize = True
        Me.LTempMinLlit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTempMinLlit.ForeColor = System.Drawing.Color.Black
        Me.LTempMinLlit.Location = New System.Drawing.Point(21, 232)
        Me.LTempMinLlit.Name = "LTempMinLlit"
        Me.LTempMinLlit.Size = New System.Drawing.Size(197, 20)
        Me.LTempMinLlit.TabIndex = 22
        Me.LTempMinLlit.Text = "Temperatura mínima del llit"
        '
        'LTempMaxLlit
        '
        Me.LTempMaxLlit.AutoSize = True
        Me.LTempMaxLlit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTempMaxLlit.ForeColor = System.Drawing.Color.Black
        Me.LTempMaxLlit.Location = New System.Drawing.Point(21, 197)
        Me.LTempMaxLlit.Name = "LTempMaxLlit"
        Me.LTempMaxLlit.Size = New System.Drawing.Size(201, 20)
        Me.LTempMaxLlit.TabIndex = 21
        Me.LTempMaxLlit.Text = "Temperatura máxima del llit"
        '
        'LAreaX
        '
        Me.LAreaX.AutoSize = True
        Me.LAreaX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAreaX.ForeColor = System.Drawing.Color.Black
        Me.LAreaX.Location = New System.Drawing.Point(21, 266)
        Me.LAreaX.Name = "LAreaX"
        Me.LAreaX.Size = New System.Drawing.Size(141, 20)
        Me.LAreaX.TabIndex = 23
        Me.LAreaX.Text = "Area d'impressió X"
        '
        'LAreaY
        '
        Me.LAreaY.AutoSize = True
        Me.LAreaY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAreaY.ForeColor = System.Drawing.Color.Black
        Me.LAreaY.Location = New System.Drawing.Point(21, 297)
        Me.LAreaY.Name = "LAreaY"
        Me.LAreaY.Size = New System.Drawing.Size(141, 20)
        Me.LAreaY.TabIndex = 24
        Me.LAreaY.Text = "Area d'impressió Y"
        '
        'LAreaZ
        '
        Me.LAreaZ.AutoSize = True
        Me.LAreaZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAreaZ.ForeColor = System.Drawing.Color.Black
        Me.LAreaZ.Location = New System.Drawing.Point(21, 326)
        Me.LAreaZ.Name = "LAreaZ"
        Me.LAreaZ.Size = New System.Drawing.Size(140, 20)
        Me.LAreaZ.TabIndex = 25
        Me.LAreaZ.Text = "Area d'impressió Z"
        '
        'LVelMaxExt
        '
        Me.LVelMaxExt.AutoSize = True
        Me.LVelMaxExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVelMaxExt.ForeColor = System.Drawing.Color.Black
        Me.LVelMaxExt.Location = New System.Drawing.Point(419, 26)
        Me.LVelMaxExt.Name = "LVelMaxExt"
        Me.LVelMaxExt.Size = New System.Drawing.Size(218, 20)
        Me.LVelMaxExt.TabIndex = 26
        Me.LVelMaxExt.Text = "Velocitat máxima de l'extrusor"
        '
        'LResMinCapa
        '
        Me.LResMinCapa.AutoSize = True
        Me.LResMinCapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LResMinCapa.ForeColor = System.Drawing.Color.Black
        Me.LResMinCapa.Location = New System.Drawing.Point(419, 59)
        Me.LResMinCapa.Name = "LResMinCapa"
        Me.LResMinCapa.Size = New System.Drawing.Size(194, 20)
        Me.LResMinCapa.TabIndex = 27
        Me.LResMinCapa.Text = "Resolució mínima de capa"
        '
        'LResMaxCapa
        '
        Me.LResMaxCapa.AutoSize = True
        Me.LResMaxCapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LResMaxCapa.ForeColor = System.Drawing.Color.Black
        Me.LResMaxCapa.Location = New System.Drawing.Point(419, 92)
        Me.LResMaxCapa.Name = "LResMaxCapa"
        Me.LResMaxCapa.Size = New System.Drawing.Size(198, 20)
        Me.LResMaxCapa.TabIndex = 28
        Me.LResMaxCapa.Text = "Resolució máxima de capa"
        '
        'LDiametreFil
        '
        Me.LDiametreFil.AutoSize = True
        Me.LDiametreFil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDiametreFil.ForeColor = System.Drawing.Color.Black
        Me.LDiametreFil.Location = New System.Drawing.Point(419, 127)
        Me.LDiametreFil.Name = "LDiametreFil"
        Me.LDiametreFil.Size = New System.Drawing.Size(156, 20)
        Me.LDiametreFil.TabIndex = 29
        Me.LDiametreFil.Text = "Diàmetre de filament"
        '
        'TBModel
        '
        Me.TBModel.Location = New System.Drawing.Point(276, 59)
        Me.TBModel.Name = "TBModel"
        Me.TBModel.Size = New System.Drawing.Size(141, 20)
        Me.TBModel.TabIndex = 30
        '
        'TBExtrusors
        '
        Me.TBExtrusors.Location = New System.Drawing.Point(276, 94)
        Me.TBExtrusors.Name = "TBExtrusors"
        Me.TBExtrusors.Size = New System.Drawing.Size(141, 20)
        Me.TBExtrusors.TabIndex = 31
        '
        'TBTempMaxEx
        '
        Me.TBTempMaxEx.Location = New System.Drawing.Point(276, 129)
        Me.TBTempMaxEx.Name = "TBTempMaxEx"
        Me.TBTempMaxEx.Size = New System.Drawing.Size(141, 20)
        Me.TBTempMaxEx.TabIndex = 32
        '
        'TBTempMinExt
        '
        Me.TBTempMinExt.Location = New System.Drawing.Point(276, 164)
        Me.TBTempMinExt.Name = "TBTempMinExt"
        Me.TBTempMinExt.Size = New System.Drawing.Size(141, 20)
        Me.TBTempMinExt.TabIndex = 33
        '
        'TBTempMaxLlit
        '
        Me.TBTempMaxLlit.Location = New System.Drawing.Point(276, 197)
        Me.TBTempMaxLlit.Name = "TBTempMaxLlit"
        Me.TBTempMaxLlit.Size = New System.Drawing.Size(141, 20)
        Me.TBTempMaxLlit.TabIndex = 34
        '
        'TBTempMinLlit
        '
        Me.TBTempMinLlit.Location = New System.Drawing.Point(276, 232)
        Me.TBTempMinLlit.Name = "TBTempMinLlit"
        Me.TBTempMinLlit.Size = New System.Drawing.Size(141, 20)
        Me.TBTempMinLlit.TabIndex = 35
        '
        'TBAImpX
        '
        Me.TBAImpX.Location = New System.Drawing.Point(276, 268)
        Me.TBAImpX.Name = "TBAImpX"
        Me.TBAImpX.Size = New System.Drawing.Size(141, 20)
        Me.TBAImpX.TabIndex = 36
        '
        'TBAImpY
        '
        Me.TBAImpY.Location = New System.Drawing.Point(276, 297)
        Me.TBAImpY.Name = "TBAImpY"
        Me.TBAImpY.Size = New System.Drawing.Size(141, 20)
        Me.TBAImpY.TabIndex = 37
        '
        'TBImpZ
        '
        Me.TBImpZ.Location = New System.Drawing.Point(276, 326)
        Me.TBImpZ.Name = "TBImpZ"
        Me.TBImpZ.Size = New System.Drawing.Size(141, 20)
        Me.TBImpZ.TabIndex = 38
        '
        'TBVelMaxExt
        '
        Me.TBVelMaxExt.Location = New System.Drawing.Point(637, 28)
        Me.TBVelMaxExt.Name = "TBVelMaxExt"
        Me.TBVelMaxExt.Size = New System.Drawing.Size(144, 20)
        Me.TBVelMaxExt.TabIndex = 39
        '
        'TBResMinCap
        '
        Me.TBResMinCap.Location = New System.Drawing.Point(637, 61)
        Me.TBResMinCap.Name = "TBResMinCap"
        Me.TBResMinCap.Size = New System.Drawing.Size(144, 20)
        Me.TBResMinCap.TabIndex = 40
        '
        'TBResMaxCap
        '
        Me.TBResMaxCap.Location = New System.Drawing.Point(637, 94)
        Me.TBResMaxCap.Name = "TBResMaxCap"
        Me.TBResMaxCap.Size = New System.Drawing.Size(144, 20)
        Me.TBResMaxCap.TabIndex = 41
        '
        'TBDiametre
        '
        Me.TBDiametre.Location = New System.Drawing.Point(637, 127)
        Me.TBDiametre.Name = "TBDiametre"
        Me.TBDiametre.Size = New System.Drawing.Size(144, 20)
        Me.TBDiametre.TabIndex = 42
        '
        'LMaterialSup
        '
        Me.LMaterialSup.AutoSize = True
        Me.LMaterialSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterialSup.ForeColor = System.Drawing.Color.Black
        Me.LMaterialSup.Location = New System.Drawing.Point(500, 164)
        Me.LMaterialSup.Name = "LMaterialSup"
        Me.LMaterialSup.Size = New System.Drawing.Size(131, 20)
        Me.LMaterialSup.TabIndex = 45
        Me.LMaterialSup.Text = "Material Suportat"
        '
        'BTAfegir
        '
        Me.BTAfegir.BackColor = System.Drawing.Color.White
        Me.BTAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTAfegir.Location = New System.Drawing.Point(424, 216)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(194, 62)
        Me.BTAfegir.TabIndex = 46
        Me.BTAfegir.Text = "Afegir"
        Me.BTAfegir.UseVisualStyleBackColor = False
        '
        'BTBorrar
        '
        Me.BTBorrar.BackColor = System.Drawing.Color.White
        Me.BTBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBorrar.ForeColor = System.Drawing.Color.Black
        Me.BTBorrar.Location = New System.Drawing.Point(424, 284)
        Me.BTBorrar.Name = "BTBorrar"
        Me.BTBorrar.Size = New System.Drawing.Size(194, 62)
        Me.BTBorrar.TabIndex = 47
        Me.BTBorrar.Text = "Borrar"
        Me.BTBorrar.UseVisualStyleBackColor = False
        '
        'DGMaterial
        '
        Me.DGMaterial.AllowUserToAddRows = False
        Me.DGMaterial.AllowUserToDeleteRows = False
        Me.DGMaterial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.material, Me.descripcio})
        Me.DGMaterial.Location = New System.Drawing.Point(637, 164)
        Me.DGMaterial.MultiSelect = False
        Me.DGMaterial.Name = "DGMaterial"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DGMaterial.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMaterial.Size = New System.Drawing.Size(144, 193)
        Me.DGMaterial.TabIndex = 68
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
        Me.CBMarca.Location = New System.Drawing.Point(276, 25)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(141, 21)
        Me.CBMarca.TabIndex = 69
        '
        'PanelModelAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.DGMaterial)
        Me.Controls.Add(Me.BTBorrar)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.LMaterialSup)
        Me.Controls.Add(Me.TBDiametre)
        Me.Controls.Add(Me.TBResMaxCap)
        Me.Controls.Add(Me.TBResMinCap)
        Me.Controls.Add(Me.TBVelMaxExt)
        Me.Controls.Add(Me.TBImpZ)
        Me.Controls.Add(Me.TBAImpY)
        Me.Controls.Add(Me.TBAImpX)
        Me.Controls.Add(Me.TBTempMinLlit)
        Me.Controls.Add(Me.TBTempMaxLlit)
        Me.Controls.Add(Me.TBTempMinExt)
        Me.Controls.Add(Me.TBTempMaxEx)
        Me.Controls.Add(Me.TBExtrusors)
        Me.Controls.Add(Me.TBModel)
        Me.Controls.Add(Me.LDiametreFil)
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
        Me.Controls.Add(Me.LNExtrusors)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.LModel)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelModelAfegir"
        Me.Text = "PanelModelAfegir"
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LModel As Label
    Friend WithEvents LMarca As Label
    Friend WithEvents LNExtrusors As Label
    Friend WithEvents LTempMaxExt As Label
    Friend WithEvents LTempMinExt As Label
    Friend WithEvents LTempMinLlit As Label
    Friend WithEvents LTempMaxLlit As Label
    Friend WithEvents LAreaX As Label
    Friend WithEvents LAreaY As Label
    Friend WithEvents LAreaZ As Label
    Friend WithEvents LVelMaxExt As Label
    Friend WithEvents LResMinCapa As Label
    Friend WithEvents LResMaxCapa As Label
    Friend WithEvents LDiametreFil As Label
    Friend WithEvents TBModel As TextBox
    Friend WithEvents TBExtrusors As TextBox
    Friend WithEvents TBTempMaxEx As TextBox
    Friend WithEvents TBTempMinExt As TextBox
    Friend WithEvents TBTempMaxLlit As TextBox
    Friend WithEvents TBTempMinLlit As TextBox
    Friend WithEvents TBAImpX As TextBox
    Friend WithEvents TBAImpY As TextBox
    Friend WithEvents TBImpZ As TextBox
    Friend WithEvents TBVelMaxExt As TextBox
    Friend WithEvents TBResMinCap As TextBox
    Friend WithEvents TBResMaxCap As TextBox
    Friend WithEvents TBDiametre As TextBox
    Friend WithEvents LMaterialSup As Label
    Friend WithEvents BTAfegir As Button
    Friend WithEvents BTBorrar As Button
    Friend WithEvents DGMaterial As DataGridView
    Friend WithEvents material As DataGridViewTextBoxColumn
    Friend WithEvents descripcio As DataGridViewTextBoxColumn
    Friend WithEvents CBMarca As ComboBox
End Class
