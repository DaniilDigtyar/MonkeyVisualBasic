Public Class FCambIdiom
    Private Sub BTCatala_Click(sender As Object, e As EventArgs) Handles BTCatala.Click
        globals.lang = "cat"
        Language.setLang()
    End Sub

    Private Sub BTIngles_Click(sender As Object, e As EventArgs) Handles BTIngles.Click
        globals.lang = "eng"
        Language.setLang()
    End Sub
End Class