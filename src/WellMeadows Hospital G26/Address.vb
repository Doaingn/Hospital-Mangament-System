Public Class AddressP
    Private Sub Address_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Addresses' table. You can move, or remove it, as needed.
        Me.AddressesTableAdapter1.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Addresses)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.AddressesTableAdapter1.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Addresses, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.AddressesTableAdapter1.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Addresses, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class