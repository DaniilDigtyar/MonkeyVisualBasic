Public Class Suporta
    Private tipusMaterial As String
    Private marca As String
    Private model As String

    Sub New(ByVal tipusMaterial As String, ByVal marca As String, ByVal model As String)
        Me.tipusMaterial = tipusMaterial
        Me.marca = marca
        Me.model = model
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetTipusMaterial.GetHashCode + Me.GetSetMarca.GetHashCode + Me.GetSetModel.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetTipusMaterial.Equals(obj.GetSetTipusMaterial) And Me.GetSetMarca.Equals(obj.GetSetMarca) And Me.GetSetModel.Equals(obj.GetSetModel)
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

    Property GetSetMarca
        Get
            Return Me.marca
        End Get
        Set(value)
            Me.marca = value
        End Set
    End Property

    Property GetSetModel
        Get
            Return Me.model
        End Get
        Set(value)
            Me.model = value
        End Set
    End Property
End Class
