Public Class AlcoholCalulator

    ' Declare variables
    Dim Volume As Double ' as liters
    Dim Percentage As Double ' as percentage
    Dim AlcoholContent As Double
    Const AlcoholDensity As Double = 0.789 ' approx. density of alcohol in g/ml at room temperature


    Private Sub AlcoholCalulator_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub


    Private Sub CalulateStandardDrinks()

        Try

            Volume = TextBoxVolume.Text

            Percentage = TextBoxPercentage.Text

            AlcoholContent = Volume * Percentage * AlcoholDensity

            LabelDrinks.Text = "Approximate number of standard drinks: " & AlcoholContent.ToString

            LabelError.Text = ""

        Catch ex As Exception

            LabelDrinks.Text = ""

            LabelError.Text = "Enter valid values"

        End Try

    End Sub

    Private Sub TextBoxVolume_TextChanged(sender As Object, e As EventArgs) Handles TextBoxVolume.TextChanged

        CalulateStandardDrinks()

    End Sub

    Private Sub TextBoxPercentage_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPercentage.TextChanged

        CalulateStandardDrinks()

    End Sub

End Class