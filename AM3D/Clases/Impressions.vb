Public Class Impressions
    Private nomGcode As String
    Private numeroCopia As Integer
    Private codiImpresora As String
    Private ordreImpressio As Integer
    Private estat As String
    Private nickname As String

    Sub New(ByVal nomGcode As String, ByVal numeroCopia As Integer, ByVal codiImpresora As String, ByVal ordreImpressio As Integer, ByVal estat As String, ByVal nickname As String)
        Me.nomGcode = nomGcode
        Me.numeroCopia = numeroCopia
        Me.codiImpresora = codiImpresora
        Me.ordreImpressio = ordreImpressio
        Me.estat = estat
        Me.nickname = nickname
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetNomGcode.GetHashCode + Me.GetSetNumeroCopia.GetHashCode + Me.GetSetCodiImpresora.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetNomGcode.Equals(obj.GetSetNomGcode) And Me.GetSetNumeroCopia.Equals(obj.GetSetNumeroCopia) And Me.GetSetCodiImpresora.Equals(obj.GetSetCodiImpresora)
        End If
        Return False
    End Function

    Property GetSetNomGcode
        Get
            Return Me.nomGcode
        End Get
        Set(value)
            Me.nomGcode = value
        End Set
    End Property

    Property GetSetNumeroCopia
        Get
            Return Me.numeroCopia
        End Get
        Set(value)
            Me.numeroCopia = value
        End Set
    End Property

    Property GetSetCodiImpresora
        Get
            Return Me.codiImpresora
        End Get
        Set(value)
            Me.codiImpresora = value
        End Set
    End Property

    Property GetSetOrdreImpressio
        Get
            Return Me.ordreImpressio
        End Get
        Set(value)
            Me.ordreImpressio = value
        End Set
    End Property

    Property GetSetEstat
        Get
            Return Me.estat
        End Get
        Set(value)
            Me.estat = value
        End Set
    End Property

    Property GetSetNickname
        Get
            Return Me.nickname
        End Get
        Set(value)
            Me.nickname = value
        End Set
    End Property
End Class
