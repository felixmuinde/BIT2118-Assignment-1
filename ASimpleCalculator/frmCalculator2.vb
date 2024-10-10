Public Class frmCalculate

    Private Sub btnAddNumbers_Click(sender As Object, e As EventArgs) Handles btnAddNumbers.Click
        txtResult.Text = Val(txtNum1.Text) + Val(txtNum2.Text)
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        txtResult.Text = Val(txtNum1.Text) - Val(txtNum2.Text)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        txtResult.Text = Val(txtNum1.Text) * Val(txtNum2.Text)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        txtResult.Text = Val(txtNum1.Text) / Val(txtNum2.Text)
    End Sub
End Class
