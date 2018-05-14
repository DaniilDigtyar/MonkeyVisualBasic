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
        Dim listaMaterial As HashSet(Of Materials) = New HashSet(Of Materials)
        Dim material As Materials
        Dim indice As Integer = 0

        listaMaterial = SQLCommands.SelectAllMaterialsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each material In listaMaterial
            DGMaterial.Rows.Add(material.GetSetTipusMaterial, material.GetSetDescripcio)
        Next material

        Dim listaMarques As HashSet(Of MarquesBobines) = New HashSet(Of MarquesBobines)
        Dim marcaBobina As MarquesBobines

        listaMarques = SQLCommands.SelectAllMarcasBobinasFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each marcaBobina In listaMarques
            DGMarcaProductora.Rows.Add(marcaBobina.GetSetMarcaProductora)
        Next marcaBobina

        Dim listaColores As HashSet(Of Colors) = New HashSet(Of Colors)
        Dim colorObjeto As Colors

        listaColores = SQLCommands.SelectAllColorsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each colorObjeto In listaColores
            DGColor.Rows.Add(colorObjeto.GetSetColor, colorObjeto.GetSetHex)
            DGColor.Rows(DGColor.Rows.Count - 1).Cells(2).Style.BackColor = Interaction.ConvertToRBG(colorObjeto.GetSetHex)
        Next colorObjeto

        For i As Integer = 0 To DGMaterial.Rows.Count - 1
            If (DGMaterial.Rows(i).Cells(0).Value.ToString.Equals(PanelBobinesBobinaModificarEliminar.bobinaSeleccionada.GetSetTipusMaterial)) Then
                indice = DGMaterial.Rows(i).Index
            End If
        Next i
        DGMaterial.Rows(indice).Selected = True
        indice = 0

        For i As Integer = 0 To DGColor.Rows.Count - 1
            If (DGColor.Rows(i).Cells(0).Value.ToString.Equals(PanelBobinesBobinaModificarEliminar.bobinaSeleccionada.GetSetColor)) Then
                indice = DGColor.Rows(i).Index
            End If
        Next i
        DGColor.Rows(indice).Selected = True
        indice = 0

        For i As Integer = 0 To DGMarcaProductora.Rows.Count - 1
            If (DGMarcaProductora.Rows(i).Cells(0).Value.ToString.Equals(PanelBobinesBobinaModificarEliminar.bobinaSeleccionada.GetSetMarcaProductora)) Then
                indice = DGMarcaProductora.Rows(i).Index
            End If
        Next i
        DGMarcaProductora.Rows(indice).Selected = True


        TBDiametre.Text = PanelBobinesBobinaModificarEliminar.bobinaSeleccionada.GetSetDiametre
    End Sub

    Private Sub BTCancelar_Click_1(sender As Object, e As EventArgs) Handles BTCancelar.Click
        Me.Close()
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
                Me.Close()
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