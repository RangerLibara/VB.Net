Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1
    Private Sub cb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb1.SelectedIndexChanged
        If cb1.SelectedItem = "Red" Then
            box1.BackColor = Color.Red
        ElseIf cb1.SelectedItem = "Blue" Then
            box1.BackColor = Color.Blue
        ElseIf cb1.SelectedItem = "Green" Then
            box1.BackColor = Color.Green
        ElseIf cb1.SelectedItem = "Nothing" Then
            box1.BackColor = Color.White
        End If
    End Sub

    Private Sub cb2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb2.SelectedIndexChanged
        If cb2.SelectedItem = "Red" Then
            box2.BackColor = Color.Red
        ElseIf cb2.SelectedItem = "Blue" Then
            box2.BackColor = Color.Blue
        ElseIf cb2.SelectedItem = "Green" Then
            box2.BackColor = Color.Green
        ElseIf cb2.SelectedItem = "Nothing" Then
            box2.BackColor = Color.White
        End If
    End Sub

    Private Sub pbmix_Click(sender As Object, e As EventArgs) Handles pbmix.Click

    End Sub

    Private Sub mixbtn_Click(sender As Object, e As EventArgs) Handles mixbtn.Click
        If cb1.SelectedItem = "Red" And
          cb2.SelectedItem = "Red" Then
            pbmix.BackColor = Color.Red
        ElseIf cb1.SelectedItem = "Blue" And
            cb2.SelectedItem = "Blue" Then
            pbmix.BackColor = Color.Blue
        ElseIf cb1.SelectedItem = "Green" And
            cb2.SelectedItem = "Green" Then
            pbmix.BackColor = Color.Green
        ElseIf cb1.SelectedItem = "Blue" And
            cb2.SelectedItem = "Nothing" Then
            pbmix.BackColor = Color.Blue
        ElseIf cb1.SelectedItem = "Red" And
            cb2.SelectedItem = "Nothing" Then
            pbmix.BackColor = Color.Red
        ElseIf cb1.SelectedItem = "Green" And
            cb2.SelectedItem = "Nothing" Then
            pbmix.BackColor = Color.Green
        ElseIf cb1.SelectedItem = "Red" And
            cb2.SelectedItem = "Blue" Then
            pbmix.BackColor = Color.Violet
        ElseIf cb1.SelectedItem = "Blue" And
            cb2.SelectedItem = "Green" Then
            pbmix.BackColor = Color.LightBlue
        ElseIf cb1.SelectedItem = "Green" And
            cb2.SelectedItem = "Red" Then
            pbmix.BackColor = Color.Yellow

        ElseIf cb1.SelectedItem = "Red" And
            cb2.SelectedItem = "Red" Then
            pbmix.BackColor = Color.Red
        ElseIf cb1.SelectedItem = "Blue" And
                cb2.SelectedItem = "Blue" Then
            pbmix.BackColor = Color.Blue
        ElseIf cb1.SelectedItem = "Green" And
                cb2.SelectedItem = "Green" Then
            pbmix.BackColor = Color.Green
        ElseIf cb1.SelectedItem = "Nothing" And
                cb2.SelectedItem = "Blue" Then
            pbmix.BackColor = Color.Blue
        ElseIf cb1.SelectedItem = "Nothing" And
                cb2.SelectedItem = "Red" Then
            pbmix.BackColor = Color.Red
        ElseIf cb1.SelectedItem = "Nothing" And
                cb2.SelectedItem = "Green" Then
            pbmix.BackColor = Color.Green
        ElseIf cb1.SelectedItem = "Blue" And
                cb2.SelectedItem = "Red" Then
            pbmix.BackColor = Color.Violet
        ElseIf cb1.SelectedItem = "Green" And
                cb2.SelectedItem = "Blue" Then
            pbmix.BackColor = Color.LightBlue
        ElseIf cb1.SelectedItem = "Nothing" And
            cb2.SelectedItem = "Nothing" Then
            pbmix.BackColor = Color.White
        ElseIf cb1.SelectedItem = "Red" And
        cb2.SelectedItem = "Green" Then
            pbmix.BackColor = Color.Yellow



        End If
    End Sub

    Private Sub box1_Click(sender As Object, e As EventArgs) Handles box1.Click

    End Sub
End Class
