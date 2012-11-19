Imports System.Data.SqlClient
Public Class memoriass

    Private Sub MemoriasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.MemoriasBindingSource.EndEdit()
        Me.MemoriasTableAdapter.Update(Me.Dtset.memorias)

    End Sub

    Private Sub memorias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.memorias' table. You can move, or remove it, as needed.
        'Me.MemoriasTableAdapter.Fill(Me.Dtset.memorias)
        If variables.modo = 0 Then
            Me.MemoriasTableAdapter.Fill(Me.Dtset.memorias)
            Me.MemoriasBindingSource.AddNew()

        End If
        If variables.modo = 1 Then
            Me.MemoriasTableAdapter.FillByid(Me.Dtset.memorias, variables.idmemoria)

        End If

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn


        If Me.TemaTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TemaTextBox, "Debe Ingresar un Titulo")
        Else
            If variables.modo = 0 Then
                Try
                    mycommand.CommandText = "insert into memorias(idmemoria,archivo,tema,descripcion) values(@idmem,NULL,@tema,@descripcion)"
                    mycommand.Parameters.AddWithValue("@idmem", Me.IdmemoriaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@tema", Me.TemaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@descripcion", Me.DescripcionTextBox.Text)
                    mycommand.ExecuteNonQuery()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("No se pudo ingresar", MsgBoxStyle.Exclamation, "Memorias")
                End Try
            End If
            If variables.modo = 1 Then
                Try
                    mycommand.CommandText = "update memorias set tema=@temam,descripcion=@desc where idmemoria=@idmemo"
                    mycommand.Parameters.AddWithValue("@temam", Me.TemaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@desc", Me.DescripcionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idmemo", Me.IdmemoriaTextBox.Text)
                    mycommand.ExecuteNonQuery()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("No se pudo ingresar", MsgBoxStyle.Exclamation, "Memorias")
                End Try


            End If
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.MemoriasBindingSource.CancelEdit()

        Me.Close()
    End Sub

    

   
    Private Sub ReporteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteToolStripMenuItem1.Click
        Try

            Me.Vta_memoriasTableAdapter.Fill(Me.Dtset.vta_memorias, Me.IdmemoriaTextBox.Text)

            Dim vp As New Reporte
            Dim rpt As New rpt_memoria

            rpt.Database.Tables("vta_memorias").SetDataSource(Me.Dtset.Tables("vta_memorias"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Memorias")

        End Try
    End Sub
End Class