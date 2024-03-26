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
        Label3 = New Label()
        Label4 = New Label()
        Subject1TextBox = New TextBox()
        Subject2TextBox = New TextBox()
        Subject3TextBox = New TextBox()
        Subject4TextBox = New TextBox()
        ComputeGradeButtton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(61, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 20)
        Label1.TabIndex = 0
        Label1.Text = "Subject 1:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 92)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 1
        Label2.Text = "Subject 2:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(61, 140)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 2
        Label3.Text = "Subject 3:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(61, 196)
        Label4.Name = "Label4"
        Label4.Size = New Size(73, 20)
        Label4.TabIndex = 3
        Label4.Text = "Subject 4:"
        ' 
        ' Subject1TextBox
        ' 
        Subject1TextBox.Location = New Point(207, 39)
        Subject1TextBox.Name = "Subject1TextBox"
        Subject1TextBox.Size = New Size(125, 27)
        Subject1TextBox.TabIndex = 4
        ' 
        ' Subject2TextBox
        ' 
        Subject2TextBox.Location = New Point(207, 85)
        Subject2TextBox.Name = "Subject2TextBox"
        Subject2TextBox.Size = New Size(125, 27)
        Subject2TextBox.TabIndex = 5
        ' 
        ' Subject3TextBox
        ' 
        Subject3TextBox.Location = New Point(207, 140)
        Subject3TextBox.Name = "Subject3TextBox"
        Subject3TextBox.Size = New Size(125, 27)
        Subject3TextBox.TabIndex = 6
        ' 
        ' Subject4TextBox
        ' 
        Subject4TextBox.Location = New Point(207, 196)
        Subject4TextBox.Name = "Subject4TextBox"
        Subject4TextBox.Size = New Size(125, 27)
        Subject4TextBox.TabIndex = 7
        ' 
        ' ComputeGradeButtton
        ' 
        ComputeGradeButtton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        ComputeGradeButtton.Location = New Point(138, 297)
        ComputeGradeButtton.Name = "ComputeGradeButtton"
        ComputeGradeButtton.Size = New Size(168, 59)
        ComputeGradeButtton.TabIndex = 8
        ComputeGradeButtton.Text = "&Compute Grade"
        ComputeGradeButtton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        ExitButton.Location = New Point(386, 297)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(168, 59)
        ExitButton.TabIndex = 9
        ExitButton.Text = "&Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(ComputeGradeButtton)
        Controls.Add(Subject4TextBox)
        Controls.Add(Subject3TextBox)
        Controls.Add(Subject2TextBox)
        Controls.Add(Subject1TextBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Compute Grade"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Subject1TextBox As TextBox
    Friend WithEvents Subject2TextBox As TextBox
    Friend WithEvents Subject3TextBox As TextBox
    Friend WithEvents Subject4TextBox As TextBox
    Friend WithEvents ComputeGradeButtton As Button
    Friend WithEvents ExitButton As Button

End Class
