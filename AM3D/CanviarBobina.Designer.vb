<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CanviarBobina
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
        Me.CBImpressora = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTCanviarCancelar = New System.Windows.Forms.Button()
        Me.BTCanviar = New System.Windows.Forms.Button()
        Me.CBBobina = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CBImpressora
        '
        Me.CBImpressora.FormattingEnabled = True
        Me.CBImpressora.Location = New System.Drawing.Point(40, 93)
        Me.CBImpressora.Name = "CBImpressora"
        Me.CBImpressora.Size = New System.Drawing.Size(121, 21)
        Me.CBImpressora.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(52, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Impressora"
        '
        'BTCanviarCancelar
        '
        Me.BTCanviarCancelar.BackColor = System.Drawing.Color.White
        Me.BTCanviarCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCanviarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCanviarCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCanviarCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCanviarCancelar.Location = New System.Drawing.Point(216, 170)
        Me.BTCanviarCancelar.Name = "BTCanviarCancelar"
        Me.BTCanviarCancelar.Size = New System.Drawing.Size(154, 62)
        Me.BTCanviarCancelar.TabIndex = 21
        Me.BTCanviarCancelar.Text = "Cancelar"
        Me.BTCanviarCancelar.UseVisualStyleBackColor = False
        '
        'BTCanviar
        '
        Me.BTCanviar.BackColor = System.Drawing.Color.White
        Me.BTCanviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCanviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCanviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCanviar.ForeColor = System.Drawing.Color.Black
        Me.BTCanviar.Location = New System.Drawing.Point(24, 170)
        Me.BTCanviar.Name = "BTCanviar"
        Me.BTCanviar.Size = New System.Drawing.Size(154, 62)
        Me.BTCanviar.TabIndex = 20
        Me.BTCanviar.Text = "Canviar"
        Me.BTCanviar.UseVisualStyleBackColor = False
        '
        'CBBobina
        '
        Me.CBBobina.FormattingEnabled = True
        Me.CBBobina.Location = New System.Drawing.Point(236, 93)
        Me.CBBobina.Name = "CBBobina"
        Me.CBBobina.Size = New System.Drawing.Size(121, 21)
        Me.CBBobina.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(259, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Bobina"
        '
        'CanviarBobina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(402, 282)
        Me.Controls.Add(Me.CBBobina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CBImpressora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTCanviarCancelar)
        Me.Controls.Add(Me.BTCanviar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CanviarBobina"
        Me.Text = "CanviarBobina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBImpressora As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTCanviarCancelar As Button
    Friend WithEvents BTCanviar As Button
    Friend WithEvents CBBobina As ComboBox
    Friend WithEvents Label1 As Label
End Class
