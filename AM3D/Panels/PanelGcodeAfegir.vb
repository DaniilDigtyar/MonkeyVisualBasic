Public Class PanelGcodeAfegir
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Private Sub BTBorrar_Click(sender As Object, e As EventArgs) Handles BTBorrar.Click
        TBNomGcode.Text = ""
        TBRuta.Text = ""
    End Sub

    Private Sub TBRuta_Click(sender As Object, e As EventArgs) Handles TBRuta.Click
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
        Dim path As String
        openFileDialog.Filter = "Gcode file|*.gcode"
        openFileDialog.Title = "Obrir Gcode."
        openFileDialog.ShowDialog()
        path = openFileDialog.FileName
        TBRuta.Text = path
        TBNomGcode.Text = openFileDialog.SafeFileName.Substring(0, openFileDialog.SafeFileName.Length - 6)
    End Sub

    Private Sub BTAfegir_Click(sender As Object, e As EventArgs) Handles BTAfegir.Click

    End Sub

    Private Sub PanelGcodeAfegir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaMaterial As HashSet(Of Materials) = New HashSet(Of Materials)
        Dim material As Materials

        listaMaterial = SQLCommands.SelectAllMaterialsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each material In listaMaterial
            DGMaterial.Rows.Add(material.GetSetTipusMaterial, material.GetSetDescripcio)
        Next material
    End Sub
End Class