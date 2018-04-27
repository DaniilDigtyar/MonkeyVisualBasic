Public Class MarquesBobines
    Private marcaProductora As String

    Sub New(ByVal marcaProductora As String)
        Me.marcaProductora = marcaProductora
    End Sub

    Property GetSetMarcaProductora
        Get
            Return Me.marcaProductora
        End Get
        Set(value)
            Me.marcaProductora = value
        End Set
    End Property
End Class
