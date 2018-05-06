<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FImpressions
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
        Me.BTImprimirGCODE = New System.Windows.Forms.DataGridView()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTImpressionsPeçaRetirada = New System.Windows.Forms.Button()
        Me.BTImpressionsPausar = New System.Windows.Forms.Button()
        Me.BTImprimirG = New System.Windows.Forms.Button()
        CType(Me.BTImprimirGCODE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTImprimirGCODE
        '
        Me.BTImprimirGCODE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BTImprimirGCODE.Location = New System.Drawing.Point(12, 103)
        Me.BTImprimirGCODE.Name = "BTImprimirGCODE"
        Me.BTImprimirGCODE.Size = New System.Drawing.Size(802, 406)
        Me.BTImprimirGCODE.TabIndex = 0
        '
        'BTCancelar
        '
        Me.BTCancelar.BackColor = System.Drawing.Color.White
        Me.BTCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTCancelar.Location = New System.Drawing.Point(12, 23)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(154, 62)
        Me.BTCancelar.TabIndex = 10
        Me.BTCancelar.Text = "Cancelar"
        Me.BTCancelar.UseVisualStyleBackColor = False
        '
        'BTImpressionsPeçaRetirada
        '
        Me.BTImpressionsPeçaRetirada.BackColor = System.Drawing.Color.White
        Me.BTImpressionsPeçaRetirada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImpressionsPeçaRetirada.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImpressionsPeçaRetirada.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImpressionsPeçaRetirada.ForeColor = System.Drawing.Color.Black
        Me.BTImpressionsPeçaRetirada.Location = New System.Drawing.Point(225, 23)
        Me.BTImpressionsPeçaRetirada.Name = "BTImpressionsPeçaRetirada"
        Me.BTImpressionsPeçaRetirada.Size = New System.Drawing.Size(154, 62)
        Me.BTImpressionsPeçaRetirada.TabIndex = 11
        Me.BTImpressionsPeçaRetirada.Text = "Peça retirada"
        Me.BTImpressionsPeçaRetirada.UseVisualStyleBackColor = False
        '
        'BTImpressionsPausar
        '
        Me.BTImpressionsPausar.BackColor = System.Drawing.Color.White
        Me.BTImpressionsPausar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImpressionsPausar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImpressionsPausar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImpressionsPausar.ForeColor = System.Drawing.Color.Black
        Me.BTImpressionsPausar.Location = New System.Drawing.Point(446, 23)
        Me.BTImpressionsPausar.Name = "BTImpressionsPausar"
        Me.BTImpressionsPausar.Size = New System.Drawing.Size(154, 62)
        Me.BTImpressionsPausar.TabIndex = 12
        Me.BTImpressionsPausar.Text = "Pausar"
        Me.BTImpressionsPausar.UseVisualStyleBackColor = False
        '
        'BTImprimirG
        '
        Me.BTImprimirG.BackColor = System.Drawing.Color.White
        Me.BTImprimirG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImprimirG.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImprimirG.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImprimirG.ForeColor = System.Drawing.Color.Black
        Me.BTImprimirG.Location = New System.Drawing.Point(660, 23)
        Me.BTImprimirG.Name = "BTImprimirG"
        Me.BTImprimirG.Size = New System.Drawing.Size(154, 62)
        Me.BTImprimirG.TabIndex = 13
        Me.BTImprimirG.Text = "Imprimir GCODE"
        Me.BTImprimirG.UseVisualStyleBackColor = False
        '
        'FImpressions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 521)
        Me.Controls.Add(Me.BTImprimirG)
        Me.Controls.Add(Me.BTImpressionsPausar)
        Me.Controls.Add(Me.BTImpressionsPeçaRetirada)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTImprimirGCODE)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FImpressions"
        Me.Text = "FImpressions"
        CType(Me.BTImprimirGCODE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTImprimirGCODE As DataGridView
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTImpressionsPeçaRetirada As Button
    Friend WithEvents BTImpressionsPausar As Button
    Friend WithEvents BTImprimirG As Button
End Class
