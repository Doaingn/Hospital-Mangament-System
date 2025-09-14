Public Class userLookup
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub userLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Users)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.UsersTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Users, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox1.TextChanged
        Try
            Me.UsersTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Users, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class