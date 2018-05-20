Public Class ModificarModel
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point
    Dim SQLCommands As New SQLCommands()

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

    Private Sub ModificarModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TBTempMaxEx_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTempMaxEx.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBTempMinExt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTempMinExt.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBTempMaxLlit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTempMaxLlit.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBTempMinLlit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTempMinLlit.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBAImpX_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBAImpX.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBAImpY_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBAImpY.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBImpZ_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBImpZ.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBVelMinExt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBVelMinExt.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBResMinCap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBResMinCap.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBResMaxCap_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBResMaxCap.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub TBDiametre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBDiametre.KeyPress
        If Asc(e.KeyChar) <> 13 AndAlso Asc(e.KeyChar) <> 8 AndAlso Not IsNumeric(e.KeyChar) AndAlso e.KeyChar <> "," Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTModificar_Click(sender As Object, e As EventArgs) Handles BTModificar.Click
        Dim modelObjeto As Models
        Dim modelCambiar As Models
        Dim caracteristicasObjeto As Caracteristiques
        Dim afectat As Integer
        If TBModel.Text <> "" And CBMarca.SelectedIndex <> -1 Then
            modelObjeto = New Models(CBMarca.SelectedItem.ToString, TBModel.Text)
            modelCambiar = New Models(PanelModelModificarEliminar.caracteristicaSeleccionada.GetSetMarca, PanelModelModificarEliminar.caracteristicaSeleccionada.GetSetModel)
            caracteristicasObjeto = New Caracteristiques(CBMarca.SelectedItem.ToString, TBModel.Text, TBExtrusors.Text, TBTempMinExt.Text, TBTempMaxEx.Text, TBTempMinLlit.Text, TBTempMaxLlit.Text, TBAImpX.Text, TBAImpY.Text, TBImpZ.Text, TBVelMinExt.Text, TBResMaxCap.Text, TBResMinCap.Text, TBDiametre.Text)

            afectat = SQLCommands.UpdateModelIntoDatabase(Globals.userCredentials.GetSetBaseDades, modelObjeto, modelCambiar)
            If afectat > 0 Then
                afectat = SQLCommands.UpdateCaracteristiquesIntoDatabase(Globals.userCredentials.GetSetBaseDades, caracteristicasObjeto, modelCambiar)
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