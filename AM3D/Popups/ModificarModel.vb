Public Class ModificarModel
    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Me.Hide()
        TBModel.Text = ""
        CBMarca.Text = ""
        TBExtrusors.Text = ""
        TBTempMaxEx.Text = ""
        TBTempMinExt.Text = ""
        TBTempMaxLlit.Text = ""
        TBTempMinLlit.Text = ""
        TBImpZ.Text = ""
        TBAImpY.Text = ""
        TBAImpX.Text = ""
        TBVelMinExt.Text = ""
        TBResMinCap.Text = ""
        TBResMaxCap.Text = ""
        TBDiametre.Text = ""
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
End Class