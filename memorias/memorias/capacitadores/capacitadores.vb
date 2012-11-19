Imports System.Data.SqlClient
Public Class capacitadores

    Private Sub CapacitadoresBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapacitadoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CapacitadoresBindingSource.EndEdit()
        Me.CapacitadoresTableAdapter.Update(Me.Dtset.capacitadores)

    End Sub

    Private Sub capacitadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.capacitadores' table. You can move, or remove it, as needed.
        'Me.CapacitadoresTableAdapter.Fill(Me.Dtset.capacitadores)
        If variables.modo = 0 Then
            Me.CapacitadoresTableAdapter.Fill(Me.Dtset.capacitadores)
            Me.CapacitadoresBindingSource.AddNew()
            Me.IdmovTextBox.Text = 1
            Me.IdpaisTextBox.Text = 1
            Me.SexoComboBox.SelectedIndex = 1
            buscarmovpolitico()
            buscarpaises()

        End If
        If variables.modo = 1 Then
            Me.CapacitadoresTableAdapter.FillByigual(Me.Dtset.capacitadores, variables.idcapacitador)
            buscarmovpolitico()
            buscarpaises()

        End If

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.CapacitadoresBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        validarcampos()
        If variables.errora = 1 Then
            variables.errora = 0
        Else
            variables.errora = 0
            Me.Validate()
            Me.CapacitadoresBindingSource.EndEdit()
            Me.CapacitadoresTableAdapter.Update(Me.Dtset.capacitadores)
            Me.Close()
        End If
    End Sub
    Public Sub validarcampos()
        If Me.NombreTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.NombreTextBox, "Debe ingresar un Nombre")
            errora = 1
        End If
        If Me.ApellidoTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.ApellidoTextBox, "Debe ingresar un Apellido")
            errora = 1
        End If
        If Me.IdpaisTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.Button2, "Debe Ingresar un Pais de Origen")
            errora = 1
        End If
    End Sub
    Public Sub buscarmovpolitico()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "select movimiento from mov_politico where idmov=@idmovi"
            mycommand.Parameters.AddWithValue("@idmovi", Me.IdmovTextBox.Text)
            Me.TextBox2.Text = mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox2.Text = "N/A"
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pkmov As New pkmovpolitico
        pkmov.idmov = Me.IdmovTextBox.Text
        pkmov.ShowDialog()
        Me.IdmovTextBox.Text = pkmov.idmov
        buscarmovpolitico()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim pkpaises As New pick
        pkpaises.ID = Me.IdpaisTextBox.Text
        pkpaises.tipo = 1
        pkpaises.ShowDialog()
        Me.IdpaisTextBox.Text = pkpaises.ID
        buscarpaises()

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
End Class