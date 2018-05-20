<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBobinesBobinaAfegir
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
        Me.TBDiametre = New System.Windows.Forms.TextBox()
        Me.LDiametre = New System.Windows.Forms.Label()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.LColor = New System.Windows.Forms.Label()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.BTBorrar = New System.Windows.Forms.Button()
        Me.DGMaterial = New System.Windows.Forms.DataGridView()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGMarcaProductora = New System.Windows.Forms.DataGridView()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGColor = New System.Windows.Forms.DataGridView()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorBackground = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGMarcaProductora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TBDiametre
        '
        Me.TBDiametre.Location = New System.Drawing.Point(16, 57)
        Me.TBDiametre.MaxLength = 10
        Me.TBDiametre.Name = "TBDiametre"
        Me.TBDiametre.Size = New System.Drawing.Size(151, 20)
        Me.TBDiametre.TabIndex = 0
        '
        'LDiametre
        '
        Me.LDiametre.AutoSize = True
        Me.LDiametre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDiametre.ForeColor = System.Drawing.Color.Black
        Me.LDiametre.Location = New System.Drawing.Point(12, 34)
        Me.LDiametre.Name = "LDiametre"
        Me.LDiametre.Size = New System.Drawing.Size(74, 20)
        Me.LDiametre.TabIndex = 53
        Me.LDiametre.Text = "Diametre"
        '
        'LMaterial
        '
        Me.LMaterial.AutoSize = True
        Me.LMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterial.ForeColor = System.Drawing.Color.Black
        Me.LMaterial.Location = New System.Drawing.Point(169, 34)
        Me.LMaterial.Name = "LMaterial"
        Me.LMaterial.Size = New System.Drawing.Size(65, 20)
        Me.LMaterial.TabIndex = 55
        Me.LMaterial.Text = "Material"
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(318, 34)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(135, 20)
        Me.LMarca.TabIndex = 56
        Me.LMarca.Text = "Marca Productora"
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LColor.ForeColor = System.Drawing.Color.Black
        Me.LColor.Location = New System.Drawing.Point(499, 34)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(46, 20)
        Me.LColor.TabIndex = 57
        Me.LColor.Text = "Color"
        '
        'BTAfegir
        '
        Me.BTAfegir.BackColor = System.Drawing.Color.White
        Me.BTAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTAfegir.Location = New System.Drawing.Point(12, 188)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(155, 58)
        Me.BTAfegir.TabIndex = 4
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
        Me.BTBorrar.Location = New System.Drawing.Point(12, 285)
        Me.BTBorrar.Name = "BTBorrar"
        Me.BTBorrar.Size = New System.Drawing.Size(155, 58)
        Me.BTBorrar.TabIndex = 5
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
        Me.DGMaterial.Location = New System.Drawing.Point(173, 57)
        Me.DGMaterial.MultiSelect = False
        Me.DGMaterial.Name = "DGMaterial"
        Me.DGMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMaterial.Size = New System.Drawing.Size(143, 288)
        Me.DGMaterial.TabIndex = 1
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
        'DGMarcaProductora
        '
        Me.DGMarcaProductora.AllowUserToAddRows = False
        Me.DGMarcaProductora.AllowUserToDeleteRows = False
        Me.DGMarcaProductora.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMarcaProductora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMarcaProductora.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.marca})
        Me.DGMarcaProductora.Location = New System.Drawing.Point(322, 55)
        Me.DGMarcaProductora.MultiSelect = False
        Me.DGMarcaProductora.Name = "DGMarcaProductora"
        Me.DGMarcaProductora.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMarcaProductora.Size = New System.Drawing.Size(175, 288)
        Me.DGMarcaProductora.TabIndex = 2
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        Me.marca.Width = 120
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
        Me.DGColor.Location = New System.Drawing.Point(503, 57)
        Me.DGColor.MultiSelect = False
        Me.DGColor.Name = "DGColor"
        Me.DGColor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGColor.Size = New System.Drawing.Size(286, 286)
        Me.DGColor.TabIndex = 3
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
        'PanelBobinesBobinaAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.DGColor)
        Me.Controls.Add(Me.DGMarcaProductora)
        Me.Controls.Add(Me.DGMaterial)
        Me.Controls.Add(Me.BTBorrar)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.LColor)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.LMaterial)
        Me.Controls.Add(Me.TBDiametre)
        Me.Controls.Add(Me.LDiametre)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesBobinaAfegir"
        Me.Text = "PanelBobinesBobinaAfegir"
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGMarcaProductora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBDiametre As TextBox
    Friend WithEvents LDiametre As Label
    Friend WithEvents LMaterial As Label
    Friend WithEvents LMarca As Label
    Friend WithEvents LColor As Label
    Friend WithEvents BTAfegir As Button
    Friend WithEvents BTBorrar As Button
    Friend WithEvents DGMaterial As DataGridView
    Friend WithEvents material As DataGridViewTextBoxColumn
    Friend WithEvents descripcio As DataGridViewTextBoxColumn
    Friend WithEvents DGMarcaProductora As DataGridView
    Friend WithEvents DGColor As DataGridView
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents Hex As DataGridViewTextBoxColumn
    Friend WithEvents ColorBackground As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
End Class
