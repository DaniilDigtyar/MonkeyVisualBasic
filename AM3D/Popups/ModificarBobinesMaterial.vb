Public Class ModificarBobinesMaterial
    Dim SQLCommands As SQLCommands = New SQLCommands()

    Private Sub BTBorrar_Click(sender As Object, e As EventArgs) Handles BTBorrar.Click
        Me.Hide()
        TBTecnic.Text = ""
        TBMaterial.Text = ""
    End Sub
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point
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

    Private Sub ModificarBobinesMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTModificar_Click(sender As Object, e As EventArgs) Handles BTModificar.Click
        Dim tipoMaterial As String
        Dim material As Materials
        Dim afectat As Integer
        If TBTecnic.Text <> "" And TBMaterial.Text <> "" Then
            material = New Materials(TBMaterial.Text, TBTecnic.Text)
            afectat = SQLCommands.UpdateMaterialIntoDatabase(Globals.userCredentials.GetSetBaseDades, material, PanelBobinesMaterialModificarEliminar.materialSeleccionat.GetSetTipusMaterial)
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