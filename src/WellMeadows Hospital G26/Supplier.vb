Public Class Supplier
    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SuppliersBindingNavigator.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Suppliers)

    End Sub

    Private Sub PhoneNumLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SuppliersTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Suppliers, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.SuppliersTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Suppliers, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class