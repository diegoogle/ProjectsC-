Public Class FORM_RECALL
    Private formMain As FORM_MAIN
    Private recall As Recall
    Private usuario As String
    Private upc As Double
    Private qty As Integer
    Private selectCredito As Boolean
    Private verCreditoEspecific As Boolean
    Public Sub New(usuario As String)
        InitializeComponent()
        selectCredito = False
        verCreditoEspecific = False
        Me.usuario = usuario
        Me.Show()
    End Sub
    Private Sub FORM_RECALL_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtStore.Select()
        cargaForm()
    End Sub
    Private Sub txtStore_KeyDown(sender As Object, e As KeyEventArgs) Handles txtStore.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtStore.Text <> "" And IsNumeric(txtStore.Text) Then
                    If verCreditoEspecific = False Then
                        recibeTienda(txtStore.Text)
                    Else
                        recibeCredito(txtStore.Text)
                    End If

                End If
            ElseIf e.KeyCode = Keys.F1 Then
                nuevo()
            ElseIf e.KeyCode = Keys.F2 Then
                MsgBox("YOU MUST CREATE A CREDIT FOR CONTINUE")
            ElseIf e.KeyCode = Keys.F3 Then
                If selectCredito = False Then
                    verCredito()
                Else
                    If txtStore.Text <> "" And IsNumeric(txtStore.Text) Then
                        recibeCredito(txtStore.Text)
                    End If
                End If
            ElseIf e.KeyCode = Keys.F4 Then
                verTodosCreditos()
            ElseIf e.KeyCode = Keys.F10 Then
                formMain = New FORM_MAIN(usuario)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtItem_KeyDown(sender As Object, e As KeyEventArgs) Handles txtItem.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtItem.Text <> "" And IsNumeric(txtItem.Text) Then
                    recibeItem(txtItem.Text)
                End If
            ElseIf e.KeyCode = Keys.F2 Then
                terminaCredito()
            ElseIf e.KeyCode = Keys.F10 Then
                formMain = New FORM_MAIN(usuario)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtQty.Text <> "" And IsNumeric(txtQty.Text) Then
                    recibeQty(txtQty.Text)
                End If
            ElseIf e.KeyCode = Keys.F2 Then
                terminaCredito()
            ElseIf e.KeyCode = Keys.F10 Then
                formMain = New FORM_MAIN(usuario)
            Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub cargaForm()
        Try
            selectCredito = False
            lblItem.Visible = False
            lblQty.Visible = False
            txtItem.Visible = False
            txtQty.Visible = False
            txtStore.Visible = True
            lblStore.Visible = True
            dGridTabla.DataSource = Nothing
            lblStore.Text = "SELECT:"
            txtStore.Enabled = True
            txtStore.Clear()
            txtStore.Select()
        Catch ex As Exception
            Console.WriteLine("cargaForm Error: " & ex.Message)
        End Try
    End Sub
    Private Sub nuevo()
        selectCredito = False
        verCreditoEspecific = False
        lblStore.Text = "STORE:"
        dGridTabla.DataSource = Nothing
        txtStore.Select()
    End Sub
    Private Sub verCredito()
        verCreditoEspecific = True
        lblStore.Text = "CREDIT #:"
        dGridTabla.DataSource = Nothing
        txtStore.Select()
    End Sub
    Private Sub recibeCredito(credito As Long)
        Try
            recall = New Recall(credito)
            dGridTabla.DataSource = recall.propDTable
            txtStore.Clear()
            Me.Refresh()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub verTodosCreditos()
        selectCredito = False
        verCreditoEspecific = False
        'FUNCION PARA CARGAR TODOS LOS CREDITOS REALIZADOS
        recall = New Recall
        dGridTabla.DataSource = recall.propDTable
        txtStore.Select()
        Me.Refresh()
    End Sub
    Private Sub recibeTienda(tienda As Integer)
        recall = New Recall(usuario, tienda)
        txtStore.Enabled = False
        lblItem.Visible = True
        lblQty.Visible = True
        txtItem.Enabled = True
        txtItem.Visible = True
        txtItem.Clear()
        txtItem.Select()
    End Sub
    Private Sub recibeItem(upc As Double)
        Try
            Me.upc = upc
            txtItem.Enabled = False
            txtQty.Visible = True
            txtQty.Enabled = True
            txtQty.Clear()
            txtQty.Select()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub recibeQty(qty As Integer)
        Me.qty = qty
        recall.validaUpc(upc, qty)
        txtItem.Clear()
        txtQty.Clear()
        txtItem.Enabled = True
        txtQty.Enabled = False
        dGridTabla.DataSource = recall.propDTable
        txtItem.Select()
        Me.Refresh()
    End Sub
    Private Sub terminaCredito()
        Try
            selectCredito = False
            verCreditoEspecific = False
            recall.insertaTabla()
            recall.updateCredito()
            MsgBox("CREDIT FINISHED! " & vbLf & "CREDIT NUMBER: " & recall.propCredito & vbLf &
                   "COST ACCREDITED: " & Format(recall.propMontoAcreditado, "$00.00") & vbLf &
                   "PERCENT ACCREDITED: " & Format(recall.propPercentAcreditado, "%00.00"))
            cargaForm()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub dGridTabla_KeyDown(sender As Object, e As KeyEventArgs)
        Try
            If e.KeyCode = Keys.F10 Then
                formMain = New FORM_MAIN(usuario)
                Me.Close()
            ElseIf e.KeyCode = Keys.F1 Or e.KeyCode = Keys.F2 Or e.KeyCode = Keys.F3 Or e.KeyCode = Keys.F4 Then
                txtStore.Select()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class