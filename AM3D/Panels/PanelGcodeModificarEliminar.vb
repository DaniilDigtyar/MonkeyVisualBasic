Public Class PanelGcodeModificarEliminar
    Dim SQLCommands As SQLCommands = New SQLCommands()
    Public gcodeSeleccionat As Gcode = New Gcode("", "", "")

    Private Sub BTModificarGcode_Click(sender As Object, e As EventArgs) Handles BTModificarGcode.Click
        gcodeSeleccionat = New Gcode(DGGcode.SelectedRows.Item(0).Cells(0).Value, DGGcode.SelectedRows.Item(0).Cells(1).Value, DGGcode.SelectedRows.Item(0).Cells(2).Value)
        ModificarGcode.Show()
    End Sub

    Private Sub PanelGcodeModificarEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaGcodes As HashSet(Of Gcode) = New HashSet(Of Gcode)
        Dim gcodeObject As Gcode

        DGGcode.Rows.Clear()
        listaGcodes = SQLCommands.SelectAllGcodesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each gcodeObject In listaGcodes
            DGGcode.Rows.Add(gcodeObject.GetSetNomGcode, gcodeObject.GetSetTipusMaterialSuportat, gcodeObject.GetSetNicknameCreador)
        Next gcodeObject
    End Sub

    Private Sub BResfrescar_Click(sender As Object, e As EventArgs) Handles BResfrescar.Click
        Dim listaGcodes As HashSet(Of Gcode) = New HashSet(Of Gcode)
        Dim gcodeObject As Gcode

        DGGcode.Rows.Clear()
        listaGcodes = SQLCommands.SelectAllGcodesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each gcodeObject In listaGcodes
            DGGcode.Rows.Add(gcodeObject.GetSetNomGcode, gcodeObject.GetSetTipusMaterialSuportat, gcodeObject.GetSetNicknameCreador)
        Next gcodeObject
    End Sub

    Private Sub BTEliminarGcode_Click(sender As Object, e As EventArgs) Handles BTEliminarGcode.Click
        Dim gcodeObject As Gcode
        Dim indice As Integer
        Dim afectat As Integer = 0

        gcodeObject = New Gcode(DGGcode.SelectedRows.Item(0).Cells(0).Value, DGGcode.SelectedRows.Item(0).Cells(1).Value, DGGcode.SelectedRows.Item(0).Cells(2).Value)
        afectat = SQLCommands.DeleteGcodeFromDatabaseWhereGcode(Globals.userCredentials.GetSetBaseDades, gcodeObject)
        If afectat > 0 Then
            indice = DGGcode.SelectedRows.Item(0).Index
            DGGcode.Rows.RemoveAt(indice)
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGDeleteCorrect)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGDeleteCorrect)
            End If
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.MSGDeleteError)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.MSGDeleteError)
            End If
        End If
    End Sub
End Class