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
        Me.ListBoxShortcuts = New System.Windows.Forms.ListBox()
        Me.ButtonGo = New Oexl.RoundedButton()
        Me.PictureBoxIcon = New System.Windows.Forms.PictureBox()
        Me.ButtonEditShortcut = New Oexl.RoundedButton()
        Me.ButtonRefreshList = New Oexl.RoundedButton()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(426, 13)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(4, 15, 16, 6)
        Me.PictureBoxClose.Padding = New System.Windows.Forms.Padding(2)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(426, 54)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(4, 15, 16, 6)
        Me.PictureBoxMax.Padding = New System.Windows.Forms.Padding(2)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(426, 94)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(4, 15, 16, 6)
        Me.PictureBoxMinimize.Padding = New System.Windows.Forms.Padding(2)
        '
        'ListBoxShortcuts
        '
        Me.ListBoxShortcuts.AllowDrop = True
        Me.ListBoxShortcuts.FormattingEnabled = True
        Me.ListBoxShortcuts.ItemHeight = 22
        Me.ListBoxShortcuts.Location = New System.Drawing.Point(31, 32)
        Me.ListBoxShortcuts.Name = "ListBoxShortcuts"
        Me.ListBoxShortcuts.Size = New System.Drawing.Size(345, 708)
        Me.ListBoxShortcuts.TabIndex = 3
        '
        'ButtonGo
        '
        Me.ButtonGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonGo.Location = New System.Drawing.Point(383, 678)
        Me.ButtonGo.Name = "ButtonGo"
        Me.ButtonGo.Size = New System.Drawing.Size(66, 63)
        Me.ButtonGo.TabIndex = 10
        Me.ButtonGo.Text = "GO"
        Me.ButtonGo.UseVisualStyleBackColor = False
        '
        'PictureBoxIcon
        '
        Me.PictureBoxIcon.Location = New System.Drawing.Point(383, 346)
        Me.PictureBoxIcon.Name = "PictureBoxIcon"
        Me.PictureBoxIcon.Size = New System.Drawing.Size(66, 55)
        Me.PictureBoxIcon.TabIndex = 11
        Me.PictureBoxIcon.TabStop = False
        '
        'ButtonEditShortcut
        '
        Me.ButtonEditShortcut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEditShortcut.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonEditShortcut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditShortcut.Location = New System.Drawing.Point(383, 609)
        Me.ButtonEditShortcut.Name = "ButtonEditShortcut"
        Me.ButtonEditShortcut.Size = New System.Drawing.Size(66, 63)
        Me.ButtonEditShortcut.TabIndex = 12
        Me.ButtonEditShortcut.Text = "✏"
        Me.ButtonEditShortcut.UseVisualStyleBackColor = False
        '
        'ButtonRefreshList
        '
        Me.ButtonRefreshList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRefreshList.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonRefreshList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRefreshList.Location = New System.Drawing.Point(383, 540)
        Me.ButtonRefreshList.Name = "ButtonRefreshList"
        Me.ButtonRefreshList.Size = New System.Drawing.Size(66, 63)
        Me.ButtonRefreshList.TabIndex = 13
        Me.ButtonRefreshList.Text = "🔃"
        Me.ButtonRefreshList.UseVisualStyleBackColor = False
        '
        'Shortcuts
        '
        Me.AcceptButton = Me.ButtonGo
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 773)
        Me.Controls.Add(Me.ButtonRefreshList)
        Me.Controls.Add(Me.ButtonEditShortcut)
        Me.Controls.Add(Me.PictureBoxIcon)
        Me.Controls.Add(Me.ButtonGo)
        Me.Controls.Add(Me.ListBoxShortcuts)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.Name = "Shortcuts"
        Me.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Text = "Shortcuts"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.ListBoxShortcuts, 0)
        Me.Controls.SetChildIndex(Me.ButtonGo, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxIcon, 0)
        Me.Controls.SetChildIndex(Me.ButtonEditShortcut, 0)
        Me.Controls.SetChildIndex(Me.ButtonRefreshList, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxShortcuts As ListBox
    Friend WithEvents ButtonGo As RoundedButton
    Friend WithEvents PictureBoxIcon As PictureBox
    Friend WithEvents ButtonEditShortcut As RoundedButton
    Friend WithEvents ButtonRefreshList As RoundedButton
End Class
