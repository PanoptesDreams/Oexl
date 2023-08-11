Public Class NoteTaker

    Dim folderPath As String = "R:\Adam\Operator\Note\"


    Private Sub ButtonSaveNote_Click(sender As Object, e As EventArgs) Handles ButtonSaveNote.Click

        ' Get the note title and body text
        Dim noteTitle As String = TextBoxNoteTitle.Text.Trim()
        Dim noteBody As String = TextBoxNoteBody.Text.Trim()

        ' Verify that the note has content
        If String.IsNullOrWhiteSpace(noteTitle) AndAlso String.IsNullOrWhiteSpace(noteBody) Then
            MessageBox.Show("Please enter a note title or body.")
            Return
        End If

        ' Combine the note title and body with appropriate new lines
        Dim noteContent As String = noteTitle & Environment.NewLine & Environment.NewLine & noteBody

        ' Save the note to a text file
        Dim fileName As String = folderPath & noteTitle & ".txt" ' update path

        Try
            ' Write the note content to the text file
            Using writer As New StreamWriter(fileName, True)
                writer.WriteLine(noteContent)
            End Using

            ' MessageBox.Show("Note saved to " & fileName)
            PicStatus.Image = My.Resources.complete

            Notes.PopulateListBoxWithFileNames(folderPath)



        Catch ex As Exception
            MessageBox.Show("Error occurred while saving the note: " & ex.Message)
        End Try

    End Sub



End Class