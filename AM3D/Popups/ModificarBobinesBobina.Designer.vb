<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarBobinesBobina
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarBobinesBobina))
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.DGColor = New System.Windows.Forms.DataGridView()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorBackground = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGMarcaProductora = New System.Windows.Forms.DataGridView()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGMaterial = New System.Windows.Forms.DataGridView()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.LColor = New System.Windows.Forms.Label()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.TBDiametre = New System.Windows.Forms.TextBox()
        Me.LDiametre = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.LabelInfo = New System.Windows.Forms.Label()
        CType(Me.DGColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMarcaProductora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(-2, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(800, 19)
        Me.MenuSup.TabIndex = 78
        '
        'DGColor
        '
        Me.DGColor.AllowUserToAddRows = False
        Me.DGColor.AllowUserToDeleteRows = False
        Me.DGColor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGColor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.color, Me.Hex, Me.ColorBackground})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGColor.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGColor.Location = New System.Drawing.Point(500, 68)
        Me.DGColor.MultiSelect = False
        Me.DGColor.Name = "DGColor"
        Me.DGColor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGColor.Size = New System.Drawing.Size(286, 258)
        Me.DGColor.TabIndex = 88
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
        'DGMarcaProductora
        '
        Me.DGMarcaProductora.AllowUserToAddRows = False
        Me.DGMarcaProductora.AllowUserToDeleteRows = False
        Me.DGMarcaProductora.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMarcaProductora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMarcaProductora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.marca})
        Me.DGMarcaProductora.Location = New System.Drawing.Point(319, 66)
        Me.DGMarcaProductora.MultiSelect = False
        Me.DGMarcaProductora.Name = "DGMarcaProductora"
        Me.DGMarcaProductora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMarcaProductora.Size = New System.Drawing.Size(175, 260)
        Me.DGMarcaProductora.TabIndex = 87
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 120
        '
        'DGMaterial
        '
        Me.DGMaterial.AllowUserToAddRows = False
        Me.DGMaterial.AllowUserToDeleteRows = False
        Me.DGMaterial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.material, Me.descripcio})
        Me.DGMaterial.Location = New System.Drawing.Point(170, 68)
        Me.DGMaterial.MultiSelect = False
        Me.DGMaterial.Name = "DGMaterial"
        Me.DGMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMaterial.Size = New System.Drawing.Size(143, 260)
        Me.DGMaterial.TabIndex = 86
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
        'BTAfegir
        '
        Me.BTAfegir.BackColor = System.Drawing.Color.White
        Me.BTAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTAfegir.Location = New System.Drawing.Point(9, 202)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(155, 58)
        Me.BTAfegir.TabIndex = 84
        Me.BTAfegir.Text = "Modificar"
        Me.BTAfegir.UseVisualStyleBackColor = False
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LColor.ForeColor = System.Drawing.Color.Black
        Me.LColor.Location = New System.Drawing.Point(496, 45)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(46, 20)
        Me.LColor.TabIndex = 83
        Me.LColor.Text = "Color"
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(315, 45)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(135, 20)
        Me.LMarca.TabIndex = 82
        Me.LMarca.Text = "Marca Productora"
        '
        'LMaterial
        '
        Me.LMaterial.AutoSize = True
        Me.LMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterial.ForeColor = System.Drawing.Color.Black
        Me.LMaterial.Location = New System.Drawing.Point(166, 45)
        Me.LMaterial.Name = "LMaterial"
        Me.LMaterial.Size = New System.Drawing.Size(65, 20)
        Me.LMaterial.TabIndex = 81
        Me.LMaterial.Text = "Material"
        '
        'TBDiametre
        '
        Me.TBDiametre.Location = New System.Drawing.Point(13, 68)
        Me.TBDiametre.Name = "TBDiametre"
        Me.TBDiametre.Size = New System.Drawing.Size(151, 20)
        Me.TBDiametre.TabIndex = 80
        '
        'LDiametre
        '
        Me.LDiametre.AutoSize = True
        Me.LDiametre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDiametre.ForeColor = System.Drawing.Color.Black
        Me.LDiametre.Location = New System.Drawing.Point(9, 45)
        Me.LDiametre.Name = "LDiametre"
        Me.LDiametre.Size = New System.Drawing.Size(74, 20)
        Me.LDiametre.TabIndex = 79
        Me.LDiametre.Text = "Diametre"
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(9, 266)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(155, 62)
        Me.BTCancelar.TabIndex = 89
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LabelInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelInfo.Location = New System.Drawing.Point(12, 340)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(0, 18)
        Me.LabelInfo.TabIndex = 90
        Me.LabelInfo.Visible = False
        '
        'ModificarBobinesBobina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(798, 388)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.DGColor)
        Me.Controls.Add(Me.DGMarcaProductora)
        Me.Controls.Add(Me.DGMaterial)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.LColor)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.LMaterial)
        Me.Controls.Add(Me.TBDiametre)
        Me.Controls.Add(Me.LDiametre)
        Me.Controls.Add(Me.MenuSup)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarBobinesBobina"
        Me.Text = "ModificarBobinesBobina"
        CType(Me.DGColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMarcaProductora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuSup As Panel
    Friend WithEvents DGColor As DataGridView
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents Hex As DataGridViewTextBoxColumn
    Friend WithEvents ColorBackground As DataGridViewTextBoxColumn
    Friend WithEvents DGMarcaProductora As DataGridView
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents DGMaterial As DataGridView
    Friend WithEvents material As DataGridViewTextBoxColumn
    Friend WithEvents descripcio As DataGridViewTextBoxColumn
    Friend WithEvents BTAfegir As Button
    Friend WithEvents LColor As Label
    Friend WithEvents LMarca As Label
    Friend WithEvents LMaterial As Label
    Friend WithEvents TBDiametre As TextBox
    Friend WithEvents LDiametre As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents LabelInfo As Label
End Class
