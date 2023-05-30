Public Class DesktopClock

    Private Sub DesktopClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.clock_ico


        LabelClockLabel.Text = My.Settings.ClockName

        ResizeMe()

    End Sub

    Private Sub ResizeMe()

        Me.Height = LabelClockLabel.Location.Y + LabelClockLabel.Height + 6
        Me.Width = lblTime.Width + 8
        LabelClockLabel.Location = New Point(Me.Width / 2 - LabelClockLabel.Width / 2, lblTime.Bottom + 8)

        Me.Location = New Point(My.Computer.Screen.WorkingArea.Width / 2 - (Width / 2), My.Computer.Screen.WorkingArea.Height / 2 - (Height / 2))

    End Sub

    Private Sub TimerTicker_Tick(sender As Object, e As EventArgs) Handles TimerTicker.Tick

        TimeTick()

    End Sub

    Sub TimeTick()

        Dim TimeZone As Short = My.Settings.ClockUTC
        Dim TimeFormat As String = My.Settings.ClockFormat


        Dim DesiredTime As Date = Now.ToUniversalTime.AddHours(TimeZone)
        Dim formattedTime As String = DesiredTime.ToString(TimeFormat)

        lblTime.Text = formattedTime

        ResizeMe()

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

        DesktopClockSettings.Show()

    End Sub


End Class