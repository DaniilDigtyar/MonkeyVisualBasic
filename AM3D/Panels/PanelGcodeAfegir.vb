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
        Dim afectat As Integer
        Dim gcode As Gcode
        If TBRuta.Text <> "" And TBNomGcode.Text <> "" Then
            gcode = New Gcode(TBNomGcode.Text, DGMaterial.SelectedRows(0).Cells(0).Value, Globals.userCredentials.GetSetNickname)
            afectat = SQLCommands.InsertGcodeIntoDatabase(Globals.userCredentials.GetSetBaseDades, gcode)
            If afectat > 0 Then
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGInsertCorrecto)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGInsertCorrecto)
                End If
                TBRuta.Text = ""
                TBNomGcode.Text = ""
            Else
                If Globals.lang = "cat" Then
                    MenuPrincipal.showMSG(My.Resources.cat.MSGInsertIncorrecto)
                Else
                    MenuPrincipal.showMSG(My.Resources.eng.MSGInsertIncorrecto)
                End If
            End If
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGRellenarError)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGRellenarError)
            End If
        End If
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