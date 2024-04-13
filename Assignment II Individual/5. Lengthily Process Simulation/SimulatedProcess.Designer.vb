<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SimulatedProcess
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
        components = New ComponentModel.Container()
        ProgressBar = New ProgressBar()
        LabelProgress = New Label()
        TimerProcess = New Timer(components)
        StartProcessButton = New Button()
        ResetProgressButton = New Button()
        SuspendLayout()
        ' 
        ' ProgressBar
        ' 
        ProgressBar.Location = New Point(149, 167)
        ProgressBar.Name = "ProgressBar"
        ProgressBar.Size = New Size(471, 41)
        ProgressBar.TabIndex = 0
        ' 
        ' LabelProgress
        ' 
        LabelProgress.AutoSize = True
        LabelProgress.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelProgress.ForeColor = SystemColors.HotTrack
        LabelProgress.Location = New Point(149, 101)
        LabelProgress.Name = "LabelProgress"
        LabelProgress.Size = New Size(130, 28)
        LabelProgress.TabIndex = 1
        LabelProgress.Text = "Progress: 0%"
        ' 
        ' TimerProcess
        ' 
        TimerProcess.Interval = 1000
        ' 
        ' StartProcessButton
        ' 
        StartProcessButton.BackColor = Color.GreenYellow
        StartProcessButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        StartProcessButton.Location = New Point(175, 279)
        StartProcessButton.Name = "StartProcessButton"
        StartProcessButton.Size = New Size(177, 56)
        StartProcessButton.TabIndex = 2
        StartProcessButton.Text = "Start Process"
        StartProcessButton.UseVisualStyleBackColor = False
        ' 
        ' ResetProgressButton
        ' 
        ResetProgressButton.BackColor = Color.IndianRed
        ResetProgressButton.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetProgressButton.Location = New Point(394, 279)
        ResetProgressButton.Name = "ResetProgressButton"
        ResetProgressButton.Size = New Size(179, 56)
        ResetProgressButton.TabIndex = 3
        ResetProgressButton.Text = "Reset Progress"
        ResetProgressButton.UseVisualStyleBackColor = False
        ' 
        ' SimulatedProcess
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ResetProgressButton)
        Controls.Add(StartProcessButton)
        Controls.Add(LabelProgress)
        Controls.Add(ProgressBar)
        Name = "SimulatedProcess"
        Text = "Simulated Process"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents LabelProgress As Label
    Friend WithEvents TimerProcess As Timer
    Friend WithEvents StartProcessButton As Button
    Friend WithEvents ResetProgressButton As Button

End Class
