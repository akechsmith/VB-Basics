<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComputeCommision
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
        DailySaleTextBox = New TextBox()
        CalculateButon = New Button()
        ResultListBox = New ListBox()
        CloseButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(135, 20)
        Label1.TabIndex = 0
        Label1.Text = "Salesperson Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 77)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 20)
        Label2.TabIndex = 1
        Label2.Text = "Daily Sales: "
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(190, 32)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(333, 27)
        NameTextBox.TabIndex = 2
        ' 
        ' DailySaleTextBox
        ' 
        DailySaleTextBox.Location = New Point(190, 77)
        DailySaleTextBox.Name = "DailySaleTextBox"
        DailySaleTextBox.Size = New Size(333, 27)
        DailySaleTextBox.TabIndex = 3
        ' 
        ' CalculateButon
        ' 
        CalculateButon.Location = New Point(546, 35)
        CalculateButon.Name = "CalculateButon"
        CalculateButon.Size = New Size(125, 53)
        CalculateButon.TabIndex = 4
        CalculateButon.Text = "Calculate"
        CalculateButon.UseVisualStyleBackColor = True
        ' 
        ' ResultListBox
        ' 
        ResultListBox.FormattingEnabled = True
        ResultListBox.Location = New Point(23, 134)
        ResultListBox.Name = "ResultListBox"
        ResultListBox.Size = New Size(723, 304)
        ResultListBox.TabIndex = 5
        ' 
        ' CloseButton
        ' 
        CloseButton.Location = New Point(688, 38)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(100, 50)
        CloseButton.TabIndex = 6
        CloseButton.Text = "close"
        CloseButton.UseVisualStyleBackColor = True
        ' 
        ' ComputeCommision
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CloseButton)
        Controls.Add(ResultListBox)
        Controls.Add(CalculateButon)
        Controls.Add(DailySaleTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "ComputeCommision"
        Text = "Compute Salepersons Commission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DailySaleTextBox As TextBox
    Friend WithEvents CalculateButon As Button
    Friend WithEvents ResultListBox As ListBox
    Friend WithEvents CloseButton As Button

End Class
