Public Class Form1
    Private Sub btnCountToZero_Click(sender As Object, e As EventArgs) Handles btnCountToZero.Click

        Dim numberEntered As Integer = txtNumberEntered.Text

        While numberEntered
            MessageBox.Show("number " & numberEntered)
            numberEntered = numberEntered - 1
        End While
    End Sub
End Class
