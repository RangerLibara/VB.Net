Public Class editItem
    Public mainFrm As Form1
    Dim cla As New Class1
    Public selected_id As String
    Private Sub editItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cla.GetProductTypes1(cmbItemTypes)
        cla.GetProductTypes2(cmbSuppliers)
        cla.GetProductTypes3(cmbCurrencies)

        cmbItemTypes.Text = Form1.DataTable.SelectedCells.Item(7).Value.ToString()
        cmbSuppliers.Text = Form1.DataTable.SelectedCells.Item(8).Value.ToString()
        cmbCurrencies.Text = Form1.DataTable.SelectedCells.Item(9).Value.ToString()

        lblID.Text = selected_id


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtCode.Text.ToString.Trim.Count <> 0 And txtName.Text.ToString.Trim.Count <> 0 And
 txtPrice.Text.ToString.Trim.Count <> 0 And cmbItemTypes.SelectedValue <> 0 And
 cmbSuppliers.SelectedValue <> 0 And cmbCurrencies.SelectedValue <> 0 Then
            cla.edit_item(txtCode.Text.ToString.Trim, txtName.Text.ToString.Trim, txtPrice.Text.Trim,
                        cmbItemTypes.SelectedValue, cmbSuppliers.SelectedValue, cmbCurrencies.SelectedValue, selected_id)
            Close()
            mainFrm.btnRef.PerformClick()
        Else
            MsgBox("please enter all fields")
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        Dim DecimalSeparator As String = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8 Or (e.KeyChar = DecimalSeparator And sender.Text.IndexOf(DecimalSeparator) = -1))
    End Sub

End Class