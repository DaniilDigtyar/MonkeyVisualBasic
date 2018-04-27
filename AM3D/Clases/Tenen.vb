Public Class Tenen
    Private usuaris As Usuaris
    Private permisos As Permisos

    Sub New(ByVal usuari As Usuaris, ByVal permisos As Permisos)
        Me.usuaris = usuari
        Me.permisos = permisos
    End Sub

End Class
