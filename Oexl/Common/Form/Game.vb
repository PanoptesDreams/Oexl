Public Class Game

    Dim PSXBinDir As String = "C:\\Users\panoptes.live\Desktop\duck\duckstation-qt-x64-ReleaseLTCG.exe"

    Private Sub ButtonPSXLaunch_Click(sender As Object, e As EventArgs) Handles ButtonPSXLaunch.Click

        Dim PSXBin As New Process()

        PSXBin.StartInfo.FileName = PSXBinDir
        PSXBin.StartInfo.UseShellExecute = True

        PSXBin.Start()


    End Sub

End Class