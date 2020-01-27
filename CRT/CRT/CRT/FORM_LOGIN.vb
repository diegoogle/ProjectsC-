Public Class FORM_LOGIN
    Private formMain As FORM_MAIN
    Private Sub txtName_KeyDown(sender As Object, e As KeyEventArgs) Handles txtName.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If txtName.Text <> "" And txtName.Text <> " " Then
                    formMain = New FORM_MAIN(txtName.Text)
                    Me.Hide()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class