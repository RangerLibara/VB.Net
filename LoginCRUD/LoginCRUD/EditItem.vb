Public Class EditItem
    Public mainFrm As Form1
    Dim cla As New Sample_Functions
    Public selected_id As String

    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cla.GetProductTypes1(cmbItemTypes)
        cla.GetProductTypes2(cmbSuppliers)
        cla.GetProductTypes3(cmbCurrencies)

        cmbItemTypes.Text = mainFrm.itemTable.SelectedCells.Item(4).Value.ToString()
        cmbSuppliers.Text = mainFrm.itemTable.SelectedCells.Item(5).Value.ToString()
        cmbCurrencies.Text = mainFrm.itemTable.SelectedCells.Item(6).Value.ToString()
        lblID.Text = selected_id
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtCode.Text.ToString.Trim.Count <> 0 And txtName.Text.ToString.Trim.Count <> 0 And
            txtPrice.Text.ToString.Trim.Count <> 0 And cmbItemTypes.SelectedValue <> 0 And
            cmbSuppliers.SelectedValue <> 0 And cmbCurrencies.SelectedValue <> 0 Then
            cla.update_item(txtCode.Text.ToString.Trim, txtName.Text.ToString.Trim, txtPrice.Text.Trim,
                        cmbItemTypes.SelectedValue, cmbSuppliers.SelectedValue, cmbCurrencies.SelectedValue, selected_id)
            Close()
            mainFrm.btnRefresh.PerformClick()
        Else
            MsgBox("please enter all fields")
        End If
    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged

    End Sub

    Private Sub btnEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles btnEdit.KeyPress

    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Dim DecimalSeparator As String =
          Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub
End Class