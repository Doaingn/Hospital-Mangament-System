Public Class Phamarcetical_Lookup


    Private Sub Phamarcetical_Lookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Pharmaceutical_Supplies' table. You can move, or remove it, as needed.
        Me.Pharmaceutical_SuppliesTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Pharmaceutical_Supplies)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet2.Pharmaceutical_Supplies' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Pharmaceutical_SuppliesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Pharmaceutical_SuppliesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.Pharmaceutical_SuppliesTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Pharmaceutical_Supplies, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.Pharmaceutical_SuppliesTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Pharmaceutical_Supplies, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class