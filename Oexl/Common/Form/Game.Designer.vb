<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
    Inherits System.Windows.Forms.Form

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
        Me.ButtonPSXLaunch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonPSXLaunch
        '
        Me.ButtonPSXLaunch.Location = New System.Drawing.Point(65, 60)
        Me.ButtonPSXLaunch.Name = "ButtonPSXLaunch"
        Me.ButtonPSXLaunch.Size = New System.Drawing.Size(148, 99)
        Me.ButtonPSXLaunch.TabIndex = 0
        Me.ButtonPSXLaunch.Text = "PS1"
        Me.ButtonPSXLaunch.UseVisualStyleBackColor = True
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 360)
        Me.Controls.Add(Me.ButtonPSXLaunch)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Game"
        Me.Text = "Game"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonPSXLaunch As Button
End Class
