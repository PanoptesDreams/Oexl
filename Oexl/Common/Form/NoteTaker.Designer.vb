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
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(776, 3)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(776, 27)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(776, 51)
        '
        'TextBoxNoteTitle
        '
        Me.TextBoxNoteTitle.Location = New System.Drawing.Point(16, 16)
        Me.TextBoxNoteTitle.Name = "TextBoxNoteTitle"
        Me.TextBoxNoteTitle.Size = New System.Drawing.Size(663, 26)
        Me.TextBoxNoteTitle.TabIndex = 3
        '
        'TextBoxNoteBody
        '
        Me.TextBoxNoteBody.Location = New System.Drawing.Point(16, 76)
        Me.TextBoxNoteBody.Name = "TextBoxNoteBody"
        Me.TextBoxNoteBody.Size = New System.Drawing.Size(743, 358)
        Me.TextBoxNoteBody.TabIndex = 4
        Me.TextBoxNoteBody.Text = ""
        '
        'ButtonSaveNote
        '
        Me.ButtonSaveNote.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonSaveNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSaveNote.Location = New System.Drawing.Point(16, 440)
        Me.ButtonSaveNote.Name = "ButtonSaveNote"
        Me.ButtonSaveNote.Size = New System.Drawing.Size(106, 57)
        Me.ButtonSaveNote.TabIndex = 7
        Me.ButtonSaveNote.Text = "Save Note"
        Me.ButtonSaveNote.UseVisualStyleBackColor = False
        '
        'NoteTaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 506)
        Me.Controls.Add(Me.ButtonSaveNote)
        Me.Controls.Add(Me.TextBoxNoteBody)
        Me.Controls.Add(Me.TextBoxNoteTitle)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NoteTaker"
        Me.Text = "NoteTaker"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNoteTitle, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNoteBody, 0)
        Me.Controls.SetChildIndex(Me.ButtonSaveNote, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNoteTitle As TextBox
    Friend WithEvents TextBoxNoteBody As RichTextBox
    Friend WithEvents ButtonSaveNote As RoundedButton
End Class
