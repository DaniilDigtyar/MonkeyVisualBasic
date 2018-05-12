Public Class PanelUsuarisAfegir
    Dim SQLCommands As SQLCommands = New SQLCommands()

    Private Sub BTEsborrar_Click(sender As Object, e As EventArgs) Handles BTEsborrar.Click
        TBNickname.Text = ""
        TBNom.Text = ""
        TBCongnom.Text = ""
        TBContrasenya.Text = ""
        TBRContrasenya.Text = ""
        TBDNI.Text = ""
        TBCorreu.Text = ""
    End Sub

    Private Sub PanelUsuarisAfegir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaPermisos As HashSet(Of Permisos) = New HashSet(Of Permisos)
        Dim permis As Permisos
        listaPermisos = SQLCommands.SelectAllPermisosFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each permis In listaPermisos
            DataGridViewPermisos.Rows.Add(permis.GetSetCodiPermisos, permis.GetSetDescripcioPermisos)
        Next permis
    End Sub

    Private Sub BTCrear_Click(sender As Object, e As EventArgs) Handles BTCrear.Click
        If TBNickname.Text IsNot "" And TBContrasenya.Text IsNot "" And TBRContrasenya.Text IsNot "" Then
            If TBContrasenya.Text.Equals(TBRContrasenya.Text) Then
                Dim afectat As Integer
                Dim usuari As Usuaris
                Dim row As DataGridViewRow
                Dim permiso As Permisos
                usuari = New Usuaris(TBNickname.Text, TBContrasenya.Text, TBDNI.Text, TBNom.Text, TBCongnom.Text, TBCorreu.Text)
                afectat = SQLCommands.InsertUserClient(Globals.userCredentials.GetSetBaseDades, usuari)
                If (afectat > 0) Then
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.MSGUserUpdateCorrect)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.MSGUserUpdateCorrect)
                    End If
                    For Each row In DataGridViewPermisos.SelectedRows
                        permiso = New Permisos(DataGridViewPermisos.Rows(row.Index).Cells(0).Value, DataGridViewPermisos.Rows(row.Index).Cells(1).Value)
                        afectat = SQLCommands.InsertPermisoDeUsuario(Globals.userCredentials.GetSetBaseDades, usuari, permiso)
                    Next row
                    TBNickname.Text = ""
                    TBNom.Text = ""
                    TBCongnom.Text = ""
                    TBContrasenya.Text = ""
                    TBRContrasenya.Text = ""
                    TBDNI.Text = ""
                    TBCorreu.Text = ""

                Else
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.MSGUserUpdateError)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.MSGUserUpdateError)
                    End If
                End If
            Else
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGUserRepetirError)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGUserRepetirError)
                End If
            End If
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGRellenarError)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGRellenarError)
            End If
        End If
    End Sub
End Class