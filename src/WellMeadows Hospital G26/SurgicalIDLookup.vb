Public Class SurgicalIDLookup


    Private Sub Staffbtn_Click(sender As Object, e As EventArgs) Handles Staffbtn.Click
        Staff_LookUp.Show()
    End Sub

    Private Sub SurgicalRequisitionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.SurgicalRequisitionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub SurgicalIDLookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.SurgicalRequisition' table. You can move, or remove it, as needed.
        Me.SurgicalRequisitionTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.SurgicalRequisition)

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SurgicalRequisitionTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.SurgicalRequisition, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.SurgicalRequisitionTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.SurgicalRequisition, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class