Public Class Staff_LookUp

    Private Sub Staff_LookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs)

    End Sub


    Private Sub StaffsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.StaffsTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.StaffsTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class