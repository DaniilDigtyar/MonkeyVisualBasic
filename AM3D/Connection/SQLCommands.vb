Imports System.Data.SqlClient

''' <summary>
''' Clase para ejecutar transacciones SQL, se realiza la conexion automaticamente.
''' </summary>
Public Class SQLCommands
    Inherits Connection
    Dim cmd As SqlCommand

    ''' <summary>
    ''' Llamas a un stored procedure en SQL server para authentificar el logueo del usuario
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
    ''' Llamas a la BD de usuarios para recuperar la información del cliente.
    ''' </summary>
    ''' <param name="userNickname">Nickname del usuario</param>
    ''' <returns>Objeto de la clase Users con todo la info</returns>
    Public Function SelectUserInfo(ByVal userNickname As String)
        Try
            Dim dr As SqlDataReader
            Dim query As String
            Dim data(3) As String
            Dim user As Users

            Me.connectUsuaris()

            query = "SELECT top 1 *
		                            FROM dbo.Users
		                            WHERE nickname = @nickname"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionUsuaris
            cmd.Parameters.AddWithValue("@nickname", userNickname)

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                data(0) = dr(0)
                data(1) = "MonkeySoftware_" + dr(1)
                data(2) = dr(2)
                user = New Users(data(0), data(1), data(2))
                Return user
            End If

            Return ""
        Catch ex As Exception
            MsgBox(ex.Message)
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
            Dim dr As SqlDataReader
            Dim query As String

            Me.connectDataBaseClient(dbToConnect)
            query = "select * from " + table
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    For i = 0 To dr.FieldCount - 1
                        Console.WriteLine(dr(i))
                    Next i
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos los usuarios y devuelve un hashset de Usuarios
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Hash set de la clase Usuaris</returns>
    Public Function SelectAllUsersFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaUsuaris As HashSet(Of Usuaris) = New HashSet(Of Usuaris)
            Dim usuari As Usuaris
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from usuaris"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    usuari = New Usuaris(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
                    listaUsuaris.Add(usuari)
                End While
                Return listaUsuaris
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function


    Public Function SelectUserFromDatabaseWhere(ByVal dbToConnect As String, ByVal nickname As String)
        Try
            Dim dni, nom, cognom, email As String
            Dim usuari As Usuaris = New Usuaris(nickname, "", "", "", "", "")
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from usuaris
                     where nickname = '" + nickname + "'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If dr.IsDBNull(0) Then
                    nickname = ""
                Else
                    nickname = dr(0)
                End If
                If dr.IsDBNull(2) Then
                    dni = ""
                Else
                    dni = dr(2)
                End If
                If dr.IsDBNull(3) Then
                    nom = ""
                Else
                    nom = dr(3)
                End If
                If dr.IsDBNull(4) Then
                    cognom = ""
                Else
                    cognom = dr(4)
                End If
                If dr.IsDBNull(5) Then
                    email = ""
                Else
                    email = dr(5)
                End If
                usuari = New Usuaris(nickname, "", dni, nom, cognom, email)
            End If
            Return usuari
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    Public Function SelectAllImpressionsFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaImpressions As HashSet(Of Impressions) = New HashSet(Of Impressions)
            Dim impression As Impressions
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from IMPRESSIONS"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    impression = New Impressions(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
                    listaImpressions.Add(impression)
                End While
                Return listaImpressions
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos los permisos y devuelve un hashset de Permisos
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Hash set de la clase Permisos</returns>
    Public Function SelectAllPermisosFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaPermisos As HashSet(Of Permisos) = New HashSet(Of Permisos)
            Dim permis As Permisos
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from permisos"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    permis = New Permisos(dr(0), dr(1))
                    listaPermisos.Add(permis)
                End While
                Return listaPermisos
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos los permisos y devuelve un hashset de Permisos
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Hash set de la clase Permisos</returns>
    Public Function SelectAllTenenFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaTenen As HashSet(Of Tenen) = New HashSet(Of Tenen)
            Dim tenen As Tenen
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from tenen"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    tenen = New Tenen(dr(0), dr(1))
                    listaTenen.Add(tenen)
                End While
                Return listaTenen
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos las impressoras y devuelve un hashset de Impressores
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Hash set de la clase Permisos</returns>
    Public Function SelectAllPrintersFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
            Dim impressores As Impressores
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from impressores"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    impressores = New Impressores(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
                    listaImpressores.Add(impressores)
                End While
                Return listaImpressores
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos las impressoras que tienen el estado conectado y devuelve un hashset de Impressores
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Hash set de la clase Impressores</returns>
    Public Function SelectAllPrintersLliureFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
            Dim impressores As Impressores
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from impressores
                     where estat = 'CONNECTED'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    impressores = New Impressores(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
                    listaImpressores.Add(impressores)
                End While
                Return listaImpressores
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos los Gcodes y devuelve un hashset de Gcode
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Hash set de la clase Gcode</returns>
    Public Function SelectAllGcodesFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaGcode As HashSet(Of Gcode) = New HashSet(Of Gcode)
            Dim gcode As Gcode
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from GCODE"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    gcode = New Gcode(dr(0), dr(2), dr(3))
                    listaGcode.Add(gcode)
                End While
                Return listaGcode
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos los modelos y devuelve un hashset de Models
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Hash set de la clase Models</returns>
    Public Function SelectAllModelsFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaModels As HashSet(Of Models) = New HashSet(Of Models)
            Dim models As Models
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from models"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    models = New Models(dr(0), dr(1))
                    listaModels.Add(models)
                End While
                Return listaModels
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos los modelos equivalentes de una marca y devuelve un hashset de Models
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <param name="marca">Marca que se quiere consultar</param>
    ''' <returns>Hash set de la clase Models</returns>
    Public Function SelectAllModelsFromDatabaseWhere(ByVal dbToConnect As String, ByVal marca As String)
        Try
            Dim listaModels As HashSet(Of Models) = New HashSet(Of Models)
            Dim models As Models
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from models
                     where marca = '" + marca + "'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    models = New Models(dr(0), dr(1))
                    listaModels.Add(models)
                End While
                Return listaModels
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos las marcas y devuelve un hashset de Marca
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Hash set de la clase Marca</returns>
    Public Function SelectAllMarquesFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaMarca As HashSet(Of Marca) = New HashSet(Of Marca)
            Dim marca As Marca
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from models"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    marca = New Marca(dr(0))
                    listaMarca.Add(marca)
                End While
                Return listaMarca
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos las bobinas y devuelve un hashset de Bobines
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Hash set de la clase Bobines</returns>
    Public Function SelectAllBobinesFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaBobines As HashSet(Of Bobines) = New HashSet(Of Bobines)
            Dim bobines As Bobines
            Dim query As String
            Dim dr As SqlDataReader
            Dim color As String
            Dim marcaProductora As String
            Dim diametre As Double
            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from bobines"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                While (dr.Read())
                    If (dr(2) Is DBNull.Value) Then
                        color = vbNull
                    Else
                        color = dr(2)
                    End If

                    If (dr(3) Is DBNull.Value) Then
                        marcaProductora = vbNull
                    Else
                        marcaProductora = dr(3)
                    End If

                    If (dr(4) Is DBNull.Value) Then
                        diametre = vbNull
                    Else
                        diametre = dr(4)
                    End If
                    bobines = New Bobines(dr(0), dr(1), color, marcaProductora, diametre)
                    listaBobines.Add(bobines)
                End While
                Return listaBobines
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' De la base de datos cliente busca el codigo de impressora mas grande y genera el siguente codigo.
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <returns>Codigo de impressora en String</returns>
    Public Function SelectNewPrinterCode(ByVal dbToConnect As String)
        Try
            Dim query As String
            Dim dr As SqlDataReader
            Dim codi As String
            Dim numero As Integer

            Me.connectDataBaseClient(dbToConnect)
            query = "select top 1 codi_impresora 
                     from impressores
                     order by codi_impresora desc"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                codi = dr(0)
                numero = Integer.Parse(codi.Substring(4)) + 1
                '6 numeros
                codi = "IMPR" + Format(numero, "000000")
                Return codi
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
        Return vbNull
    End Function

    ''' <summary>
    ''' De la base de datos cliente recupera todos las impressiones que ejecuta y tiene pendientes una impressora y devuelve un hashset de Impressions
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <param name="printerCode">Impressora a consultar</param>
    ''' <returns>Hashset de Impressions</returns>
    Public Function SelectPrinterPrintList(ByVal dbToConnect As String, ByVal printerCode As String)
        Dim listaImpressions As HashSet(Of Impressions) = New HashSet(Of Impressions)
        Try

            Dim impressio As Impressions
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select * 
                     from impressions
                     where codi_impresora = '" + printerCode + "'
                     order by ordre_impressio desc"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    impressio = New Impressions(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
                    listaImpressions.Add(impressio)
                End While
                Return listaImpressions
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()

        End Try
        Return listaImpressions
    End Function

    Public Function InsertUserClient(ByVal dbToConnect As String, ByVal usuari As Usuaris)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            query = "INSERT INTO usuaris 
                                VALUES('" + usuari.GetSetNickname + "', null, '" + usuari.GetSetDNI + "', '" + usuari.GetSetNom + "', '" + usuari.GetSetCognom + "', '" + usuari.GetSetEmail + "')"

            Me.connectDataBaseClient(dbToConnect)
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            afectat = cmd.ExecuteNonQuery

            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    Public Function InsertPermisoDeUsuario(ByVal dbToConnect As String, ByVal usuari As Usuaris, ByVal permiso As Permisos)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            query = "INSERT INTO tenen 
                                VALUES('" + permiso.GetSetCodiPermisos + "' , '" + usuari.GetSetNickname + "')"

            Me.connectDataBaseClient(dbToConnect)
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            afectat = cmd.ExecuteNonQuery

            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    Public Function InsertUserIfExistsUpdate(ByVal dbToConnect As String, ByVal usuari As Usuaris)
        Try
            Dim querySelect, queryUpdate, queryInsert As String
            Dim afectat As Integer = 0
            Dim dr As SqlDataReader

            querySelect = "SELECT count(*) FROM usuaris WHERE nickname='" + usuari.GetSetNickname + "'"
            queryUpdate = "UPDATE usuaris 
                     SET nickname = '" + usuari.GetSetNickname + "',contrasenya = null, dni = '" + usuari.GetSetDNI + "', nom = '" + usuari.GetSetNom + "', cognoms = '" + usuari.GetSetCognom + "', email = '" + usuari.GetSetEmail + "'
                     WHERE nickname ='" + usuari.GetSetNickname + "'"
            queryInsert = "INSERT INTO usuaris 
                                VALUES('" + usuari.GetSetNickname + "', null, '" + usuari.GetSetDNI + "', '" + usuari.GetSetNom + "', '" + usuari.GetSetCognom + "', '" + usuari.GetSetEmail + "')"

            Me.connectDataBaseClient(dbToConnect)
            cmd = New SqlCommand(querySelect)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                If dr(0) > 0 Then
                    Me.connectDataBaseClient(dbToConnect)
                    cmd = New SqlCommand(queryUpdate)
                    cmd.Connection = connectionClient
                    afectat = cmd.ExecuteNonQuery()
                Else
                    Me.connectDataBaseClient(dbToConnect)
                    cmd = New SqlCommand(queryInsert)
                    cmd.Connection = connectionClient
                    afectat = cmd.ExecuteNonQuery()
                End If
            End If
            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    Public Function UpdateUserPassword(ByVal dbToConnect As String, ByVal contraseña As String, ByVal nickname As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectUsuaris()
            query = "UPDATE USERS
            SET contrasenya = EncryptByPassPhrase('Banana', '" + contraseña + "' )
            WHERE nickname = '" + nickname + "'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionUsuaris

            afectat = cmd.ExecuteNonQuery()
            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectUsuaris()
        End Try
    End Function

    ''' <summary>
    ''' Inserta una nueva impressora en la base de datos.
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <param name="impressora">Objeto impressora a insertar.</param>
    ''' <returns>Numero de filas afectadas</returns>
    Public Function InsertPrinterIntoDatabase(ByVal dbToConnect As String, ByVal impressora As Impressores)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO impressores 
                    VALUES ('" + impressora.GetSetCodiImpressora + "','" + impressora.GetSetNomAssignat + "','" + impressora.GetSetEstat + "','" + impressora.GetSetMarca + "', '" + impressora.GetSetModel + "','" + impressora.GetSetBobinaCarregada + "');"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient


            afectat = cmd.ExecuteNonQuery()
            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' Inserta una nueva impression en la base de datos.
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos del cliente</param>
    ''' <param name="impressora">Objeto Impressio a insertar.</param>
    ''' <returns>Numero de filas afectadas</returns>
    Public Function InsertPrintIntoDatabase(ByVal dbToConnect As String, ByVal impresio As Impressions)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO IMPRESSIONS
            VALUES ('" + impresio.GetSetNomGcode + "'," + impresio.GetSetNumeroCopia.ToString + ",'" + impresio.GetSetCodiImpresora + "'," + impresio.GetSetOrdreImpressio.ToString + ", '" + impresio.GetSetEstat + "','" + impresio.GetSetNickname + "');"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            afectat = cmd.ExecuteNonQuery()
            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' Actualiza la bobina de una impressora en la base de datos.
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos a conectarte</param>
    ''' <param name="bobina">Codigo de bobina a assignar</param>
    ''' <param name="codiImpressora">Codigo de impressora a la cual se cambia la bobina</param>
    ''' <returns>Numero de filas afectadas.</returns>
    Public Function UpdatePrinterCoilIntoDatabase(ByVal dbToConnect As String, ByVal bobina As String, ByVal codiImpressora As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE impressores 
                    SET bobina_carregada = '" + bobina + "'
                    WHERE codi_impresora = '" + codiImpressora + "'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            afectat = cmd.ExecuteNonQuery()
            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' Funcion para acutalizar la información de una impressora de la base de datos.
    ''' </summary>
    ''' <param name="dbToConnect"></param>
    ''' <param name="codiImpressora"></param>
    ''' <param name="marca"></param>
    ''' <param name="model"></param>
    ''' <param name="nom"></param>
    ''' <returns></returns>
    Public Function UpdatePrinterInfoIntoDatabase(ByVal dbToConnect As String, ByVal codiImpressora As String, ByVal marca As String, ByVal model As String, ByVal nom As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE impressores 
                    SET marca = '" + marca + "' model = '" + model + "', nom_assignat = '" + nom + "'
                    WHERE codi_impresora = '" + codiImpressora + "'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            afectat = cmd.ExecuteNonQuery()
            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    ''' <summary>
    ''' Eliminar una impressora de la base de datos
    ''' </summary>
    ''' <param name="dbToConnect">Base de datos a la cual se conecta el cliente</param>
    ''' <param name="impressora">Impressora a eliminar</param>
    ''' <returns></returns>
    Public Function DeletePrinterIntoDatabase(ByVal dbToConnect As String, ByVal impressora As Impressores)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "DELETE FROM IMPRESSORES
                     WHERE codi_impresora = '" + impressora.GetSetCodiImpressora + "'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            afectat = cmd.ExecuteNonQuery()
            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function
End Class
