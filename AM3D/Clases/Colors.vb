Public Class Colors
    Private color As String
    Private hex As String

    Sub New(ByVal color As String, ByVal hex As String)
        Me.color = color
        Me.hex = hex
    End Sub

    Property GetSetColor
        Get
            Return Me.color
        End Get
        Set(value)
            Me.color = value
        End Set
    End Property

    Property GetSetHex
        Get
            Return Me.hex
        End Get
        Set(value)
            Me.hex = value
        End Set
    End Property
End Class
