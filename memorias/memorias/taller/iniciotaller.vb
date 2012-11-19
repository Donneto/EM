Imports System.Data.SqlClient
Public Class iniciotaller
#Region "variables"
    Private sqle As New ClasesGenerales.SQLExecuter("sm")
    Private DS As New DataSet
    Private DV As New DataView
#End Region
#Region "Sql Queries"
    Private sqlq1 As String = "SELECT * FROM VW_TALLERES where fecha_inicio between '{0}' and '{1}'"
#End Region


    Private Sub traer_talleres()
        sqle.traer_datos(String.Format(sqlq1, Me.DateTimePicker1.Value.ToString("yyyy-MM-dd 00:00:00"), Me.DateTimePicker2.Value.ToString("yyyy-MM-dd 23:59:00")), "talleres", DS, True)
        DV.Table = DS.Tables("talleres")
        Me.GridControl1.DataSource = DV
        GridControl1.Refresh()
    End Sub

    Private Sub iniciotaller_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Value = DateAdd(DateInterval.Year, -1, Now())
        traer_talleres()

    End Sub

    Private Sub AbrirTallerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirTallerToolStripMenuItem.Click
        variables.modo = 0
        Dim ataller As New MantTalleres
        ataller.Modo = 0
        ataller.IDTaller = 0
        ataller.ShowDialog()
        traer_talleres()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim id As Integer = 0
        Dim dr As DataRow
        If Not Me.GridView1.FocusedRowHandle > -1 Then
            Exit Sub
        End If
        dr = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)

       
        id = dr("idtaller")
        If id < 1 Then
            MsgBox("Seleccione un taller", MsgBoxStyle.Exclamation, "Talleres")
            Exit Sub
        End If
        Dim etaller As New MantTalleres
        etaller.Modo = 1
        etaller.IDTaller = id
        etaller.ShowDialog()




    End Sub

    Private Sub ClausurarTallerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClausurarTallerToolStripMenuItem.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        Dim dr As DataRow
        If Not Me.GridView1.FocusedRowHandle > -1 Then
            Exit Sub
        End If
        dr = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)

        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn
       
        Try
            mycommand.CommandText = "update taller set activo=@ac where idtaller=@idta"
            mycommand.Parameters.AddWithValue("@idta", dr("idtaller"))
            mycommand.Parameters.AddWithValue("@ac", 0)
            mycommand.ExecuteNonQuery()
            traer_talleres()
        Catch ex As Exception
            MsgBox("No se pudo Actualizar", MsgBoxStyle.Exclamation, "Taller")
        End Try


    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AgregarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarToolStripMenuItem.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        Dim dr As DataRow
        If Not Me.GridView1.FocusedRowHandle > -1 Then
            Exit Sub
        End If
        dr = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Dim mparticipante As New pkparticipante
        Dim tempvar As Integer


        
        mparticipante.idpart = 99999
        mparticipante.ShowDialog()
        tempvar = mparticipante.idpart
        If tempvar = 99999 Then

        Else
            Try
                mycommand.CommandText = "insert into taller_participante(idtaller,idparticipante) values(@tallervar,@participantevar)"
                mycommand.Parameters.AddWithValue("@tallervar", dr("idtaller"))
                mycommand.Parameters.AddWithValue("@participantevar", tempvar)
                mycommand.ExecuteNonQuery()
                traer_talleres()
            Catch ex As Exception
                MsgBox("No se pudo Matricular", MsgBoxStyle.Exclamation, "Taller")
            End Try
        End If

    End Sub

    Private Sub VerParticipantesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerParticipantesToolStripMenuItem.Click
        Dim dr As DataRow
        If Not Me.GridView1.FocusedRowHandle > -1 Then
            Exit Sub
        End If
        dr = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)

       
        variables.id_taller = dr("idtaller")
        Dim vpartici As New vparticipantes
        vpartici.ShowDialog()
        traer_talleres()



    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        eliminartalleres()
    End Sub
    Public Sub eliminartalleres()
        Dim dr As DataRow
        If Not Me.GridView1.FocusedRowHandle > -1 Then
            Exit Sub
        End If
        dr = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)

        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn
    
        Try
            mycommand.CommandText = "delete from taller_participante where idtaller=@varidtallera"
            mycommand.Parameters.AddWithValue("@varidtallera", dr("idtaller"))
            mycommand.ExecuteNonQuery()

            mycommand.CommandText = "delete from taller where idtaller=@varidtaller"
            mycommand.Parameters.AddWithValue("@varidtaller", dr("idtaller"))
            mycommand.ExecuteNonQuery()
            traer_talleres()
        Catch ex As Exception
            MsgBox("No se pudo Eliminar", MsgBoxStyle.Exclamation, "Taller")
        End Try


    End Sub

    

 
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged, DateTimePicker2.ValueChanged
        traer_talleres()
    End Sub
End Class