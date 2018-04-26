Public Class FUsuaris
    Private Sub BTConnectar_Click(sender As Object, e As EventArgs) Handles BTConnectar.Click
        PanelModificarEliminarUsuaris.Hide()
        PanelUsuarisAfegir.TopLevel = False
        PUsuaris.Controls.Add(PanelUsuarisAfegir)
        PanelUsuarisAfegir.Show()
    End Sub

    Private Sub BTLlista_Click(sender As Object, e As EventArgs) Handles BTLlista.Click
        PanelUsuarisAfegir.Hide()
        PanelModificarEliminarUsuaris.TopLevel = False
        PUsuaris.Controls.Add(PanelModificarEliminarUsuaris)
        PanelModificarEliminarUsuaris.Show()
    End Sub
End Class