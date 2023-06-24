Public Class Notes

    Dim folderPath As String = "R:\Adam\Operator\Note"

    Private Sub Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateListBoxWithFileNames(folderPath)

    End Sub

    Sub PopulateListBoxWithFileNames(folderPath As String)
        Try
            ' Clear the list box first
            ListBoxNotes.Items.Clear()

            ' Get a list of all .txt files in the specified folder
            Dim txtFileNames() As String = System.IO.Directory.GetFiles(folderPath, "*.txt")
            For Each txtFileName As String In txtFileNames
                ' Add the file name (without extension) to the list box
                ListBoxNotes.Items.Add(System.IO.Path.GetFileNameWithoutExtension(txtFileName))
            Next

            ' Get a list of all .md files in the specified folder
            Dim mdFileNames() As String = System.IO.Directory.GetFiles(folderPath, "*.md")
            For Each mdFileName As String In mdFileNames
                ' Add the file name (without extension) to the list box
                ListBoxNotes.Items.Add(System.IO.Path.GetFileNameWithoutExtension(mdFileName))
            Next

        Catch ex As Exception
            ' Handle any exceptions that occur
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub LoadFileIntoTextBoxNotes(fileName As String)
        Try
            ' Load the contents of the file into the TextBoxNotes
            TextBoxNotes.LoadFile(fileName, RichTextBoxStreamType.PlainText)
        Catch ex As Exception
            ' Handle any exceptions that occur
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub ListBoxNotes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNotes.SelectedIndexChanged
        ' Get the selected item in the ListBoxNotes
        Dim selectedItem As String = ListBoxNotes.SelectedItem

        ' Load the file into the TextBoxNotes
        If Not String.IsNullOrEmpty(selectedItem) Then
            Dim filePath As String = Path.Combine(folderPath, selectedItem & ".txt")
            If Not System.IO.File.Exists(filePath) Then
                filePath = Path.Combine(folderPath, selectedItem & ".md")
            End If
            If System.IO.File.Exists(filePath) Then
                LoadFileIntoTextBoxNotes(filePath)
            Else
                MessageBox.Show("File not found: " & filePath)
            End If
        End If
    End Sub

    Private Sub ButtonOpenNotesFolder_Click(sender As Object, e As EventArgs) Handles ButtonOpenNotesFolder.Click

        Dim startInfo As New ProcessStartInfo("explorer.exe")
        startInfo.Arguments = folderPath
        Process.Start(startInfo)

    End Sub

    Private Sub ButtonTakeNote_Click(sender As Object, e As EventArgs) Handles ButtonTakeNote.Click

        Summon(NoteTaker)

    End Sub

    ' Demo subroutine that serves to teach the imitating of a click
    Private Sub ImmatatoButton_Click(sender As Object, e As EventArgs) Handles ImmatatoButton.Click

        ButtonTakeNote.PerformClick()

    End Sub
End Class