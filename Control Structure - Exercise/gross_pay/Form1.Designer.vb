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
        EmployeeNameTextBox = New TextBox()
        HoursWorkedTextBox = New TextBox()
        PayRateTextBox = New TextBox()
        GrossPayTextBox = New TextBox()
        ComputeButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label1.Location = New Point(40, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 31)
        Label1.TabIndex = 0
        Label1.Text = "Employee Nmae"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label2.Location = New Point(40, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(169, 31)
        Label2.TabIndex = 1
        Label2.Text = "Hours Worked"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label3.Location = New Point(40, 132)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 31)
        Label3.TabIndex = 2
        Label3.Text = "Pay Rate"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label4.Location = New Point(40, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 31)
        Label4.TabIndex = 3
        Label4.Text = "Gross Pay"
        ' 
        ' EmployeeNameTextBox
        ' 
        EmployeeNameTextBox.Location = New Point(282, 32)
        EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        EmployeeNameTextBox.Size = New Size(269, 27)
        EmployeeNameTextBox.TabIndex = 4
        ' 
        ' HoursWorkedTextBox
        ' 
        HoursWorkedTextBox.Location = New Point(282, 88)
        HoursWorkedTextBox.Name = "HoursWorkedTextBox"
        HoursWorkedTextBox.Size = New Size(269, 27)
        HoursWorkedTextBox.TabIndex = 5
        ' 
        ' PayRateTextBox
        ' 
        PayRateTextBox.Location = New Point(282, 144)
        PayRateTextBox.Name = "PayRateTextBox"
        PayRateTextBox.Size = New Size(269, 27)
        PayRateTextBox.TabIndex = 6
        ' 
        ' GrossPayTextBox
        ' 
        GrossPayTextBox.Location = New Point(282, 199)
        GrossPayTextBox.Name = "GrossPayTextBox"
        GrossPayTextBox.ReadOnly = True
        GrossPayTextBox.Size = New Size(269, 27)
        GrossPayTextBox.TabIndex = 7
        ' 
        ' ComputeButton
        ' 
        ComputeButton.BackColor = SystemColors.AppWorkspace
        ComputeButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        ComputeButton.Location = New Point(130, 271)
        ComputeButton.Name = "ComputeButton"
        ComputeButton.Size = New Size(167, 45)
        ComputeButton.TabIndex = 8
        ComputeButton.Text = "Compute"
        ComputeButton.UseVisualStyleBackColor = False
        ' 
        ' ExitButton
        ' 
        ExitButton.BackColor = SystemColors.AppWorkspace
        ExitButton.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        ExitButton.Location = New Point(355, 271)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(167, 45)
        ExitButton.TabIndex = 9
        ExitButton.Text = "&Exit"
        ExitButton.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(ComputeButton)
        Controls.Add(GrossPayTextBox)
        Controls.Add(PayRateTextBox)
        Controls.Add(HoursWorkedTextBox)
        Controls.Add(EmployeeNameTextBox)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Compute Gross Pay "
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents HoursWorkedTextBox As TextBox
    Friend WithEvents PayRateTextBox As TextBox
    Friend WithEvents GrossPayTextBox As TextBox
    Friend WithEvents ComputeButton As Button
    Friend WithEvents ExitButton As Button

End Class
