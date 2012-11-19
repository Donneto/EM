Imports System.Data.SqlClient
Public Class inicioregiones

    Private Sub RegionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegionBindingSource.EndEdit()
        Me.RegionTableAdapter.Update(Me.Dtset._region)

    End Sub

    Private Sub inicioregiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset._region' table. You can move, or remove it, as needed.
        Me.RegionTableAdapter.Fill(Me.Dtset._region)
        'Me.RegionTableAdapter.FillBylike(Me.Dtset._region, "%" + "" + "%")

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        variables.modo = 0
        Dim aregion As New regiones
        aregion.ShowDialog()
        Me.RegionTableAdapter.Fill(Me.Dtset._region)
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click

        If Me.RegionBindingSource.Count > 0 Then
            variables.modo = 1
            variables.idregion = Me.RegionDataGridView.Item(0, Me.RegionDataGridView.CurrentRow.Index).Value
            Dim eregion As New regiones
            eregion.ShowDialog()
            Me.RegionTableAdapter.Fill(Me.Dtset._region)
        Else
            MsgBox("Debe Ingresar una Region", MsgBoxStyle.Exclamation, "Regiones")

        End If


    End Sub

    Private Sub VerDetallesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerDetallesToolStripMenuItem.Click
        variables.idregion = Me.RegionDataGridView.Item(0, Me.RegionDataGridView.CurrentRow.Index).Value
        Dim dregion As New detallesregiones
        dregion.ShowDialog()
        Me.RegionTableAdapter.Fill(Me.Dtset._region)
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        eliminarregiones()
    End Sub
    Public Sub eliminarregiones()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.RegionBindingSource.Count = 0 Then
            MsgBox("Debe Ingresar una Region", MsgBoxStyle.Exclamation, "Regiones")
        Else
            Try
                mycommand.CommandText = "delete from region_pais where idregion=@varreg"
                mycommand.Parameters.AddWithValue("@varreg", Me.RegionDataGridView.Item(0, Me.RegionDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()

                mycommand.CommandText = "delete from region_depto where idregion=@varregb"
                mycommand.Parameters.AddWithValue("@varregb", Me.RegionDataGridView.Item(0, Me.RegionDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()

                mycommand.CommandText = "delete from region_municipio where idregion=@varregc"
                mycommand.Parameters.AddWithValue("@varregc", Me.RegionDataGridView.Item(0, Me.RegionDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()

                mycommand.CommandText = "delete from region_general where idregion=@varregd"
                mycommand.Parameters.AddWithValue("@varregd", Me.RegionDataGridView.Item(0, Me.RegionDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()

                mycommand.CommandText = "update taller set idregion=1 where idregion=@varrege"
                mycommand.Parameters.AddWithValue("@varrege", Me.RegionDataGridView.Item(0, Me.RegionDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()

                mycommand.CommandText = "delete from region where idregion=@varregf"
                mycommand.Parameters.AddWithValue("@varregf", Me.RegionDataGridView.Item(0, Me.RegionDataGridView.CurrentRow.Index).Value)
                mycommand.ExecuteNonQuery()
                Me.RegionTableAdapter.Fill(Me.Dtset._region)

            Catch ex As Exception
                MsgBox("No se pudo eliminar la region", MsgBoxStyle.Exclamation, "Regiones")
            End Try
        End If


    End Sub

    Private Sub ReporteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteToolStripMenuItem1.Click
        Try


            Me.RegionTableAdapter.Fill(Me.Dtset._region)

            Dim vp As New Reporte
            Dim rpt As New rpt_region

            rpt.Database.Tables("Region").SetDataSource(Me.Dtset.Tables("Region"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Regiones")

        End Try
    End Sub
End Class