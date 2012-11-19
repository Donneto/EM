Imports System.Data.SqlClient
Public Class vparticipantes

 

    Private Sub vparticipantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.rpt_listaparticipantesxtaller' table. You can move, or remove it, as needed.
        Me.Rpt_listaparticipantesxtallerTableAdapter.Fill(Me.Dtset.rpt_listaparticipantesxtaller)
        Me.ListaparticipantesxtallerTableAdapter.FillBylike(Me.Dtset.listaparticipantesxtaller, variables.id_taller, "%" + "" + "%")
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.ListaparticipantesxtallerTableAdapter.FillBylike(Me.Dtset.listaparticipantesxtaller, variables.id_taller, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EliminardelaListaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminardelaListaToolStripMenuItem.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.ListaparticipantesxtallerBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Taller")
        Else
            Try
                mycommand.CommandText = "delete from taller_participante where idtaller=@idtall and idparticipante=@vparti"
                mycommand.Parameters.AddWithValue("@idtall", variables.id_taller)
                mycommand.Parameters.AddWithValue("@vparti", Me.ListaparticipantesxtallerDataGridView.Item(0, Me.ListaparticipantesxtallerDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()
                Me.ListaparticipantesxtallerTableAdapter.FillBylike(Me.Dtset.listaparticipantesxtaller, variables.id_taller, "%" + Me.TextBox1.Text + "%")
            Catch ex As Exception
                MsgBox("No se pudo Eliminar", MsgBoxStyle.Exclamation, "Taller")
            End Try
        End If
    End Sub

    Private Sub VerDetallesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerDetallesToolStripMenuItem.Click
        If Me.ListaparticipantesxtallerBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Taller")
        Else
            variables.modo = 1
            variables.idparticipante = Me.ListaparticipantesxtallerDataGridView.Item(0, Me.ListaparticipantesxtallerDataGridView.CurrentRow.Index).Value
            Dim detallesparti As New participantes
            detallesparti.ShowDialog()
            Me.ListaparticipantesxtallerTableAdapter.FillBylike(Me.Dtset.listaparticipantesxtaller, variables.id_taller, "%" + Me.TextBox1.Text + "%")
        End If
        
    End Sub

    Private Sub ImprimirReporteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirReporteToolStripMenuItem.Click
        Try

            Me.Rpt_listaparticipantesxtallerTableAdapter.Fill(Me.Dtset.rpt_listaparticipantesxtaller)

            Dim vp As New Reporte
            Dim rpt As New rpt_participantesxtaller




            rpt.Database.Tables("Rpt_listaparticipantesxtaller").SetDataSource(Me.Dtset.Tables("Rpt_listaparticipantesxtaller"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Ver participantes")

        End Try
    End Sub
End Class