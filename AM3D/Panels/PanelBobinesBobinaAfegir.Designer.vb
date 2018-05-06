<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBobinesBobinaAfegir
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
        Me.LVMaterial = New System.Windows.Forms.ListView()
        Me.LVMarca = New System.Windows.Forms.ListView()
        Me.LVColor = New System.Windows.Forms.ListView()
        Me.TBDiametre = New System.Windows.Forms.TextBox()
        Me.LDiametre = New System.Windows.Forms.Label()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.LColor = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.BTBorrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LVMaterial
        '
        Me.LVMaterial.Location = New System.Drawing.Point(250, 70)
        Me.LVMaterial.Name = "LVMaterial"
        Me.LVMaterial.Size = New System.Drawing.Size(144, 273)
        Me.LVMaterial.TabIndex = 0
        Me.LVMaterial.UseCompatibleStateImageBehavior = False
        '
        'LVMarca
        '
        Me.LVMarca.Location = New System.Drawing.Point(436, 70)
        Me.LVMarca.Name = "LVMarca"
        Me.LVMarca.Size = New System.Drawing.Size(144, 273)
        Me.LVMarca.TabIndex = 1
        Me.LVMarca.UseCompatibleStateImageBehavior = False
        '
        'LVColor
        '
        Me.LVColor.Location = New System.Drawing.Point(617, 70)
        Me.LVColor.Name = "LVColor"
        Me.LVColor.Size = New System.Drawing.Size(144, 273)
        Me.LVColor.TabIndex = 2
        Me.LVColor.UseCompatibleStateImageBehavior = False
        '
        'TBDiametre
        '
        Me.TBDiametre.Location = New System.Drawing.Point(72, 70)
        Me.TBDiametre.Name = "TBDiametre"
        Me.TBDiametre.Size = New System.Drawing.Size(114, 20)
        Me.TBDiametre.TabIndex = 54
        '
        'LDiametre
        '
        Me.LDiametre.AutoSize = True
        Me.LDiametre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDiametre.ForeColor = System.Drawing.Color.Black
        Me.LDiametre.Location = New System.Drawing.Point(88, 34)
        Me.LDiametre.Name = "LDiametre"
        Me.LDiametre.Size = New System.Drawing.Size(74, 20)
        Me.LDiametre.TabIndex = 53
        Me.LDiametre.Text = "Diametre"
        '
        'LMaterial
        '
        Me.LMaterial.AutoSize = True
        Me.LMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterial.ForeColor = System.Drawing.Color.Black
        Me.LMaterial.Location = New System.Drawing.Point(290, 34)
        Me.LMaterial.Name = "LMaterial"
        Me.LMaterial.Size = New System.Drawing.Size(65, 20)
        Me.LMaterial.TabIndex = 55
        Me.LMaterial.Text = "Material"
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(446, 34)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(135, 20)
        Me.LMarca.TabIndex = 56
        Me.LMarca.Text = "Marca Productora"
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LColor.ForeColor = System.Drawing.Color.Black
        Me.LColor.Location = New System.Drawing.Point(661, 34)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(46, 20)
        Me.LColor.TabIndex = 57
        Me.LColor.Text = "Color"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Location = New System.Drawing.Point(713, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(29, 28)
        Me.Panel1.TabIndex = 58
        '
        'BTAfegir
        '
        Me.BTAfegir.BackColor = System.Drawing.Color.White
        Me.BTAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTAfegir.Location = New System.Drawing.Point(53, 188)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(155, 58)
        Me.BTAfegir.TabIndex = 65
        Me.BTAfegir.Text = "Afegir"
        Me.BTAfegir.UseVisualStyleBackColor = False
        '
        'BTBorrar
        '
        Me.BTBorrar.BackColor = System.Drawing.Color.White
        Me.BTBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBorrar.ForeColor = System.Drawing.Color.Black
        Me.BTBorrar.Location = New System.Drawing.Point(53, 285)
        Me.BTBorrar.Name = "BTBorrar"
        Me.BTBorrar.Size = New System.Drawing.Size(155, 58)
        Me.BTBorrar.TabIndex = 66
        Me.BTBorrar.Text = "Borrar"
        Me.BTBorrar.UseVisualStyleBackColor = False
        '
        'PanelBobinesBobinaAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.BTBorrar)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LColor)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.LMaterial)
        Me.Controls.Add(Me.TBDiametre)
        Me.Controls.Add(Me.LDiametre)
        Me.Controls.Add(Me.LVColor)
        Me.Controls.Add(Me.LVMarca)
        Me.Controls.Add(Me.LVMaterial)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesBobinaAfegir"
        Me.Text = "PanelBobinesBobinaAfegir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LVMaterial As ListView
    Friend WithEvents LVMarca As ListView
    Friend WithEvents LVColor As ListView
    Friend WithEvents TBDiametre As TextBox
    Friend WithEvents LDiametre As Label
    Friend WithEvents LMaterial As Label
    Friend WithEvents LMarca As Label
    Friend WithEvents LColor As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTAfegir As Button
    Friend WithEvents BTBorrar As Button
End Class
