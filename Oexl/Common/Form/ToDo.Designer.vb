<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToDo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToDo))
        Me.ListToDo = New System.Windows.Forms.CheckedListBox()
        Me.HartPanel1 = New Oexl.HartPanel()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HartPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(369, 2)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(335, 2)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(301, 2)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'ListToDo
        '
        Me.ListToDo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListToDo.FormattingEnabled = True
        Me.ListToDo.Location = New System.Drawing.Point(1, 1)
        Me.ListToDo.Name = "ListToDo"
        Me.ListToDo.Size = New System.Drawing.Size(386, 773)
        Me.ListToDo.TabIndex = 3
        '
        'HartPanel1
        '
        Me.HartPanel1.Controls.Add(Me.ListToDo)
        Me.HartPanel1.Location = New System.Drawing.Point(2, 27)
        Me.HartPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.HartPanel1.Name = "HartPanel1"
        Me.HartPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.HartPanel1.Size = New System.Drawing.Size(388, 775)
        Me.HartPanel1.TabIndex = 4
        '
        'ToDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 804)
        Me.Controls.Add(Me.HartPanel1)
        Me.ForeColor = System.Drawing.Color.Indigo
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "ToDo"
        Me.Text = "ToDo"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.HartPanel1, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HartPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListToDo As CheckedListBox
    Friend WithEvents HartPanel1 As HartPanel
End Class
