Public Class ModificarGcode
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point
    Dim SQLCommands As New SQLCommands()

    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Me.Hide()
        TBNomGcode.Text = ""
        TBRuta.Text = ""
    End Sub

    Private Sub MenuSup_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuSup.MouseDown
        allowCoolMove = True
        myCoolPoint = New Point(e.X, e.Y)
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub MenuSup_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuSup.MouseMove
        If allowCoolMove = True Then
            Me.Location = New Point(Me.Location.X + e.X - myCoolPoint.X, Me.Location.Y + e.Y - myCoolPoint.Y)
        End If
    End Sub

    Private Sub MenuSup_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MenuSup.MouseUp
        allowCoolMove = False
        Me.Cursor = Cursors.Default
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

    Private Sub ModificarGcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTModificar_Click(sender As Object, e As EventArgs) Handles BTModificar.Click
        Dim gcodeNombre As String
        Dim gcodeObjeto As Gcode
        Dim afectat As Integer
        If TBNomGcode.Text <> "" Then
            gcodeObjeto = New Gcode(TBNomGcode.Text, DGMaterial.SelectedRows.Item(0).Cells(0).Value, Globals.userCredentials.GetSetNickname)
            afectat = SQLCommands.UpdateGcodeIntoDatabase(Globals.userCredentials.GetSetBaseDades, gcodeObjeto, PanelGcodeModificarEliminar.gcodeSeleccionat.GetSetNomGcode)
            If afectat > 0 Then
                If Globals.lang = "cat" Then
                    LabelInfo.Text = My.Resources.cat.LabelnfoCorrecte
                Else
                    LabelInfo.Text = My.Resources.eng.LabelnfoCorrecte
                End If
                Me.Hide()
            Else
                If Globals.lang = "cat" Then
                    LabelInfo.Text = My.Resources.cat.LabelnfoError
                Else
                    LabelInfo.Text = My.Resources.eng.LabelnfoError
                End If
            End If
        Else
            If Globals.lang = "cat" Then
                LabelInfo.Text = My.Resources.cat.MSGRellenarError
            Else
                LabelInfo.Text = My.Resources.eng.MSGRellenarError
            End If
        End If
    End Sub
End Class