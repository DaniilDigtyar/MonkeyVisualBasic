<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelModificarEliminarUsuaris
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
        Me.BTEliminarUsuari = New System.Windows.Forms.Button()
        Me.BTModificarUsuari = New System.Windows.Forms.Button()
        Me.DGUsuaris = New System.Windows.Forms.DataGridView()
        Me.Nickname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cognoms = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BResfrescar = New System.Windows.Forms.Button()
        CType(Me.DGUsuaris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTEliminarUsuari
        '
        Me.BTEliminarUsuari.BackColor = System.Drawing.Color.White
        Me.BTEliminarUsuari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEliminarUsuari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEliminarUsuari.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEliminarUsuari.ForeColor = System.Drawing.Color.Black
        Me.BTEliminarUsuari.Location = New System.Drawing.Point(181, 12)
        Me.BTEliminarUsuari.Name = "BTEliminarUsuari"
        Me.BTEliminarUsuari.Size = New System.Drawing.Size(154, 62)
        Me.BTEliminarUsuari.TabIndex = 6
        Me.BTEliminarUsuari.Text = "Eliminar Usuari"
        Me.BTEliminarUsuari.UseVisualStyleBackColor = False
        '
        'BTModificarUsuari
        '
        Me.BTModificarUsuari.BackColor = System.Drawing.Color.White
        Me.BTModificarUsuari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTModificarUsuari.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTModificarUsuari.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTModificarUsuari.ForeColor = System.Drawing.Color.Black
        Me.BTModificarUsuari.Location = New System.Drawing.Point(21, 12)
        Me.BTModificarUsuari.Name = "BTModificarUsuari"
        Me.BTModificarUsuari.Size = New System.Drawing.Size(154, 62)
        Me.BTModificarUsuari.TabIndex = 5
        Me.BTModificarUsuari.Text = "Modificar Usuari"
        Me.BTModificarUsuari.UseVisualStyleBackColor = False
        '
        'DGUsuaris
        '
        Me.DGUsuaris.AllowUserToAddRows = False
        Me.DGUsuaris.AllowUserToDeleteRows = False
        Me.DGUsuaris.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGUsuaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUsuaris.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nickname, Me.DNI, Me.Nom, Me.Cognoms, Me.Email})
        Me.DGUsuaris.Location = New System.Drawing.Point(21, 89)
        Me.DGUsuaris.Name = "DGUsuaris"
        Me.DGUsuaris.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGUsuaris.Size = New System.Drawing.Size(739, 268)
        Me.DGUsuaris.TabIndex = 29
        '
        'Nickname
        '
        Me.Nickname.HeaderText = "Nickname"
        Me.Nickname.Name = "Nickname"
        Me.Nickname.ReadOnly = True
        '
        'DNI
        '
        Me.DNI.HeaderText = "DNI"
        Me.DNI.Name = "DNI"
        Me.DNI.ReadOnly = True
        '
        'Nom
        '
        Me.Nom.HeaderText = "Nom"
        Me.Nom.Name = "Nom"
        Me.Nom.ReadOnly = True
        '
        'Cognoms
        '
        Me.Cognoms.HeaderText = "Cognoms"
        Me.Cognoms.Name = "Cognoms"
        Me.Cognoms.ReadOnly = True
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        '
        'BResfrescar
        '
        Me.BResfrescar.BackColor = System.Drawing.Color.White
        Me.BResfrescar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BResfrescar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BResfrescar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BResfrescar.ForeColor = System.Drawing.Color.Black
        Me.BResfrescar.Location = New System.Drawing.Point(606, 12)
        Me.BResfrescar.Name = "BResfrescar"
        Me.BResfrescar.Size = New System.Drawing.Size(154, 62)
        Me.BResfrescar.TabIndex = 30
        Me.BResfrescar.Text = "Refresca llista"
        Me.BResfrescar.UseVisualStyleBackColor = False
        '
        'PanelModificarEliminarUsuaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 380)
        Me.Controls.Add(Me.BResfrescar)
        Me.Controls.Add(Me.DGUsuaris)
        Me.Controls.Add(Me.BTEliminarUsuari)
        Me.Controls.Add(Me.BTModificarUsuari)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelModificarEliminarUsuaris"
        Me.Text = "PanelModificarEliminarUsuaris"
        CType(Me.DGUsuaris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BTEliminarUsuari As Button
    Friend WithEvents BTModificarUsuari As Button
    Friend WithEvents DGUsuaris As DataGridView
    Friend WithEvents Nickname As DataGridViewTextBoxColumn
    Friend WithEvents DNI As DataGridViewTextBoxColumn
    Friend WithEvents Nom As DataGridViewTextBoxColumn
    Friend WithEvents Cognoms As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents BResfrescar As Button
End Class
