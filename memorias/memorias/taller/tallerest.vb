Imports System.Data.SqlClient
Public Class tallerest

    Private Sub TallerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TallerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TallerBindingSource.EndEdit()
        Me.TallerTableAdapter.Update(Me.Dtset.taller)

    End Sub

    Private Sub tallerest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.taller' table. You can move, or remove it, as needed.
        If variables.modo = 0 Then
            Me.TallerTableAdapter.Fill(Me.Dtset.taller)
            Me.TallerBindingSource.AddNew()
            Me.IdcapacitadorTextBox.Text = 1
            Me.IdmemoriaTextBox.Text = 1
            Me.IdperiodoTextBox.Text = 1
            Me.IdregionTextBox.Text = 1
            Me.IdtipotallerTextBox.Text = 1
            obtenercapacitador()
            obtenermemoria()
            obtenertipodetaller()
            obtenerperiodo()
            obtenerregion()
            Me.AnioTextBox.Text = Date.Now.Year
            Me.ActivoCheckBox.CheckState = CheckState.Checked
        End If
        If variables.modo = 1 Then
            Me.TallerTableAdapter.FillByigual(Me.Dtset.taller, variables.id_taller)
            obtenercapacitador()
            obtenermemoria()
            obtenertipodetaller()
            obtenerperiodo()
            obtenerregion()
        End If


        ' Me.TallerTableAdapter.Fill(Me.Dtset.taller)

    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        Me.TallerBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim scapacitador As New pkcapacitador
        scapacitador.idcapac = Me.IdcapacitadorTextBox.Text
        scapacitador.ShowDialog()
        Me.IdcapacitadorTextBox.Text = scapacitador.idcapac
        obtenercapacitador()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim smemoria As New pkmemoria
        smemoria.idmemory = Me.IdmemoriaTextBox.Text
        smemoria.ShowDialog()
        Me.IdmemoriaTextBox.Text = smemoria.idmemory
        obtenermemoria()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim stipodetaller As New pktipotaller
        stipodetaller.idpktipotaller = Me.IdtipotallerTextBox.Text
        stipodetaller.ShowDialog()
        Me.IdtipotallerTextBox.Text = stipodetaller.idpktipotaller
        obtenertipodetaller()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim speriodo As New pkperiodo
        speriodo.idper = Me.IdperiodoTextBox.Text
        speriodo.ShowDialog()
        Me.IdperiodoTextBox.Text = speriodo.idper
        obtenerperiodo()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim sregion As New pkregiones
        sregion.idregii = Me.IdregionTextBox.Text
        sregion.ShowDialog()
        Me.IdregionTextBox.Text = sregion.idregii
        obtenerregion()
    End Sub
    Public Sub obtenercapacitador()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        'Obtener Capacitador
        Try
            mycommand.CommandText = "select nombre from capacitadores where idcapacitador=@idcapa"
            mycommand.Parameters.AddWithValue("@idcapa", Me.IdcapacitadorTextBox.Text)

            Me.TextBox1.Text = mycommand.ExecuteScalar()

            Me.TextBox1.Text = Me.TextBox1.Text + " "
            mycommand.CommandText = "select Apellido from capacitadores where idcapacitador=@idcapacz"
            mycommand.Parameters.AddWithValue("@idcapacz", Me.IdcapacitadorTextBox.Text)
            Me.TextBox1.Text = Me.TextBox1.Text + mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox1.Text = "No se pudo obtener el Capacitador"
        End Try
        
    End Sub
    Public Sub obtenermemoria()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "select tema from memorias where idmemoria=@idmemom"
            mycommand.Parameters.AddWithValue("@idmemom", Me.IdmemoriaTextBox.Text)
            Me.TextBox2.Text = mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox2.Text = "No se pudo obtener La memoria"
        End Try
    End Sub
    Public Sub obtenertipodetaller()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "select descripcion from tipo_taller where idtipotaller=@idtipotaller"
            mycommand.Parameters.AddWithValue("@idtipotaller", Me.IdtipotallerTextBox.Text)
            Me.TextBox3.Text = mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox3.Text = "No se pudo obtener el Tipo de taller"
        End Try
    End Sub
    Public Sub obtenerperiodo()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "select descripcion from periodo where idperiodo=@idp"
            mycommand.Parameters.AddWithValue("@idp", Me.IdperiodoTextBox.Text)
            Me.TextBox4.Text = mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox4.Text = "No se pudo obtener el periodo"
        End Try
    End Sub
    Public Sub obtenerregion()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        Try
            mycommand.CommandText = "select descripcion from region where idregion=@irg"
            mycommand.Parameters.AddWithValue("@irg", Me.IdregionTextBox.Text)
            Me.TextBox5.Text = mycommand.ExecuteScalar()
        Catch ex As Exception
            Me.TextBox5.Text = "No se pudo obtener la Region"
        End Try

    End Sub

    Private Sub AceptarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.TemaTextBox.Text = "" Then
            Me.ErrorProvider1.SetError(Me.TemaTextBox, "Debe Ingresar un Tema")
        Else
            If variables.modo = 0 Then
                Try
                    mycommand.CommandText = "insert into taller(idtaller,idcapacitador,descripcion,tema,anio,fecha_inicio,fecha_final,idmemoria,idperiodo,idtipotaller,idregion,activo) values(@idta,@idcapacitator,@descripcione,@temaa,@anion,@finicio,@ffinal,@idmemoriaa,@idp,@idtt,@idr,@ac)"
                    mycommand.Parameters.AddWithValue("@idta", Me.IdtallerTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idcapacitator", Me.IdcapacitadorTextBox.Text)
                    mycommand.Parameters.AddWithValue("@descripcione", Me.DescripcionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@temaa", Me.TemaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@anion", Me.AnioTextBox.Text)
                    mycommand.Parameters.AddWithValue("@finicio", Me.Fecha_inicioDateTimePicker.Value)
                    mycommand.Parameters.AddWithValue("@ffinal", Me.Fecha_finalDateTimePicker.Value)
                    mycommand.Parameters.AddWithValue("@idmemoriaa", Me.IdmemoriaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idp", Me.IdperiodoTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idtt", Me.IdtipotallerTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idr", Me.IdregionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@ac", Me.ActivoCheckBox.Checked)
                    mycommand.ExecuteNonQuery()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("No se pudo Guardar el Registro", MsgBoxStyle.Exclamation, "Talleres")

                End Try
            End If
            If variables.modo = 1 Then
                Try

                    mycommand.CommandText = "update taller set idcapacitador=@idcapacitator,descripcion=@descripcione,tema=@temaa,anio=@anion,fecha_inicio=@finicio,fecha_final=@ffinal,idmemoria=@idmemoriaa,idperiodo=@idp,idtipotaller=@idtt,idregion=@idr,activo=@ac where idtaller=@idta"
                    mycommand.Parameters.AddWithValue("@idta", Me.IdtallerTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idcapacitator", Me.IdcapacitadorTextBox.Text)
                    mycommand.Parameters.AddWithValue("@descripcione", Me.DescripcionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@temaa", Me.TemaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@anion", Me.AnioTextBox.Text)
                    mycommand.Parameters.AddWithValue("@finicio", Me.Fecha_inicioDateTimePicker.Value)
                    mycommand.Parameters.AddWithValue("@ffinal", Me.Fecha_finalDateTimePicker.Value)
                    mycommand.Parameters.AddWithValue("@idmemoriaa", Me.IdmemoriaTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idp", Me.IdperiodoTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idtt", Me.IdtipotallerTextBox.Text)
                    mycommand.Parameters.AddWithValue("@idr", Me.IdregionTextBox.Text)
                    mycommand.Parameters.AddWithValue("@ac", Me.ActivoCheckBox.Checked)
                    mycommand.ExecuteNonQuery()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("No se pudo Guardar el Registro", MsgBoxStyle.Exclamation, "Talleres")

                End Try
            End If
            
        End If
    End Sub
End Class