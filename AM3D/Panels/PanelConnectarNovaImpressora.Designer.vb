<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelConnectarNovaImpressora
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
        Me.LMarca = New System.Windows.Forms.Label()
        Me.LModel = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LBobina = New System.Windows.Forms.Label()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.TBNomImpressora = New System.Windows.Forms.TextBox()
        Me.BTImpressoraGuardar = New System.Windows.Forms.Button()
        Me.BTImpressoraBorrar = New System.Windows.Forms.Button()
        Me.DataGridViewBobina = New System.Windows.Forms.DataGridView()
        Me.codi_bobina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bobina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca_productora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diametre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Labelnfo = New System.Windows.Forms.Label()
        CType(Me.DataGridViewBobina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(53, 40)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(67, 25)
        Me.LMarca.TabIndex = 0
        Me.LMarca.Text = "Marca"
        '
        'LModel
        '
        Me.LModel.AutoSize = True
        Me.LModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModel.ForeColor = System.Drawing.Color.Black
        Me.LModel.Location = New System.Drawing.Point(53, 114)
        Me.LModel.Name = "LModel"
        Me.LModel.Size = New System.Drawing.Size(66, 25)
        Me.LModel.TabIndex = 1
        Me.LModel.Text = "Model"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.ForeColor = System.Drawing.Color.Black
        Me.LNom.Location = New System.Drawing.Point(53, 182)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(53, 25)
        Me.LNom.TabIndex = 2
        Me.LNom.Text = "Nom"
        '
        'LBobina
        '
        Me.LBobina.AutoSize = True
        Me.LBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBobina.ForeColor = System.Drawing.Color.Black
        Me.LBobina.Location = New System.Drawing.Point(404, 40)
        Me.LBobina.Name = "LBobina"
        Me.LBobina.Size = New System.Drawing.Size(73, 25)
        Me.LBobina.TabIndex = 4
        Me.LBobina.Text = "Bobina"
        '
        'CBMarca
        '
        Me.CBMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Location = New System.Drawing.Point(163, 46)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(169, 21)
        Me.CBMarca.TabIndex = 1
        '
        'CBModel
        '
        Me.CBModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBModel.Enabled = False
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(163, 120)
        Me.CBModel.MaxDropDownItems = 10
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(169, 21)
        Me.CBModel.TabIndex = 2
        '
        'TBNomImpressora
        '
        Me.TBNomImpressora.Location = New System.Drawing.Point(163, 187)
        Me.TBNomImpressora.Name = "TBNomImpressora"
        Me.TBNomImpressora.Size = New System.Drawing.Size(169, 20)
        Me.TBNomImpressora.TabIndex = 3
        '
        'BTImpressoraGuardar
        '
        Me.BTImpressoraGuardar.BackColor = System.Drawing.Color.White
        Me.BTImpressoraGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImpressoraGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImpressoraGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImpressoraGuardar.ForeColor = System.Drawing.Color.Black
        Me.BTImpressoraGuardar.Location = New System.Drawing.Point(58, 264)
        Me.BTImpressoraGuardar.Name = "BTImpressoraGuardar"
        Me.BTImpressoraGuardar.Size = New System.Drawing.Size(154, 62)
        Me.BTImpressoraGuardar.TabIndex = 8
        Me.BTImpressoraGuardar.Text = "Guardar"
        Me.BTImpressoraGuardar.UseVisualStyleBackColor = False
        '
        'BTImpressoraBorrar
        '
        Me.BTImpressoraBorrar.BackColor = System.Drawing.Color.White
        Me.BTImpressoraBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImpressoraBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImpressoraBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImpressoraBorrar.ForeColor = System.Drawing.Color.Black
        Me.BTImpressoraBorrar.Location = New System.Drawing.Point(297, 264)
        Me.BTImpressoraBorrar.Name = "BTImpressoraBorrar"
        Me.BTImpressoraBorrar.Size = New System.Drawing.Size(154, 62)
        Me.BTImpressoraBorrar.TabIndex = 9
        Me.BTImpressoraBorrar.Text = "Borrar"
        Me.BTImpressoraBorrar.UseVisualStyleBackColor = False
        '
        'DataGridViewBobina
        '
        Me.DataGridViewBobina.AllowUserToAddRows = False
        Me.DataGridViewBobina.AllowUserToDeleteRows = False
        Me.DataGridViewBobina.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewBobina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBobina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codi_bobina, Me.Bobina, Me.color, Me.marca_productora, Me.Diametre})
        Me.DataGridViewBobina.Location = New System.Drawing.Point(496, 12)
        Me.DataGridViewBobina.MultiSelect = False
        Me.DataGridViewBobina.Name = "DataGridViewBobina"
        Me.DataGridViewBobina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBobina.Size = New System.Drawing.Size(294, 350)
        Me.DataGridViewBobina.TabIndex = 10
        '
        'codi_bobina
        '
        Me.codi_bobina.HeaderText = "Codi Bobina"
        Me.codi_bobina.Name = "codi_bobina"
        Me.codi_bobina.ReadOnly = True
        Me.codi_bobina.Visible = False
        '
        'Bobina
        '
        Me.Bobina.HeaderText = "Bobina"
        Me.Bobina.Name = "Bobina"
        Me.Bobina.ReadOnly = True
        '
        'color
        '
        Me.color.HeaderText = "Color"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        '
        'marca_productora
        '
        Me.marca_productora.HeaderText = "Marca"
        Me.marca_productora.Name = "marca_productora"
        Me.marca_productora.ReadOnly = True
        '
        'Diametre
        '
        Me.Diametre.HeaderText = "Diametre"
        Me.Diametre.Name = "Diametre"
        Me.Diametre.ReadOnly = True
        '
        'Labelnfo
        '
        Me.Labelnfo.AutoSize = True
        Me.Labelnfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Labelnfo.ForeColor = System.Drawing.Color.DarkRed
        Me.Labelnfo.Location = New System.Drawing.Point(55, 233)
        Me.Labelnfo.Name = "Labelnfo"
        Me.Labelnfo.Size = New System.Drawing.Size(32, 18)
        Me.Labelnfo.TabIndex = 16
        Me.Labelnfo.Text = "aaa"
        Me.Labelnfo.Visible = False
        '
        'PanelConnectarNovaImpressora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(802, 374)
        Me.Controls.Add(Me.Labelnfo)
        Me.Controls.Add(Me.DataGridViewBobina)
        Me.Controls.Add(Me.BTImpressoraBorrar)
        Me.Controls.Add(Me.BTImpressoraGuardar)
        Me.Controls.Add(Me.TBNomImpressora)
        Me.Controls.Add(Me.CBModel)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.LBobina)
        Me.Controls.Add(Me.LNom)
        Me.Controls.Add(Me.LModel)
        Me.Controls.Add(Me.LMarca)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelConnectarNovaImpressora"
        Me.Text = "PanelConnectarNovaImpressora"
        CType(Me.DataGridViewBobina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LMarca As Label
    Friend WithEvents LModel As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LBobina As Label
    Friend WithEvents CBMarca As ComboBox
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents TBNomImpressora As TextBox
    Friend WithEvents BTImpressoraGuardar As Button
    Friend WithEvents BTImpressoraBorrar As Button
    Friend WithEvents DataGridViewBobina As DataGridView
    Friend WithEvents Labelnfo As Label
    Friend WithEvents codi_bobina As DataGridViewTextBoxColumn
    Friend WithEvents Bobina As DataGridViewTextBoxColumn
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents marca_productora As DataGridViewTextBoxColumn
    Friend WithEvents Diametre As DataGridViewTextBoxColumn
End Class
