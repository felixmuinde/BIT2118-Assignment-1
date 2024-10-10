<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptionButtons
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
        Me.lblGender = New System.Windows.Forms.Label()
        Me.optMale = New System.Windows.Forms.RadioButton()
        Me.optFemale = New System.Windows.Forms.RadioButton()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(57, 84)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(387, 22)
        Me.lblGender.TabIndex = 0
        Me.lblGender.Text = "Select your Gender and Click Command Button"
        '
        'optMale
        '
        Me.optMale.AutoSize = True
        Me.optMale.Checked = True
        Me.optMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMale.Location = New System.Drawing.Point(119, 150)
        Me.optMale.Name = "optMale"
        Me.optMale.Size = New System.Drawing.Size(61, 24)
        Me.optMale.TabIndex = 1
        Me.optMale.TabStop = True
        Me.optMale.Text = "Male"
        Me.optMale.UseVisualStyleBackColor = True
        '
        'optFemale
        '
        Me.optFemale.AutoSize = True
        Me.optFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optFemale.Location = New System.Drawing.Point(119, 205)
        Me.optFemale.Name = "optFemale"
        Me.optFemale.Size = New System.Drawing.Size(80, 24)
        Me.optFemale.TabIndex = 2
        Me.optFemale.TabStop = True
        Me.optFemale.Text = "Female"
        Me.optFemale.UseVisualStyleBackColor = True
        '
        'cmdConfirm
        '
        Me.cmdConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConfirm.Location = New System.Drawing.Point(119, 266)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.Size = New System.Drawing.Size(255, 39)
        Me.cmdConfirm.TabIndex = 3
        Me.cmdConfirm.Text = "Confirm your selection"
        Me.cmdConfirm.UseVisualStyleBackColor = True
        '
        'frmOptionButtons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 388)
        Me.Controls.Add(Me.cmdConfirm)
        Me.Controls.Add(Me.optFemale)
        Me.Controls.Add(Me.optMale)
        Me.Controls.Add(Me.lblGender)
        Me.Name = "frmOptionButtons"
        Me.Text = "Selecting Gender"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGender As Label
    Friend WithEvents optMale As RadioButton
    Friend WithEvents optFemale As RadioButton
    Friend WithEvents cmdConfirm As Button
End Class
