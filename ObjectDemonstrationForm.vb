Public Class ObjectDemonstrationForm
    Private Sub SampleTestTextBox_TextChanged(sender As Object, e As EventArgs) Handles SampleTestTextBox.TextChanged

    End Sub

    Private Sub TahomaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TahomaRadioButton.CheckedChanged
        If TahomaRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Tahoma", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub GaramondRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadioButton.CheckedChanged
        If GaramondRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Garamond", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub MagnetoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioButton.CheckedChanged
        If MagnetoRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Magneto", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoadImageButton_Click(sender As Object, e As EventArgs) Handles LoadImageButton.Click
        ' Button, for loading a picture from the computer and display it in the picture box control.
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedImage As Image = Image.FromFile(openFileDialog.FileName)
            ImagePictureBox.Image = selectedImage
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BoldCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldCheckBox.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular

        If ItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If BoldCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If BoldItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold Or FontStyle.Italic
        End If
        SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, fontStyle)
    End Sub
    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged

        If GreenRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Green
        End If
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        If BlueRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        If RedRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Red
        End If
    End Sub

    Private Sub ItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicCheckBox.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular

        If ItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If
        If BoldCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If BoldItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold Or FontStyle.Italic
        End If

        SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, fontStyle)

    End Sub

    Private Sub BoldItalicCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles BoldItalicCheckBox.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular

        If ItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Italic
        End If

        If BoldCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold
        End If

        If BoldItalicCheckBox.Checked Then
            fontStyle = fontStyle Or FontStyle.Bold Or FontStyle.Italic
        End If

        SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, fontStyle)
    End Sub

End Class