Imports System.IO

Public Class Launcher


    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        OperatorLoader()

        PositionElements()

        Positioner(Me, "Top")

    End Sub

    ' Operator Loader
    Public Sub OperatorLoader()

        LabelGreeting.Text = Greeting() ' Greet the Operator

        LabelOperatorName.Text = My.Settings.OperatorName ' Retrieve name

        Dim OperatorPicture As Image

        Try ' Loading Operator image from the default path

            OperatorPicture = Image.FromFile(Path.Combine(My.Settings.OperatorJunction & "\" & My.Settings.OperatorName & "\Operator\avatar.png"))

        Catch ex As Exception ' Insert default image instead

            OperatorPicture = My.Resources.operator_default

        End Try

        PictureBoxOperator.Image = ResizeImage(OperatorPicture, PictureBoxOperator.Width, PictureBoxOperator.Height) ' Resize imported image and apply


    End Sub

    Private Sub PositionElements()

        PictureBoxOperator.Location = New Point(Me.Width / 2 - PictureBoxOperator.Width / 2, Me.Height / 2 - PictureBoxOperator.Height / 2) ' fix

    End Sub

    Private Sub LabelOperatorName_Click(sender As Object, e As EventArgs) Handles LabelOperatorName.Click

        Summon(Operators)

    End Sub
End Class