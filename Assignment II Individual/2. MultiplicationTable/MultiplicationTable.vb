Public Class MultiplicationTable
    Private Sub MultiplicationTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateMultiplicationTable()
    End Sub
    Private Sub GenerateMultiplicationTable()
        Dim tableText As String = "Multiplication Table" & vbCrLf

        For i As Integer = 1 To 7
            For j As Integer = 1 To 7
                tableText &= $"{i * j} "
            Next
            tableText &= vbCrLf
        Next

        TextBox1.Multiline = True ' Ensure TextBox is set to accept multiline text
        TextBox1.Text = tableText
    End Sub

End Class
