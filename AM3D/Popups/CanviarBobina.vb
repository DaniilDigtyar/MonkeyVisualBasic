Public Class CanviarBobina
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point
    Dim SQLCommands As SQLCommands = New SQLCommands()

    Private Sub BTCanviarCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Me.Close()
    End Sub

    Private Sub CanviarBobina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaBobines As HashSet(Of Bobines) = New HashSet(Of Bobines)
        Dim bobina As Bobines
        Dim indice As Integer
        Dim listaImpressores As HashSet(Of Impressores) = New HashSet(Of Impressores)
        Dim impressores As Impressores

        listaBobines = SQLCommands.SelectAllBobinesFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaImpressores = SQLCommands.SelectAllPrintersFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each impressores In listaImpressores
            CBImpressora.Items.Add(impressores.GetSetCodiImpressora)
        Next impressores
        For Each bobina In listaBobines
            DataGridViewBobina.Rows.Add(bobina.GetSetCodiBobina, bobina.GetSetTipusMaterial, bobina.GetSetColor, bobina.GetSetMarcaProductora, bobina.GetSetDiametre)
        Next bobina

        For i As Integer = 0 To DataGridViewBobina.Rows.Count - 1
            If (DataGridViewBobina.Rows(i).Cells(0).Value.ToString.Equals(PanelLlistaImpressores.bobinaSeleccionada)) Then
                indice = DataGridViewBobina.Rows(i).Index
            End If
        Next i

        DataGridViewBobina.Rows(indice).Selected = True
        CBImpressora.Text = PanelLlistaImpressores.impresoraSeleccionada
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

    Private Sub BTCanviar_Click(sender As Object, e As EventArgs) Handles BTCanviar.Click
        SQLCommands.UpdatePrinterCoilIntoDatabase(Globals.userCredentials.GetSetBaseDades, DataGridViewBobina.SelectedRows.Item(0).Cells(0).Value.ToString, CBImpressora.SelectedItem.ToString)
        Me.Close()
    End Sub
End Class