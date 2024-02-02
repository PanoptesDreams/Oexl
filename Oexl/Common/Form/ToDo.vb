Public Class ToDo

    Dim TaskDir As String = My.Settings.OperatorRoot & "\" & My.Settings.OperatorName & "\Operator\Note\Task"


    Private Sub ToDo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Positioner(Me, "Top-Right") ' Override where you want the form to go

        HideOnClose = False ' This changes the inherent hiding of a form to a close instead

        ReadTasks()

    End Sub

    Private Sub ReadTasks()

        Dim Tasks As ListBox = ListToDo

        For Each item In Directory.EnumerateFiles(TaskDir)

            Tasks.Items.Add(item.Remove(0, TaskDir.Length + 1))

        Next


    End Sub

    ' 
    ' JSON based - values: ID (running counter starting from 1), parent (parent ID), content (string of what to do)
    ' 
    ' GUI 'add' button
    ' 
    ' Every item can have a parent
    ' Default parent is root
    ' 
    ' Default Categories are weekly, each day i.e mon, tue, wed...
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 
    ' 

End Class