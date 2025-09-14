Public Class local_doctor
    Private Sub Local_DoctorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Local_DoctorsBindingNavigatorSaveItem.Click, Local_DoctorsBindingNavigatorSaveItem.Click, Local_DoctorsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Local_DoctorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseG26DataSet)

    End Sub

    Private Sub local_doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet.Local_Doctors' table. You can move, or remove it, as needed.
        Me.Local_DoctorsTableAdapter.Fill(Me.DatabaseG26DataSet.Local_Doctors)

    End Sub

    Private Sub Add_LU_Click(sender As Object, e As EventArgs) Handles Add_LU.Click
        Clinic_LookUp.Show()
    End Sub
End Class