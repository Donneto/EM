Public Class pkdepto
    Public iddepto As Integer
    Private Sub DeptoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeptoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DeptoBindingSource.EndEdit()
        Me.DeptoTableAdapter.Update(Me.Dtset.depto)

    End Sub

    Private Sub pkdepto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.depto' table. You can move, or remove it, as needed.
        Me.DeptoTableAdapter.FillBylike(Me.Dtset.depto, "%" + "" + "%")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.DeptoTableAdapter.FillBylike(Me.Dtset.depto, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.DeptoBindingSource.Count = 0 Then
            MsgBox("No hay elementos en la lista", MsgBoxStyle.Exclamation, "Departamentos")
        Else
            iddepto = Me.DeptoDataGridView.Item(0, Me.DeptoDataGridView.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class