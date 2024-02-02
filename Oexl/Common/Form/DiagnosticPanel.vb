Public Class DiagnosticPanel



    Private Sub DiagnosticPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelDiagnosticPositionResult.Text = ParentForm.Location.ToString()

        LabelDiagnosticWidthResult.Text = ParentForm.Width.ToString()

        LabelDiagnosticHeightResult.Text = ParentForm.Height.ToString()

    End Sub


End Class