<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarBobinesBobina
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTActualitzar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LColor = New System.Windows.Forms.Label()
        Me.LFabricant = New System.Windows.Forms.Label()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.TBModel = New System.Windows.Forms.TextBox()
        Me.LDiametre = New System.Windows.Forms.Label()
        Me.LVColor = New System.Windows.Forms.ListView()
        Me.LVMarca = New System.Windows.Forms.ListView()
        Me.LVMaterial = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(42, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 58)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTActualitzar
        '
        Me.BTActualitzar.BackColor = System.Drawing.Color.White
        Me.BTActualitzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTActualitzar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTActualitzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTActualitzar.ForeColor = System.Drawing.Color.Black
        Me.BTActualitzar.Location = New System.Drawing.Point(42, 168)
        Me.BTActualitzar.Name = "BTActualitzar"
        Me.BTActualitzar.Size = New System.Drawing.Size(155, 58)
        Me.BTActualitzar.TabIndex = 76
        Me.BTActualitzar.Text = "Modificar"
        Me.BTActualitzar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(702, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(29, 28)
        Me.Panel1.TabIndex = 75
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LColor.ForeColor = System.Drawing.Color.Black
        Me.LColor.Location = New System.Drawing.Point(650, 31)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(46, 20)
        Me.LColor.TabIndex = 74
        Me.LColor.Text = "Color"
        '
        'LFabricant
        '
        Me.LFabricant.AutoSize = True
        Me.LFabricant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFabricant.ForeColor = System.Drawing.Color.Black
        Me.LFabricant.Location = New System.Drawing.Point(428, 31)
        Me.LFabricant.Name = "LFabricant"
        Me.LFabricant.Size = New System.Drawing.Size(135, 20)
        Me.LFabricant.TabIndex = 73
        Me.LFabricant.Text = "Marca Productora"
        '
        'LMaterial
        '
        Me.LMaterial.AutoSize = True
        Me.LMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterial.ForeColor = System.Drawing.Color.Black
        Me.LMaterial.Location = New System.Drawing.Point(279, 31)
        Me.LMaterial.Name = "LMaterial"
        Me.LMaterial.Size = New System.Drawing.Size(65, 20)
        Me.LMaterial.TabIndex = 72
        Me.LMaterial.Text = "Material"
        '
        'TBModel
        '
        Me.TBModel.Location = New System.Drawing.Point(61, 67)
        Me.TBModel.Name = "TBModel"
        Me.TBModel.Size = New System.Drawing.Size(114, 20)
        Me.TBModel.TabIndex = 71
        '
        'LDiametre
        '
        Me.LDiametre.AutoSize = True
        Me.LDiametre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDiametre.ForeColor = System.Drawing.Color.Black
        Me.LDiametre.Location = New System.Drawing.Point(77, 31)
        Me.LDiametre.Name = "LDiametre"
        Me.LDiametre.Size = New System.Drawing.Size(74, 20)
        Me.LDiametre.TabIndex = 70
        Me.LDiametre.Text = "Diametre"
        '
        'LVColor
        '
        Me.LVColor.Location = New System.Drawing.Point(606, 67)
        Me.LVColor.Name = "LVColor"
        Me.LVColor.Size = New System.Drawing.Size(144, 273)
        Me.LVColor.TabIndex = 69
        Me.LVColor.UseCompatibleStateImageBehavior = False
        '
        'LVMarca
        '
        Me.LVMarca.Location = New System.Drawing.Point(425, 67)
        Me.LVMarca.Name = "LVMarca"
        Me.LVMarca.Size = New System.Drawing.Size(144, 273)
        Me.LVMarca.TabIndex = 68
        Me.LVMarca.UseCompatibleStateImageBehavior = False
        '
        'LVMaterial
        '
        Me.LVMaterial.Location = New System.Drawing.Point(239, 67)
        Me.LVMaterial.Name = "LVMaterial"
        Me.LVMaterial.Size = New System.Drawing.Size(144, 273)
        Me.LVMaterial.TabIndex = 67
        Me.LVMaterial.UseCompatibleStateImageBehavior = False
        '
        'ModificarBobinesBobina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(798, 388)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTActualitzar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LColor)
        Me.Controls.Add(Me.LFabricant)
        Me.Controls.Add(Me.LMaterial)
        Me.Controls.Add(Me.TBModel)
        Me.Controls.Add(Me.LDiametre)
        Me.Controls.Add(Me.LVColor)
        Me.Controls.Add(Me.LVMarca)
        Me.Controls.Add(Me.LVMaterial)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarBobinesBobina"
        Me.Text = "ModificarBobinesBobina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents BTActualitzar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LColor As Label
    Friend WithEvents LFabricant As Label
    Friend WithEvents LMaterial As Label
    Friend WithEvents TBModel As TextBox
    Friend WithEvents LDiametre As Label
    Friend WithEvents LVColor As ListView
    Friend WithEvents LVMarca As ListView
    Friend WithEvents LVMaterial As ListView
End Class
