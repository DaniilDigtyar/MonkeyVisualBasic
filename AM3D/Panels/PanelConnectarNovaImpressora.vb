Public Class PanelConnectarNovaImpressora
    Private Sub BTImpressoraCancelar_Click(sender As Object, e As EventArgs) Handles BTImpressoraBorrar.Click
        TBNomImpressora.Text = ""
        CBMarca.Text = ""
        CBModel.Text = ""
    End Sub
End Class