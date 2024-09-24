Public Class Form1
    Private Sub btnShowInformation_Click(sender As Object, e As EventArgs) Handles btnShowInformation.Click

        Dim Name As String = txtName.Text
        Dim Age As Integer = txtAge.Text
        Dim FavoriteColor As String = txtFavoriteColor.Text

        MessageBox.Show("My Name is " & Name & vbCrLf &
                        "I am " & Age & " Years old" & vbCrLf &
                        "My favorite color is " & FavoriteColor)
    End Sub
End Class
