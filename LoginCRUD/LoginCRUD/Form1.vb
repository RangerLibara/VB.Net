Public Class Form1
    Dim cla As New Sample_Functions
    Public session
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cla.retrieveData(itemTable)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        cla.retrieveData(itemTable)
    End Sub


    Private Sub RefreshTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        cla.retrieveData(itemTable)
    End Sub

    Private Sub EditItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If itemTable.RowCount > 0 Then
            Dim edit_item As New EditItem
            edit_item.mainFrm = Me
            edit_item.selected_id = itemTable.SelectedCells.Item(0).Value.ToString()
            edit_item.txtCode.Text = itemTable.SelectedCells.Item(1).Value.ToString()
            edit_item.txtName.Text = itemTable.SelectedCells.Item(2).Value.ToString()
            edit_item.txtPrice.Text = itemTable.SelectedCells.Item(3).Value.ToString()
            edit_item.ShowDialog()
        Else
            btnEdit.Enabled = False
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        If itemTable.RowCount > 0 Then
            Dim msg = MessageBox.Show("Do you want to delete item " &
        itemTable.SelectedCells.Item(1).Value.ToString() & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If msg = DialogResult.Yes Then
                cla.delete_item(itemTable.SelectedCells.Item(0).Value.ToString())
                btnRefresh.PerformClick()
            End If
        Else
            btnDel.Enabled = False
        End If
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add_item As New AddItem
        add_item.mainFrm = Me
        add_item.ShowDialog()
    End Sub

    Private Sub ManageUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles btnManageUsers.Click
        Dim users As New ManageUsers
        users.ShowDialog()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Login.Show()
        Close()
    End Sub
End Class
