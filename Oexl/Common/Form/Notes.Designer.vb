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
        Me.ListBoxNotes.Location = New System.Drawing.Point(18, 18)
        Me.ListBoxNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListBoxNotes.Name = "ListBoxNotes"
        Me.ListBoxNotes.Size = New System.Drawing.Size(212, 604)
        Me.ListBoxNotes.TabIndex = 0
        '
        'TextBoxNotes
        '
        Me.TextBoxNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNotes.Location = New System.Drawing.Point(268, 63)
        Me.TextBoxNotes.Name = "TextBoxNotes"
        Me.TextBoxNotes.Size = New System.Drawing.Size(652, 559)
        Me.TextBoxNotes.TabIndex = 3
        Me.TextBoxNotes.Text = ""
        '
        'Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 652)
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
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxNotes As ListBox
    Friend WithEvents TextBoxNotes As RichTextBox
End Class
