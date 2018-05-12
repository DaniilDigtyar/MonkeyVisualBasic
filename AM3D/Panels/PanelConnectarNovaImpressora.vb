Public Class PanelConnectarNovaImpressora
    Dim SQLCommands As SQLCommands = New SQLCommands()

    ''' <summary>
    ''' En cargar el panel cargara el combobox marca y el datagridview de bobina
    ''' </summary>
    ''' <param name="e"></param>
    Protected Overrides Sub OnLoad(e As EventArgs)
        Dim listaBobines As HashSet(Of Bobines) = New HashSet(Of Bobines)
        Dim listaMarca As HashSet(Of Marca) = New HashSet(Of Marca)
        Dim bobina As Bobines
        Dim marca As Marca

        listaMarca = SQLCommands.SelectAllMarquesFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaBobines = SQLCommands.SelectAllBobinesFromDatabase(Globals.userCredentials.GetSetBaseDades)

        For Each marca In listaMarca
            CBMarca.Items.Add(marca.GetSetMarca)
        Next marca

        For Each bobina In listaBobines
            DataGridViewBobina.Rows.Add(bobina.GetSetCodiBobina, bobina.GetSetTipusMaterial, bobina.GetSetColor, bobina.GetSetMarcaProductora, bobina.GetSetDiametre)
        Next bobina
    End Sub

    ''' <summary>
    ''' Reinicia el formulario a el estado original
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTImpressoraCancelar_Click(sender As Object, e As EventArgs) Handles BTImpressoraBorrar.Click
        TBNomImpressora.Text = ""
        CBMarca.SelectedIndex = -1
        CBModel.SelectedIndex = -1
        CBModel.Enabled = False
    End Sub

    ''' <summary>
    ''' Añade una nueva impressora a la base de datos y reinicia el formulario.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BTImpressoraGuardar_Click(sender As Object, e As EventArgs) Handles BTImpressoraGuardar.Click
        Dim impressora As Impressores
        Dim codi As String
        Dim bobina As String
        Dim afectat As Integer
        If CBModel.SelectedIndex <> -1 And CBMarca.SelectedIndex <> -1 And TBNomImpressora.Text IsNot "" Then
            Try
                codi = SQLCommands.SelectNewPrinterCode(Globals.userCredentials.GetSetBaseDades)
                bobina = DataGridViewBobina.SelectedRows.Item(0).Cells(0).Value
                impressora = New Impressores(codi, TBNomImpressora.Text, "CONNECTED", CBMarca.SelectedItem.ToString, CBModel.SelectedItem.ToString, bobina)
                afectat = SQLCommands.InsertPrinterIntoDatabase(Globals.userCredentials.GetSetBaseDades, impressora)
                TBNomImpressora.Text = ""
                CBMarca.SelectedIndex = -1
                CBModel.SelectedIndex = -1
                CBModel.Enabled = False
                If afectat > 0 Then
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.LabelnfoCorrecte)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.LabelnfoCorrecte)
                    End If
                Else
                    If Globals.lang = "cat" Then
                        MenuPrincipal.showMSG(My.Resources.cat.LabelnfoError)
                    Else
                        MenuPrincipal.showMSG(My.Resources.eng.LabelnfoError)
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            If Globals.lang = "cat" Then
                MenuPrincipal.showMSG(My.Resources.cat.LabelnfoNoSelect)
            Else
                MenuPrincipal.showMSG(My.Resources.eng.LabelnfoNoSelect)
            End If
        End If

    End Sub

    ''' <summary>
    ''' Rellena automaticamente el cobobox de modelos dependiendo de la marca de impresora selecionada.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CBMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMarca.SelectedIndexChanged
        Dim model As Models
        Dim marca As Object
        Dim listaModels As HashSet(Of Models) = New HashSet(Of Models)
        Try
            If CBMarca.SelectedIndex <> -1 Then
                marca = CBMarca.SelectedItem
                CBModel.Items.Clear()
                CBModel.SelectedIndex = -1
                CBModel.Enabled = True
                listaModels = SQLCommands.SelectAllModelsFromDatabaseWhere(Globals.userCredentials.GetSetBaseDades, marca.ToString())
                For Each model In listaModels
                    CBModel.Items.Add(model.GetSetModel)
                Next model

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class