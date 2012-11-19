Imports System.Data.SqlClient
Public Class municipio
    Public accion

    Private Sub MunicipioBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MunicipioBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MunicipioBindingSource.EndEdit()
        Me.MunicipioTableAdapter.Update(Me.Dtset.municipio)

    End Sub

    Private Sub municipio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.municipio' table. You can move, or remove it, as needed.
        Me.MunicipioTableAdapter.Fill(Me.Dtset.municipio)
        accion = variables.modo
        If variables.modo = 0 Then
            Me.MunicipioTableAdapter.Fill(Me.Dtset.municipio)
            Me.MunicipioBindingSource.AddNew()
            Me.IddeptoTextBox.Text = variables.iddepto
            buscardepto()
        End If
        If variables.modo = 1 Then
            Me.MunicipioTableAdapter.FillByigual(Me.Dtset.municipio, variables.idmunicipio)
            buscardepto()

        End If

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.MunicipioBindingSource.CancelEdit()
        Me.Close()

    End Sub
    Public Sub buscardepto()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "select depto from depto where iddepto=@iddepto"
            mycommand.Parameters.AddWithValue("@iddepto", Me.IddeptoTextBox.Text)
            Me.TextBox1.Text = mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox1.Text = "N/A"
        End Try
    End Sub
    Public Sub updatemunicipio()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "update municipio set municipio=@municipio where idmunicipio=@idmuni and iddepto=@iddepto"
            mycommand.Parameters.AddWithValue("@municipio", Me.MunicipioTextBox.Text)
            mycommand.Parameters.AddWithValue("@idmuni", Me.IdmunicipioTextBox.Text)
            mycommand.Parameters.AddWithValue("@iddepto", Me.IddeptoTextBox.Text)
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo Actualizar", MsgBoxStyle.Exclamation, "Municipio")
        End Try
    End Sub
    Public Sub savemunicipio()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "insert into municipio(municipio,iddepto) values(@municipio,@iddept)"

            mycommand.Parameters.AddWithValue("@municipio", Me.MunicipioTextBox.Text)
            mycommand.Parameters.AddWithValue("@iddept", Me.IddeptoTextBox.Text)
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo Ingresar", MsgBoxStyle.Exclamation, "Municipio")
        End Try
    End Sub
    Public Sub guardar()
        If accion = 0 Then
            savemunicipio()

        End If
        If accion = 1 Then
            updatemunicipio()

        End If
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        If Me.MunicipioTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.MunicipioTextBox, "Debe ingresar un municipio valido")
        Else
            guardar()
            Me.Close()
        End If
    End Sub
End Class