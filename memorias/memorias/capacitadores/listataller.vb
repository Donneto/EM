Public Class listataller

    Private Sub TallerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TallerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TallerBindingSource.EndEdit()
        Me.TallerTableAdapter.Update(Me.Dtset.taller)

    End Sub

    Private Sub listataller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.taller' table. You can move, or remove it, as needed.
        Me.TallerTableAdapter.FillBycapac(Me.Dtset.taller, variables.idcapacitador)

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class