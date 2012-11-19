Public Class pick

#Region "Variables"
    Private ds As New DataSet
    Private sqle As New ClasesGenerales.SQLExecuter
    Private m_id As Integer = 0
    Private m_tipo As Integer = -1

    Public Enum TIPOPICK
        PAIS = 1
        DEPARTAMENTO = 2
        MUNICIPIO = 3
        CAPACITADOR = 4
        MEMORIA = 5
        GENERAL = 6
        MOVIMIENTO_POLITICO = 7
        PERIODO = 8
        TIPO_TALLER = 9
        REGION = 10
    End Enum

#End Region

#Region "SQL"
    Private Qpais As String = "select idpais as id,pais as nombre from pais"
    Private Qdepto As String = "select iddepto as id,depto as nombre from depto"
    Private Qmunicipio As String = "select idmunicipio as id,municipio as nombre from municipio"
    Private Qcapacitador As String = "select idcapacitador as id,nombre + ' ' + apellido as nombre from capacitadores"
    Private Qmemoria As String = "select idmemoria as id,tema as nombre from memorias"
    Private Qgeneral As String = "select * from vw_generalespick"
    Private QMovimiento As String = "select idmov as id,movimiento as nombre from dbo.mov_politico"
    Private Qperiodo As String = "select idperiodo as id,descripcion as nombre from dbo.periodo"
    Private QTipoTaller As String = "SELECT idtipotaller as id,descripcion as nombre FROM dbo.tipo_taller"
    Private Qregion As String = "select idregion as id,descripcion as nombre from dbo.region"

    

#End Region

#Region "Propiedades"
    Public Property ID() As Integer
        Get
            Return m_id
        End Get

        Set(ByVal value As Integer)
            m_id = value
            'Extraer()
            If GridView1.RowCount > value Then
                Me.GridView1.SelectRow(m_id)
            End If
        End Set
    End Property

    Public Property TIPO() As TIPOPICK
        Get
            Return m_id
        End Get

        Set(ByVal value As TIPOPICK)
            m_tipo = value
            Extraer()
            If GridView1.RowCount > value Then
                Me.GridView1.SelectRow(m_id)
            End If
        End Set
    End Property

   

#End Region

    Private Sub pkpais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Dtset.pais' table. You can move, or remove it, as needed.
        'Me.PaisTableAdapter.Fill(Me.Dtset.pais)
        sqle.servidor = My.Settings.Servidor
        sqle.basededatos = "sm"
        'Extraer()

    End Sub
    Private Sub Extraer()
        sqle.servidor = My.Settings.Servidor
        sqle.basededatos = "sm"
        Dim q As String = ""
        Dim colName As String = ""
        Dim colID As String = ""
        Select Case m_tipo
            Case 1
                q = Qpais
                colName = "PAIS"
            Case 2
                q = Qdepto
                colName = "DEPARTAMENTO"
            Case 3
                q = Qmunicipio
                colName = "MUNICIPIO"
            Case 4
                q = Qcapacitador
                colName = "CAPACITADOR"
            Case 5
                q = Qmemoria
                colName = "MEMORIA"
            Case 6
                q = Qgeneral
                colName = "DESCRIPCION"
            Case 7
                q = Qgeneral
                colName = "MOVIMIENTO"
            Case 8
                q = Qperiodo
                colName = "PERIODO"
            Case 9
                q = QTipoTaller
                colName = "TIPO TALLER"
            Case 10
                q = Qregion
                colName = "REGION"
        End Select
        If q.Trim = "" Then
            Exit Sub
        End If
        sqle.traer_datos(q, "data", ds, True)
        Me.GridControl1.DataSource = ds.Tables("data")
        GridView1.Columns(0).Caption = "CODIGO"
        GridView1.Columns(1).Caption = colName
        Me.Text = "Seleccione una OpciÛn"

        Me.GridControl1.Refresh()
    End Sub

    Private Sub CancelarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarToolStripMenuItem.Click
        m_id = 0
        Me.Close()
    End Sub


    Private Sub GridView1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        If e.FocusedRowHandle >= 0 Then
            Try
                Me.m_id = Me.GridView1.GetDataRow(Me.GridView1.FocusedRowHandle)("id")
            Catch ex As Exception
                m_id = 0
            End Try
        End If
    End Sub

    Private Sub AceptarToolStripMenuItgm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarToolStripMenuItem.Click
        Dim row As Integer = Me.GridView1.FocusedRowHandle
        If row >= 0 Then
            Try
                Me.m_id = Me.GridView1.GetDataRow(row)("id")
            Catch ex As Exception
                m_id = 0
            End Try
        End If
        If Not m_id > 0 Then
            MsgBox("Debe seleccionar una opci”n", MsgBoxStyle.Information, "data")
            Exit Sub
        Else
            Me.Close()
        End If
    End Sub
End Class