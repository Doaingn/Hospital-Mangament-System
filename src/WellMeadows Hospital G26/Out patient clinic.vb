Public Class Out_patient_clinic
    Private Sub Outpatient_ClinicsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Outpatient_ClinicsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Outpatient_ClinicsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet)

    End Sub

    Private Sub Out_patient_clinic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet.Outpatient_Clinics' table. You can move, or remove it, as needed.
        Me.Outpatient_ClinicsTableAdapter.Fill(Me.DatabaseG26DataSet.Outpatient_Clinics)

    End Sub
End Class