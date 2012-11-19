Imports System.Data.SqlClient
Public Class participantes


    Private Sub ParticipantesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParticipantesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ParticipantesBindingSource.EndEdit()
        Me.ParticipantesTableAdapter.Update(Me.Dtset.participantes)

    End Sub

    Private Sub participantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.participantes' table. You can move, or remove it, as needed.
        Me.ParticipantesTableAdapter.Fill(Me.Dtset.participantes)

        If variables.modo = 0 Then
            Me.ParticipantesTableAdapter.Fill(Me.Dtset.participantes)
            Me.ParticipantesBindingSource.AddNew()
            Me.IdmovTextBox.Text = 1
            Me.SexoComboBox.SelectedIndex = 1
            buscarmovpolitico()
        End If
        If variables.modo = 1 Then
            Me.ParticipantesTableAdapter.FillByigual(Me.Dtset.participantes, variables.idparticipante)
            buscarmovpolitico()
        End If

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.ParticipantesBindingSource.CancelEdit()
        Me.Close()
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
            Me.TextBox1.Text = mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox1.Text = "N/A"
        End Try
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click
        validarcampos()
        If variables.errora = 1 Then
            variables.errora = 0
        Else
            variables.errora = 0
            Me.Validate()
            Me.ParticipantesBindingSource.EndEdit()
            Me.ParticipantesTableAdapter.Update(Me.Dtset.participantes)
            Me.Close()


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pkmov As New pkmovpolitico
        pkmov.idmov = Me.IdmovTextBox.Text
        pkmov.ShowDialog()
        Me.IdmovTextBox.Text = pkmov.idmov
        buscarmovpolitico()
    End Sub
End Class