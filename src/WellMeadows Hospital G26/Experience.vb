Public Class Experience
    Private Sub Work_ExperienceBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Work_ExperienceBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Work_ExperienceBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Experience_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Work_Experience' table. You can move, or remove it, as needed.
        Me.Work_ExperienceTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Work_Experience)

    End Sub

    Private Sub S_LU_Click(sender As Object, e As EventArgs) Handles S_LU.Click
        Staff_LookUp.Show()
    End Sub
End Class