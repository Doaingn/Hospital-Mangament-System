Public Class Medication_Head
    Private Sub Medication_HeadBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Medication_HeadBindingNavigatorSaveItem.Click, Medication_HeadBindingNavigatorSaveItem.Click, Medication_HeadBindingNavigatorSaveItem.Click, Medication_HeadBindingNavigatorSaveItem.Click, Medication_HeadBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Medication_HeadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet2)

    End Sub

    Private Sub Medication_Head_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet2.Medication_Head' table. You can move, or remove it, as needed.
        Me.Medication_HeadTableAdapter.Fill(Me.DatabaseG26DataSet2.Medication_Head)

    End Sub

    Private Sub Medic_detail_Click(sender As Object, e As EventArgs) Handles Medic_detail.Click
        Medication_Details.Show()
    End Sub

    Private Sub SHeadLB_Click(sender As Object, e As EventArgs) Handles SHeadLB.Click

    End Sub

    Private Sub S_LU_Click(sender As Object, e As EventArgs) Handles S_LU.Click
        Staff_LookUp.ShowDialog()
    End Sub

    Private Sub P_LU_Click(sender As Object, e As EventArgs) Handles P_LU.Click
        Patient_Lookup.Show()
    End Sub

    Private Sub W_LU_Click(sender As Object, e As EventArgs) Handles W_LU.Click
        Ward_LookUp.Show()
    End Sub

    Private Sub Cli_LU_Click(sender As Object, e As EventArgs) Handles Cli_LU.Click
        Clinic_LookUp.Show()
    End Sub
End Class