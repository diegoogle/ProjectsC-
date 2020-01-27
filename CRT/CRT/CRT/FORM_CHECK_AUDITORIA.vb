Public Class FORM_CHECK_AUDITORIA
    Private formMain As FORM_MAIN
    Private conexionDB As New ConexionDB
    Private auditoria As Auditoria
    Private item As Items
    Private usuario As String
    Private sql As String
    Private dTableDetalleAuditoria As DataTable
    Public Sub New(usuario As String)
        InitializeComponent()
        Me.usuario = usuario
        Me.Show()
    End Sub
    Private Sub FORM_CHECK_AUDITORIA_Load(sender As Object, e As EventArgs) Handles Me.Load
        nuevaBusqueda()
    End Sub
    Private Sub txtContainer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAudit.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                nuevaBusqueda()
            ElseIf e.KeyCode = Keys.F10 Then
                formMain = New FORM_MAIN(usuario)
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                If txtAudit.Text <> "" And IsNumeric(txtAudit.Text) Then
                    Dim audit As Long = txtAudit.Text
                    auditoria = New Auditoria(audit)
                    Console.WriteLine("AUDITORIA: " & auditoria.propAuditoria)
                    If auditoria.propAuditoria > 0 Then
                        setResultadoAuditoria(auditoria.propDTableAuditoria)
                        setDTableDetalle(auditoria.propAuditoria)
                        auditoria.setDtableListaAuditado(auditoria.propAuditoria, True)
                        dGridTabla.DataSource = auditoria.propDTableAllAuditorias
                    Else
                        nuevaBusqueda()
                        MsgBox("THIS AUDIT DO NOT EXIST")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dGridTabla_KeyDown(sender As Object, e As KeyEventArgs) Handles dGridTabla.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                nuevaBusqueda()
            ElseIf e.KeyCode = Keys.F10 Then
                formMain = New FORM_MAIN(usuario)
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                If txtAudit.Text <> "" And IsNumeric(txtAudit.Text) Then
                    Dim audit As Long = txtAudit.Text
                    auditoria = New Auditoria(audit)
                    Console.WriteLine("AUDITORIA: " & auditoria.propAuditoria)
                    If auditoria.propAuditoria > 0 Then
                        setResultadoAuditoria(auditoria.propDTableAuditoria)
                        setDTableDetalle(auditoria.propAuditoria)
                        auditoria.setDtableListaAuditado(auditoria.propAuditoria, True)
                        dGridTabla.DataSource = auditoria.propDTableAllAuditorias
                    Else
                        nuevaBusqueda()
                        MsgBox("THIS AUDIT DO NOT EXIST")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub setResultadoAuditoria(dTable As DataTable)
        Try
            Dim tiempo As DateTime
            For Each row As DataRow In dTable.Rows
                lblContainerR.Text = row.Item(3)
                lblUserR.Text = row.Item(1)
                lblDateR.Text = row.Item(2)
                lblLnsRequiredR.Text = row.Item(7)
                lblLnsR.Text = row.Item(8)
                lblPiecesRequiredR.Text = row.Item(4)
                lblPiecesR.Text = row.Item(5)
                lblWrongLinesR.Text = row.Item(9)
                lblWrongPiecesR.Text = row.Item(6)
                tiempo = row.Item(12)
                lblTimeR.Text = Format(tiempo, "mm:ss")
                lblAccuracyLnsR.Text = FormatNumber(row.Item(11), 2) * 100 & "%"
                lblAccuracyPzsR.Text = FormatNumber(row.Item(10), 2) * 100 & "%"
            Next
        Catch ex As Exception

        End Try
    End Sub
    Private Sub nuevaBusqueda()
        Try
            txtAudit.Text = ""
            lblContainerR.Text = ""
            lblDateR.Text = ""
            lblUserR.Text = ""
            txtAudit.Select()
        Catch ex As Exception
            Console.WriteLine("ERROR nuevaBusqueda " & ex.Message)
        End Try
    End Sub
    Private Sub setDTableDetalle(idAuditoria As Long)
        Try
            sql = "SELECT * FROM [DETALLE_AUDITORIA] WHERE(AUDITORIA = " & idAuditoria & " AND QTY_ERROR > 0)"
            Console.WriteLine(sql)
            conexionDB.setDataSet(sql)
            dTableDetalleAuditoria = conexionDB.getDataTable
        Catch ex As Exception
            Console.WriteLine("ERROR setItems " & ex.Message)
        End Try
    End Sub

End Class
