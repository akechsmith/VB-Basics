Public Class CalculateCompoundInterest
    Private Sub DisplayAmountButton_Click(sender As Object, e As EventArgs) Handles DisplayAmountButton.Click
        CalculateAndDisplayAmounts()
    End Sub
    Private Sub CalculateAndDisplayAmounts()
        ' Constants
        Const initialInvestment As Double = 1000000 ' KSh
        Const annualInterestRate As Double = 0.05 ' 5 percent
        Const numberOfYears As Integer = 10

        ListBox1.Items.Clear()

        ' Loop through each year and calculate the amount
        For year As Integer = 1 To numberOfYears
            ' formula A = P(1 + R)^n
            Dim amount As Double = initialInvestment * (1 + annualInterestRate) ^ year

            ' Addinf to the ListBox
            ListBox1.Items.Add("Year" & year.ToString() & "   -     " & amount.ToString("C"))
        Next
    End Sub
    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        ' Close the form
        Close()
    End Sub

End Class

