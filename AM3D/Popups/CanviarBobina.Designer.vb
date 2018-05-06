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
        Me.LImpressora = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTCanviar = New System.Windows.Forms.Button()
        Me.CBBobina = New System.Windows.Forms.ComboBox()
        Me.LBobina = New System.Windows.Forms.Label()
        Me.MenuSup = New System.Windows.Forms.Panel()
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
        'LImpressora
        '
        Me.LImpressora.AutoSize = True
        Me.LImpressora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LImpressora.ForeColor = System.Drawing.Color.Black
        Me.LImpressora.Location = New System.Drawing.Point(52, 52)
        Me.LImpressora.Name = "LImpressora"
        Me.LImpressora.Size = New System.Drawing.Size(109, 25)
        Me.LImpressora.TabIndex = 22
        Me.LImpressora.Text = "Impressora"
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(216, 170)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(154, 62)
        Me.BTCancelar.TabIndex = 21
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
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
        'LBobina
        '
        Me.LBobina.AutoSize = True
        Me.LBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBobina.ForeColor = System.Drawing.Color.Black
        Me.LBobina.Location = New System.Drawing.Point(259, 52)
        Me.LBobina.Name = "LBobina"
        Me.LBobina.Size = New System.Drawing.Size(73, 25)
        Me.LBobina.TabIndex = 24
        Me.LBobina.Text = "Bobina"
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(-1, -2)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(404, 23)
        Me.MenuSup.TabIndex = 26
        '
        'CanviarBobina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(402, 282)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.CBBobina)
        Me.Controls.Add(Me.LBobina)
        Me.Controls.Add(Me.CBImpressora)
        Me.Controls.Add(Me.LImpressora)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTCanviar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CanviarBobina"
        Me.Text = "CanviarBobina"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBImpressora As ComboBox
    Friend WithEvents LImpressora As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTCanviar As Button
    Friend WithEvents CBBobina As ComboBox
    Friend WithEvents LBobina As Label
    Friend WithEvents MenuSup As Panel
End Class
