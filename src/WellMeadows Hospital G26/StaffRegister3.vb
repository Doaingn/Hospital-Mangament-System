Imports System.Data.SqlClient

Public Class StaffRegister3
    Private Sub Employment_ContractsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Employment_ContractsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SQLEXPRESS_DatabaseG26DataSet)

    End Sub

    Private Sub StaffRegister3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseG26DataSet9.GetNextContractID' table. You can move, or remove it, as needed.
        Me.GetNextContractIDTableAdapter.Fill(Me.DatabaseG26DataSet9.GetNextContractID)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet9.GetNextWexID' table. You can move, or remove it, as needed.
        Me.GetNextWexIDTableAdapter.Fill(Me.DatabaseG26DataSet9.GetNextWexID)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet9.GetNextQualificationID' table. You can move, or remove it, as needed.
        Me.GetNextQualificationIDTableAdapter.Fill(Me.DatabaseG26DataSet9.GetNextQualificationID)
        'TODO: This line of code loads data into the 'DatabaseG26DataSet9.GetLatestSNum' table. You can move, or remove it, as needed.
        Me.GetLatestSNumTableAdapter.Fill(Me.DatabaseG26DataSet9.GetLatestSNum)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Work_Experience' table. You can move, or remove it, as needed.
        'Me.Work_ExperienceTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Work_Experience)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Qualifications' table. You can move, or remove it, as needed.
        'Me.QualificationsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Qualifications)
        'TODO: This line of code loads data into the 'SQLEXPRESS_DatabaseG26DataSet.Employment_Contracts' table. You can move, or remove it, as needed.
        'Me.Employment_ContractsTableAdapter.Fill(Me.SQLEXPRESS_DatabaseG26DataSet.Employment_Contracts)

    End Sub
    Private Function GetLatestSNum() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim latestSNum As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("GetLatestSNum", connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    latestSNum = reader("S_Num").ToString()
                End If
            End Using
        End Using

        Return latestSNum
    End Function

    Private Function GetNextQualificationID() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim nextQualificationID As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("GetNextQualificationID", connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    nextQualificationID = reader("NextQualificationID").ToString()
                End If
            End Using
        End Using

        Return nextQualificationID
    End Function

    Private Function GetNextWexID() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim nextWexID As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("GetNextWexID", connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    nextWexID = reader("NextWexID").ToString()
                End If
            End Using
        End Using

        Return nextWexID
    End Function

    Private Function GetNextContractID() As String
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim nextContractID As String = ""

        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Dim command As New SqlCommand("GetNextContractID", connection)
            command.CommandType = CommandType.StoredProcedure

            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    nextContractID = reader("NextContractID").ToString()
                End If
            End Using
        End Using

        Return nextContractID
    End Function

    Private Sub SaveData()
        Dim connectionString As String = "Data Source=localhost\SQLEXPRESS;Initial Catalog=DatabaseG26;Integrated Security=True;"
        Dim newQualificationID As String = GetNextQualificationID()
        Dim newWexID As String = GetNextWexID()
        Dim newContractID As String = GetNextContractID()
        Dim latestStaffID As String = GetLatestSNum()

        ' ตั้งค่า TextBox ของ S_Num
        S_NumTextBox1.Text = latestStaffID
        S_NumTextBox.Text = latestStaffID
        S_NumTextBox3.Text = latestStaffID

        Using connection As New SqlConnection(connectionString)
            connection.Open()

            ' คำสั่ง SQL สำหรับการบันทึกข้อมูล Work_Experience
            Dim workExperienceSql As String = "
        INSERT INTO Work_Experience (Wex_ID, Organization, Position, Start_Date, End_Date, S_Num) 
        VALUES (@Wex_ID, @Organization, @Position, @Start_Date, @End_Date, @S_Num);"

            ' คำสั่ง SQL สำหรับการบันทึกข้อมูล Qualifications
            Dim qualificationsSql As String = "
        INSERT INTO Qualifications (Qualification_ID, Name, Institution, Date_of_Qualification, S_Num) 
        VALUES (@Qualification_ID, @Name, @Institution, @Date_of_Qualification, @S_Num);"

            ' คำสั่ง SQL สำหรับการบันทึกข้อมูล Employment_Contracts
            Dim employmentContractsSql As String = "
        INSERT INTO Employment_Contracts (Contract_ID, Hours_Worked_per_Week, Contract_Type, Salary_Payment_Type, S_Num) 
        VALUES (@Contract_ID, @Hours_Worked_per_Week, @Contract_Type, @Salary_Payment_Type, @S_Num);"

            ' กำหนดพารามิเตอร์ของ Work_Experience
            Dim workExperienceCommand As New SqlCommand(workExperienceSql, connection)
            workExperienceCommand.Parameters.AddWithValue("@Wex_ID", newWexID)
            workExperienceCommand.Parameters.AddWithValue("@Organization", OrganizationTextBox.Text)
            workExperienceCommand.Parameters.AddWithValue("@Position", PositionTextBox.Text)
            workExperienceCommand.Parameters.AddWithValue("@Start_Date", Start_DateDateTimePicker.Value)
            workExperienceCommand.Parameters.AddWithValue("@End_Date", End_DateDateTimePicker.Value)
            workExperienceCommand.Parameters.AddWithValue("@S_Num", latestStaffID)

            ' กำหนดพารามิเตอร์ของ Qualifications
            Dim qualificationsCommand As New SqlCommand(qualificationsSql, connection)
            qualificationsCommand.Parameters.AddWithValue("@Qualification_ID", newQualificationID)
            qualificationsCommand.Parameters.AddWithValue("@Name", NameTextBox.Text)
            qualificationsCommand.Parameters.AddWithValue("@Institution", InstitutionTextBox.Text)
            qualificationsCommand.Parameters.AddWithValue("@Date_of_Qualification", Date_of_QualificationDateTimePicker.Value)
            qualificationsCommand.Parameters.AddWithValue("@S_Num", latestStaffID)

            ' กำหนดพารามิเตอร์ของ Employment_Contracts
            Dim employmentContractsCommand As New SqlCommand(employmentContractsSql, connection)
            employmentContractsCommand.Parameters.AddWithValue("@Contract_ID", newContractID)
            employmentContractsCommand.Parameters.AddWithValue("@Hours_Worked_per_Week", Hours_Worked_per_WeekTextBox.Text)
            employmentContractsCommand.Parameters.AddWithValue("@Contract_Type", Contract_TypeComboBox.Text)
            employmentContractsCommand.Parameters.AddWithValue("@Salary_Payment_Type", Salary_Payment_TypeComboBox.Text)
            employmentContractsCommand.Parameters.AddWithValue("@S_Num", latestStaffID)

            Try
                workExperienceCommand.ExecuteNonQuery()
                qualificationsCommand.ExecuteNonQuery()
                employmentContractsCommand.ExecuteNonQuery()
                MessageBox.Show("Registration completed!")
                Me.Hide()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        SaveData()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Contract_IDTextBox.ReadOnly = True
        Qualification_IDTextBox.ReadOnly = True
        Wex_IDTextBox.ReadOnly = True
        S_NumTextBox3.Hide()
        S_NumTextBox2.Hide()
        S_NumTextBox1.Hide()
        S_NumTextBox.Hide()
    End Sub
End Class