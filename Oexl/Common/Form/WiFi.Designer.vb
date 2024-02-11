<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WiFi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WiFi))
        Me.TextBoxSSID = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(2817, 5)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(4, 14, 14, 5)
        Me.PictureBoxClose.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(2817, 42)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(4, 14, 14, 5)
        Me.PictureBoxMax.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(2817, 78)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(4, 14, 14, 5)
        Me.PictureBoxMinimize.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'TextBoxSSID
        '
        Me.TextBoxSSID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxSSID.Location = New System.Drawing.Point(15, 15)
        Me.TextBoxSSID.Margin = New System.Windows.Forms.Padding(13)
        Me.TextBoxSSID.Name = "TextBoxSSID"
        Me.TextBoxSSID.ReadOnly = True
        Me.TextBoxSSID.Size = New System.Drawing.Size(424, 26)
        Me.TextBoxSSID.TabIndex = 1
        Me.TextBoxSSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxPassword.Location = New System.Drawing.Point(15, 76)
        Me.TextBoxPassword.Margin = New System.Windows.Forms.Padding(13)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.ReadOnly = True
        Me.TextBoxPassword.Size = New System.Drawing.Size(424, 26)
        Me.TextBoxPassword.TabIndex = 2
        Me.TextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WiFi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 117)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxSSID)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "WiFi"
        Me.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Text = "WiFi"
        Me.Controls.SetChildIndex(Me.TextBoxSSID, 0)
        Me.Controls.SetChildIndex(Me.TextBoxPassword, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxSSID As TextBox
    Friend WithEvents TextBoxPassword As TextBox
End Class
