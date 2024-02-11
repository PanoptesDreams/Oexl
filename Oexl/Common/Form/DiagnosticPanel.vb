Public Class DiagnosticPanel



    Private Sub DiagnosticPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ParentalForm As Form = FindForm()

        LabelDiagnosticPositionResult.Text = ParentalForm.Location.ToString()

        LabelDiagnosticWidthResult.Text = ParentalForm.Width.ToString()

        LabelDiagnosticHeightResult.Text = ParentalForm.Height.ToString()

    End Sub


End Class