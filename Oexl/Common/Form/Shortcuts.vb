Public Class Shortcuts

    Dim ShortcutDirectory As String = "R:\Adam\Operator\Shortcut"


    Private Sub Shortcuts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Positioner(Me, "Right")

        HideOnClose = False ' Ensures shortcut list refreshes each time

        AddShortcutFilesToListBox()

    End Sub


    Sub AddShortcutFilesToListBox()

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
        Next

        For Each urlFile As String In urlFiles
            Dim fileName As String = Path.GetFileNameWithoutExtension(urlFile)

            ' Add the file name to the ListBox
            ListBoxShortcuts.Items.Add(fileName)
        Next

    End Sub


    Sub StartApp()

        Try

            Dim Link As String = Path.Combine(ShortcutDirectory, ListBoxShortcuts.SelectedItem.ToString & ".lnk")


            If File.Exists(Link) = True Then

                Process.Start(Link)

            Else
                Link = Path.Combine(ShortcutDirectory, ListBoxShortcuts.SelectedItem.ToString & ".url")
                Process.Start(Link)

            End If

        Catch ex As Exception



        End Try

    End Sub

    Private Sub ListBoxShortcuts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxShortcuts.SelectedIndexChanged

        Dim selectedShortcut As String = ListBoxShortcuts.SelectedItem.ToString()
        Dim shortcutPath As String = Path.Combine(ShortcutDirectory, selectedShortcut & ".lnk")

        If File.Exists(shortcutPath) Then
            Dim icon As Icon = Icon.ExtractAssociatedIcon(shortcutPath)
            PictureBoxIcon.Image = icon.ToBitmap()
        Else
            shortcutPath = Path.Combine(ShortcutDirectory, selectedShortcut & ".url")
            Dim icon As Icon = Icon.ExtractAssociatedIcon(shortcutPath)
            PictureBoxIcon.Image = icon.ToBitmap()
        End If

    End Sub

    Private Sub ListBoxShortcuts_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxShortcuts.DoubleClick

        StartApp()

    End Sub

    Private Sub ButtonGo_Click(sender As Object, e As EventArgs) Handles ButtonGo.Click

        StartApp()

    End Sub
End Class
