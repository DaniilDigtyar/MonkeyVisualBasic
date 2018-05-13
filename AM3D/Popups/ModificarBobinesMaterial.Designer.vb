<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarBobinesMaterial
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
        Me.TBTecnic = New System.Windows.Forms.TextBox()
        Me.LTecnic = New System.Windows.Forms.Label()
        Me.BTBorrar = New System.Windows.Forms.Button()
        Me.BTModificar = New System.Windows.Forms.Button()
        Me.TBMaterial = New System.Windows.Forms.TextBox()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBTecnic
        '
        Me.TBTecnic.Location = New System.Drawing.Point(196, 78)
        Me.TBTecnic.Name = "TBTecnic"
        Me.TBTecnic.Size = New System.Drawing.Size(141, 20)
        Me.TBTecnic.TabIndex = 67
        '
        'LTecnic
        '
        Me.LTecnic.AutoSize = True
        Me.LTecnic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTecnic.ForeColor = System.Drawing.Color.Black
        Me.LTecnic.Location = New System.Drawing.Point(29, 78)
        Me.LTecnic.Name = "LTecnic"
        Me.LTecnic.Size = New System.Drawing.Size(92, 20)
        Me.LTecnic.TabIndex = 66
        Me.LTecnic.Text = "Nom Tècnic"
        '
        'BTBorrar
        '
        Me.BTBorrar.BackColor = System.Drawing.Color.White
        Me.BTBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBorrar.ForeColor = System.Drawing.Color.Black
        Me.BTBorrar.Location = New System.Drawing.Point(57, 235)
        Me.BTBorrar.Name = "BTBorrar"
        Me.BTBorrar.Size = New System.Drawing.Size(245, 62)
        Me.BTBorrar.TabIndex = 65
        Me.BTBorrar.Text = "Borrar"
        Me.BTBorrar.UseVisualStyleBackColor = False
        '
        'BTModificar
        '
        Me.BTModificar.BackColor = System.Drawing.Color.White
        Me.BTModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificar.ForeColor = System.Drawing.Color.Black
        Me.BTModificar.Location = New System.Drawing.Point(57, 150)
        Me.BTModificar.Name = "BTModificar"
        Me.BTModificar.Size = New System.Drawing.Size(245, 62)
        Me.BTModificar.TabIndex = 64
        Me.BTModificar.Text = "Modificar"
        Me.BTModificar.UseVisualStyleBackColor = False
        '
        'TBMaterial
        '
        Me.TBMaterial.Location = New System.Drawing.Point(196, 36)
        Me.TBMaterial.Name = "TBMaterial"
        Me.TBMaterial.Size = New System.Drawing.Size(141, 20)
        Me.TBMaterial.TabIndex = 63
        '
        'LMaterial
        '
        Me.LMaterial.AutoSize = True
        Me.LMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterial.ForeColor = System.Drawing.Color.Black
        Me.LMaterial.Location = New System.Drawing.Point(29, 34)
        Me.LMaterial.Name = "LMaterial"
        Me.LMaterial.Size = New System.Drawing.Size(65, 20)
        Me.LMaterial.TabIndex = 62
        Me.LMaterial.Text = "Material"
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(0, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(366, 19)
        Me.MenuSup.TabIndex = 68
        '
        'LabelInfo
        '
        Me.LabelInfo.AutoSize = True
        Me.LabelInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.LabelInfo.ForeColor = System.Drawing.Color.DarkRed
        Me.LabelInfo.Location = New System.Drawing.Point(30, 116)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(0, 18)
        Me.LabelInfo.TabIndex = 69
        '
        'ModificarBobinesMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 332)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.TBTecnic)
        Me.Controls.Add(Me.LTecnic)
        Me.Controls.Add(Me.BTBorrar)
        Me.Controls.Add(Me.BTModificar)
        Me.Controls.Add(Me.TBMaterial)
        Me.Controls.Add(Me.LMaterial)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarBobinesMaterial"
        Me.Text = "ModificarBobinesMaterial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBTecnic As TextBox
    Friend WithEvents LTecnic As Label
    Friend WithEvents BTBorrar As Button
    Friend WithEvents BTModificar As Button
    Friend WithEvents TBMaterial As TextBox
    Friend WithEvents LMaterial As Label
    Friend WithEvents MenuSup As Panel
    Friend WithEvents LabelInfo As Label
End Class
