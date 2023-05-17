Public Class Settings


    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateSettings()

    End Sub

    ' Writes settings values to labels
    Private Sub PopulateSettings()

        LabelSettingThemeDisplay.Text = My.Settings.Theme
        LabelSettingOperatorColorPrimaryDisplay.Text = My.Settings.OperatorColorPrimary.ToString
        LabelSettingOperatorColorSecondaryDisplay.Text = My.Settings.OperatorColorSecondary.ToString
        LabelSettingOperatorJunctionDisplay.Text = My.Settings.OperatorJunction
        LabelSettingOperatorNameDisplay.Text = My.Settings.OperatorName
        LabelSettingSystemMoodDisplay.Text = My.Settings.SystemMood
        LabelSettingOperatorDefaultProfileDisplay.Text = My.Settings.OperatorDefaultProfile
        LabelSettingLoadedDisplay.Text = My.Settings.Loaded

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
End Class