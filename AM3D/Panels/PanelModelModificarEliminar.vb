Public Class PanelModelModificarEliminar
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Private Sub BTModificarModel_Click(sender As Object, e As EventArgs) Handles BTModificarModel.Click
        ModificarModel.Show()
    End Sub

    Private Sub PanelModelModificarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaCaracteristiques As HashSet(Of Caracteristiques) = New HashSet(Of Caracteristiques)
        Dim caracteristica As Caracteristiques

        listaCaracteristiques = SQLCommands.SelectAllCaracteristiquesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each caracteristica In listaCaracteristiques
            DGMarca.Rows.Add(caracteristica.GetSetMarca, caracteristica.GetSetModel, caracteristica.GetSetNumeroExtrusors, caracteristica.GetSetTemperaturaMinimaExtrusor, caracteristica.GetSetTemperaturaMaximaExtrusor, caracteristica.GetSetTemperaturaMinimaLlit, caracteristica.GetSetTemperaturaMaximaLlit, caracteristica.GetSetAreaImpresioX, caracteristica.GetSetAreaImpresioY, caracteristica.GetSetAreaImpresioZ, caracteristica.GetSetVelocitatMaximaCapcal, caracteristica.GetSetResolucioCapaMaxima, caracteristica.GetSetResolucioCapaMinima, caracteristica.GetSetDiametreFilamentAcceptat)
        Next caracteristica
    End Sub

    Private Sub BTEliminarModel_Click(sender As Object, e As EventArgs) Handles BTEliminarModel.Click
        Dim caracteristiques As Caracteristiques
        Dim model As Models
        Dim indice As Integer
        Dim afectat As Integer = 0

        model = New Models(DGMarca.SelectedRows.Item(0).Cells(0).Value, DGMarca.SelectedRows.Item(0).Cells(1).Value)

        caracteristiques = New Caracteristiques(model.GetSetMarca, model.GetSetModel, "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
        afectat = SQLCommands.DeleteModelFromDatabaseWhereModel(Globals.userCredentials.GetSetBaseDades, model)
        If afectat > 0 Then
            indice = DGMarca.SelectedRows.Item(0).Index
            DGMarca.Rows.RemoveAt(indice)
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

    Private Sub BResfrescar_Click(sender As Object, e As EventArgs) Handles BResfrescar.Click
        Dim listaCaracteristiques As HashSet(Of Caracteristiques) = New HashSet(Of Caracteristiques)
        Dim caracteristica As Caracteristiques

        DGMarca.Rows.Clear()
        listaCaracteristiques = SQLCommands.SelectAllCaracteristiquesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each caracteristica In listaCaracteristiques
            DGMarca.Rows.Add(caracteristica.GetSetMarca, caracteristica.GetSetModel, caracteristica.GetSetNumeroExtrusors, caracteristica.GetSetTemperaturaMinimaExtrusor, caracteristica.GetSetTemperaturaMaximaExtrusor, caracteristica.GetSetTemperaturaMinimaLlit, caracteristica.GetSetTemperaturaMaximaLlit, caracteristica.GetSetAreaImpresioX, caracteristica.GetSetAreaImpresioY, caracteristica.GetSetAreaImpresioZ, caracteristica.GetSetVelocitatMaximaCapcal, caracteristica.GetSetResolucioCapaMaxima, caracteristica.GetSetResolucioCapaMinima, caracteristica.GetSetDiametreFilamentAcceptat)
        Next caracteristica
    End Sub
End Class