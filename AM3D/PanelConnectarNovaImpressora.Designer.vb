<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelConnectarNovaImpressora
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LVBobines = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.CBModel = New System.Windows.Forms.ComboBox()
        Me.TBNomImpressora = New System.Windows.Forms.TextBox()
        Me.BTImpressoraGuardar = New System.Windows.Forms.Button()
        Me.BTImpressoraCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(53, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nom"
        '
        'LVBobines
        '
        Me.LVBobines.Location = New System.Drawing.Point(496, 12)
        Me.LVBobines.Name = "LVBobines"
        Me.LVBobines.Size = New System.Drawing.Size(294, 350)
        Me.LVBobines.TabIndex = 3
        Me.LVBobines.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(404, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Bobina"
        '
        'CBMarca
        '
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Location = New System.Drawing.Point(163, 46)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(169, 21)
        Me.CBMarca.TabIndex = 5
        '
        'CBModel
        '
        Me.CBModel.FormattingEnabled = True
        Me.CBModel.Location = New System.Drawing.Point(163, 120)
        Me.CBModel.Name = "CBModel"
        Me.CBModel.Size = New System.Drawing.Size(169, 21)
        Me.CBModel.TabIndex = 6
        '
        'TBNomImpressora
        '
        Me.TBNomImpressora.Location = New System.Drawing.Point(163, 187)
        Me.TBNomImpressora.Name = "TBNomImpressora"
        Me.TBNomImpressora.Size = New System.Drawing.Size(169, 20)
        Me.TBNomImpressora.TabIndex = 7
        '
        'BTImpressoraGuardar
        '
        Me.BTImpressoraGuardar.BackColor = System.Drawing.Color.White
        Me.BTImpressoraGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImpressoraGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImpressoraGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImpressoraGuardar.ForeColor = System.Drawing.Color.Black
        Me.BTImpressoraGuardar.Location = New System.Drawing.Point(58, 264)
        Me.BTImpressoraGuardar.Name = "BTImpressoraGuardar"
        Me.BTImpressoraGuardar.Size = New System.Drawing.Size(154, 62)
        Me.BTImpressoraGuardar.TabIndex = 8
        Me.BTImpressoraGuardar.Text = "Guardar"
        Me.BTImpressoraGuardar.UseVisualStyleBackColor = False
        '
        'BTImpressoraCancelar
        '
        Me.BTImpressoraCancelar.BackColor = System.Drawing.Color.White
        Me.BTImpressoraCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTImpressoraCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTImpressoraCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTImpressoraCancelar.ForeColor = System.Drawing.Color.Black
        Me.BTImpressoraCancelar.Location = New System.Drawing.Point(297, 264)
        Me.BTImpressoraCancelar.Name = "BTImpressoraCancelar"
        Me.BTImpressoraCancelar.Size = New System.Drawing.Size(154, 62)
        Me.BTImpressoraCancelar.TabIndex = 9
        Me.BTImpressoraCancelar.Text = "Cancelar"
        Me.BTImpressoraCancelar.UseVisualStyleBackColor = False
        '
        'PanelConnectarNovaImpressora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(802, 374)
        Me.Controls.Add(Me.BTImpressoraCancelar)
        Me.Controls.Add(Me.BTImpressoraGuardar)
        Me.Controls.Add(Me.TBNomImpressora)
        Me.Controls.Add(Me.CBModel)
        Me.Controls.Add(Me.CBMarca)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LVBobines)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelConnectarNovaImpressora"
        Me.Text = "PanelConnectarNovaImpressora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LVBobines As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents CBMarca As ComboBox
    Friend WithEvents CBModel As ComboBox
    Friend WithEvents TBNomImpressora As TextBox
    Friend WithEvents BTImpressoraGuardar As Button
    Friend WithEvents BTImpressoraCancelar As Button
End Class
