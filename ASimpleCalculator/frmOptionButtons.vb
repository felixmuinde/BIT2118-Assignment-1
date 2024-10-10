Public Class frmOptionButtons
    Private Sub frmOptionButtons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optMale.Checked = False
        optFemale.Checked = False
    End Sub

    Private Sub cmdConfirm_Click(sender As Object, e As EventArgs) Handles cmdConfirm.Click
        If optMale.Checked = True Then
            MsgBox("You are a Male")
        ElseIf optFemale.Checked = True Then
            MsgBox("You are a Female")
        Else
            MsgBox("C'mon You are Neither Male not Female")
        End If
    End Sub
End Class