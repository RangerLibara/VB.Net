Public Class Form1
    Dim cla As New Class1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addItem As New add_Item
        addItem.mainFrm = Me
        addItem.ShowDialog()

        Try
            If DataTable.RowCount <= 0 Then
                btnDel.Enabled = False
            Else
                btnDel.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If DataTable.RowCount <= 0 Then
                btnEdit.Enabled = False
            Else
                btnEdit.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cla.retrieveData(DataTable)

        Try
            If DataTable.RowCount <= 0 Then
                btnDel.Enabled = False
            Else
                btnDel.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Try
            If DataTable.RowCount <= 0 Then
                btnEdit.Enabled = False
            Else
                btnEdit.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRef_Click(sender As Object, e As EventArgs) Handles btnRef.Click
        cla.retrieveData(DataTable)
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Try
            If DataTable.RowCount <= 0 Then
                btnEdit.Enabled = False
            Else
                btnEdit.Enabled = True
                Dim edit_Item As New editItem

                edit_Item.mainFrm = Me
                edit_Item.selected_id = DataTable.SelectedCells.Item(0).Value.ToString()
                edit_Item.txtCode.Text = DataTable.SelectedCells.Item(1).Value.ToString()
                edit_Item.txtName.Text = DataTable.SelectedCells.Item(2).Value.ToString()
                edit_Item.txtPrice.Text = DataTable.SelectedCells.Item(3).Value.ToString()

                edit_Item.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataTable.CellContentClick

    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        Dim msg = MessageBox.Show("Do you want to delete item " &
   DataTable.SelectedCells.Item(1).Value.ToString() & "?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If msg = DialogResult.Yes Then
            cla.delete_user(DataTable.SelectedCells.Item(0).Value.ToString())
            btnRef.PerformClick()
        End If

        Try
            If DataTable.RowCount <= 0 Then
                btnDel.Enabled = False
            Else
                btnDel.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
