Imports System.IO
Imports System.Text

Module Interaction
    ''' <summary>
    ''' Crea un archivo TXT con el nickname del usuario que se leera al iniciar el Form Login para rellenar la casilla del TextBox.Nickname
    ''' </summary>
    ''' <param name="nickname">Nickname a escribir</param>
    ''' <returns></returns>
    Public Function SaveUserNickname(ByVal nickname As String)
        Try
            Dim fs As FileStream = File.Create(My.Computer.FileSystem.CurrentDirectory + "\nickname.txt")
            Dim info As Byte() = New UTF8Encoding(True).GetBytes(nickname)
            fs.Write(info, 0, info.Length)
            fs.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Function

    ''' <summary>
    ''' Crea dos archivos TXT con la información nesesaria para generar las estadisticas en Java.
    ''' </summary>
    ''' <returns>Bolean indica si se han generado correctamente o no.</returns>
    Public Function GenerateStadisticsFiles()
        Dim SQLCommands As SQLCommands = New SQLCommands()
        Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
        Dim listaUsuaris As HashSet(Of Usuaris) = New HashSet(Of Usuaris)
        Dim i As Impressores
        Dim usuari As Usuaris
        Dim info As Byte()
        Dim fs As FileStream
        Dim savefileDialog As SaveFileDialog = New SaveFileDialog()
        Dim path As String
        Try
            savefileDialog.Filter = "Txt file|*.txt"
            savefileDialog.Title = "Guardar dades d'impressores."
            savefileDialog.FileName = "Impressores"
            savefileDialog.ShowDialog()
            path = savefileDialog.FileName

            listaImpressores = SQLCommands.SelectAllPrintersFromDatabase(Globals.userCredentials.GetSetBaseDades)
            fs = File.Create(path)

            For Each i In listaImpressores
                info = New UTF8Encoding(True).GetBytes(i.GetSetCodiImpressora + "|" + i.GetSetNomAssignat + "|" + i.GetSetEstat + "|" + i.GetSetMarca + "|" + i.GetSetModel + "|" + i.GetSetBobinaCarregada + vbCrLf)
                fs.Write(info, 0, info.Length)

            Next i
            fs.Close()

            savefileDialog.Title = "Guardar dades d'usuaris."
            savefileDialog.FileName = "Usuaris"
            savefileDialog.ShowDialog()
            path = savefileDialog.FileName

            listaUsuaris = SQLCommands.SelectAllUsersFromDatabase(Globals.userCredentials.GetSetBaseDades)
            fs = File.Create(path)

            For Each usuari In listaUsuaris
                info = New UTF8Encoding(True).GetBytes(usuari.GetSetDNI + "|" + usuari.GetSetNom + "|" + usuari.GetSetCognom + vbCrLf)
                fs.Write(info, 0, info.Length)

            Next usuari
            fs.Close()

            Return True
        Catch ex As Exception
            Return False
        End Try


    End Function


End Module
