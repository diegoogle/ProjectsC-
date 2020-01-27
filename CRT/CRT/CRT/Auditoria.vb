Public Class Auditoria
    Private conexionDB As New ConexionDB
    Private dTableAuditoria As DataTable
    Private dTableAllAuditorias As DataTable
    Private dTableListaAuditado As DataTable
    Private user As String
    Private sql As String
    Private auditoria As Long
    Private nameContainer As String
    Private lns As Double
    Private lnsOrdenadas As Double
    Private qtyOrdenada As Double
    Private qtyCapturada As Double
    Private lnsError As Double
    Private pzsError As Double
    Private avgPzs As Double
    Private avgLns As Double
    Public Sub New()
        Console.WriteLine("Auditoria abierto")
    End Sub
    Public Sub New(porPuntos As Boolean)
        Try
            dTableAllAuditorias = New DataTable
            Console.WriteLine("setDTableAuditoria iniciado")
            If porPuntos Then
                sql = "SELECT AUDITORIA AS AUDIT, USUARIO AS _USER, FECHA AS DATE_REG, CONTENEDOR AS _CONTAINER, PIEZAS_ERROR AS PIECES_WRNG, LNS_ERROR AS LINES_WRNG, " &
                "FORMAT(AVG_PZS, 'Percent') AS ACCURACY_PIECES, FORMAT(AVG_LNS, 'Percent') AS ACCURACY_LINES FROM [AUDITORIAS] ORDER BY AVG_PZS DESC"
                Console.WriteLine(sql)
            Else
                sql = "SELECT AUDITORIA AS AUDIT, USUARIO AS _USER, FECHA AS DATE_REG, CONTENEDOR AS _CONTAINER, PIEZAS_ERROR AS PIECES_WRNG, LNS_ERROR AS LINES_WRNG, " &
                "FORMAT(AVG_PZS, 'Percent') AS ACCURACY_PIECES, FORMAT(AVG_LNS, 'Percent') AS ACCURACY_LINES FROM [AUDITORIAS] ORDER BY AUDITORIA DESC"
            End If
            conexionDB.setDataSet(sql)
            dTableAllAuditorias = conexionDB.getDataTable
        Catch ex As Exception
            Console.WriteLine("setDTableAuditoria error " & ex.Message)
        Finally
            Console.WriteLine("setDTableAuditoria terminado")
        End Try
    End Sub
    Public Sub New(idAuditoria As Long)
        Me.auditoria = idAuditoria
        setDTableAuditoria(idAuditoria)
    End Sub
    Public Sub actualizaDetalleAuditoria(idAuditoria As Long, tiempo As String)
        avgPzs = 0
        avgLns = 0
        Try
            setResultadoAuditoria(idAuditoria)
            setDTableAuditoria(idAuditoria)
            If pzsError > 0 Then
                avgLns = 1 - (lnsError / lnsOrdenadas)
                avgPzs = 1 - (pzsError / qtyOrdenada)
            Else
                avgPzs = 1
                avgLns = 1
            End If
            conexionDB.openDB()
            sql = "UPDATE [AUDITORIAS] SET PIEZAS_INGRESADAS = " & qtyCapturada & ", PIEZAS_ERROR = " & pzsError &
            ", LNS_INGRESADAS = " & lns & ", LNS_ERROR = " & lnsError & ", AVG_PZS = " & FormatNumber(avgPzs, 4) &
            ", AVG_LNS = " & FormatNumber(avgLns, 4) & ", TIEMPO = '" & tiempo & "' WHERE(AUDITORIA = " & idAuditoria & ")"
            conexionDB.runInsert(sql)
        Catch ex As Exception
            Console.WriteLine("actualizaDetalleAuditoria error: " & ex.Message)
        Finally
            conexionDB.closeDB()
        End Try
    End Sub
    Public Sub insertaNuevaAuditoria(usuario As String, contenedor As String, piezasPedidas As Double,
                                     lineasPedidas As Double)
        Try
            Console.WriteLine("insertaNuevaAuditoria iniciado")
            sql = "INSERT INTO [AUDITORIAS](USUARIO, FECHA, CONTENEDOR, PIEZAS_PEDIDAS, LNS_PEDIDAS) " &
            " VALUES('" & usuario & "', #" & Now & "#, '" & contenedor & "', " & piezasPedidas & ", " & lineasPedidas & ")"
            Console.WriteLine(sql)
            conexionDB.openDB()
            conexionDB.runInsert(sql)
        Catch ex As Exception
            Console.WriteLine("insertaNuevaAuditoria error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine("insertaNuevaAuditoria terminado")
        End Try
    End Sub
    Public Sub updateDetalleAuditoria(idAuditoria As Long, sku As Long, qty As Integer)
        Try
            Console.WriteLine("updateDetalleAuditoria iniciado")
            conexionDB.openDB()
            Dim cantError As Integer
            sql = "SELECT QTY_ORDENADA FROM [DETALLE_AUDITORIA] WHERE(AUDITORIA = " & idAuditoria & " AND SKU = " & sku & ")"
            conexionDB.runRequest(sql)
            While conexionDB.getReader.Read
                Dim qty_orden As Integer = conexionDB.getReader.GetInt32(0)
                cantError = Math.Abs(qty_orden - qty)
            End While
            sql = "UPDATE [DETALLE_AUDITORIA] SET QTY_CAPTURADA = " & qty & ", QTY_ERROR = " & cantError & " WHERE(AUDITORIA = " & idAuditoria & " AND SKU = " & sku & ")"
            conexionDB.runInsert(sql)
        Catch ex As Exception
            Console.WriteLine("updateDetalleAuditoria error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine("updateDetalleAuditoria terminado")
        End Try
    End Sub
    Public Sub insertaDetalleAuditoria(dTable As DataTable)
        Try
            Console.WriteLine("insertaDetalleAuditoria iniciado")
            conexionDB.openDB()
            For Each row As DataRow In dTable.Rows
                sql = "INSERT INTO [DETALLE_AUDITORIA](AUDITORIA, CONTENEDOR, SKU, QTY_ORDENADA, QTY_CAPTURADA, QTY_ERROR) " &
                "VALUES(" & row.Item(3) & ", '" & row.Item(0) & "', " &
                    row.Item(1) & ", " & row.Item(2) & ", " & row.Item(4) & ", " & row.Item(5) & ")"
                conexionDB.runInsert(sql)
            Next
        Catch ex As Exception
            Console.WriteLine("insertaDetalleAuditoria error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine("insertaDetalleAuditoria terminado")
        End Try
    End Sub
    Public Sub setResultadoAuditoria(idAuditoria As Long)
        lns = 0
        lnsOrdenadas = 0
        qtyOrdenada = 0
        lnsError = 0
        pzsError = 0
        qtyCapturada = 0
        Try
            Console.WriteLine("setResultadoAuditoria iniciado")
            Dim dTable As New DataTable
            sql = "SELECT SKU, QTY_ORDENADA, QTY_CAPTURADA, QTY_ERROR FROM [DETALLE_AUDITORIA] WHERE(AUDITORIA = " & idAuditoria & ")"
            Console.WriteLine(sql)
            conexionDB.setDataSet(sql)
            dTable = conexionDB.getDataTable
            For Each row As DataRow In dTable.Rows
                lnsOrdenadas += 1
                qtyOrdenada += row.Item(1)
                qtyCapturada += row.Item(2)
                If (row.Item(1) <> row.Item(2)) Then
                    lnsError += 1
                    pzsError += row.Item(3)
                End If
                If row.Item(2) > 0 Then
                    lns += 1
                End If
            Next
        Catch ex As Exception
            Console.WriteLine("setResultadoAuditoria error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine("setResultadoAuditoria terminado")
        End Try
    End Sub
    Public Function getAuditoriaId() As Long
        Dim result As Long = 0
        Try
            Console.WriteLine("getAuditoriaId iniciado")
            sql = "SELECT TOP 1 AUDITORIA FROM [AUDITORIAS] ORDER BY AUDITORIA DESC"
            Console.WriteLine(sql)
            conexionDB.openDB()
            conexionDB.runRequest(sql)
            While conexionDB.getReader.Read
                result = conexionDB.getReader.GetInt32(0)
            End While
            Console.WriteLine("ID AUDITORIA: " & result)
        Catch ex As Exception
            Console.WriteLine("getAuditoriaId error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            getAuditoriaId = result
            Console.WriteLine("getAuditoriaId terminado")
        End Try
    End Function
    Private Sub setDTableAuditoria(idAuditoria As Long)
        Try
            dTableAuditoria = New DataTable
            Console.WriteLine("setDTableAuditoria iniciado")
            sql = "SELECT * FROM [AUDITORIAS] WHERE(AUDITORIA = " & idAuditoria & ")"
            conexionDB.setDataSet(sql)
            dTableAuditoria = conexionDB.getDataTable
            For Each row As DataRow In dTableAuditoria.Rows
                If row.Item(0) > 0 Then
                    Console.WriteLine("AUDITORIA POSITIVA: " & Me.auditoria)
                Else
                    Console.WriteLine("AUDITORIA NEGATIVA: " & Me.auditoria)
                End If
            Next
        Catch ex As Exception
            Console.WriteLine("setDTableAuditoria error " & ex.Message)
            Me.auditoria = 0
            Console.WriteLine("AUDITORIA: " & Me.auditoria)
        Finally
            Console.WriteLine("setDTableAuditoria terminado")
        End Try
    End Sub
    Public Sub setDtableListaAuditado(idAuditoria As Long, conRequired As Boolean)
        Try
            dTableAllAuditorias = New DataTable
            Console.WriteLine("setDtableListaAuditado iniciado")
            If conRequired = False Then
                sql = "SELECT DETALLE_AUDITORIA.SKU AS ITEM, ITEMS.PARTE AS PART, ITEMS.DESCRIPCION AS DESCRIPTION, DETALLE_AUDITORIA.QTY_CAPTURADA AS SCANNED " &
                "FROM DETALLE_AUDITORIA INNER JOIN ITEMS ON DETALLE_AUDITORIA.SKU = ITEMS.UPC " &
                "WHERE (DETALLE_AUDITORIA.AUDITORIA= " & idAuditoria & " AND DETALLE_AUDITORIA.QTY_CAPTURADA > 0)"
            Else
                sql = "SELECT DETALLE_AUDITORIA.SKU AS ITEM, ITEMS.PARTE AS PART, ITEMS.DESCRIPCION AS DESCRIPTION, " &
                "DETALLE_AUDITORIA.QTY_ORDENADA AS REQUIRED, DETALLE_AUDITORIA.QTY_CAPTURADA AS SCANNED, DETALLE_AUDITORIA.QTY_ERROR AS ERROR " &
                "FROM DETALLE_AUDITORIA INNER JOIN ITEMS ON DETALLE_AUDITORIA.SKU = ITEMS.UPC " &
                "WHERE (DETALLE_AUDITORIA.AUDITORIA= " & idAuditoria & ")"
            End If
            conexionDB.setDataSet(sql)
            dTableAllAuditorias = conexionDB.getDataTable
        Catch ex As Exception
            Console.WriteLine("setDtableListaAuditado error " & ex.Message)
        Finally
            Console.WriteLine("setDtableListaAuditado terminado")
        End Try
    End Sub
    Public Property propAuditoria As Long
        Get
            Return auditoria
        End Get
        Set(value As Long)
            auditoria = value
        End Set
    End Property
    Public Property propNameContainer As String
        Get
            Return nameContainer
        End Get
        Set(value As String)
            nameContainer = value
        End Set
    End Property
    Public Property propDTableAuditoria As DataTable
        Get
            Return dTableAuditoria
        End Get
        Set(value As DataTable)
            dTableAuditoria = value
        End Set
    End Property
    Public Property propDTableAllAuditorias As DataTable
        Get
            Return dTableAllAuditorias
        End Get
        Set(value As DataTable)
            dTableAllAuditorias = value
        End Set
    End Property
    Public Property propDTableListaAuditado As DataTable
        Get
            Return dTableListaAuditado
        End Get
        Set(value As DataTable)
            dTableListaAuditado = value
        End Set
    End Property
    Public Property propAvgPzs As Double
        Get
            Return avgPzs
        End Get
        Set(value As Double)
            avgPzs = value
        End Set
    End Property
    Public Property propAvgLns As Double
        Get
            Return avgLns
        End Get
        Set(value As Double)
            avgLns = value
        End Set
    End Property
End Class
