Public Class User
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigator.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Users)

    End Sub
End Class