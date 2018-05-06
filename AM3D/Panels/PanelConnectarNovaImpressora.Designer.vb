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
        Me.LVBobines = New System.Windows.Forms.ListView()
        Me.LBobina = New System.Windows.Forms.Label()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.TBNomImpressora = New System.Windows.Forms.TextBox()
        Me.BTImpressoraGuardar = New System.Windows.Forms.Button()
        Me.BTImpressoraBorrar = New System.Windows.Forms.Button()
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
        'LVBobines
        '
        Me.LVBobines.Location = New System.Drawing.Point(496, 12)
        Me.LVBobines.Name = "LVBobines"
        Me.LVBobines.Size = New System.Drawing.Size(294, 350)
        Me.LVBobines.TabIndex = 3
        Me.LVBobines.UseCompatibleStateImageBehavior = False
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
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Location = New System.Drawing.Point(163, 46)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(169, 21)
        Me.CBMarca.TabIndex = 5
        '
        'CBModel
        '
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(163, 120)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(169, 21)
        Me.CBModel.TabIndex = 6
        '
        'TBNomImpressora
        '
        Me.TBNomImpressora.Location = New System.Drawing.Point(163, 187)
        Me.TBNomImpressora.Name = "TBNomImpressora"
        Me.TBNomImpressora.Size = New System.Drawing.Size(169, 20)
        Me.TBNomImpressora.TabIndex = 7
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
        'PanelConnectarNovaImpressora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(802, 374)
        Me.Controls.Add(Me.BTImpressoraBorrar)
        Me.Controls.Add(Me.BTImpressoraGuardar)
        Me.Controls.Add(Me.TBNomImpressora)
        Me.Controls.Add(Me.CBModel)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.LBobina)
        Me.Controls.Add(Me.LVBobines)
        Me.Controls.Add(Me.LNom)
        Me.Controls.Add(Me.LModel)
        Me.Controls.Add(Me.LMarca)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelConnectarNovaImpressora"
        Me.Text = "PanelConnectarNovaImpressora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LMarca As Label
    Friend WithEvents LModel As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LVBobines As ListView
    Friend WithEvents LBobina As Label
    Friend WithEvents CBMarca As ComboBox
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents TBNomImpressora As TextBox
    Friend WithEvents BTImpressoraGuardar As Button
    Friend WithEvents BTImpressoraBorrar As Button
End Class
