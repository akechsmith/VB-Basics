Public Class Form1
    Private Sub ComputeGradeButtton_Click(sender As Object, e As EventArgs) Handles ComputeGradeButtton.Click
        Try
            Dim Subject1Marks, Subject2Marks, Subject3Marks, Subject4Marks As Integer
            Dim AverageMarks As Decimal

            Subject1Marks = Integer.Parse(Subject1TextBox.Text)
            Subject2Marks = Integer.Parse(Subject2TextBox.Text)
            Subject3Marks = Integer.Parse(Subject3TextBox.Text)
            Subject4Marks = Integer.Parse(Subject4TextBox.Text)

            AverageMarks = (Subject1Marks + Subject2Marks + Subject3Marks + Subject4Marks) / 4

            If AverageMarks >= 0 AndAlso AverageMarks <= 49 Then
                MessageBox.Show("Your Grade is, FAIL", "Display Grade", MessageBoxButtons.OK)

            ElseIf AverageMarks >= 50 AndAlso AverageMarks <= 64 Then
                MessageBox.Show("Your Grade is, C", "Display Grade", MessageBoxButtons.OK)

            ElseIf AverageMarks >= 65 AndAlso AverageMarks <= 74 Then
                MessageBox.Show("Your Grade is, B", "Display Grade", MessageBoxButtons.OK)

            ElseIf AverageMarks >= 75 AndAlso AverageMarks <= 100 Then
                MessageBox.Show("Your Grade is, A", "Display Grade", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
            MessageBox.Show("Please enter valid marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Subject1TextBox.Focus()
        End Try

        Subject1TextBox.Text = ""
        Subject2TextBox.Text = ""
        Subject3TextBox.Text = ""
        Subject4TextBox.Text = ""

        Subject1TextBox.Focus()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
