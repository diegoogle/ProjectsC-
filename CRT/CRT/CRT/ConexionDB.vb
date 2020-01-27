Imports System.Data.OleDb
Public Class ConexionDB
    Private ruta As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\QC_DB.mdb;Persist Security Info=false;Jet OLEDB:Database Password=''"
    Private conexion As OleDbConnection 'CONEXION OLEDB, DEBE INICIALIZARSE
    Private ordenSQL As OleDbCommand 'COMANDO PARA EJECUTAR SQL
    Private dReader As OleDbDataReader 'VALOR QUE REGRESAN LOS SELECT
    Private dAdapter As OleDbDataAdapter 'ADAPTADOR
    Private dSet As DataSet 'DATA SET
    Private dTable As DataTable 'DATA TABLE   
    Public Sub setDataSet(ByVal requestSql As String)
        Try
            dTable = New DataTable
            openDB() 'EJECUTA EL PROCESO DE ABRIR LA CONEXION
            dAdapter = New OleDbDataAdapter
            dSet = New DataSet
            ordenSQL = New OleDbCommand(requestSql, conexion) 'INGRESA EL QUERY Y EL ARCHIVO DE LA CONEXION
            dAdapter.SelectCommand = ordenSQL
            dAdapter.Fill(dSet)
            dTable = dSet.Tables(0)
        Catch ex As Exception
            Console.WriteLine("***   ***ConexionDB:[setDataSet] error: " & ex.Message & "***    ***")
        Finally 'NO RETORNA VALOR, EL RESULTADO SE ALMACENA EN DATASET
            dSet.Dispose()
            ordenSQL.Dispose()
            dAdapter.Dispose()
            closeDB() 'CIERRA CONEXION
            Console.WriteLine("ConexionDB:[setDataSet] terminado " & Now)
        End Try
    End Sub 'CONSULTA EL QUERY Y LO ALMACENA DENTRO DEL DATASET
    Public Sub runRequest(ByVal requestSQL As String)
        Try
            openDB()
            Console.WriteLine("ConexionDB:[runRequest] iniciado")
            ordenSQL = New OleDbCommand(requestSQL, conexion)
            Console.WriteLine(requestSQL)
            dReader = ordenSQL.ExecuteReader
        Catch ex As Exception
            Console.WriteLine("***   ***ConexionDB:[runRequest] error " & ex.Message & "***   ***")
        Finally 'NO PUEDE CERRAR CONEXION, HASTA QUE EL PROCESO EXTERNO TERMINE.
            Console.WriteLine("ConexionDB:[runRequest] terminado")
        End Try
    End Sub 'REALIZA LA CONSULTA, RECIBE QUERY STRING, NO CIERRA LA DB, CERRAR DESPUES DE LA LECTURA
    Public Sub closeDB()
        Console.WriteLine("[closeDB] cerrado")
        conexion.Close()
    End Sub 'CIERRA CONEXION
    Public Sub runInsert(ByVal insertSQL As String)
        Try
            Console.WriteLine("ConexionDB:[runInsert] iniciado")
            ordenSQL = New OleDbCommand(insertSQL, conexion)
            ordenSQL.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("***   ***ConexionDB:[runInsert] error:  " & ex.Message & "***    ***")
            Console.WriteLine(insertSQL)
        Finally
            Console.WriteLine("ConexionDB:[runInsert] terminado")
        End Try
    End Sub 'RECIBE SQL STRING PARA INSERTAR EN DB_DB
    Public Function openDB() As Boolean
        Try
            Console.WriteLine("ConexionDB:[openDB] iniciado")
            conexion = New OleDbConnection(ruta)
            conexion.Open()
            openDB = True
            Console.WriteLine("ConexionDB:[openDB] terminado")
        Catch ex As Exception
            MsgBox("NO ES POSIBLE CONECTAR A DB_DB", vbCritical, "ERROR DE CONEXION")
            openDB = False
        End Try
    End Function 'ABRE CONEXION
    Public Function getOrdenSql() As OleDbCommand
        Return ordenSQL
    End Function 'REGRESA COMMAND SQL
    Public Function getReader() As OleDbDataReader
        Return dReader
    End Function 'REGRESA DATA READER
    Public Function getRuta() As String
        Return ruta
    End Function 'REGRESA RUTA DE LA DB
    Public Function getDataSet() As DataSet
        Return dSet
    End Function 'REGRESA DATA SET
    Public Function getDataTable() As DataTable 'REGRESA DATA TABLE
        Return dTable
        dTable = New DataTable
    End Function
    Public Function getAdapter() As OleDbDataAdapter
        Return dAdapter
    End Function
End Class
