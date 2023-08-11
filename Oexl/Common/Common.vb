Imports System.Drawing.Text
Imports System.Management


Public Module Common

#Region "Subroutines"


    ' Save Settings To My.Settings
    Public Sub ASave()

        My.Settings.Save()

        My.Settings.Reload()

    End Sub

    ' Create Tree Structure
    ''' <summary>
    ''' Generates all basic folders used in the Operators Folder.
    ''' </summary>
    ''' <param name="OperatorName">Name of Operator to have folders generatred for.</param>
    Public Sub BuildOperatorTree(OperatorName As String)

        Dim OperatorDirectory = Path.Combine(My.Settings.OperatorJunction & OperatorName)

        Dim BasePaths() As String = {".tmp", ".cloud", "Media", "Operator", "Software"}
        Dim MediaPaths() As String = {"Book", "Font", "Image", "Model", "Theme", "Video"}
        Dim OperatorPaths() As String = {"Document", "Keyring", "Media", "Note", "Shortcut", "Template", "Wallet"}
        Dim SoftwarePaths() As String = {".template", ".unsorted", "Crypto", "Development", "Driver", "Education", "Emulation", "File Distribution", "Game", "Media", "Operating System", "Productivity", "Repository", "Remote Control", "Security", "Script", "Shell", "System", "Utility", "Web"}

        For Each item In BasePaths
            Directory.CreateDirectory(Path.Combine(OperatorDirectory & "\" & item))
        Next

        For Each item In MediaPaths
            Directory.CreateDirectory(Path.Combine(OperatorDirectory & "\Media\" & item))
        Next

        For Each item In OperatorPaths
            Directory.CreateDirectory(Path.Combine(OperatorDirectory & "\Operator\" & item))
        Next

        For Each item In SoftwarePaths
            Directory.CreateDirectory(Path.Combine(OperatorDirectory & "\Software\" & item))
        Next
    End Sub

    Sub ClearIconCache()
        Try
            Dim iconCachePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "IconCache.db")

            ' Kill the explorer.exe process to release locks on the icon cache file
            For Each process As Process In Process.GetProcessesByName("explorer")
                process.Kill()
                process.WaitForExit()
            Next

            ' Delete the icon cache file
            If File.Exists(iconCachePath) Then
                File.Delete(iconCachePath)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while clearing the icon cache: " & ex.Message)
        End Try
    End Sub


    ' Create Operator
    Public Function CreateOperator(OperatorName As String)

        Dim folderPath As String = Path.Combine("R:\", OperatorName)
        Dim junctionPath As String = Path.Combine("A:\", OperatorName)

        If Directory.Exists(folderPath) Then ' Check if the folder already exists in R:

            If Directory.Exists(junctionPath) Then ' Folder exists check if Junction already exists

                MessageBox.Show("Operator already exists.", "Big Sad")

            Else ' Junction does not exist, prompt to create one

                Dim result As DialogResult = MessageBox.Show("Operator found in Root. Do you want to create a junction?", "Attention Duelist's!", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes AndAlso CreateJunction(junctionPath, folderPath) Then ' Junction created successfully

                    MessageBox.Show("Operator created successfully.", "Success")


                Else ' Junction creation failed or user canceled, show error message

                    MessageBox.Show("Failed to create Operator.", "Error")

                    Return 0

                End If

            End If

        Else ' Folder does not exist, create it and the junction

            Directory.CreateDirectory(folderPath)

            If CreateJunction(junctionPath, folderPath) Then ' Folder and junction created successfully

                MessageBox.Show("Folder and junction created successfully.", "Success")


            Else ' Junction creation failed, show error message and delete the folder

                MessageBox.Show("Failed to create junction.", "Error")

                Directory.Delete(folderPath)

                Return 0

            End If

        End If

        Return 1

    End Function

    Public Sub RemoveShortcutArrow()

        'change shortcut .ico location

        ClearIconCache() ' Clear Cache to view changes

    End Sub


    ' Rename  System
    ''' <summary>
    ''' Renames the Host System
    ''' </summary>
    ''' <param name="newName">New valid system name</param>
    Public Sub RenameSystem(newName As String)

        If IsValidSystemName(newName) Then

            Try
                'Connect to WMI service on the local machine
                Dim options As ConnectionOptions = New ConnectionOptions()
                options.Impersonation = ImpersonationLevel.Impersonate
                options.Authentication = AuthenticationLevel.Default
                options.EnablePrivileges = True

                Dim scope As ManagementScope = New ManagementScope("\\.\root\cimv2", options)

                'Create object query for Win32_ComputerSystem class
                Dim query As ObjectQuery = New ObjectQuery("SELECT * FROM Win32_ComputerSystem")

                'Create object searcher and retrieve the collection of Win32_ComputerSystem instances
                Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher(scope, query)
                Dim computerSystems As ManagementObjectCollection = searcher.Get()

                For Each computerSystem As ManagementObject In computerSystems

                    Dim returnValue As Object = computerSystem.InvokeMethod("Rename", New Object() {newName})
                    Dim errorCode As Integer = Integer.Parse(returnValue.ToString())

                    If errorCode = 0 Then
                        MessageBox.Show("Computer renamed successfully. Please restart the computer to apply changes.")
                    Else
                        MessageBox.Show("Failed to rename computer with error code " & errorCode)
                    End If

                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            MessageBox.Show("Invalid name specified. Computer names can only contain letters, numbers and hyphens, and cannot begin or end with a hyphen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Public Sub SetJunctionPath()
        Dim folderBrowser As New FolderBrowserDialog()

        ' Open the folder browser dialog
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            ' Check if the selected path exists and is a directory
            If Directory.Exists(folderBrowser.SelectedPath) Then
                My.Settings.OperatorJunction = folderBrowser.SelectedPath
                My.Settings.Save()
                MessageBox.Show("Junction path set to: " & My.Settings.OperatorJunction, "Success")
            Else
                MessageBox.Show("Invalid path selected. Please select a valid directory.", "Error")
            End If
        End If
    End Sub


    ' Summoner of Forms
    ''' <summary>
    ''' Opens Forms and Focus' them
    ''' </summary>
    ''' <param name="Sender">Form to Summon</param>
    Public Sub Summon(Sender As Object)

        If Sender.Visible = True Then ' If the form is already visible

            Sender.Activate() ' Simply trigger activate on form

        Else ' Otherwise ...

            Sender.Show() ' Properly open form ...

            Sender.Activate() ' And trigger activation.

        End If

    End Sub

    ' Windows State Toggler
    Public Sub ToggleMaximized(form As Form)

        If form.WindowState = FormWindowState.Maximized Then

            form.WindowState = FormWindowState.Normal

        Else

            form.WindowState = FormWindowState.Maximized

        End If

    End Sub

    ' Form Positioner
    ''' <summary>
    ''' Positions a form for you.
    ''' </summary>
    ''' <param name="Sender">Always Me</param>
    ''' <param name="Placement">Top, Bottom, Left, Right, Center</param>
    Public Sub Positioner(Sender As Form, Placement As String)

        Select Case Placement

            Case = "Top"
                Sender.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2 - (Sender.Width / 2)), 3)
            Case = "Bottom"
                Sender.Location = New Point((Screen.PrimaryScreen.Bounds.Width / 2 - (Sender.Width / 2)), (Screen.PrimaryScreen.Bounds.Height - 70))
            Case = "Left"
                Sender.Location = New Point(1, Screen.PrimaryScreen.Bounds.Height / 2 - Sender.Height / 2)
            Case = "Right"
                Sender.Location = New Point(Screen.PrimaryScreen.Bounds.Width - Sender.Width, Screen.PrimaryScreen.Bounds.Height / 2 - Sender.Height / 2)
            Case = "Center"
                Sender.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - (Sender.Width / 2), Screen.PrimaryScreen.Bounds.Height / 2 - Sender.Height / 2)
        End Select

    End Sub

#End Region


#Region "Functions"

    ' Create Junction
    ''' <summary>
    ''' Creates a file system junction.
    ''' </summary>
    ''' <param name="junctionPath">Where the Junction will be created</param>
    ''' <param name="targetPath">Original folder location</param>
    ''' <returns></returns>
    Public Function CreateJunction(ByVal junctionPath As String, ByVal targetPath As String) As Boolean

        Try

            Dim process As New Process()
            process.StartInfo.FileName = "cmd.exe"
            process.StartInfo.Arguments = $"/c mklink /j ""{junctionPath}"" ""{targetPath}"""
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            process.Start()
            process.WaitForExit()
            Return (process.ExitCode = 0)

        Catch ex As Exception

            MsgBox(ex.Message)

            Return False

        End Try

    End Function

    ' Greeting - Greet the operator based on the time of day
    Public Function Greeting()

        Dim Greet As String = ""
        Dim Mood As String = My.Settings.SystemMood

        Select Case Mood
            Case "Happy"
                Greet = "Good "
            Case "Neutral"
                Greet = ""
            Case "Bad"
                Greet = "Hi, "
                Return Greet
        End Select

        'Sets time of day greeting, formated to 24 hour
        Select Case Now.ToString("HH")

            'Morning case, from 00 (midnight) to 11am
            Case "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11"
                Greet += "Morning, "

            'Afternoon case, from 12pm (mid day) to 5pm
            Case "12", "13", "14", "15", "16", "17"
                Greet += "Afternoon, "

            'Evening case, from 6pm to 11pm
            Case "18", "19", "20", "21", "22", "23"
                Greet += "Evening, "
        End Select

        Return Greet

    End Function



    ' System Name Validity Checker
    ''' <summary>
    ''' Checks if name is vaild for a Windows System.
    ''' </summary>
    ''' <param name="name">Desired name.</param>
    ''' <returns></returns>
    Public Function IsValidSystemName(name As String) As Boolean

        If name.Length > 15 OrElse name.Length < 1 Then
            Return False
        End If

        Dim invalidChars As Char() = Path.GetInvalidFileNameChars()

        For Each c As Char In invalidChars
            If name.Contains(c) Then
                Return False
            End If
        Next

        If Not Char.IsLetter(name(0)) OrElse Not Char.IsLetterOrDigit(name(name.Length - 1)) Then
            Return False
        End If

        For i As Integer = 1 To name.Length - 2
            If Not Char.IsLetterOrDigit(name(i)) AndAlso name(i) <> "-" Then
                Return False
            End If
        Next

        Return True

    End Function


    Function CreateRegistryKey(ByVal keyPath As String, ByVal valueName As String, ByVal valueData As String) As Boolean
        Try
            Using key As RegistryKey = Registry.ClassesRoot.OpenSubKey(keyPath, writable:=True)
                If key IsNot Nothing Then
                    Return False
                End If

                Using newKey As RegistryKey = Registry.ClassesRoot.CreateSubKey(keyPath)
                    newKey.SetValue(valueName, valueData)
                End Using

                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function



    ' Image Resizer
    ''' <summary>
    ''' Takes image input and converts it to desired dimensions
    ''' </summary>
    ''' <param name="InputImage">Input formatted as Image, not file or string/path.</param>
    ''' <param name="ImageWidth">New Width</param>
    ''' <param name="ImageHeight">New Height</param>
    ''' <returns></returns>
    Public Function ResizeImage(ByVal InputImage As Image, ByVal ImageWidth As Integer, ByVal ImageHeight As Integer) As Image

        Return New Bitmap(InputImage, New Size(ImageWidth, ImageHeight))

    End Function


#End Region

End Module


Public Module FontManager

    Private Const FR_PRIVATE As Integer = &H10
    Private Const HWND_BROADCAST As Integer = &HFFFF
    Private Const WM_FONTCHANGE As Integer = &H1D

    <DllImport("gdi32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Function AddFontResourceEx(ByVal lpszFilename As String, ByVal fl As Integer, ByVal pdv As IntPtr) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function


    Public Sub InstallFontFromFile()

        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Multiselect = True
        openFileDialog.Filter = "Fonts (*.ttf)|*.ttf|All files (*.*)|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then

            For Each fontFile As String In openFileDialog.FileNames

                Try

                    InstallLocalFont(fontFile)

                Catch ex As Exception

                    Dim errorLog As String = String.Format("Error installing font {0} on {1}: {2}{3}", fontFile, DateTime.Now, ex.Message, Environment.NewLine)
                    System.IO.File.AppendAllText("error.txt", errorLog)

                End Try

            Next

            MessageBox.Show("Fonts installed successfully!", "Success")

        End If

    End Sub


    Public Sub InstallLocalFont(fontFile As String) 'Installs font file on local system and makes it available for use in applications.

        'Get the font name from the font file name by removing the extension.
        Dim fontName As String = System.IO.Path.GetFileNameWithoutExtension(fontFile)

        'Create a new PrivateFontCollection object that can be used to load custom fonts.
        Dim fontCollection As New PrivateFontCollection()

        'Load the font file into the PrivateFontCollection object.
        fontCollection.AddFontFile(fontFile)

        'Retrieve the FontFamily object of the loaded font file from the PrivateFontCollection.
        Dim fontFamily As FontFamily = fontCollection.Families(0)

        'Get the RegistryKey object for the Fonts registry key in the current user's registry.
        Dim fontKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows NT\CurrentVersion\Fonts")

        'Set the value of the font name to the font file path in the Fonts registry key.
        fontKey.SetValue(fontName, fontFile)

        'Add the font file to the system's font resource table.
        AddFontResourceEx(fontFile, FR_PRIVATE, 0)

        'Sends a message to all top-level windows to notify them that a new font has been installed.
        SendMessage(HWND_BROADCAST, WM_FONTCHANGE, 0, 0)

        'Create a new Font object using the installed font family, a size of 12, and regular style.
        Dim font As New Font(fontFamily, 12, FontStyle.Regular)

    End Sub


End Module

