Imports System.Data.SqlClient
Public Class iniciotipotaller

    Private Sub Tipo_tallerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tipo_tallerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tipo_tallerBindingSource.EndEdit()
        Me.Tipo_tallerTableAdapter.Update(Me.Dtset.tipo_taller)

    End Sub

    Private Sub iniciotipotaller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.tipo_taller' table. You can move, or remove it, as needed.
        Me.Tipo_tallerTableAdapter.Fill(Me.Dtset.tipo_taller)

    End Sub

    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click
        variables.modo = 0
        Dim atipo_taller As New ttalleres
        atipo_taller.ShowDialog()
        Me.Tipo_tallerTableAdapter.Fill(Me.Dtset.tipo_taller)

    End Sub

    Private Sub EditarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarToolStripMenuItem.Click

        If Me.Tipo_tallerBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Tipo de Taller")
        Else
            variables.modo = 1
            variables.idtipo_taller = Me.Tipo_tallerDataGridView.Item(0, Me.Tipo_tallerDataGridView.CurrentRow.Index).Value
            Dim etipo_taller As New ttalleres
            etipo_taller.ShowDialog()
            Me.Tipo_tallerTableAdapter.Fill(Me.Dtset.tipo_taller)
        End If

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        eliminartipotaller()
    End Sub
    Public Sub eliminartipotaller()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.Tipo_tallerBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Tipo de Taller")
        Else
            Try
                mycommand.CommandText = "update taller set idtipotaller=1 where idtipotaller=@varidtipotaller"
                mycommand.Parameters.AddWithValue("@varidtipotaller", Me.Tipo_tallerDataGridView.Item(0, Me.Tipo_tallerDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()

                mycommand.CommandText = "delete from tipo_taller where idtipotaller=@varidtipotallerb"
                mycommand.Parameters.AddWithValue("@varidtipotallerb", Me.Tipo_tallerDataGridView.Item(0, Me.Tipo_tallerDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()
                Me.Tipo_tallerTableAdapter.Fill(Me.Dtset.tipo_taller)
            Catch ex As Exception
                MsgBox("No se pudo eliminar", MsgBoxStyle.Exclamation, "Tipo de Taller")
            End Try


        End If
    End Sub

    Private Sub rpttipotallerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpttipotallerToolStripMenuItem1.Click
        Try

            Me.Tipo_tallerTableAdapter.Fill(Me.Dtset.tipo_taller)

            Dim vp As New Reporte
            Dim rpt As New rpt_tipotaller

            rpt.Database.Tables("tipo_taller").SetDataSource(Me.Dtset.Tables("tipo_taller"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Tipo taller")

        End Try
    End Sub
End Class