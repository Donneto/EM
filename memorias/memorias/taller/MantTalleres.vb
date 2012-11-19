Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraEditors.Controls
Public Class MantTalleres
#Region "Variables"
    Private sqle As New ClasesGenerales.SQLExecuter("sm")
    Private ds As New DataSet
    Private dvCapa As New DataView
    Private dtCapa As New DataTable
    Private v_modo As Integer = 0
    Private v_idtaller As Integer = 0
#End Region

#Region "Queries"

    Private sqlq1 As String = "select idcapacitador,nombre + ' ' + apellido as 'nombre' from capacitadores where activo=1 order by nombre + ' ' + apellido"
    Private sqlq2 As String = "select a.idcapacitador, nombre + ' ' + apellido as 'nombre',fecha_inicio,fecha_final from taller_capacitador a inner join capacitadores b on a.idcapacitador=b.idcapacitador where idtaller={0}"
    Private sqlq3 As String = "select * from taller where idtaller={0}"
#End Region
#Region "Properties"
    Public WriteOnly Property Modo() As Integer
        Set(ByVal value As Integer)
            v_modo = value
        End Set
    End Property

    Public Property IDTaller() As Integer
        Get
            Return v_idtaller
        End Get
        Set(ByVal value As Integer)
            v_idtaller = value
        End Set
    End Property

#End Region

#Region "Functions and Actions"
    Private Sub MantTalleres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sqle.servidor = "DESKTOP"
        Traercapacitadores()
        TraerCapacitadoresTaller()
        TraerDatos()
    End Sub
    Private Sub TraerCapacitadoresTaller()
        If ds.Tables.Contains("capatalleres") Then ds.Tables("capatalleres").Clear()
        sqle.traer_datos(String.Format(sqlq2, Me.v_idtaller), "capatalleres", ds)
        If v_modo = 0 Then
            If ds.Tables.Contains("capatalleres") Then ds.Tables("capatalleres").Clear()
        End If
        dvCapa.Table = ds.Tables("capatalleres")
        Me.GridControl1.DataSource = dvCapa
        Me.GridControl1.Refresh()

    End Sub
    Private Sub TraerDatos()
        Dim DR As DataRow = Nothing
        If ds.Tables.Contains("talleres") Then ds.Tables("talleres").Clear()
        sqle.traer_datos(String.Format(sqlq3, v_idtaller), "talleres", ds)
        If Not ds.Tables("talleres").Rows.Count > 0 Then Exit Sub
        DR = ds.Tables("talleres").Rows(0)

        TemaTextBox.Text = DR("tema")
        DescripcionTextBox.Text = DR("descripcion")
        IdmemoriaTextBox.Text = DR("idmemoria")
        IdtipotallerTextBox.Text = DR("idtipotaller")
        IdperiodoTextBox.Text = DR("idperiodo")
        IdregionTextBox.Text = DR("idregion")

        TraerMemoria()
        TraerPeriodo()
        TraerTipoTaller()
        TraerRegion()
    End Sub

    Private Sub Traercapacitadores()
        If ds.Tables.Contains("capacitadores") Then ds.Tables("capacitadores").Clear()
        sqle.traer_datos(sqlq1, "capacitadores", ds)
        RepositoryItemLookUpEdit1.DataSource = ds.Tables("capacitadores")
        RepositoryItemLookUpEdit1.DisplayMember = "nombre"
        RepositoryItemLookUpEdit1.ValueMember = "idcapacitador"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pi As New pick
        pi.Location = Me.PointToClient(Windows.Forms.Cursor.Position)
        pi.ID = Me.IdmemoriaTextBox.Text
        pi.TIPO = pick.TIPOPICK.MEMORIA
        pi.ShowDialog()
        If (pi.ID = 0) Then Exit Sub
        Me.IdmemoriaTextBox.Text = pi.ID
        TraerMemoria()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pi As New pick
        If IsNumeric(Me.IdtipotallerTextBox.Text) Then
            pi.ID = Me.IdtipotallerTextBox.Text
        Else
            pi.ID = 1
        End If
        pi.TIPO = pick.TIPOPICK.TIPO_TALLER
        pi.ShowDialog()
        If pi.ID = 0 Then Exit Sub
        Me.IdtipotallerTextBox.Text = pi.ID
        Me.TraerTipoTaller()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim pi As New pick
        pi.ID = Me.IdperiodoTextBox.Text
        pi.TIPO = pick.TIPOPICK.PERIODO
        pi.ShowDialog()
        If pi.ID = 0 Then Exit Sub
        Me.IdperiodoTextBox.Text = pi.ID

        Me.TraerPeriodo()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim pi As New pick
        pi.ID = Me.IdregionTextBox.Text
        pi.TIPO = pick.TIPOPICK.REGION
        pi.ShowDialog()
        If IsNumeric(pi.ID) Then
            If pi.ID = 0 Then Exit Sub
        Else
            Exit Sub
        End If

        Me.IdregionTextBox.Text = pi.ID
        Me.TraerRegion()
    End Sub
    Private Sub TraerMemoria()
        Try
            Me.TextBox2.Text = sqle.ExecuteQueryScalarExc("select tema from memorias where idmemoria=" & Me.IdmemoriaTextBox.Text)
        Catch ex As Exception
            Me.TextBox2.Text = "No se pudo obtener La memoria"
        End Try
    End Sub
    Private Sub TraerPeriodo()
        Try
            Me.TextBox4.Text = sqle.ExecuteQueryScalarExc("select descripcion from periodo where idperiodo=" & Me.IdperiodoTextBox.Text)
        Catch ex As Exception
            Me.TextBox4.Text = "No se pudo obtener el periodo"
        End Try
    End Sub

    Private Sub TraerTipoTaller()
        Try
            Me.TextBox3.Text = sqle.ExecuteQueryScalarExc("select descripcion from tipo_taller where idtipotaller=" & Me.IdtipotallerTextBox.Text)
        Catch ex As Exception
            Me.TextBox3.Text = "No se pudo obtener el tipo de taller"
        End Try
    End Sub
    Private Sub TraerRegion()
        Try
            Me.TextBox5.Text = sqle.ExecuteQueryScalarExc("select descripcion from region where idregion=" & Me.IdregionTextBox.Text)
        Catch ex As Exception
            Me.TextBox5.Text = "No se pudo obtener la Region"
        End Try
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        Dim mytransaction As SqlTransaction
        conn.ConnectionString = sqle.conexion

        Dim idtallernew As Integer = 0

        conn.Open()
        mytransaction = conn.BeginTransaction()
        mycommand = New SqlCommand
        mycommand.Connection = conn
        mycommand.Transaction = mytransaction
        If Me.TemaTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TemaTextBox, "Debe Ingresar un Tema")
        Else
            If v_modo = 0 Then
                Try
                    mycommand.CommandText = "insert into taller(descripcion,tema,fecha_inicio,fecha_final,idmemoria,idperiodo,idtipotaller,idregion,activo) values(@descripcione,@temaa,@finicio,@ffinal,@idmemoriaa,@idp,@idtt,@idr,@ac); select scope_identity()"
                    mycommand.Parameters.AddWithValue("@descripcione", Me.DescripcionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@temaa", Me.TemaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@finicio", Me.Fecha_inicioDateTimePicker.Value)
                    mycommand.Parameters.AddWithValue("@ffinal", Me.Fecha_finalDateTimePicker.Value)
                    mycommand.Parameters.AddWithValue("@idmemoriaa", Me.IdmemoriaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idp", Me.IdperiodoTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idtt", Me.IdtipotallerTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idr", Me.IdregionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@ac", Me.ActivoCheckBox.Checked)
                    idtallernew = mycommand.ExecuteScalar
                    For Each dr As DataRowView In dvCapa
                        mycommand.CommandText = "insert into taller_capacitador(idtaller,idcapacitador,fecha_inicio,fecha_final)values(@p0,@p1,@p2,@p3)"
                        mycommand.Parameters.AddWithValue("@p0", idtallernew)
                        mycommand.Parameters.AddWithValue("@p1", dr("idcapacitador"))
                        mycommand.Parameters.AddWithValue("@p2", dr("fecha_inicio"))
                        mycommand.Parameters.AddWithValue("@p3", dr("fecha_final"))
                        mycommand.ExecuteNonQuery()
                    Next
                    mytransaction.Commit()
                    conn.Close()
                    Me.Close()
                Catch ex As Exception
                    mytransaction.Rollback()
                    conn.Close()
                    MsgBox("No se pudo Guardar el Registro", MsgBoxStyle.Exclamation, "Talleres")
                    Exit Sub
                End Try
            End If
            If v_modo = 1 Then
                Try
                    mycommand.CommandText = "update taller set descripcion=@descripcione,tema=@temaa,fecha_inicio=@finicio,fecha_final=@ffinal,idmemoria=@idmemoriaa,idperiodo=@idp,idtipotaller=@idtt,idregion=@idr,activo=@ac where idtaller=@idta"
                    mycommand.Parameters.AddWithValue("@idta", v_idtaller)
                    mycommand.Parameters.AddWithValue("@descripcione", Me.DescripcionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@temaa", Me.TemaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@finicio", Me.Fecha_inicioDateTimePicker.Value)
                    mycommand.Parameters.AddWithValue("@ffinal", Me.Fecha_finalDateTimePicker.Value)
                    mycommand.Parameters.AddWithValue("@idmemoriaa", Me.IdmemoriaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idp", Me.IdperiodoTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idtt", Me.IdtipotallerTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idr", Me.IdregionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@ac", Me.ActivoCheckBox.Checked)
                    mycommand.ExecuteNonQuery()
                    mycommand.Parameters.Clear()
                    'Guardar Agregados
                    dvCapa.RowStateFilter = DataViewRowState.Added
                    For Each dr As DataRowView In dvCapa
                        mycommand.CommandText = "insert into taller_capacitador(idtaller,idcapacitador,fecha_inicio,fecha_final)values(@p0,@p1,@p2,@p3)"
                        mycommand.Parameters.AddWithValue("@p0", v_idtaller)
                        mycommand.Parameters.AddWithValue("@p1", dr("idcapacitador"))
                        mycommand.Parameters.AddWithValue("@p2", dr("fecha_inicio"))
                        mycommand.Parameters.AddWithValue("@p3", dr("fecha_final"))
                        mycommand.ExecuteNonQuery()
                    Next
                    mycommand.Parameters.Clear()

                    'Actualizar Existentes
                    dvCapa.RowStateFilter = DataViewRowState.ModifiedCurrent
                    For Each dr As DataRowView In dvCapa
                        mycommand.CommandText = "update taller_capacitador set idcapacitador=@p1,fecha_inicio=@p2,fecha_final=@p3 where idtaller=@p0 and idcapacitador=@p1"
                        mycommand.Parameters.AddWithValue("@p0", v_idtaller)
                        mycommand.Parameters.AddWithValue("@p1", dr("idcapacitador"))
                        mycommand.Parameters.AddWithValue("@p2", dr("fecha_inicio"))
                        mycommand.Parameters.AddWithValue("@p3", dr("fecha_final"))
                        mycommand.ExecuteNonQuery()
                    Next
                    mycommand.Parameters.Clear()

                    'Eliminar Borradas
                    dvCapa.RowStateFilter = DataViewRowState.Deleted
                    For Each dr As DataRowView In dvCapa
                        mycommand.CommandText = "delete taller_capacitador where idtaller=@p0 and idcapacitador=@p1"
                        mycommand.Parameters.AddWithValue("@p0", v_idtaller)
                        mycommand.Parameters.AddWithValue("@p1", dr("idcapacitador"))
                        mycommand.ExecuteNonQuery()
                    Next
                    mytransaction.Commit()
                    conn.Close()
                    Me.Close()
                Catch ex As Exception
                    mytransaction.Rollback()
                    conn.Close()
                    MsgBox("No se pudo Guardar el Registro", MsgBoxStyle.Exclamation, "Talleres")
                    Exit Sub
                End Try
            End If

        End If
    End Sub

    Private Sub GridView1_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GridView1.ValidateRow

        Dim view As ColumnView = CType(sender, ColumnView)
        Dim column1 As GridColumn = view.Columns("fecha_inicio")
        Dim column2 As GridColumn = view.Columns("fecha_final")
        Dim column3 As GridColumn = view.Columns("idcapacitador")
        Dim time1 As DateTime
        Dim time2 As DateTime
        Try
            time1 = CType(IIf(view.GetRowCellValue(e.RowHandle, column1) Is DBNull.Value, Date.MinValue, view.GetRowCellValue(e.RowHandle, column1)), DateTime)
        Catch ex As Exception
            time1 = Date.MinValue
        End Try
        Try
            time2 = CType(IIf(view.GetRowCellValue(e.RowHandle, column1) Is DBNull.Value, Date.MinValue, view.GetRowCellValue(e.RowHandle, column2)), DateTime)
        Catch ex As Exception
            time2 = Date.MinValue
        End Try
        If time1 >= time2 Then
            e.Valid = False
            view.SetColumnError(column1, "La hora de inicio debe ser menor a la final")
            view.SetColumnError(column2, "La hora final debe ser mayor a la de inicio")
        End If
        If view.GetRowCellValue(e.RowHandle, column3) Is DBNull.Value Then
            e.Valid = False
            view.SetColumnError(column3, "Debe seleccionar un capacitador")
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Close()
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        variables.modo = 0
        Dim acapacitador As New capacitadores
        acapacitador.ShowDialog()
        Traercapacitadores()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim row As Integer = 0
        If GridView1.FocusedRowHandle >= 0 Then
            If Not MessageBox.Show("¿Desea eliminar el capacitador de la lista?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If
            row = GridView1.FocusedRowHandle
            GridView1.DeleteRow(row)
        End If
    End Sub

    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If GridView1.FocusedRowHandle >= 0 Then
            ToolStripButton2.Enabled = True
        Else
            ToolStripButton2.Enabled = False
        End If
    End Sub

#End Region




    
End Class