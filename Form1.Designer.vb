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
        LoadObjectButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' LoadObjectButton
        ' 
        LoadObjectButton.Location = New Point(59, 252)
        LoadObjectButton.Name = "LoadObjectButton"
        LoadObjectButton.Size = New Size(273, 82)
        LoadObjectButton.TabIndex = 0
        LoadObjectButton.Text = "Load Object Demo"
        LoadObjectButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(513, 252)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(150, 82)
        ExitButton.TabIndex = 1
        ExitButton.Text = "EXIT"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ExitButton)
        Controls.Add(LoadObjectButton)
        Name = "Form1"
        Text = "Welcoming Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadObjectButton As Button
    Friend WithEvents ExitButton As Button

End Class
