Public Class Shortcuts

    Dim ShortcutDirectory As String = "R:\Adam\Operator\Shortcut"

    Private Sub Shortcuts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Positioner(Me, "Right")

        AddShortcutFilesToListBox()

    End Sub

    Sub AddShortcutFilesToListBox()

        Dim ListBox As ListBox
        ListBox = ListBoxShortcuts

        ' Clear the ListBox first
        ListBox.Items.Clear()

        ' Get all .lnk files in the specified folder
        Dim files() As String = Directory.GetFiles(ShortcutDirectory, "*.lnk")

        ' Add the file names to the ListBox
        For Each file As String In files
            Dim fileName As String = Path.GetFileName(file)
            ListBox.Items.Add(fileName)
        Next

    End Sub

    Private Sub ListBoxShortcuts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxShortcuts.SelectedIndexChanged

        Try

            Dim Link As String = Path.Combine(ShortcutDirectory, ListBoxShortcuts.SelectedItem.ToString)


            If File.Exists(Link) = True Then

                Process.Start(Link)

            End If

        Catch ex As Exception



        End Try

    End Sub
End Class