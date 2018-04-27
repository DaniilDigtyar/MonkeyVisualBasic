Public Class Permisos
    Private codiPermisos As String
    Private descripcioPermisos As String

    Sub New(ByVal codiPermisos As String, ByVal descripcioPermisos As String)
        Me.codiPermisos = codiPermisos
        Me.descripcioPermisos = descripcioPermisos
    End Sub

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
