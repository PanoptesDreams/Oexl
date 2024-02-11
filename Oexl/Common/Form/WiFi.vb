Public Class WiFi

    Public Sub ShowWifiPassword()
        Dim wifiProfile As String = ""
        Dim wifiPassword As String = ""

        Dim process As New Process()
        process.StartInfo.FileName = "netsh"
        process.StartInfo.Arguments = "wlan show interfaces"
        process.StartInfo.UseShellExecute = False
        process.StartInfo.RedirectStandardOutput = True
        process.Start()

        Dim output As String = process.StandardOutput.ReadToEnd()
        process.WaitForExit()

        Dim ssidRegex As New Regex("^\s+SSID\s+:\s+(.*)$", RegexOptions.Multiline)
        Dim ssidMatch As Match = ssidRegex.Match(output)
        If ssidMatch.Success Then
            wifiProfile = ssidMatch.Groups(1).Value.Trim()
        End If

        process.StartInfo.Arguments = "wlan show profile name=""" & wifiProfile & """ key=clear"
        process.Start()

        output = process.StandardOutput.ReadToEnd()
        process.WaitForExit()

        Dim passwordRegex As New Regex("Key Content\s+:\s+(.*)$", RegexOptions.Multiline)
        Dim passwordMatch As Match = passwordRegex.Match(output)
        If passwordMatch.Success Then
            wifiPassword = passwordMatch.Groups(1).Value.Trim()
        End If


        TextBoxSSID.Text = wifiProfile
        TextBoxPassword.Text = wifiPassword

    End Sub



    Private Sub TextBoxPassword_Click(sender As Object, e As EventArgs) Handles TextBoxPassword.Click
        TextBoxPassword.SelectAll()
    End Sub

    Private Sub TextBoxSSID_Click(sender As Object, e As EventArgs) Handles TextBoxSSID.Click
        TextBoxSSID.SelectAll()

    End Sub


    Private Sub WiFi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Positioner(Me, "Top-Left") ' Override where you want the form to go

        HideOnClose = False ' This changes the inherent hiding of a form to a close instead

        ShowWifiPassword()


    End Sub
End Class