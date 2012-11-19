Public Class paises

    Private Sub PaisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaisBindingSource.EndEdit()
        Me.PaisTableAdapter.Update(Me.Dtset.pais)

    End Sub

    Private Sub paises_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.pais' table. You can move, or remove it, as needed.
        Me.PaisTableAdapter.Fill(Me.Dtset.pais)
        If variables.modo = 0 Then
            Me.PaisTableAdapter.Fill(Me.Dtset.pais)
            Me.PaisBindingSource.AddNew()
        End If
        If variables.modo = 1 Then
            Me.PaisTableAdapter.FillByigual(Me.Dtset.pais, variables.idpais)


        End If

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.PaisTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.PaisTextBox, "Debe Ingresar un Pais")
        Else
            Me.Validate()
            Me.PaisBindingSource.EndEdit()
            Me.PaisTableAdapter.Update(Me.Dtset.pais)
            Me.Close()
        End If


    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.PaisBindingSource.CancelEdit()
        Me.Close()
    End Sub
End Class