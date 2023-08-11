Imports System.Management

Public Class SystemStats


    Private Sub SystemStats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetCPUArch()

        GetCPUInstructions()

    End Sub

    Private Sub GetCPUArch()


        Dim cpuArch As String = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE")
        LabelProcessARCH.Text = "CPU Architecture: " & cpuArch


    End Sub


    Private Sub GetCPUInstructions()

        Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_Processor")
        Dim instructionSetArray As New List(Of String)
        For Each queryObj As ManagementObject In searcher.Get()
            instructionSetArray.Add(queryObj("InstructionSet").ToString())
        Next

        LabelProcessInstructions.Text = ""

        For Each item In instructionSetArray

            LabelProcessInstructions.Text.Append(item & ", ")

        Next




    End Sub
End Class