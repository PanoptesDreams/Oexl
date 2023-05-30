<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesktopClock
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
        Me.LabelClockLabel = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.TimerTicker = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LabelClockLabel
        '
        Me.LabelClockLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelClockLabel.AutoSize = True
        Me.LabelClockLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelClockLabel.ForeColor = System.Drawing.Color.White
        Me.LabelClockLabel.Location = New System.Drawing.Point(72, 46)
        Me.LabelClockLabel.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.LabelClockLabel.Name = "LabelClockLabel"
        Me.LabelClockLabel.Size = New System.Drawing.Size(68, 15)
        Me.LabelClockLabel.TabIndex = 3
        Me.LabelClockLabel.Text = "ClockLabel"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.ForeColor = System.Drawing.Color.White
        Me.lblTime.Location = New System.Drawing.Point(19, 9)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(184, 37)
        Me.lblTime.TabIndex = 2
        Me.lblTime.Text = "hh:mm:ss tt"
        '
        'TimerTicker
        '
        Me.TimerTicker.Enabled = True
        '
        'DesktopClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(233, 80)
        Me.Controls.Add(Me.LabelClockLabel)
        Me.Controls.Add(Me.lblTime)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.Name = "DesktopClock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DesktopClock"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelClockLabel As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents TimerTicker As Windows.Forms.Timer
End Class
