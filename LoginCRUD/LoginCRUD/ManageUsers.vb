Public Class ManageUsers
    Dim cla As New Sample_Functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cla.retrieveDataUsers(usersTable)
    End Sub

    Private Sub ManageUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cla.retrieveDataUsers(usersTable)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add_user As New AddUser
        add_user.users = Me
        add_user.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If usersTable.RowCount > 0 Then
            Dim edit_users As New EditUser
            edit_users.users = Me
            edit_users.selected_id = usersTable.SelectedCells.Item(0).Value.ToString()
            edit_users.txtUsername.Text = usersTable.SelectedCells.Item(1).Value.ToString()
            edit_users.txtPassword.Text = usersTable.SelectedCells.Item(2).Value.ToString()
            edit_users.ShowDialog()
        Else
            btnEdit.Enabled = False
        End If
    End Sub


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If usersTable.RowCount > 0 Then
            Dim msg = MessageBox.Show("Do you want to delete user " &
        usersTable.SelectedCells.Item(1).Value.ToString() & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If msg = DialogResult.Yes Then
                cla.delete_user(usersTable.SelectedCells.Item(0).Value.ToString())
                btnRefresh.PerformClick()
            End If
        Else
            btnDelete.Enabled = False
        End If
    End Sub
End Class