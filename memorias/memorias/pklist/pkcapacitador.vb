Public Class pkcapacitador
    Public idcapac As Integer

    Private Sub CapacitadoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapacitadoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CapacitadoresBindingSource.EndEdit()
        Me.CapacitadoresTableAdapter.Update(Me.Dtset.capacitadores)

    End Sub

    Private Sub pkcapacitador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.capacitadores' table. You can move, or remove it, as needed.
        Me.CapacitadoresTableAdapter.FillByname(Me.Dtset.capacitadores, "%" + "" + "%")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.CapacitadoresTableAdapter.FillByname(Me.Dtset.capacitadores, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.CapacitadoresBindingSource.Count = 0 Then
            MsgBox("La Lista esta Vacia")
        Else
            idcapac = Me.CapacitadoresDataGridView.Item(0, Me.CapacitadoresDataGridView.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class