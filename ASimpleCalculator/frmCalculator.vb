Public Class frmCalculator
    Private Sub btnAddNumbers_Click(sender As Object, e As EventArgs) Handles btnAddNumbers.Click
        txtResult.Text = Val(txtNum1.Text) + Val(txtNum2.Text)
    End Sub
End Class
