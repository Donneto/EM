Imports System.Data.SqlClient
Public Class vertalleres

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub vertalleres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.rpt_talleresxparticipante' table. You can move, or remove it, as needed.
        Me.Rpt_talleresxparticipanteTableAdapter.Fill(Me.Dtset.rpt_talleresxparticipante)
        Me.ListatallerxparticipanteTableAdapter.FillBylike(Me.Dtset.listatallerxparticipante, variables.idparticipante, "%" + "" + "%")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.ListatallerxparticipanteTableAdapter.FillBylike(Me.Dtset.listatallerxparticipante, variables.idparticipante, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub VerDetallesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerDetallesToolStripMenuItem.Click
        If Me.ListatallerxparticipanteBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Participantes")
        Else
            variables.modo = 1
            variables.id_taller = Me.ListatallerxparticipanteDataGridView.Item(0, Me.ListatallerxparticipanteDataGridView.CurrentRow.Index).Value
            Dim vt As New tallerest
            vt.ShowDialog()
            Me.ListatallerxparticipanteTableAdapter.FillBylike(Me.Dtset.listatallerxparticipante, variables.idparticipante, "%" + Me.TextBox1.Text + "%")
        End If


    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.ListatallerxparticipanteBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Taller")
        Else
            Try
                mycommand.CommandText = "delete from taller_participante where idtaller=@idtall and idparticipante=@vparti"
                mycommand.Parameters.AddWithValue("@idtall", Me.ListatallerxparticipanteDataGridView.Item(0, Me.ListatallerxparticipanteDataGridView.CurrentRow.Index).Value)
                mycommand.Parameters.AddWithValue("@vparti", variables.idparticipante)
                mycommand.ExecuteNonQuery()
                Me.ListatallerxparticipanteTableAdapter.FillBylike(Me.Dtset.listatallerxparticipante, variables.idparticipante, "%" + Me.TextBox1.Text + "%")
            Catch ex As Exception
                MsgBox("No se pudo Eliminar", MsgBoxStyle.Exclamation, "Taller")
            End Try
        End If
    End Sub

    Private Sub ImprimirReporteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirReporteToolStripMenuItem.Click
        Try

            Me.Rpt_talleresxparticipanteTableAdapter.Fill(Me.Dtset.rpt_talleresxparticipante)

            Dim vp As New Reporte
            Dim rpt As New rpt_talleresxparticipante




            rpt.Database.Tables("rpt_talleresxparticipante").SetDataSource(Me.Dtset.Tables("rpt_talleresxparticipante"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Ver Talleres")

        End Try
    End Sub
End Class