Public Class Permisos
    Private codiPermisos As String
    Private descripcioPermisos As String

    Sub New(ByVal codiPermisos As String, ByVal descripcioPermisos As String)
        Me.codiPermisos = codiPermisos
        Me.descripcioPermisos = descripcioPermisos
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetCodiPermisos.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetCodiPermisos.Equals(obj.GetSetCodiPermisos)
        End If
        Return False

    End Function

    Public Property GetSetCodiPermisos
        Get
            Return Me.codiPermisos
        End Get
        Set(value)
            Me.codiPermisos = value
        End Set
    End Property

    Public Property GetSetDescripcioPermisos
        Get
            Return Me.descripcioPermisos
        End Get
        Set(value)
            Me.descripcioPermisos = value
        End Set
    End Property

End Class
