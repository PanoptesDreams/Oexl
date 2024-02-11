Public Class HartListBox
    Inherits ListBox
    Public Sub New()
        DrawMode = DrawMode.OwnerDrawFixed
    End Sub
    Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
        e.DrawBackground()
        If e.Index >= 0 Then
            Dim stringFormat As New StringFormat()
            stringFormat.LineAlignment = StringAlignment.Center
            stringFormat.Alignment = StringAlignment.Center

            ' Use a font that supports emojis
            Dim emojiFont As New Font("Segoe UI Emoji", e.Font.Size)

            e.Graphics.DrawString(Me.Items(e.Index).ToString(), emojiFont, New SolidBrush(e.ForeColor), e.Bounds, stringFormat)
        End If
        e.DrawFocusRectangle()
    End Sub
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'HartListBox
        '
        Me.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemHeight = 30
        Me.Items.AddRange(New Object() {"UwU"})
        Me.Size = New System.Drawing.Size(120, 95)
        Me.ResumeLayout(False)

    End Sub
End Class
