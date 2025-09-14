Public Class Patient_Medication_Form

    Private Sub Patient_Medication_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Medication_Head' table. You can move, or remove it, as needed.
        Me.Medication_HeadTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Medication_Head)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Medication_Details' table. You can move, or remove it, as needed.
        Me.Medication_DetailsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Medication_Details)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Staff_LookUp.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Patient_Lookup.Show()
    End Sub

    Private Sub Pharma_LU_Click(sender As Object, e As EventArgs) Handles Pharma_LU.Click
        Ward_LookUp.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clinic_LookUp.Show()
    End Sub

    Private Sub Medication_DetailsDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Phamarcetical_Lookup.Show()
    End Sub

    Private Sub Medication_HeadBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles Medication_HeadBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Medication_HeadBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.Click
        Me.Validate()
        Me.Medication_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Medication_HeadTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Medication_Head)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Medication_HeadTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Medication_Head, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.Medication_HeadTableAdapter.FillBy1(Me.SQLEXPRESS_DatabaseG26DataSet.Medication_Head, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.Medication_DetailsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Medication_Details, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox1.TextChanged
        Try
            Me.Medication_DetailsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Medication_Details, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class