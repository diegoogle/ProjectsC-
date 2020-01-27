Public Class FORM_CHECK_CONT
    Private formMain As FORM_MAIN
    Private contenedor As Contenedor
    Private item As Items
    Private usuario As String
    Public Sub New(usuario As String)
        InitializeComponent()
        Me.usuario = usuario
        Me.Show()
    End Sub
    Private Sub FORM_CHECK_CONT_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtContainer.Select()
    End Sub
    Private Sub completaTabla()
        Try
            For Each row As DataRow In contenedor.propDTableContenedor.Rows
                item = New Items(row.Item(1))
                row.Item(3) = item.propNumeroParte
                row.Item(4) = item.propDescripcion
            Next
        Catch ex As Exception
            Console.WriteLine("ERROR completaTabla " & ex.Message)
        End Try
    End Sub
    Private Sub vaciarContendor()
        Try
            For Each row As DataRow In contenedor.propDTableContenedor.Rows
                agregaTexto(row.Item(1), row.Item(2), row.Item(3), row.Item(4))
            Next
        Catch ex As Exception
            Console.WriteLine("ERROR vaciarContendor " & ex.Message)
        End Try
    End Sub
    Private Sub txtContainer_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContainer.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                txtContainer.Clear()
                richContainer.Clear()
                txtContainer.Select()
            ElseIf e.KeyCode = Keys.F10 Then
                formMain = New FORM_MAIN(usuario)
                Me.Close()
            ElseIf e.KeyCode = Keys.Enter Then
                If txtContainer.Text <> "" Then
                    contenedor = New Contenedor(txtContainer.Text, True)
                    If contenedor.propLineasPedidas > 0 Then
                        completaTabla()
                        vaciarContendor()
                    Else
                        MsgBox("THIS CONTAINER DO NOT EXIST ")
                        txtContainer.Clear()
                    End If
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("ERROR txtContainer_KeyDown " & ex.Message)
        End Try
    End Sub
    Private Sub agregaTexto(item As String, qty As String, part As String, desc As String)
        Try
            richContainer.AppendText(item)
            richContainer.AppendText(vbTab)
            richContainer.AppendText(qty)
            richContainer.AppendText(vbTab)
            richContainer.AppendText(part)
            richContainer.AppendText(vbTab)
            richContainer.AppendText(desc)
            richContainer.AppendText(vbLf)
            richContainer.ScrollToCaret()
            Me.Refresh()
        Catch ex As Exception
            Console.WriteLine("ERROR agregaTexto " & ex.Message)
        End Try
    End Sub
    Private Sub richContainer_KeyDown(sender As Object, e As KeyEventArgs) Handles richContainer.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                txtContainer.Clear()
                richContainer.Clear()
                txtContainer.Select()
            ElseIf e.KeyCode = Keys.F10 Then
                formMain = New FORM_MAIN(usuario)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
