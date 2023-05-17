<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WingetInstaller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WingetInstaller))
        Me.ComboBoxApps = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonExecute = New System.Windows.Forms.Button()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(369, 3)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(369, 24)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(369, 45)
        '
        'ComboBoxApps
        '
        Me.ComboBoxApps.FormattingEnabled = True
        Me.ComboBoxApps.Location = New System.Drawing.Point(6, 6)
        Me.ComboBoxApps.Name = "ComboBoxApps"
        Me.ComboBoxApps.Size = New System.Drawing.Size(282, 28)
        Me.ComboBoxApps.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(282, 251)
        Me.TextBox1.TabIndex = 4
        '
        'ButtonExecute
        '
        Me.ButtonExecute.Location = New System.Drawing.Point(304, 211)
        Me.ButtonExecute.Name = "ButtonExecute"
        Me.ButtonExecute.Size = New System.Drawing.Size(83, 80)
        Me.ButtonExecute.TabIndex = 5
        Me.ButtonExecute.Text = "Oddish"
        Me.ButtonExecute.UseVisualStyleBackColor = True
        '
        'WingetInstaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 302)
        Me.Controls.Add(Me.ButtonExecute)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBoxApps)
        Me.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WingetInstaller"
        Me.Text = "WingetInstaller"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.ComboBoxApps, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        Me.Controls.SetChildIndex(Me.ButtonExecute, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxApps As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonExecute As Button
End Class
