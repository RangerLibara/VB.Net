﻿Public Class add_Item
    Public mainFrm As Form1
    Dim cla As New Class1

    Private Sub add_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cla.GetProductTypes1(cmbItemTypes)
        cla.GetProductTypes2(cmbSuppliers)
        cla.GetProductTypes3(cmbCurrencies)

        cmbItemTypes.Text = Nothing
        cmbSuppliers.Text = Nothing
        cmbCurrencies.Text = Nothing
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCode.Text.ToString.Trim.Count <> 0 And txtName.Text.ToString.Trim.Count <> 0 And
        txtPrice.Text.ToString.Trim.Count <> 0 And cmbItemTypes.SelectedValue <> 0 And
        cmbSuppliers.SelectedValue <> 0 And cmbCurrencies.SelectedValue <> 0 Then
            cla.insert_user(txtCode.Text.ToString.Trim, txtName.Text.ToString.Trim, txtPrice.Text.Trim,
                        cmbItemTypes.SelectedValue, cmbSuppliers.SelectedValue, cmbCurrencies.SelectedValue)
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