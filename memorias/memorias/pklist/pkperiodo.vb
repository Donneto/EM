Public Class pkperiodo
    Public idper

    Private Sub PeriodoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PeriodoBindingSource.EndEdit()
        Me.PeriodoTableAdapter.Update(Me.Dtset.periodo)

    End Sub

    Private Sub pkperiodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.periodo' table. You can move, or remove it, as needed.
        Me.PeriodoTableAdapter.Fill(Me.Dtset.periodo)

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.PeriodoBindingSource.Count = 0 Then
            MsgBox("La lista se encuentra vacia", MsgBoxStyle.Exclamation, "Periodo")
        Else
            idper = Me.PeriodoDataGridView.Item(0, Me.PeriodoDataGridView.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class