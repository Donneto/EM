Public Class pkmovpolitico
    Public idmov

    Private Sub Mov_politicoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mov_politicoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Mov_politicoBindingSource.EndEdit()
        Me.Mov_politicoTableAdapter.Update(Me.Dtset.mov_politico)

    End Sub

    Private Sub pkmovpolitico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.mov_politico' table. You can move, or remove it, as needed.
        'Me.Mov_politicoTableAdapter.Fill(Me.Dtset.mov_politico)
        Me.Mov_politicoTableAdapter.FillBylike(Me.Dtset.mov_politico, "%" + "" + "%")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.Mov_politicoTableAdapter.FillBylike(Me.Dtset.mov_politico, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.Mov_politicoBindingSource.Count = 0 Then
            MsgBox("No hay Elementos en la Lista", MsgBoxStyle.Exclamation, "Movimiento Politico")
        Else
            idmov = Me.Mov_politicoDataGridView.Item(0, Me.Mov_politicoDataGridView.CurrentRow.Index).Value
            Me.Close()

        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class