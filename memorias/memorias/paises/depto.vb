Imports System.Data.SqlClient
Public Class depto
    Public accion

    Private Sub DeptoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeptoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DeptoBindingSource.EndEdit()
        Me.DeptoTableAdapter.Update(Me.Dtset.depto)

    End Sub

    Private Sub depto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.depto' table. You can move, or remove it, as needed.
        accion = variables.modo
        Me.DeptoTableAdapter.Fill(Me.Dtset.depto)
        If variables.modo = 0 Then
            Me.DeptoTableAdapter.Fill(Me.Dtset.depto)
            Me.DeptoBindingSource.AddNew()
            Me.IdpaisTextBox.Text = variables.idpais
            buscarpaises()
        End If
        If variables.modo = 1 Then
            Me.DeptoTableAdapter.FillByigual(Me.Dtset.depto, variables.iddepto)
            buscarpaises()

        End If


    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.DeptoTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.DeptoTextBox, "Debe ingresar un Departamento")
        Else
            guardar()
            Me.Close()
            'updatedepto()
            'Me.Validate()
            'Me.DeptoBindingSource.EndEdit()
            'Me.DeptoTableAdapter.Update(Me.Dtset.depto)
            'Me.Close()
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.DeptoBindingSource.CancelEdit()
        Me.Close()
    End Sub
    Public Sub buscarpaises()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "select pais from pais where idpais=@idpais"
            mycommand.Parameters.AddWithValue("@idpais", Me.IdpaisTextBox.Text)
            Me.TextBox1.Text = mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox1.Text = "N/A"
        End Try
    End Sub
    Public Sub updatedepto()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "update depto set depto=@depto where iddepto=@iddeptoe and idpais=@idpais"
            mycommand.Parameters.AddWithValue("@depto", Me.DeptoTextBox.Text)
            mycommand.Parameters.AddWithValue("@iddeptoe", Me.IddeptoTextBox.Text)
            mycommand.Parameters.AddWithValue("@idpais", Me.IdpaisTextBox.Text)
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo Actualizar", MsgBoxStyle.Exclamation, "Departamento")
        End Try
    End Sub
    Public Sub savedepto()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "insert into depto(depto,idpais) values(@depto,@idpais)"

            mycommand.Parameters.AddWithValue("@depto", Me.DeptoTextBox.Text)
            mycommand.Parameters.AddWithValue("@idpais", Me.IdpaisTextBox.Text)
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo Ingresar", MsgBoxStyle.Exclamation, "Departamento")
        End Try
    End Sub
    Public Sub guardar()
        If accion = 0 Then
            savedepto()

        End If
        If accion = 1 Then
            updatedepto()

        End If
    End Sub
End Class