Public Class Arguments

    Private Sub Arguments_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Positioner(Me, "Bottom-Left") ' Override where you want the form to go

        HideOnClose = False ' This changes the inherent hiding of a form to a close instead

        For Each item In Environment.GetCommandLineArgs

            ListBoxArguments.Items.Add(item)

        Next

        Dim g As Graphics = ListBoxArguments.CreateGraphics()
        Dim maxWidth As Integer = 0

        For Each s As String In ListBoxArguments.Items

            Dim w As Integer = CInt(g.MeasureString(s, ListBoxArguments.Font).Width)

            If w > maxWidth Then
                maxWidth = w
            End If

        Next

        Me.Width = maxWidth + 100

    End Sub

End Class