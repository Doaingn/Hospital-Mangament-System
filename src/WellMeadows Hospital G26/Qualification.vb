Public Class Qualification

    Private Sub S_LU_Click(sender As Object, e As EventArgs) Handles S_LU.Click
        Staff_LookUp.Show()
    End Sub

    Private Sub QualificationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles QualificationsBindingNavigator.Click
        Me.Validate()
        Me.QualificationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Qualification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Qualifications' table. You can move, or remove it, as needed.
        Me.QualificationsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Qualifications)

    End Sub
End Class