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
        Me.BTConnectar = New System.Windows.Forms.Button()
        Me.BTLlista = New System.Windows.Forms.Button()
        Me.PUsuaris = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BTConnectar
        '
        Me.BTConnectar.BackColor = System.Drawing.Color.White
        Me.BTConnectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTConnectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTConnectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTConnectar.ForeColor = System.Drawing.Color.Black
        Me.BTConnectar.Location = New System.Drawing.Point(82, 33)
        Me.BTConnectar.Name = "BTConnectar"
        Me.BTConnectar.Size = New System.Drawing.Size(190, 62)
        Me.BTConnectar.TabIndex = 4
        Me.BTConnectar.Text = "Afegir"
        Me.BTConnectar.UseVisualStyleBackColor = False
        '
        'BTLlista
        '
        Me.BTLlista.BackColor = System.Drawing.Color.White
        Me.BTLlista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTLlista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTLlista.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTLlista.ForeColor = System.Drawing.Color.Black
        Me.BTLlista.Location = New System.Drawing.Point(569, 33)
        Me.BTLlista.Name = "BTLlista"
        Me.BTLlista.Size = New System.Drawing.Size(190, 62)
        Me.BTLlista.TabIndex = 3
        Me.BTLlista.Text = "Modificar/Eliminar"
        Me.BTLlista.UseVisualStyleBackColor = False
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
        Me.Controls.Add(Me.BTConnectar)
        Me.Controls.Add(Me.BTLlista)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FUsuaris"
        Me.Text = "FUsuaris"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTConnectar As Button
    Friend WithEvents BTLlista As Button
    Friend WithEvents PUsuaris As Panel
End Class
