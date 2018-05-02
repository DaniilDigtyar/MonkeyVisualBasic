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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBModel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LVColor = New System.Windows.Forms.ListView()
        Me.LVMarca = New System.Windows.Forms.ListView()
        Me.LVMaterial = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Enabled = False
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
        Me.BTActualitzar.Enabled = False
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(650, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 20)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Color"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(458, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Fabricant"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(279, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Material"
        '
        'TBModel
        '
        Me.TBModel.Enabled = False
        Me.TBModel.Location = New System.Drawing.Point(61, 67)
        Me.TBModel.Name = "TBModel"
        Me.TBModel.Size = New System.Drawing.Size(114, 20)
        Me.TBModel.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(77, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Diametre"
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
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBModel)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TBModel As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LVColor As ListView
    Friend WithEvents LVMarca As ListView
    Friend WithEvents LVMaterial As ListView
End Class
