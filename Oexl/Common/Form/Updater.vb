Imports System.Net

Public Class Updater

    Dim LocalVersion As String
    Dim WebVersion As String
    Dim WebCheckSuccess As Boolean


    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        HideOnClose = False

        GetLocalVersion()

        GetWebVersion()

        If WebCheckSuccess = True Then

            VersionCompare(Integer.Parse(LocalVersion.Replace(".", "")), Integer.Parse(WebVersion.Replace(".", "")))

        End If

    End Sub


    Sub GetLocalVersion()

        LocalVersion = My.Application.Info.Version.ToString

        LabelCurrentVersion.Text = "Current Version - " & LocalVersion

    End Sub


    Sub GetWebVersion()

        Dim client As WebClient = New WebClient()

        Try
            WebVersion = client.DownloadString("https://raw.githubusercontent.com/PanoptesDreams/Oexl/root/version")

            WebCheckSuccess = True

            LabelWebVersion.Text = "Web Version - " & WebVersion

        Catch ex As Exception

            WebCheckSuccess = False

            Imadeanoopsie(ex.ToString)

            LabelWebVersion.Text = "Web Version - " & "Failed to fetch version information"

        End Try



    End Sub

    Sub VersionCompare(local As Integer, web As Integer)

        If local > web Then

            LabelVersionAlert.Text = "Local version is newer than web version!"

        ElseIf web > local Then

            LabelVersionAlert.Text = "Web version is newer than local version!"

            ButtonFetchUpdate.Enabled = True

        Else

            LabelVersionAlert.Text = "You are up to date!"

        End If

    End Sub

    Private Sub ButtonFetchUpdate_Click(sender As Object, e As EventArgs) Handles ButtonFetchUpdate.Click



    End Sub
End Class