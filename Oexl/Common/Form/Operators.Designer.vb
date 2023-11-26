<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Operators
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Operators))
        Me.ImageListOperator = New System.Windows.Forms.ImageList(Me.components)
        Me.CheckedListBoxOperators = New System.Windows.Forms.CheckedListBox()
        Me.ButtonAddOperator = New Oexl.RoundedButton()
        Me.ButtonSelectOperator = New Oexl.RoundedButton()
        Me.ButtonSetDefaultOperator = New Oexl.RoundedButton()
        Me.ButtonClearDefaultOperator = New Oexl.RoundedButton()
        Me.ButtonSetJunction = New Oexl.RoundedButton()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Location = New System.Drawing.Point(343, 3)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(347, 26)
        Me.PictureBoxMax.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(347, 50)
        Me.PictureBoxMinimize.Margin = New System.Windows.Forms.Padding(3, 10, 10, 3)
        '
        'ImageListOperator
        '
        Me.ImageListOperator.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListOperator.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageListOperator.TransparentColor = System.Drawing.Color.Transparent
        '
        'CheckedListBoxOperators
        '
        Me.CheckedListBoxOperators.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckedListBoxOperators.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CheckedListBoxOperators.FormattingEnabled = True
        Me.CheckedListBoxOperators.Location = New System.Drawing.Point(8, 9)
        Me.CheckedListBoxOperators.Name = "CheckedListBoxOperators"
        Me.CheckedListBoxOperators.Size = New System.Drawing.Size(380, 234)
        Me.CheckedListBoxOperators.TabIndex = 0
        '
        'ButtonAddOperator
        '
        Me.ButtonAddOperator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddOperator.BackColor = System.Drawing.Color.Plum
        Me.ButtonAddOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddOperator.Location = New System.Drawing.Point(8, 318)
        Me.ButtonAddOperator.Name = "ButtonAddOperator"
        Me.ButtonAddOperator.Size = New System.Drawing.Size(118, 63)
        Me.ButtonAddOperator.TabIndex = 3
        Me.ButtonAddOperator.Text = "Add Operator"
        Me.ButtonAddOperator.UseVisualStyleBackColor = False
        '
        'ButtonSelectOperator
        '
        Me.ButtonSelectOperator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSelectOperator.BackColor = System.Drawing.Color.Plum
        Me.ButtonSelectOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSelectOperator.Location = New System.Drawing.Point(290, 318)
        Me.ButtonSelectOperator.Name = "ButtonSelectOperator"
        Me.ButtonSelectOperator.Size = New System.Drawing.Size(118, 63)
        Me.ButtonSelectOperator.TabIndex = 4
        Me.ButtonSelectOperator.Text = "Select Operator"
        Me.ButtonSelectOperator.UseVisualStyleBackColor = False
        '
        'ButtonSetDefaultOperator
        '
        Me.ButtonSetDefaultOperator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSetDefaultOperator.BackColor = System.Drawing.Color.Plum
        Me.ButtonSetDefaultOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSetDefaultOperator.Location = New System.Drawing.Point(151, 318)
        Me.ButtonSetDefaultOperator.Name = "ButtonSetDefaultOperator"
        Me.ButtonSetDefaultOperator.Size = New System.Drawing.Size(118, 63)
        Me.ButtonSetDefaultOperator.TabIndex = 5
        Me.ButtonSetDefaultOperator.Text = "Set Default Operator"
        Me.ButtonSetDefaultOperator.UseVisualStyleBackColor = False
        '
        'ButtonClearDefaultOperator
        '
        Me.ButtonClearDefaultOperator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClearDefaultOperator.BackColor = System.Drawing.Color.Plum
        Me.ButtonClearDefaultOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClearDefaultOperator.Location = New System.Drawing.Point(151, 249)
        Me.ButtonClearDefaultOperator.Name = "ButtonClearDefaultOperator"
        Me.ButtonClearDefaultOperator.Size = New System.Drawing.Size(118, 63)
        Me.ButtonClearDefaultOperator.TabIndex = 6
        Me.ButtonClearDefaultOperator.Text = "Clear Default"
        Me.ButtonClearDefaultOperator.UseVisualStyleBackColor = False
        '
        'ButtonSetJunction
        '
        Me.ButtonSetJunction.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSetJunction.BackColor = System.Drawing.Color.Plum
        Me.ButtonSetJunction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSetJunction.Location = New System.Drawing.Point(8, 249)
        Me.ButtonSetJunction.Name = "ButtonSetJunction"
        Me.ButtonSetJunction.Size = New System.Drawing.Size(118, 63)
        Me.ButtonSetJunction.TabIndex = 7
        Me.ButtonSetJunction.Text = "Add Operator"
        Me.ButtonSetJunction.UseVisualStyleBackColor = False
        '
        'Operators
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 389)
        Me.Controls.Add(Me.ButtonSetJunction)
        Me.Controls.Add(Me.ButtonClearDefaultOperator)
        Me.Controls.Add(Me.ButtonSetDefaultOperator)
        Me.Controls.Add(Me.ButtonSelectOperator)
        Me.Controls.Add(Me.ButtonAddOperator)
        Me.Controls.Add(Me.CheckedListBoxOperators)
        Me.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.Name = "Operators"
        Me.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Text = "Operators"
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        Me.Controls.SetChildIndex(Me.CheckedListBoxOperators, 0)
        Me.Controls.SetChildIndex(Me.ButtonAddOperator, 0)
        Me.Controls.SetChildIndex(Me.ButtonSelectOperator, 0)
        Me.Controls.SetChildIndex(Me.ButtonSetDefaultOperator, 0)
        Me.Controls.SetChildIndex(Me.ButtonClearDefaultOperator, 0)
        Me.Controls.SetChildIndex(Me.ButtonSetJunction, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ImageListOperator As ImageList
    Friend WithEvents CheckedListBoxOperators As CheckedListBox
    Friend WithEvents ButtonAddOperator As RoundedButton
    Friend WithEvents ButtonSelectOperator As RoundedButton
    Friend WithEvents ButtonSetDefaultOperator As RoundedButton
    Friend WithEvents ButtonClearDefaultOperator As RoundedButton
    Friend WithEvents ButtonSetJunction As RoundedButton
End Class
