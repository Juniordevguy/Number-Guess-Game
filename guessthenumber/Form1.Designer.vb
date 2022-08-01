<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumberGuess
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
        Me.btnGuessMode = New System.Windows.Forms.Button()
        Me.lblGuessNumber = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGuessMode
        '
        Me.btnGuessMode.BackColor = System.Drawing.Color.Gray
        Me.btnGuessMode.Location = New System.Drawing.Point(71, 175)
        Me.btnGuessMode.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnGuessMode.Name = "btnGuessMode"
        Me.btnGuessMode.Size = New System.Drawing.Size(217, 48)
        Me.btnGuessMode.TabIndex = 0
        Me.btnGuessMode.Text = "Guess"
        Me.btnGuessMode.UseVisualStyleBackColor = False
        '
        'lblGuessNumber
        '
        Me.lblGuessNumber.AutoSize = True
        Me.lblGuessNumber.ForeColor = System.Drawing.Color.Gold
        Me.lblGuessNumber.Location = New System.Drawing.Point(63, 85)
        Me.lblGuessNumber.Name = "lblGuessNumber"
        Me.lblGuessNumber.Size = New System.Drawing.Size(225, 39)
        Me.lblGuessNumber.TabIndex = 1
        Me.lblGuessNumber.Text = "SELECT MODE"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Gray
        Me.btnExit.Location = New System.Drawing.Point(71, 373)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(217, 48)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(71, 274)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(217, 48)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Timer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frmNumberGuess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(21.0!, 39.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(369, 558)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblGuessNumber)
        Me.Controls.Add(Me.btnGuessMode)
        Me.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(8, 7, 8, 7)
        Me.Name = "frmNumberGuess"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guess a Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGuessMode As Button
    Friend WithEvents lblGuessNumber As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents Button1 As Button
End Class
