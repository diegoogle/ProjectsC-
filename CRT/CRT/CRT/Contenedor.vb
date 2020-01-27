Public Class Contenedor
    Private conexionDB As New ConexionDB
    Private contenedorName As String
    Private dTableContenedor As DataTable
    Private piezasPedidas As Double
    Private lineasPedidas As Double
    Private tiempo As String
    Private idAuditoria As Long
    Private sql As String
    Public Sub New(contenedor As String)
        Me.contenedorName = contenedor
        setContenedor(Me.contenedorName)
        setDTableContenedor(contenedor)
        setTiempoContenedor(contenedor)
    End Sub
    Public Sub New(contenedor As String, info As Boolean)
        Me.contenedorName = contenedor
        setContenedor(contenedor)
        setDTableContenedor(contenedor, info)
        setTiempoContenedor(contenedor)
    End Sub
    Private Sub setTiempoContenedor(contenedor)
        tiempo = "00:00:00"
        Try
            Console.WriteLine("setTiempoContenedor iniciado")
            sql = "SELECT LIMITE FROM [CONTENEDORES] " &
                "WHERE(CONTENEDOR = '" & contenedor & "')"
            Console.WriteLine(sql)
            conexionDB.openDB()
            conexionDB.runRequest(sql)
            While conexionDB.getReader.Read
                tiempo = conexionDB.getReader.GetString(0)
            End While
            Console.WriteLine("TIEMPO: " & tiempo)
        Catch ex As Exception
            Console.WriteLine("setTiempoContenedor error " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine("setTiempoContenedor terminado")
        End Try
    End Sub
    Public Sub actualizaAuditoria(auditoria As Long)
        Try
            Console.WriteLine("actualizaAuditoria iniciado")
            For Each row As DataRow In dTableContenedor.Rows
                row.Item(3) = auditoria
                row.Item(4) = 0
                row.Item(5) = row.Item(2)
            Next
        Catch ex As Exception
            Console.WriteLine("actualizaAuditoria error " & ex.Message)
        Finally
            Console.WriteLine("actualizaAuditoria terminado")
        End Try
    End Sub
    Public Sub setDTableContenedor(contenedor As String)
        Try
            dTableContenedor = New DataTable
            Console.WriteLine("setDTableContenedor iniciado")
            sql = "SELECT otd_cont_id, otd_part, otd_qty_done FROM [BASE] " &
                "WHERE(otd_cont_id = '" & contenedor & "')"
            conexionDB.setDataSet(sql)
            dTableContenedor = conexionDB.getDataTable
            dTableContenedor.Columns.Add("AUDITORIA", Type.GetType("System.Int32")) 'ITEM 3
            dTableContenedor.Columns.Add("QTY_CAPTURADA", Type.GetType("System.Int32")) 'ITEM 4
            dTableContenedor.Columns.Add("QTY_ERROR", Type.GetType("System.Int32")) ' ITEM 5                        
        Catch ex As Exception
            Console.WriteLine("setDTableContenedor error " & ex.Message)
        Finally
            Console.WriteLine("setDTableContenedor terminado")
        End Try
    End Sub
    Public Sub setDTableContenedor(contenedor As String, info As Boolean)
        Try
            dTableContenedor = New DataTable
            Console.WriteLine("setDTableContenedor iniciado")
            sql = "SELECT otd_cont_id, otd_part, otd_qty_done FROM [BASE] " &
                "WHERE(otd_cont_id = '" & contenedor & "')"
            conexionDB.setDataSet(sql)
            dTableContenedor = conexionDB.getDataTable
            dTableContenedor.Columns.Add("PART", Type.GetType("System.String")) 'ITEM 3
            dTableContenedor.Columns.Add("DESC", Type.GetType("System.String")) 'ITEM 4            
        Catch ex As Exception
            Console.WriteLine("setDTableContenedor error " & ex.Message)
        Finally
            Console.WriteLine("setDTableContenedor terminado")
        End Try
    End Sub
    Private Sub setContenedor(contenedor As String)
        Try
            Console.WriteLine("setContenedor iniciado")
            Dim dTable As New DataTable
            lineasPedidas = 0
            piezasPedidas = 0
            sql = "SELECT COUNT(otd_part) as lines, SUM(otd_qty_done) as pieces FROM [BASE] " &
                "WHERE(otd_cont_id = '" & contenedor & "')"
            Console.WriteLine(sql)
            conexionDB.setDataSet(sql)
            dTable = conexionDB.getDataTable
            For Each row As DataRow In dTable.Rows
                lineasPedidas = row.Item(0)
                piezasPedidas = row.Item(1)
            Next
        Catch ex As Exception
            Console.WriteLine("setContenedor error: " & ex.Message)
            MsgBox("NO EXISTE CONTENEDOR")
            lineasPedidas = 0
            piezasPedidas = 0
        Finally
            Console.WriteLine("setContenedor terminado")
            Console.WriteLine(lineasPedidas)
            Console.WriteLine(piezasPedidas)
        End Try
    End Sub
    Public Property propPiezasPedidas As Double
        Get
            Return piezasPedidas
        End Get
        Set(value As Double)
            piezasPedidas = value
        End Set
    End Property
    Public Property propLineasPedidas As Double
        Get
            Return lineasPedidas
        End Get
        Set(value As Double)
            lineasPedidas = value
        End Set
    End Property
    Public Property propDTableContenedor As DataTable
        Get
            Return dTableContenedor
        End Get
        Set(value As DataTable)
            dTableContenedor = value
        End Set
    End Property
    Public Property propTiempo As String
        Get
            Return tiempo
        End Get
        Set(value As String)
            tiempo = value
        End Set
    End Property
End Class
