<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlcoholCalulator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlcoholCalulator))
        Me.TextBoxVolume = New System.Windows.Forms.TextBox()
        Me.TextBoxPercentage = New System.Windows.Forms.TextBox()
        Me.LabelVolume = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelDrinks = New System.Windows.Forms.Label()
        Me.LabelError = New System.Windows.Forms.Label()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(469, 3)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(469, 27)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(469, 51)
        '
        'TextBoxVolume
        '
        Me.TextBoxVolume.Location = New System.Drawing.Point(6, 6)
        Me.TextBoxVolume.Name = "TextBoxVolume"
        Me.TextBoxVolume.Size = New System.Drawing.Size(305, 26)
        Me.TextBoxVolume.TabIndex = 3
        '
        'TextBoxPercentage
        '
        Me.TextBoxPercentage.Location = New System.Drawing.Point(6, 38)
        Me.TextBoxPercentage.Name = "TextBoxPercentage"
        Me.TextBoxPercentage.Size = New System.Drawing.Size(305, 26)
        Me.TextBoxPercentage.TabIndex = 4
        '
        'LabelVolume
        '
        Me.LabelVolume.AutoSize = True
        Me.LabelVolume.Location = New System.Drawing.Point(317, 12)
        Me.LabelVolume.Name = "LabelVolume"
        Me.LabelVolume.Size = New System.Drawing.Size(116, 20)
        Me.LabelVolume.TabIndex = 5
        Me.LabelVolume.Text = "Volume (Litres)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(317, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Percentage"
        '
        'LabelDrinks
        '
        Me.LabelDrinks.AutoSize = True
        Me.LabelDrinks.Location = New System.Drawing.Point(2, 67)
        Me.LabelDrinks.Name = "LabelDrinks"
        Me.LabelDrinks.Size = New System.Drawing.Size(54, 20)
        Me.LabelDrinks.TabIndex = 7
        Me.LabelDrinks.Text = "Drinks"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Location = New System.Drawing.Point(2, 133)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(0, 20)
        Me.LabelError.TabIndex = 8
        '
        'AlcoholCalulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 175)
        Me.Controls.Add(Me.LabelError)
        Me.Controls.Add(Me.LabelDrinks)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelVolume)
        Me.Controls.Add(Me.TextBoxPercentage)
        Me.Controls.Add(Me.TextBoxVolume)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AlcoholCalulator"
        Me.Text = "AlcoholCalulator"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.TextBoxVolume, 0)
        Me.Controls.SetChildIndex(Me.TextBoxPercentage, 0)
        Me.Controls.SetChildIndex(Me.LabelVolume, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabelDrinks, 0)
        Me.Controls.SetChildIndex(Me.LabelError, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxVolume As TextBox
    Friend WithEvents TextBoxPercentage As TextBox
    Friend WithEvents LabelVolume As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelDrinks As Label
    Friend WithEvents LabelError As Label
End Class
