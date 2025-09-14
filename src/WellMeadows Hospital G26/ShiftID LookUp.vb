Public Class ShiftID_LookUp

    Private Sub ShiftID_LookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Shifts' table. You can move, or remove it, as needed.
        Me.ShiftsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Shifts)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet2.Shifts' table. You can move, or remove it, as needed.


    End Sub

    Private Sub FillByToolStripButton_Click_2(sender As Object, e As EventArgs)
        Try
            Me.ShiftsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Shifts, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.ShiftsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Shifts, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class