Public Class Login
    Dim cla As New Sample_Functions
    Public session
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        RegisterForm.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        session = cla.LoginUser(txtUsername.Text, txtPassword.Text)

        If session.Rows.Count <> 0 Then

            MsgBox("Logged In!!")

            Dim mainFrm As New Form1
            mainFrm.lblUsername.Text = session.Rows(0)("username").ToString
            mainFrm.lblUserType.Text = session.Rows(0)("usertype_name").ToString
            If mainFrm.lblUserType.Text = "Storekeeper" Then
                mainFrm.btnManageUsers.Visible = False
            ElseIf mainFrm.lblUserType.Text = "Customer" Then
                mainFrm.btnManageUsers.Visible = False
                mainFrm.btnManageItems.Visible = False
            End If
            mainFrm.session = Me.session
            mainFrm.Show()
            Close()

        Else
            MsgBox("Invalid Username/password")
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class