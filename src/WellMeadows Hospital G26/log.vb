Imports System.Data.SqlClient

Public Class log
    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader
        con.ConnectionString = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"

        'con.ConnectionString = "Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"

        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT username, password FROM Users WHERE username = @username AND password = @password"
        cmd.Parameters.AddWithValue("@username", txtuser.Text)
        cmd.Parameters.AddWithValue("@password", txtpass.Text)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            rd.Read()
            Dim mainMenu As New MainMenu()
            mainMenu.LoggedInUsers = rd("username").ToString()
            mainMenu.Show()
            Me.Hide()
        Else
            MessageBox.Show("User or password fail")
        End If
        con.Close()
    End Sub

    Private Sub log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        preloaduser()
    End Sub

    Private Sub preloaduser()
        ' Add any preloading logic here
    End Sub

    Private Sub log_Load_1()

    End Sub
End Class