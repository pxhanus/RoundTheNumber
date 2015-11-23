<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnRound = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDecimalPlaces = New System.Windows.Forms.TextBox()
        Me.lblAns = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a number:"
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(100, 19)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(78, 20)
        Me.txtNum.TabIndex = 1
        '
        'btnRound
        '
        Me.btnRound.Location = New System.Drawing.Point(205, 17)
        Me.btnRound.Name = "btnRound"
        Me.btnRound.Size = New System.Drawing.Size(75, 23)
        Me.btnRound.TabIndex = 2
        Me.btnRound.Text = "Round"
        Me.btnRound.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Decimal places:"
        '
        'txtDecimalPlaces
        '
        Me.txtDecimalPlaces.Location = New System.Drawing.Point(100, 57)
        Me.txtDecimalPlaces.Name = "txtDecimalPlaces"
        Me.txtDecimalPlaces.Size = New System.Drawing.Size(78, 20)
        Me.txtDecimalPlaces.TabIndex = 4
        '
        'lblAns
        '
        Me.lblAns.AutoSize = True
        Me.lblAns.Location = New System.Drawing.Point(212, 60)
        Me.lblAns.Name = "lblAns"
        Me.lblAns.Size = New System.Drawing.Size(0, 13)
        Me.lblAns.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 98)
        Me.Controls.Add(Me.lblAns)
        Me.Controls.Add(Me.txtDecimalPlaces)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRound)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Round The Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents btnRound As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDecimalPlaces As System.Windows.Forms.TextBox
    Friend WithEvents lblAns As System.Windows.Forms.Label

End Class
