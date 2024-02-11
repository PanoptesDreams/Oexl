Public Class Launcher


    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OperatorLoader()

        PositionElements()

        Positioner(Me, "Top-Center")

        PictureBoxToolbox.Image = ResizeImage(My.Resources.toolbox, PictureBoxToolbox.Width - 3, PictureBoxToolbox.Height - 3)

        PictureBoxShutdown.Image = ResizeImage(My.Resources.close, PictureBoxToolbox.Width - 3, PictureBoxToolbox.Height - 3)

        If My.Settings.DestopClockActive = True Then

            Summon(DesktopClock)

        End If

        Summon(Shortcuts)


    End Sub

    ' Operator Loader
    Public Sub OperatorLoader()

        Dim OperatorGreeting = Greeting()

        LabelGreeting.Text = OperatorGreeting ' Greet the Operator

        LabelOperatorName.Text = My.Settings.OperatorName ' Retrieve name

        LoadOperatorAvatar()

        TrayIcon.TrayCommon.Text = "OEXL - " & My.Settings.OperatorName

    End Sub

    ' Operator Avatar Loader
    Public Sub LoadOperatorAvatar()

        Dim OperatorPicture As Image

        Try ' Loading Operator image from the default path

            OperatorPicture = Image.FromFile(Path.Combine(My.Settings.OperatorRoot & "\" & My.Settings.OperatorName & "\" & "\Operator\avatar.png"))

        Catch ex As Exception ' Insert default image instead

            OperatorPicture = My.Resources.operator_default

        End Try

        PictureBoxOperatorAvatar.Image = ResizeImage(OperatorPicture, PictureBoxOperatorAvatar.Width - 3, PictureBoxOperatorAvatar.Height - 3) ' Resize imported image and apply

    End Sub

    Private Sub PositionElements()

        PictureBoxOperatorAvatar.Location = New Point(Me.Width / 2 - PictureBoxOperatorAvatar.Width / 2, Me.Height / 2 - PictureBoxOperatorAvatar.Height / 2) ' fix

    End Sub

    Private Sub LabelOperatorName_Click(sender As Object, e As EventArgs) Handles LabelOperatorName.Click

        Summon(Operators)

    End Sub

    Private Sub PictureBoxToolbox_Click(sender As Object, e As EventArgs) Handles PictureBoxToolbox.Click

        Summon(Toolbox)

    End Sub

    Private Sub Launcher_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged

        If Visible = False Then

            TrayIcon.TrayMenuLauncher.Checked = False

        ElseIf Visible = True Then

            TrayIcon.TrayMenuLauncher.Checked = True

        End If

    End Sub

    Private Sub PictureBoxShutdown_Click(sender As Object, e As EventArgs) Handles PictureBoxShutdown.Click

        Application.Exit()

    End Sub
End Class