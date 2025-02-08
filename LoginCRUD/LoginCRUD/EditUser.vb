Public Class EditUser
    Dim cla As New Sample_Functions
    Public users As New ManageUsers
    Public selected_id As String
    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cla.getusertypes(cmbUserType)
        cmbUserType.Text = users.usersTable.SelectedCells.Item(3).Value.ToString()
        lblID.Text = selected_id
    End Sub

    Private Sub btnEditUser_Click(sender As Object, e As EventArgs) Handles btnEditUser.Click
        If txtUsername.Text.ToString.Trim.Count <> 0 And txtPassword.Text.ToString.Trim.Count <> 0 And
      cmbUserType.SelectedValue <> 0 Then
            cla.update_user(txtUsername.Text.ToString.Trim, txtPassword.Text.ToString.Trim, cmbUserType.SelectedValue, selected_id)
            Close()
            users.btnRefresh.PerformClick()
        Else
            MsgBox("please enter all fields")
        End If
    End Sub
End Class