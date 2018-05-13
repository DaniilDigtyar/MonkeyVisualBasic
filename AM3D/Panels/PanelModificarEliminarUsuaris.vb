Public Class PanelModificarEliminarUsuaris
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public usuariSeleccionat As Usuaris = New Usuaris("", "", "", "", "", "")

    Private Sub BTModificarUsuari_Click(sender As Object, e As EventArgs) Handles BTModificarUsuari.Click
        Dim nickname, contraseña, dni, nom, cognom, email As String
        nickname = DGUsuaris.SelectedRows.Item(0).Cells(0).Value
        contraseña = ""
        dni = DGUsuaris.SelectedRows.Item(0).Cells(1).Value
        nom = DGUsuaris.SelectedRows.Item(0).Cells(2).Value
        cognom = DGUsuaris.SelectedRows.Item(0).Cells(3).Value
        email = DGUsuaris.SelectedRows.Item(0).Cells(4).Value
        usuariSeleccionat = New Usuaris(nickname, contraseña, dni, nom, cognom, email)
        ModificarUsuari.Show()
    End Sub

    Private Sub PanelModificarEliminarUsuaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaUsuaris As HashSet(Of Usuaris) = New HashSet(Of Usuaris)
        Dim usuari As Usuaris

        listaUsuaris = SQLCommands.SelectAllUsersFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each usuari In listaUsuaris
            DGUsuaris.Rows.Add(usuari.GetSetNickname, usuari.GetSetDNI, usuari.GetSetNom, usuari.GetSetCognom, usuari.GetSetEmail)
        Next usuari

    End Sub

    Private Sub BResfrescar_Click(sender As Object, e As EventArgs) Handles BResfrescar.Click
        Dim listaUsuaris As HashSet(Of Usuaris) = New HashSet(Of Usuaris)
        Dim usuari As Usuaris

        DGUsuaris.Rows.Clear()
        listaUsuaris = SQLCommands.SelectAllUsersFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each usuari In listaUsuaris
            DGUsuaris.Rows.Add(usuari.GetSetNickname, usuari.GetSetDNI, usuari.GetSetNom, usuari.GetSetCognom, usuari.GetSetEmail)
        Next usuari

    End Sub

    Private Sub BTEliminarUsuari_Click(sender As Object, e As EventArgs) Handles BTEliminarUsuari.Click
        Dim nickname As String
        Dim usuari As Usuaris
        Dim indice As Integer
        Dim afectat As Integer = 0

        nickname = DGUsuaris.SelectedRows.Item(0).Cells(0).Value
        indice = DGUsuaris.SelectedRows.Item(0).Index
        DGUsuaris.Rows.RemoveAt(indice)
        usuari = New Usuaris(nickname, "", "", "", "", "")
        afectat = SQLCommands.DeleteUserFromDataBase(Globals.userCredentials.GetSetBaseDades, usuari)
        If afectat > 0 Then
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGDeleteCorrect)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGDeleteCorrect)
            End If
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGDeleteError)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGDeleteError)
            End If
        End If

    End Sub

End Class