<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ASCII_Table
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
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LawnGreen
        Button1.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(172, 145)
        Button1.Name = "Button1"
        Button1.Size = New Size(443, 127)
        Button1.TabIndex = 0
        Button1.Text = "Click me , To Start Predict Next Character"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ASCII_Table
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Name = "ASCII_Table"
        Text = "ASCII TABLE"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button

End Class
