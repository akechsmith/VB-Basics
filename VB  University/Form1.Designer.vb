<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        NameTextBox = New TextBox()
        MajorTextBox = New TextBox()
        Display1Button = New Button()
        Display2Button = New Button()
        DisplayButton = New Button()
        ResetButtton = New Button()
        PrintButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(40, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 20)
        Label1.TabIndex = 0
        Label1.Text = "Student name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 20)
        Label2.TabIndex = 1
        Label2.Text = "Academic mjaor:"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(194, 50)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.ReadOnly = True
        NameTextBox.Size = New Size(409, 27)
        NameTextBox.TabIndex = 2
        NameTextBox.TabStop = False
        ' 
        ' MajorTextBox
        ' 
        MajorTextBox.Location = New Point(194, 99)
        MajorTextBox.Name = "MajorTextBox"
        MajorTextBox.ReadOnly = True
        MajorTextBox.Size = New Size(409, 27)
        MajorTextBox.TabIndex = 3
        MajorTextBox.TabStop = False
        ' 
        ' Display1Button
        ' 
        Display1Button.Location = New Point(78, 179)
        Display1Button.Name = "Display1Button"
        Display1Button.Size = New Size(167, 68)
        Display1Button.TabIndex = 4
        Display1Button.Text = "Display Student #1"
        Display1Button.UseVisualStyleBackColor = True
        ' 
        ' Display2Button
        ' 
        Display2Button.Location = New Point(320, 179)
        Display2Button.Name = "Display2Button"
        Display2Button.Size = New Size(167, 68)
        Display2Button.TabIndex = 5
        Display2Button.Text = "Display Student #2"
        Display2Button.UseVisualStyleBackColor = True
        ' 
        ' DisplayButton
        ' 
        DisplayButton.Location = New Point(529, 179)
        DisplayButton.Name = "DisplayButton"
        DisplayButton.Size = New Size(167, 68)
        DisplayButton.TabIndex = 6
        DisplayButton.Text = "Display Student #3"
        DisplayButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButtton
        ' 
        ResetButtton.Location = New Point(78, 300)
        ResetButtton.Name = "ResetButtton"
        ResetButtton.Size = New Size(167, 68)
        ResetButtton.TabIndex = 7
        ResetButtton.Text = "&Reset Form "
        ResetButtton.TextImageRelation = TextImageRelation.TextAboveImage
        ResetButtton.UseVisualStyleBackColor = True
        ' 
        ' PrintButton
        ' 
        PrintButton.Location = New Point(309, 300)
        PrintButton.Name = "PrintButton"
        PrintButton.Size = New Size(167, 68)
        PrintButton.TabIndex = 8
        PrintButton.Text = "&Print Form"
        PrintButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(529, 300)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(167, 68)
        ExitButton.TabIndex = 9
        ExitButton.Text = "&Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(890, 511)
        Controls.Add(ExitButton)
        Controls.Add(PrintButton)
        Controls.Add(ResetButtton)
        Controls.Add(DisplayButton)
        Controls.Add(Display2Button)
        Controls.Add(Display1Button)
        Controls.Add(MajorTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents MajorTextBox As TextBox
    Friend WithEvents Display1Button As Button
    Friend WithEvents Display2Button As Button
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ResetButtton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button

End Class
