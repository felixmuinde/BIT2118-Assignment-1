<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckBoxes
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
        Me.ChkBold = New System.Windows.Forms.CheckBox()
        Me.ChkItalic = New System.Windows.Forms.CheckBox()
        Me.TxtDisplay = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ChkUnderline = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ChkBold
        '
        Me.ChkBold.AutoSize = True
        Me.ChkBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChkBold.Location = New System.Drawing.Point(59, 115)
        Me.ChkBold.Name = "ChkBold"
        Me.ChkBold.Size = New System.Drawing.Size(64, 24)
        Me.ChkBold.TabIndex = 0
        Me.ChkBold.Text = "Bold"
        Me.ChkBold.UseVisualStyleBackColor = True
        '
        'ChkItalic
        '
        Me.ChkItalic.AutoSize = True
        Me.ChkItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic)
        Me.ChkItalic.Location = New System.Drawing.Point(59, 147)
        Me.ChkItalic.Name = "ChkItalic"
        Me.ChkItalic.Size = New System.Drawing.Size(61, 24)
        Me.ChkItalic.TabIndex = 1
        Me.ChkItalic.Text = "Italic"
        Me.ChkItalic.UseVisualStyleBackColor = True
        '
        'TxtDisplay
        '
        Me.TxtDisplay.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDisplay.Location = New System.Drawing.Point(59, 47)
        Me.TxtDisplay.MinimumSize = New System.Drawing.Size(4, 36)
        Me.TxtDisplay.Name = "TxtDisplay"
        Me.TxtDisplay.Size = New System.Drawing.Size(218, 27)
        Me.TxtDisplay.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.Button1.Location = New System.Drawing.Point(59, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(218, 38)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "CLOSE THE FORM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ChkUnderline
        '
        Me.ChkUnderline.AutoSize = True
        Me.ChkUnderline.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Underline)
        Me.ChkUnderline.Location = New System.Drawing.Point(129, 115)
        Me.ChkUnderline.Name = "ChkUnderline"
        Me.ChkUnderline.Size = New System.Drawing.Size(96, 24)
        Me.ChkUnderline.TabIndex = 4
        Me.ChkUnderline.Text = "Underline"
        Me.ChkUnderline.UseVisualStyleBackColor = True
        '
        'frmCheckBoxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 246)
        Me.Controls.Add(Me.ChkUnderline)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtDisplay)
        Me.Controls.Add(Me.ChkItalic)
        Me.Controls.Add(Me.ChkBold)
        Me.Name = "frmCheckBoxes"
        Me.Text = "Formatting Text in a Text Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ChkBold As CheckBox
    Friend WithEvents ChkItalic As CheckBox
    Friend WithEvents TxtDisplay As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ChkUnderline As CheckBox
End Class
