Public Class DemoForm
    Public Sub SetFormSize()
        Dim screenWidth As Integer
        Dim screenHeight As Integer

        ' Get the screen dimensions
        screenWidth = Screen.PrimaryScreen.Bounds.Width
        screenHeight = Screen.PrimaryScreen.Bounds.Height

        ' Set the form size
        Me.Height = screenHeight \ 2 ' Set vertical size to half the screen height
        Me.Width = screenWidth * 3 \ 4 ' Set horizontal size to three-quarters the screen width
    End Sub
    Private Sub DemoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the SetFormSize subroutine to adjust the form size
        SetFormSize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
