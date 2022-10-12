Public Class Form1
    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

        If txtPassword.Text <> "" Then
            If txtPassword.TextLength >= 8 Then
                lblStrongWeak.Text = "Password is strong."
            Else
                lblStrongWeak.Text = "Password is weak."
            End If
            lblStrongWeak.Visible = True
        Else
            lblStrongWeak.Visible = False
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If txtPassword.Text <> "" Then
            If txtPassword.TextLength >= 8 Then
                MsgBox("Your password is strong.")
            Else
                MsgBox("Your password is weak.")
            End If
        Else
            MsgBox("Please enter password.")
        End If
    End Sub
End Class
