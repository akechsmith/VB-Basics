Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles MajorTextBox.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NameTextBox_TextChanged(sender As Object, e As EventArgs) Handles NameTextBox.TextChanged

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ResetButtton_Click(sender As Object, e As EventArgs) Handles ResetButtton.Click
        NameTextBox.Clear()
        MajorTextBox.Clear()
    End Sub

    Private Sub Display1Button_Click(sender As Object, e As EventArgs) Handles Display1Button.Click
        NameTextBox.Text = "Douglas Brook"
        MajorTextBox.Text = "Computer Management and information systems"
    End Sub
End Class
