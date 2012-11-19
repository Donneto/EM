Public Class pkregiones
    Public idregii

    Private Sub RegionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegionBindingSource.EndEdit()
        Me.RegionTableAdapter.Update(Me.Dtset._region)

    End Sub

    Private Sub pkregiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset._region' table. You can move, or remove it, as needed.
        Me.RegionTableAdapter.Fill(Me.Dtset._region)

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.RegionBindingSource.Count = 0 Then
            MsgBox("Lista vacia", MsgBoxStyle.Exclamation, "Regiones")
        Else
            idregii = Me.RegionDataGridView.Item(0, Me.RegionDataGridView.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class