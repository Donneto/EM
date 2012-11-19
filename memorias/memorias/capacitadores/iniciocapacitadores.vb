Imports System.Data.SqlClient
Public Class iniciocapacitadores

    Private Sub CapacitadoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapacitadoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CapacitadoresBindingSource.EndEdit()
        Me.CapacitadoresTableAdapter.Update(Me.Dtset.capacitadores)

    End Sub

    Private Sub iniciocapacitadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.Rpt_capacitador' table. You can move, or remove it, as needed.
        Me.Rpt_capacitadorTableAdapter.Fill(Me.Dtset.Rpt_capacitador)
        'TODO: This line of code loads data into the 'Dtset.Rpt_capacitador' table. You can move, or remove it, as needed.
        Me.Rpt_capacitadorTableAdapter.Fill(Me.Dtset.Rpt_capacitador)
        'TODO: This line of code loads data into the 'Dtset.Rpt_capacitador' table. You can move, or remove it, as needed.
        Me.Rpt_capacitadorTableAdapter.Fill(Me.Dtset.Rpt_capacitador)
        'TODO: This line of code loads data into the 'Dtset.capacitadores' table. You can move, or remove it, as needed.
        Me.CapacitadoresTableAdapter.FillByname(Me.Dtset.capacitadores, "%" + "" + "%")

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.CapacitadoresTableAdapter.FillByname(Me.Dtset.capacitadores, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        variables.modo = 0
        Dim acapacitador As New capacitadores
        acapacitador.ShowDialog()
        Me.CapacitadoresTableAdapter.FillByname(Me.Dtset.capacitadores, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click

        If Me.CapacitadoresBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Capacitadores")
        Else
            variables.modo = 1
            variables.idcapacitador = Me.CapacitadoresDataGridView.Item(0, Me.CapacitadoresDataGridView.CurrentRow.Index).Value
            Dim ecapacitador As New capacitadores
            ecapacitador.ShowDialog()
            Me.CapacitadoresTableAdapter.FillByname(Me.Dtset.capacitadores, "%" + Me.TextBox1.Text + "%")

        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub ListadodecursosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadodecursosToolStripMenuItem.Click

        variables.idcapacitador = Me.CapacitadoresDataGridView.Item(0, Me.CapacitadoresDataGridView.CurrentRow.Index).Value
        Dim lstcursos As New listataller
        lstcursos.ShowDialog()
        Me.CapacitadoresTableAdapter.FillByname(Me.Dtset.capacitadores, "%" + Me.TextBox1.Text + "%")

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        eliminarcapacitador()
    End Sub
    Public Sub eliminarcapacitador()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.CapacitadoresBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Capacitadores")
        Else
            Try
                mycommand.CommandText = "update taller set idcapacitador=1 where idcapacitador=@varcapa"
                mycommand.Parameters.AddWithValue("@varcapa", Me.CapacitadoresDataGridView.Item(0, Me.CapacitadoresDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()

                mycommand.CommandText = "delete capacitadores where idcapacitador=@varcapab"
                mycommand.Parameters.AddWithValue("@varcapab", Me.CapacitadoresDataGridView.Item(0, Me.CapacitadoresDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()
                Me.CapacitadoresTableAdapter.FillByname(Me.Dtset.capacitadores, "%" + Me.TextBox1.Text + "%")
            Catch ex As Exception
                MsgBox("No se pudo eliminar talleres", MsgBoxStyle.Exclamation, "Capacitadores")
            End Try
            


        End If
    End Sub

    Private Sub ReporteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteToolStripMenuItem1.Click
        Try

       
            Me.Rpt_capacitadorTableAdapter.Fill(Me.Dtset.Rpt_capacitador)

            Dim vp As New Reporte
            Dim rpt As New rpt_capacitadores

            rpt.Database.Tables(0).SetDataSource(Me.Dtset.Tables("Rpt_capacitador"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()
        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Capacitadores")

        End Try
    End Sub

End Class