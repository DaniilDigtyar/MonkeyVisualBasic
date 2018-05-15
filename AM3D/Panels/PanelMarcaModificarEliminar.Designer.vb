<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelMarcaModificarEliminar
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
        Me.BTEliminarMarca = New System.Windows.Forms.Button()
        Me.BTModificarMarca = New System.Windows.Forms.Button()
        Me.DGMarca = New System.Windows.Forms.DataGridView()
        Me.marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BResfrescar = New System.Windows.Forms.Button()
        CType(Me.DGMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarMarca
        '
        Me.BTEliminarMarca.BackColor = System.Drawing.Color.White
        Me.BTEliminarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarMarca.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarMarca.Location = New System.Drawing.Point(195, 16)
        Me.BTEliminarMarca.Name = "BTEliminarMarca"
        Me.BTEliminarMarca.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarMarca.TabIndex = 9
        Me.BTEliminarMarca.Text = "Eliminar Marca"
        Me.BTEliminarMarca.UseVisualStyleBackColor = False
        '
        'BTModificarMarca
        '
        Me.BTModificarMarca.BackColor = System.Drawing.Color.White
        Me.BTModificarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarMarca.ForeColor = System.Drawing.Color.Black
        Me.BTModificarMarca.Location = New System.Drawing.Point(35, 16)
        Me.BTModificarMarca.Name = "BTModificarMarca"
        Me.BTModificarMarca.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarMarca.TabIndex = 8
        Me.BTModificarMarca.Text = "Modificar Marca"
        Me.BTModificarMarca.UseVisualStyleBackColor = False
        '
        'DGMarca
        '
        Me.DGMarca.AllowUserToAddRows = False
        Me.DGMarca.AllowUserToDeleteRows = False
        Me.DGMarca.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMarca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.marca})
        Me.DGMarca.Location = New System.Drawing.Point(35, 84)
        Me.DGMarca.Name = "DGMarca"
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGMarca.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGMarca.Size = New System.Drawing.Size(739, 268)
        Me.DGMarca.TabIndex = 30
        '
        'marca
        '
        Me.marca.HeaderText = "Marca"
        Me.marca.Name = "marca"
        Me.marca.ReadOnly = True
        '
        'BResfrescar
        '
        Me.BResfrescar.BackColor = System.Drawing.Color.White
        Me.BResfrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BResfrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BResfrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BResfrescar.ForeColor = System.Drawing.Color.Black
        Me.BResfrescar.Location = New System.Drawing.Point(620, 12)
        Me.BResfrescar.Name = "BResfrescar"
        Me.BResfrescar.Size = New System.Drawing.Size(154, 62)
        Me.BResfrescar.TabIndex = 33
        Me.BResfrescar.Text = "Refresca llista"
        Me.BResfrescar.UseVisualStyleBackColor = False
        '
        'PanelMarcaModificarEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BResfrescar)
        Me.Controls.Add(Me.DGMarca)
        Me.Controls.Add(Me.BTEliminarMarca)
        Me.Controls.Add(Me.BTModificarMarca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelMarcaModificarEliminar"
        Me.Text = "PanelMarcaModificarEliminar"
        CType(Me.DGMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTEliminarMarca As Button
    Friend WithEvents BTModificarMarca As Button
    Friend WithEvents DGMarca As DataGridView
    Friend WithEvents marca As DataGridViewTextBoxColumn
    Friend WithEvents BResfrescar As Button
End Class
