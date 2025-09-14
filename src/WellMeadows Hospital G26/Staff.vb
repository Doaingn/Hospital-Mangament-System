Imports System.Diagnostics.Contracts
Imports WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters
Imports System.Data.SqlClient

Public Class Staff
    Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
    Private Sub StaffsNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StaffsBindingNavigator.Click
        Me.Validate()
        Me.StaffsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        SearchT.Show()
    End Sub


    Private Sub Staff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Staffs' table. You can move, or remove it, as needed.
        Me.StaffsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet.Staffs' table. You can move, or remove it, as needed.

    End Sub

    Private Sub BtnQual_Click(sender As Object, e As EventArgs)
        Qualification.Show()
    End Sub

    Private Sub BtnAd_Click(sender As Object, e As EventArgs)
        AddressP.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        EmployeeContract.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Experience.Show()
    End Sub

    Private Sub BtnWEx_Click(sender As Object, e As EventArgs)
        User.Show()
    End Sub

    Private Sub UserBtn_Click(sender As Object, e As EventArgs) Handles UserBtn.Click
        User.Show()
    End Sub

    Private Sub AddrBtn_Click(sender As Object, e As EventArgs) Handles AddrBtn.Click
        AddressP.Show()
    End Sub

    Private Sub Contractbtn_Click(sender As Object, e As EventArgs) Handles Contractbtn.Click
        EmployeeContract.Show()
    End Sub

    Private Sub WEXSBtn_Click(sender As Object, e As EventArgs) Handles WEXSBtn.Click
        Experience.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Qualification.Show()
    End Sub



    Private Sub DOC_LU_Click(sender As Object, e As EventArgs) Handles DOC_LU.Click
        userLookup.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Address_LookUp.Show()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.StaffsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Param1ToolStripTextBox_TextChanged(sender As Object, e As EventArgs) Handles Param1ToolStripTextBox1.TextChanged
        Try
            Me.StaffsTableAdapter.FillBy(Me.SQLEXPRESS_DatabaseG26DataSet.Staffs, Param1ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private connectionString1 As String

    ' Constructor to initialize connectionString
    Public Sub New(connStr As String)
        InitializeComponent()
        connectionString1 = connStr
    End Sub

    ' Default constructor for designer support
    Public Sub New()
        InitializeComponent()
    End Sub

    ' Use connectionString for your database operations
    Private Sub LoadStaffData()
        Using connection As New SqlConnection(connectionString1)
            ' Your code to load staff data
        End Using
    End Sub

End Class


