Imports System.Data.SqlClient
Public Class ttalleres

    Private Sub Tipo_tallerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tipo_tallerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Tipo_tallerBindingSource.EndEdit()
        Me.Tipo_tallerTableAdapter.Update(Me.Dtset.tipo_taller)

    End Sub

    Private Sub ttalleres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.tipo_taller' table. You can move, or remove it, as needed.
        'Me.Tipo_tallerTableAdapter.Fill(Me.Dtset.tipo_taller)
        If variables.modo = 0 Then
            Me.Tipo_tallerTableAdapter.Fill(Me.Dtset.tipo_taller)
            Me.Tipo_tallerBindingSource.AddNew()

        End If
        If variables.modo = 1 Then
            Me.Tipo_tallerTableAdapter.FillByigual(Me.Dtset.tipo_taller, variables.idtipo_taller)

        End If


    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.DescripcionTextBox.Text = "" Then
            MsgBox("Debe ingresar una descripcion", MsgBoxStyle.Exclamation, "Tipos de Taller")
        Else
            If variables.modo = 0 Then
                Try
                    mycommand.CommandText = "insert into tipo_taller(idtipotaller,descripcion) values(@idttaller,@descripcion)"
                    mycommand.Parameters.AddWithValue("@idttaller", Me.IdtipotallerTextBox.Text)
                    mycommand.Parameters.AddWithValue("@descripcion", Me.DescripcionTextBox.Text)
                    mycommand.ExecuteNonQuery()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("No se pudo ingresar", MsgBoxStyle.Exclamation, "Tipo de Taller")
                End Try
            End If
            If variables.modo = 1 Then
                Try
                    mycommand.CommandText = "update tipo_taller set descripcion=@desc where idtipotaller=@idtipot"
                    mycommand.Parameters.AddWithValue("@idtipot", Me.IdtipotallerTextBox.Text)
                    mycommand.Parameters.AddWithValue("@desc", Me.DescripcionTextBox.Text)

                    mycommand.ExecuteNonQuery()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("No se pudo ingresar", MsgBoxStyle.Exclamation, "Tipo de Taller")
                End Try

               
            End If
        End If
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.Tipo_tallerBindingSource.CancelEdit()
        Me.Close()
    End Sub
End Class