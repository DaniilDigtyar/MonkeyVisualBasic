Public Class PanelBobinesBobinaAfegir
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Private Sub BTBorrar_Click(sender As Object, e As EventArgs) Handles BTBorrar.Click
        TBDiametre.Text = ""
    End Sub

    Private Sub PanelBobinesBobinaAfegir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaMaterial As HashSet(Of Materials) = New HashSet(Of Materials)
        Dim material As Materials

        listaMaterial = SQLCommands.SelectAllMaterialsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each material In listaMaterial
            DGMaterial.Rows.Add(material.GetSetTipusMaterial, material.GetSetDescripcio)
        Next material

        Dim listaMarques As HashSet(Of MarquesBobines) = New HashSet(Of MarquesBobines)
        Dim marcaBobina As MarquesBobines

        listaMarques = SQLCommands.SelectAllMarcasBobinasFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each marcaBobina In listaMarques
            DGMarcaProductora.Rows.Add(marcaBobina.GetSetMarcaProductora)
        Next marcaBobina

        Dim listaColores As HashSet(Of Colors) = New HashSet(Of Colors)
        Dim colorObjeto As Colors

        listaColores = SQLCommands.SelectAllColorsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each colorObjeto In listaColores
            DGColor.Rows.Add(colorObjeto.GetSetColor, colorObjeto.GetSetHex)
            DGColor.Rows(DGColor.Rows.Count - 1).Cells(2).Style.BackColor = Interaction.ConvertToRBG(colorObjeto.GetSetHex)
        Next colorObjeto
    End Sub

    Private Sub BTAfegir_Click(sender As Object, e As EventArgs) Handles BTAfegir.Click
        Dim afectat As Integer
        Dim bobina As Bobines
        Dim codi As String
        If TBDiametre.Text <> "" Then
            codi = SQLCommands.SelectNewBobinaCode(Globals.userCredentials.GetSetBaseDades, DGMaterial.SelectedRows.Item(0).Cells(0).Value)
            bobina = New Bobines(codi, DGMaterial.SelectedRows.Item(0).Cells(0).Value, DGColor.SelectedRows.Item(0).Cells(0).Value, DGMarcaProductora.SelectedRows.Item(0).Cells(0).Value, TBDiametre.Text)
            afectat = SQLCommands.InsertBobinaIntoDatabase(Globals.userCredentials.GetSetBaseDades, bobina)
            If afectat > 0 Then
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGInsertCorrecto)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGInsertCorrecto)
                End If
                TBDiametre.Text = ""
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

    Private Sub TBDiametre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDiametre.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class