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
    ''' Crea un archivo TXT con la información nesesaria para generar las estadisticas en Java
    ''' </summary>
    ''' <returns></returns>
    Public Function GenerateStadisticsFiles()
        Dim SQLCommands As SQLCommands = New SQLCommands()
        Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
        Dim info As Byte()
        Dim fs As FileStream
        Dim i As Impressores
        Try
            listaImpressores = SQLCommands.SelectAllPrintersFromDatabase(Globals.userCredentials.GetSetBaseDades)
            fs = File.Create(My.Computer.FileSystem.CurrentDirectory + "\Impressores.txt")

            For Each i In listaImpressores
                info = New UTF8Encoding(True).GetBytes(i.GetSetCodiImpressora + "|" + i.GetSetNomAssignat + "|" + i.GetSetEstat + "|" + i.GetSetMarca + "|" + i.GetSetModel + "|" + i.GetSetBobinaCarregada + vbCrLf)
                fs.Write(info, 0, info.Length)

            Next i
            fs.Close()
        Catch ex As Exception
            MsgBox(ex)
        End Try


    End Function


End Module
