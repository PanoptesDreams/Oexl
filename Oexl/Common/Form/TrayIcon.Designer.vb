<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrayIcon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TrayIcon))
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrayMenuLauncher = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrayMenuDestopClock = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenuShortcuts = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenuToolbox = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenuSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TrayMenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayCommon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrayMenu
        '
        Me.TrayMenu.BackColor = System.Drawing.SystemColors.Control
        Me.TrayMenu.DropShadowEnabled = False
        Me.TrayMenu.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrayMenu.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrayMenuLauncher, Me.TrayMenuSeparator1, Me.TrayMenuDestopClock, Me.TrayMenuShortcuts, Me.TrayMenuToolbox, Me.TrayMenuSeparator2, Me.TrayMenuExit})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(188, 168)
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
        'TrayMenuShortcuts
        '
        Me.TrayMenuShortcuts.Name = "TrayMenuShortcuts"
        Me.TrayMenuShortcuts.Size = New System.Drawing.Size(187, 26)
        Me.TrayMenuShortcuts.Tag = "shortcut"
        Me.TrayMenuShortcuts.Text = "Shortcut"
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
        Me.TrayMenuExit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem})
        Me.TrayMenuExit.Name = "TrayMenuExit"
        Me.TrayMenuExit.Size = New System.Drawing.Size(187, 26)
        Me.TrayMenuExit.Text = "Exit"
        '
        'TrayCommon
        '
        Me.TrayCommon.ContextMenuStrip = Me.TrayMenu
        Me.TrayCommon.Icon = CType(resources.GetObject("TrayCommon.Icon"), System.Drawing.Icon)
        Me.TrayCommon.Text = "OEXL"
        Me.TrayCommon.Visible = True
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'TrayIcon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(562, 450)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TrayIcon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "I'm A Spooky Ghost"
        Me.TransparencyKey = System.Drawing.Color.Black
        Me.TrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents TrayMenu As ContextMenuStrip
    Friend WithEvents TrayMenuLauncher As ToolStripMenuItem
    Friend WithEvents TrayMenuSeparator1 As ToolStripSeparator
    Friend WithEvents TrayMenuDestopClock As ToolStripMenuItem
    Friend WithEvents TrayMenuShortcuts As ToolStripMenuItem
    Friend WithEvents TrayMenuToolbox As ToolStripMenuItem
    Friend WithEvents TrayMenuSeparator2 As ToolStripSeparator
    Friend WithEvents TrayMenuExit As ToolStripMenuItem
    Friend WithEvents TrayCommon As NotifyIcon
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
End Class
