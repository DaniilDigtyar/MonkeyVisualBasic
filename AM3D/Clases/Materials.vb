Public Class Materials
    Private tipusMaterial As String
    Private descripcio As String

    Sub New(ByVal tipusMaterial As String, ByVal descripcio As String)
        Me.tipusMaterial = tipusMaterial
        Me.descripcio = descripcio
    End Sub

    Property GetSetTipusMaterial
        Get
            Return Me.tipusMaterial
        End Get
        Set(value)
            Me.tipusMaterial = value
        End Set
    End Property
End Class
