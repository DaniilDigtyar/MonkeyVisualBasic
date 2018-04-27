Public Class Marca
    Private marca As String

    Sub New(ByVal marca As String)
        Me.marca = marca
    End Sub

    Property GetSetMarca
        Get
            Return marca
        End Get
        Set(value)
            Me.marca = value
        End Set
    End Property
End Class
