Public Class PanelUsuarisAfegir
    Private Sub BTEsborrar_Click(sender As Object, e As EventArgs) Handles BTEsborrar.Click
        TBNickname.Text = ""
        TBNom.Text = ""
        TBCongnom.Text = ""
        TBContrasenya.Text = ""
        TBRContrasenya.Text = ""
        TBCorreu.Text = ""
        'NOSE BORRAR ELS CHECLIKST
        'CLBPermisos
    End Sub
End Class