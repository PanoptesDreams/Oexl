<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RoundedForm
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoundedForm))
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMax = New System.Windows.Forms.PictureBox()
        Me.PictureBoxMinimize = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxClose.BackgroundImage = CType(resources.GetObject("PictureBoxClose.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxClose.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBoxClose.Location = New System.Drawing.Point(312, 3)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(18, 18)
        Me.PictureBoxClose.TabIndex = 0
        Me.PictureBoxClose.TabStop = False
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxMax.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMax.BackgroundImage = Global.Oexl.My.Resources.Resources.max_grey
        Me.PictureBoxMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxMax.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBoxMax.Location = New System.Drawing.Point(312, 21)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxMax.Name = "PictureBoxMax"
        Me.PictureBoxMax.Size = New System.Drawing.Size(18, 18)
        Me.PictureBoxMax.TabIndex = 1
        Me.PictureBoxMax.TabStop = False
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxMinimize.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxMinimize.BackgroundImage = Global.Oexl.My.Resources.Resources.minimize_grey
        Me.PictureBoxMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(312, 39)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBoxMinimize.Name = "PictureBoxMinimize"
        Me.PictureBoxMinimize.Size = New System.Drawing.Size(18, 18)
        Me.PictureBoxMinimize.TabIndex = 2
        Me.PictureBoxMinimize.TabStop = False
        '
        'RoundedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(333, 333)
        Me.Controls.Add(Me.PictureBoxMinimize)
        Me.Controls.Add(Me.PictureBoxMax)
        Me.Controls.Add(Me.PictureBoxClose)
        Me.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RoundedForm"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "RoudedForm"
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents PictureBoxClose As PictureBox
    Public WithEvents PictureBoxMax As PictureBox
    Public WithEvents PictureBoxMinimize As PictureBox
End Class
