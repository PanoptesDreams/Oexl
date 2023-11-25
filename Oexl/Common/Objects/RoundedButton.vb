Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    ' Border
    Private BorderPath As New GraphicsPath()
    Private BorderColor As Color = My.Settings.OperatorColorSecondary
    Private OpBackColor As Color = My.Settings.OperatorColorPrimary


    ' Add custom properties, methods, and event handlers here
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        ' Call the base class's OnPaint method to draw the basic button
        MyBase.OnPaint(e)

        ' Draw custom graphics or modify the appearance of the button here
        ' BackColor = BorderColorize(My.Settings.OperatorColorPrimary)
        SetRoundEdges()
        ' Draw a custom border using Pen and predetermined Arc Paths in SetRoundEdges()
        Dim pen1 As New Pen(BorderColor, 9)
        e.Graphics.DrawPath(pen1, BorderPath)
    End Sub

    Private Sub SetRoundEdges() ' Define the shape of the GraphicsPath object to be rounded corners

        BorderPath.Reset()
        BorderPath.StartFigure()

        BorderPath.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        BorderPath.AddLine(20, 0, Me.Width - 20, 0)
        BorderPath.AddArc(New Rectangle(Me.Width - 20, 0, 20, 20), -90, 90)
        BorderPath.AddLine(Me.Width, 20, Me.Width, Me.Height - 20)
        BorderPath.AddArc(New Rectangle(Me.Width - 20, Me.Height - 20, 20, 20), 0, 90)
        BorderPath.AddLine(Me.Width - 20, Me.Height, 20, Me.Height)
        BorderPath.AddArc(New Rectangle(0, Me.Height - 20, 20, 20), 90, 90)

        BorderPath.CloseFigure()

        Me.Region = New Region(BorderPath) ' Set the form's Region property to the GraphicsPath object

    End Sub

    Private Function BorderColorize(ByVal color As Color) As Color
        'Calculate the perceived brightness of the color using the formula for relative luminance from the sRGB color space.
        Dim luminance As Double = 0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B

        'Determine whether the color is closer to white or black based on its perceived brightness.
        Dim isLightColor As Boolean = (luminance > 128)

        'Calculate the amount of brightness change needed to produce a visible border.
        Dim delta As Integer = If(isLightColor, -6, 6)

        'Adjust the color brightness by the delta value to produce the new color.
        Dim newR As Integer = color.R + delta
        Dim newG As Integer = color.G + delta
        Dim newB As Integer = color.B + delta

        'Check if any of the RGB values fall outside the valid range of 0-255
        If newR < 0 Then
            newR = Math.Abs(newR)
        ElseIf newR > 255 Then
            newR = 255 - (newR - 255)
        End If

        If newG < 0 Then
            newG = Math.Abs(newG)
        ElseIf newG > 255 Then
            newG = 255 - (newG - 255)
        End If

        If newB < 0 Then
            newB = Math.Abs(newB)
        ElseIf newB > 255 Then
            newB = 255 - (newB - 255)
        End If

        Dim newColor As Color = Color.FromArgb(newR, newG, newB)

        Return newColor
    End Function

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'RoundedButton
        '
        Me.BackColor = System.Drawing.Color.Plum
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkOrchid
        Me.UseVisualStyleBackColor = False
        Me.ResumeLayout(False)

    End Sub
End Class

