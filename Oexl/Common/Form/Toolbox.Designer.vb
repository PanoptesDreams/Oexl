<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Toolbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Toolbox))
        Me.ButtonAddFont = New Oexl.RoundedButton()
        Me.ButtonRenameSystem = New Oexl.RoundedButton()
        Me.ButtonAddOperator = New Oexl.RoundedButton()
        Me.ButtonBuildOperatorTree = New Oexl.RoundedButton()
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
        'ButtonAddFont
        '
        Me.ButtonAddFont.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonAddFont.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddFont.Location = New System.Drawing.Point(6, 6)
        Me.ButtonAddFont.Name = "ButtonAddFont"
        Me.ButtonAddFont.Size = New System.Drawing.Size(106, 57)
        Me.ButtonAddFont.TabIndex = 0
        Me.ButtonAddFont.Text = "Add Font"
        Me.ButtonAddFont.UseVisualStyleBackColor = False
        '
        'ButtonRenameSystem
        '
        Me.ButtonRenameSystem.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonRenameSystem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRenameSystem.Location = New System.Drawing.Point(6, 69)
        Me.ButtonRenameSystem.Name = "ButtonRenameSystem"
        Me.ButtonRenameSystem.Size = New System.Drawing.Size(106, 57)
        Me.ButtonRenameSystem.TabIndex = 1
        Me.ButtonRenameSystem.Text = "Rename System"
        Me.ButtonRenameSystem.UseVisualStyleBackColor = False
        '
        'ButtonAddOperator
        '
        Me.ButtonAddOperator.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonAddOperator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddOperator.Location = New System.Drawing.Point(6, 132)
        Me.ButtonAddOperator.Name = "ButtonAddOperator"
        Me.ButtonAddOperator.Size = New System.Drawing.Size(106, 57)
        Me.ButtonAddOperator.TabIndex = 2
        Me.ButtonAddOperator.Text = "Add Operator"
        Me.ButtonAddOperator.UseVisualStyleBackColor = False
        '
        'ButtonBuildOperatorTree
        '
        Me.ButtonBuildOperatorTree.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.ButtonBuildOperatorTree.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBuildOperatorTree.Location = New System.Drawing.Point(118, 132)
        Me.ButtonBuildOperatorTree.Name = "ButtonBuildOperatorTree"
        Me.ButtonBuildOperatorTree.Size = New System.Drawing.Size(106, 57)
        Me.ButtonBuildOperatorTree.TabIndex = 3
        Me.ButtonBuildOperatorTree.Text = "Build Op Tree"
        Me.ButtonBuildOperatorTree.UseVisualStyleBackColor = False
        '
        'Toolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 561)
        Me.Controls.Add(Me.ButtonBuildOperatorTree)
        Me.Controls.Add(Me.ButtonAddOperator)
        Me.Controls.Add(Me.ButtonRenameSystem)
        Me.Controls.Add(Me.ButtonAddFont)
        Me.ForeColor = System.Drawing.Color.Purple
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.Name = "Toolbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Toolbox"
        Me.Controls.SetChildIndex(Me.ButtonAddFont, 0)
        Me.Controls.SetChildIndex(Me.ButtonRenameSystem, 0)
        Me.Controls.SetChildIndex(Me.ButtonAddOperator, 0)
        Me.Controls.SetChildIndex(Me.ButtonBuildOperatorTree, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxClose, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMax, 0)
        Me.Controls.SetChildIndex(Me.PictureBoxMinimize, 0)
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonAddFont As RoundedButton
    Friend WithEvents ButtonRenameSystem As RoundedButton
    Friend WithEvents ButtonAddOperator As RoundedButton
    Friend WithEvents ButtonBuildOperatorTree As RoundedButton
End Class
