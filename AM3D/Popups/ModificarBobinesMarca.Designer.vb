<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarBobinesMarca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarBobinesMarca))
        Me.TBMarca = New System.Windows.Forms.TextBox()
        Me.LMarcaProductora = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBMarca
        '
        Me.TBMarca.Location = New System.Drawing.Point(163, 28)
        Me.TBMarca.MaxLength = 20
        Me.TBMarca.Name = "TBMarca"
        Me.TBMarca.Size = New System.Drawing.Size(141, 20)
        Me.TBMarca.TabIndex = 1
        '
        'LMarcaProductora
        '
        Me.LMarcaProductora.AutoSize = True
        Me.LMarcaProductora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarcaProductora.ForeColor = System.Drawing.Color.Black
        Me.LMarcaProductora.Location = New System.Drawing.Point(8, 28)
        Me.LMarcaProductora.Name = "LMarcaProductora"
        Me.LMarcaProductora.Size = New System.Drawing.Size(134, 20)
        Me.LMarcaProductora.TabIndex = 62
        Me.LMarcaProductora.Text = "Marca productora"
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(34, 166)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(245, 62)
        Me.BTCancelar.TabIndex = 3
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
        '
        'BTModificar
        '
        Me.BTModificar.BackColor = System.Drawing.Color.White
        Me.BTModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificar.ForeColor = System.Drawing.Color.Black
        Me.BTModificar.Location = New System.Drawing.Point(34, 91)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(245, 62)
        Me.BTModificar.TabIndex = 2
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = False
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(0, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(310, 19)
        Me.MenuSup.TabIndex = 64
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LabelInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelInfo.Location = New System.Drawing.Point(9, 59)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(0, 18)
        Me.LabelInfo.TabIndex = 70
        '
        'ModificarBobinesMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(310, 247)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.TBMarca)
        Me.Controls.Add(Me.LMarcaProductora)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTModificar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarBobinesMarca"
        Me.Text = "ModificarBobinesMarca"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBMarca As TextBox
    Friend WithEvents LMarcaProductora As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTModificar As Button
    Friend WithEvents MenuSup As Panel
    Friend WithEvents LabelInfo As Label
End Class
