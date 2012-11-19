Imports System.Data.SqlClient
Public Class detallesregiones

    Private Sub FillToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton.Click
        Try
            Me.Pais_region_listTableAdapter.Fill(Me.Dtset.pais_region_list, variables.idregion)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pklistpaises As New pick
        pklistpaises.TIPO = pick.TIPOPICK.PAIS
        pklistpaises.ShowDialog()
        If Not pklistpaises.ID > 0 Then
            MsgBox("Debe seleccionar un pais", MsgBoxStyle.Exclamation, "Error")
            Exit Sub
        End If
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "insert into region_pais(idregion,idpais) values(@region,@pais)"
            mycommand.Parameters.AddWithValue("@region", variables.idregion)
            mycommand.Parameters.AddWithValue("@pais", pklistpaises.ID)
            mycommand.ExecuteNonQuery()
            Me.Pais_region_listTableAdapter.Fill(Me.Dtset.pais_region_list, variables.idregion)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub detallesregiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Pais_region_listTableAdapter.Fill(Me.Dtset.pais_region_list, variables.idregion)
            Me.Municipio_region_listTableAdapter.Fill(Me.Dtset.municipio_region_list, variables.idregion)
            Me.Depto_region_listTableAdapter.Fill(Me.Dtset.depto_region_list, variables.idregion)
            Me.General_region_listTableAdapter.Fill(Me.Dtset.general_region_list, variables.idregion)
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Municipio_region_listTableAdapter.Fill(Me.Dtset.municipio_region_list, CType(VarToolStripTextBox1.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton1.Click
        Try
            Me.Municipio_region_listTableAdapter.Fill(Me.Dtset.municipio_region_list, CType(VarToolStripTextBox1.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton2.Click
        Try
            Me.Depto_region_listTableAdapter.Fill(Me.Dtset.depto_region_list, CType(VarToolStripTextBox2.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillToolStripButton3.Click
        Try
            Me.General_region_listTableAdapter.Fill(Me.Dtset.general_region_list, CType(VarToolStripTextBox3.Text, Integer))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pklistdeptos As New pick
        pklistdeptos.TIPO = pick.TIPOPICK.DEPARTAMENTO
        pklistdeptos.ShowDialog()

        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "insert into region_depto(idregion,iddepto) values(@regionb,@depto)"
            mycommand.Parameters.AddWithValue("@regionb", variables.idregion)
            mycommand.Parameters.AddWithValue("@depto", pklistdeptos.ID)
            mycommand.ExecuteNonQuery()
            Me.Depto_region_listTableAdapter.Fill(Me.Dtset.depto_region_list, variables.idregion)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim pklistmuni As New pick
        pklistmuni.TIPO = pick.TIPOPICK.MUNICIPIO
        pklistmuni.ShowDialog()

        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "insert into region_municipio(idregion,idmunicipio) values(@regionc,@mun)"
            mycommand.Parameters.AddWithValue("@regionc", variables.idregion)
            mycommand.Parameters.AddWithValue("@mun", pklistmuni.ID)
            mycommand.ExecuteNonQuery()
            Me.Municipio_region_listTableAdapter.Fill(Me.Dtset.municipio_region_list, variables.idregion)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim pklistgen As New pick
        pklistgen.TIPO = pick.TIPOPICK.GENERAL
        pklistgen.ShowDialog()

        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "insert into region_general(idregion,idgeneral) values(@regiond,@generalid)"
            mycommand.Parameters.AddWithValue("@regiond", variables.idregion)
            mycommand.Parameters.AddWithValue("@generalid", pklistgen.ID)
            mycommand.ExecuteNonQuery()
            Me.General_region_listTableAdapter.Fill(Me.Dtset.general_region_list, variables.idregion)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Not MessageBox.Show("¿Está seguro de eliminar este país de la región?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Exit Sub
        End If
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn
        If Me.Pais_region_listBindingSource.Count = 0 Then
            MsgBox("No hay elementos en la lista", MsgBoxStyle.Exclamation, "Pais")
        Else
            Try
                mycommand.CommandText = "delete from region_pais where idregion=@r and idpais=@p"
                mycommand.Parameters.AddWithValue("@r", variables.idregion)
                mycommand.Parameters.AddWithValue("@p", Me.Pais_region_listListBox.SelectedValue)
                mycommand.ExecuteNonQuery()
                Me.Pais_region_listTableAdapter.Fill(Me.Dtset.pais_region_list, variables.idregion)
            Catch ex As Exception
                MsgBox("No se ha podido eliminar")
            End Try
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn
        If Me.Depto_region_listBindingSource.Count = 0 Then
            MsgBox("No hay elementos en la lista", MsgBoxStyle.Exclamation, "Departamentos")
        Else
            Try
                mycommand.CommandText = "delete from region_depto where idregion=@re and iddepto=@d"
                mycommand.Parameters.AddWithValue("@re", variables.idregion)
                mycommand.Parameters.AddWithValue("@d", Me.Depto_region_listListBox.SelectedValue)
                mycommand.ExecuteNonQuery()
                Me.Depto_region_listTableAdapter.Fill(Me.Dtset.depto_region_list, variables.idregion)
            Catch ex As Exception
                MsgBox("No se ha podido eliminar")
            End Try
        End If

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn
        If Me.Municipio_region_listBindingSource.Count = 0 Then
            MsgBox("No hay elementos en la lista", MsgBoxStyle.Exclamation, "Municipio")
        Else
            Try
                mycommand.CommandText = "delete from region_municipio where idregion=@reg and idmunicipio=@m"
                mycommand.Parameters.AddWithValue("@reg", variables.idregion)
                mycommand.Parameters.AddWithValue("@m", Me.Municipio_region_listListBox.SelectedValue)
                mycommand.ExecuteNonQuery()
                Me.Municipio_region_listTableAdapter.Fill(Me.Dtset.municipio_region_list, variables.idregion)
            Catch ex As Exception
                MsgBox("No se ha podido eliminar")
            End Try
        End If


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn
        If Me.General_region_listBindingSource.Count = 0 Then
            MsgBox("No hay elementos en la lista", MsgBoxStyle.Exclamation, "General")
        Else
            Try
                mycommand.CommandText = "delete from region_general where idregion=@regi and idgeneral=@g"
                mycommand.Parameters.AddWithValue("@regi", variables.idregion)
                mycommand.Parameters.AddWithValue("@g", Me.General_region_listListBox.SelectedValue)
                mycommand.ExecuteNonQuery()
                Me.General_region_listTableAdapter.Fill(Me.Dtset.general_region_list, variables.idregion)

            Catch ex As Exception
                MsgBox("No se ha podido eliminar")
            End Try
        End If


    End Sub
End Class