Public Class pkgeneral
    Public idgene As Integer

    Private Sub GeneralBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GeneralBindingSource.EndEdit()
        Me.GeneralTableAdapter.Update(Me.Dtset.general)

    End Sub

    Private Sub pkgeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.general' table. You can move, or remove it, as needed.
        Me.GeneralTableAdapter.FillBylike(Me.Dtset.general, "%" + "" + "%")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.GeneralTableAdapter.FillBylike(Me.Dtset.general, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.GeneralBindingSource.Count = 0 Then
            MsgBox("No hay elementos en la lista", MsgBoxStyle.Exclamation, "General")
        Else
            idgene = Me.GeneralDataGridView.Item(0, Me.GeneralDataGridView.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class