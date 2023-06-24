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
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(122, 5)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(4, 14, 14, 5)
        Me.PictureBoxClose.Padding = New System.Windows.Forms.Padding(2)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(122, 42)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(4, 14, 14, 5)
        Me.PictureBoxMax.Padding = New System.Windows.Forms.Padding(2)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(122, 78)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(4, 14, 14, 5)
        Me.PictureBoxMinimize.Padding = New System.Windows.Forms.Padding(2)
        '
        'ListBoxShortcuts
        '
        Me.ListBoxShortcuts.FormattingEnabled = True
        Me.ListBoxShortcuts.ItemHeight = 20
        Me.ListBoxShortcuts.Location = New System.Drawing.Point(22, 19)
        Me.ListBoxShortcuts.Name = "ListBoxShortcuts"
        Me.ListBoxShortcuts.Size = New System.Drawing.Size(321, 524)
        Me.ListBoxShortcuts.TabIndex = 3
        '
        'Shortcuts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 570)
        Me.Controls.Add(Me.ListBoxShortcuts)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "Shortcuts"
        Me.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Text = "Shortcuts"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.ListBoxShortcuts, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxShortcuts As ListBox
End Class
