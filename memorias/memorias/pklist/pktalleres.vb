Public Class pktalleres
    Public idtallerres

    Private Sub TallerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TallerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TallerBindingSource.EndEdit()
        Me.TallerTableAdapter.Update(Me.Dtset.taller)

    End Sub

    Private Sub pktalleres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.taller' table. You can move, or remove it, as needed.
        Me.TallerTableAdapter.FillBylike(Me.Dtset.taller, "%" + "" + "%")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.TallerTableAdapter.FillBylike(Me.Dtset.taller, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.TallerBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Talleres")
        Else
            idtallerres = Me.TallerDataGridView.Item(0, Me.TallerDataGridView.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class