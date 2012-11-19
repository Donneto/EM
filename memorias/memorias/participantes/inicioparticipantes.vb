Imports System.Data.SqlClient
Public Class inicioparticipantes



    Private Sub inicioparticipantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.rpt_participantes' table. You can move, or remove it, as needed.
        Me.Rpt_participantesTableAdapter.Fill(Me.Dtset.rpt_participantes)
        'TODO: This line of code loads data into the 'Dtset.participantes' table. You can move, or remove it, as needed.
        'Me.ParticipantesTableAdapter.Fill(Me.Dtset.participantes)
        Me.ParticipantesTableAdapter.FillByname(Me.Dtset.participantes, "%" + "" + "%")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.ParticipantesTableAdapter.FillByname(Me.Dtset.participantes, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub ParticipantesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ParticipantesBindingSource.EndEdit()
        Me.ParticipantesTableAdapter.Update(Me.Dtset.participantes)

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        variables.modo = 0
        Dim aparticipantes As New participantes
        aparticipantes.ShowDialog()
        Me.ParticipantesTableAdapter.FillByname(Me.Dtset.participantes, "%" + Me.TextBox1.Text + "%")

    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        If Me.ParticipantesBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Participantes")
        Else
            variables.modo = 1
            variables.idparticipante = Me.ParticipantesDataGridView.Item(0, Me.ParticipantesDataGridView.CurrentRow.Index).Value
            Dim eparticipantes As New participantes
            eparticipantes.ShowDialog()
            Me.ParticipantesTableAdapter.FillByname(Me.Dtset.participantes, "%" + Me.TextBox1.Text + "%")
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub VerTalleresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerTalleresToolStripMenuItem.Click
        If Me.ParticipantesBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Participantes")
        Else
            variables.idparticipante = Me.ParticipantesDataGridView.Item(0, Me.ParticipantesDataGridView.CurrentRow.Index).Value
            Dim vvtall As New vertalleres
            vvtall.ShowDialog()
            Me.ParticipantesTableAdapter.FillByname(Me.Dtset.participantes, "%" + Me.TextBox1.Text + "%")
        End If

    End Sub

    Private Sub InscribirentallerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InscribirentallerToolStripMenuItem.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn
        Dim mtalleres As New pktalleres
        Dim tempovar As Integer

        If Me.ParticipantesBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Participantes")
        Else
            mtalleres.idtallerres = 99999
            mtalleres.ShowDialog()
            tempovar = mtalleres.idtallerres
            If tempovar = 99999 Then
            Else
                Try
                    mycommand.CommandText = "insert into taller_participante(idtaller,idparticipante) values(@tallervar,@participantevar)"
                    mycommand.Parameters.AddWithValue("@tallervar", tempovar)
                    mycommand.Parameters.AddWithValue("@participantevar", Me.ParticipantesDataGridView.Item(0, Me.ParticipantesDataGridView.CurrentRow.Index).Value)
                    mycommand.ExecuteNonQuery()
                    Me.ParticipantesTableAdapter.FillByname(Me.Dtset.participantes, "%" + Me.TextBox1.Text + "%")
                Catch ex As Exception
                    MsgBox("No se pudo Matricular", MsgBoxStyle.Exclamation, "Taller")
                End Try
            End If
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        eliminarparticipante()
    End Sub
    Public Sub eliminarparticipante()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.ParticipantesBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Participantes")
        Else
            Try
                mycommand.CommandText = "delete from taller_participante where idparticipante=@idpavar"
                mycommand.Parameters.AddWithValue("@idpavar", Me.ParticipantesDataGridView.Item(0, Me.ParticipantesDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()

                mycommand.CommandText = "delete from participantes where idparticipante=@idpavarb"
                mycommand.Parameters.AddWithValue("@idpavarb", Me.ParticipantesDataGridView.Item(0, Me.ParticipantesDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()
                Me.ParticipantesTableAdapter.FillByname(Me.Dtset.participantes, "%" + Me.TextBox1.Text + "%")

            Catch ex As Exception
                MsgBox("No se pudo Eliminar,participantes", MsgBoxStyle.Exclamation, "Taller")
            End Try
            
        End If
    End Sub

    Private Sub rptparToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptparToolStripMenuItem1.Click
        Try

            Me.Rpt_participantesTableAdapter.Fill(Me.Dtset.rpt_participantes)

            Dim vp As New Reporte
            Dim rpt As New rpt_participantes

            rpt.Database.Tables("rpt_participantes").SetDataSource(Me.Dtset.Tables("rpt_participantes"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Participantes")

        End Try
    End Sub
End Class