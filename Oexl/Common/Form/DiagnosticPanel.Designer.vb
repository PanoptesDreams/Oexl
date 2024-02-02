<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiagnosticPanel
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
        Me.LabelDiagnosticPosition = New System.Windows.Forms.Label()
        Me.LabelDiagnosticWidth = New System.Windows.Forms.Label()
        Me.LabelDiagnosticHeight = New System.Windows.Forms.Label()
        Me.LabelDiagnosticHeightResult = New System.Windows.Forms.Label()
        Me.LabelDiagnosticWidthResult = New System.Windows.Forms.Label()
        Me.LabelDiagnosticPositionResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelDiagnosticPosition
        '
        Me.LabelDiagnosticPosition.AutoSize = True
        Me.LabelDiagnosticPosition.Location = New System.Drawing.Point(27, 35)
        Me.LabelDiagnosticPosition.Name = "LabelDiagnosticPosition"
        Me.LabelDiagnosticPosition.Size = New System.Drawing.Size(166, 15)
        Me.LabelDiagnosticPosition.TabIndex = 0
        Me.LabelDiagnosticPosition.Text = "LabelDiagnosticPosition.Text"
        Me.LabelDiagnosticPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDiagnosticWidth
        '
        Me.LabelDiagnosticWidth.AutoSize = True
        Me.LabelDiagnosticWidth.Location = New System.Drawing.Point(40, 82)
        Me.LabelDiagnosticWidth.Name = "LabelDiagnosticWidth"
        Me.LabelDiagnosticWidth.Size = New System.Drawing.Size(153, 15)
        Me.LabelDiagnosticWidth.TabIndex = 1
        Me.LabelDiagnosticWidth.Text = "LabelDiagnosticWidth.Text"
        Me.LabelDiagnosticWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDiagnosticHeight
        '
        Me.LabelDiagnosticHeight.AutoSize = True
        Me.LabelDiagnosticHeight.Location = New System.Drawing.Point(35, 123)
        Me.LabelDiagnosticHeight.Name = "LabelDiagnosticHeight"
        Me.LabelDiagnosticHeight.Size = New System.Drawing.Size(158, 15)
        Me.LabelDiagnosticHeight.TabIndex = 2
        Me.LabelDiagnosticHeight.Text = "LabelDiagnosticHeight.Text"
        Me.LabelDiagnosticHeight.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelDiagnosticHeightResult
        '
        Me.LabelDiagnosticHeightResult.AutoSize = True
        Me.LabelDiagnosticHeightResult.Location = New System.Drawing.Point(199, 123)
        Me.LabelDiagnosticHeightResult.Name = "LabelDiagnosticHeightResult"
        Me.LabelDiagnosticHeightResult.Size = New System.Drawing.Size(193, 15)
        Me.LabelDiagnosticHeightResult.TabIndex = 5
        Me.LabelDiagnosticHeightResult.Text = "LabelDiagnosticHeightResult.Text"
        Me.LabelDiagnosticHeightResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDiagnosticWidthResult
        '
        Me.LabelDiagnosticWidthResult.AutoSize = True
        Me.LabelDiagnosticWidthResult.Location = New System.Drawing.Point(199, 82)
        Me.LabelDiagnosticWidthResult.Name = "LabelDiagnosticWidthResult"
        Me.LabelDiagnosticWidthResult.Size = New System.Drawing.Size(188, 15)
        Me.LabelDiagnosticWidthResult.TabIndex = 4
        Me.LabelDiagnosticWidthResult.Text = "LabelDiagnosticWidthResult.Text"
        Me.LabelDiagnosticWidthResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelDiagnosticPositionResult
        '
        Me.LabelDiagnosticPositionResult.AutoSize = True
        Me.LabelDiagnosticPositionResult.Location = New System.Drawing.Point(199, 35)
        Me.LabelDiagnosticPositionResult.Name = "LabelDiagnosticPositionResult"
        Me.LabelDiagnosticPositionResult.Size = New System.Drawing.Size(201, 15)
        Me.LabelDiagnosticPositionResult.TabIndex = 3
        Me.LabelDiagnosticPositionResult.Text = "LabelDiagnosticPositionResult.Text"
        Me.LabelDiagnosticPositionResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiagnosticPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 215)
        Me.Controls.Add(Me.LabelDiagnosticHeightResult)
        Me.Controls.Add(Me.LabelDiagnosticWidthResult)
        Me.Controls.Add(Me.LabelDiagnosticPositionResult)
        Me.Controls.Add(Me.LabelDiagnosticHeight)
        Me.Controls.Add(Me.LabelDiagnosticWidth)
        Me.Controls.Add(Me.LabelDiagnosticPosition)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DiagnosticPanel"
        Me.Text = "DiagnosticPanel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelDiagnosticPosition As Label
    Friend WithEvents LabelDiagnosticWidth As Label
    Friend WithEvents LabelDiagnosticHeight As Label
    Friend WithEvents LabelDiagnosticHeightResult As Label
    Friend WithEvents LabelDiagnosticWidthResult As Label
    Friend WithEvents LabelDiagnosticPositionResult As Label
End Class
