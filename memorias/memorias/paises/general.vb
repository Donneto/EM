Imports System.Data.SqlClient
Public Class general
    Public accion


    Private Sub GeneralBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GeneralBindingSource.EndEdit()
        Me.GeneralTableAdapter.Update(Me.Dtset.general)

    End Sub

    Private Sub general_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.general' table. You can move, or remove it, as needed.
        'Me.GeneralTableAdapter.Fill(Me.Dtset.general)
        accion = variables.modo
        If variables.modo = 0 Then
            Me.GeneralTableAdapter.Fill(Me.Dtset.general)
            Me.GeneralBindingSource.AddNew()
            Me.IdmunicipioTextBox.Text = variables.idmunicipio
            buscarmunicipio()
        End If
        If variables.modo = 1 Then
            Me.GeneralTableAdapter.FillByigual(Me.Dtset.general, variables.idgeneral)
            buscarmunicipio()

        End If

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.GeneralBindingSource.CancelEdit()
        Me.Close()
    End Sub
    Public Sub buscarmunicipio()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "select municipio from municipio where idmunicipio=@idmuni"
            mycommand.Parameters.AddWithValue("@idmuni", Me.IdmunicipioTextBox.Text)
            Me.TextBox1.Text = mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox1.Text = "N/A"
        End Try
    End Sub
    Public Sub updategeneral()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "update general set general=@general,pueblo=@pueblo,colonia=@colonia,aldea=@aldea where idgeneral=@idgeneral and idmunicipio=@idmunicipio"
            mycommand.Parameters.AddWithValue("@general", Me.GeneralTextBox.Text)
            mycommand.Parameters.AddWithValue("@pueblo", Me.PuebloRadioButton.Checked)
            mycommand.Parameters.AddWithValue("@colonia", Me.ColoniaRadioButton.Checked)
            mycommand.Parameters.AddWithValue("@aldea", Me.AldeaRadioButton.Checked)
            mycommand.Parameters.AddWithValue("@idgeneral", Me.IdgeneralTextBox.Text)
            mycommand.Parameters.AddWithValue("@idmunicipio", Me.IdmunicipioTextBox.Text)
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo Actualizar", MsgBoxStyle.Exclamation, "Municipio")
        End Try
    End Sub
    Public Sub savegeneral()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "insert into general(general,pueblo,colonia,aldea,idmunicipio) values(@general,@pueblo,@colonia,@aldea,@idmunicipio)"
            mycommand.Parameters.AddWithValue("@general", Me.GeneralTextBox.Text)
            mycommand.Parameters.AddWithValue("@pueblo", Me.PuebloRadioButton.Checked)
            mycommand.Parameters.AddWithValue("@colonia", Me.ColoniaRadioButton.Checked)
            mycommand.Parameters.AddWithValue("@aldea", Me.AldeaRadioButton.Checked)
            mycommand.Parameters.AddWithValue("@idmunicipio", Me.IdmunicipioTextBox.Text)
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se pudo Ingresar", MsgBoxStyle.Exclamation, "Municipio")
        End Try
    End Sub
    Public Sub guardar()
        If accion = 0 Then
            savegeneral()

        End If
        If accion = 1 Then
            updategeneral()

        End If
    End Sub

    Private Sub AceptaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptaToolStripMenuItem.Click
        If Me.GeneralTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.GeneralTextBox, "Debe ingresar un dato valido")
        Else
            guardar()
            Me.Close()
        End If
    End Sub
End Class