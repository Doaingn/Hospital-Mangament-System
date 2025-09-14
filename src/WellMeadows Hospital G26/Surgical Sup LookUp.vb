Public Class Surgical_Sup_LookUp
    Private Sub Surgical_Sup_LookUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Surgical_Supplies' table. You can move, or remove it, as needed.
        Me.Surgical_SuppliesTableAdapter1.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Surgical_Supplies)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Surgical_SuppliesTableAdapter1.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Surgical_Supplies, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.Surgical_SuppliesTableAdapter1.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Surgical_Supplies, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class