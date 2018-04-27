Public Class Tenen
    Private usuaris As String
    Private permisos As String

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetUsuaris.GetHashCode + Me.GetSetPermisos.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetUsuaris.Equals(obj.GetSetUsuaris) And Me.GetSetPermisos.Equals(obj.GetSetPermisos)
        End If
        Return False
    End Function

    Sub New(ByVal usuari As String, ByVal permisos As String)
        Me.usuaris = usuari
        Me.permisos = permisos
    End Sub

    Property GetSetUsuaris
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
