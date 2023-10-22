Public Class ToDo

    Private Sub ToDo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Positioner(Me, "Center") ' Override where you want the form to go

        HideOnClose = False ' This changes the inherent hiding of a form to a close instead

        ReadTasks()

    End Sub

    Private Sub ReadTasks()

        Dim TaskDir As String = "O:\Operator\Task"
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
    ' 

End Class