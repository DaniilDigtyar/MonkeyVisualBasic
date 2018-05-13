﻿Public Class PanelBobinesMarcaAfegir
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Private Sub BTBorrar_Click(sender As Object, e As EventArgs) Handles BTBorrar.Click
        TBMarca.Text = ""
    End Sub

    Private Sub BTAfegir_Click(sender As Object, e As EventArgs) Handles BTAfegir.Click
        Dim afectat As Integer
        Dim marcaProductora As MarquesBobines
        If TBMarca.Text <> "" Then
            marcaProductora = New MarquesBobines(TBMarca.Text)
            afectat = SQLCommands.InsertMarcaBobinaIntoDatabase(Globals.userCredentials.GetSetBaseDades, marcaProductora)
            If afectat > 0 Then
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGInsertCorrecto)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGInsertCorrecto)
                End If
                TBMarca.Text = ""
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