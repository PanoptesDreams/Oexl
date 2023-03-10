Imports System.Drawing.Drawing2D

Public Class RoundedForm

    ' Border
    Private BorderPath As New GraphicsPath()
    Private BorderColor As Color = BorderColorize(BackColor)

    ' Movement
    Private isDragging As Boolean = False
    Private mouseOffset As Point


    ' Form Loading event handler
    Private Sub RoundedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBoxClose.Location = New Point(Me.ClientSize.Width - PictureBoxClose.Width - 3, 3)
        PictureBoxMax.Location = New Point(Me.ClientSize.Width - PictureBoxMax.Width - 3, PictureBoxClose.Location.Y + PictureBoxMax.Width + 3)
        PictureBoxMinimize.Location = New Point(Me.ClientSize.Width - PictureBoxMinimize.Width - 3, PictureBoxMax.Location.Y + PictureBoxMinimize.Width + 3)

        BackColor = My.Settings.OperatorColorPrimary
        ForeColor = My.Settings.OperatorColorSecondary

        SetRoundEdges() ' Define the initial shape of the GraphicsPath object to be rounded corners

        Positioner(Me, "Center")

        Icon = My.Resources.oexl_small

    End Sub


    Private Function BorderColorize(ByVal color As Color) As Color
        'Calculate the perceived brightness of the color using the formula for relative luminance from the sRGB color space.
        Dim luminance As Double = 0.2126 * color.R + 0.7152 * color.G + 0.0722 * color.B

        'Determine whether the color is closer to white or black based on its perceived brightness.
        Dim isLightColor As Boolean = (luminance > 128)

        'Calculate the amount of brightness change needed to produce a visible border.
        Dim delta As Integer = If(isLightColor, -20, 20)

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


    Private Sub RoundedForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        SetRoundEdges() ' Update the shape of the GraphicsPath object to match the new size of the form

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

    ' Form Painting event Handler
    Private Sub RoundedForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        BorderColor = BorderColorize(BackColor)

        ' Draw a custom border using Pen and predetermined Arc Paths in SetRoundEdges()
        Dim pen1 As New Pen(BorderColor, 6)
        e.Graphics.DrawPath(pen1, BorderPath)

    End Sub

    ' Mouse Click down event handler
    Private Sub RoundedForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        If e.Button = MouseButtons.Left Then ' Move form on Left Mouse down, activation

            isDragging = True
            mouseOffset = New Point(-e.X, -e.Y)

        End If

    End Sub

    ' Mouse Movement event handler
    Private Sub RoundedForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        If isDragging Then ' Move form on Left Mouse down, movement

            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos

        End If

    End Sub

    ' Mouse Click up event handler
    Private Sub RoundedForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp

        If e.Button = MouseButtons.Left Then ' Move form on Left Mouse down, deactivation

            isDragging = False

        End If

    End Sub

#Region "Buttons"

    ' Close
    Private Sub PictureBoxClose_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxClose.MouseEnter

        PictureBoxClose.BackgroundImage = My.Resources.close

    End Sub

    Private Sub PictureBoxClose_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxClose.MouseLeave

        PictureBoxClose.BackgroundImage = My.Resources.close_grey

    End Sub

    Private Sub PictureBoxClose_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click

        Close()

    End Sub

    ' Maximize
    Private Sub PictureBoxMax_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxMax.MouseEnter

        If WindowState = FormWindowState.Maximized Then
            PictureBoxMax.BackgroundImage = My.Resources.max_reduce
        Else
            PictureBoxMax.BackgroundImage = My.Resources.max
        End If

    End Sub

    Private Sub PictureBoxMax_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMax.MouseLeave

        If WindowState = FormWindowState.Maximized Then
            PictureBoxMax.BackgroundImage = My.Resources.max_grey_reduce
        Else
            PictureBoxMax.BackgroundImage = My.Resources.max_grey
        End If

    End Sub

    Private Sub PictureBoxMax_Click(sender As Object, e As EventArgs) Handles PictureBoxMax.Click

        ToggleMaximized(Me)

    End Sub

    ' Minimize
    Private Sub PictureBoxMinimize_MouseEnter(sender As Object, e As EventArgs) Handles PictureBoxMinimize.MouseEnter

        PictureBoxMinimize.BackgroundImage = My.Resources.minimize

    End Sub

    Private Sub PictureBoxMinimize_MouseLeave(sender As Object, e As EventArgs) Handles PictureBoxMinimize.MouseLeave

        PictureBoxMinimize.BackgroundImage = My.Resources.minimize_grey

    End Sub

    Private Sub PictureBoxMinimize_Click(sender As Object, e As EventArgs) Handles PictureBoxMinimize.Click

        WindowState = FormWindowState.Minimized

    End Sub

#End Region

End Class
