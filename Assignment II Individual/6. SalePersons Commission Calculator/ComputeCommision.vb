Public Class ComputeCommision
    ' Constants
    Const WeeklyBasePay As Double = 2500
    Const Quota As Double = 1000
    Const CommissionRate As Double = 0.15

    ' Define structure to store salesperson data
    Structure Salesperson
        Dim Name As String
        Dim DailySales As Double
        Dim WeeklySales As Double
        Dim WeeklySalary As Double
    End Structure
    ' Array to store salesperson data
    Dim salespersons(9) As Salesperson
    Dim currentIndex As Integer = 0

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButon.Click
        ' Validate input
        Dim dailySales As Double
        If Not Double.TryParse(DailySaleTextBox.Text, dailySales) Then
            MessageBox.Show("Please enter a valid number for daily sales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Calculate weekly sales
        Dim weeklySales As Double = dailySales * 7

        ' Calculate commission
        Dim commission As Double = If(weeklySales > Quota, CommissionRate * weeklySales, 0)

        ' Calculate weekly salary
        Dim weeklySalary As Double = WeeklyBasePay + commission

        ' Store data in the array
        salespersons(currentIndex).Name = NameTextBox.Text
        salespersons(currentIndex).DailySales = dailySales
        salespersons(currentIndex).WeeklySales = weeklySales
        salespersons(currentIndex).WeeklySalary = weeklySalary

        ' Display results in list box
        Dim resultText As String = $"Name: {salespersons(currentIndex).Name}, Daily Sales: {salespersons(currentIndex).DailySales:C}, Weekly Sales: {salespersons(currentIndex).WeeklySales:C}, Weekly Salary: {salespersons(currentIndex).WeeklySalary:C}"
        ResultListBox.Items.Add(resultText)

        ' Increment the current index
        currentIndex += 1

        ' Reset input fields
        NameTextBox.Clear()
        DailySaleTextBox.Clear()

        ' Check if we've reached the maximum number of salespersons
        If currentIndex >= 10 Then
            CalculateButon.Enabled = False ' Disable the button if the maximum is reached
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

End Class
