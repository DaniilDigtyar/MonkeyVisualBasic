Public Class MarquesBobines
    Private marcaProductora As String

    Sub New(ByVal marcaProductora As String)
        Me.marcaProductora = marcaProductora
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetMarcaProductora.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetMarcaProductora.Equals(obj.GetSetMarcaProductora)
        End If
        Return False
    End Function

    Property GetSetMarcaProductora
        Get
            Return Me.marcaProductora
        End Get
        Set(value)
            Me.marcaProductora = value
        End Set
    End Property
End Class
