Public Class Caracteristiques
    Private marca As String
    Private model As String
    Private numeroExtrusors As String
    Private temperaturaMinimaExtrusor As Double
    Private temperaturaMaximaExtrusor As Double
    Private temperaturaMinimaLlit As Double
    Private temperaturaMaximaLlit As Double
    Private areaImpresioX As Double
    Private areaImpresioY As Double
    Private areaImpresioZ As Double
    Private velocitatMaximaCapcal As Double
    Private resolucioCapaMaxima As Double
    Private resolucioCapaMinima As Double
    Private diametreFilamentAcceptat As Double

    Sub New(ByVal marca As String, ByVal model As String, ByVal numeroExtrusors As String, ByVal temperaturaMinimaExtrusor As Double, ByVal temperaturaMaximaExtrusor As Double, ByVal temperaturaMinimaLlit As Double, ByVal temperaturaMaximaLlit As Double, ByVal areaImpresioX As Double, ByVal areaImpresioY As Double, ByVal areaImpresioZ As Double, ByVal velocitatMaximaCapcal As Double, ByVal resolucioCapaMaxima As Double, ByVal resolucioCapaMinima As Double, ByVal diametreFilamentAcceptat As Double)
        Me.marca = marca
        Me.model = model
        Me.numeroExtrusors = numeroExtrusors
        Me.temperaturaMinimaExtrusor = temperaturaMinimaExtrusor
        Me.temperaturaMaximaExtrusor = temperaturaMaximaExtrusor
        Me.temperaturaMinimaLlit = temperaturaMinimaLlit
        Me.temperaturaMaximaLlit = temperaturaMaximaLlit
        Me.areaImpresioX = areaImpresioX
        Me.areaImpresioY = areaImpresioY
        Me.areaImpresioZ = areaImpresioZ
        Me.velocitatMaximaCapcal = velocitatMaximaCapcal
        Me.resolucioCapaMaxima = resolucioCapaMaxima
        Me.resolucioCapaMinima = resolucioCapaMinima
        Me.diametreFilamentAcceptat = diametreFilamentAcceptat
    End Sub

    Public Overrides Function GetHashCode() As Integer
        Return Me.GetSetMarca.GetHashCode + Me.GetSetModel.GetHashCode
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        If (obj.GetType().Equals(Me.GetType)) Then
            Return Me.GetSetMarca.Equals(obj.GetSetMarca) And Me.GetSetModel.Equals(obj.GetSetModel)
        End If
        Return False
    End Function

    Property GetSetMarca
        Get
            Return marca
        End Get
        Set(value)
            Me.marca = value
        End Set
    End Property

    Property GetSetModel
        Get
            Return model
        End Get
        Set(value)
            Me.model = value
        End Set
    End Property

    Property GetSetNumeroExtrusors
        Get
            Return Me.numeroExtrusors
        End Get
        Set(value)
            Me.numeroExtrusors = value
        End Set
    End Property

    Property GetSetTemperaturaMinimaExtrusor
        Get
            Return Me.temperaturaMinimaExtrusor
        End Get
        Set(value)
            Me.temperaturaMinimaExtrusor = value
        End Set
    End Property

    Property GetSetTemperaturaMinimaLlit
        Get
            Return Me.temperaturaMinimaLlit
        End Get
        Set(value)
            Me.temperaturaMinimaLlit = value
        End Set
    End Property

    Property GetSetTemperaturaMaximaLlit
        Get
            Return Me.temperaturaMaximaLlit
        End Get
        Set(value)
            Me.temperaturaMaximaLlit = value
        End Set
    End Property

    Property GetSetAreaImpresioX
        Get
            Return Me.areaImpresioX
        End Get
        Set(value)
            Me.areaImpresioX = value
        End Set
    End Property

    Property GetSetAreaImpresioY
        Get
            Return Me.areaImpresioY
        End Get
        Set(value)
            Me.areaImpresioY = value
        End Set
    End Property

    Property GetSetAreaImpresioZ
        Get
            Return Me.areaImpresioZ
        End Get
        Set(value)
            Me.areaImpresioZ = value
        End Set
    End Property

    Property GetSetVelocitatMaximaCapcal
        Get
            Return Me.velocitatMaximaCapcal
        End Get
        Set(value)
            Me.velocitatMaximaCapcal = value
        End Set
    End Property

    Property GetSetResolucioCapaMaxima
        Get
            Return Me.resolucioCapaMaxima
        End Get
        Set(value)
            Me.resolucioCapaMaxima = value
        End Set
    End Property

    Property GetSetResolucioCapaMinima
        Get
            Return Me.resolucioCapaMinima
        End Get
        Set(value)
            Me.resolucioCapaMinima = value
        End Set
    End Property

    Property GetSetDiametreFilamentAcceptat
        Get
            Return Me.diametreFilamentAcceptat
        End Get
        Set(value)
            Me.diametreFilamentAcceptat = value
        End Set
    End Property
End Class
