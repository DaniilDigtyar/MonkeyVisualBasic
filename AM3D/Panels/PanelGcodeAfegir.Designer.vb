<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelGcodeAfegir
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTBorrar = New System.Windows.Forms.Button()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.TBNomGcode = New System.Windows.Forms.TextBox()
        Me.LNomGcode = New System.Windows.Forms.Label()
        Me.TBRuta = New System.Windows.Forms.TextBox()
        Me.LRuta = New System.Windows.Forms.Label()
        Me.LMaterialsSup = New System.Windows.Forms.Label()
        Me.DGMaterial = New System.Windows.Forms.DataGridView()
        Me.material = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTBorrar
        '
        Me.BTBorrar.BackColor = System.Drawing.Color.White
        Me.BTBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBorrar.ForeColor = System.Drawing.Color.Black
        Me.BTBorrar.Location = New System.Drawing.Point(31, 285)
        Me.BTBorrar.Name = "BTBorrar"
        Me.BTBorrar.Size = New System.Drawing.Size(298, 62)
        Me.BTBorrar.TabIndex = 53
        Me.BTBorrar.Text = "Borrar"
        Me.BTBorrar.UseVisualStyleBackColor = False
        '
        'BTAfegir
        '
        Me.BTAfegir.BackColor = System.Drawing.Color.White
        Me.BTAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTAfegir.Location = New System.Drawing.Point(31, 210)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(298, 62)
        Me.BTAfegir.TabIndex = 52
        Me.BTAfegir.Text = "Afegir"
        Me.BTAfegir.UseVisualStyleBackColor = False
        '
        'TBNomGcode
        '
        Me.TBNomGcode.Location = New System.Drawing.Point(165, 83)
        Me.TBNomGcode.Name = "TBNomGcode"
        Me.TBNomGcode.Size = New System.Drawing.Size(164, 20)
        Me.TBNomGcode.TabIndex = 51
        '
        'LNomGcode
        '
        Me.LNomGcode.AutoSize = True
        Me.LNomGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNomGcode.ForeColor = System.Drawing.Color.Black
        Me.LNomGcode.Location = New System.Drawing.Point(27, 83)
        Me.LNomGcode.Name = "LNomGcode"
        Me.LNomGcode.Size = New System.Drawing.Size(105, 20)
        Me.LNomGcode.TabIndex = 50
        Me.LNomGcode.Text = "Nom GCODE"
        '
        'TBRuta
        '
        Me.TBRuta.Location = New System.Drawing.Point(165, 44)
        Me.TBRuta.Name = "TBRuta"
        Me.TBRuta.Size = New System.Drawing.Size(164, 20)
        Me.TBRuta.TabIndex = 55
        '
        'LRuta
        '
        Me.LRuta.AutoSize = True
        Me.LRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRuta.ForeColor = System.Drawing.Color.Black
        Me.LRuta.Location = New System.Drawing.Point(27, 44)
        Me.LRuta.Name = "LRuta"
        Me.LRuta.Size = New System.Drawing.Size(107, 20)
        Me.LRuta.TabIndex = 54
        Me.LRuta.Text = "Ruta del fitxer"
        '
        'LMaterialsSup
        '
        Me.LMaterialsSup.AutoSize = True
        Me.LMaterialsSup.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterialsSup.ForeColor = System.Drawing.Color.Black
        Me.LMaterialsSup.Location = New System.Drawing.Point(364, 21)
        Me.LMaterialsSup.Name = "LMaterialsSup"
        Me.LMaterialsSup.Size = New System.Drawing.Size(128, 20)
        Me.LMaterialsSup.TabIndex = 57
        Me.LMaterialsSup.Text = "Material suportat"
        '
        'DGMaterial
        '
        Me.DGMaterial.AllowUserToAddRows = False
        Me.DGMaterial.AllowUserToDeleteRows = False
        Me.DGMaterial.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMaterial.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.material, Me.descripcio})
        Me.DGMaterial.Location = New System.Drawing.Point(368, 44)
        Me.DGMaterial.MultiSelect = False
        Me.DGMaterial.Name = "DGMaterial"
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DGMaterial.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGMaterial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMaterial.Size = New System.Drawing.Size(337, 303)
        Me.DGMaterial.TabIndex = 58
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
        'PanelGcodeAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 380)
        Me.Controls.Add(Me.DGMaterial)
        Me.Controls.Add(Me.LMaterialsSup)
        Me.Controls.Add(Me.TBRuta)
        Me.Controls.Add(Me.LRuta)
        Me.Controls.Add(Me.BTBorrar)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.TBNomGcode)
        Me.Controls.Add(Me.LNomGcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelGcodeAfegir"
        Me.Text = "PanelGcodeAfegir"
        CType(Me.DGMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTBorrar As Button
    Friend WithEvents BTAfegir As Button
    Friend WithEvents TBNomGcode As TextBox
    Friend WithEvents LNomGcode As Label
    Friend WithEvents TBRuta As TextBox
    Friend WithEvents LRuta As Label
    Friend WithEvents LMaterialsSup As Label
    Friend WithEvents DGMaterial As DataGridView
    Friend WithEvents material As DataGridViewTextBoxColumn
    Friend WithEvents descripcio As DataGridViewTextBoxColumn
End Class
