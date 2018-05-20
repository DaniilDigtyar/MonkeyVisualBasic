Public Class ModificarBobinesBobina
    Dim SQLCommands As SQLCommands = New SQLCommands()
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

    Private Sub ModificarBobinesBobina_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BTCancelar_Click_1(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Me.Hide()
        TBDiametre.Text = ""
        LabelInfo.Text = ""
    End Sub

    Private Sub BTAfegir_Click(sender As Object, e As EventArgs) Handles BTAfegir.Click
        Dim bobina As Bobines
        Dim afectat As Integer
        Dim codiBobina = PanelBobinesBobinaModificarEliminar.bobinaSeleccionada.GetSetCodiBobina
        If TBDiametre.Text <> "" Then
            bobina = New Bobines(codiBobina, DGMaterial.SelectedRows(0).Cells(0).Value, DGColor.SelectedRows(0).Cells(0).Value, DGMarcaProductora.SelectedRows(0).Cells(0).Value, TBDiametre.Text)
            afectat = SQLCommands.UpdateBobinaIntoDatabase(Globals.userCredentials.GetSetBaseDades, bobina)
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

    Private Sub TBDiametre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDiametre.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub
End Class