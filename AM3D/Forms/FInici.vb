Public Class FInici
    Protected Overrides Sub OnLoad(e As EventArgs)
        LabelNomUsuari.Text = Globals.userCredentials.GetSetNickname
    End Sub
End Class