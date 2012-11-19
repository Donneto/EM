Imports System.Data.SqlClient
Public Class iniciopaises

    Private Sub PaisBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaisBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PaisBindingSource.EndEdit()
        Me.PaisTableAdapter.Update(Me.Dtset.pais)

    End Sub

    Private Sub iniciopaises_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.rpt_municipio' table. You can move, or remove it, as needed.
        Me.Rpt_municipioTableAdapter.Fill(Me.Dtset.rpt_municipio)
        'TODO: This line of code loads data into the 'Dtset.rpt_deptos' table. You can move, or remove it, as needed.
        Me.Rpt_deptosTableAdapter.Fill(Me.Dtset.rpt_deptos)
        'TODO: This line of code loads data into the 'Dtset.general' table. You can move, or remove it, as needed.
        Me.GeneralTableAdapter.Fill(Me.Dtset.general)
        'TODO: This line of code loads data into the 'Dtset.municipio' table. You can move, or remove it, as needed.
        Me.MunicipioTableAdapter.Fill(Me.Dtset.municipio)
        'TODO: This line of code loads data into the 'Dtset.depto' table. You can move, or remove it, as needed.
        Me.DeptoTableAdapter.Fill(Me.Dtset.depto)
        'TODO: This line of code loads data into the 'Dtset.pais' table. You can move, or remove it, as needed.
        Me.PaisTableAdapter.Fill(Me.Dtset.pais)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Me.PaisTableAdapter.FillBylike(Me.Dtset.pais, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.PaisTableAdapter.FillBylike(Me.Dtset.pais, "%" + Me.TextBox1.Text + "%")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.TextBox1.Text = ""
        Me.PaisTableAdapter.FillBylike(Me.Dtset.pais, "%" + "" + "%")

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Me.DeptoTableAdapter.FillBylike(Me.Dtset.depto, "%" + Me.TextBox2.Text + "%")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.DeptoTableAdapter.FillBylike(Me.Dtset.depto, "%" + Me.TextBox2.Text + "%")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.TextBox2.Text = ""
        Me.DeptoTableAdapter.FillBylike(Me.Dtset.depto, "%" + "" + "%")

    End Sub

    Private Sub PaisListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaisListBox.SelectedIndexChanged
        Me.TextBox2.Text = ""

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Me.MunicipioTableAdapter.FillBylike(Me.Dtset.municipio, "%" + Me.TextBox3.Text + "%")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.MunicipioTableAdapter.FillBylike(Me.Dtset.municipio, "%" + Me.TextBox3.Text + "%")
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Me.TextBox3.Text = ""
        Me.MunicipioTableAdapter.FillBylike(Me.Dtset.municipio, "%" + "" + "%")
    End Sub

    Private Sub DeptoListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeptoListBox.SelectedIndexChanged
        Me.TextBox3.Text = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        variables.modo = 0

        Dim apais As New paises
        apais.ShowDialog()
        Me.TextBox1.Text = ""
        Me.PaisTableAdapter.Fill(Me.Dtset.pais)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.PaisBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Paises")
        Else
            variables.modo = 1
            variables.idpais = Me.PaisListBox.SelectedValue
            Dim epais As New paises
            epais.ShowDialog()
            Me.PaisTableAdapter.FillBylike(Me.Dtset.pais, "%" + Me.TextBox1.Text + "%")
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If Me.PaisBindingSource.Count = 0 Then
            MsgBox("Debe Ingresar un Pais antes de continuar", MsgBoxStyle.Exclamation, "Departamentos")
        Else
            variables.modo = 0
            Dim adepto As New depto
            variables.idpais = Me.PaisListBox.SelectedValue

            adepto.ShowDialog()
            Me.TextBox2.Text = ""
            Me.DeptoTableAdapter.Fill(Me.Dtset.depto)

        End If


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Me.DeptoBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Departamentos")
        Else
            variables.modo = 1
            variables.iddepto = Me.DeptoListBox.SelectedValue
            Dim edepto As New depto
            edepto.ShowDialog()
            Me.DeptoTableAdapter.FillBylike(Me.Dtset.depto, "%" + Me.TextBox2.Text + "%")
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        If Me.DeptoBindingSource.Count = 0 Then
            MsgBox("Debe Ingresar un Departamento antes de continuar", MsgBoxStyle.Exclamation, "Municipio")
        Else
            variables.modo = 0
            Dim amunicipio As New municipio
            variables.iddepto = Me.DeptoListBox.SelectedValue

            amunicipio.ShowDialog()
            Me.TextBox3.Text = ""
            Me.MunicipioTableAdapter.Fill(Me.Dtset.municipio)
        End If


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        If Me.MunicipioBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Municipios")
        Else
            variables.modo = 1
            variables.idmunicipio = Me.MunicipioListBox.SelectedValue
            Dim emunicipio As New municipio
            emunicipio.ShowDialog()
            Me.MunicipioTableAdapter.FillBylike(Me.Dtset.municipio, "%" + Me.TextBox3.Text + "%")
        End If
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Me.MunicipioBindingSource.Count = 0 Then
            MsgBox("Debe Ingresar un Municipio antes de continuar", MsgBoxStyle.Exclamation, "General")
        Else
            variables.modo = 0
            Dim ageneral As New general
            variables.idmunicipio = Me.MunicipioListBox.SelectedValue
            ageneral.ShowDialog()
            Me.TextBox4.Text = ""
            Me.GeneralTableAdapter.Fill(Me.Dtset.general)

        End If


    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Me.GeneralBindingSource.Count = 0 Then
            MsgBox("Lista Vacia", MsgBoxStyle.Exclamation, "Municipios")
        Else
            variables.modo = 1
            variables.idgeneral = Me.GeneralListBox.SelectedValue
            Dim egeneral As New general
            egeneral.ShowDialog()
            Me.GeneralTableAdapter.FillBylike(Me.Dtset.general, "%" + Me.TextBox4.Text + "%")
        End If
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click

    End Sub
    Public Sub eliminarpais()
        Dim mycommand As New SqlCommand
        Dim conn As New SqlConnection
        conn.ConnectionString = My.Settings.smConnectionString
        conn.Open()
        mycommand = New SqlCommand
        mycommand.Connection = conn

        If Me.PaisBindingSource.Count = 0 Then
            MsgBox("No hay elementos en la lista", MsgBoxStyle.Exclamation, "Paises")
        Else
            If Me.PaisListBox.SelectedIndex = 0 Then
                MsgBox("No se puede Eliminar el Registro", MsgBoxStyle.Exclamation, "Paises")
            Else
                Try
                    mycommand.CommandText = "update capacitadores set idpais=1 where idpais=@varidpas"
                    mycommand.Parameters.AddWithValue("@varidpas", Me.PaisListBox.SelectedValue)
                    mycommand.ExecuteNonQuery()

                    mycommand.CommandText = "update mov_politico set idpais=1 where idpais=@varidpasa"
                    mycommand.Parameters.AddWithValue("@varidpasa", Me.PaisListBox.SelectedValue)
                    mycommand.ExecuteNonQuery()

                    
                Catch ex As Exception

                End Try
            End If
        End If


    End Sub

    Private Sub rpt_paisToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_paisToolStripMenuItem1.Click
        Try

            Me.PaisTableAdapter.Fill(Me.Dtset.pais)

            Dim vp As New Reporte
            Dim rpt As New rpt_pais

            rpt.Database.Tables("Pais").SetDataSource(Me.Dtset.Tables("Pais"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Pais")

        End Try
    End Sub

    Private Sub rpt_deptosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_deptosToolStripMenuItem1.Click
        Try

            Me.Rpt_deptosTableAdapter.Fill(Me.Dtset.rpt_deptos)

            Dim vp As New Reporte
            Dim rpt As New rpt_deptos

            rpt.Database.Tables("rpt_deptos").SetDataSource(Me.Dtset.Tables("rpt_deptos"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Departamentos")

        End Try
    End Sub

    Private Sub rpt_municipiosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rpt_municipiosToolStripMenuItem1.Click
        Try

            Me.Rpt_municipioTableAdapter.Fill(Me.Dtset.rpt_municipio)

            Dim vp As New Reporte
            Dim rpt As New rpt_municipios

            rpt.Database.Tables("rpt_municipio").SetDataSource(Me.Dtset.Tables("rpt_municipio"))

            vp.CrystalReportViewer1.ReportSource = rpt

            vp.Show()

        Catch ex As Exception
            MsgBox("No se puede mostrar la informacion", MsgBoxStyle.Exclamation, "Municipios")

        End Try
    End Sub
End Class