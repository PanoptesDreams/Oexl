<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shortcuts
    Inherits RoundedForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Shortcuts))
        Me.ButtonGo = New Oexl.RoundedButton()
        Me.PictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.ButtonEditShortcut = New Oexl.RoundedButton()
        Me.ButtonRefreshList = New Oexl.RoundedButton()
        Me.ButtonDeleteShortcut = New Oexl.RoundedButton()
        Me.ListBoxShortcuts = New Oexl.HartListBox()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(400, 13)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(4, 15, 14, 5)
        Me.PictureBoxClose.Padding = New System.Windows.Forms.Padding(2)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(400, 51)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(4, 15, 14, 5)
        Me.PictureBoxMax.Padding = New System.Windows.Forms.Padding(2)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(400, 89)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(4, 15, 14, 5)
        Me.PictureBoxMinimize.Padding = New System.Windows.Forms.Padding(2)
        '
        'ButtonGo
        '
        Me.ButtonGo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGo.Location = New System.Drawing.Point(170, 30)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(59, 62)
        Me.ButtonGo.TabIndex = 10
        Me.ButtonGo.Text = "GO"
        Me.ButtonGo.UseVisualStyleBackColor = False
        '
        'PictureBoxIcon
        '
        Me.PictureBoxIcon.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxIcon.Location = New System.Drawing.Point(7, 30)
        Me.PictureBoxIcon.Name = "PictureBoxIcon"
        Me.PictureBoxIcon.Size = New System.Drawing.Size(59, 62)
        Me.PictureBoxIcon.TabIndex = 11
        Me.PictureBoxIcon.TabStop = False
        '
        'ButtonEditShortcut
        '
        Me.ButtonEditShortcut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonEditShortcut.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonEditShortcut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditShortcut.Location = New System.Drawing.Point(254, 30)
        Me.ButtonEditShortcut.Name = "ButtonEditShortcut"
        Me.ButtonEditShortcut.Size = New System.Drawing.Size(59, 62)
        Me.ButtonEditShortcut.TabIndex = 12
        Me.ButtonEditShortcut.Text = "✏"
        Me.ButtonEditShortcut.UseVisualStyleBackColor = False
        '
        'ButtonRefreshList
        '
        Me.ButtonRefreshList.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonRefreshList.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonRefreshList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRefreshList.Location = New System.Drawing.Point(91, 30)
        Me.ButtonRefreshList.Name = "ButtonRefreshList"
        Me.ButtonRefreshList.Size = New System.Drawing.Size(59, 62)
        Me.ButtonRefreshList.TabIndex = 13
        Me.ButtonRefreshList.Text = "🔃"
        Me.ButtonRefreshList.UseVisualStyleBackColor = False
        '
        'ButtonDeleteShortcut
        '
        Me.ButtonDeleteShortcut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ButtonDeleteShortcut.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonDeleteShortcut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeleteShortcut.Location = New System.Drawing.Point(319, 30)
        Me.ButtonDeleteShortcut.Name = "ButtonDeleteShortcut"
        Me.ButtonDeleteShortcut.Size = New System.Drawing.Size(59, 62)
        Me.ButtonDeleteShortcut.TabIndex = 14
        Me.ButtonDeleteShortcut.Text = "☠"
        Me.ButtonDeleteShortcut.UseVisualStyleBackColor = False
        '
        'ListBoxShortcuts
        '
        Me.ListBoxShortcuts.AllowDrop = True
        Me.ListBoxShortcuts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBoxShortcuts.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ListBoxShortcuts.FormattingEnabled = True
        Me.ListBoxShortcuts.ItemHeight = 30
        Me.ListBoxShortcuts.Items.AddRange(New Object() {"UwU"})
        Me.ListBoxShortcuts.Location = New System.Drawing.Point(7, 120)
        Me.ListBoxShortcuts.Name = "ListBoxShortcuts"
        Me.ListBoxShortcuts.Size = New System.Drawing.Size(414, 604)
        Me.ListBoxShortcuts.TabIndex = 15
        '
        'Shortcuts
        '
        Me.AcceptButton = Me.ButtonGo
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 741)
        Me.Controls.Add(Me.ListBoxShortcuts)
        Me.Controls.Add(Me.ButtonDeleteShortcut)
        Me.Controls.Add(Me.ButtonRefreshList)
        Me.Controls.Add(Me.ButtonEditShortcut)
        Me.Controls.Add(Me.PictureBoxIcon)
        Me.Controls.Add(Me.ButtonGo)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "Shortcuts"
        Me.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Text = "Shortcuts"
        Me.Controls.SetChildIndex(Me.ButtonGo, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxIcon, 0)
        Me.Controls.SetChildIndex(Me.ButtonEditShortcut, 0)
        Me.Controls.SetChildIndex(Me.ButtonRefreshList, 0)
        Me.Controls.SetChildIndex(Me.ButtonDeleteShortcut, 0)
        Me.Controls.SetChildIndex(Me.ListBoxShortcuts, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonGo As RoundedButton
    Friend WithEvents PictureBoxIcon As PictureBox
    Friend WithEvents ButtonEditShortcut As RoundedButton
    Friend WithEvents ButtonRefreshList As RoundedButton
    Friend WithEvents ButtonDeleteShortcut As RoundedButton
    Friend WithEvents ListBoxShortcuts As HartListBox
End Class
