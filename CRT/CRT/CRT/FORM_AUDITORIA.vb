Public Class FORM_AUDITORIA
    Private formMain As FORM_MAIN
    Private contenedor As Contenedor
    Private item As Items
    Private auditoria As New Auditoria
    Private estado As Integer
    Private conexionDb As New ConexionDB
    Private idAuditoria As Long
    Private contenedorName As String
    Private usuario As String
    Private tiempo As DateTime
    Private tiempoGenerado As DateTime
    Private iniciaAuditoria As Boolean
    '[1] = form cargado
    '[2] = captura nuevo contenedor
    '[3] = captura sku
    '[4] = captura qty
    Public Sub New(usuario As String)
        InitializeComponent()
        Me.Show()
        Me.usuario = usuario
    End Sub
    Private Sub FORM_AUDITORIA_Load(sender As Object, e As EventArgs) Handles Me.Load
        'cargaForm()
        estado = 1
        setEstado(estado)
        tiempo = "00:00:00"
        iniciaAuditoria = False
    End Sub
    Private Sub nueva()
        Try
            richComandos.Clear()
            lbl1.Visible = False
            lbl2.Visible = True
            lbl3.Visible = False
            txt1.Visible = False
            txt2.Visible = True
            txt3.Visible = False
            lbl2.Text = "CONTAINER"
            txt2.Select()
            estado = 2
        Catch ex As Exception

        End Try
    End Sub
    Private Sub capturaQty()
        txt3.ReadOnly = True
        txt4.Visible = True
        txt4.ReadOnly = False
        lbl4.Visible = True
        lbl4.Text = "QTY"
        txt4.Select()
        estado = 4
    End Sub
    Private Sub txt1_KeyDown(sender As Object, e As KeyEventArgs) Handles txt1.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                nueva()
            ElseIf e.KeyCode = Keys.F2 Then
                MsgBox("START AUDIT BEFORE")
            ElseIf e.KeyCode = Keys.F10 Then
                Me.Close()
                formMain = New FORM_MAIN(usuario)
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt2_KeyDown(sender As Object, e As KeyEventArgs) Handles txt2.KeyDown
        Try
            If e.KeyCode = Keys.F10 Then
                setEstado(1)
            ElseIf e.KeyCode = Keys.Enter Then
                If txt2.Text <> "" And txt2.Text.Length > 0 Then
                    contenedorName = txt2.Text
                    contenedor = New Contenedor(contenedorName)
                    If contenedor.propLineasPedidas > 0 Then
                        iniciaAuditoria = True
                        agregaTexto("DOWNLOADING CONTAINER..")
                        tiempo = contenedor.propTiempo
                        Me.Refresh()
                        auditoria.insertaNuevaAuditoria(usuario, contenedorName, contenedor.propPiezasPedidas, contenedor.propLineasPedidas)
                        idAuditoria = auditoria.getAuditoriaId
                        contenedor.actualizaAuditoria(idAuditoria)
                        auditoria.insertaDetalleAuditoria(contenedor.propDTableContenedor)
                        agregaTexto("CONTAINER " & contenedorName & " READY:")
                        estado3()
                    Else
                        agregaTexto("THIS CONTAINER DO NOT EXIST:")
                        txt2.Clear()
                        nueva()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txt3_KeyDown(sender As Object, e As KeyEventArgs) Handles txt3.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt3.Text <> "" And txt3.Text.Length > 0 And IsNumeric(txt3.Text) Then
                    capturaQty()
                End If
            ElseIf e.KeyCode = Keys.F10 Then
                setEstado(1)
            ElseIf e.KeyCode = Keys.F2 Then
                terminaContenedor()
                'If idAuditoria > 0 Then
                '    auditoria.insertaDetalleAuditoria(contenedor.propDTableContenedor)
                '    auditoria.actualizaDetalleAuditoria(idAuditoria)
                '    agregaTexto("CONTAINER: " & txt2.Text & " FINISHED!")
                '    agregaTexto("AUDIT " & idAuditoria & " GENERATED!")
                'End If
            End If
        Catch ex As Exception
            Console.WriteLine("ERROR txt3 " & ex.Message)
        End Try
    End Sub
    Private Sub txt4_KeyDown(sender As Object, e As KeyEventArgs) Handles txt4.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txt4.Text <> "" And txt4.Text.Length > 0 And IsNumeric(txt4.Text) Then
                    Dim upc As Double = txt3.Text
                    item = New Items(upc)
                    If item.propResult Then
                        actualizaSku(item.propItem, txt4.Text)
                        auditoria.updateDetalleAuditoria(idAuditoria, item.propItem, txt4.Text)
                        auditoria.setDtableListaAuditado(idAuditoria, False)
                        dGridTabla.DataSource = auditoria.propDTableAllAuditorias
                    Else
                        agregaTexto("ITEM: " & txt3.Text & " DO NOT EXIST")
                    End If
                    txt3.Clear()
                    txt4.Clear()
                    'setSku(txt3.Text)
                    estado3()
                End If
            ElseIf e.KeyCode = Keys.F2 Then
                terminaContenedor()
                'If idAuditoria > 0 Then
                '    auditoria.actualizaDetalleAuditoria(idAuditoria, limite)
                '    agregaTexto("CONTAINER: " & txt2.Text & " FINISHED!")
                '    agregaTexto("AUDIT " & idAuditoria & " GENERATED!")
                'End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub actualizaSku(sku As Long, qty As Integer)
        Try
            Dim encontrado As Boolean = False
            Console.WriteLine("actualizaSku iniciado")
            For Each row As DataRow In contenedor.propDTableContenedor.Rows
                If row.Item(1) = sku Then
                    row.Item(4) = qty
                    row.Item(5) = Math.Abs(row.Item(2) - row.Item(4))
                    encontrado = True
                    Console.WriteLine(row.Item(0) & " " & row.Item(1) & " " & row.Item(2) & " " & row.Item(3) &
                                      " " & row.Item(4) & " " & row.Item(5))
                    Exit For
                End If
            Next
            If encontrado = False Then
                agregaTexto("ITEM " & sku & " DO NOT EXIST: " & sku & " QTY: " & qty)
            End If
        Catch ex As Exception
            Console.WriteLine("actualizaSku Error: " & ex.Message)
            agregaTexto(sku & " CAN'T BE ADDED: " & " QTY: " & qty)
        Finally
            Console.WriteLine("actualizaSku terminado")
        End Try
    End Sub
    Private Sub setEstado(estado As Integer)
        Try
            Select Case (estado)
                Case 1
                    estado1()
                Case 2
                    estado2()
                Case 3
            End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub estado1() 'ABRIR FORM
        Try
            lbl1.Visible = True
            txt1.Visible = True
            lbl1.Text = "SELECT"
            lbl2.Visible = False
            lbl3.Visible = False
            lbl4.Visible = False
            txt2.Visible = False
            txt3.Visible = False
            txt4.Visible = False
            txt1.Select()
            Me.Refresh()
        Catch ex As Exception
            Console.WriteLine("ERROR estado1 " & ex.Message)
        End Try
    End Sub
    Private Sub estado2()
        Try
            richComandos.Clear()
            lbl1.Visible = False
            lbl2.Visible = True
            lbl3.Visible = False
            txt1.Visible = False
            txt2.Visible = True
            txt3.Visible = False
            lbl2.Text = "CONTAINER"
            txt2.Select()
        Catch ex As Exception
            Console.WriteLine("ERROR estado2 " & ex.Message)
        End Try
    End Sub
    Private Sub estado3()
        txt2.ReadOnly = True
        txt4.ReadOnly = True
        txt3.ReadOnly = False
        lbl4.Visible = False
        txt4.Visible = False
        lbl3.Visible = True
        txt3.Visible = True
        lbl3.Text = "ITEM"
        txt3.Select()
        estado = 3
    End Sub
    Private Sub agregaTexto(texto As String)
        Try
            richComandos.AppendText(texto)
            richComandos.AppendText(vbLf)
        Catch ex As Exception
            Console.WriteLine("ERROR estado1 " & ex.Message)
        End Try
    End Sub
    Private Sub timerAuditoria_Tick(sender As Object, e As EventArgs) Handles timerAuditoria.Tick
        If iniciaAuditoria = True Then
            tiempo = tiempo.AddSeconds(-1)
            tiempoGenerado = tiempoGenerado.AddSeconds(1)
            lblTiempo.Text = "TIME REMAINING: " & Format(tiempo, "mm:ss")
            If tiempo <= "00:00:59" Then
                lblTiempo.ForeColor = Color.Red
            Else
                lblTiempo.ForeColor = Color.Lime
            End If
            If tiempo <= "00:00:00" Then
                terminaContenedor()
            End If
            Me.Refresh()
        End If
    End Sub
    Private Sub terminaContenedor()
        Try
            If idAuditoria > 0 Then
                Dim limite As String = tiempoGenerado
                auditoria.actualizaDetalleAuditoria(idAuditoria, limite)
                iniciaAuditoria = False
                setEstado(1)
                agregaTexto("CONTAINER: " & txt2.Text & " FINISHED!")
                agregaTexto("AUDIT " & idAuditoria & " GENERATED!")
                dGridTabla.DataSource = Nothing
                MsgBox("THANKS FOR PARTICIPATE " & usuario & vbLf &
                       "YOU GET: " & vbLf & FormatNumber(auditoria.propAvgLns, 4) * 100 & "%" &
                       " ON ACCURACY FOR LINES" & vbLf & FormatNumber(auditoria.propAvgPzs, 4) * 100 & "%" &
                       " ON ACCURACY FOR PIECES" & vbLf & "YOUR #AUDIT IS    ***" & idAuditoria & "***")
            End If
        Catch ex As Exception
            Console.WriteLine("terminaContenedor error: " & ex.Message)
        End Try
    End Sub
    Private Sub dGridTabla_KeyDown(sender As Object, e As KeyEventArgs) Handles dGridTabla.KeyDown

    End Sub
End Class
