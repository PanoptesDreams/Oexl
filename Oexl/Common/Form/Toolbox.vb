﻿Public Class Toolbox


    Private Sub Toolbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Positioner(Me, "Left")

        toggleHide = False ' Close don't hide


    End Sub


    Private Sub ButtonAddFont_Click(sender As Object, e As EventArgs) Handles ButtonAddFont.Click

        InstallFontFromFile()

    End Sub


    Private Sub RoundedButton1_Click(sender As Object, e As EventArgs) Handles ButtonRenameSystem.Click

        RenameSystem(InputBox("Please enter a name", "Name System"))

    End Sub


    Private Sub ButtonAddOperator_Click(sender As Object, e As EventArgs) Handles ButtonAddOperator.Click

        CreateOperator(InputBox("Please enter a name", "Create new Operator"))

    End Sub

    Private Sub ButtonBuildOperatorTree_Click(sender As Object, e As EventArgs) Handles ButtonBuildOperatorTree.Click

        BuildOperatorTree(InputBox("Please enter an existing Operator", "Build Operator tree"))

    End Sub

    Private Sub ButtonWingetInstall_Click(sender As Object, e As EventArgs) Handles ButtonWingetInstall.Click

        Summon(WingetInstaller)

    End Sub

    Private Sub ButtonAlcoholCalc_Click(sender As Object, e As EventArgs) Handles ButtonAlcoholCalc.Click

        Summon(AlcoholCalulator)

    End Sub

    Private Sub ButtonNotes_Click(sender As Object, e As EventArgs) Handles ButtonNotes.Click

        Summon(Notes)

    End Sub

    Private Sub ButtonToolbox_Click(sender As Object, e As EventArgs) Handles ButtonSettings.Click

        Summon(Settings)

    End Sub
End Class