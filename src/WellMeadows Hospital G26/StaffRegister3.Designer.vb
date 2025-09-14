<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffRegister3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Contract_IDLabel As System.Windows.Forms.Label
        Dim Hours_Worked_per_WeekLabel As System.Windows.Forms.Label
        Dim Qualification_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim InstitutionLabel As System.Windows.Forms.Label
        Dim Date_of_QualificationLabel As System.Windows.Forms.Label
        Dim Wex_IDLabel As System.Windows.Forms.Label
        Dim OrganizationLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim Start_DateLabel As System.Windows.Forms.Label
        Dim End_DateLabel As System.Windows.Forms.Label
        Dim Salary_Payment_TypeLabel1 As System.Windows.Forms.Label
        Dim Contract_TypeLabel1 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.Employment_ContractsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employment_ContractsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Employment_ContractsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.QualificationsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.QualificationsTableAdapter()
        Me.Work_ExperienceTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Work_ExperienceTableAdapter()
        Me.Hours_Worked_per_WeekTextBox = New System.Windows.Forms.TextBox()
        Me.S_NumTextBox = New System.Windows.Forms.TextBox()
        Me.QualificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.InstitutionTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_QualificationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Work_ExperienceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrganizationTextBox = New System.Windows.Forms.TextBox()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Start_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.End_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.S_NumTextBox2 = New System.Windows.Forms.TextBox()
        Me.Salary_Payment_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Contract_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.DatabaseG26DataSet9 = New WellMeadows_Hospital_G26.DatabaseG26DataSet9()
        Me.GetLatestSNumBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetLatestSNumTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet9TableAdapters.GetLatestSNumTableAdapter()
        Me.TableAdapterManager1 = New WellMeadows_Hospital_G26.DatabaseG26DataSet9TableAdapters.TableAdapterManager()
        Me.S_NumTextBox1 = New System.Windows.Forms.TextBox()
        Me.GetNextQualificationIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetNextQualificationIDTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet9TableAdapters.GetNextQualificationIDTableAdapter()
        Me.Qualification_IDTextBox = New System.Windows.Forms.TextBox()
        Me.GetNextWexIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetNextWexIDTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet9TableAdapters.GetNextWexIDTableAdapter()
        Me.Wex_IDTextBox = New System.Windows.Forms.TextBox()
        Me.GetNextContractIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GetNextContractIDTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet9TableAdapters.GetNextContractIDTableAdapter()
        Me.Contract_IDTextBox = New System.Windows.Forms.TextBox()
        Me.savebtn = New System.Windows.Forms.Button()
        Me.S_NumTextBox3 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.User = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Contract_IDLabel = New System.Windows.Forms.Label()
        Hours_Worked_per_WeekLabel = New System.Windows.Forms.Label()
        Qualification_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        InstitutionLabel = New System.Windows.Forms.Label()
        Date_of_QualificationLabel = New System.Windows.Forms.Label()
        Wex_IDLabel = New System.Windows.Forms.Label()
        OrganizationLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Start_DateLabel = New System.Windows.Forms.Label()
        End_DateLabel = New System.Windows.Forms.Label()
        Salary_Payment_TypeLabel1 = New System.Windows.Forms.Label()
        Contract_TypeLabel1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employment_ContractsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_ExperienceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetLatestSNumBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetNextQualificationIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetNextWexIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GetNextContractIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Contract_IDLabel
        '
        Contract_IDLabel.AutoSize = True
        Contract_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Contract_IDLabel.Location = New System.Drawing.Point(3, 0)
        Contract_IDLabel.Name = "Contract_IDLabel"
        Contract_IDLabel.Size = New System.Drawing.Size(95, 20)
        Contract_IDLabel.TabIndex = 95
        Contract_IDLabel.Text = "Contract ID:"
        '
        'Hours_Worked_per_WeekLabel
        '
        Hours_Worked_per_WeekLabel.AutoSize = True
        Hours_Worked_per_WeekLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Hours_Worked_per_WeekLabel.Location = New System.Drawing.Point(3, 34)
        Hours_Worked_per_WeekLabel.Name = "Hours_Worked_per_WeekLabel"
        Hours_Worked_per_WeekLabel.Size = New System.Drawing.Size(187, 20)
        Hours_Worked_per_WeekLabel.TabIndex = 97
        Hours_Worked_per_WeekLabel.Text = "Hours Worked per Week:"
        '
        'Qualification_IDLabel
        '
        Qualification_IDLabel.AutoSize = True
        Qualification_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Qualification_IDLabel.Location = New System.Drawing.Point(3, 0)
        Qualification_IDLabel.Name = "Qualification_IDLabel"
        Qualification_IDLabel.Size = New System.Drawing.Size(121, 20)
        Qualification_IDLabel.TabIndex = 104
        Qualification_IDLabel.Text = "Qualification ID:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        NameLabel.Location = New System.Drawing.Point(3, 34)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(55, 20)
        NameLabel.TabIndex = 106
        NameLabel.Text = "Name:"
        '
        'InstitutionLabel
        '
        InstitutionLabel.AutoSize = True
        InstitutionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        InstitutionLabel.Location = New System.Drawing.Point(3, 68)
        InstitutionLabel.Name = "InstitutionLabel"
        InstitutionLabel.Size = New System.Drawing.Size(83, 20)
        InstitutionLabel.TabIndex = 108
        InstitutionLabel.Text = "Institution:"
        '
        'Date_of_QualificationLabel
        '
        Date_of_QualificationLabel.AutoSize = True
        Date_of_QualificationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_of_QualificationLabel.Location = New System.Drawing.Point(3, 102)
        Date_of_QualificationLabel.Name = "Date_of_QualificationLabel"
        Date_of_QualificationLabel.Size = New System.Drawing.Size(157, 20)
        Date_of_QualificationLabel.TabIndex = 110
        Date_of_QualificationLabel.Text = "Date of Qualification:"
        '
        'Wex_IDLabel
        '
        Wex_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Wex_IDLabel.AutoSize = True
        Wex_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Wex_IDLabel.Location = New System.Drawing.Point(3, 6)
        Wex_IDLabel.Name = "Wex_IDLabel"
        Wex_IDLabel.Size = New System.Drawing.Size(65, 20)
        Wex_IDLabel.TabIndex = 113
        Wex_IDLabel.Text = "Wex ID:"
        '
        'OrganizationLabel
        '
        OrganizationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        OrganizationLabel.AutoSize = True
        OrganizationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        OrganizationLabel.Location = New System.Drawing.Point(3, 38)
        OrganizationLabel.Name = "OrganizationLabel"
        OrganizationLabel.Size = New System.Drawing.Size(103, 20)
        OrganizationLabel.TabIndex = 115
        OrganizationLabel.Text = "Organization:"
        '
        'PositionLabel
        '
        PositionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PositionLabel.Location = New System.Drawing.Point(3, 70)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(69, 20)
        PositionLabel.TabIndex = 117
        PositionLabel.Text = "Position:"
        '
        'Start_DateLabel
        '
        Start_DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Start_DateLabel.AutoSize = True
        Start_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Start_DateLabel.Location = New System.Drawing.Point(3, 102)
        Start_DateLabel.Name = "Start_DateLabel"
        Start_DateLabel.Size = New System.Drawing.Size(87, 20)
        Start_DateLabel.TabIndex = 119
        Start_DateLabel.Text = "Start Date:"
        '
        'End_DateLabel
        '
        End_DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        End_DateLabel.AutoSize = True
        End_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        End_DateLabel.Location = New System.Drawing.Point(3, 135)
        End_DateLabel.Name = "End_DateLabel"
        End_DateLabel.Size = New System.Drawing.Size(81, 20)
        End_DateLabel.TabIndex = 121
        End_DateLabel.Text = "End Date:"
        '
        'Salary_Payment_TypeLabel1
        '
        Salary_Payment_TypeLabel1.AutoSize = True
        Salary_Payment_TypeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Salary_Payment_TypeLabel1.Location = New System.Drawing.Point(3, 102)
        Salary_Payment_TypeLabel1.Name = "Salary_Payment_TypeLabel1"
        Salary_Payment_TypeLabel1.Size = New System.Drawing.Size(161, 20)
        Salary_Payment_TypeLabel1.TabIndex = 124
        Salary_Payment_TypeLabel1.Text = "Salary Payment Type:"
        '
        'Contract_TypeLabel1
        '
        Contract_TypeLabel1.AutoSize = True
        Contract_TypeLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Contract_TypeLabel1.Location = New System.Drawing.Point(3, 68)
        Contract_TypeLabel1.Name = "Contract_TypeLabel1"
        Contract_TypeLabel1.Size = New System.Drawing.Size(112, 20)
        Contract_TypeLabel1.TabIndex = 125
        Contract_TypeLabel1.Text = "Contract Type:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 123)
        Me.Panel1.TabIndex = 94
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(106, 37)
        Me.SHeadLB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(156, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Staff Register"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox2.Location = New System.Drawing.Point(-144, 42)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1570, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 125)
        Me.Panel2.TabIndex = 93
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources.vejq5m3sm4396c01m3etnnp4r8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(18, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 98)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(124, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Management"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(123, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Wellmeadows Hospital"
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Employment_ContractsBindingSource
        '
        Me.Employment_ContractsBindingSource.DataMember = "Employment_Contracts"
        Me.Employment_ContractsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'Employment_ContractsTableAdapter
        '
        Me.Employment_ContractsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressesTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.BedsTableAdapter = Nothing
        Me.TableAdapterManager.Clinic_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.DrugReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.DrugRequisitionTableAdapter = Nothing
        Me.TableAdapterManager.Employment_ContractsTableAdapter = Me.Employment_ContractsTableAdapter
        Me.TableAdapterManager.InpatientsTableAdapter = Nothing
        Me.TableAdapterManager.Local_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager.Local_DoctorsTableAdapter = Nothing
        Me.TableAdapterManager.Medication_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Medication_HeadTableAdapter = Nothing
        Me.TableAdapterManager.Outpatient_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager.OutpatientsTableAdapter = Nothing
        Me.TableAdapterManager.Patients_NextOfKinTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.Pharmaceutical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.QualificationsTableAdapter = Me.QualificationsTableAdapter
        Me.TableAdapterManager.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.Surgical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalRequisitionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Me.Work_ExperienceTableAdapter
        '
        'QualificationsTableAdapter
        '
        Me.QualificationsTableAdapter.ClearBeforeFill = True
        '
        'Work_ExperienceTableAdapter
        '
        Me.Work_ExperienceTableAdapter.ClearBeforeFill = True
        '
        'Hours_Worked_per_WeekTextBox
        '
        Me.Hours_Worked_per_WeekTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Hours_Worked_per_WeekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "Hours_Worked_per_Week", True))
        Me.Hours_Worked_per_WeekTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Hours_Worked_per_WeekTextBox.Location = New System.Drawing.Point(213, 38)
        Me.Hours_Worked_per_WeekTextBox.Name = "Hours_Worked_per_WeekTextBox"
        Me.Hours_Worked_per_WeekTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Hours_Worked_per_WeekTextBox.TabIndex = 98
        '
        'S_NumTextBox
        '
        Me.S_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "S_Num", True))
        Me.S_NumTextBox.Location = New System.Drawing.Point(0, 784)
        Me.S_NumTextBox.Name = "S_NumTextBox"
        Me.S_NumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.S_NumTextBox.TabIndex = 104
        '
        'QualificationsBindingSource
        '
        Me.QualificationsBindingSource.DataMember = "Qualifications"
        Me.QualificationsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationsBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(210, 37)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NameTextBox.TabIndex = 107
        '
        'InstitutionTextBox
        '
        Me.InstitutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationsBindingSource, "Institution", True))
        Me.InstitutionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.InstitutionTextBox.Location = New System.Drawing.Point(210, 71)
        Me.InstitutionTextBox.Name = "InstitutionTextBox"
        Me.InstitutionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.InstitutionTextBox.TabIndex = 109
        '
        'Date_of_QualificationDateTimePicker
        '
        Me.Date_of_QualificationDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QualificationsBindingSource, "Date_of_Qualification", True))
        Me.Date_of_QualificationDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_of_QualificationDateTimePicker.Location = New System.Drawing.Point(210, 105)
        Me.Date_of_QualificationDateTimePicker.Name = "Date_of_QualificationDateTimePicker"
        Me.Date_of_QualificationDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Date_of_QualificationDateTimePicker.TabIndex = 111
        '
        'Work_ExperienceBindingSource
        '
        Me.Work_ExperienceBindingSource.DataMember = "Work_Experience"
        Me.Work_ExperienceBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'OrganizationTextBox
        '
        Me.OrganizationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.OrganizationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "Organization", True))
        Me.OrganizationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OrganizationTextBox.Location = New System.Drawing.Point(213, 35)
        Me.OrganizationTextBox.Name = "OrganizationTextBox"
        Me.OrganizationTextBox.Size = New System.Drawing.Size(200, 26)
        Me.OrganizationTextBox.TabIndex = 116
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "Position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PositionTextBox.Location = New System.Drawing.Point(213, 67)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PositionTextBox.TabIndex = 118
        '
        'Start_DateDateTimePicker
        '
        Me.Start_DateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Start_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Work_ExperienceBindingSource, "Start_Date", True))
        Me.Start_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Start_DateDateTimePicker.Location = New System.Drawing.Point(213, 99)
        Me.Start_DateDateTimePicker.Name = "Start_DateDateTimePicker"
        Me.Start_DateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Start_DateDateTimePicker.TabIndex = 120
        '
        'End_DateDateTimePicker
        '
        Me.End_DateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.End_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Work_ExperienceBindingSource, "End_Date", True))
        Me.End_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.End_DateDateTimePicker.Location = New System.Drawing.Point(213, 132)
        Me.End_DateDateTimePicker.Name = "End_DateDateTimePicker"
        Me.End_DateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.End_DateDateTimePicker.TabIndex = 122
        '
        'S_NumTextBox2
        '
        Me.S_NumTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "S_Num", True))
        Me.S_NumTextBox2.Location = New System.Drawing.Point(-103, 528)
        Me.S_NumTextBox2.Name = "S_NumTextBox2"
        Me.S_NumTextBox2.Size = New System.Drawing.Size(200, 20)
        Me.S_NumTextBox2.TabIndex = 124
        '
        'Salary_Payment_TypeComboBox
        '
        Me.Salary_Payment_TypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Salary_Payment_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "Salary_Payment_Type", True))
        Me.Salary_Payment_TypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Salary_Payment_TypeComboBox.FormattingEnabled = True
        Me.Salary_Payment_TypeComboBox.Items.AddRange(New Object() {"Weekly", "Monthly"})
        Me.Salary_Payment_TypeComboBox.Location = New System.Drawing.Point(213, 106)
        Me.Salary_Payment_TypeComboBox.Name = "Salary_Payment_TypeComboBox"
        Me.Salary_Payment_TypeComboBox.Size = New System.Drawing.Size(200, 28)
        Me.Salary_Payment_TypeComboBox.TabIndex = 125
        '
        'Contract_TypeComboBox
        '
        Me.Contract_TypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Contract_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "Contract_Type", True))
        Me.Contract_TypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Contract_TypeComboBox.FormattingEnabled = True
        Me.Contract_TypeComboBox.Items.AddRange(New Object() {"Full-Time", "Part-Time"})
        Me.Contract_TypeComboBox.Location = New System.Drawing.Point(213, 71)
        Me.Contract_TypeComboBox.Name = "Contract_TypeComboBox"
        Me.Contract_TypeComboBox.Size = New System.Drawing.Size(200, 28)
        Me.Contract_TypeComboBox.TabIndex = 126
        '
        'DatabaseG26DataSet9
        '
        Me.DatabaseG26DataSet9.DataSetName = "DatabaseG26DataSet9"
        Me.DatabaseG26DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GetLatestSNumBindingSource
        '
        Me.GetLatestSNumBindingSource.DataMember = "GetLatestSNum"
        Me.GetLatestSNumBindingSource.DataSource = Me.DatabaseG26DataSet9
        '
        'GetLatestSNumTableAdapter
        '
        Me.GetLatestSNumTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSet9TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'S_NumTextBox1
        '
        Me.S_NumTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetLatestSNumBindingSource, "S_Num", True))
        Me.S_NumTextBox1.Location = New System.Drawing.Point(-28, 560)
        Me.S_NumTextBox1.Name = "S_NumTextBox1"
        Me.S_NumTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.S_NumTextBox1.TabIndex = 127
        '
        'GetNextQualificationIDBindingSource
        '
        Me.GetNextQualificationIDBindingSource.DataMember = "GetNextQualificationID"
        Me.GetNextQualificationIDBindingSource.DataSource = Me.DatabaseG26DataSet9
        '
        'GetNextQualificationIDTableAdapter
        '
        Me.GetNextQualificationIDTableAdapter.ClearBeforeFill = True
        '
        'Qualification_IDTextBox
        '
        Me.Qualification_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetNextQualificationIDBindingSource, "NextQualificationID", True))
        Me.Qualification_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Qualification_IDTextBox.Location = New System.Drawing.Point(210, 3)
        Me.Qualification_IDTextBox.Name = "Qualification_IDTextBox"
        Me.Qualification_IDTextBox.Size = New System.Drawing.Size(201, 26)
        Me.Qualification_IDTextBox.TabIndex = 128
        '
        'GetNextWexIDBindingSource
        '
        Me.GetNextWexIDBindingSource.DataMember = "GetNextWexID"
        Me.GetNextWexIDBindingSource.DataSource = Me.DatabaseG26DataSet9
        '
        'GetNextWexIDTableAdapter
        '
        Me.GetNextWexIDTableAdapter.ClearBeforeFill = True
        '
        'Wex_IDTextBox
        '
        Me.Wex_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Wex_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetNextWexIDBindingSource, "NextWexID", True))
        Me.Wex_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Wex_IDTextBox.Location = New System.Drawing.Point(213, 3)
        Me.Wex_IDTextBox.Name = "Wex_IDTextBox"
        Me.Wex_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Wex_IDTextBox.TabIndex = 129
        '
        'GetNextContractIDBindingSource
        '
        Me.GetNextContractIDBindingSource.DataMember = "GetNextContractID"
        Me.GetNextContractIDBindingSource.DataSource = Me.DatabaseG26DataSet9
        '
        'GetNextContractIDTableAdapter
        '
        Me.GetNextContractIDTableAdapter.ClearBeforeFill = True
        '
        'Contract_IDTextBox
        '
        Me.Contract_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Contract_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GetNextContractIDBindingSource, "NextContractID", True))
        Me.Contract_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Contract_IDTextBox.Location = New System.Drawing.Point(213, 4)
        Me.Contract_IDTextBox.Name = "Contract_IDTextBox"
        Me.Contract_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Contract_IDTextBox.TabIndex = 130
        '
        'savebtn
        '
        Me.savebtn.BackColor = System.Drawing.Color.SpringGreen
        Me.savebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.savebtn.Location = New System.Drawing.Point(549, 871)
        Me.savebtn.Name = "savebtn"
        Me.savebtn.Size = New System.Drawing.Size(75, 37)
        Me.savebtn.TabIndex = 131
        Me.savebtn.Text = "Submit"
        Me.savebtn.UseVisualStyleBackColor = False
        '
        'S_NumTextBox3
        '
        Me.S_NumTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "S_Num", True))
        Me.S_NumTextBox3.Location = New System.Drawing.Point(14, 398)
        Me.S_NumTextBox3.Name = "S_NumTextBox3"
        Me.S_NumTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.S_NumTextBox3.TabIndex = 133
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Qualification_IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(NameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(InstitutionLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Date_of_QualificationLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Qualification_IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.InstitutionTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Date_of_QualificationDateTimePicker, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(134, 293)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(414, 138)
        Me.TableLayoutPanel1.TabIndex = 134
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox4.Location = New System.Drawing.Point(-10, 276)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(900, 11)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 138
        Me.PictureBox4.TabStop = False
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.User.ForeColor = System.Drawing.Color.DimGray
        Me.User.Location = New System.Drawing.Point(97, 253)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(181, 20)
        Me.User.TabIndex = 139
        Me.User.Text = "Qualification Information"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Contract_IDLabel, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Contract_IDTextBox, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Hours_Worked_per_WeekLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Contract_TypeLabel1, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Salary_Payment_TypeLabel1, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Salary_Payment_TypeComboBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Contract_TypeComboBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Hours_Worked_per_WeekTextBox, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(128, 714)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(420, 138)
        Me.TableLayoutPanel2.TabIndex = 140
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox3.Location = New System.Drawing.Point(-10, 473)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(900, 11)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 141
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(97, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 20)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "Work Experience Information"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Wex_IDLabel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Wex_IDTextBox, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(OrganizationLabel, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.OrganizationTextBox, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(PositionLabel, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.PositionTextBox, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Start_DateLabel, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Start_DateDateTimePicker, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(End_DateLabel, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.End_DateDateTimePicker, 1, 4)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(128, 490)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(420, 162)
        Me.TableLayoutPanel3.TabIndex = 143
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox5.Location = New System.Drawing.Point(0, 697)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(900, 11)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 144
        Me.PictureBox5.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(107, 674)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 20)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Employment Contract Information"
        '
        'StaffRegister3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 920)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.S_NumTextBox3)
        Me.Controls.Add(Me.savebtn)
        Me.Controls.Add(Me.S_NumTextBox1)
        Me.Controls.Add(Me.S_NumTextBox2)
        Me.Controls.Add(Me.S_NumTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "StaffRegister3"
        Me.Text = "StaffRegister3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employment_ContractsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_ExperienceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetLatestSNumBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetNextQualificationIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetNextWexIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GetNextContractIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents Employment_ContractsBindingSource As BindingSource
    Friend WithEvents Employment_ContractsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Employment_ContractsTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents QualificationsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.QualificationsTableAdapter
    Friend WithEvents Hours_Worked_per_WeekTextBox As TextBox
    Friend WithEvents S_NumTextBox As TextBox
    Friend WithEvents QualificationsBindingSource As BindingSource
    Friend WithEvents Work_ExperienceTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Work_ExperienceTableAdapter
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents InstitutionTextBox As TextBox
    Friend WithEvents Date_of_QualificationDateTimePicker As DateTimePicker
    Friend WithEvents Work_ExperienceBindingSource As BindingSource
    Friend WithEvents OrganizationTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Start_DateDateTimePicker As DateTimePicker
    Friend WithEvents End_DateDateTimePicker As DateTimePicker
    Friend WithEvents S_NumTextBox2 As TextBox
    Friend WithEvents Salary_Payment_TypeComboBox As ComboBox
    Friend WithEvents Contract_TypeComboBox As ComboBox
    Friend WithEvents DatabaseG26DataSet9 As DatabaseG26DataSet9
    Friend WithEvents GetLatestSNumBindingSource As BindingSource
    Friend WithEvents GetLatestSNumTableAdapter As DatabaseG26DataSet9TableAdapters.GetLatestSNumTableAdapter
    Friend WithEvents TableAdapterManager1 As DatabaseG26DataSet9TableAdapters.TableAdapterManager
    Friend WithEvents S_NumTextBox1 As TextBox
    Friend WithEvents GetNextQualificationIDBindingSource As BindingSource
    Friend WithEvents GetNextQualificationIDTableAdapter As DatabaseG26DataSet9TableAdapters.GetNextQualificationIDTableAdapter
    Friend WithEvents Qualification_IDTextBox As TextBox
    Friend WithEvents GetNextWexIDBindingSource As BindingSource
    Friend WithEvents GetNextWexIDTableAdapter As DatabaseG26DataSet9TableAdapters.GetNextWexIDTableAdapter
    Friend WithEvents Wex_IDTextBox As TextBox
    Friend WithEvents GetNextContractIDBindingSource As BindingSource
    Friend WithEvents GetNextContractIDTableAdapter As DatabaseG26DataSet9TableAdapters.GetNextContractIDTableAdapter
    Friend WithEvents Contract_IDTextBox As TextBox
    Friend WithEvents savebtn As Button
    Friend WithEvents S_NumTextBox3 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents User As Label
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label5 As Label
End Class
