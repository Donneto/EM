Public Class pkmuni
    Public idmun As Integer

    Private Sub MunicipioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MunicipioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MunicipioBindingSource.EndEdit()
        Me.MunicipioTableAdapter.Update(Me.Dtset.municipio)

    End Sub

    Private Sub pkmuni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.municipio' table. You can move, or remove it, as needed.
        Me.MunicipioTableAdapter.FillBylike(Me.Dtset.municipio, "%" + "" + "%")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.MunicipioTableAdapter.FillBylike(Me.Dtset.municipio, "%" + TextBox1.Text + "%")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.MunicipioBindingSource.Count = 0 Then
            MsgBox("No hay elementos en la lista", MsgBoxStyle.Exclamation, "Municipios")
        Else
            idmun = Me.MunicipioDataGridView.Item(0, Me.MunicipioDataGridView.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class