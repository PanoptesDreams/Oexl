<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
    Inherits RoundedForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.LabelOperatorName = New System.Windows.Forms.Label()
        Me.LabelGreeting = New System.Windows.Forms.Label()
        Me.PictureBoxOperatorAvatar = New System.Windows.Forms.PictureBox()
        Me.PictureBoxToolbox = New System.Windows.Forms.PictureBox()
        Me.PictureBoxShutdown = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOperatorAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxToolbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxShutdown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(1083, 3)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(1083, 22)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(1083, 41)
        '
        'LabelOperatorName
        '
        Me.LabelOperatorName.AutoSize = True
        Me.LabelOperatorName.Location = New System.Drawing.Point(7, 41)
        Me.LabelOperatorName.Name = "LabelOperatorName"
        Me.LabelOperatorName.Size = New System.Drawing.Size(115, 21)
        Me.LabelOperatorName.TabIndex = 1
        Me.LabelOperatorName.Text = "OperatorName"
        '
        'LabelGreeting
        '
        Me.LabelGreeting.AutoSize = True
        Me.LabelGreeting.Location = New System.Drawing.Point(7, 20)
        Me.LabelGreeting.Name = "LabelGreeting"
        Me.LabelGreeting.Size = New System.Drawing.Size(70, 21)
        Me.LabelGreeting.TabIndex = 2
        Me.LabelGreeting.Text = "Greeting"
        '
        'PictureBoxOperatorAvatar
        '
        Me.PictureBoxOperatorAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxOperatorAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxOperatorAvatar.Location = New System.Drawing.Point(305, 14)
        Me.PictureBoxOperatorAvatar.Name = "PictureBoxOperatorAvatar"
        Me.PictureBoxOperatorAvatar.Size = New System.Drawing.Size(51, 52)
        Me.PictureBoxOperatorAvatar.TabIndex = 3
        Me.PictureBoxOperatorAvatar.TabStop = False
        '
        'PictureBoxToolbox
        '
        Me.PictureBoxToolbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxToolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxToolbox.Location = New System.Drawing.Point(249, 14)
        Me.PictureBoxToolbox.Name = "PictureBoxToolbox"
        Me.PictureBoxToolbox.Padding = New System.Windows.Forms.Padding(3)
        Me.PictureBoxToolbox.Size = New System.Drawing.Size(51, 52)
        Me.PictureBoxToolbox.TabIndex = 4
        Me.PictureBoxToolbox.TabStop = False
        '
        'PictureBoxShutdown
        '
        Me.PictureBoxShutdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxShutdown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxShutdown.Location = New System.Drawing.Point(362, 14)
        Me.PictureBoxShutdown.Name = "PictureBoxShutdown"
        Me.PictureBoxShutdown.Padding = New System.Windows.Forms.Padding(3)
        Me.PictureBoxShutdown.Size = New System.Drawing.Size(51, 52)
        Me.PictureBoxShutdown.TabIndex = 5
        Me.PictureBoxShutdown.TabStop = False
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 220)
        Me.Controls.Add(Me.PictureBoxShutdown)
        Me.Controls.Add(Me.PictureBoxToolbox)
        Me.Controls.Add(Me.PictureBoxOperatorAvatar)
        Me.Controls.Add(Me.LabelGreeting)
        Me.Controls.Add(Me.LabelOperatorName)
        Me.ForeColor = System.Drawing.Color.Purple
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "Launcher"
        Me.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Text = "Launcher"
        Me.Controls.SetChildIndex(Me.LabelOperatorName, 0)
        Me.Controls.SetChildIndex(Me.LabelGreeting, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxOperatorAvatar, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxToolbox, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxShutdown, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOperatorAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxToolbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxShutdown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelOperatorName As Label
    Friend WithEvents LabelGreeting As Label
    Friend WithEvents PictureBoxOperatorAvatar As PictureBox
    Friend WithEvents PictureBoxToolbox As PictureBox
    Friend WithEvents PictureBoxShutdown As PictureBox
End Class
