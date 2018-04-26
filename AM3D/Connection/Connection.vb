Imports System.Data.SqlClient

Public Class Connection
    Protected connectionUsuaris As New SqlConnection

    ''' <summary>
    ''' Conexion a la base de datos de usuario para authentificación
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
    ''' Desconexion de la base de datos
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
End Class
