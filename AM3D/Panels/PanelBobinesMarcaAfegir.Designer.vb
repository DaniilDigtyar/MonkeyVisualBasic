<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelBobinesMarcaAfegir
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
        Me.TBMarca = New System.Windows.Forms.TextBox()
        Me.LMarcaProductora = New System.Windows.Forms.Label()
        Me.BTBorrar = New System.Windows.Forms.Button()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBMarca
        '
        Me.TBMarca.Location = New System.Drawing.Point(180, 30)
        Me.TBMarca.Name = "TBMarca"
        Me.TBMarca.Size = New System.Drawing.Size(141, 20)
        Me.TBMarca.TabIndex = 59
        '
        'LMarcaProductora
        '
        Me.LMarcaProductora.AutoSize = True
        Me.LMarcaProductora.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarcaProductora.ForeColor = System.Drawing.Color.Black
        Me.LMarcaProductora.Location = New System.Drawing.Point(25, 30)
        Me.LMarcaProductora.Name = "LMarcaProductora"
        Me.LMarcaProductora.Size = New System.Drawing.Size(134, 20)
        Me.LMarcaProductora.TabIndex = 58
        Me.LMarcaProductora.Text = "Marca productora"
        '
        'BTBorrar
        '
        Me.BTBorrar.BackColor = System.Drawing.Color.White
        Me.BTBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBorrar.ForeColor = System.Drawing.Color.Black
        Me.BTBorrar.Location = New System.Drawing.Point(29, 167)
        Me.BTBorrar.Name = "BTBorrar"
        Me.BTBorrar.Size = New System.Drawing.Size(245, 62)
        Me.BTBorrar.TabIndex = 57
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
        Me.BTAfegir.Location = New System.Drawing.Point(29, 92)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(245, 62)
        Me.BTAfegir.TabIndex = 56
        Me.BTAfegir.Text = "Afegir"
        Me.BTAfegir.UseVisualStyleBackColor = False
        '
        'PanelBobinesMarcaAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(801, 376)
        Me.Controls.Add(Me.TBMarca)
        Me.Controls.Add(Me.LMarcaProductora)
        Me.Controls.Add(Me.BTBorrar)
        Me.Controls.Add(Me.BTAfegir)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelBobinesMarcaAfegir"
        Me.Text = "PanelBobinesMarcaAfegir"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBMarca As TextBox
    Friend WithEvents LMarcaProductora As Label
    Friend WithEvents BTBorrar As Button
    Friend WithEvents BTAfegir As Button
End Class
