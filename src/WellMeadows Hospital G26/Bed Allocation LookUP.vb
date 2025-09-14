Public Class Bed_Allocation_LookUP
    Private Sub BedAllocationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BedAllocationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Bed_Allocation_LookUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.BedAllocations' table. You can move, or remove it, as needed.
        Me.BedAllocationsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.BedAllocations)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.BedAllocationsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.BedAllocations, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.BedAllocationsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.BedAllocations, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class