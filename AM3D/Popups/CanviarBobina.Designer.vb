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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CanviarBobina))
        Me.CBImpressora = New System.Windows.Forms.ComboBox()
        Me.LImpressora = New System.Windows.Forms.Label()
        Me.BTCancelar = New System.Windows.Forms.Button()
        Me.BTCanviar = New System.Windows.Forms.Button()
        Me.LBobina = New System.Windows.Forms.Label()
        Me.MenuSup = New System.Windows.Forms.Panel()
        Me.DataGridViewBobina = New System.Windows.Forms.DataGridView()
        Me.codi_bobina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bobina = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.color = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marca_productora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Diametre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewBobina, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CBImpressora
        '
        Me.CBImpressora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBImpressora.FormattingEnabled = True
        Me.CBImpressora.Location = New System.Drawing.Point(24, 55)
        Me.CBImpressora.Name = "CBImpressora"
        Me.CBImpressora.Size = New System.Drawing.Size(154, 21)
        Me.CBImpressora.TabIndex = 1
        '
        'LImpressora
        '
        Me.LImpressora.AutoSize = True
        Me.LImpressora.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LImpressora.ForeColor = System.Drawing.Color.Black
        Me.LImpressora.Location = New System.Drawing.Point(19, 27)
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
        Me.BTCancelar.Location = New System.Drawing.Point(24, 315)
        Me.BTCancelar.Name = "BTCancelar"
        Me.BTCancelar.Size = New System.Drawing.Size(154, 62)
        Me.BTCancelar.TabIndex = 4
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
        Me.BTCanviar.Location = New System.Drawing.Point(24, 232)
        Me.BTCanviar.Name = "BTCanviar"
        Me.BTCanviar.Size = New System.Drawing.Size(154, 62)
        Me.BTCanviar.TabIndex = 3
        Me.BTCanviar.Text = "Canviar"
        Me.BTCanviar.UseVisualStyleBackColor = False
        '
        'LBobina
        '
        Me.LBobina.AutoSize = True
        Me.LBobina.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBobina.ForeColor = System.Drawing.Color.Black
        Me.LBobina.Location = New System.Drawing.Point(179, 27)
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
        Me.MenuSup.Size = New System.Drawing.Size(522, 23)
        Me.MenuSup.TabIndex = 26
        '
        'DataGridViewBobina
        '
        Me.DataGridViewBobina.AllowUserToAddRows = False
        Me.DataGridViewBobina.AllowUserToDeleteRows = False
        Me.DataGridViewBobina.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewBobina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBobina.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codi_bobina, Me.Bobina, Me.color, Me.marca_productora, Me.Diametre})
        Me.DataGridViewBobina.Location = New System.Drawing.Point(184, 55)
        Me.DataGridViewBobina.MultiSelect = False
        Me.DataGridViewBobina.Name = "DataGridViewBobina"
        Me.DataGridViewBobina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewBobina.Size = New System.Drawing.Size(323, 322)
        Me.DataGridViewBobina.TabIndex = 2
        '
        'codi_bobina
        '
        Me.codi_bobina.HeaderText = "Codi Bobina"
        Me.codi_bobina.Name = "codi_bobina"
        Me.codi_bobina.ReadOnly = True
        Me.codi_bobina.Visible = False
        '
        'Bobina
        '
        Me.Bobina.HeaderText = "Bobina"
        Me.Bobina.Name = "Bobina"
        Me.Bobina.ReadOnly = True
        '
        'color
        '
        Me.color.HeaderText = "Color"
        Me.color.Name = "color"
        Me.color.ReadOnly = True
        '
        'marca_productora
        '
        Me.marca_productora.HeaderText = "Marca"
        Me.marca_productora.Name = "marca_productora"
        Me.marca_productora.ReadOnly = True
        '
        'Diametre
        '
        Me.Diametre.HeaderText = "Diametre"
        Me.Diametre.Name = "Diametre"
        Me.Diametre.ReadOnly = True
        '
        'CanviarBobina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(521, 397)
        Me.Controls.Add(Me.DataGridViewBobina)
        Me.Controls.Add(Me.MenuSup)
        Me.Controls.Add(Me.LBobina)
        Me.Controls.Add(Me.CBImpressora)
        Me.Controls.Add(Me.LImpressora)
        Me.Controls.Add(Me.BTCancelar)
        Me.Controls.Add(Me.BTCanviar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CanviarBobina"
        Me.Text = "CanviarBobina"
        CType(Me.DataGridViewBobina, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CBImpressora As ComboBox
    Friend WithEvents LImpressora As Label
    Friend WithEvents BTCancelar As Button
    Friend WithEvents BTCanviar As Button
    Friend WithEvents LBobina As Label
    Friend WithEvents MenuSup As Panel
    Friend WithEvents DataGridViewBobina As DataGridView
    Friend WithEvents codi_bobina As DataGridViewTextBoxColumn
    Friend WithEvents Bobina As DataGridViewTextBoxColumn
    Friend WithEvents color As DataGridViewTextBoxColumn
    Friend WithEvents marca_productora As DataGridViewTextBoxColumn
    Friend WithEvents Diametre As DataGridViewTextBoxColumn
End Class
