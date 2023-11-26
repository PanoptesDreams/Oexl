<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoteTaker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NoteTaker))
        Me.TextBoxNoteTitle = New System.Windows.Forms.TextBox()
        Me.TextBoxNoteBody = New System.Windows.Forms.RichTextBox()
        Me.ButtonSaveNote = New Oexl.RoundedButton()
        Me.PicStatus = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(862, 3)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(862, 30)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(862, 56)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'TextBoxNoteTitle
        '
        Me.TextBoxNoteTitle.Location = New System.Drawing.Point(18, 18)
        Me.TextBoxNoteTitle.Name = "TextBoxNoteTitle"
        Me.TextBoxNoteTitle.Size = New System.Drawing.Size(736, 28)
        Me.TextBoxNoteTitle.TabIndex = 3
        '
        'TextBoxNoteBody
        '
        Me.TextBoxNoteBody.Location = New System.Drawing.Point(18, 56)
        Me.TextBoxNoteBody.Name = "TextBoxNoteBody"
        Me.TextBoxNoteBody.Size = New System.Drawing.Size(825, 393)
        Me.TextBoxNoteBody.TabIndex = 4
        Me.TextBoxNoteBody.Text = ""
        '
        'ButtonSaveNote
        '
        Me.ButtonSaveNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonSaveNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonSaveNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSaveNote.Location = New System.Drawing.Point(18, 484)
        Me.ButtonSaveNote.Name = "ButtonSaveNote"
        Me.ButtonSaveNote.Size = New System.Drawing.Size(118, 63)
        Me.ButtonSaveNote.TabIndex = 7
        Me.ButtonSaveNote.Text = "Save Note"
        Me.ButtonSaveNote.UseVisualStyleBackColor = False
        '
        'PicStatus
        '
        Me.PicStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PicStatus.Location = New System.Drawing.Point(142, 484)
        Me.PicStatus.Name = "PicStatus"
        Me.PicStatus.Size = New System.Drawing.Size(66, 63)
        Me.PicStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicStatus.TabIndex = 8
        Me.PicStatus.TabStop = False
        '
        'NoteTaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 557)
        Me.Controls.Add(Me.PicStatus)
        Me.Controls.Add(Me.ButtonSaveNote)
        Me.Controls.Add(Me.TextBoxNoteBody)
        Me.Controls.Add(Me.TextBoxNoteTitle)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "NoteTaker"
        Me.Padding = New System.Windows.Forms.Padding(14, 14, 14, 14)
        Me.Text = "NoteTaker"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNoteTitle, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNoteBody, 0)
        Me.Controls.SetChildIndex(Me.ButtonSaveNote, 0)
        Me.Controls.SetChildIndex(Me.PicStatus, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNoteTitle As TextBox
    Friend WithEvents TextBoxNoteBody As RichTextBox
    Friend WithEvents ButtonSaveNote As RoundedButton
    Friend WithEvents PicStatus As PictureBox
End Class
