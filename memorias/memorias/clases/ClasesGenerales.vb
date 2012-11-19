Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Data.OleDb
Public Class ClasesGenerales

    Public Class SQLExecuter

#Region "Definicion de Variables"

        Private sqlcon As SqlConnection, sqldba As SqlDataAdapter
        Private sqlcom As SqlCommand
        Private dstemp As New DataSet
        'Private _servidor As String = "NB-ARFG\HOMEDEVELOPER"
        'Private _servidor As String = "192.168.3.1\SQLGLOBAL"
        Private _servidor As String = "DESKTOP"
        Private _BasedeDatos As String = ""
        Private _nombre As String = ""
        Private _conexion As String = "Persist Security Info=false;Integrated Security=SSPI;DataBase=" & _
        _BasedeDatos & ";Connection Timeout=240000;Server=" & _servidor

#End Region

#Region "Contructores"

        Public Sub New()
        End Sub

        Public Sub New(ByVal basededatos As String)
            _BasedeDatos = basededatos
            checkconsistency()
        End Sub

        Public Sub New(ByVal servidor As String, ByVal basededatos As String)
            _servidor = servidor
            _BasedeDatos = basededatos
            checkconsistency()
        End Sub

#End Region

#Region "Propiedades Publicas"
        ' Parametros para la conexion de la tabla
        Public Property servidor() As String
            Get
                Return _servidor
            End Get
            Set(ByVal value As String)
                _servidor = value
                checkconsistency()
            End Set
        End Property
        Public Property basededatos() As String
            Get
                Return _BasedeDatos
            End Get
            Set(ByVal value As String)
                _BasedeDatos = value
                checkconsistency()
            End Set
        End Property
        Public Property conexion() As String
            Get
                Return _conexion
            End Get
            Set(ByVal value As String)
                _conexion = value
            End Set
        End Property
#End Region

#Region "Funciones, Sub Publicas"

        Public Sub traer_datos(ByVal _query As String, ByVal _nombre As String, ByVal dstemp As DataSet, Optional ByVal ClearData As Boolean = False)

            '***********************
            '* Verificar Variables *
            '***********************
            If _BasedeDatos = "" Then
                MsgBox("El nombre de la base de datos no debe de estar en blanco")
                dstemp = Nothing
                Exit Sub
            ElseIf _query = "" Then
                MsgBox("El query esta en blanco, no pude extraer los datos")
                dstemp = Nothing
                Exit Sub
            ElseIf _nombre = "" Then
                MsgBox("El nombre de la tabla no debe de estar vacio")
                dstemp = Nothing
                Exit Sub
            End If
            If ClearData Then
                If dstemp.Tables.Contains(_nombre) Then dstemp.Tables(_nombre).Clear()
            End If

            '*****************************
            '* Extraer datos de la tabla *
            '*****************************
            Try

                Cursor.Current = Cursors.WaitCursor
                sqlcon = New SqlConnection(_conexion)
                sqlcon.Open()
                sqldba = New SqlDataAdapter(_query, _conexion)
                sqldba.SelectCommand.CommandTimeout = 120
                sqldba.Fill(dstemp, _nombre)
                sqlcon.Close()

            Catch ex As SqlException

                Cursor.Current = Cursors.Default
                MsgBox(ex.Message & ", No se realizo la extracción de los datos", 48, variables.titulo)
                dstemp = Nothing

            Finally

                Cursor.Current = Cursors.Default

            End Try

        End Sub

        Public Sub traer_datosExcep(ByVal _query As String, ByVal _nombre As String, ByVal dstemp As DataSet)

            '***********************
            '* Verificar Variables *
            '***********************
            If _BasedeDatos = "" Then
                MsgBox("El nombre de la base de datos no debe de estar en blanco")
                dstemp = Nothing
                Exit Sub
            ElseIf _query = "" Then
                MsgBox("El query esta en blanco, no pude extraer los datos")
                dstemp = Nothing
                Exit Sub
            ElseIf _nombre = "" Then
                MsgBox("El nombre de la tabla no debe de estar vacio")
                dstemp = Nothing
                Exit Sub
            End If

            '*****************************
            '* Extraer datos de la tabla *
            '*****************************
            Try

                Cursor.Current = Cursors.WaitCursor
                sqlcon = New SqlConnection(_conexion)
                sqlcon.Open()
                sqldba = New SqlDataAdapter(_query, _conexion)
                sqldba.SelectCommand.CommandTimeout = 120
                sqldba.Fill(dstemp, _nombre)
                sqlcon.Close()

            Catch ex As SqlException

                Cursor.Current = Cursors.Default
                Throw New ArgumentException("Error: " & ex.Message)
                dstemp = Nothing

            Finally

                Cursor.Current = Cursors.Default

            End Try

        End Sub

        Public Sub Update_Datos(ByVal _query As String, ByVal _nombre As String, ByVal dsorig As DataSet)

            '***********************
            '* Verificar Variables *
            '***********************
            If _BasedeDatos = "" Then
                MsgBox("El nombre de la base de datos no debe de estar en blanco")
                dstemp = Nothing
                Exit Sub
            ElseIf _query = "" Then
                MsgBox("El query esta en blanco, no pude extraer los datos")
                dstemp = Nothing
                Exit Sub
            ElseIf _nombre = "" Then
                MsgBox("El nombre de la tabla no debe de estar vacio")
                dstemp = Nothing
                Exit Sub
            ElseIf Not dsorig.Tables(_nombre).PrimaryKey.Length > 0 Then
                MsgBox("Debe de definir un indice primario para poder utilizar esta opción")
                dstemp = Nothing
                Exit Sub
            End If

            '*****************************
            '* Extraer datos de la tabla *
            '*****************************
            Try

                Dim dstemp As New DataSet
                Cursor.Current = Cursors.WaitCursor
                sqlcon = New SqlConnection(_conexion)
                sqlcon.Open()
                sqldba = New SqlDataAdapter(_query, _conexion)
                sqldba.Fill(dstemp, _nombre)
                sqlcon.Close()
                Try
                    Try
                        dsorig.Tables(_nombre).BeginLoadData()
                        dsorig.Tables(_nombre).Merge(dstemp.Tables(_nombre))
                        dsorig.Tables(_nombre).EndLoadData()
                    Catch ex As RowNotInTableException
                    End Try
                Catch ex As IndexOutOfRangeException
                End Try


            Catch ex As SqlException

                Cursor.Current = Cursors.Default
                MsgBox(ex.Message & ", No se realizo la extracción de los datos", 48, variables.titulo)
                dstemp = Nothing

            Finally

                Cursor.Current = Cursors.Default

            End Try


        End Sub

        Public Function ExecuteQuery(ByVal _query As String)

            Dim retorna As Boolean = False
            Try
                sqlcon = New SqlConnection(_conexion)
                sqlcon.Open()
                sqlcom = sqlcon.CreateCommand
                sqlcom.CommandText = _query
                sqlcom.ExecuteNonQuery()
                sqlcon.Close()
            Catch ex As SqlException
                Cursor.Current = Cursors.Default
                MsgBox(ex.Message & ", Error al intentar ejecutar el query", 48, variables.titulo)
                dstemp = Nothing
            Finally
                Cursor.Current = Cursors.Default
                retorna = True
            End Try

            Return retorna

        End Function

        Public Function ExecuteQueryScalar(ByVal _query As String)

            Dim retorna = Nothing
            Try

                sqlcon = New SqlConnection(_conexion)
                sqlcon.Open()
                sqlcom = sqlcon.CreateCommand
                sqlcom.CommandText = _query
                retorna = sqlcom.ExecuteScalar()
                sqlcon.Close()

            Catch ex As SqlException

                Cursor.Current = Cursors.Default
                MsgBox(ex.Message & ", Error al intentar ejecutar el query", 48, variables.titulo)
                dstemp = Nothing

            Finally

                Cursor.Current = Cursors.Default

            End Try

            Return retorna

        End Function

        Public Function ExecuteQueryScalarExc(ByVal _query As String)

            Dim retorna = Nothing
            Try

                sqlcon = New SqlConnection(_conexion)
                sqlcon.Open()
                sqlcom = sqlcon.CreateCommand
                sqlcom.CommandText = _query
                retorna = sqlcom.ExecuteScalar()
                sqlcon.Close()

            Catch ex As SqlException

                Cursor.Current = Cursors.Default
                Throw New ArgumentException("Error: " & ex.Message)
                dstemp = Nothing

            Finally

                Cursor.Current = Cursors.Default

            End Try

            Return retorna

        End Function


#End Region

#Region "Funciones, Sub Privadas"

        Private Sub checkconsistency()
            _conexion = "Persist Security Info=false;Integrated Security=SSPI;DataBase=" & _
            _BasedeDatos & ";TimeOut=60;Server=" & _servidor
        End Sub
#End Region

    End Class

   



    Public Class ExcelSQLExecuter


#Region "Definicion de Variables"

        Private oledbcon As OleDbConnection, oledbda As OleDbDataAdapter
        Private oledbcom As OleDbCommand
        Private dstemp As New DataSet
        Private _nombre As String = ""
        Private m_rutaarchivo As String = ""
        Private provider As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};" & _
                                     "Extended Properties={1};"
        Private _conexion As String = ""
        Private extendedp() As String = {"Excel 8.0", "Excel 12.0", "Excel 14.0"}

#End Region

#Region "Contructores"

        Public Sub New()
        End Sub

        Public Sub New(ByVal RutaArchivo As String)
            m_rutaarchivo = RutaArchivo
            Dim ext As String = ""
            If m_rutaarchivo.ToLower.Contains("xlsx") Then ext = extendedp(2) Else ext = extendedp(0)
            _conexion = String.Format(provider, RutaArchivo, ext)
        End Sub

#End Region

#Region "Propiedades Publicas"
        ' Parametros para la conexion de la tabla
        Public Property conexion() As String
            Get
                Return _conexion
            End Get
            Set(ByVal value As String)
                _conexion = value
            End Set
        End Property
        Public WriteOnly Property Ruta_Archivo()
            Set(ByVal value)
                m_rutaarchivo = value
                Dim ext As String = ""
                If m_rutaarchivo.ToLower.Contains("xlsx") Then ext = extendedp(2) Else ext = extendedp(0)
                _conexion = String.Format(provider, m_rutaarchivo, ext)
            End Set
        End Property
#End Region

#Region "Funciones, Sub Publicas"

        Public Sub traer_datos(ByVal _query As String, ByVal _nombre As String, ByVal dstemp As DataSet)

            '***********************
            '* Verificar Variables *
            '***********************
            If _query = "" Then
                MsgBox("El query esta en blanco, no pude extraer los datos")
                dstemp = Nothing
                Exit Sub
            ElseIf _nombre = "" Then
                MsgBox("El nombre de la tabla no debe de estar vacio")
                dstemp = Nothing
                Exit Sub
            ElseIf _conexion = "" Then
                MsgBox("Debe de indicar la ruta del archivo del cual importar los datos")
                dstemp = Nothing
                Exit Sub
            End If

            '*****************************
            '* Extraer datos de la tabla *
            '*****************************
            Try
                Try
                    Cursor.Current = Cursors.WaitCursor
                    oledbcon = New OleDbConnection(_conexion)
                    oledbcon.Open()
                    oledbda = New OleDbDataAdapter(_query, _conexion)
                    oledbda.Fill(dstemp, _nombre)
                    oledbcon.Close()
                Catch ex As Exception
                    Cursor.Current = Cursors.Default
                    MsgBox(ex.Message & ", No se realizo la extracción de los datos", 48, variables.titulo)
                    dstemp = Nothing
                Finally
                    Cursor.Current = Cursors.Default
                End Try
            Catch ex As Exception
                MsgBox("Error : " & ex.Message, 48, variables.titulo)
            End Try

        End Sub

        Public Function ExecuteQuery(ByVal _query As String)

            Dim retorna As Boolean = False
            Try
                oledbcon = New OleDbConnection(_conexion)
                oledbcon.Open()
                oledbcom = oledbcon.CreateCommand
                oledbcom.CommandText = _query
                oledbcom.ExecuteNonQuery()
                oledbcon.Close()
            Catch ex As SqlException
                Cursor.Current = Cursors.Default
                MsgBox(ex.Message & ", Error al intentar ejecutar el query", 48, variables.titulo)
                dstemp = Nothing
            Finally
                Cursor.Current = Cursors.Default
                retorna = True
            End Try

            Return retorna

        End Function

        Public Function ExecuteQueryScalar(ByVal _query As String)

            Dim retorna = Nothing
            Try

                oledbcon = New OleDbConnection(_conexion)
                oledbcon.Open()
                oledbcom = oledbcon.CreateCommand
                oledbcom.CommandText = _query
                retorna = oledbcom.ExecuteScalar
                oledbcon.Close()

            Catch ex As SqlException

                Cursor.Current = Cursors.Default
                MsgBox(ex.Message & ", Error al intentar ejecutar el query", 48, variables.titulo)
                dstemp = Nothing

            Finally

                Cursor.Current = Cursors.Default

            End Try

            Return retorna

        End Function

        Public Function SheetName(ByVal SheetIndex As Integer) As String
            Dim tablename As String = Nothing
            Try
                oledbcon = New OleDbConnection(_conexion)
                oledbcon.Open()
                Dim schemaTable As New DataTable
                schemaTable = oledbcon.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, "TABLE"})
                tablename = schemaTable.Rows(SheetIndex).Item("Table_Name")
                oledbcon.Close()

            Catch ex As Exception
                MsgBox(ex.Message, 48, variables.titulo)
                oledbcon.Close()
            End Try

            Return tablename

        End Function

#End Region

    End Class

End Class


