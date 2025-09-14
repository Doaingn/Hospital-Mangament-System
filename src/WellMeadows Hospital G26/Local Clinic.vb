Public Class Local_Clinic
    Private Sub Local_ClinicsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Local_ClinicsBindingNavigatorSaveItem.Click, Local_ClinicsBindingNavigatorSaveItem.Click, Local_ClinicsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Local_ClinicsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet)

    End Sub

    Private Sub Local_Clinic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet.Local_Clinics' table. You can move, or remove it, as needed.
        Me.Local_ClinicsTableAdapter.Fill(Me.DatabaseG26DataSet.Local_Clinics)

    End Sub
End Class