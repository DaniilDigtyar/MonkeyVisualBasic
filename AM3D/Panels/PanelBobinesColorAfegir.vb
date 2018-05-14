Public Class PanelBobinesColorAfegir
    Dim SQLCommands As SQLCommands = New SQLCommands()

    Private Sub BTBorrar_Click(sender As Object, e As EventArgs) Handles BTBorrar.Click
        TBColor.Text = ""
        TBHex.Text = ""
        PanelColor.BackColor = Color.Transparent
    End Sub

    Private Sub BTAfegir_Click(sender As Object, e As EventArgs) Handles BTAfegir.Click
        Dim afectat As Integer
        Dim colorObject As Colors
        If TBColor.Text <> "" And TBHex.Text <> "" Then
            colorObject = New Colors(TBColor.Text, TBHex.Text)
            afectat = SQLCommands.InsertColorIntoDatabase(Globals.userCredentials.GetSetBaseDades, colorObject)
            If afectat > 0 Then
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGInsertCorrecto)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGInsertCorrecto)
                End If
                TBColor.Text = ""
                TBHex.Text = ""
                PanelColor.BackColor = Color.Transparent
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

    Private Sub TBHex_TextChanged(sender As Object, e As EventArgs) Handles TBHex.TextChanged
        Dim color As Color
        Try
            If TBHex.Text <> "" Then
                PanelColor.BackColor = Interaction.ConvertToRBG(TBHex.Text)
            End If
        Catch ex As Exception
        End Try
    End Sub

End Class