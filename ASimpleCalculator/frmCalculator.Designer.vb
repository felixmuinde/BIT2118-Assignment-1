<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculator
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
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnAddNumbers = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.Location = New System.Drawing.Point(61, 59)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(100, 20)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.Text = "First Number"
        '
        'lblSecond
        '
        Me.lblSecond.AutoSize = True
        Me.lblSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.Location = New System.Drawing.Point(61, 108)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(124, 20)
        Me.lblSecond.TabIndex = 1
        Me.lblSecond.Text = "Second Number"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(61, 159)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(55, 20)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "Result"
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(236, 59)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(127, 20)
        Me.txtNum1.TabIndex = 3
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(236, 110)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(127, 20)
        Me.txtNum2.TabIndex = 4
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(236, 161)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(127, 20)
        Me.txtResult.TabIndex = 5
        '
        'btnAddNumbers
        '
        Me.btnAddNumbers.Location = New System.Drawing.Point(236, 239)
        Me.btnAddNumbers.Name = "btnAddNumbers"
        Me.btnAddNumbers.Size = New System.Drawing.Size(96, 35)
        Me.btnAddNumbers.TabIndex = 6
        Me.btnAddNumbers.Text = "ADD NUMBERS"
        Me.btnAddNumbers.UseVisualStyleBackColor = True
        '
        'frmCalculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 391)
        Me.Controls.Add(Me.btnAddNumbers)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Name = "frmCalculate"
        Me.Text = "A simple Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtNum1 As TextBox
    Friend WithEvents txtNum2 As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnAddNumbers As Button
End Class
