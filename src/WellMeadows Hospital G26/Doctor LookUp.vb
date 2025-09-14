Public Class Doctor_LookUp
    Private Sub Local_DoctorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Local_DoctorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Doctor_LookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Local_Doctors' table. You can move, or remove it, as needed.
        Me.Local_DoctorsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Local_Doctors)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Local_DoctorsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Local_Doctors, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.Local_DoctorsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Local_Doctors, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class