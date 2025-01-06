Public Class login_page
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim form2 As New Form2()
        ' Check if the username and password are correct
        If username_txtb.Text = "admin" AndAlso pwd_txtb.Text = "imissyousomuchbabyq" Then
            MessageBox.Show("You have successfully logged in.", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Show Form2
            form2.Show()

            ' Optionally hide or close the current form
            Me.Hide() ' Or use Me.Close() to close the form
        Else
            ' Display a message for incorrect credentials
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub login_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pwd_txtb.PasswordChar = "●"c
    End Sub

    Private Sub showpass_checkb_CheckedChanged(sender As Object, e As EventArgs) Handles showpass_checkb.CheckedChanged
        If showpass_checkb.Checked Then
            pwd_txtb.PasswordChar = ControlChars.NullChar
        Else
            pwd_txtb.PasswordChar = "●"c
        End If
    End Sub
End Class
