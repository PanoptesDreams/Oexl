Imports System.IO

Public Class Operators

    ' Variables
    Dim OperatorJunction As String = My.Settings.OperatorRoot & "\"
    Dim SelectedOperator As String


    Private Sub Operators_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PopulateList()




    End Sub

    ' Populate Checkbox List with Operators
    Public Sub PopulateList()


        If My.Settings.OperatorRoot <> "" Then
            OperatorJunction = My.Settings.OperatorRoot & "\"
        End If

        CheckedListBoxOperators.Items.Clear()

        If Directory.Exists(OperatorJunction) Then ' Operator Junction exists

            For Each dir As String In Directory.EnumerateDirectories(OperatorJunction) ' Check for Existing Operators in Junction

                Dim attributes As FileAttributes = File.GetAttributes(dir)

                If ((attributes And FileAttributes.Hidden) <> FileAttributes.Hidden) And ((attributes And FileAttributes.System) <> FileAttributes.System) Then ' Hidden and File System folders ignored

                    Dim folderName As String = Path.GetFileName(dir)

                    folderName = StrConv(folderName, VbStrConv.ProperCase)

                    If folderName = My.Settings.OperatorDefaultProfile Then
                        folderName = folderName & " (Default Profile)"
                    End If

                    CheckedListBoxOperators.Items.Add(folderName)

                End If

            Next

        Else ' Directory does not exist

            CheckedListBoxOperators.Items.Clear()

            MessageBox.Show("The junction " & OperatorJunction & " does not exist. You will need to create one manually.")

            Close()

        End If


    End Sub

    ' This is not functioning as intended, we know how to fix it, can't do it right now
    Private Sub ProtocolHandler()

        Dim args As String() = Environment.GetCommandLineArgs()
        Dim ArgsB As String = "oexl:"

        For i As Integer = 1 To args.Length - 1

            Select Case args(i)

                Case "op"

                    If i < args.Length - 1 Then

                        ' The next argument is the username
                        Dim username As String = args(i + 1)
                        ' Do something with the username...
                        My.Settings.OperatorName = username
                        ASave()

                    Else

                        ' The -u flag is missing the username argument
                        MsgBox("Missing -u argument")

                    End If

            End Select

        Next

    End Sub

    ' CheckBox's act like a radio button
    Private Sub CheckedListBoxOperators_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBoxOperators.SelectedIndexChanged

        Dim listBox As CheckedListBox = DirectCast(sender, CheckedListBox)
        Dim selectedIndex As Integer = listBox.SelectedIndex

        ' Uncheck all other items
        For i As Integer = 0 To listBox.Items.Count - 1
            If i <> selectedIndex Then
                listBox.SetItemChecked(i, False)
            End If
        Next

        ' Check the selected item
        If selectedIndex >= 0 AndAlso Not listBox.GetItemChecked(selectedIndex) Then
            listBox.SetItemChecked(selectedIndex, True)
        End If

        SelectedOperator = CheckedListBoxOperators.SelectedItem.ToString

    End Sub


    Private Sub ButtonAddOperator_Click(sender As Object, e As EventArgs) Handles ButtonAddOperator.Click

        If CreateOperator(InputBox("Please enter a name", "Create new Operator")) = 1 Then

            PopulateList()

        End If

    End Sub


    Private Sub ButtonSelectOperator_Click(sender As Object, e As EventArgs) Handles ButtonSelectOperator.Click

        ActivateOperator()

        Summon(Launcher)

        Application.Restart()

    End Sub

    ' Activate Operator and Start Launcher
    Public Sub ActivateOperator()

        Dim strSuffix As String = " (Default Profile)"

        If SelectedOperator.EndsWith(strSuffix) Then
            SelectedOperator = SelectedOperator.Remove(SelectedOperator.Length - strSuffix.Length)
        End If

        My.Settings.OperatorName = SelectedOperator

        SelectedOperator = StrConv(SelectedOperator, VbStrConv.ProperCase)

        CloseOtherForms(Me)


    End Sub


    Private Sub CloseOtherForms(ByVal currentForm As Form)
        Dim formsToClose As New List(Of Form)

        For Each form As Form In Application.OpenForms
            If form IsNot currentForm Then
                formsToClose.Add(form)
            End If
        Next

        For Each form As Form In formsToClose
            form.Close()
        Next
    End Sub

    Private Sub ButtonSetDefaultOperator_Click(sender As Object, e As EventArgs) Handles ButtonSetDefaultOperator.Click

        If SelectedOperator.EndsWith(" (Default Profile)") Then
            MsgBox("Profile is already set to default")
            Return
        End If

        My.Settings.OperatorDefaultProfile = CheckedListBoxOperators.SelectedItem.ToString

        PopulateList()

    End Sub

    Private Sub ButtonClearDefaultOperator_Click(sender As Object, e As EventArgs) Handles ButtonClearDefaultOperator.Click

        My.Settings.OperatorDefaultProfile = ""
        PopulateList()

    End Sub

    Private Sub ButtonSetJunction_Click(sender As Object, e As EventArgs) Handles ButtonSetJunction.Click

        SetJunctionPath()

        PopulateList()

    End Sub

    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles RoundedButton1.Click


        For Each item In Environment.GetCommandLineArgs

            CheckedListBoxOperators.Items.Add(item)

        Next

    End Sub




End Class
