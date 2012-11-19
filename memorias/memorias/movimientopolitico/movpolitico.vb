Imports System.Data.SqlClient
Public Class movpolitico
    Private Sub movpolitico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.mov_politico' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Dtset.mov_politico' table. You can move, or remove it, as needed.
        'Me.Mov_politicoTableAdapter.Fill(Me.Dtset.mov_politico)
        'Me.Mov_politicoTableAdapter.FillByigual(Me.Dtset.mov_politico, variables.idmovpolitico)

        If variables.modo = 0 Then
            Me.Mov_politicoTableAdapter.Fill(Me.Dtset.mov_politico)
            Me.Mov_politicoBindingSource.AddNew()
            Me.IdpaisTextBox.Text = 1
            buscarpaises()
        End If
        If variables.modo = 1 Then
            Me.Mov_politicoTableAdapter.FillByigual(Me.Dtset.mov_politico, variables.idmovpolitico)
            buscarpaises()
        End If

    End Sub

    Private Sub Mov_politicoBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mov_politicoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Mov_politicoBindingSource.EndEdit()
        Me.Mov_politicoTableAdapter.Update(Me.Dtset.mov_politico)

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
    Public Sub validardata()
        If Me.MovimientoTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.MovimientoTextBox, "Debe Ingresar un Movimiento")
            errora = 1
        End If
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        validardata()
        If variables.errora = 1 Then
            variables.errora = 0
        Else
            errora = 0
            Me.Validate()
            Me.Mov_politicoBindingSource.EndEdit()
            Me.Mov_politicoTableAdapter.Update(Me.Dtset.mov_politico)
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim pkpaises As New pick
        pkpaises.ID = Me.IdpaisTextBox.Text
        pkpaises.tipo = 1
        pkpaises.ShowDialog()
        Me.IdpaisTextBox.Text = pkpaises.ID
        buscarpaises()
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Mov_politicoBindingSource.CancelEdit()
        Me.Close()
    End Sub
End Class