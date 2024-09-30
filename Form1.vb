Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Get user input from textboxes
        Dim userName As String = txtUserName.Text
        Dim userAge As String = txtUserAge.Text
        Dim favoriteColor As String = txtFavoriteColor.Text

        'Display the message in a label
        lblResult.Text = "Hello " & userName & ", you are " & userAge & " years old and your favorite color is " & favoriteColor & "."
    End Sub
End Class
