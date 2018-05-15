<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelGcodeModificarEliminar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTEliminarGcode = New System.Windows.Forms.Button()
        Me.BTModificarGcode = New System.Windows.Forms.Button()
        Me.DGGcode = New System.Windows.Forms.DataGridView()
        Me.nomGcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BResfrescar = New System.Windows.Forms.Button()
        CType(Me.DGGcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarGcode
        '
        Me.BTEliminarGcode.BackColor = System.Drawing.Color.White
        Me.BTEliminarGcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarGcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarGcode.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarGcode.Location = New System.Drawing.Point(183, 18)
        Me.BTEliminarGcode.Name = "BTEliminarGcode"
        Me.BTEliminarGcode.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarGcode.TabIndex = 9
        Me.BTEliminarGcode.Text = "Eliminar Gcode"
        Me.BTEliminarGcode.UseVisualStyleBackColor = False
        '
        'BTModificarGcode
        '
        Me.BTModificarGcode.BackColor = System.Drawing.Color.White
        Me.BTModificarGcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarGcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarGcode.ForeColor = System.Drawing.Color.Black
        Me.BTModificarGcode.Location = New System.Drawing.Point(23, 18)
        Me.BTModificarGcode.Name = "BTModificarGcode"
        Me.BTModificarGcode.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarGcode.TabIndex = 8
        Me.BTModificarGcode.Text = "Modificar Gcode"
        Me.BTModificarGcode.UseVisualStyleBackColor = False
        '
        'DGGcode
        '
        Me.DGGcode.AllowUserToAddRows = False
        Me.DGGcode.AllowUserToDeleteRows = False
        Me.DGGcode.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGGcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGGcode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nomGcode, Me.Hex, Me.usuari})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGGcode.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGGcode.Location = New System.Drawing.Point(23, 86)
        Me.DGGcode.MultiSelect = False
        Me.DGGcode.Name = "DGGcode"
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DGGcode.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGGcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGGcode.Size = New System.Drawing.Size(739, 268)
        Me.DGGcode.TabIndex = 37
        '
        'nomGcode
        '
        Me.nomGcode.HeaderText = "Nom Gcode"
        Me.nomGcode.Name = "nomGcode"
        Me.nomGcode.ReadOnly = True
        '
        'Hex
        '
        Me.Hex.HeaderText = "Material suportat"
        Me.Hex.Name = "Hex"
        Me.Hex.ReadOnly = True
        '
        'usuari
        '
        Me.usuari.HeaderText = "Usuari"
        Me.usuari.Name = "usuari"
        Me.usuari.ReadOnly = True
        '
        'BResfrescar
        '
        Me.BResfrescar.BackColor = System.Drawing.Color.White
        Me.BResfrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BResfrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BResfrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BResfrescar.ForeColor = System.Drawing.Color.Black
        Me.BResfrescar.Location = New System.Drawing.Point(608, 18)
        Me.BResfrescar.Name = "BResfrescar"
        Me.BResfrescar.Size = New System.Drawing.Size(154, 62)
        Me.BResfrescar.TabIndex = 38
        Me.BResfrescar.Text = "Refresca llista"
        Me.BResfrescar.UseVisualStyleBackColor = False
        '
        'PanelGcodeModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 380)
        Me.Controls.Add(Me.BResfrescar)
        Me.Controls.Add(Me.DGGcode)
        Me.Controls.Add(Me.BTEliminarGcode)
        Me.Controls.Add(Me.BTModificarGcode)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelGcodeModificarEliminar"
        Me.Text = "PanelGcodeModificarEliminar"
        CType(Me.DGGcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarGcode As Button
    Friend WithEvents BTModificarGcode As Button
    Friend WithEvents DGGcode As DataGridView
    Friend WithEvents nomGcode As DataGridViewTextBoxColumn
    Friend WithEvents Hex As DataGridViewTextBoxColumn
    Friend WithEvents usuari As DataGridViewTextBoxColumn
    Friend WithEvents BResfrescar As Button
End Class
