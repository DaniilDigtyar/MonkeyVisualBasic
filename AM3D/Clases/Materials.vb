Public Class Materials
    Private tipusMaterial As String
    Private descripcio As String

    Sub New(ByVal tipusMaterial As String, ByVal descripcio As String)
        Me.tipusMaterial = tipusMaterial
        Me.descripcio = descripcio
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetTipusMaterial.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetTipusMaterial.Equals(obj.GetSetTipusMaterial)
        End If
        Return False
    End Function

    Property GetSetTipusMaterial
        Get
            Return Me.tipusMaterial
        End Get
        Set(value)
            Me.tipusMaterial = value
        End Set
    End Property

    Property GetSetDescripcio
        Get
            Return Me.descripcio
        End Get
        Set(value)
            Me.descripcio = value
        End Set
    End Property
End Class
