Public Class Impressores
    Private codiImpressora As String
    Private nomAssignat As String
    Private estat As String
    Private marca As String
    Private model As String
    Private bobinaCarregada As String

    Sub New(ByVal codiImpressora As String, ByVal nomAssignat As String, ByVal estat As String, ByVal marca As String, ByVal model As String, ByVal bobinaCarregada As String)
        Me.codiImpressora = codiImpressora
        Me.nomAssignat = nomAssignat
        Me.estat = estat
        Me.marca = marca
        Me.model = model
        Me.bobinaCarregada = bobinaCarregada
    End Sub

    Property GetSetCodiImpressora
        Get
            Return Me.codiImpressora
        End Get
        Set(value)
            Me.codiImpressora = value
        End Set
    End Property

    Property GetSetNomAssignat
        Get
            Return Me.nomAssignat
        End Get
        Set(value)
            Me.nomAssignat = value
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

    Property GetSetBobinaCarregada
        Get
            Return Me.bobinaCarregada
        End Get
        Set(value)
            Me.bobinaCarregada = bobinaCarregada
        End Set
    End Property
End Class
