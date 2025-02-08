Public Class AddUser
    Dim cla As New Sample_Functions
    Public users As New ManageUsers
    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If txtUsername.Text.ToString.Trim.Count <> 0 And txtPassword.Text.ToString.Trim.Count <> 0 And
         cmbUserType.SelectedValue <> 0 Then
            cla.insert_User(txtUsername.Text.ToString.Trim, txtPassword.Text.ToString.Trim, cmbUserType.SelectedValue)
            Close()
            users.btnRefresh.PerformClick()
            users.btnDelete.Enabled = True
            users.btnEdit.Enabled = True

        Else
            MsgBox("Please enter all fields")
        End If
    End Sub

    Private Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cla.getusertypes(cmbUserType)
    End Sub
End Class