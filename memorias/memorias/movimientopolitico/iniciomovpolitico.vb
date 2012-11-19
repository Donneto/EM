Imports System.Data.SqlClient
Public Class iniciomovpolitico

    Private Sub iniciomovpolitico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.mov_politico' table. You can move, or remove it, as needed.
        Me.IniciomovpoliticoTableAdapter.Fill(Me.Dtset.iniciomovpolitico, "%" + "" + "%")

    End Sub

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.IniciomovpoliticoTableAdapter.Fill(Me.Dtset.iniciomovpolitico, VarToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.IniciomovpoliticoTableAdapter.Fill(Me.Dtset.iniciomovpolitico, "%" + Me.TextBox1.Text + "%")

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        variables.modo = 0
        Dim amovpolitico As New movpolitico
        amovpolitico.ShowDialog()
        Me.IniciomovpoliticoTableAdapter.Fill(Me.Dtset.iniciomovpolitico, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click
        If Me.IniciomovpoliticoBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Movimiento Politico")
        Else
            variables.modo = 1
            variables.idmovpolitico = Me.IniciomovpoliticoDataGridView.Item(0, Me.IniciomovpoliticoDataGridView.CurrentRow.Index).Value
            Dim emovpolitico As New movpolitico
            emovpolitico.ShowDialog()
            Me.IniciomovpoliticoTableAdapter.Fill(Me.Dtset.iniciomovpolitico, "%" + Me.TextBox1.Text + "%")

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        eliminarmovpolitico()
    End Sub
    Public Sub eliminarmovpolitico()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.IniciomovpoliticoBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Movimiento Politico")
        Else
            If Me.IniciomovpoliticoDataGridView.Item(0, Me.IniciomovpoliticoDataGridView.CurrentRow.Index).Value = 1 Then
                MsgBox("Registro de Control, No borrar", MsgBoxStyle.Exclamation, "Movimiento Politico")
            Else
                Try
                    mycommand.CommandText = "update capacitadores set idmov=1 where idmov=@varmov"
                    mycommand.Parameters.AddWithValue("@varmov", Me.IniciomovpoliticoDataGridView.Item(0, Me.IniciomovpoliticoDataGridView.CurrentRow.Index).Value)
                    mycommand.ExecuteNonQuery()

                    mycommand.CommandText = "update participantes set idmov=1 where idmov=@varmovb"
                    mycommand.Parameters.AddWithValue("@varmovb", Me.IniciomovpoliticoDataGridView.Item(0, Me.IniciomovpoliticoDataGridView.CurrentRow.Index).Value)
                    mycommand.ExecuteNonQuery()

                    mycommand.CommandText = "delete from mov_politico where idmov=@varmovc"
                    mycommand.Parameters.AddWithValue("@varmovc", Me.IniciomovpoliticoDataGridView.Item(0, Me.IniciomovpoliticoDataGridView.CurrentRow.Index).Value)
                    mycommand.ExecuteNonQuery()
                    Me.IniciomovpoliticoTableAdapter.Fill(Me.Dtset.iniciomovpolitico, "%" + Me.TextBox1.Text + "%")
                Catch ex As Exception
                    MsgBox("No se pudo eliminar", MsgBoxStyle.Exclamation, "Movimiento Politico")
                End Try
            End If

           
        End If





    End Sub

    Private Sub ReporteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteToolStripMenuItem1.Click

        Try

       
            Me.IniciomovpoliticoTableAdapter.Fill(Me.Dtset.iniciomovpolitico, "%" + "" + "%")

            Dim vp As New Reporte
            Dim rpt As New rpt_mov_politico

            rpt.Database.Tables("Iniciomovpolitico").SetDataSource(Me.Dtset.Tables("Iniciomovpolitico"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Iniciomovpolitico")

        End Try
    End Sub
End Class