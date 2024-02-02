Public Class TrayIcon


    Private Sub TrayIcon_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Height = Screen.PrimaryScreen.Bounds.Height
        Width = Screen.PrimaryScreen.Bounds.Width

        Positioner(Me, "Center-Center")

        PrepareTray()

        Summon(Launcher)

    End Sub

    ' Set Tray States
    Private Sub PrepareTray()

        TrayMenuLauncher.Checked = My.Settings.LauncherActive

        TrayMenuDestopClock.Checked = My.Settings.DestopClockActive


    End Sub

    Private Sub TrayMenuLauncher_Click(sender As Object, e As EventArgs) Handles TrayMenuLauncher.Click

        If TrayMenuLauncher.Checked = True Then

            Launcher.Hide()

            TrayMenuLauncher.Checked = False

        Else

            Launcher.Show()

            TrayMenuLauncher.Checked = True

        End If


    End Sub

    Private Sub TrayMenuDestopClock_Click(sender As Object, e As EventArgs) Handles TrayMenuDestopClock.Click

        If TrayMenuDestopClock.Checked = True Then

            DesktopClock.Close()

            TrayMenuDestopClock.Checked = False

        Else

            Summon(DesktopClock)

            TrayMenuDestopClock.Checked = True

        End If

        My.Settings.DestopClockActive = TrayMenuDestopClock.Checked

        ASave()

    End Sub

    Private Sub TrayMenuToolbox_Click(sender As Object, e As EventArgs) Handles TrayMenuToolbox.Click

        Summon(Toolbox)

    End Sub

    Private Sub TrayMenuShortcuts_Click(sender As Object, e As EventArgs) Handles TrayMenuShortcuts.Click
        Summon(Shortcuts)
    End Sub

    Private Sub TrayMenuExit_Click(sender As Object, e As EventArgs) Handles TrayMenuExit.Click

        Application.Exit()

    End Sub


End Class