Public Class FORM_MAIN
    Private usuario As String
    Private formAuditoria As FORM_AUDITORIA
    Private formCheckCont As FORM_CHECK_CONT
    Private formCheckAudit As FORM_CHECK_AUDITORIA
    Private formAllAuditorias As ALL_AUDITORIAS
    Private formRecall As FORM_RECALL
    Public Sub New(user As String)
        InitializeComponent()
        Me.usuario = user
        Me.Show()
        Console.WriteLine(usuario)
    End Sub
    Private Sub FORM_MAIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargaAutozone()
        richComandos.Select()
    End Sub
    Private Sub cargaAutozone()
        Try
            richComandos.AppendText(vbLf)
            richComandos.AppendText(vbLf)
            Dim arreglo(5) As String
            arreglo(0) = "@@@@@ @   @ @@@@@ @@@@@ @@@@@ @@@@@ @@   @ @@@@@"
            arreglo(1) = "@   @ @   @   @   @   @     @ @   @ @ @  @ @"
            arreglo(2) = "@   @ @   @   @   @   @     @ @   @ @ @  @ @"
            arreglo(3) = "@@@@@ @   @   @   @   @   @   @   @ @  @ @ @@@@@"
            arreglo(4) = "@   @ @   @   @   @   @ @     @   @ @   @@ @"
            arreglo(5) = "@   @ @@@@@   @   @@@@@ @@@@@ @@@@@ @    @ @@@@@"
            Dim i As Integer = 0
            While i < arreglo.Length
                richComandos.AppendText(vbTab & vbTab & vbTab & arreglo(i) & vbLf)
                i += 1
                Me.Refresh()
            End While
            richComandos.AppendText(usuario)
            richComandos.AppendText(vbLf)
            richComandos.AppendText("ENTER SELECTION: ")
        Catch ex As Exception
            Console.WriteLine("ERROR: " & ex.Message)
        End Try
    End Sub
    Private Sub richComandos_KeyDown(sender As Object, e As KeyEventArgs) Handles richComandos.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                formAuditoria = New FORM_AUDITORIA(usuario)
                Me.Close()
                Me.Refresh()
            ElseIf e.KeyCode = Keys.F2 Then
                formCheckCont = New FORM_CHECK_CONT(usuario)
                Me.Close()
            ElseIf e.KeyCode = Keys.F3 Then
                formCheckAudit = New FORM_CHECK_AUDITORIA(usuario)
                Me.Close()
            ElseIf e.KeyCode = Keys.F4 Then
                formAllAuditorias = New ALL_AUDITORIAS(usuario)
                Me.Close()
            ElseIf e.KeyCode = Keys.F5 Then
                formRecall = New FORM_RECALL(usuario)
                Me.Close()
            ElseIf e.KeyCode = Keys.F10 Then
                Me.Close()
                FORM_LOGIN.Show()
                FORM_LOGIN.txtName.Clear()
            End If
        Catch ex As Exception
            Console.WriteLine("ERROR " & ex.Message)
        End Try
    End Sub
End Class
