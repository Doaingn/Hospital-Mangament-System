Public Class Surgical_Requi

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Surgireq_detail.Show()
    End Sub

    Private Sub Cli_LU_Click(sender As Object, e As EventArgs) Handles Cli_LU.Click
        Clinic_LookUp.Show()
    End Sub

    Private Sub W_LU_Click(sender As Object, e As EventArgs) Handles W_LU.Click
        Ward_LookUp.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        SurgicalIDLookup.Show()
    End Sub
End Class