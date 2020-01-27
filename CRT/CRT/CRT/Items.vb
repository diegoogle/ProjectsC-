Public Class Items
    Private conexionDB As New ConexionDB
    Private upc As Double
    Private item As Long
    Private descripcion As String
    Private numeroParte As String
    Private result As Boolean
    Private costo As Double
    Private sql As String
    Public Sub New(upc As Double)
        Me.upc = upc
        setItem(upc)
    End Sub
    Public Sub New(upc As Double, qty As Integer)
        Me.upc = upc
        setItem(upc, qty)
    End Sub
    Private Sub setItem(upc As Double)
        Try
            Console.WriteLine("setItem iniciado")
            item = 0
            descripcion = ""
            numeroParte = ""
            result = False
            sql = "SELECT SKU, DESCRIPCION, PARTE FROM [ITEMS] " &
                "WHERE(UPC = " & upc & ")"
            Console.WriteLine(sql)
            conexionDB.runRequest(sql)
            While conexionDB.getReader.Read
                item = conexionDB.getReader.GetInt32(0)
                descripcion = conexionDB.getReader.GetString(1)
                numeroParte = conexionDB.getReader.GetString(2)
                result = True
            End While
        Catch ex As Exception
            Console.WriteLine("setItem error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine(item & " " & numeroParte & " " & descripcion)
            Console.WriteLine("setItem terminado")
        End Try
    End Sub
    Private Sub setItem(sku As Long)
        Try
            Console.WriteLine("setItem iniciado")
            item = 0
            descripcion = ""
            numeroParte = ""
            result = False
            sql = "SELECT SKU, DESCRIPCION, PARTE FROM [ITEMS] " &
                "WHERE(SKU = " & sku & ")"
            Console.WriteLine(sql)
            conexionDB.runRequest(sql)
            While conexionDB.getReader.Read
                item = conexionDB.getReader.GetInt32(0)
                descripcion = conexionDB.getReader.GetString(1)
                numeroParte = conexionDB.getReader.GetString(2)
                result = True
            End While
        Catch ex As Exception
            Console.WriteLine("setItem error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine(item & " " & numeroParte & " " & descripcion)
            Console.WriteLine("setItem terminado")
        End Try
    End Sub
    Private Sub setItem(upc As Double, qty As Integer)
        Try
            Console.WriteLine("setItem iniciado")
            item = 0
            descripcion = ""
            numeroParte = ""
            costo = 0
            result = False
            sql = "SELECT SKU, DESCRIPCION, PARTE, COSTO  FROM [ITEMS] " &
                "WHERE(UPC = " & upc & ")"
            Console.WriteLine(sql)
            conexionDB.runRequest(sql)
            While conexionDB.getReader.Read
                item = conexionDB.getReader.GetInt32(0)
                descripcion = conexionDB.getReader.GetString(1)
                numeroParte = conexionDB.getReader.GetString(2)
                costo = conexionDB.getReader.GetDouble(3)
                result = True
            End While
        Catch ex As Exception
            Console.WriteLine("setItem error: " & ex.Message)
        Finally
            conexionDB.closeDB()
            Console.WriteLine(item & " " & numeroParte & " " & descripcion)
            Console.WriteLine("setItem terminado")
        End Try
    End Sub
    Public Property propDescripcion As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property
    Public Property propNumeroParte As String
        Get
            Return numeroParte
        End Get
        Set(value As String)
            numeroParte = value
        End Set
    End Property
    Public Property propResult As Boolean
        Get
            Return result
        End Get
        Set(value As Boolean)
            result = value
        End Set
    End Property
    Public Property propItem As Long
        Get
            Return item
        End Get
        Set(value As Long)
            item = value
        End Set
    End Property
    Public Property propCosto As Double
        Get
            Return costo
        End Get
        Set(value As Double)
            costo = value
        End Set
    End Property
End Class
