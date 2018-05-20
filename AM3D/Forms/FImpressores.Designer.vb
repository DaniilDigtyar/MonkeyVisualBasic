<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FImpressores
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
        Me.BTLlista = New System.Windows.Forms.Button()
        Me.BTConnectar = New System.Windows.Forms.Button()
        Me.PImpressores = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'BTLlista
        '
        Me.BTLlista.BackColor = System.Drawing.Color.White
        Me.BTLlista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTLlista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTLlista.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTLlista.ForeColor = System.Drawing.Color.Black
        Me.BTLlista.Location = New System.Drawing.Point(614, 39)
        Me.BTLlista.Name = "BTLlista"
        Me.BTLlista.Size = New System.Drawing.Size(154, 62)
        Me.BTLlista.TabIndex = 2
        Me.BTLlista.Text = "Llista d'impressores"
        Me.BTLlista.UseVisualStyleBackColor = False
        '
        'BTConnectar
        '
        Me.BTConnectar.BackColor = System.Drawing.Color.White
        Me.BTConnectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTConnectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTConnectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTConnectar.ForeColor = System.Drawing.Color.Black
        Me.BTConnectar.Location = New System.Drawing.Point(70, 39)
        Me.BTConnectar.Name = "BTConnectar"
        Me.BTConnectar.Size = New System.Drawing.Size(154, 62)
        Me.BTConnectar.TabIndex = 1
        Me.BTConnectar.Text = "Connectar nova impressora"
        Me.BTConnectar.UseVisualStyleBackColor = False
        '
        'PImpressores
        '
        Me.PImpressores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PImpressores.Cursor = System.Windows.Forms.Cursors.Default
        Me.PImpressores.Location = New System.Drawing.Point(12, 135)
        Me.PImpressores.Name = "PImpressores"
        Me.PImpressores.Size = New System.Drawing.Size(802, 374)
        Me.PImpressores.TabIndex = 3
        '
        'FImpressores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 521)
        Me.Controls.Add(Me.PImpressores)
        Me.Controls.Add(Me.BTConnectar)
        Me.Controls.Add(Me.BTLlista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FImpressores"
        Me.Text = "FImpressores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTLlista As Button
    Friend WithEvents BTConnectar As Button
    Friend WithEvents PImpressores As Panel
End Class
