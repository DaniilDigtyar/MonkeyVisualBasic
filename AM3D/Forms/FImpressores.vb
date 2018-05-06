Public Class FImpressores
    Private Sub BTConnectar_Click(sender As Object, e As EventArgs) Handles BTConnectar.Click
        PanelLlistaImpressores.Close()
        PanelConnectarNovaImpressora.TopLevel = False
        PImpressores.Controls.Add(PanelConnectarNovaImpressora)
        PanelConnectarNovaImpressora.Show()
    End Sub

    Private Sub BTLlista_Click(sender As Object, e As EventArgs) Handles BTLlista.Click
        PanelConnectarNovaImpressora.Close()
        PanelLlistaImpressores.TopLevel = False
        PImpressores.Controls.Add(PanelLlistaImpressores)
        PanelLlistaImpressores.Show()
    End Sub
End Class