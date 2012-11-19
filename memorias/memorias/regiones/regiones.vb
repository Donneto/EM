Imports System.Data.SqlClient
Public Class regiones
    Private sqle As New ClasesGenerales.SQLExecuter("sm")
    Private Sub RegionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RegionBindingSource.EndEdit()
        Me.RegionTableAdapter.Update(Me.Dtset._region)

    End Sub

    Private Sub regiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset._region' table. You can move, or remove it, as needed.
        'Me.RegionTableAdapter.Fill(Me.Dtset._region)
        sqle.servidor = "DESKTOP"
        If variables.modo = 1 Then
            Me.GroupBox1.Text = "Editar"
            Me.RegionTableAdapter.FillByid(Me.Dtset._region, idregion)
        End If
        If variables.modo = 0 Then
            Me.GroupBox1.Text = "Agregar"
            Me.RegionTableAdapter.Fill(Me.Dtset._region)
            Me.RegionBindingSource.AddNew()

        End If

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        validatefields()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If variables.errora = 1 Then
            variables.errora = 0
        Else
            variables.errora = 0
            If variables.modo = 0 Then
                Try
                    mycommand.CommandText = "insert into region(idregion,descripcion) values(@code,@region)"
                    mycommand.Parameters.AddWithValue("@code", Me.IdregionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@region", Me.DescripcionTextBox.Text)
                    mycommand.ExecuteNonQuery()
                    Me.Close()

                Catch ex As Exception
                    MsgBox("Hay un error", MsgBoxStyle.Exclamation, "Regiones")
                End Try
            End If
            If variables.modo = 1 Then
                Try
                    mycommand.CommandText = "update region set descripcion=@descb where idregion=@code"
                    mycommand.Parameters.AddWithValue("@descb", Me.DescripcionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@code", Me.IdregionTextBox.Text)
                    mycommand.ExecuteNonQuery()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Hay un error", MsgBoxStyle.Exclamation, "Regiones")
                End Try
            End If
        End If
    End Sub

    Public Sub validatefields()
        If Me.IdregionTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.IdregionTextBox, "Por favor ingrese un codigo")
            variables.errora = 1
        End If
        If Me.DescripcionTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.DescripcionTextBox, "Por favor ingrese una Descripcion")
            variables.errora = 1
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.RegionBindingSource.CancelEdit()
        Me.Close()

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
        TraerTipoTaller()
    End Sub

    Private Sub TraerTipoTaller()
        Try
            Me.TextBox1.Text = sqle.ExecuteQueryScalarExc("select descripcion from tipo_taller where idtipotaller=" & Me.IdtipotallerTextBox.Text)
        Catch ex As Exception
            Me.TextBox1.Text = "No se pudo obtener el tipo de taller"
        End Try
    End Sub
End Class