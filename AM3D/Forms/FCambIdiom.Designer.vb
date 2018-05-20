<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FCambIdiom
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
        Me.LSelecionarIdioma = New System.Windows.Forms.Label()
        Me.BTCatala = New System.Windows.Forms.Button()
        Me.BTIngles = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LSelecionarIdioma
        '
        Me.LSelecionarIdioma.AutoSize = True
        Me.LSelecionarIdioma.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSelecionarIdioma.Location = New System.Drawing.Point(268, 42)
        Me.LSelecionarIdioma.Name = "LSelecionarIdioma"
        Me.LSelecionarIdioma.Size = New System.Drawing.Size(270, 31)
        Me.LSelecionarIdioma.TabIndex = 14
        Me.LSelecionarIdioma.Text = "Selecciona un idioma"
        '
        'BTCatala
        '
        Me.BTCatala.BackColor = System.Drawing.Color.White
        Me.BTCatala.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCatala.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCatala.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCatala.ForeColor = System.Drawing.Color.Black
        Me.BTCatala.Location = New System.Drawing.Point(147, 163)
        Me.BTCatala.Name = "BTCatala"
        Me.BTCatala.Size = New System.Drawing.Size(179, 133)
        Me.BTCatala.TabIndex = 1
        Me.BTCatala.Text = "Català"
        Me.BTCatala.UseVisualStyleBackColor = False
        '
        'BTIngles
        '
        Me.BTIngles.BackColor = System.Drawing.Color.White
        Me.BTIngles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTIngles.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTIngles.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTIngles.ForeColor = System.Drawing.Color.Black
        Me.BTIngles.Location = New System.Drawing.Point(455, 163)
        Me.BTIngles.Name = "BTIngles"
        Me.BTIngles.Size = New System.Drawing.Size(179, 133)
        Me.BTIngles.TabIndex = 2
        Me.BTIngles.Text = "English"
        Me.BTIngles.UseVisualStyleBackColor = False
        '
        'FCambIdiom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 521)
        Me.Controls.Add(Me.BTCatala)
        Me.Controls.Add(Me.BTIngles)
        Me.Controls.Add(Me.LSelecionarIdioma)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FCambIdiom"
        Me.Text = "FCambIdiom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LSelecionarIdioma As Label
    Friend WithEvents BTCatala As Button
    Friend WithEvents BTIngles As Button
End Class
