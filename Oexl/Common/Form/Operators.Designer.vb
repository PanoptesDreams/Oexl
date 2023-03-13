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
        'PictureBoxMax
        '
        Me.PictureBoxMax.Location = New System.Drawing.Point(312, 24)
        '
        'PictureBoxMinimize
        '
        Me.PictureBoxMinimize.Location = New System.Drawing.Point(312, 45)
        '
        'ImageListOperator
        '
        Me.ImageListOperator.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListOperator.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageListOperator.TransparentColor = System.Drawing.Color.Transparent
        '
        'CheckedListBoxOperators
        '
        Me.CheckedListBoxOperators.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CheckedListBoxOperators.FormattingEnabled = True
        Me.CheckedListBoxOperators.Location = New System.Drawing.Point(7, 8)
        Me.CheckedListBoxOperators.Name = "CheckedListBoxOperators"
        Me.CheckedListBoxOperators.Size = New System.Drawing.Size(342, 214)
        Me.CheckedListBoxOperators.TabIndex = 0
        '
        'ButtonAddOperator
        '
        Me.ButtonAddOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddOperator.Location = New System.Drawing.Point(7, 289)
        Me.ButtonAddOperator.Name = "ButtonAddOperator"
        Me.ButtonAddOperator.Size = New System.Drawing.Size(106, 57)
        Me.ButtonAddOperator.TabIndex = 3
        Me.ButtonAddOperator.Text = "Add Operator"
        Me.ButtonAddOperator.UseVisualStyleBackColor = False
        '
        'ButtonSelectOperator
        '
        Me.ButtonSelectOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSelectOperator.Location = New System.Drawing.Point(261, 289)
        Me.ButtonSelectOperator.Name = "ButtonSelectOperator"
        Me.ButtonSelectOperator.Size = New System.Drawing.Size(106, 57)
        Me.ButtonSelectOperator.TabIndex = 4
        Me.ButtonSelectOperator.Text = "Select Operator"
        Me.ButtonSelectOperator.UseVisualStyleBackColor = False
        '
        'ButtonSetDefaultOperator
        '
        Me.ButtonSetDefaultOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSetDefaultOperator.Location = New System.Drawing.Point(136, 289)
        Me.ButtonSetDefaultOperator.Name = "ButtonSetDefaultOperator"
        Me.ButtonSetDefaultOperator.Size = New System.Drawing.Size(106, 57)
        Me.ButtonSetDefaultOperator.TabIndex = 5
        Me.ButtonSetDefaultOperator.Text = "Set Default Operator"
        Me.ButtonSetDefaultOperator.UseVisualStyleBackColor = False
        '
        'ButtonClearDefaultOperator
        '
        Me.ButtonClearDefaultOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClearDefaultOperator.Location = New System.Drawing.Point(136, 226)
        Me.ButtonClearDefaultOperator.Name = "ButtonClearDefaultOperator"
        Me.ButtonClearDefaultOperator.Size = New System.Drawing.Size(106, 57)
        Me.ButtonClearDefaultOperator.TabIndex = 6
        Me.ButtonClearDefaultOperator.Text = "Clear Default"
        Me.ButtonClearDefaultOperator.UseVisualStyleBackColor = False
        '
        'ButtonSetJunction
        '
        Me.ButtonSetJunction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSetJunction.Location = New System.Drawing.Point(7, 226)
        Me.ButtonSetJunction.Name = "ButtonSetJunction"
        Me.ButtonSetJunction.Size = New System.Drawing.Size(106, 57)
        Me.ButtonSetJunction.TabIndex = 7
        Me.ButtonSetJunction.Text = "Add Operator"
        Me.ButtonSetJunction.UseVisualStyleBackColor = False
        '
        'Operators
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 354)
        Me.Controls.Add(Me.ButtonSetJunction)
        Me.Controls.Add(Me.ButtonClearDefaultOperator)
        Me.Controls.Add(Me.ButtonSetDefaultOperator)
        Me.Controls.Add(Me.ButtonSelectOperator)
        Me.Controls.Add(Me.ButtonAddOperator)
        Me.Controls.Add(Me.CheckedListBoxOperators)
        Me.ForeColor = System.Drawing.Color.DarkOrchid
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "Operators"
        Me.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
