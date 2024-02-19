<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemonstrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        SampleTestTextBox = New TextBox()
        Label2 = New Label()
        GaramondRadioButton = New RadioButton()
        MagnetoRadioButton = New RadioButton()
        TahomaRadioButton = New RadioButton()
        Label3 = New Label()
        ItalicCheckBox = New CheckBox()
        BoldCheckBox = New CheckBox()
        BoldItalicCheckBox = New CheckBox()
        Label4 = New Label()
        GreenRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        RedRadioButton = New RadioButton()
        ExitButton = New Button()
        ImagePictureBox = New PictureBox()
        LoadImageButton = New Button()
        CType(ImagePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 32)
        Label1.TabIndex = 0
        Label1.Text = "Display Test"
        ' 
        ' SampleTestTextBox
        ' 
        SampleTestTextBox.Location = New Point(12, 65)
        SampleTestTextBox.Name = "SampleTestTextBox"
        SampleTestTextBox.Size = New Size(180, 39)
        SampleTestTextBox.TabIndex = 1
        SampleTestTextBox.Text = "Sample Test"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(331, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 32)
        Label2.TabIndex = 2
        Label2.Text = "Font"
        ' 
        ' GaramondRadioButton
        ' 
        GaramondRadioButton.AutoSize = True
        GaramondRadioButton.Location = New Point(311, 68)
        GaramondRadioButton.Name = "GaramondRadioButton"
        GaramondRadioButton.Size = New Size(156, 36)
        GaramondRadioButton.TabIndex = 3
        GaramondRadioButton.TabStop = True
        GaramondRadioButton.Text = "Garamond"
        GaramondRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MagnetoRadioButton
        ' 
        MagnetoRadioButton.AutoSize = True
        MagnetoRadioButton.Location = New Point(473, 68)
        MagnetoRadioButton.Name = "MagnetoRadioButton"
        MagnetoRadioButton.Size = New Size(142, 36)
        MagnetoRadioButton.TabIndex = 4
        MagnetoRadioButton.TabStop = True
        MagnetoRadioButton.Text = "Magneto"
        MagnetoRadioButton.UseVisualStyleBackColor = True
        ' 
        ' TahomaRadioButton
        ' 
        TahomaRadioButton.AutoSize = True
        TahomaRadioButton.Location = New Point(621, 68)
        TahomaRadioButton.Name = "TahomaRadioButton"
        TahomaRadioButton.Size = New Size(128, 36)
        TahomaRadioButton.TabIndex = 5
        TahomaRadioButton.TabStop = True
        TahomaRadioButton.Text = "Tahoma"
        TahomaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(408, 180)
        Label3.Name = "Label3"
        Label3.Size = New Size(120, 32)
        Label3.TabIndex = 6
        Label3.Text = "Font Style"
        ' 
        ' ItalicCheckBox
        ' 
        ItalicCheckBox.AutoSize = True
        ItalicCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        ItalicCheckBox.Location = New Point(408, 241)
        ItalicCheckBox.Name = "ItalicCheckBox"
        ItalicCheckBox.Size = New Size(95, 36)
        ItalicCheckBox.TabIndex = 7
        ItalicCheckBox.Text = "Italic"
        ItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldCheckBox
        ' 
        BoldCheckBox.AutoSize = True
        BoldCheckBox.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BoldCheckBox.Location = New Point(408, 296)
        BoldCheckBox.Name = "BoldCheckBox"
        BoldCheckBox.Size = New Size(98, 36)
        BoldCheckBox.TabIndex = 8
        BoldCheckBox.Text = "Bold"
        BoldCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldItalicCheckBox
        ' 
        BoldItalicCheckBox.AutoSize = True
        BoldItalicCheckBox.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        BoldItalicCheckBox.Location = New Point(408, 338)
        BoldItalicCheckBox.Name = "BoldItalicCheckBox"
        BoldItalicCheckBox.Size = New Size(164, 36)
        BoldItalicCheckBox.TabIndex = 9
        BoldItalicCheckBox.Text = "Bold Italic"
        BoldItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(640, 180)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 32)
        Label4.TabIndex = 10
        Label4.Text = "Font Color"
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.Location = New Point(640, 219)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(109, 36)
        GreenRadioButton.TabIndex = 11
        GreenRadioButton.TabStop = True
        GreenRadioButton.Text = "Green"
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.Location = New Point(640, 261)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(92, 36)
        BlueRadioButton.TabIndex = 12
        BlueRadioButton.TabStop = True
        BlueRadioButton.Text = "Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' RedRadioButton
        ' 
        RedRadioButton.AutoSize = True
        RedRadioButton.Location = New Point(640, 312)
        RedRadioButton.Name = "RedRadioButton"
        RedRadioButton.Size = New Size(85, 36)
        RedRadioButton.TabIndex = 13
        RedRadioButton.TabStop = True
        RedRadioButton.Text = "Red"
        RedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Location = New Point(657, 381)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(131, 46)
        ExitButton.TabIndex = 14
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' ImagePictureBox
        ' 
        ImagePictureBox.BorderStyle = BorderStyle.FixedSingle
        ImagePictureBox.Location = New Point(35, 180)
        ImagePictureBox.Name = "ImagePictureBox"
        ImagePictureBox.Size = New Size(253, 212)
        ImagePictureBox.TabIndex = 15
        ImagePictureBox.TabStop = False
        ' 
        ' LoadImageButton
        ' 
        LoadImageButton.Location = New Point(42, 398)
        LoadImageButton.Name = "LoadImageButton"
        LoadImageButton.Size = New Size(150, 46)
        LoadImageButton.TabIndex = 16
        LoadImageButton.Text = "Load Photo"
        LoadImageButton.UseVisualStyleBackColor = True
        ' 
        ' ObjectDemonstrationForm
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LoadImageButton)
        Controls.Add(ImagePictureBox)
        Controls.Add(ExitButton)
        Controls.Add(RedRadioButton)
        Controls.Add(BlueRadioButton)
        Controls.Add(GreenRadioButton)
        Controls.Add(Label4)
        Controls.Add(BoldItalicCheckBox)
        Controls.Add(BoldCheckBox)
        Controls.Add(ItalicCheckBox)
        Controls.Add(Label3)
        Controls.Add(TahomaRadioButton)
        Controls.Add(MagnetoRadioButton)
        Controls.Add(GaramondRadioButton)
        Controls.Add(Label2)
        Controls.Add(SampleTestTextBox)
        Controls.Add(Label1)
        Name = "ObjectDemonstrationForm"
        Text = "ObjectDemonstrationForm"
        CType(ImagePictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SampleTestTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents ItalicCheckBox As CheckBox
    Friend WithEvents BoldCheckBox As CheckBox
    Friend WithEvents BoldItalicCheckBox As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents ExitButton As Button
    Friend WithEvents ImagePictureBox As PictureBox
    Friend WithEvents LoadImageButton As Button
End Class
