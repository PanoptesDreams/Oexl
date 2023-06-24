Public Class Applications

    ' Before we even begin here, the form is NOT in template mode.
    ' From is in PRE-DEV
    ' Form is demonstarting
    ' That was not a typo


    Private Sub Applications_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonTrumpet_Click(sender As Object, e As EventArgs) Handles ButtonTrumpet.Click

        Dim cmd As String = "winget install " & "File-New-Project.EarTrumpet"
        Dim process As New Process()
        process.StartInfo.FileName = "cmd.exe"
        process.StartInfo.Arguments = "/c " & cmd
        process.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        process.Start()

    End Sub


End Class