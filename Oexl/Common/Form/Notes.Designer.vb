<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notes))
        Me.ListBoxNotes = New System.Windows.Forms.ListBox()
        Me.TextBoxNotes = New System.Windows.Forms.RichTextBox()
        Me.ButtonOpenNotesFolder = New Oexl.RoundedButton()
        Me.ButtonTakeNote = New Oexl.RoundedButton()
        Me.ImmatatoButton = New Oexl.RoundedButton()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(940, 18)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(940, 50)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(940, 82)
        '
        'ListBoxNotes
        '
        Me.ListBoxNotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListBoxNotes.FormattingEnabled = True
        Me.ListBoxNotes.ItemHeight = 20
        Me.ListBoxNotes.Location = New System.Drawing.Point(18, 15)
        Me.ListBoxNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBoxNotes.Name = "ListBoxNotes"
        Me.ListBoxNotes.Size = New System.Drawing.Size(212, 644)
        Me.ListBoxNotes.TabIndex = 0
        '
        'TextBoxNotes
        '
        Me.TextBoxNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNotes.Location = New System.Drawing.Point(257, 81)
        Me.TextBoxNotes.Name = "TextBoxNotes"
        Me.TextBoxNotes.Size = New System.Drawing.Size(652, 578)
        Me.TextBoxNotes.TabIndex = 3
        Me.TextBoxNotes.Text = ""
        '
        'ButtonOpenNotesFolder
        '
        Me.ButtonOpenNotesFolder.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonOpenNotesFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonOpenNotesFolder.Location = New System.Drawing.Point(803, 14)
        Me.ButtonOpenNotesFolder.Name = "ButtonOpenNotesFolder"
        Me.ButtonOpenNotesFolder.Size = New System.Drawing.Size(106, 57)
        Me.ButtonOpenNotesFolder.TabIndex = 4
        Me.ButtonOpenNotesFolder.Text = "Open Folder"
        Me.ButtonOpenNotesFolder.UseVisualStyleBackColor = False
        '
        'ButtonTakeNote
        '
        Me.ButtonTakeNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonTakeNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTakeNote.Location = New System.Drawing.Point(257, 15)
        Me.ButtonTakeNote.Name = "ButtonTakeNote"
        Me.ButtonTakeNote.Size = New System.Drawing.Size(106, 57)
        Me.ButtonTakeNote.TabIndex = 5
        Me.ButtonTakeNote.Text = "Take Note"
        Me.ButtonTakeNote.UseVisualStyleBackColor = False
        '
        'ImmatatoButton
        '
        Me.ImmatatoButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ImmatatoButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImmatatoButton.Location = New System.Drawing.Point(643, 14)
        Me.ImmatatoButton.Name = "ImmatatoButton"
        Me.ImmatatoButton.Size = New System.Drawing.Size(106, 57)
        Me.ImmatatoButton.TabIndex = 6
        Me.ImmatatoButton.Text = "IMm-ATATO OPEN"
        Me.ImmatatoButton.UseVisualStyleBackColor = False
        '
        'Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 671)
        Me.Controls.Add(Me.ImmatatoButton)
        Me.Controls.Add(Me.ButtonTakeNote)
        Me.Controls.Add(Me.ButtonOpenNotesFolder)
        Me.Controls.Add(Me.TextBoxNotes)
        Me.Controls.Add(Me.ListBoxNotes)
        Me.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "Notes"
        Me.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Text = "Notes"
        Me.Controls.SetChildIndex(Me.ListBoxNotes, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNotes, 0)
        Me.Controls.SetChildIndex(Me.ButtonOpenNotesFolder, 0)
        Me.Controls.SetChildIndex(Me.ButtonTakeNote, 0)
        Me.Controls.SetChildIndex(Me.ImmatatoButton, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxNotes As ListBox
    Friend WithEvents TextBoxNotes As RichTextBox
    Friend WithEvents ButtonOpenNotesFolder As RoundedButton
    Friend WithEvents ButtonTakeNote As RoundedButton
    Friend WithEvents ImmatatoButton As RoundedButton
End Class
