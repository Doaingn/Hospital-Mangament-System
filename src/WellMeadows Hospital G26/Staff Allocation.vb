
Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Staff_Allocation
    Dim connectionString As String = "Data Source=DESKTOP-1NO20T3\CHANAD;Initial Catalog=DatabaseG26;Integrated Security=True"

    Private Sub Staff_Allocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSetView.Staff_Allocation_View' table. You can move, or remove it, as needed.
        Me.Staff_Allocation_ViewTableAdapter.Fill(Me.DatabaseG26DataSetView.Staff_Allocation_View)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class

'Dim sqlDataAdapter = New SqlDataAdapter("SELECT * FROM Staff_Allocation_View", connectionString)
'Dim dataSet As DataSet = New DataSet()
'sqlDataAdapter.Fill(dataSet)

'Dim rprtDS1 = New ReportDataSource("StaffAllocationReportDataSet", dataSet.Tables.Item(0))
'ReportViewer1.LocalReport.DataSources.Add(rprtDS1)