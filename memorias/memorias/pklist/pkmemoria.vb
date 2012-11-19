Public Class pkmemoria
    Public idmemory


    Private Sub MemoriasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoriasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MemoriasBindingSource.EndEdit()
        Me.MemoriasTableAdapter.Update(Me.Dtset.memorias)

    End Sub

    Private Sub pkmemoria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.memorias' table. You can move, or remove it, as needed.
        Me.MemoriasTableAdapter.FillBylike(Me.Dtset.memorias, "%" + "" + "%")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.MemoriasTableAdapter.FillBylike(Me.Dtset.memorias, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.MemoriasBindingSource.Count = 0 Then
            MsgBox("No hay elementos en la lista", MsgBoxStyle.Exclamation, "Memorias")
        Else
            idmemory = Me.MemoriasDataGridView.Item(0, Me.MemoriasDataGridView.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub

    
    Private Sub MemoriasDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MemoriasDataGridView.DoubleClick
        AceptarToolStripMenuItem_Click(sender, e)
    End Sub
End Class