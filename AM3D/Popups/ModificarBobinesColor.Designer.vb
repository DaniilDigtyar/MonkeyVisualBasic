<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarBobinesColor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarBobinesColor))
        Me.TBHex = New System.Windows.Forms.TextBox()
        Me.LHex = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.TBColor = New System.Windows.Forms.TextBox()
        Me.LColor = New System.Windows.Forms.Label()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBHex
        '
        Me.TBHex.Location = New System.Drawing.Point(109, 86)
        Me.TBHex.MaxLength = 7
        Me.TBHex.Name = "TBHex"
        Me.TBHex.Size = New System.Drawing.Size(141, 20)
        Me.TBHex.TabIndex = 61
        '
        'LHex
        '
        Me.LHex.AutoSize = True
        Me.LHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHex.ForeColor = System.Drawing.Color.Black
        Me.LHex.Location = New System.Drawing.Point(17, 86)
        Me.LHex.Name = "LHex"
        Me.LHex.Size = New System.Drawing.Size(79, 20)
        Me.LHex.TabIndex = 60
        Me.LHex.Text = "Codi HEX"
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(42, 233)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(245, 62)
        Me.BTCancelar.TabIndex = 59
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
        Me.BTModificar.Location = New System.Drawing.Point(42, 158)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(245, 62)
        Me.BTModificar.TabIndex = 58
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = False
        '
        'TBColor
        '
        Me.TBColor.Location = New System.Drawing.Point(109, 42)
        Me.TBColor.Name = "TBColor"
        Me.TBColor.Size = New System.Drawing.Size(178, 20)
        Me.TBColor.TabIndex = 57
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LColor.ForeColor = System.Drawing.Color.Black
        Me.LColor.Location = New System.Drawing.Point(17, 42)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(46, 20)
        Me.LColor.TabIndex = 56
        Me.LColor.Text = "Color"
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(-3, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(345, 19)
        Me.MenuSup.TabIndex = 62
        '
        'PanelColor
        '
        Me.PanelColor.BackColor = System.Drawing.Color.Transparent
        Me.PanelColor.Location = New System.Drawing.Point(256, 86)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(31, 20)
        Me.PanelColor.TabIndex = 63
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LabelInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelInfo.Location = New System.Drawing.Point(18, 123)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(0, 18)
        Me.LabelInfo.TabIndex = 71
        '
        'ModificarBobinesColor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(341, 364)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.PanelColor)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.TBHex)
        Me.Controls.Add(Me.LHex)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTModificar)
        Me.Controls.Add(Me.TBColor)
        Me.Controls.Add(Me.LColor)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarBobinesColor"
        Me.Text = "L"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBHex As TextBox
    Friend WithEvents LHex As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTModificar As Button
    Friend WithEvents TBColor As TextBox
    Friend WithEvents LColor As Label
    Friend WithEvents MenuSup As Panel
    Friend WithEvents PanelColor As Panel
    Friend WithEvents LabelInfo As Label
End Class
