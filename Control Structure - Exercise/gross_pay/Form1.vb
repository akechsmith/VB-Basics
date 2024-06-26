﻿Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComputeButton_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Try
            Dim HoursDecimal, PayRateDecimal, GrossPayDecimal As Decimal
            If EmployeeNameTextBox.Text.Trim = String.Empty Then
                MessageBox.Show("Name is required", "Name Missing Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
                EmployeeNameTextBox.Focus()
                EmployeeNameTextBox.SelectAll()

            ElseIf IsNumeric(HoursWorkedTextBox.Text) = False OrElse
            (Decimal.Parse(HoursWorkedTextBox.Text, Globalization.NumberStyles.Number) <= 0D Or
            Decimal.Parse(HoursWorkedTextBox.Text,
            Globalization.NumberStyles.Number) > 60D) Then
                'Hours must be numeric and within allowable range
                MessageBox.Show("Hours worked must be numeric between 0 and 60",
                "Hours Value Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
                HoursWorkedTextBox.Focus()
                HoursWorkedTextBox.SelectAll()

            ElseIf IsNumeric(PayRateTextBox.Text) = False OrElse
            Decimal.Parse(PayRateTextBox.Text,
            Globalization.NumberStyles.Currency) <= 0D Then
                'Pay rate must be numeric and greater than zero
                MessageBox.Show("Pay rate worked must be greater than zero.",
                "Pay Rate Value Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error)
                PayRateTextBox.Focus()
                PayRateTextBox.SelectAll()

            Else
                HoursDecimal = Decimal.Parse(HoursWorkedTextBox.Text,
                Globalization.NumberStyles.Number)
                PayRateDecimal = Decimal.Parse(PayRateTextBox.Text,
                Globalization.NumberStyles.Currency)
                'Compute gross pay
                If HoursDecimal <= 40D Then 'pay only regular time
                    GrossPayDecimal = Decimal.Round(HoursDecimal * PayRateDecimal, 2)
                Else 'pay regular + overtime
                    GrossPayDecimal = Decimal.Round((40D * PayRateDecimal) + ((HoursDecimal - 40D) * PayRateDecimal * 1.5D), 2)
                End If
                GrossPayTextBox.Text = GrossPayDecimal.ToString("C")
            End If
        Catch ex As Exception
            MessageBox.Show("Unexpected error: " & ControlChars.NewLine &
            ex.Message, "Compute Button Error", MessageBoxButtons.OK,
            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub HoursWorkedTextBox_TextChanged(sender As Object, e As EventArgs) Handles HoursWorkedTextBox.TextChanged

    End Sub
End Class
