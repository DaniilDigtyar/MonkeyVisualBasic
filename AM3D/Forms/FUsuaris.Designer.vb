<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FUsuaris
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BTAfegir = New System.Windows.Forms.Button()
        Me.BTModificarEliminar = New System.Windows.Forms.Button()
        Me.PUsuaris = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BTAfegir
        '
        Me.BTAfegir.BackColor = System.Drawing.Color.White
        Me.BTAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTAfegir.Location = New System.Drawing.Point(82, 33)
        Me.BTAfegir.Name = "BTAfegir"
        Me.BTAfegir.Size = New System.Drawing.Size(190, 62)
        Me.BTAfegir.TabIndex = 4
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
        Me.BTModificarEliminar.Location = New System.Drawing.Point(569, 33)
        Me.BTModificarEliminar.Name = "BTModificarEliminar"
        Me.BTModificarEliminar.Size = New System.Drawing.Size(190, 62)
        Me.BTModificarEliminar.TabIndex = 3
        Me.BTModificarEliminar.Text = "Modificar/Eliminar"
        Me.BTModificarEliminar.UseVisualStyleBackColor = False
        '
        'PUsuaris
        '
        Me.PUsuaris.Location = New System.Drawing.Point(21, 119)
        Me.PUsuaris.Name = "PUsuaris"
        Me.PUsuaris.Size = New System.Drawing.Size(780, 380)
        Me.PUsuaris.TabIndex = 5
        '
        'FUsuaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 521)
        Me.Controls.Add(Me.PUsuaris)
        Me.Controls.Add(Me.BTAfegir)
        Me.Controls.Add(Me.BTModificarEliminar)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FUsuaris"
        Me.Text = "FUsuaris"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTAfegir As Button
    Friend WithEvents BTModificarEliminar As Button
    Friend WithEvents PUsuaris As Panel
End Class
