Public Class Form1
    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim Number As Integer = txtNumber.Text

        If Number = 0 Then
            MessageBox.Show("Zero")
        ElseIf Number > 0 Then
            MessageBox.Show("Positive Number")
        ElseIf Number < 0 Then
            MessageBox.Show("Negative Number")
        End If

    End Sub
End Class
