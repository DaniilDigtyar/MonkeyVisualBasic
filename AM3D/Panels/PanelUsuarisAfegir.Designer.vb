<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelUsuarisAfegir
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
        Me.LNomUsuari = New System.Windows.Forms.Label()
        Me.LNom = New System.Windows.Forms.Label()
        Me.LCognom = New System.Windows.Forms.Label()
        Me.LContrasenya = New System.Windows.Forms.Label()
        Me.LRContrasenya = New System.Windows.Forms.Label()
        Me.TBNickname = New System.Windows.Forms.TextBox()
        Me.TBNom = New System.Windows.Forms.TextBox()
        Me.TBCongnom = New System.Windows.Forms.TextBox()
        Me.TBContrasenya = New System.Windows.Forms.TextBox()
        Me.TBRContrasenya = New System.Windows.Forms.TextBox()
        Me.LPermisos = New System.Windows.Forms.Label()
        Me.BTEsborrar = New System.Windows.Forms.Button()
        Me.BTCrear = New System.Windows.Forms.Button()
        Me.TBCorreu = New System.Windows.Forms.TextBox()
        Me.LCorreu = New System.Windows.Forms.Label()
        Me.DataGridViewPermisos = New System.Windows.Forms.DataGridView()
        Me.codi_permis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewPermisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNomUsuari
        '
        Me.LNomUsuari.AutoSize = True
        Me.LNomUsuari.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNomUsuari.ForeColor = System.Drawing.Color.Black
        Me.LNomUsuari.Location = New System.Drawing.Point(12, 54)
        Me.LNomUsuari.Name = "LNomUsuari"
        Me.LNomUsuari.Size = New System.Drawing.Size(139, 25)
        Me.LNomUsuari.TabIndex = 1
        Me.LNomUsuari.Text = "Nom d'usuari *"
        '
        'LNom
        '
        Me.LNom.AutoSize = True
        Me.LNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNom.ForeColor = System.Drawing.Color.Black
        Me.LNom.Location = New System.Drawing.Point(12, 98)
        Me.LNom.Name = "LNom"
        Me.LNom.Size = New System.Drawing.Size(53, 25)
        Me.LNom.TabIndex = 2
        Me.LNom.Text = "Nom"
        '
        'LCognom
        '
        Me.LCognom.AutoSize = True
        Me.LCognom.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCognom.ForeColor = System.Drawing.Color.Black
        Me.LCognom.Location = New System.Drawing.Point(12, 138)
        Me.LCognom.Name = "LCognom"
        Me.LCognom.Size = New System.Drawing.Size(97, 25)
        Me.LCognom.TabIndex = 3
        Me.LCognom.Text = "Cognoms"
        '
        'LContrasenya
        '
        Me.LContrasenya.AutoSize = True
        Me.LContrasenya.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContrasenya.ForeColor = System.Drawing.Color.Black
        Me.LContrasenya.Location = New System.Drawing.Point(12, 260)
        Me.LContrasenya.Name = "LContrasenya"
        Me.LContrasenya.Size = New System.Drawing.Size(137, 25)
        Me.LContrasenya.TabIndex = 4
        Me.LContrasenya.Text = "Contrasenya *"
        '
        'LRContrasenya
        '
        Me.LRContrasenya.AutoSize = True
        Me.LRContrasenya.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRContrasenya.ForeColor = System.Drawing.Color.Black
        Me.LRContrasenya.Location = New System.Drawing.Point(12, 281)
        Me.LRContrasenya.Name = "LRContrasenya"
        Me.LRContrasenya.Size = New System.Drawing.Size(233, 25)
        Me.LRContrasenya.TabIndex = 5
        Me.LRContrasenya.Text = "Repeteix la contrasenya *"
        '
        'TBNickname
        '
        Me.TBNickname.Location = New System.Drawing.Point(256, 59)
        Me.TBNickname.Name = "TBNickname"
        Me.TBNickname.Size = New System.Drawing.Size(196, 20)
        Me.TBNickname.TabIndex = 8
        '
        'TBNom
        '
        Me.TBNom.Location = New System.Drawing.Point(256, 101)
        Me.TBNom.Name = "TBNom"
        Me.TBNom.Size = New System.Drawing.Size(196, 20)
        Me.TBNom.TabIndex = 9
        '
        'TBCongnom
        '
        Me.TBCongnom.Location = New System.Drawing.Point(256, 141)
        Me.TBCongnom.Name = "TBCongnom"
        Me.TBCongnom.Size = New System.Drawing.Size(196, 20)
        Me.TBCongnom.TabIndex = 10
        '
        'TBContrasenya
        '
        Me.TBContrasenya.Location = New System.Drawing.Point(256, 260)
        Me.TBContrasenya.Name = "TBContrasenya"
        Me.TBContrasenya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContrasenya.Size = New System.Drawing.Size(196, 20)
        Me.TBContrasenya.TabIndex = 11
        '
        'TBRContrasenya
        '
        Me.TBRContrasenya.Location = New System.Drawing.Point(256, 286)
        Me.TBRContrasenya.Name = "TBRContrasenya"
        Me.TBRContrasenya.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBRContrasenya.Size = New System.Drawing.Size(196, 20)
        Me.TBRContrasenya.TabIndex = 12
        '
        'LPermisos
        '
        Me.LPermisos.AutoSize = True
        Me.LPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPermisos.ForeColor = System.Drawing.Color.Black
        Me.LPermisos.Location = New System.Drawing.Point(575, 9)
        Me.LPermisos.Name = "LPermisos"
        Me.LPermisos.Size = New System.Drawing.Size(93, 25)
        Me.LPermisos.TabIndex = 13
        Me.LPermisos.Text = "Permisos"
        '
        'BTEsborrar
        '
        Me.BTEsborrar.BackColor = System.Drawing.Color.White
        Me.BTEsborrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTEsborrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTEsborrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTEsborrar.ForeColor = System.Drawing.Color.Black
        Me.BTEsborrar.Location = New System.Drawing.Point(360, 324)
        Me.BTEsborrar.Name = "BTEsborrar"
        Me.BTEsborrar.Size = New System.Drawing.Size(92, 32)
        Me.BTEsborrar.TabIndex = 16
        Me.BTEsborrar.Text = "Esborrar"
        Me.BTEsborrar.UseVisualStyleBackColor = False
        '
        'BTCrear
        '
        Me.BTCrear.BackColor = System.Drawing.Color.White
        Me.BTCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTCrear.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCrear.ForeColor = System.Drawing.Color.Black
        Me.BTCrear.Location = New System.Drawing.Point(17, 324)
        Me.BTCrear.Name = "BTCrear"
        Me.BTCrear.Size = New System.Drawing.Size(92, 32)
        Me.BTCrear.TabIndex = 15
        Me.BTCrear.Text = "Crear"
        Me.BTCrear.UseVisualStyleBackColor = False
        '
        'TBCorreu
        '
        Me.TBCorreu.Location = New System.Drawing.Point(256, 186)
        Me.TBCorreu.Name = "TBCorreu"
        Me.TBCorreu.Size = New System.Drawing.Size(196, 20)
        Me.TBCorreu.TabIndex = 18
        '
        'LCorreu
        '
        Me.LCorreu.AutoSize = True
        Me.LCorreu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreu.ForeColor = System.Drawing.Color.Black
        Me.LCorreu.Location = New System.Drawing.Point(12, 183)
        Me.LCorreu.Name = "LCorreu"
        Me.LCorreu.Size = New System.Drawing.Size(72, 25)
        Me.LCorreu.TabIndex = 17
        Me.LCorreu.Text = "Correu"
        '
        'DataGridViewPermisos
        '
        Me.DataGridViewPermisos.AllowUserToAddRows = False
        Me.DataGridViewPermisos.AllowUserToDeleteRows = False
        Me.DataGridViewPermisos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codi_permis, Me.descripcio})
        Me.DataGridViewPermisos.Location = New System.Drawing.Point(458, 54)
        Me.DataGridViewPermisos.Name = "DataGridViewPermisos"
        Me.DataGridViewPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPermisos.Size = New System.Drawing.Size(300, 302)
        Me.DataGridViewPermisos.TabIndex = 28
        '
        'codi_permis
        '
        Me.codi_permis.HeaderText = "Codi Permis"
        Me.codi_permis.Name = "codi_permis"
        Me.codi_permis.ReadOnly = True
        '
        'descripcio
        '
        Me.descripcio.HeaderText = "Descripció"
        Me.descripcio.Name = "descripcio"
        Me.descripcio.ReadOnly = True
        Me.descripcio.Width = 150
        '
        'TBDNI
        '
        Me.TBDNI.Location = New System.Drawing.Point(256, 221)
        Me.TBDNI.Name = "TBDNI"
        Me.TBDNI.Size = New System.Drawing.Size(196, 20)
        Me.TBDNI.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "DNI"
        '
        'PanelUsuarisAfegir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 380)
        Me.Controls.Add(Me.TBDNI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridViewPermisos)
        Me.Controls.Add(Me.TBCorreu)
        Me.Controls.Add(Me.LCorreu)
        Me.Controls.Add(Me.BTEsborrar)
        Me.Controls.Add(Me.BTCrear)
        Me.Controls.Add(Me.LPermisos)
        Me.Controls.Add(Me.TBRContrasenya)
        Me.Controls.Add(Me.TBContrasenya)
        Me.Controls.Add(Me.TBCongnom)
        Me.Controls.Add(Me.TBNom)
        Me.Controls.Add(Me.TBNickname)
        Me.Controls.Add(Me.LRContrasenya)
        Me.Controls.Add(Me.LContrasenya)
        Me.Controls.Add(Me.LCognom)
        Me.Controls.Add(Me.LNom)
        Me.Controls.Add(Me.LNomUsuari)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelUsuarisAfegir"
        Me.Text = "PanelUsuarisAfegir"
        CType(Me.DataGridViewPermisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LNomUsuari As Label
    Friend WithEvents LNom As Label
    Friend WithEvents LCognom As Label
    Friend WithEvents LContrasenya As Label
    Friend WithEvents LRContrasenya As Label
    Friend WithEvents TBNickname As TextBox
    Friend WithEvents TBNom As TextBox
    Friend WithEvents TBCongnom As TextBox
    Friend WithEvents TBContrasenya As TextBox
    Friend WithEvents TBRContrasenya As TextBox
    Friend WithEvents LPermisos As Label
    Friend WithEvents BTEsborrar As Button
    Friend WithEvents BTCrear As Button
    Friend WithEvents TBCorreu As TextBox
    Friend WithEvents LCorreu As Label
    Friend WithEvents DataGridViewPermisos As DataGridView
    Friend WithEvents codi_permis As DataGridViewTextBoxColumn
    Friend WithEvents descripcio As DataGridViewTextBoxColumn
    Friend WithEvents TBDNI As TextBox
    Friend WithEvents Label1 As Label
End Class
