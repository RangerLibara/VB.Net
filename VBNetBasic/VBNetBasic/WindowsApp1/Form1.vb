Public Class Form1
    Dim num1, num2 As Decimal
    Dim sum, diff, prod, quo, expo As Decimal
    Dim floor_quo, remainder As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = Box1.Text
        num2 = Box2.Text

        sum = num1 + num2

        Label3.Text = num1
        Label5.Text = num2
        Label4.Text = "+"
        Label6.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num1 = Box1.Text
        num2 = Box2.Text

        diff = num1 - num2

        Label3.Text = num1
        Label5.Text = num2
        Label4.Text = "-"
        Label6.Text = diff
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num1 = Box1.Text
        num2 = Box2.Text

        quo = num1 / num2

        Label3.Text = num1
        Label5.Text = num2
        Label4.Text = "/"
        Label6.Text = quo
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num1 = Box1.Text
        num2 = Box2.Text

        prod = num1 * num2

        Label3.Text = num1
        Label5.Text = num2
        Label4.Text = "*"
        Label6.Text = prod
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        num1 = Box1.Text
        num2 = Box2.Text

        remainder = num1 Mod num2

        Label3.Text = num1
        Label5.Text = num2
        Label4.Text = "*"
        Label6.Text = remainder
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        num1 = Box1.Text
        num2 = Box2.Text

        expo = Math.Pow(num1, num2)

        Label3.Text = num1
        Label5.Text = num2
        Label4.Text = "raised to"
        Label6.Text = expo
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        num1 = Box1.Text
        num2 = Box2.Text

        floor_quo = num1 \ num2

        Label3.Text = num1
        Label5.Text = num2
        Label4.Text = "floor division"
        Label6.Text = floor_quo
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Box1.Text = " "
        Box2.Text = " "
        Label3.Text = "0"
        Label5.Text = "Operation"
        Label4.Text = "0"
        Label6.Text = "= Result"
    End Sub

End Class
