Public Class Usuaris
    Private nickname As String
    Private dni As String
    Private nom As String
    Private cognom As String
    Private contrasenya As String
    Private email As String

    Sub New(ByVal nickname As String, ByVal dni As String, ByVal nom As String, ByVal cognom As String, ByVal contrasenya As String, ByVal email As String)
        Me.nickname = nickname
        Me.dni = dni
        Me.nom = nom
        Me.cognom = cognom
        Me.contrasenya = contrasenya
        Me.email = email
    End Sub

    Public Property GetSetNickname
        Get
            Return Me.nickname
        End Get
        Set(value)
            Me.nickname = value
        End Set
    End Property

    Public Property GetSetDNI
        Get
            Return Me.dni
        End Get
        Set(value)
            Me.dni = value
        End Set
    End Property

    Public Property GetSetNom
        Get
            Return Me.nom
        End Get
        Set(value)
            Me.nom = value
        End Set
    End Property

    Public Property GetSetCognom
        Get
            Return Me.cognom
        End Get
        Set(value)
            Me.cognom = cognom
        End Set
    End Property

    Public Property GetSetContrasenya
        Get
            Return Me.contrasenya
        End Get
        Set(value)
            Me.contrasenya = value
        End Set
    End Property

    Public Property GetSetEmail
        Get
            Return Me.email
        End Get
        Set(value)
            Me.email = value
        End Set
    End Property
End Class
