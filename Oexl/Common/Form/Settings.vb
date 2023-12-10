Public Class Settings


    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateSettings()

    End Sub

    ' Writes settings values to labels
    Private Sub PopulateSettings()

        LabelSettingThemeDisplay.Text = My.Settings.Theme
        LabelSettingOperatorColorPrimaryDisplay.Text = My.Settings.OperatorColorPrimary.ToString
        LabelSettingOperatorColorSecondaryDisplay.Text = My.Settings.OperatorColorSecondary.ToString
        LabelSettingOperatorJunctionDisplay.Text = My.Settings.OperatorRoot
        LabelSettingOperatorNameDisplay.Text = My.Settings.OperatorName
        LabelSettingSystemMoodDisplay.Text = My.Settings.SystemMood
        LabelSettingOperatorDefaultProfileDisplay.Text = My.Settings.OperatorDefaultProfile
        LabelSettingLoadedDisplay.Text = My.Settings.Loaded
        NumUpDownFormCornerRadius.Value = My.Settings.FormRadius

    End Sub


    Private Sub LabelSettingThemeDisplay_Click(sender As Object, e As EventArgs) Handles LabelSettingThemeDisplay.Click

        ' Change string with input

    End Sub

    Private Sub LabelSettingOperatorColorPrimaryDisplay_Click(sender As Object, e As EventArgs) Handles LabelSettingOperatorColorPrimaryDisplay.Click

        ' Change color with color picker

    End Sub

    Private Sub LabelSettingOperatorColorSecondaryDisplay_Click(sender As Object, e As EventArgs) Handles LabelSettingOperatorColorSecondaryDisplay.Click

        ' Change color with color picker

    End Sub

    Private Sub LabelSettingOperatorJunctionDisplay_Click(sender As Object, e As EventArgs) Handles LabelSettingOperatorJunctionDisplay.Click

        ' Change string with OFD

    End Sub

    Private Sub LabelSettingOperatorNameDisplay_Click(sender As Object, e As EventArgs) Handles LabelSettingOperatorNameDisplay.Click

        ' Change Operator name with Input. Needs checks to prevent stomping/errors

    End Sub

    Private Sub LabelSettingSystemMoodDisplay_Click(sender As Object, e As EventArgs) Handles LabelSettingSystemMoodDisplay.Click

        ' Change Mood with combo box

    End Sub

    Private Sub LabelSettingOperatorDefaultProfileDisplay_Click(sender As Object, e As EventArgs) Handles LabelSettingOperatorDefaultProfileDisplay.Click

        ' Change Default Op using combo box
        ' Prompt: "this can also be done by opening the operator select menu....."

    End Sub

    Private Sub LabelSettingLoadedDisplay_Click(sender As Object, e As EventArgs) Handles LabelSettingLoadedDisplay.Click

        ' Change Loaded variable with check box or radio button

    End Sub

    Private Sub PanelSettingsOperatorPictureChange_DragEnter(sender As Object, e As DragEventArgs) Handles PanelSettingsOperatorPictureChange.DragEnter

        ' Check if the Drag event contains a list of files
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub


    ' This needs to be replaced with a common function that changes the Avatar to any image
    ' The sub should take in the image location as an argument, automatically convert it to a png
    ' then store it in the appropriate location

    Private Sub PanelSettingsOperatorPictureChange_DragDrop(sender As Object, e As DragEventArgs) Handles PanelSettingsOperatorPictureChange.DragDrop

        ' Check if the Drop event contains a list of files
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            ' Get the list of files
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

            If files.Length = 1 Then

                ' Add each file to the ListBox and copy it to the directory
                For Each file In files

                    Dim filename As String = Path.GetFileName(file) ' Get the filename
                    Dim destPath As String = Path.Combine(My.Settings.OperatorRoot & "\" & My.Settings.OperatorName & "\Operator\avatar.png") ' Create the destination path

                    If IO.File.Exists(destPath) = True Then ' If an avatar already exists, back it up

                        Dim bakTimeStamp As String = DateTime.Now.ToString("MMddyyyyhhmmss")
                        Dim bakPath As String = Path.Combine(My.Settings.OperatorRoot & "\" & My.Settings.OperatorName & "Media\Image\Avatar\avatar-" & bakTimeStamp & ".png")

                        IO.File.Copy(destPath, bakPath)

                    End If

                    ' Copy the file to the directory
                    IO.File.Copy(file, destPath)

                Next

            Else

                MsgBox("Too many images")
                GoTo 0

            End If

            Launcher.LoadOperatorAvatar()

        End If

0:

    End Sub


    Private Sub LabelSettingUpdaterSummon_Click(sender As Object, e As EventArgs) Handles LabelSettingUpdaterSummon.Click

        Summon(Updater)

    End Sub

    Private Sub PicRestartApp_Click(sender As Object, e As EventArgs) Handles PicRestartApp.Click

        Application.Restart()

    End Sub

    Private Sub NumUpDownFormCornerRadius_ValueChanged(sender As Object, e As EventArgs) Handles NumUpDownFormCornerRadius.ValueChanged

        My.Settings.FormRadius = NumUpDownFormCornerRadius.Value

        ASave()

    End Sub
End Class