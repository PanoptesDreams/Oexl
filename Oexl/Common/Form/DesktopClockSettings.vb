Public Class DesktopClockSettings


    Dim TimeZone As Short = My.Settings.ClockUTC
    Dim ClockLabel As String = My.Settings.ClockName
        Dim ClockFormat As String = My.Settings.ClockFormat

        Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Icon = My.Resources.clock_ico

        ComboBoxUTC.Text = TimeZone

            ComboBoxFormat.Text = ClockFormat

            TextBoxClockLabel.Text = ClockLabel

        End Sub

        Private Sub ComboBoxUTC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUTC.SelectedIndexChanged

            TimeZone = ComboBoxUTC.Text

        My.Settings.ClockUTC = TimeZone

        ASave()

        End Sub

        Private Sub ComboBoxFormat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFormat.SelectedIndexChanged

            ClockFormat = ComboBoxFormat.Text

            My.Settings.ClockFormat = ClockFormat

            ASave()

        End Sub


        Private Sub TextBoxClockLabel_TextChanged(sender As Object, e As EventArgs) Handles TextBoxClockLabel.TextChanged

            ClockLabel = TextBoxClockLabel.Text

            DesktopClock.LabelClockLabel.Text = ClockLabel

            My.Settings.ClockName = ClockLabel

            ASave()

        End Sub

    End Class