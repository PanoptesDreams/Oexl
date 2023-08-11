Imports System.Globalization

Public Class DesktopClock

    Private Sub DesktopClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.clock_ico


        LabelClockLabel.Text = My.Settings.ClockName
        WeekCalculator()
        ResizeMe()

    End Sub

    Private Sub ResizeMe()

        Me.Height = LabelWeekLabel.Location.Y + LabelWeekLabel.Height + 6
        Me.Width = lblTime.Width + 8
        LabelClockLabel.Location = New Point(Me.Width / 2 - LabelClockLabel.Width / 2, lblTime.Bottom + 8)
        LabelWeekLabel.Location = New Point(Me.Width / 2 - LabelWeekLabel.Width / 2, LabelClockLabel.Bottom + 8)
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

    ' Move to argus common
    Sub WeekCalculator()
        Dim currentDate As DateTime = DateTime.Now
        Dim weekOfYear As Integer = GetWeekOfYear(currentDate)

        LabelWeekLabel.Text = "Week " & weekOfYear
    End Sub

    ' Move to argus common
    Function GetWeekOfYear(currentDate As DateTime) As Integer

        Dim cultureInfo As CultureInfo = cultureInfo.CurrentCulture
        Dim calendar As Calendar = cultureInfo.Calendar
        Dim weekRule As CalendarWeekRule = cultureInfo.DateTimeFormat.CalendarWeekRule
        Dim firstDayOfWeek As DayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek

        Return calendar.GetWeekOfYear(currentDate, weekRule, firstDayOfWeek)
    End Function


End Class