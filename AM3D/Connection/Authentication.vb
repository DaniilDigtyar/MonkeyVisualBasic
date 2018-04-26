Imports System.Data.SqlClient

Public Class Authentication
    Inherits Connection
    Dim cmd As SqlCommand

    ''' <summary>
    ''' Funcion para authentificar el logueo del usuario
    ''' </summary>
    ''' <param name="nickname">Nickname del usuario</param>
    ''' <param name="password">Contraseña que introduce el usuario, sin encriptar</param>
    ''' <returns>Un boolean, true existe, false no existe o error</returns>
    Public Function AuthenticateUser(ByVal nickname As String, ByVal password As String)
        Try
            Me.connectUsuaris()
            cmd = New SqlCommand("SP_AuthenticateUser")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connectionUsuaris
            cmd.Parameters.AddWithValue("@nickname", nickname)
            cmd.Parameters.AddWithValue("@password", password)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Me.disconnectUsuaris()
        End Try
    End Function
End Class
