Public Class pktipotaller
    Public idpktipotaller As Integer

    Private Sub Tipo_tallerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tipo_tallerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tipo_tallerBindingSource.EndEdit()
        Me.Tipo_tallerTableAdapter.Update(Me.Dtset.tipo_taller)

    End Sub

    Private Sub pktipotaller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.tipo_taller' table. You can move, or remove it, as needed.
        Me.Tipo_tallerTableAdapter.Fill(Me.Dtset.tipo_taller)

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        idpktipotaller = Me.Tipo_tallerDataGridView.Item(0, Me.Tipo_tallerDataGridView.CurrentRow.Index).Value
        Me.Close()

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class