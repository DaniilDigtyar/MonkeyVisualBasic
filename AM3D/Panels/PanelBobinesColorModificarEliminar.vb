Public Class PanelBobinesColorModificarEliminar
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public colorSeleccionado As Colors = New Colors("", "")

    Private Sub BTModificarColor_Click(sender As Object, e As EventArgs) Handles BTModificarColor.Click
        colorSeleccionado = New Colors(DGMarcaProductora.SelectedRows.Item(0).Cells(0).Value, DGMarcaProductora.SelectedRows.Item(0).Cells(1).Value)
        ModificarBobinesColor.TBColor.Text = colorSeleccionado.GetSetColor
        ModificarBobinesColor.TBHex.Text = colorSeleccionado.GetSetHex
        ModificarBobinesColor.Show()
    End Sub

    Private Sub PanelBobinesColorModificarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaColores As HashSet(Of Colors) = New HashSet(Of Colors)
        Dim colorObjeto As Colors

        listaColores = SQLCommands.SelectAllColorsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each colorObjeto In listaColores
            DGMarcaProductora.Rows.Add(colorObjeto.GetSetColor, colorObjeto.GetSetHex)
            DGMarcaProductora.Rows(DGMarcaProductora.Rows.Count - 1).Cells(2).Style.BackColor = Interaction.ConvertToRBG(colorObjeto.GetSetHex)
        Next colorObjeto
    End Sub

    Private Sub BResfrescar_Click(sender As Object, e As EventArgs) Handles BResfrescar.Click
        Dim listaColores As HashSet(Of Colors) = New HashSet(Of Colors)
        Dim colorObjeto As Colors

        DGMarcaProductora.Rows.Clear()
        listaColores = SQLCommands.SelectAllColorsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each colorObjeto In listaColores
            DGMarcaProductora.Rows.Add(colorObjeto.GetSetColor, colorObjeto.GetSetHex)
            DGMarcaProductora.Rows(DGMarcaProductora.Rows.Count - 1).Cells(2).Style.BackColor = Interaction.ConvertToRBG(colorObjeto.GetSetHex)
        Next colorObjeto
    End Sub

    Private Sub BTEliminarColor_Click(sender As Object, e As EventArgs) Handles BTEliminarColor.Click
        Dim colorObjeto As Colors
        Dim indice As Integer
        Dim afectat As Integer = 0

        colorObjeto = New Colors(DGMarcaProductora.SelectedRows.Item(0).Cells(0).Value, DGMarcaProductora.SelectedRows.Item(0).Cells(1).Value)
        afectat = SQLCommands.DeleteColorFromDatabaseWhereColor(Globals.userCredentials.GetSetBaseDades, colorObjeto)
        If afectat > 0 Then
            indice = DGMarcaProductora.SelectedRows.Item(0).Index
            DGMarcaProductora.Rows.RemoveAt(indice)
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