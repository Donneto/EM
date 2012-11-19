Public Class pkparticipante
    Public idpart

    Private Sub ParticipantesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParticipantesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ParticipantesBindingSource.EndEdit()
        Me.ParticipantesTableAdapter.Update(Me.Dtset.participantes)

    End Sub

    Private Sub pkparticipante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.participantes' table. You can move, or remove it, as needed.
        Me.ParticipantesTableAdapter.FillByname(Me.Dtset.participantes, "%" + "" + "%")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.ParticipantesTableAdapter.FillByname(Me.Dtset.participantes, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.ParticipantesBindingSource.Count = 0 Then
            MsgBox("La  Lista  Esta  Vacia", MsgBoxStyle.Exclamation, "Participantes")
        Else
            idpart = Me.ParticipantesDataGridView.Item(0, Me.ParticipantesDataGridView.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class