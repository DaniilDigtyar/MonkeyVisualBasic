Imports System.Data.SqlClient

''' <summary>
''' Clase para ejecutar transacciones SQL, se realiza la conexion automaticamente.
''' </summary>
Public Class SQLCommands
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

    ''' <summary>
    ''' Llamas a la BD de usuarios para recuperar la BD del cliente.
    ''' </summary>
    ''' <param name="userNickname">Nickname del usuario</param>
    ''' <returns>Nombre de la base de datos a la cual se tiene que conectar</returns>
    Public Function SelectUserDatabase(ByVal userNickname As String)
        Try
            Dim dr As SqlDataReader
            Dim query As String
            Dim databaseName As String

            Me.connectUsuaris()

            query = "SELECT top 1 base_de_dades
		                            FROM dbo.Users
		                            WHERE nickname = @nickname"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionUsuaris
            cmd.Parameters.AddWithValue("@nickname", userNickname)

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                databaseName = "MonkeySoftware_" + dr(0)
                Return databaseName
            End If

            Return ""
        Catch ex As Exception
            MsgBox(ex.Message)
            Return ""
        Finally
            Me.disconnectUsuaris()
        End Try
    End Function

    ''' <summary>
    ''' Seleccionas todos los campos y registros de una tabla
    ''' </summary>
    ''' <param name="dbToConnect">Nombre de la base de datos del cliente</param>
    ''' <param name="table">Tabla la cual coges todos los registros</param>
    ''' <returns></returns>
    Public Function SelectAllFromTable(ByVal dbToConnect As String, ByVal table As String)
        Try
            Dim i As Integer
            Me.connectDataBaseClient(dbToConnect)
            Dim query As String = "select *
                                   from " + table
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    For i = 0 To dr.FieldCount - 1
                        Console.WriteLine(dr(i))
                    Next i
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message + "table")

        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function
End Class
