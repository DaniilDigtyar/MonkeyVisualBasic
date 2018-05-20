<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FBobines
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
        Me.PBobines = New System.Windows.Forms.Panel()
        Me.LBobina = New System.Windows.Forms.Label()
        Me.BTBobinaModif = New System.Windows.Forms.Button()
        Me.BTBobinaAfegir = New System.Windows.Forms.Button()
        Me.LColor = New System.Windows.Forms.Label()
        Me.BTColorModif = New System.Windows.Forms.Button()
        Me.BTColorAfegir = New System.Windows.Forms.Button()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.BTMarcaModif = New System.Windows.Forms.Button()
        Me.BTMarcaAfegir = New System.Windows.Forms.Button()
        Me.LMaterial = New System.Windows.Forms.Label()
        Me.BTMaterialModif = New System.Windows.Forms.Button()
        Me.BTMaterialAfegir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PBobines
        '
        Me.PBobines.Location = New System.Drawing.Point(13, 134)
        Me.PBobines.Name = "PBobines"
        Me.PBobines.Size = New System.Drawing.Size(801, 376)
        Me.PBobines.TabIndex = 24
        '
        'LBobina
        '
        Me.LBobina.AutoSize = True
        Me.LBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBobina.ForeColor = System.Drawing.Color.Black
        Me.LBobina.Location = New System.Drawing.Point(57, 9)
        Me.LBobina.Name = "LBobina"
        Me.LBobina.Size = New System.Drawing.Size(73, 25)
        Me.LBobina.TabIndex = 22
        Me.LBobina.Text = "Bobina"
        '
        'BTBobinaModif
        '
        Me.BTBobinaModif.BackColor = System.Drawing.Color.White
        Me.BTBobinaModif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBobinaModif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBobinaModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBobinaModif.ForeColor = System.Drawing.Color.Black
        Me.BTBobinaModif.Location = New System.Drawing.Point(13, 86)
        Me.BTBobinaModif.Name = "BTBobinaModif"
        Me.BTBobinaModif.Size = New System.Drawing.Size(169, 38)
        Me.BTBobinaModif.TabIndex = 2
        Me.BTBobinaModif.Text = "Modificar/Eliminar"
        Me.BTBobinaModif.UseVisualStyleBackColor = False
        '
        'BTBobinaAfegir
        '
        Me.BTBobinaAfegir.BackColor = System.Drawing.Color.White
        Me.BTBobinaAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTBobinaAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTBobinaAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBobinaAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTBobinaAfegir.Location = New System.Drawing.Point(47, 40)
        Me.BTBobinaAfegir.Name = "BTBobinaAfegir"
        Me.BTBobinaAfegir.Size = New System.Drawing.Size(92, 38)
        Me.BTBobinaAfegir.TabIndex = 1
        Me.BTBobinaAfegir.Text = "Afegir"
        Me.BTBobinaAfegir.UseVisualStyleBackColor = False
        '
        'LColor
        '
        Me.LColor.AutoSize = True
        Me.LColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LColor.ForeColor = System.Drawing.Color.Black
        Me.LColor.Location = New System.Drawing.Point(272, 9)
        Me.LColor.Name = "LColor"
        Me.LColor.Size = New System.Drawing.Size(59, 25)
        Me.LColor.TabIndex = 27
        Me.LColor.Text = "Color"
        '
        'BTColorModif
        '
        Me.BTColorModif.BackColor = System.Drawing.Color.White
        Me.BTColorModif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTColorModif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTColorModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTColorModif.ForeColor = System.Drawing.Color.Black
        Me.BTColorModif.Location = New System.Drawing.Point(221, 86)
        Me.BTColorModif.Name = "BTColorModif"
        Me.BTColorModif.Size = New System.Drawing.Size(169, 38)
        Me.BTColorModif.TabIndex = 4
        Me.BTColorModif.Text = "Modificar/Eliminar"
        Me.BTColorModif.UseVisualStyleBackColor = False
        '
        'BTColorAfegir
        '
        Me.BTColorAfegir.BackColor = System.Drawing.Color.White
        Me.BTColorAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTColorAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTColorAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTColorAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTColorAfegir.Location = New System.Drawing.Point(255, 40)
        Me.BTColorAfegir.Name = "BTColorAfegir"
        Me.BTColorAfegir.Size = New System.Drawing.Size(92, 38)
        Me.BTColorAfegir.TabIndex = 3
        Me.BTColorAfegir.Text = "Afegir"
        Me.BTColorAfegir.UseVisualStyleBackColor = False
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Black
        Me.LMarca.Location = New System.Drawing.Point(485, 9)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(67, 25)
        Me.LMarca.TabIndex = 30
        Me.LMarca.Text = "Marca"
        '
        'BTMarcaModif
        '
        Me.BTMarcaModif.BackColor = System.Drawing.Color.White
        Me.BTMarcaModif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTMarcaModif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTMarcaModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTMarcaModif.ForeColor = System.Drawing.Color.Black
        Me.BTMarcaModif.Location = New System.Drawing.Point(437, 86)
        Me.BTMarcaModif.Name = "BTMarcaModif"
        Me.BTMarcaModif.Size = New System.Drawing.Size(169, 38)
        Me.BTMarcaModif.TabIndex = 6
        Me.BTMarcaModif.Text = "Modificar/Eliminar"
        Me.BTMarcaModif.UseVisualStyleBackColor = False
        '
        'BTMarcaAfegir
        '
        Me.BTMarcaAfegir.BackColor = System.Drawing.Color.White
        Me.BTMarcaAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTMarcaAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTMarcaAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTMarcaAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTMarcaAfegir.Location = New System.Drawing.Point(471, 40)
        Me.BTMarcaAfegir.Name = "BTMarcaAfegir"
        Me.BTMarcaAfegir.Size = New System.Drawing.Size(92, 38)
        Me.BTMarcaAfegir.TabIndex = 5
        Me.BTMarcaAfegir.Text = "Afegir"
        Me.BTMarcaAfegir.UseVisualStyleBackColor = False
        '
        'LMaterial
        '
        Me.LMaterial.AutoSize = True
        Me.LMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMaterial.ForeColor = System.Drawing.Color.Black
        Me.LMaterial.Location = New System.Drawing.Point(687, 9)
        Me.LMaterial.Name = "LMaterial"
        Me.LMaterial.Size = New System.Drawing.Size(81, 25)
        Me.LMaterial.TabIndex = 33
        Me.LMaterial.Text = "Material"
        '
        'BTMaterialModif
        '
        Me.BTMaterialModif.BackColor = System.Drawing.Color.White
        Me.BTMaterialModif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTMaterialModif.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTMaterialModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTMaterialModif.ForeColor = System.Drawing.Color.Black
        Me.BTMaterialModif.Location = New System.Drawing.Point(645, 86)
        Me.BTMaterialModif.Name = "BTMaterialModif"
        Me.BTMaterialModif.Size = New System.Drawing.Size(169, 38)
        Me.BTMaterialModif.TabIndex = 8
        Me.BTMaterialModif.Text = "Modificar/Eliminar"
        Me.BTMaterialModif.UseVisualStyleBackColor = False
        '
        'BTMaterialAfegir
        '
        Me.BTMaterialAfegir.BackColor = System.Drawing.Color.White
        Me.BTMaterialAfegir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTMaterialAfegir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTMaterialAfegir.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTMaterialAfegir.ForeColor = System.Drawing.Color.Black
        Me.BTMaterialAfegir.Location = New System.Drawing.Point(679, 40)
        Me.BTMaterialAfegir.Name = "BTMaterialAfegir"
        Me.BTMaterialAfegir.Size = New System.Drawing.Size(92, 38)
        Me.BTMaterialAfegir.TabIndex = 7
        Me.BTMaterialAfegir.Text = "Afegir"
        Me.BTMaterialAfegir.UseVisualStyleBackColor = False
        '
        'FBobines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(826, 521)
        Me.Controls.Add(Me.LMaterial)
        Me.Controls.Add(Me.BTMaterialModif)
        Me.Controls.Add(Me.BTMaterialAfegir)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.BTMarcaModif)
        Me.Controls.Add(Me.BTMarcaAfegir)
        Me.Controls.Add(Me.LColor)
        Me.Controls.Add(Me.BTColorModif)
        Me.Controls.Add(Me.BTColorAfegir)
        Me.Controls.Add(Me.PBobines)
        Me.Controls.Add(Me.LBobina)
        Me.Controls.Add(Me.BTBobinaModif)
        Me.Controls.Add(Me.BTBobinaAfegir)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FBobines"
        Me.Text = "FBobines"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PBobines As Panel
    Friend WithEvents LBobina As Label
    Friend WithEvents BTBobinaModif As Button
    Friend WithEvents BTBobinaAfegir As Button
    Friend WithEvents LColor As Label
    Friend WithEvents BTColorModif As Button
    Friend WithEvents BTColorAfegir As Button
    Friend WithEvents LMarca As Label
    Friend WithEvents BTMarcaModif As Button
    Friend WithEvents BTMarcaAfegir As Button
    Friend WithEvents LMaterial As Label
    Friend WithEvents BTMaterialModif As Button
    Friend WithEvents BTMaterialAfegir As Button
End Class
