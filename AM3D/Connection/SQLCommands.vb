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
            Dim nickname, nom, cognom, email As String
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
                    usuari = New Usuaris(dr(0), "", dr(2), dr(3), dr(4), dr(5))
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

    Public Function SelectAllMaterialsFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaMaterials As HashSet(Of Materials) = New HashSet(Of Materials)
            Dim material As Materials
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from materials"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    material = New Materials(dr(0), dr(1))
                    listaMaterials.Add(material)
                End While
                Return listaMaterials
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    Public Function SelectAllMarcasBobinasFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaMarcasBobinas As HashSet(Of MarquesBobines) = New HashSet(Of MarquesBobines)
            Dim marquesBobines As MarquesBobines
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from marques_bobines"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    marquesBobines = New MarquesBobines(dr(0))
                    listaMarcasBobinas.Add(marquesBobines)
                End While
                Return listaMarcasBobinas
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    Public Function SelectAllColorsFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaColores As HashSet(Of Colors) = New HashSet(Of Colors)
            Dim colores As Colors
            Dim nombreColor, hex As String
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from colors"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    If Not dr.IsDBNull(0) Then
                        nombreColor = dr(0)
                    Else
                        nombreColor = ""
                    End If

                    If Not dr.IsDBNull(1) Then
                        hex = dr(1)
                    Else
                        hex = ""
                    End If
                    colores = New Colors(nombreColor, hex)
                    listaColores.Add(colores)
                End While
            End If
            Return listaColores
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

    Public Function SelectAllCaracteristiquesFromDatabase(ByVal dbToConnect As String)
        Try
            Dim listaCaracteristiques As HashSet(Of Caracteristiques) = New HashSet(Of Caracteristiques)
            Dim caracteristica As Caracteristiques
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from caracteristiques"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    caracteristica = New Caracteristiques(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12), dr(13))
                    listaCaracteristiques.Add(caracteristica)
                End While
                Return listaCaracteristiques
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
                     from marques"
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

    Public Function SelectNewBobinaCode(ByVal dbToConnect As String, ByVal material As String)
        Try
            Dim query As String
            Dim dr As SqlDataReader
            Dim codi As String
            Dim numero As Integer
            Dim tipoMaterial As String

            Me.connectDataBaseClient(dbToConnect)
            query = "select top 1 codi_bobina tipus_material
                     from bobines
                     where tipus_material = '" + material + "'
                     order by codi_bobina desc"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                codi = dr(0)
                If material.Length >= 3 Then
                    tipoMaterial = material.Substring(0, 3)
                ElseIf material.Length.Equals(2) Then
                    tipoMaterial = material.Substring(0, 2) + "0"
                Else
                    tipoMaterial = "000"
                End If

                numero = Integer.Parse(codi.Substring(4)) + 1
                '6 numeros
                codi = "B" + tipoMaterial + Format(numero, "000000")

            Else
                If material.Length >= 3 Then
                    tipoMaterial = material.Substring(0, 3)
                ElseIf material.Length.Equals(2) Then
                    tipoMaterial = material.Substring(0, 2) + "0"
                Else
                    tipoMaterial = "000"
                End If
                codi = "B" + tipoMaterial + "000000"
            End If
            Return codi


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

    Public Function SelectCodiCopiaFromImpressionsWhereImpressio(ByVal dbToConnect As String, ByVal impressio As Impressions)
        Try
            Dim numeroCopia As Integer = -1
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select numero_copia
                     from impressions
                     WHERE nom_gcode = '" + impressio.GetSetNomGcode + "' and codi_impresora = '" + impressio.GetSetCodiImpresora + "'
                     order by numero_copia  desc"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                numeroCopia = dr(0)
            End If
            Return numeroCopia

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()

        End Try
    End Function


    Public Function SelectOrdreImpressioFromImpressionsWhereImpressio(ByVal dbToConnect As String, ByVal impressio As Impressions)
        Try
            Dim ordre_impressio As Integer = -1
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select ordre_impressio
                     from impressions
                     WHERE nom_gcode = '" + impressio.GetSetNomGcode + "' and codi_impresora = '" + impressio.GetSetCodiImpresora + "'
                     order by ordre_impressio desc"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Read()
                ordre_impressio = dr(0)
            End If
            Return ordre_impressio

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()

        End Try
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

    Public Function InsertUserLogin(ByVal usuari As Usuaris)
        Try
            Dim baseDades As String
            Dim afectat As Integer = 0

            baseDades = Globals.userCredentials.GetSetBaseDades
            baseDades = baseDades.Substring(15)

            Me.connectUsuaris()
            cmd = New SqlCommand("SP_InsertUser")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = connectionUsuaris
            cmd.Parameters.AddWithValue("@nickname", usuari.GetSetNickname)
            cmd.Parameters.AddWithValue("@password", usuari.GetSetContrasenya)
            cmd.Parameters.AddWithValue("@database", baseDades)

            afectat = cmd.ExecuteNonQuery
            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Me.disconnectUsuaris()
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

    Public Function InsertMarcaIntoDatabase(ByVal dbToConnect As String, ByVal marcas As Marca)
        Try
            Dim query As String
            Dim afectat As Integer = 0


            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO marques 
                    VALUES ('" + marcas.GetSetMarca + "');"
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

    Public Function InsertMaterialIntoDatabase(ByVal dbToConnect As String, ByVal material As Materials)
        Try
            Dim query As String
            Dim afectat As Integer = 0


            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO materials 
                    VALUES ('" + material.GetSetTipusMaterial + "', '" + material.GetSetDescripcio + "');"
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

    Public Function InsertMarcaBobinaIntoDatabase(ByVal dbToConnect As String, ByVal marcaBobina As MarquesBobines)
        Try
            Dim query As String
            Dim afectat As Integer = 0


            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO marques_bobines 
                    VALUES ('" + marcaBobina.GetSetMarcaProductora + "');"
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

    Public Function InsertColorIntoDatabase(ByVal dbToConnect As String, ByVal color As Colors)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO colors 
                    VALUES ('" + color.GetSetColor + "', '" + color.GetSetHex + "');"
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

    Public Function InsertGcodeIntoDatabase(ByVal dbToConnect As String, ByVal gcode As Gcode)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO gcode 
                    VALUES ('" + gcode.GetSetNomGcode + "', null ,'" + gcode.GetSetTipusMaterialSuportat + "' , '" + gcode.GetSetNicknameCreador + "');"
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

    Public Function InsertModelIntoDatabase(ByVal dbToConnect As String, ByVal model As Models)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO models 
                    VALUES ('" + model.GetSetMarca + "', '" + model.GetSetModel + "');"
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

    Public Function InsertCaracteristiquesIntoDatabase(ByVal dbToConnect As String, ByVal caracteristiques As Caracteristiques)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO caracteristiques  
                    VALUES ('" + caracteristiques.GetSetMarca + "', '" + caracteristiques.GetSetModel + "' , '" + caracteristiques.GetSetNumeroExtrusors + "', " + caracteristiques.GetSetTemperaturaMinimaExtrusor.ToString + ", " + caracteristiques.GetSetTemperaturaMaximaExtrusor.ToString + ", " + caracteristiques.GetSetTemperaturaMinimaLlit.ToString + ", " + caracteristiques.GetSetTemperaturaMaximaLlit.ToString + ", " + caracteristiques.GetSetAreaImpresioX.ToString + " , " + caracteristiques.GetSetAreaImpresioY.ToString + " , " + caracteristiques.GetSetAreaImpresioZ.ToString + ", " + caracteristiques.GetSetVelocitatMaximaCapcal.ToString + ", " + caracteristiques.GetSetResolucioCapaMaxima.ToString + ", " + caracteristiques.GetSetResolucioCapaMinima.ToString + " ," + caracteristiques.GetSetDiametreFilamentAcceptat.ToString + ");"
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

    Public Function InsertBobinaIntoDatabase(ByVal dbToConnect As String, ByVal bobina As Bobines)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)
            query = "INSERT INTO bobines 
                    VALUES ('" + bobina.GetSetCodiBobina + "', '" + bobina.GetSetTipusMaterial + "', '" + bobina.GetSetColor + "', '" + bobina.GetSetMarcaProductora + "', " + Replace(Format(bobina.GetSetDiametre, "0.00"), ",", ".") + ");"
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

    Public Function UpdateMaterialIntoDatabase(ByVal dbToConnect As String, ByVal material As Materials, ByVal tipoMaterial As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE materials 
                    SET tipus_material = '" + material.GetSetTipusMaterial + "', descripcio = '" + material.GetSetDescripcio + "'
                    WHERE tipus_material = '" + tipoMaterial + "'"
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

    Public Function UpdateMarcaBobinaIntoDatabase(ByVal dbToConnect As String, ByVal marcaBobina As MarquesBobines, ByVal marcaBobinaModificar As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE marques_bobines 
                    SET marca_productora = '" + marcaBobina.GetSetMarcaProductora + "'
                    WHERE marca_productora = '" + marcaBobinaModificar + "'"
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

    Public Function UpdateColorIntoDatabase(ByVal dbToConnect As String, ByVal colorObjeto As Colors, ByVal colorNombreModificar As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE colors 
                    SET color  = '" + colorObjeto.GetSetColor + "' , hex = '" + colorObjeto.GetSetHex + "'
                    WHERE color = '" + colorNombreModificar + "'"
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

    Public Function UpdateGcodeIntoDatabase(ByVal dbToConnect As String, ByVal gcodeObject As Gcode, ByVal gcodeNomModificar As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE gcode 
                    SET nom_gcode = '" + gcodeObject.GetSetNomGcode + "' , tipus_material = '" + gcodeObject.GetSetTipusMaterialSuportat + "' , nickname = '" + gcodeObject.GetSetNicknameCreador + "'
                    WHERE nom_gcode = '" + gcodeNomModificar + "'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            afectat = cmd.ExecuteNonQuery()
            Return afectat
            'Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    Public Function UpdateBobinaIntoDatabase(ByVal dbToConnect As String, ByVal bobina As Bobines)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE bobines 
                    SET tipus_material   = '" + bobina.GetSetTipusMaterial + "' , color = '" + bobina.GetSetColor + "', marca_productora = '" + bobina.GetSetMarcaProductora + "', diametre = " + Replace(Format(bobina.GetSetDiametre, "0.00"), ",", ".") + "
                    WHERE codi_bobina  = '" + bobina.GetSetCodiBobina + "'"
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

    Public Function UpdateMarcaIntoDatabase(ByVal dbToConnect As String, ByVal marca As Marca, ByRef marcaMoficar As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE marques 
                    SET marca    = '" + marca.GetSetMarca + "'
                    WHERE marca  = '" + marcaMoficar + "'"
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

    Public Function UpdateModelIntoDatabase(ByVal dbToConnect As String, ByVal model As Models, ByRef modelModificar As Models)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE models 
                    SET marca    = '" + model.GetSetMarca + "' and model = '" + model.GetSetModel + "'
                    WHERE marca  = '" + modelModificar.GetSetMarca + "'  and model = '" + modelModificar.GetSetModel +
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

    Public Function UpdateCaracteristiquesIntoDatabase(ByVal dbToConnect As String, ByVal caracteristiques As Caracteristiques, ByRef modelModificar As Models)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE caracteristiques  
                    SET marca    = '" + caracteristiques.GetSetMarca + "' and model = '" + caracteristiques.GetSetModel + "' and numero_extrusors = '" + caracteristiques.GetSetNumeroExtrusors + "' and temperatura_minima_extrusor = '" + Replace(Format(caracteristiques.GetSetTemperaturaMinimaExtrusor.ToString, "0.00"), ",", ".") + "' and numero_extrusors = '" + caracteristiques.GetSetNumeroExtrusors + "'
                     and temperatura_maxima_extrusor = '" + Replace(Format(caracteristiques.GetSetTemperaturaMaximaExtrusor.ToString, "0.00"), ",", ".") + " and temperatura_minima_llit = " + Replace(Format(caracteristiques.GetSetTemperaturaMinimaLlit.ToString, "0.00"), ",", ".") + " and temperatura_maxima_llit = " + Replace(Format(caracteristiques.GetSetTemperaturaMaximaLlit.ToString, "0.00"), ",", ".") + "
                     and area_impressio_x = '" + Replace(Format(caracteristiques.GetSetAreaImpresioX.ToString, "0.00"), ",", ".") + " and area_impressio_y  = '" + Replace(Format(caracteristiques.GetSetAreaImpresioY.ToString, "0.00"), ",", ".") + " and area_impressio_z   = '" + Replace(Format(caracteristiques.GetSetAreaImpresioZ.ToString, "0.00"), ",", ".") + " 
                     and velocitat_maxima_capcal = '" + Replace(Format(caracteristiques.GetSetVelocitatMaximaCapcal.ToString, "0.00"), ",", ".") + "  and resolucio_capa_maxima  = '" + Replace(Format(caracteristiques.GetSetResolucioCapaMaxima.ToString, "0.00"), ",", ".") + " 
                     and resolucio_capa_minima = '" + Replace(Format(caracteristiques.GetSetResolucioCapaMinima.ToString, "0.00"), ",", ".") + "  and diametre_filament_acceptat = '" + Replace(Format(caracteristiques.GetSetDiametreFilamentAcceptat.ToString, "0.00"), ",", ".") + " 
                    WHERE marca  = '" + modelModificar.GetSetMarca + "'  and model = '" + modelModificar.GetSetModel +
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

    Public Function UpdateImpressionsEstatIntoDatabase(ByVal dbToConnect As String, ByVal impressions As Impressions, ByVal estat As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE impressions 
                    SET estat = '" + estat + "'
                    WHERE nom_gcode = '" + impressions.GetSetNomGcode + "' and numero_copia = " + impressions.GetSetNumeroCopia.ToString + " and codi_impresora = '" + impressions.GetSetCodiImpresora + "'"
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

    Public Function UpdateImpressoraEstatIntoDatabase(ByVal dbToConnect As String, ByVal impressora As Impressores, ByVal estat As String)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "UPDATE impressores 
                    SET estat = '" + estat + "'
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
                    SET marca = '" + marca + "' ,  model = '" + model + "', nom_assignat = '" + nom + "'
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
    Public Function DeleteImpressoresFromDatabaseWhereImpressora(ByVal dbToConnect As String, ByVal impressora As Impressores)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            DeleteImpressionsFromDatabaseWhereImpressora(dbToConnect, impressora)
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

    Public Function DeleteImpressionsFromDatabaseWhereImpressora(ByVal dbToConnect As String, ByVal impressora As Impressores)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "DELETE FROM impressions
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

    Public Function DeleteImpressionsFromDatabaseWhereImpressio(ByVal dbToConnect As String, ByVal impressio As Impressions)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "DELETE FROM impressions
                     WHERE nom_gcode = '" + impressio.GetSetNomGcode + "' and numero_copia = " + impressio.GetSetNumeroCopia.ToString + " and codi_impresora = '" + impressio.GetSetCodiImpresora + "'"
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

    Public Function SelectNextImpressioFromDatabaseWhereImpressio(ByVal dbToConnect As String, ByVal impressio As Impressions, ByRef siguente As Boolean)
        Try
            Dim query As String = ""
            Dim dr As SqlDataReader
            Dim impressioReturn As New Impressions("", 0, "", 0, "", "")

            Me.connectDataBaseClient(dbToConnect)
            query = "SELECT top 1 *
                     FROM impressions
                     WHERE codi_impresora = '" + impressio.GetSetCodiImpresora + "' and ordre_impressio = " + (impressio.GetSetOrdreImpressio + 1).ToString
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            siguente = False
            If dr.HasRows Then
                siguente = True
                dr.Read()
                impressioReturn = New Impressions(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
            End If
            Return impressioReturn
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    Public Function DeleteMarcaFromDatabaseWhereMarca(ByVal dbToConnect As String, ByVal marca As Marca)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)

            query = "DELETE 
                     FROM marques
                     WHERE marca = '" + marca.GetSetMarca + "'"
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

    Public Function DeleteMaterialFromDatabaseWhereMaterial(ByVal dbToConnect As String, ByVal material As Materials)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)

            query = "DELETE 
                     FROM materials
                     WHERE tipus_material = '" + material.GetSetTipusMaterial + "'"
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


    Public Function DeleteBobinaFromDatabaseWhereBobina(ByVal dbToConnect As String, ByVal bobina As Bobines)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)

            query = "DELETE 
                     FROM bobines
                     WHERE codi_bobina = '" + bobina.GetSetCodiBobina + "'"
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

    Public Function DeleteMarcaBobinaFromDatabaseWhereMarcaBobina(ByVal dbToConnect As String, ByVal marcaBobina As MarquesBobines)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)

            query = "DELETE 
                     FROM marques_bobines
                     WHERE marca_productora = '" + marcaBobina.GetSetMarcaProductora + "'"
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

    Public Function DeleteColorFromDatabaseWhereColor(ByVal dbToConnect As String, ByVal colorObjeto As Colors)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)

            query = "DELETE 
                     FROM colors
                     WHERE color  = '" + colorObjeto.GetSetColor + "'"
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

    Public Function DeleteGcodeFromDatabaseWhereGcode(ByVal dbToConnect As String, ByVal gcode As Gcode)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Me.connectDataBaseClient(dbToConnect)
            query = "DELETE 
                     FROM gcode
                     WHERE nom_gcode   = '" + gcode.GetSetNomGcode + "'"
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

    Public Function DeleteUserFromDataBase(ByVal dbToConnect As String, ByVal usuari As Usuaris)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            DeleteAllPermitsFromDatabase(dbToConnect, usuari)
            DeleteUserLoginFromDatabase(usuari.GetSetNickname)
            Me.connectDataBaseClient(dbToConnect)

            query = "DELETE FROM USUARIS
                     WHERE nickname = '" + usuari.GetSetNickname + "'"
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

    Public Function DeleteUserLoginFromDatabase(ByVal nickname As String)
        Try
            Dim afectat As Integer = 0
            Dim query As String
            Me.connectUsuaris()

            query = "DELETE FROM USERS
                     WHERE nickname = '" + nickname + "'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionUsuaris

            afectat = cmd.ExecuteNonQuery
            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Me.disconnectUsuaris()
        End Try
    End Function

    Public Function DeleteAllPermitsFromDatabase(ByVal dbToConnect As String, ByVal usuari As Usuaris)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "DELETE FROM TENEN
                     WHERE nickname = '" + usuari.GetSetNickname + "'"
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

    Public Function DeleteModelFromDatabaseWhereModel(ByVal dbToConnect As String, ByVal model As Models)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "DELETE FROM models
                     WHERE marca  = '" + model.GetSetMarca + "' and model = '" + model.GetSetModel + "'"
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

    Public Function DeleteImpressoresFromDatabaseWhereModel(ByVal dbToConnect As String, ByVal model As Models)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            DeleteImpressionsFromDatabaseWhereModel(dbToConnect, model)
            Me.connectDataBaseClient(dbToConnect)
            query = "DELETE FROM impressores
                     WHERE marca  = '" + model.GetSetMarca + "' and model = '" + model.GetSetModel + "'"
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

    Public Function DeleteImpressionsFromDatabaseWhereModel(ByVal dbToConnect As String, ByVal model As Models)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            Dim listaImpressions As HashSet(Of Impressions) = New HashSet(Of Impressions)
            Dim impression As Impressions

            listaImpressions = SelectImpressionFromDatabaseWhereModel(dbToConnect, model)
            Me.connectDataBaseClient(dbToConnect)

            For Each impression In listaImpressions
                query = "DELETE FROM impressions
                     WHERE codi_impresora = '" + impression.GetSetCodiImpresora + "'"
                cmd = New SqlCommand(query)
                cmd.Connection = connectionClient
                afectat = cmd.ExecuteNonQuery()
                Me.disconnectDataBaseClient()
            Next impression

            Return afectat
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

        End Try
    End Function

    Public Function SelectImpressionFromDatabaseWhereModel(ByVal dbToConnect As String, ByVal model As Models)
        Try
            Dim listaImpressions As HashSet(Of Impressions) = New HashSet(Of Impressions)
            Dim impression As Impressions
            Dim query As String
            Dim dr As SqlDataReader

            Me.connectDataBaseClient(dbToConnect)
            query = "select *
                     from IMPRESSIONS
                     where marca  = '" + model.GetSetMarca + "' and model = '" + model.GetSetModel + "'"
            cmd = New SqlCommand(query)
            cmd.Connection = connectionClient
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While (dr.Read())
                    impression = New Impressions(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5))
                    listaImpressions.Add(impression)
                End While
            End If
            Return listaImpressions
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Me.disconnectDataBaseClient()
        End Try
    End Function

    Public Function DeleteCaracteristiquesFromDatabaseWhereModel(ByVal dbToConnect As String, ByVal model As Models)
        Try
            Dim query As String
            Dim afectat As Integer = 0
            DeleteSuportaFromDatabaseWhereModel(dbToConnect, model)
            Me.connectDataBaseClient(dbToConnect)
            query = "DELETE FROM caracteristiques
                     WHERE marca  = '" + model.GetSetMarca + "' and model = '" + model.GetSetModel + "'"
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

    Public Function DeleteSuportaFromDatabaseWhereModel(ByVal dbToConnect As String, ByVal model As Models)
        Try
            Dim query As String
            Dim afectat As Integer = 0

            Me.connectDataBaseClient(dbToConnect)
            query = "DELETE FROM suporta
                     WHERE marca  = '" + model.GetSetMarca + "' and model = '" + model.GetSetModel + "'"
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
