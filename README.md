# BIT2118-Assignment-1 SCT221-C003-0030/2023

Applications Programming first Assignment

## Activity 4.1 Labels, Textboxes and Command Buttons

### Code

```
Public Class frmCalculator
    Private Sub btnAddNumbers_Click(sender As Object, e As EventArgs) Handles btnAddNumbers.Click
        txtResult.Text = Val(txtNum1.Text) + Val(txtNum2.Text)
    End Sub
End Class

```

### Screenshots

![image](https://github.com/user-attachments/assets/ae478f17-8101-44a6-98e2-ea14e1d52c6a)

## Activity 4.1.1 More Arithmetic Operations

### Code 
```
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

```

### Subtraction

![image](https://github.com/user-attachments/assets/218b6dcb-0f2d-4f6a-957b-6a94242460c4)

### Multiplication

![image](https://github.com/user-attachments/assets/e8dfca60-9034-44c0-a8d9-32b863100fd0)

### Division

![image](https://github.com/user-attachments/assets/4991e2e8-bc0e-4d11-ad9a-3e4b54b29581)


## Activity 4.2 CheckBoxes

### Code 
```
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
```

### Bold

![image](https://github.com/user-attachments/assets/15c76dc7-12e0-4924-bf29-386ee793d01a)

### Italic

![image](https://github.com/user-attachments/assets/f8fbb1df-6f50-4e28-b15f-a68f3d0b9d92)

### Underlined

![image](https://github.com/user-attachments/assets/29f9689a-30e6-4b84-9414-1db54db680fd)


## Activity 4.3 Options 

### Source Code

```
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
```

### Male Selected

![image](https://github.com/user-attachments/assets/6e6d3a82-2f6a-4d67-a5c3-13ea74543fd9)

### Female Selected

![image](https://github.com/user-attachments/assets/0fc27a83-c1ba-4762-865f-355a856545bf)

### None Selected

![image](https://github.com/user-attachments/assets/c4a6d8aa-a280-4b91-a888-c718ebe909eb)
