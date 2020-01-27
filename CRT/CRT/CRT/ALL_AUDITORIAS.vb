Public Class ALL_AUDITORIAS
    Private frmMain As FORM_MAIN
    Private auditoria As Auditoria
    Private usuario As String
    Public Sub New(usuario As String)
        InitializeComponent()
        Me.usuario = usuario
        Me.Show()
    End Sub
    Private Sub cargaAuditorias(porPuntos As Boolean)
        Try
            auditoria = New Auditoria(porPuntos)
            dGridTabla.DataSource = auditoria.propDTableAllAuditorias
            Me.Refresh()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ALL_AUDITORIAS_Load(sender As Object, e As EventArgs) Handles Me.Load
        dGridTabla.Select()
    End Sub
    Private Sub dGridTabla_KeyDown(sender As Object, e As KeyEventArgs) Handles dGridTabla.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                cargaAuditorias(False)
            ElseIf e.KeyCode = Keys.F2 Then
                cargaAuditorias(True)
            ElseIf e.KeyCode = Keys.F10 Then
                frmMain = New FORM_MAIN(usuario)
                Me.Close()
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class