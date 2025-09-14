Imports System.Data.SqlClient
Public Class SearchT
    Dim Connection As New SqlConnection("Data Source=DESKTOP-1NO20T3\CHANAD;Initial Catalog=DatabaseG26;Integrated Security=True;")

    Private Sub SearchT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FillterData("")
    End Sub

    Public Sub FillterData(ValuToSearch As String)
        Dim searchQuery As String = "SELECT * FROM Work_Experience we ,Qualifications q,Staffs s WHERE s.S_Num = we.S_Num AND q.S_Num = s.S_Num AND (we.Organization LIKE @search OR q.Name LIKE @search OR s.First_name LIKE @search)"

        Dim Command As New SqlCommand(searchQuery, Connection)
        Command.Parameters.AddWithValue("@search", "%" & ValuToSearch & "%")

        Dim adapter As New SqlDataAdapter(Command)
        Dim table As New DataTable()

        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FillterData(InputSearch.Text)
    End Sub

    Private Sub InputSearch_TextChanged(sender As Object, e As EventArgs) Handles InputSearch.TextChanged
        FillterData(InputSearch.Text)
    End Sub
End Class