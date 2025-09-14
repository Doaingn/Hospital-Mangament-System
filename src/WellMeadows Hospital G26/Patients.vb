Imports Microsoft.Reporting.Map.WebForms.BingMaps

Public Class Patients
    Private Sub BindingNavigator1SaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigator1.Click
        Me.Validate()
        Me.PatientsBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)
    End Sub
    Private Sub Patients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Patients' table. You can move, or remove it, as needed.
        Me.PatientsTableAdapter1.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Patients)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet.Patients' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Add_LU_Click(sender As Object, e As EventArgs) Handles Add_LU.Click
        Address_LookUp.Show()
    End Sub

    Private Sub DOC_LU_Click(sender As Object, e As EventArgs) Handles DOC_LU.Click
        Doctor_LookUp.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Address.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Patient_next_of_kin.Show()
    End Sub

    Private Sub NOKbtn_Click(sender As Object, e As EventArgs) Handles NOKbtn.Click
        Patient_next_of_kin.Show()
    End Sub

    Private Sub Address_Click(sender As Object, e As EventArgs) Handles Address.Click
        AddressP.Show()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.PatientsTableAdapter1.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Patients, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox.TextChanged
        Try
            Me.PatientsTableAdapter1.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Patients, Param1ToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class