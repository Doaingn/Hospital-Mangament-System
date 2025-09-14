Public Class DrugReqLookup
    Private Sub DrugReqLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.DrugRequisition' table. You can move, or remove it, as needed.
        Me.DrugRequisitionTableAdapter1.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.DrugRequisition)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.DrugRequisitionTableAdapter1.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.DrugRequisition, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.DrugRequisitionTableAdapter1.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.DrugRequisition, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class