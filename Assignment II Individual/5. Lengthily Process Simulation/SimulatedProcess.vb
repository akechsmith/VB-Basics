Public Class SimulatedProcess

    Private progressValue As Integer = 0

    Private Sub SimulatedProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the progress bar and label
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = 100
        ProgressBar.Value = 0
        LabelProgress.Text = "Progress: 0%"

    End Sub

    Private Sub StartProcessButton_Click(sender As Object, e As EventArgs) Handles StartProcessButton.Click
        TimerProcess.Enabled = True
    End Sub
    Private Sub TimerProcess_Tick(sender As Object, e As EventArgs) Handles TimerProcess.Tick
        ' Simulate the progress by incrementing the progress value
        progressValue += 10
        If progressValue > 100 Then
            progressValue = 100
            ' If progress reaches 100%, stop the timer
            TimerProcess.Enabled = False
        End If

        ' Update the progress bar and label
        ProgressBar.Value = progressValue
        LabelProgress.Text = "Progress: " & progressValue & "%"

    End Sub

    Private Sub ResetProgressButton_Click(sender As Object, e As EventArgs) Handles ResetProgressButton.Click
        ' Reset the progress
        progressValue = 0
        ProgressBar.Value = 0
        LabelProgress.Text = "Progress: 0%"

    End Sub
End Class
