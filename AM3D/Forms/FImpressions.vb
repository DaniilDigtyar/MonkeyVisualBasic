Public Class FImpressions
    Dim SQLCommand As New SQLCommands

    Protected Overrides Sub OnLoad(e As EventArgs)
        Try
            Dim listaImpressions As HashSet(Of Impressions) = New HashSet(Of Impressions)
            Dim impressions As Impressions

            listaImpressions = SQLCommand.SelectAllImpressionsFromDatabase(Globals.userCredentials.GetSetBaseDades)

            For Each impressions In listaImpressions
                BTImprimirGCODE.Rows.Add(impressions.GetSetNomGcode, impressions.GetSetNumeroCopia, impressions.GetSetCodiImpresora, impressions.GetSetOrdreImpressio, impressions.GetSetEstat, impressions.GetSetNickname)
            Next impressions
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BTImpressionsPeçaRetirada_Click(sender As Object, e As EventArgs) Handles BTImpressionsPeçaRetirada.Click

    End Sub

    Private Sub BTImprimirG_Click(sender As Object, e As EventArgs) Handles BTImprimirG.Click
        ImprimirGCODE.Show()
    End Sub

    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click

    End Sub

    Private Sub BResfrescar_Click(sender As Object, e As EventArgs) Handles BResfrescar.Click
        Dim listaImpressions As HashSet(Of Impressions) = New HashSet(Of Impressions)
        Dim impressions As Impressions
        Try
            BTImprimirGCODE.Rows.Clear()
            listaImpressions = SQLCommand.SelectAllImpressionsFromDatabase(Globals.userCredentials.GetSetBaseDades)

            For Each impressions In listaImpressions
                BTImprimirGCODE.Rows.Add(impressions.GetSetNomGcode, impressions.GetSetNumeroCopia, impressions.GetSetCodiImpresora, impressions.GetSetOrdreImpressio, impressions.GetSetEstat, impressions.GetSetNickname)
            Next impressions
        Catch ex As Exception

        End Try
    End Sub
End Class