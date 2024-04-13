<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalculateCompoundInterest
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
        ListBox1 = New ListBox()
        DisplayAmountButton = New Button()
        QuitButton = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(126, 12)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(506, 304)
        ListBox1.TabIndex = 0
        ' 
        ' DisplayAmountButton
        ' 
        DisplayAmountButton.BackColor = SystemColors.MenuHighlight
        DisplayAmountButton.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DisplayAmountButton.Location = New Point(126, 355)
        DisplayAmountButton.Name = "DisplayAmountButton"
        DisplayAmountButton.Size = New Size(218, 56)
        DisplayAmountButton.TabIndex = 1
        DisplayAmountButton.Text = "Display Amount"
        DisplayAmountButton.UseVisualStyleBackColor = False
        ' 
        ' QuitButton
        ' 
        QuitButton.BackColor = Color.Red
        QuitButton.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        QuitButton.Location = New Point(575, 369)
        QuitButton.Name = "QuitButton"
        QuitButton.RightToLeft = RightToLeft.No
        QuitButton.Size = New Size(75, 42)
        QuitButton.TabIndex = 2
        QuitButton.Text = "QUIT"
        QuitButton.UseVisualStyleBackColor = False
        ' 
        ' CalculateCompoundInterest
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(QuitButton)
        Controls.Add(DisplayAmountButton)
        Controls.Add(ListBox1)
        Name = "CalculateCompoundInterest"
        Text = "Calculate and Display Amount"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DisplayAmountButton As Button
    Friend Protected WithEvents QuitButton As Button

End Class
