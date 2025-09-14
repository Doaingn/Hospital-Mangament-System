Public Class DrugRequisitionForm


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Phamarcetical_Lookup.Show()
    End Sub

    Private Sub Cli_LU_Click(sender As Object, e As EventArgs) Handles Cli_LU.Click
        Clinic_LookUp.Show()
    End Sub

    Private Sub W_LU_Click(sender As Object, e As EventArgs) Handles W_LU.Click
        Ward_LookUp.Show()
    End Sub

    Private Sub DrugRequisitionBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DrugRequisitionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DrugRequisitionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub DrugRequisitionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.DrugReq_Details' table. You can move, or remove it, as needed.
        Me.DrugReq_DetailsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.DrugReq_Details)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.DrugRequisition' table. You can move, or remove it, as needed.
        Me.DrugRequisitionTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.DrugRequisition)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.DrugRequisitionTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.DrugRequisition, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.DrugRequisitionTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.DrugRequisition, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.DrugReq_DetailsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.DrugReq_Details, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox1.TextChanged
        Try
            Me.DrugReq_DetailsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.DrugReq_Details, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.Click
        Me.Validate()
        Me.DrugReq_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub Requisition_byLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Staff_LookUp.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Staff_LookUp.Show()

    End Sub
End Class