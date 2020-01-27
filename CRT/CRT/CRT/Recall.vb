Public Class Recall
    Private conexionDB As New ConexionDB
    Private tienda As Integer
    Private usuario As String
    Private credito As Long
    Private item As Items
    Private dTable As DataTable
    Private sql As String
    Private montoAcreditado As Double
    Private piezasAcreditadas As Integer
    Private piezasEnviadas As Integer = 22
    Private percentAcreditado As Double
    Public Sub New(usuario As String, tienda As String)
        Me.usuario = usuario
        Me.tienda = tienda
        insertaCredito(usuario, tienda)
        credito = getCreditoId()
        creaDTable()
    End Sub
    Public Sub New(credito As Long)
        Me.credito = credito
        setViewCredit(credito)
    End Sub
    Public Sub New()
        setViewAllCredits()
    End Sub
    Private Sub insertaCredito(usuario As String, tienda As Integer)
        Try
            Console.WriteLine("insertaCredito iniciado")
            conexionDB.openDB()
            sql = "INSERT INTO [CREDITOS](USUARIO, TIENDA) VALUES('" & usuario & "', " & tienda & ")"
            conexionDB.runInsert(sql)
        Catch ex As Exception
            Console.WriteLine("insertaCredito error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine("insertaCredito terminado")
        End Try
    End Sub
    Public Sub updateCredito()
        Try
            Console.WriteLine("updateCredito iniciado")
            setResultadoCredito(credito)
            sql = "UPDATE [CREDITOS] SET PIEZAS = " & piezasAcreditadas & ", MONTO = " & montoAcreditado &
                ", PIEZAS_ENVIADAS = " & piezasEnviadas & ", AVG_ACREDITADO = " & percentAcreditado & " WHERE(ID = " & credito & ")"
            conexionDB.openDB()
            conexionDB.runInsert(sql)
        Catch ex As Exception
            Console.WriteLine("updateCredito error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine("updateCredito terminado")
        End Try
    End Sub
    Private Sub setResultadoCredito(credito As Long)
        Try
            Console.WriteLine("setResultadoCredito iniciado")
            montoAcreditado = 0
            piezasAcreditadas = 0
            percentAcreditado = 0
            sql = "SELECT SUM(PIEZAS), SUM(MONTO) FROM [DETALLE_CREDITO] WHERE(ID = " & credito & ")"
            conexionDB.openDB()
            conexionDB.runRequest(sql)
            While conexionDB.getReader.Read
                piezasAcreditadas = conexionDB.getReader.GetDouble(0)
                montoAcreditado = conexionDB.getReader.GetDouble(1)
            End While
            percentAcreditado = (piezasAcreditadas / piezasEnviadas)
        Catch ex As Exception
            Console.WriteLine("setResultadoCredito error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine("setResultadoCredito terminado")
        End Try
    End Sub
    Private Function getCreditoId() As Long
        Dim result As Long = 0
        Try
            Console.WriteLine("getCreditoId iniciado")
            sql = "SELECT TOP 1 ID FROM [CREDITOS] ORDER BY ID DESC"
            Console.WriteLine(sql)
            conexionDB.openDB()
            conexionDB.runRequest(sql)
            While conexionDB.getReader.Read
                result = conexionDB.getReader.GetInt32(0)
            End While
            Console.WriteLine("ID CREDITO: " & result)
        Catch ex As Exception
            Console.WriteLine("getCreditoId error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            getCreditoId = result
            Console.WriteLine("getCreditoId terminado")
        End Try
    End Function
    Private Sub creaDTable()
        Try
            dTable = New DataTable
            dTable.Columns.Add("CREDIT", Type.GetType("System.Int32")) 'ITEM 0
            dTable.Columns.Add("ITEM", Type.GetType("System.Int32")) 'ITEM 1
            dTable.Columns.Add("QTY", Type.GetType("System.Int32")) 'ITEM 2
            dTable.Columns.Add("COST", Type.GetType("System.Double")) 'ITEM 3
        Catch ex As Exception
            Console.WriteLine("********creaDTable error: " & ex.Message)
        End Try
    End Sub
    Public Sub validaUpc(upc As Double, qty As Integer)
        Try
            Dim yaExiste As Boolean = False
            item = New Items(upc, qty)
            If item.propItem > 0 Then
                Dim row As DataRow = dTable.NewRow
                row(0) = credito
                row(1) = item.propItem
                row(2) = qty
                row(3) = (item.propCosto * qty)
                dTable.Rows.Add(row)
                Console.WriteLine("AGREGADO: " & row(0) & " " & row(1) & " " & row(2) & " " & row(3))
            Else
                MsgBox("ITEM " & upc & " DOES NOT EXIST")
                Console.WriteLine("NO AGREGADO")
            End If
        Catch ex As Exception
            Console.WriteLine("validaUpc error: " & ex.Message)
        End Try
    End Sub
    Public Sub insertaTabla()
        Try
            Console.WriteLine("insertaTabla iniciado")
            conexionDB.openDB()
            For Each row As DataRow In dTable.Rows
                sql = "INSERT INTO [DETALLE_CREDITO] VALUES(" & row.Item(0) & ", " & row.Item(1) & ", " & row.Item(2) & ", " & row.Item(3) & ")"
                conexionDB.runInsert(sql)
            Next
        Catch ex As Exception
            Console.WriteLine("insertaTabla error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine("insertaTabla terminado")
        End Try
    End Sub
    Public Property propDTable As DataTable
        Get
            Return dTable
        End Get
        Set(value As DataTable)
            dTable = value
        End Set
    End Property
    Public Property propCredito As Long
        Get
            Return credito
        End Get
        Set(value As Long)
            credito = value
        End Set
    End Property
    Public Property propMontoAcreditado As Double
        Get
            Return montoAcreditado
        End Get
        Set(value As Double)
            montoAcreditado = value
        End Set
    End Property
    Public Property propPercentAcreditado As Double
        Get
            Return percentAcreditado
        End Get
        Set(value As Double)
            percentAcreditado = value
        End Set
    End Property
    Public Sub setViewCredit(credito As Long)
        Try
            Console.WriteLine("setViewCredit iniciado")
            dTable = New DataTable
            sql = "SELECT SKU AS ITEM, PIEZAS AS QTY, FORMAT(MONTO, '$00.00') AS COST " &
            "FROM [DETALLE_CREDITO] WHERE(ID = " & credito & ")"
            conexionDB.setDataSet(sql)
            dTable = conexionDB.getDataTable
        Catch ex As Exception
            Console.WriteLine("setViewCredit error: " & ex.Message)
        Finally
            Console.WriteLine("setViewCredit terminado")
        End Try
    End Sub
    Public Sub setViewAllCredits()
        Try
            Console.WriteLine("setViewAllCredits iniciado")
            dTable = New DataTable
            sql = "SELECT ID AS CREDIT_NUMBER, USUARIO AS USER_NAME, TIENDA AS STORE, " &
                "PIEZAS_ENVIADAS AS RECEIVED_QTY, PIEZAS AS SCANNED_QTY, " &
                "FORMAT(AVG_ACREDITADO, 'Percent') AS ACCREDITED, FORMAT(MONTO, '$00.00') AS COST FROM [CREDITOS] " &
                "ORDER BY ID DESC"
            conexionDB.setDataSet(sql)
            dTable = conexionDB.getDataTable
        Catch ex As Exception
            Console.WriteLine("setViewAllCredits error: " & ex.Message)
        Finally
            Console.WriteLine("setViewAllCredits terminado")
        End Try
    End Sub
End Class


