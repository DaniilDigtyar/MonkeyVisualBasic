<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarImpressores
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
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.Labelnfo = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTImpressoraGuardar = New System.Windows.Forms.Button()
        Me.TBNomImpressora = New System.Windows.Forms.TextBox()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LModel = New System.Windows.Forms.Label()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(0, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(353, 16)
        Me.MenuSup.TabIndex = 69
        '
        'Labelnfo
        '
        Me.Labelnfo.AutoSize = True
        Me.Labelnfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Labelnfo.ForeColor = System.Drawing.Color.DarkRed
        Me.Labelnfo.Location = New System.Drawing.Point(16, 221)
        Me.Labelnfo.Name = "Labelnfo"
        Me.Labelnfo.Size = New System.Drawing.Size(0, 18)
        Me.Labelnfo.TabIndex = 79
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(179, 252)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(154, 62)
        Me.BTCancelar.TabIndex = 78
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
        '
        'BTImpressoraGuardar
        '
        Me.BTImpressoraGuardar.BackColor = System.Drawing.Color.White
        Me.BTImpressoraGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImpressoraGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImpressoraGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImpressoraGuardar.ForeColor = System.Drawing.Color.Black
        Me.BTImpressoraGuardar.Location = New System.Drawing.Point(19, 252)
        Me.BTImpressoraGuardar.Name = "BTImpressoraGuardar"
        Me.BTImpressoraGuardar.Size = New System.Drawing.Size(154, 62)
        Me.BTImpressoraGuardar.TabIndex = 77
        Me.BTImpressoraGuardar.Text = "Guardar"
        Me.BTImpressoraGuardar.UseVisualStyleBackColor = False
        '
        'TBNomImpressora
        '
        Me.TBNomImpressora.Location = New System.Drawing.Point(124, 175)
        Me.TBNomImpressora.Name = "TBNomImpressora"
        Me.TBNomImpressora.Size = New System.Drawing.Size(169, 20)
        Me.TBNomImpressora.TabIndex = 75
        '
        'CBModel
        '
        Me.CBModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(124, 108)
        Me.CBModel.MaxDropDownItems = 10
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(169, 21)
        Me.CBModel.TabIndex = 73
        '
        'CBMarca
        '
        Me.CBMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Location = New System.Drawing.Point(124, 34)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(169, 21)
        Me.CBMarca.TabIndex = 71
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.ForeColor = System.Drawing.Color.Black
        Me.LNom.Location = New System.Drawing.Point(14, 170)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(53, 25)
        Me.LNom.TabIndex = 74
        Me.LNom.Text = "Nom"
        '
        'LModel
        '
        Me.LModel.AutoSize = True
        Me.LModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModel.ForeColor = System.Drawing.Color.Black
        Me.LModel.Location = New System.Drawing.Point(14, 102)
        Me.LModel.Name = "LModel"
        Me.LModel.Size = New System.Drawing.Size(66, 25)
        Me.LModel.TabIndex = 72
        Me.LModel.Text = "Model"
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(14, 28)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(67, 25)
        Me.LMarca.TabIndex = 70
        Me.LMarca.Text = "Marca"
        '
        'ModificarImpressores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 336)
        Me.Controls.Add(Me.Labelnfo)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTImpressoraGuardar)
        Me.Controls.Add(Me.TBNomImpressora)
        Me.Controls.Add(Me.CBModel)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.LNom)
        Me.Controls.Add(Me.LModel)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.MenuSup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarImpressores"
        Me.Text = "ModificarImpressores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuSup As Panel
    Friend WithEvents Labelnfo As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTImpressoraGuardar As Button
    Friend WithEvents TBNomImpressora As TextBox
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents CBMarca As ComboBox
    Friend WithEvents LNom As Label
    Friend WithEvents LModel As Label
    Friend WithEvents LMarca As Label
End Class
