Public Class Bobines
    Private codiBobina As String
    Private tipusMaterial As String
    Private color As String
    Private marcaProductora As String
    Private diametre As Double

    Sub New(ByVal codiBobina As String, ByVal tipusMaterial As String, ByVal color As String, ByVal marcaProductora As String, ByVal diametre As Double)
        Me.codiBobina = codiBobina
        Me.tipusMaterial = tipusMaterial
        If (color.Equals(vbNull)) Then
            Me.color = ""
        Else
            Me.color = color
        End If
        If (marcaProductora.Equals(vbNull)) Then
            Me.marcaProductora = ""
        Else
            Me.marcaProductora = marcaProductora
        End If
        If (diametre.Equals(vbNull)) Then
            Me.diametre = 0
        Else
            Me.diametre = diametre
        End If
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetCodiBobina.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetCodiBobina.Equals(obj.GetSetCodiBobina)
        End If
        Return False
    End Function

    Property GetSetCodiBobina
        Get
            Return Me.codiBobina
        End Get
        Set(value)
            Me.codiBobina = value
        End Set
    End Property

    Property GetSetTipusMaterial
        Get
            Return Me.tipusMaterial
        End Get
        Set(value)
            Me.tipusMaterial = value
        End Set
    End Property

    Property GetSetColor
        Get
            Return Me.color
        End Get
        Set(value)
            Me.color = value
        End Set
    End Property

    Property GetSetMarcaProductora
        Get
            Return Me.marcaProductora
        End Get
        Set(value)
            Me.marcaProductora = value
        End Set
    End Property

    Property GetSetDiametre
        Get
            Return Me.diametre
        End Get
        Set(value)
            Me.diametre = value
        End Set
    End Property
End Class
