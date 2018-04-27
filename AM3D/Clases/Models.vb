Public Class Models
    Private marca As String
    Private model As String

    Sub New(ByVal marca As String, ByVal model As String)
        Me.marca = marca
        Me.model = model
    End Sub

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
