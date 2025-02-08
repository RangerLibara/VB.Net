Public Class RegisterForm
    Dim cla As New Sample_Functions
    Public users As New ManageUsers
    Public session
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        session = cla.LoginUser(txtUsername.Text, txtPassword.Text)
        If txtUsername.Text.ToString.Trim.Count <> 0 And txtPassword.Text.ToString.Trim.Count <> 0 And
         txtConfirmPass.Text.ToString.Trim.Count <> 0 Then
            If session.Rows.Count <> 0 Then
                MsgBox("Already Exist")

            Else
                If txtConfirmPass.Text <> txtPassword.Text Then
                    MsgBox("Password and Confirm Password doesn't match")
                Else
                    cla.Add_User(txtUsername.Text.ToString.Trim, txtPassword.Text.ToString.Trim, 3)
                    MsgBox("Registration Successfully!")
                    Close()
                End If


            End If
        Else
            MsgBox("Please enter all fields")
        End If


    End Sub
End Class