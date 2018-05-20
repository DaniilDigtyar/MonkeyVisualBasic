Public Class PanelModelAfegir
    Dim SQLCommands As New SQLCommands()

    Private Sub BTBorrar_Click(sender As Object, e As EventArgs) Handles BTBorrar.Click
        Dim listaMaterials As HashSet(Of Materials) = New HashSet(Of Materials)
        Dim listaMarca As HashSet(Of Marca) = New HashSet(Of Marca)
        Dim material As Materials
        Dim marca As Marca

        listaMarca = SQLCommands.SelectAllMarquesFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaMaterials = SQLCommands.SelectAllMaterialsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        CBMarca.Items.Clear()

        For Each marca In listaMarca
            CBMarca.Items.Add(marca.GetSetMarca)
        Next marca

        DGMaterial.Rows.Clear()

        For Each material In listaMaterials
            DGMaterial.Rows.Add(material.GetSetTipusMaterial, material.GetSetDescripcio)
        Next material

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
        TBVelMaxExt.Text = ""
        TBResMinCap.Text = ""
        TBResMaxCap.Text = ""
        TBDiametre.Text = ""
        'NOSE BORRAR ELS CHECKLISTS
        'CBLMaterialSup

    End Sub

    Private Sub PanelModelAfegir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaMaterials As HashSet(Of Materials) = New HashSet(Of Materials)
        Dim listaMarca As HashSet(Of Marca) = New HashSet(Of Marca)
        Dim material As Materials
        Dim marca As Marca

        listaMarca = SQLCommands.SelectAllMarquesFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaMaterials = SQLCommands.SelectAllMaterialsFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each marca In listaMarca
            CBMarca.Items.Add(marca.GetSetMarca)
        Next marca

        For Each material In listaMaterials
            DGMaterial.Rows.Add(material.GetSetTipusMaterial, material.GetSetDescripcio)
        Next material
    End Sub

    Private Sub BTAfegir_Click(sender As Object, e As EventArgs) Handles BTAfegir.Click
        Dim afectat As Integer
        Dim model As Models
        Dim caracteristiques As Caracteristiques
        If TBModel.Text <> "" And CBMarca.SelectedIndex <> -1 Then
            model = New Models(CBMarca.SelectedItem.ToString, TBModel.Text)
            caracteristiques = New Caracteristiques(CBMarca.SelectedItem.ToString, TBModel.Text, Double.Parse(TBExtrusors.Text), Double.Parse(TBTempMinExt.Text), Double.Parse(TBTempMaxEx.Text), Double.Parse(TBTempMinLlit.Text), Double.Parse(TBTempMaxLlit.Text), Double.Parse(TBAImpX.Text), Double.Parse(TBAImpY.Text), Double.Parse(TBImpZ.Text), Double.Parse(TBVelMaxExt.Text), Double.Parse(TBResMaxCap.Text), Double.Parse(TBResMinCap.Text), Double.Parse(TBDiametre.Text))
            afectat = SQLCommands.InsertModelIntoDatabase(Globals.userCredentials.GetSetBaseDades, model)
            If afectat > 0 Then
                afectat = SQLCommands.InsertCaracteristiquesIntoDatabase(Globals.userCredentials.GetSetBaseDades, caracteristiques)
                If afectat > 0 Then
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.MSGInsertCorrecto)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.MSGInsertCorrecto)
                    End If
                Else
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.MSGInsertIncorrecto)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.MSGInsertIncorrecto)
                    End If
                End If
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
                TBVelMaxExt.Text = ""
                TBResMinCap.Text = ""
                TBResMaxCap.Text = ""
                TBDiametre.Text = ""
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

    Private Sub TBVelMaxExt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBVelMaxExt.KeyPress
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
End Class