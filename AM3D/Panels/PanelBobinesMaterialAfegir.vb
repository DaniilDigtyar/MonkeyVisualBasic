Public Class PanelBobinesMaterialAfegir
    Dim SQLCommands As SQLCommands = New SQLCommands()

    Private Sub BTBorrar_Click(sender As Object, e As EventArgs) Handles BTBorrar.Click
        TBMaterial.Text = ""
        TBTecnic.Text = ""
    End Sub

    Private Sub BTAfegir_Click(sender As Object, e As EventArgs) Handles BTAfegir.Click
        Dim afectat As Integer
        Dim material As Materials
        If TBMaterial.Text <> "" And TBTecnic.Text <> "" Then
            material = New Materials(TBMaterial.Text, TBTecnic.Text)
            afectat = SQLCommands.InsertMaterialIntoDatabase(Globals.userCredentials.GetSetBaseDades, material)
            If afectat > 0 Then
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGInsertCorrecto)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGInsertCorrecto)
                End If
                TBMaterial.Text = ""
                TBTecnic.Text = ""
            Else
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGInsertIncorrecto)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGInsertIncorrecto)
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