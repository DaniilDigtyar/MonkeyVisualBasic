Imports System.Data.SqlClient

''' <summary>
''' Clase para realizar la conexion a BD
''' </summary>
Public Class Connection
    Protected connectionUsuaris As New SqlConnection
    Protected connectionClient As New SqlConnection

    ''' <summary>
    ''' Conexion a la base de datos de usuario para authentificación.
    ''' </summary>
    ''' <returns>True todo correcto, false errores</returns>
    Protected Function connectUsuaris()
        Try
            Dim connectionString = "Data Source=oracle.ilerna.com;Initial Catalog=MonkeySoftware_Usuaris;User ID=DAM2_Monkey;Password=SpaghettiMonkey2018;"
            connectionUsuaris = New SqlClient.SqlConnection(connectionString)

            connectionUsuaris.Open()
            Return True
        Catch e As Exception
            MessageBox.Show(e.Message(), "Error in connectUsuaris.")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Desconexion de la base de datos de usuarios.
    ''' </summary>
    ''' <returns>True todo correcto, false errores</returns>
    Protected Function disconnectUsuaris()
        Try
            If connectionUsuaris.State = ConnectionState.Open Then
                connectionUsuaris.Close()
                Return True
            End If
            Return False
        Catch e As Exception
            MessageBox.Show(e.Message, "Error in disconnectUsuaris.")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Conexion a la base de datos del cliente.
    ''' </summary>
    ''' <param name="DBToConnect">Nombre de la base de datos del cliente</param>
    ''' <returns>True todo correcto, false errores</returns>
    Protected Function connectDataBaseClient(ByVal DBToConnect As String)
        Try
            Dim connectionString = "Data Source=oracle.ilerna.com;Initial Catalog=" + DBToConnect + ";User ID=DAM2_Monkey;Password=SpaghettiMonkey2018;"
            connectionClient = New SqlClient.SqlConnection(connectionString)

            connectionClient.Open()
            Return True
        Catch e As Exception
            MessageBox.Show(e.Message(), "Error in connectDataBaseClient.")
            Return False
        End Try
    End Function

    ''' <summary>
    ''' Desconexion de la base de datos del cliente.
    ''' </summary>
    ''' <returns>True todo correcto, false errores</returns>
    Protected Function disconnectDataBaseClient()
        Try
            If connectionClient.State = ConnectionState.Open Then
                connectionClient.Close()
                Return True
            End If
            Return False
        Catch e As Exception
            MessageBox.Show(e.Message, "Error in disconnectUsuaris.")
            Return False
        End Try
    End Function
End Class
