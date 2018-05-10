Public Class FImpressores
    Private Sub BTConnectar_Click(sender As Object, e As EventArgs) Handles BTConnectar.Click
        PanelLlistaImpressores.Hide()
        PanelConnectarNovaImpressora.TopLevel = False
        PImpressores.Controls.Add(PanelConnectarNovaImpressora)
        PanelConnectarNovaImpressora.Show()
    End Sub

    Private Sub BTLlista_Click(sender As Object, e As EventArgs) Handles BTLlista.Click
        PanelConnectarNovaImpressora.Hide()
        PanelLlistaImpressores.TopLevel = False
        PImpressores.Controls.Add(PanelLlistaImpressores)
        PanelLlistaImpressores.Show()
    End Sub
End Class