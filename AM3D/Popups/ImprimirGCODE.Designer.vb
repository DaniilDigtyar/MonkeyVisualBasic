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
        Me.CBGcode = New System.Windows.Forms.ComboBox()
        Me.CBImpriImpressora = New System.Windows.Forms.ComboBox()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.TBCopies = New System.Windows.Forms.NumericUpDown()
        CType(Me.TBCopies, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LNomGcode.Location = New System.Drawing.Point(22, 32)
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
        Me.LImpressora.Location = New System.Drawing.Point(236, 32)
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
        Me.LNCopies.Location = New System.Drawing.Point(25, 119)
        Me.LNCopies.Name = "LNCopies"
        Me.LNCopies.Size = New System.Drawing.Size(100, 25)
        Me.LNCopies.TabIndex = 16
        Me.LNCopies.Text = "Nº Copies"
        '
        'CBGcode
        '
        Me.CBGcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBGcode.FormattingEnabled = True
        Me.CBGcode.Location = New System.Drawing.Point(27, 68)
        Me.CBGcode.Name = "CBGcode"
        Me.CBGcode.Size = New System.Drawing.Size(121, 21)
        Me.CBGcode.TabIndex = 18
        '
        'CBImpriImpressora
        '
        Me.CBImpriImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBImpriImpressora.FormattingEnabled = True
        Me.CBImpriImpressora.Location = New System.Drawing.Point(227, 68)
        Me.CBImpriImpressora.Name = "CBImpriImpressora"
        Me.CBImpriImpressora.Size = New System.Drawing.Size(121, 21)
        Me.CBImpriImpressora.TabIndex = 19
        '
        'MenuSup
        '
        Me.MenuSup.BackColor = System.Drawing.Color.Black
        Me.MenuSup.Location = New System.Drawing.Point(-1, 0)
        Me.MenuSup.Name = "MenuSup"
        Me.MenuSup.Size = New System.Drawing.Size(372, 19)
        Me.MenuSup.TabIndex = 20
        '
        'TBCopies
        '
        Me.TBCopies.Location = New System.Drawing.Point(27, 159)
        Me.TBCopies.Name = "TBCopies"
        Me.TBCopies.Size = New System.Drawing.Size(120, 20)
        Me.TBCopies.TabIndex = 21
        '
        'ImprimirGCODE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(370, 320)
        Me.Controls.Add(Me.TBCopies)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.CBImpriImpressora)
        Me.Controls.Add(Me.CBGcode)
        Me.Controls.Add(Me.LNCopies)
        Me.Controls.Add(Me.LImpressora)
        Me.Controls.Add(Me.LNomGcode)
        Me.Controls.Add(Me.BTImprimirCancelar)
        Me.Controls.Add(Me.BTImprimir)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ImprimirGCODE"
        Me.Text = "ImprimirGCODE"
        CType(Me.TBCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTImprimirCancelar As Button
    Friend WithEvents BTImprimir As Button
    Friend WithEvents LNomGcode As Label
    Friend WithEvents LImpressora As Label
    Friend WithEvents LNCopies As Label
    Friend WithEvents CBGcode As ComboBox
    Friend WithEvents CBImpriImpressora As ComboBox
    Friend WithEvents MenuSup As Panel
    Friend WithEvents TBCopies As NumericUpDown
End Class
