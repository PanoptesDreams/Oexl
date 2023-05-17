Public Class WingetInstaller


    Private Sub WingetInstaller_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateApps()

    End Sub

    Private Sub PositionChildren()

        ComboBoxApps.Width = CInt(Me.Width * 0.69)

    End Sub


    Private Sub PopulateApps()

        ' Multiline formatting to readability
        Dim softwareIDs(,) As String = {{"Logitech", "Logitech.GHUB"},
                                {"VLC media player", "VideoLAN.VLC"},
                                {"Mozilla Firefox", "Mozilla.Firefox"},
                                {"Notepad++", "Notepad++.Notepad++"},
                                {"Visual Studio Code", "Microsoft.VisualStudioCode"},
                                {"Steam", "Valve.Steam"}}

        For Each item In softwareIDs

            ComboBoxApps.Items.Add(item)

        Next

    End Sub

    Private cmdProcess As Process

    Public Sub New()
        InitializeComponent()

        cmdProcess = New Process()
        cmdProcess.StartInfo.FileName = "cmd.exe"
        cmdProcess.StartInfo.UseShellExecute = False
        cmdProcess.StartInfo.RedirectStandardOutput = True
        cmdProcess.StartInfo.RedirectStandardInput = True
        cmdProcess.StartInfo.CreateNoWindow = True
        AddHandler cmdProcess.OutputDataReceived, AddressOf CmdOutputDataReceived
        cmdProcess.Start()
        cmdProcess.BeginOutputReadLine()
    End Sub

    Private Sub CmdOutputDataReceived(sender As Object, e As DataReceivedEventArgs)
        If e.Data IsNot Nothing Then
            Me.Invoke(Sub() TextBox1.AppendText(e.Data & vbCrLf))
        End If
    End Sub

End Class