Public Class Ward_LookUp
    Private Sub Ward_LookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Wards' table. You can move, or remove it, as needed.
        Me.WardsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Wards)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet2.Wards' table. You can move, or remove it, as needed.


    End Sub

End Class