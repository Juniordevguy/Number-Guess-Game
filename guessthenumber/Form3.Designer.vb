<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTimerStart = New System.Windows.Forms.Button()
        Me.btnTimerStop = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(20, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GUESS THE NUMBER (1-100)"
        '
        'btnTimerStart
        '
        Me.btnTimerStart.BackColor = System.Drawing.Color.Gray
        Me.btnTimerStart.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerStart.Location = New System.Drawing.Point(51, 227)
        Me.btnTimerStart.Name = "btnTimerStart"
        Me.btnTimerStart.Size = New System.Drawing.Size(402, 63)
        Me.btnTimerStart.TabIndex = 1
        Me.btnTimerStart.Text = "Start"
        Me.btnTimerStart.UseVisualStyleBackColor = False
        '
        'btnTimerStop
        '
        Me.btnTimerStop.BackColor = System.Drawing.Color.Gray
        Me.btnTimerStop.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimerStop.Location = New System.Drawing.Point(51, 360)
        Me.btnTimerStop.Name = "btnTimerStop"
        Me.btnTimerStop.Size = New System.Drawing.Size(402, 63)
        Me.btnTimerStop.TabIndex = 2
        Me.btnTimerStop.Text = "Exit"
        Me.btnTimerStop.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(222, 474)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "5"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(509, 558)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnTimerStop)
        Me.Controls.Add(Me.btnTimerStart)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnTimerStart As Button
    Friend WithEvents btnTimerStop As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
End Class
