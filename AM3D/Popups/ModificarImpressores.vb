Public Class ModificarImpressores
    Dim allowCoolMove As Boolean = False
    Dim myCoolPoint As New Point
    Dim SQLCommands As New SQLCommands



    Private Sub ModificarImpressores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim listaModels As HashSet(Of Models) = New HashSet(Of Models)
        Dim listaMarca As HashSet(Of Marca) = New HashSet(Of Marca)
        Dim models As Models
        Dim marca As Marca

        listaMarca = SQLCommands.SelectAllMarquesFromDatabase(Globals.userCredentials.GetSetBaseDades)
        listaModels = SQLCommands.SelectAllModelsFromDatabaseWhere(Globals.userCredentials.GetSetBaseDades, PanelLlistaImpressores.marcaSeleccionada)
        For Each models In listaModels
            CBModel.Items.Add(models.GetSetModel)
        Next models
        For Each marca In listaMarca
            CBMarca.Items.Add(marca.GetSetMarca)
        Next marca

        CBMarca.Text = PanelLlistaImpressores.marcaSeleccionada
        CBModel.Text = PanelLlistaImpressores.modelSeleccionada
        TBNomImpressora.Text = PanelLlistaImpressores.nomSeleccionada
    End Sub


    Private Sub BTCancelar_Click(sender As Object, e As EventArgs) Handles BTCancelar.Click

        TBNomImpressora.Text = ""
        CBMarca.SelectedIndex = -1
        CBModel.SelectedIndex = -1
        CBModel.Enabled = False
        Labelnfo.Visible = False
        Me.Close()
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

    Private Sub BTImpressoraGuardar_Click(sender As Object, e As EventArgs) Handles BTImpressoraGuardar.Click
        Dim afectat As Integer
        Dim codi As String
        Dim marca As String
        Dim model As String
        Dim nom As String
        If CBModel.SelectedIndex <> -1 And CBMarca.SelectedIndex <> -1 And TBNomImpressora IsNot vbNullString Then
            Try
                codi = PanelLlistaImpressores.impresoraSeleccionada
                marca = CBMarca.SelectedItem.ToString
                model = CBModel.SelectedItem.ToString
                nom = TBNomImpressora.Text.ToString

                afectat = SQLCommands.UpdatePrinterInfoIntoDatabase(Globals.userCredentials.GetSetBaseDades, codi, marca, model, nom)
                If afectat > 0 Then
                    If Globals.lang = "cat" Then
                        Labelnfo.Text = My.Resources.cat.LabelnfoCorrecte
                    Else
                        Labelnfo.Text = My.Resources.eng.LabelnfoCorrecte
                    End If
                    Me.Close()
                Else
                    If Globals.lang = "cat" Then
                        Labelnfo.Text = My.Resources.cat.LabelnfoError
                    Else
                        Labelnfo.Text = My.Resources.eng.LabelnfoError
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            Labelnfo.Visible = True
            If Globals.lang = "cat" Then
                Labelnfo.Text = My.Resources.cat.LabelnfoNoSelect
            Else
                Labelnfo.Text = My.Resources.eng.LabelnfoNoSelect
            End If
        End If
    End Sub

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