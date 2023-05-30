<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DesktopClockSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DesktopClockSettings))
        Me.LabelClockLabelLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelTimeZone = New System.Windows.Forms.Label()
        Me.TextBoxClockLabel = New System.Windows.Forms.TextBox()
        Me.CheckBoxSeconds = New System.Windows.Forms.CheckBox()
        Me.ComboBoxUTC = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFormat = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(412, 11)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(4, 14, 14, 5)
        Me.PictureBoxClose.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Enabled = False
        Me.PictureBoxMax.Location = New System.Drawing.Point(412, 48)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(4, 14, 14, 5)
        Me.PictureBoxMax.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Enabled = False
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(412, 84)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(4, 14, 14, 5)
        Me.PictureBoxMinimize.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'LabelClockLabelLabel
        '
        Me.LabelClockLabelLabel.AutoSize = True
        Me.LabelClockLabelLabel.Location = New System.Drawing.Point(16, 89)
        Me.LabelClockLabelLabel.Name = "LabelClockLabelLabel"
        Me.LabelClockLabelLabel.Size = New System.Drawing.Size(91, 20)
        Me.LabelClockLabelLabel.TabIndex = 13
        Me.LabelClockLabelLabel.Text = "Clock Label"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Clock Format"
        '
        'LabelTimeZone
        '
        Me.LabelTimeZone.AutoSize = True
        Me.LabelTimeZone.Location = New System.Drawing.Point(16, 21)
        Me.LabelTimeZone.Name = "LabelTimeZone"
        Me.LabelTimeZone.Size = New System.Drawing.Size(80, 20)
        Me.LabelTimeZone.TabIndex = 11
        Me.LabelTimeZone.Text = "TimeZone"
        '
        'TextBoxClockLabel
        '
        Me.TextBoxClockLabel.Location = New System.Drawing.Point(143, 86)
        Me.TextBoxClockLabel.Name = "TextBoxClockLabel"
        Me.TextBoxClockLabel.Size = New System.Drawing.Size(237, 26)
        Me.TextBoxClockLabel.TabIndex = 10
        '
        'CheckBoxSeconds
        '
        Me.CheckBoxSeconds.AutoSize = True
        Me.CheckBoxSeconds.Enabled = False
        Me.CheckBoxSeconds.Location = New System.Drawing.Point(289, 20)
        Me.CheckBoxSeconds.Name = "CheckBoxSeconds"
        Me.CheckBoxSeconds.Size = New System.Drawing.Size(91, 24)
        Me.CheckBoxSeconds.TabIndex = 9
        Me.CheckBoxSeconds.Text = "Seconds"
        Me.CheckBoxSeconds.UseVisualStyleBackColor = True
        Me.CheckBoxSeconds.Visible = False
        '
        'ComboBoxUTC
        '
        Me.ComboBoxUTC.FormattingEnabled = True
        Me.ComboBoxUTC.Items.AddRange(New Object() {"0", "1", "-1", "2", "-2", "3", "-3", "4", "-4", "5", "-5", "6", "-6", "7", "-7", "8", "-8", "9", "-9", "10", "-10", "11", "-11", "12", "-12", "13", "-13"})
        Me.ComboBoxUTC.Location = New System.Drawing.Point(143, 18)
        Me.ComboBoxUTC.Name = "ComboBoxUTC"
        Me.ComboBoxUTC.Size = New System.Drawing.Size(108, 28)
        Me.ComboBoxUTC.TabIndex = 8
        '
        'ComboBoxFormat
        '
        Me.ComboBoxFormat.FormattingEnabled = True
        Me.ComboBoxFormat.Items.AddRange(New Object() {"HH mm", "HH mm ss", "h mm tt", "hh mm tt", "h mm ss tt", "hh mm ss tt"})
        Me.ComboBoxFormat.Location = New System.Drawing.Point(143, 52)
        Me.ComboBoxFormat.Name = "ComboBoxFormat"
        Me.ComboBoxFormat.Size = New System.Drawing.Size(237, 28)
        Me.ComboBoxFormat.TabIndex = 7
        '
        'DesktopClockSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(445, 129)
        Me.Controls.Add(Me.LabelClockLabelLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelTimeZone)
        Me.Controls.Add(Me.TextBoxClockLabel)
        Me.Controls.Add(Me.CheckBoxSeconds)
        Me.Controls.Add(Me.ComboBoxUTC)
        Me.Controls.Add(Me.ComboBoxFormat)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "DesktopClockSettings"
        Me.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Text = "DesktopClockSettings"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxFormat, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxUTC, 0)
        Me.Controls.SetChildIndex(Me.CheckBoxSeconds, 0)
        Me.Controls.SetChildIndex(Me.TextBoxClockLabel, 0)
        Me.Controls.SetChildIndex(Me.LabelTimeZone, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelClockLabelLabel, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelClockLabelLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelTimeZone As Label
    Friend WithEvents TextBoxClockLabel As TextBox
    Friend WithEvents CheckBoxSeconds As CheckBox
    Friend WithEvents ComboBoxUTC As ComboBox
    Friend WithEvents ComboBoxFormat As ComboBox
End Class
