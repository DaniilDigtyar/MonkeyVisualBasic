Public Class Users
    Private nickname As String
    Private baseDades As String
    Private contrasenya As String


    Sub New(ByVal nickname As String, ByVal baseDades As String, ByVal contrasenya As String)
        Me.nickname = nickname
        Me.baseDades = baseDades
        Me.contrasenya = contrasenya
    End Sub

    Public Property GetSetNickname
        Get
            Return Me.nickname
        End Get
        Set(value)
            Me.nickname = value
        End Set
    End Property

    Public Property GetSetBaseDades
        Get
            Return Me.baseDades
        End Get
        Set(value)
            Me.baseDades = value
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
End Class
