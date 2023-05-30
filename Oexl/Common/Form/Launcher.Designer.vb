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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.LabelOperatorName = New System.Windows.Forms.Label()
        Me.LabelGreeting = New System.Windows.Forms.Label()
        Me.PictureBoxOperator = New System.Windows.Forms.PictureBox()
        Me.PictureBoxToolbox = New System.Windows.Forms.PictureBox()
        Me.LabelArgs = New System.Windows.Forms.Label()
        Me.TrayCommon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrayMenuLauncher = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrayMenuDestopClock = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenuToolbox = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenuSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrayMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOperator, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxToolbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(694, 3)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(694, 21)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(694, 39)
        '
        'LabelOperatorName
        '
        Me.LabelOperatorName.AutoSize = True
        Me.LabelOperatorName.Location = New System.Drawing.Point(7, 39)
        Me.LabelOperatorName.Name = "LabelOperatorName"
        Me.LabelOperatorName.Size = New System.Drawing.Size(114, 20)
        Me.LabelOperatorName.TabIndex = 1
        Me.LabelOperatorName.Text = "OperatorName"
        '
        'LabelGreeting
        '
        Me.LabelGreeting.AutoSize = True
        Me.LabelGreeting.Location = New System.Drawing.Point(7, 19)
        Me.LabelGreeting.Name = "LabelGreeting"
        Me.LabelGreeting.Size = New System.Drawing.Size(71, 20)
        Me.LabelGreeting.TabIndex = 2
        Me.LabelGreeting.Text = "Greeting"
        '
        'PictureBoxOperator
        '
        Me.PictureBoxOperator.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxOperator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxOperator.Location = New System.Drawing.Point(318, 13)
        Me.PictureBoxOperator.Name = "PictureBoxOperator"
        Me.PictureBoxOperator.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxOperator.TabIndex = 3
        Me.PictureBoxOperator.TabStop = False
        '
        'PictureBoxToolbox
        '
        Me.PictureBoxToolbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxToolbox.BackgroundImage = Global.Oexl.My.Resources.Resources.max
        Me.PictureBoxToolbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxToolbox.Location = New System.Drawing.Point(374, 13)
        Me.PictureBoxToolbox.Name = "PictureBoxToolbox"
        Me.PictureBoxToolbox.Size = New System.Drawing.Size(50, 50)
        Me.PictureBoxToolbox.TabIndex = 4
        Me.PictureBoxToolbox.TabStop = False
        '
        'LabelArgs
        '
        Me.LabelArgs.AutoSize = True
        Me.LabelArgs.Location = New System.Drawing.Point(444, 19)
        Me.LabelArgs.Name = "LabelArgs"
        Me.LabelArgs.Size = New System.Drawing.Size(71, 20)
        Me.LabelArgs.TabIndex = 5
        Me.LabelArgs.Text = "Greeting"
        '
        'TrayCommon
        '
        Me.TrayCommon.ContextMenuStrip = Me.TrayMenu
        Me.TrayCommon.Icon = CType(resources.GetObject("TrayCommon.Icon"), System.Drawing.Icon)
        Me.TrayCommon.Text = "Oh My GAASSHHH"
        Me.TrayCommon.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.BackColor = System.Drawing.SystemColors.Control
        Me.TrayMenu.DropShadowEnabled = False
        Me.TrayMenu.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrayMenuLauncher, Me.TrayMenuSeparator1, Me.TrayMenuDestopClock, Me.TrayMenuToolbox, Me.TrayMenuSeparator2, Me.TrayMenuExit})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(188, 142)
        '
        'TrayMenuLauncher
        '
        Me.TrayMenuLauncher.Name = "TrayMenuLauncher"
        Me.TrayMenuLauncher.Size = New System.Drawing.Size(187, 26)
        Me.TrayMenuLauncher.Text = "Show Launcher"
        '
        'TrayMenuSeparator1
        '
        Me.TrayMenuSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TrayMenuSeparator1.Name = "TrayMenuSeparator1"
        Me.TrayMenuSeparator1.Size = New System.Drawing.Size(184, 6)
        '
        'TrayMenuDestopClock
        '
        Me.TrayMenuDestopClock.Name = "TrayMenuDestopClock"
        Me.TrayMenuDestopClock.Size = New System.Drawing.Size(187, 26)
        Me.TrayMenuDestopClock.Text = "Desktop Clock"
        '
        'TrayMenuToolbox
        '
        Me.TrayMenuToolbox.Name = "TrayMenuToolbox"
        Me.TrayMenuToolbox.Size = New System.Drawing.Size(187, 26)
        Me.TrayMenuToolbox.Text = "Toolbox"
        '
        'TrayMenuSeparator2
        '
        Me.TrayMenuSeparator2.Name = "TrayMenuSeparator2"
        Me.TrayMenuSeparator2.Size = New System.Drawing.Size(184, 6)
        '
        'TrayMenuExit
        '
        Me.TrayMenuExit.Name = "TrayMenuExit"
        Me.TrayMenuExit.Size = New System.Drawing.Size(187, 26)
        Me.TrayMenuExit.Text = "Exit"
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 77)
        Me.Controls.Add(Me.LabelArgs)
        Me.Controls.Add(Me.PictureBoxToolbox)
        Me.Controls.Add(Me.PictureBoxOperator)
        Me.Controls.Add(Me.LabelGreeting)
        Me.Controls.Add(Me.LabelOperatorName)
        Me.ForeColor = System.Drawing.Color.Purple
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.MaximumSize = New System.Drawing.Size(1080, 77)
        Me.Name = "Launcher"
        Me.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Text = "Launcher"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.LabelOperatorName, 0)
        Me.Controls.SetChildIndex(Me.LabelGreeting, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxOperator, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxToolbox, 0)
        Me.Controls.SetChildIndex(Me.LabelArgs, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOperator, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxToolbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelOperatorName As Label
    Friend WithEvents LabelGreeting As Label
    Friend WithEvents PictureBoxOperator As PictureBox
    Friend WithEvents PictureBoxToolbox As PictureBox
    Friend WithEvents LabelArgs As Label
    Friend WithEvents TrayCommon As NotifyIcon
    Friend WithEvents TrayMenu As ContextMenuStrip
    Friend WithEvents TrayMenuLauncher As ToolStripMenuItem
    Friend WithEvents TrayMenuSeparator1 As ToolStripSeparator
    Friend WithEvents TrayMenuDestopClock As ToolStripMenuItem
    Friend WithEvents TrayMenuToolbox As ToolStripMenuItem
    Friend WithEvents TrayMenuSeparator2 As ToolStripSeparator
    Friend WithEvents TrayMenuExit As ToolStripMenuItem
End Class
