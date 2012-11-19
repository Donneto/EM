Imports System.Data.SqlClient
Public Class iniciomemorias

    Private Sub MemoriasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MemoriasBindingSource.EndEdit()
        Me.MemoriasTableAdapter.Update(Me.Dtset.memorias)

    End Sub

    Private Sub iniciomemorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.memorias' table. You can move, or remove it, as needed.
        Me.MemoriasTableAdapter.FillBylike(Me.Dtset.memorias, "%" + "" + "%")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.MemoriasTableAdapter.FillBylike(Me.Dtset.memorias, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        variables.modo = 0
        Dim amemorias As New memoriass
        amemorias.ShowDialog()
        Me.MemoriasTableAdapter.FillBylike(Me.Dtset.memorias, "%" + Me.TextBox1.Text + "%")

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If Me.MemoriasBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Memorias")
        Else
            variables.modo = 1
            variables.idmemoria = Me.MemoriasDataGridView.Item(0, Me.MemoriasDataGridView.CurrentRow.Index).Value
            Dim ememorias As New memoriass
            ememorias.ShowDialog()
            Me.MemoriasTableAdapter.FillBylike(Me.Dtset.memorias, "%" + Me.TextBox1.Text + "%")

        End If
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        eliminarmemoria()
    End Sub
    Public Sub eliminarmemoria()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.MemoriasBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Memorias")
        Else
            Try
                mycommand.CommandText = "update taller set idmemoria=1 where idmemoria=@varmemo"
                mycommand.Parameters.AddWithValue("@varmemo", Me.MemoriasDataGridView.Item(0, Me.MemoriasDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()

                mycommand.CommandText = "delete from memorias where idmemoria=@varmemob"
                mycommand.Parameters.AddWithValue("@varmemob", Me.MemoriasDataGridView.Item(0, Me.MemoriasDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()
                Me.MemoriasTableAdapter.FillBylike(Me.Dtset.memorias, "%" + Me.TextBox1.Text + "%")

            Catch ex As Exception
                MsgBox("No se pudo Eliminar la memoria", MsgBoxStyle.Exclamation, "Memorias")
            End Try

            
        End If
    End Sub

    
    Private Sub ListamemToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListamemToolStripMenuItem1.Click
        Try


            Me.MemoriasTableAdapter.Fill(Me.Dtset.memorias)

            Dim vp As New Reporte
            Dim rpt As New rpt_lista_memorias

            rpt.Database.Tables("Memorias").SetDataSource(Me.Dtset.Tables("Memorias"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Memorias")

        End Try
    End Sub



End Class