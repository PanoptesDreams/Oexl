﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Launcher
    Inherits RoundedForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.LabelOperatorName = New System.Windows.Forms.Label()
        Me.LabelGreeting = New System.Windows.Forms.Label()
        Me.PictureBoxOperatorAvatar = New System.Windows.Forms.PictureBox()
        Me.PictureBoxToolbox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOperatorAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxToolbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(771, 3)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(771, 23)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(771, 43)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'LabelOperatorName
        '
        Me.LabelOperatorName.AutoSize = True
        Me.LabelOperatorName.Location = New System.Drawing.Point(8, 43)
        Me.LabelOperatorName.Name = "LabelOperatorName"
        Me.LabelOperatorName.Size = New System.Drawing.Size(128, 22)
        Me.LabelOperatorName.TabIndex = 1
        Me.LabelOperatorName.Text = "OperatorName"
        '
        'LabelGreeting
        '
        Me.LabelGreeting.AutoSize = True
        Me.LabelGreeting.Location = New System.Drawing.Point(8, 21)
        Me.LabelGreeting.Name = "LabelGreeting"
        Me.LabelGreeting.Size = New System.Drawing.Size(79, 22)
        Me.LabelGreeting.TabIndex = 2
        Me.LabelGreeting.Text = "Greeting"
        '
        'PictureBoxOperatorAvatar
        '
        Me.PictureBoxOperatorAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxOperatorAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxOperatorAvatar.Location = New System.Drawing.Point(339, 14)
        Me.PictureBoxOperatorAvatar.Name = "PictureBoxOperatorAvatar"
        Me.PictureBoxOperatorAvatar.Size = New System.Drawing.Size(56, 55)
        Me.PictureBoxOperatorAvatar.TabIndex = 3
        Me.PictureBoxOperatorAvatar.TabStop = False
        '
        'PictureBoxToolbox
        '
        Me.PictureBoxToolbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBoxToolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBoxToolbox.Location = New System.Drawing.Point(277, 14)
        Me.PictureBoxToolbox.Name = "PictureBoxToolbox"
        Me.PictureBoxToolbox.Padding = New System.Windows.Forms.Padding(3)
        Me.PictureBoxToolbox.Size = New System.Drawing.Size(56, 55)
        Me.PictureBoxToolbox.TabIndex = 4
        Me.PictureBoxToolbox.TabStop = False
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 85)
        Me.Controls.Add(Me.PictureBoxToolbox)
        Me.Controls.Add(Me.PictureBoxOperatorAvatar)
        Me.Controls.Add(Me.LabelGreeting)
        Me.Controls.Add(Me.LabelOperatorName)
        Me.ForeColor = System.Drawing.Color.Purple
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.MaximumSize = New System.Drawing.Size(1200, 85)
        Me.Name = "Launcher"
        Me.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Text = "Launcher"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.LabelOperatorName, 0)
        Me.Controls.SetChildIndex(Me.LabelGreeting, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxOperatorAvatar, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxToolbox, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOperatorAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxToolbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelOperatorName As Label
    Friend WithEvents LabelGreeting As Label
    Friend WithEvents PictureBoxOperatorAvatar As PictureBox
    Friend WithEvents PictureBoxToolbox As PictureBox
End Class
