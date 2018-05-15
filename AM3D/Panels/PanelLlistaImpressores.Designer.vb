<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelLlistaImpressores
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTCambiarBobina = New System.Windows.Forms.Button()
        Me.BTModificarImpressora = New System.Windows.Forms.Button()
        Me.BTEliminarImpressora = New System.Windows.Forms.Button()
        Me.DGImpressores = New System.Windows.Forms.DataGridView()
        Me.codi_impressora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nom_assignat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bobina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BResfrescar = New System.Windows.Forms.Button()
        CType(Me.DGImpressores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTCambiarBobina
        '
        Me.BTCambiarBobina.BackColor = System.Drawing.Color.White
        Me.BTCambiarBobina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCambiarBobina.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCambiarBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCambiarBobina.ForeColor = System.Drawing.Color.Black
        Me.BTCambiarBobina.Location = New System.Drawing.Point(37, 21)
        Me.BTCambiarBobina.Name = "BTCambiarBobina"
        Me.BTCambiarBobina.Size = New System.Drawing.Size(154, 62)
        Me.BTCambiarBobina.TabIndex = 2
        Me.BTCambiarBobina.Text = "Canviar Bobina"
        Me.BTCambiarBobina.UseVisualStyleBackColor = False
        '
        'BTModificarImpressora
        '
        Me.BTModificarImpressora.BackColor = System.Drawing.Color.White
        Me.BTModificarImpressora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarImpressora.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarImpressora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarImpressora.ForeColor = System.Drawing.Color.Black
        Me.BTModificarImpressora.Location = New System.Drawing.Point(226, 21)
        Me.BTModificarImpressora.Name = "BTModificarImpressora"
        Me.BTModificarImpressora.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarImpressora.TabIndex = 3
        Me.BTModificarImpressora.Text = "Modificar impressora"
        Me.BTModificarImpressora.UseVisualStyleBackColor = False
        '
        'BTEliminarImpressora
        '
        Me.BTEliminarImpressora.BackColor = System.Drawing.Color.White
        Me.BTEliminarImpressora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarImpressora.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarImpressora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarImpressora.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarImpressora.Location = New System.Drawing.Point(424, 21)
        Me.BTEliminarImpressora.Name = "BTEliminarImpressora"
        Me.BTEliminarImpressora.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarImpressora.TabIndex = 4
        Me.BTEliminarImpressora.Text = "Eliminar impressora"
        Me.BTEliminarImpressora.UseVisualStyleBackColor = False
        '
        'DGImpressores
        '
        Me.DGImpressores.AllowUserToAddRows = False
        Me.DGImpressores.AllowUserToDeleteRows = False
        Me.DGImpressores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGImpressores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGImpressores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGImpressores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codi_impressora, Me.nom_assignat, Me.estat, Me.marca, Me.Model, Me.bobina})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGImpressores.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGImpressores.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DGImpressores.Location = New System.Drawing.Point(37, 98)
        Me.DGImpressores.MultiSelect = False
        Me.DGImpressores.Name = "DGImpressores"
        Me.DGImpressores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGImpressores.Size = New System.Drawing.Size(729, 246)
        Me.DGImpressores.TabIndex = 11
        '
        'codi_impressora
        '
        Me.codi_impressora.HeaderText = "Codi"
        Me.codi_impressora.Name = "codi_impressora"
        Me.codi_impressora.ReadOnly = True
        '
        'nom_assignat
        '
        Me.nom_assignat.HeaderText = "Nom"
        Me.nom_assignat.Name = "nom_assignat"
        Me.nom_assignat.ReadOnly = True
        '
        'estat
        '
        Me.estat.HeaderText = "Estat"
        Me.estat.Name = "estat"
        Me.estat.ReadOnly = True
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
        'bobina
        '
        Me.bobina.HeaderText = "Bobina"
        Me.bobina.Name = "bobina"
        Me.bobina.ReadOnly = True
        '
        'BResfrescar
        '
        Me.BResfrescar.BackColor = System.Drawing.Color.White
        Me.BResfrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BResfrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BResfrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BResfrescar.ForeColor = System.Drawing.Color.Black
        Me.BResfrescar.Location = New System.Drawing.Point(612, 21)
        Me.BResfrescar.Name = "BResfrescar"
        Me.BResfrescar.Size = New System.Drawing.Size(154, 62)
        Me.BResfrescar.TabIndex = 12
        Me.BResfrescar.Text = "Refresca llista"
        Me.BResfrescar.UseVisualStyleBackColor = False
        '
        'PanelLlistaImpressores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(802, 374)
        Me.Controls.Add(Me.BResfrescar)
        Me.Controls.Add(Me.DGImpressores)
        Me.Controls.Add(Me.BTEliminarImpressora)
        Me.Controls.Add(Me.BTModificarImpressora)
        Me.Controls.Add(Me.BTCambiarBobina)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelLlistaImpressores"
        Me.Text = "PanelLlistaImpressores"
        CType(Me.DGImpressores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTCambiarBobina As Button
    Friend WithEvents BTModificarImpressora As Button
    Friend WithEvents BTEliminarImpressora As Button
    Friend WithEvents DGImpressores As DataGridView
    Friend WithEvents codi_impressora As DataGridViewTextBoxColumn
    Friend WithEvents nom_assignat As DataGridViewTextBoxColumn
    Friend WithEvents estat As DataGridViewTextBoxColumn
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents Model As DataGridViewTextBoxColumn
    Friend WithEvents bobina As DataGridViewTextBoxColumn
    Friend WithEvents BResfrescar As Button
End Class
