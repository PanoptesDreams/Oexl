Public Class NoteTaker

    Dim folderPath As String = My.Settings.OperatorRoot & "\" & My.Settings.OperatorName & "\Operator\Note"


    Private Sub ButtonSaveNote_Click(sender As Object, e As EventArgs) Handles ButtonSaveNote.Click

        ' Get the note title and body text
        Dim noteTitle As String = Date.Now.ToString("MMMM dd, yyyy - HHmmss")
        Dim noteBody As String = TextBoxNoteBody.Text.Trim()

        ' Combine the note title and body with appropriate new lines
        Dim noteContent As String = noteTitle & Environment.NewLine & Environment.NewLine & noteBody

        ' Save the note to a text file
        Dim fileName As String = folderPath & "\" & noteTitle & ".txt" ' update path

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