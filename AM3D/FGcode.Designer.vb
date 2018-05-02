<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FGcode
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
        Me.PGcode = New System.Windows.Forms.Panel()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.BTModificarEliminar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PGcode
        '
        Me.PGcode.Location = New System.Drawing.Point(23, 113)
        Me.PGcode.Name = "PGcode"
        Me.PGcode.Size = New System.Drawing.Size(780, 380)
        Me.PGcode.TabIndex = 8
        '
        'BTAfegir
        '
        Me.BTAfegir.BackColor = System.Drawing.Color.White
        Me.BTAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTAfegir.Location = New System.Drawing.Point(84, 27)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(190, 62)
        Me.BTAfegir.TabIndex = 7
        Me.BTAfegir.Text = "Afegir"
        Me.BTAfegir.UseVisualStyleBackColor = False
        '
        'BTModificarEliminar
        '
        Me.BTModificarEliminar.BackColor = System.Drawing.Color.White
        Me.BTModificarEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarEliminar.ForeColor = System.Drawing.Color.Black
        Me.BTModificarEliminar.Location = New System.Drawing.Point(571, 27)
        Me.BTModificarEliminar.Name = "BTModificarEliminar"
        Me.BTModificarEliminar.Size = New System.Drawing.Size(190, 62)
        Me.BTModificarEliminar.TabIndex = 6
        Me.BTModificarEliminar.Text = "Modificar/Eliminar"
        Me.BTModificarEliminar.UseVisualStyleBackColor = False
        '
        'FGcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 521)
        Me.Controls.Add(Me.PGcode)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.BTModificarEliminar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FGcode"
        Me.Text = "FGcode"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PGcode As Panel
    Friend WithEvents BTAfegir As Button
    Friend WithEvents BTModificarEliminar As Button
End Class
