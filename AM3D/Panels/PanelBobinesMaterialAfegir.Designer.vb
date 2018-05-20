<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBobinesMaterialAfegir
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
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.TBMaterial = New System.Windows.Forms.TextBox()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TBTecnic
        '
        Me.TBTecnic.Location = New System.Drawing.Point(210, 78)
        Me.TBTecnic.MaxLength = 40
        Me.TBTecnic.Name = "TBTecnic"
        Me.TBTecnic.Size = New System.Drawing.Size(141, 20)
        Me.TBTecnic.TabIndex = 2
        '
        'LTecnic
        '
        Me.LTecnic.AutoSize = True
        Me.LTecnic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTecnic.ForeColor = System.Drawing.Color.Black
        Me.LTecnic.Location = New System.Drawing.Point(38, 78)
        Me.LTecnic.Name = "LTecnic"
        Me.LTecnic.Size = New System.Drawing.Size(92, 20)
        Me.LTecnic.TabIndex = 60
        Me.LTecnic.Text = "Nom Tècnic"
        '
        'BTBorrar
        '
        Me.BTBorrar.BackColor = System.Drawing.Color.White
        Me.BTBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBorrar.ForeColor = System.Drawing.Color.Black
        Me.BTBorrar.Location = New System.Drawing.Point(42, 215)
        Me.BTBorrar.Name = "BTBorrar"
        Me.BTBorrar.Size = New System.Drawing.Size(245, 62)
        Me.BTBorrar.TabIndex = 4
        Me.BTBorrar.Text = "Borrar"
        Me.BTBorrar.UseVisualStyleBackColor = False
        '
        'BTAfegir
        '
        Me.BTAfegir.BackColor = System.Drawing.Color.White
        Me.BTAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTAfegir.Location = New System.Drawing.Point(42, 140)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(245, 62)
        Me.BTAfegir.TabIndex = 3
        Me.BTAfegir.Text = "Afegir"
        Me.BTAfegir.UseVisualStyleBackColor = False
        '
        'TBMaterial
        '
        Me.TBMaterial.Location = New System.Drawing.Point(210, 34)
        Me.TBMaterial.MaxLength = 20
        Me.TBMaterial.Name = "TBMaterial"
        Me.TBMaterial.Size = New System.Drawing.Size(141, 20)
        Me.TBMaterial.TabIndex = 1
        '
        'LMaterial
        '
        Me.LMaterial.AutoSize = True
        Me.LMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterial.ForeColor = System.Drawing.Color.Black
        Me.LMaterial.Location = New System.Drawing.Point(38, 34)
        Me.LMaterial.Name = "LMaterial"
        Me.LMaterial.Size = New System.Drawing.Size(65, 20)
        Me.LMaterial.TabIndex = 56
        Me.LMaterial.Text = "Material"
        '
        'PanelBobinesMaterialAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.TBTecnic)
        Me.Controls.Add(Me.LTecnic)
        Me.Controls.Add(Me.BTBorrar)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.TBMaterial)
        Me.Controls.Add(Me.LMaterial)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesMaterialAfegir"
        Me.Text = "PanelBobinesMaterialAfegir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBTecnic As TextBox
    Friend WithEvents LTecnic As Label
    Friend WithEvents BTBorrar As Button
    Friend WithEvents BTAfegir As Button
    Friend WithEvents TBMaterial As TextBox
    Friend WithEvents LMaterial As Label
End Class
