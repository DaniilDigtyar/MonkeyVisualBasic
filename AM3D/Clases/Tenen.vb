Public Class Tenen
    Private usuaris As String
    Private permisos As String

    Sub New(ByVal usuari As String, ByVal permisos As String)
        Me.usuaris = usuari
        Me.permisos = permisos
    End Sub

    Property GetSetUsuris
        Get
            Return Me.usuaris
        End Get
        Set(value)
            Me.usuaris = value
        End Set
    End Property

    Property GetSetPermisos
        Get
            Return Me.permisos
        End Get
        Set(value)
            Me.permisos = permisos
        End Set
    End Property

End Class
