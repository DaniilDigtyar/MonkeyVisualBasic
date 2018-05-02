<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImprimirGCODE
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
        Me.BTImprimirCancelar = New System.Windows.Forms.Button()
        Me.BTImprimir = New System.Windows.Forms.Button()
        Me.LNomGcode = New System.Windows.Forms.Label()
        Me.LImpressora = New System.Windows.Forms.Label()
        Me.LNCopies = New System.Windows.Forms.Label()
        Me.TBCopies = New System.Windows.Forms.TextBox()
        Me.CBGcode = New System.Windows.Forms.ComboBox()
        Me.CBImpriImpressora = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BTImprimirCancelar
        '
        Me.BTImprimirCancelar.BackColor = System.Drawing.Color.White
        Me.BTImprimirCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImprimirCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImprimirCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImprimirCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTImprimirCancelar.Location = New System.Drawing.Point(204, 220)
        Me.BTImprimirCancelar.Name = "BTImprimirCancelar"
        Me.BTImprimirCancelar.Size = New System.Drawing.Size(154, 62)
        Me.BTImprimirCancelar.TabIndex = 11
        Me.BTImprimirCancelar.Text = "Cancelar"
        Me.BTImprimirCancelar.UseVisualStyleBackColor = False
        '
        'BTImprimir
        '
        Me.BTImprimir.BackColor = System.Drawing.Color.White
        Me.BTImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImprimir.ForeColor = System.Drawing.Color.Black
        Me.BTImprimir.Location = New System.Drawing.Point(12, 220)
        Me.BTImprimir.Name = "BTImprimir"
        Me.BTImprimir.Size = New System.Drawing.Size(154, 62)
        Me.BTImprimir.TabIndex = 10
        Me.BTImprimir.Text = "Imprimir"
        Me.BTImprimir.UseVisualStyleBackColor = False
        '
        'LNomGcode
        '
        Me.LNomGcode.AutoSize = True
        Me.LNomGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNomGcode.ForeColor = System.Drawing.Color.Black
        Me.LNomGcode.Location = New System.Drawing.Point(38, 23)
        Me.LNomGcode.Name = "LNomGcode"
        Me.LNomGcode.Size = New System.Drawing.Size(116, 25)
        Me.LNomGcode.TabIndex = 12
        Me.LNomGcode.Text = "Nom Gcode"
        '
        'LImpressora
        '
        Me.LImpressora.AutoSize = True
        Me.LImpressora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LImpressora.ForeColor = System.Drawing.Color.Black
        Me.LImpressora.Location = New System.Drawing.Point(213, 23)
        Me.LImpressora.Name = "LImpressora"
        Me.LImpressora.Size = New System.Drawing.Size(109, 25)
        Me.LImpressora.TabIndex = 14
        Me.LImpressora.Text = "Impressora"
        '
        'LNCopies
        '
        Me.LNCopies.AutoSize = True
        Me.LNCopies.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNCopies.ForeColor = System.Drawing.Color.Black
        Me.LNCopies.Location = New System.Drawing.Point(38, 119)
        Me.LNCopies.Name = "LNCopies"
        Me.LNCopies.Size = New System.Drawing.Size(100, 25)
        Me.LNCopies.TabIndex = 16
        Me.LNCopies.Text = "Nº Copies"
        '
        'TBCopies
        '
        Me.TBCopies.Location = New System.Drawing.Point(33, 164)
        Me.TBCopies.Name = "TBCopies"
        Me.TBCopies.Size = New System.Drawing.Size(121, 20)
        Me.TBCopies.TabIndex = 17
        '
        'CBGcode
        '
        Me.CBGcode.FormattingEnabled = True
        Me.CBGcode.Location = New System.Drawing.Point(33, 64)
        Me.CBGcode.Name = "CBGcode"
        Me.CBGcode.Size = New System.Drawing.Size(121, 21)
        Me.CBGcode.TabIndex = 18
        '
        'CBImpriImpressora
        '
        Me.CBImpriImpressora.FormattingEnabled = True
        Me.CBImpriImpressora.Location = New System.Drawing.Point(204, 64)
        Me.CBImpriImpressora.Name = "CBImpriImpressora"
        Me.CBImpriImpressora.Size = New System.Drawing.Size(121, 21)
        Me.CBImpriImpressora.TabIndex = 19
        '
        'ImprimirGCODE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(370, 320)
        Me.Controls.Add(Me.CBImpriImpressora)
        Me.Controls.Add(Me.CBGcode)
        Me.Controls.Add(Me.TBCopies)
        Me.Controls.Add(Me.LNCopies)
        Me.Controls.Add(Me.LImpressora)
        Me.Controls.Add(Me.LNomGcode)
        Me.Controls.Add(Me.BTImprimirCancelar)
        Me.Controls.Add(Me.BTImprimir)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImprimirGCODE"
        Me.Text = "ImprimirGCODE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTImprimirCancelar As Button
    Friend WithEvents BTImprimir As Button
    Friend WithEvents LNomGcode As Label
    Friend WithEvents LImpressora As Label
    Friend WithEvents LNCopies As Label
    Friend WithEvents TBCopies As TextBox
    Friend WithEvents CBGcode As ComboBox
    Friend WithEvents CBImpriImpressora As ComboBox
End Class
