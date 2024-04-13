Public Class ASCII_Table
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputChar As String = InputBox("Enter a character:", "Input")
        Dim outputChar As String = GetNextChar(inputChar)
        MessageBox.Show("The next character is: " & outputChar, "Output")

    End Sub
    Private Function GetNextChar(inputChar As String) As String
        ' Convert the input character to its ASCII value
        Dim asciiValue As Integer = Asc(inputChar)

        ' Increment the ASCII value by 1 to get the next character
        Dim nextAsciiValue As Integer = asciiValue + 1

        ' Convert the ASCII value back to a character
        Dim nextChar As Char = Chr(nextAsciiValue)

        ' Return the next character
        Return nextChar
    End Function

End Class
