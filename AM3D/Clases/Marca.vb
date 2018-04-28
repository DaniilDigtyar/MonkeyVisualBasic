Public Class Marca
    Private marca As String

    Sub New(ByVal marca As String)
        Me.marca = marca
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetMarca.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetMarca.Equals(obj.GetSetMarca)
        End If
        Return False
    End Function

    Property GetSetMarca
        Get
            Return marca
        End Get
        Set(value)
            Me.marca = value
        End Set
    End Property
End Class
