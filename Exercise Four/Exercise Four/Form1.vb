Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String = String.Empty
        For I As Integer = 1 To 10
            For M As Integer = 1 To 10
                result &= $"{I * M,4}"
            Next
            result &= Environment.NewLine
        Next
        TextBox1.Text = result
    End Sub
End Class
