Public Class TemplateForm

    ' This is the Template Form
    ' It has everything you SHOULD be doing to properly initialize and handle a rounded form
    ' Most handling is done in the RoundedForm, so if you want sweeping changes, go there
    ' This is for tweaking each unique butterfly

    ' Do not directly copy the file, individually copy parts you need.


    Private Sub TemplateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Positioner(Me, "Center") ' Override where you want the form to go

        HideOnClose = False ' This changes the inherent hiding of a form to a close instead

    End Sub


End Class