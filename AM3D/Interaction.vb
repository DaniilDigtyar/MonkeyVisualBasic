Imports System.IO
Imports System.Text

Module Interaction
    ''' <summary>
    ''' Crea un archivo TXT con el nickname del usuario que se leera al iniciar el Form Login para rellenar la casilla del TextBox.Nickname
    ''' </summary>
    ''' <param name="nickname">Nickname a escribir</param>
    ''' <returns></returns>
    Public Function SaveUserNickname(ByVal nickname As String)
        Dim fs As FileStream = File.Create(My.Computer.FileSystem.CurrentDirectory + "\nickname.txt")
        Dim info As Byte() = New UTF8Encoding(True).GetBytes(nickname)
        fs.Write(info, 0, info.Length)
        fs.Close()
    End Function


End Module
