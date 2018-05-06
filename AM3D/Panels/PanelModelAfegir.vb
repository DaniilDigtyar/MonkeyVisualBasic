Public Class PanelModelAfegir
    Private Sub BTBorrar_Click(sender As Object, e As EventArgs) Handles BTBorrar.Click
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
        'NOSE BORRAR ELS CHECKLISTS
        'CBLMaterialSup

    End Sub
End Class