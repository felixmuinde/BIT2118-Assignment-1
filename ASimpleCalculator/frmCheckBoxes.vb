Public Class frmCheckBoxes
    Private Sub ChkBold_CheckedChanged(sender As Object, e As EventArgs) Handles ChkBold.CheckedChanged
        If ChkBold.Checked Then
            TxtDisplay.Font = New Font(TxtDisplay.Font, FontStyle.Bold)
        Else
            TxtDisplay.Font = New Font(TxtDisplay.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub ChkItalic_CheckedChanged(sender As Object, e As EventArgs) Handles ChkItalic.CheckedChanged
        If ChkItalic.Checked Then
            TxtDisplay.Font = New Font(TxtDisplay.Font, FontStyle.Italic)
        Else
            TxtDisplay.Font = New Font(TxtDisplay.Font, FontStyle.Regular)
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub ChkUnderline_CheckedChanged(sender As Object, e As EventArgs) Handles ChkUnderline.CheckedChanged
        If ChkUnderline.Checked Then
            TxtDisplay.Font = New Font(TxtDisplay.Font, FontStyle.Underline)
        Else
            TxtDisplay.Font = New Font(TxtDisplay.Font, FontStyle.Regular)
        End If
    End Sub
End Class