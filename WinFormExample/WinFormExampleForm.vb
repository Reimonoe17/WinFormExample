Public Class WinFormExampleForm

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        'Me.Text = "You have clicked the Button"
        Me.Text = NameTextBox.Text
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub
End Class
