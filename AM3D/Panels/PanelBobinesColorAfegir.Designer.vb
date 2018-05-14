<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBobinesColorAfegir
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
        Me.BTBorrar = New System.Windows.Forms.Button()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.TBColor = New System.Windows.Forms.TextBox()
        Me.LColor = New System.Windows.Forms.Label()
        Me.TBHex = New System.Windows.Forms.TextBox()
        Me.LHex = New System.Windows.Forms.Label()
        Me.PanelColor = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BTBorrar
        '
        Me.BTBorrar.BackColor = System.Drawing.Color.White
        Me.BTBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBorrar.ForeColor = System.Drawing.Color.Black
        Me.BTBorrar.Location = New System.Drawing.Point(46, 212)
        Me.BTBorrar.Name = "BTBorrar"
        Me.BTBorrar.Size = New System.Drawing.Size(245, 62)
        Me.BTBorrar.TabIndex = 53
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
        Me.BTAfegir.Location = New System.Drawing.Point(46, 137)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(245, 62)
        Me.BTAfegir.TabIndex = 52
        Me.BTAfegir.Text = "Afegir"
        Me.BTAfegir.UseVisualStyleBackColor = False
        '
        'TBColor
        '
        Me.TBColor.Location = New System.Drawing.Point(150, 31)
        Me.TBColor.Name = "TBColor"
        Me.TBColor.Size = New System.Drawing.Size(141, 20)
        Me.TBColor.TabIndex = 51
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LColor.ForeColor = System.Drawing.Color.Black
        Me.LColor.Location = New System.Drawing.Point(42, 31)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(46, 20)
        Me.LColor.TabIndex = 50
        Me.LColor.Text = "Color"
        '
        'TBHex
        '
        Me.TBHex.Location = New System.Drawing.Point(150, 75)
        Me.TBHex.MaxLength = 7
        Me.TBHex.Name = "TBHex"
        Me.TBHex.Size = New System.Drawing.Size(141, 20)
        Me.TBHex.TabIndex = 55
        '
        'LHex
        '
        Me.LHex.AutoSize = True
        Me.LHex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LHex.ForeColor = System.Drawing.Color.Black
        Me.LHex.Location = New System.Drawing.Point(42, 75)
        Me.LHex.Name = "LHex"
        Me.LHex.Size = New System.Drawing.Size(79, 20)
        Me.LHex.TabIndex = 54
        Me.LHex.Text = "Codi HEX"
        '
        'PanelColor
        '
        Me.PanelColor.BackColor = System.Drawing.Color.Transparent
        Me.PanelColor.Location = New System.Drawing.Point(297, 75)
        Me.PanelColor.Name = "PanelColor"
        Me.PanelColor.Size = New System.Drawing.Size(51, 20)
        Me.PanelColor.TabIndex = 56
        '
        'PanelBobinesColorAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.PanelColor)
        Me.Controls.Add(Me.TBHex)
        Me.Controls.Add(Me.LHex)
        Me.Controls.Add(Me.BTBorrar)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.TBColor)
        Me.Controls.Add(Me.LColor)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesColorAfegir"
        Me.Text = "PanelBobinesColorAfegir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTBorrar As Button
    Friend WithEvents BTAfegir As Button
    Friend WithEvents TBColor As TextBox
    Friend WithEvents LColor As Label
    Friend WithEvents TBHex As TextBox
    Friend WithEvents LHex As Label
    Friend WithEvents PanelColor As Panel
End Class
