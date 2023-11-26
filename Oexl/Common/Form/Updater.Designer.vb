<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updater
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updater))
        Me.LabelCurrentVersion = New System.Windows.Forms.Label()
        Me.LabelVersionAlert = New System.Windows.Forms.Label()
        Me.LabelWebVersion = New System.Windows.Forms.Label()
        Me.ButtonFetchUpdate = New Oexl.RoundedButton()
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
        'LabelCurrentVersion
        '
        Me.LabelCurrentVersion.AutoSize = True
        Me.LabelCurrentVersion.Location = New System.Drawing.Point(323, 51)
        Me.LabelCurrentVersion.Name = "LabelCurrentVersion"
        Me.LabelCurrentVersion.Size = New System.Drawing.Size(152, 22)
        Me.LabelCurrentVersion.TabIndex = 4
        Me.LabelCurrentVersion.Text = "Current Version - "
        '
        'LabelVersionAlert
        '
        Me.LabelVersionAlert.AutoSize = True
        Me.LabelVersionAlert.Location = New System.Drawing.Point(323, 93)
        Me.LabelVersionAlert.Name = "LabelVersionAlert"
        Me.LabelVersionAlert.Size = New System.Drawing.Size(35, 22)
        Me.LabelVersionAlert.TabIndex = 5
        Me.LabelVersionAlert.Text = ". . ."
        '
        'LabelWebVersion
        '
        Me.LabelWebVersion.AutoSize = True
        Me.LabelWebVersion.Location = New System.Drawing.Point(323, 135)
        Me.LabelWebVersion.Name = "LabelWebVersion"
        Me.LabelWebVersion.Size = New System.Drawing.Size(129, 22)
        Me.LabelWebVersion.TabIndex = 6
        Me.LabelWebVersion.Text = "Web Version - "
        '
        'ButtonFetchUpdate
        '
        Me.ButtonFetchUpdate.Enabled = False
        Me.ButtonFetchUpdate.Location = New System.Drawing.Point(61, 51)
        Me.ButtonFetchUpdate.Name = "ButtonFetchUpdate"
        Me.ButtonFetchUpdate.Size = New System.Drawing.Size(229, 106)
        Me.ButtonFetchUpdate.TabIndex = 3
        Me.ButtonFetchUpdate.Text = "Fetch Update"
        Me.ButtonFetchUpdate.UseVisualStyleBackColor = True
        '
        'Updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 197)
        Me.Controls.Add(Me.LabelWebVersion)
        Me.Controls.Add(Me.LabelVersionAlert)
        Me.Controls.Add(Me.LabelCurrentVersion)
        Me.Controls.Add(Me.ButtonFetchUpdate)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Updater"
        Me.Text = "Updater"
        Me.Controls.SetChildIndex(Me.ButtonFetchUpdate, 0)
        Me.Controls.SetChildIndex(Me.LabelCurrentVersion, 0)
        Me.Controls.SetChildIndex(Me.LabelVersionAlert, 0)
        Me.Controls.SetChildIndex(Me.LabelWebVersion, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelCurrentVersion As Label
    Friend WithEvents LabelVersionAlert As Label
    Friend WithEvents LabelWebVersion As Label
    Friend WithEvents ButtonFetchUpdate As RoundedButton
End Class
