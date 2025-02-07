Public Class Form1
    Dim num1, num2, ans, squared As Double
    Dim op As String

    Private Sub Operator_Click(sender As Object, e As EventArgs) Handles btntimes.Click, btnplus.Click, btnminus.Click, btndiv.Click
        Dim b As Button = sender

        num1 = output.Text
        op = b.Text
        output.Text = Nothing
    End Sub

    Private Sub btnequal_Click(sender As Object, e As EventArgs) Handles btnequal.Click
        num2 = output.Text
        If op = "+" Then
            ans = num1 + num2
            output.Text = ans
        ElseIf op = "-" Then
            ans = num1 - num2
            output.Text = ans
        ElseIf op = "*" Then
            ans = num1 * num2
            output.Text = ans
        ElseIf op = "/" Then
            ans = num1 / num2
            output.Text = ans
        End If
    End Sub

    Private Sub btnop_Click(sender As Object, e As EventArgs) Handles btnop.Click
        If (output.Text.Contains("-")) Then
            output.Text = output.Text.Remove(0, 1)
        Else
            output.Text = "-" + output.Text
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        output.Text = "0"
    End Sub

    Private Sub btnsquared_Click(sender As Object, e As EventArgs) Handles btnsquared.Click
        Dim b As Button = sender

        num1 = output.Text
        squared = num1 * num1
        output.Text = squared

    End Sub

    Private Sub Numbers_Click(sender As Object, e As EventArgs) Handles btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click, btn0.Click, btndot.Click
        Dim b As Button = sender
        If (output.Text = "0") Then
            output.Text = ""
            output.Text = b.Text
        ElseIf (b.Text = ".") Then
            If (Not output.Text.Contains(".")) Then
                output.Text = output.Text + b.Text
            End If
        Else output.Text = output.Text + b.Text
        End If


    End Sub

    Private Sub btnbs_Click(sender As Object, e As EventArgs) Handles btnbs.Click
        If (output.Text.Length > 0) Then
            output.Text = output.Text.Remove(output.Text.Length - 1, 1)
        End If
        If (output.Text.Length = Nothing) Then
            output.Text = "0"
        End If
    End Sub
End Class
