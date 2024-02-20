
Imports System.Windows.Forms
Public Class Form1
    Private welcomeTooltTip As New ToolTip()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        welcomeTooltTip.SetToolTip(Me, "click once to maximize the form and change the background color to red")
        welcomeTooltTip.SetToolTip(LoadObjectButton, "Click to open object demonstration form")
        welcomeTooltTip.SetToolTip(ExitButton, "Click to exit the form")
    End Sub

    Private Sub LoadObjectButton_Click(sender As Object, e As EventArgs) Handles LoadObjectButton.Click
        Dim ObjectDemoForm As New ObjectDemonstrationForm()
        ObjectDemoForm.Show()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
