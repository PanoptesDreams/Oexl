Public Class Shortcuts

    Dim ShortcutDirectory As String = My.Settings.OperatorRoot & "\" & My.Settings.OperatorName & "\Operator\Shortcut"
    Const NoShortcus As String = "No Shorcuts Available"

    Private Sub Shortcuts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Positioner(Me, "Bottom-Right")

        HideOnClose = False ' Ensures shortcut list refreshes each time

        OperatorShortcutFolderCheck()

        AddShortcutFilesToListBox()

    End Sub

    Public Sub OperatorShortcutFolderCheck()

        If Directory.Exists(ShortcutDirectory) = False Then

            Directory.CreateDirectory(ShortcutDirectory)

        End If

    End Sub

    Sub AddShortcutFilesToListBox()

        Dim itemsadded As Integer = 0

        ' Clear the ListBox first
        ListBoxShortcuts.Items.Clear()

        ' Get all .lnk files in the specified folder
        Dim files() As String = Directory.GetFiles(ShortcutDirectory, "*.lnk")

        ' Get all .url files in the specified folder
        Dim urlFiles() As String = Directory.GetFiles(ShortcutDirectory, "*.url")

        ' Fetch and store icons for each file
        For Each file As String In files
            Dim fileName As String = Path.GetFileNameWithoutExtension(file)

            ' Add the file name to the ListBox
            ListBoxShortcuts.Items.Add(fileName)

            itemsadded += 1
        Next

        For Each urlFile As String In urlFiles
            Dim fileName As String = Path.GetFileNameWithoutExtension(urlFile)

            ' Add the file name to the ListBox
            ListBoxShortcuts.Items.Add(fileName)

            itemsadded += 1
        Next

        If itemsadded = 0 Then
            ListBoxShortcuts.Items.Add(NoShortcus)
        End If

        ListBoxShortcuts.SelectedIndex = 0

    End Sub


    Sub StartApp()

        If ListBoxShortcuts.SelectedItem.ToString = NoShortcus Then

            MsgBox("Drag and drop your shortcuts on the list to add.")

            GoTo 0

        End If

        Try

            Dim Link As String = Path.Combine(ShortcutDirectory, ListBoxShortcuts.SelectedItem.ToString & ".lnk")


            If File.Exists(Link) = True Then

                Process.Start(Link)

            Else
                Link = Path.Combine(ShortcutDirectory, ListBoxShortcuts.SelectedItem.ToString & ".url")
                Process.Start(Link)

            End If

        Catch ex As Exception

            MsgBox("An error has occured")

        End Try
0:
    End Sub

    Private Sub ListBoxShortcuts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxShortcuts.SelectedIndexChanged

        If ListBoxShortcuts.SelectedItem.ToString = NoShortcus Then

            GoTo 0

        End If

        Dim selectedShortcut As String = ListBoxShortcuts.SelectedItem.ToString()
        Dim shortcutPath As String = Path.Combine(ShortcutDirectory, selectedShortcut & ".lnk")

        If File.Exists(shortcutPath) Then
            Dim icon As Icon = Icon.ExtractAssociatedIcon(shortcutPath)
            PictureBoxIcon.Image = ResizeImage(icon.ToBitmap, PictureBoxIcon.Width, PictureBoxIcon.Height)
        Else
            shortcutPath = Path.Combine(ShortcutDirectory, selectedShortcut & ".url")
            Dim icon As Icon = Icon.ExtractAssociatedIcon(shortcutPath)
            PictureBoxIcon.Image = ResizeImage(icon.ToBitmap, PictureBoxIcon.Width, PictureBoxIcon.Height)
        End If
0:
    End Sub


    ' Drag and drop

    Private Sub ListBoxShortcuts_DragEnter(sender As Object, e As DragEventArgs) Handles ListBoxShortcuts.DragEnter

        ' Check if the Drag event contains a list of files
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub


    Private Sub ListBoxShortcuts_DragDrop(sender As Object, e As DragEventArgs) Handles ListBoxShortcuts.DragEnter

        ' Check if the Drop event contains a list of files
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            ' Get the list of files
            Dim files() As String = CType(e.Data.GetData(DataFormats.FileDrop), String())

            ' Add each file to the ListBox and copy it to the directory
            For Each file In files

                ' Get the filename
                Dim filename As String = Path.GetFileName(file)


                ' Create the destination path
                Dim destPath As String = Path.Combine(ShortcutDirectory, filename)

                If IO.File.Exists(destPath) = True Then
                    MsgBox("Shortcut already exists")
                    GoTo 0
                End If

                ' Copy the file to the directory
                IO.File.Copy(file, destPath)

            Next

            AddShortcutFilesToListBox()

        End If

0:
    End Sub


#Region "Buttons"

    Private Sub ListBoxShortcuts_DoubleClick(sender As Object, e As EventArgs)

        StartApp()

    End Sub

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click

        StartApp()

    End Sub



#End Region

#Region "That thing that you're doing"

    <DllImport("shell32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function ShellExecuteEx(ByRef lpExecInfo As SHELLEXECUTEINFO) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Auto)>
    Public Structure SHELLEXECUTEINFO
        Public cbSize As Integer
        Public fMask As Integer
        Public hwnd As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpVerb As String
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpFile As String
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpParameters As String
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpDirectory As String
        Public nShow As Integer
        Public hInstApp As IntPtr
        Public lpIDList As IntPtr
        <MarshalAs(UnmanagedType.LPTStr)>
        Public lpClass As String
        Public hkeyClass As IntPtr
        Public dwHotKey As Integer
        Public hIcon As IntPtr
        Public hProcess As IntPtr
    End Structure

    Private Const SW_SHOW As Integer = 5
    Private Const SEE_MASK_INVOKEIDLIST As Integer = 12

    Public Sub ShowFileProperties(ByVal Filename As String)
        Dim sei As New SHELLEXECUTEINFO()
        sei.cbSize = Marshal.SizeOf(sei)
        sei.lpVerb = "properties"
        sei.lpFile = Filename
        sei.nShow = SW_SHOW
        sei.fMask = SEE_MASK_INVOKEIDLIST
        ShellExecuteEx(sei)
    End Sub

    Private Sub ButtonEditShortcut_Click(sender As Object, e As EventArgs) Handles ButtonEditShortcut.Click
        Try

            Dim Link As String = Path.Combine(ShortcutDirectory, ListBoxShortcuts.SelectedItem.ToString & ".lnk")


            If File.Exists(Link) = True Then

                ShowFileProperties(Link)

            Else
                Link = Path.Combine(ShortcutDirectory, ListBoxShortcuts.SelectedItem.ToString & ".url")
                ShowFileProperties(Link)

            End If

        Catch ex As Exception



        End Try
    End Sub

    Private Sub ButtonRefreshList_Click(sender As Object, e As EventArgs) Handles ButtonRefreshList.Click

        AddShortcutFilesToListBox()

    End Sub

    Private Sub ButtonDeleteShortcut_Click(sender As Object, e As EventArgs) Handles ButtonDeleteShortcut.Click


        If MsgBox("Daddy", MsgBoxStyle.YesNo, "Oopsie") = vbYes Then

            Try

                Dim Link As String = Path.Combine(ShortcutDirectory, ListBoxShortcuts.SelectedItem.ToString & ".lnk")


                If File.Exists(Link) = True Then

                    File.Delete(Link)

                Else

                    Link = Path.Combine(ShortcutDirectory, ListBoxShortcuts.SelectedItem.ToString & ".url")
                    File.Delete(Link)


                End If

            Catch ex As Exception

                MsgBox("Shortcut doesn't exist, and I shit my pants")

                MsgBox(ex.ToString)

            End Try

        End If

        AddShortcutFilesToListBox()


    End Sub




#End Region


End Class
