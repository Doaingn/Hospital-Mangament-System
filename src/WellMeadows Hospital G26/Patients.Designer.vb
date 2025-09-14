<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Patients
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim P_NumLabel As System.Windows.Forms.Label
        Dim P_IDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim Date_Of_BirthLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Dim Marital_StatusLabel As System.Windows.Forms.Label
        Dim Date_RegisteredLabel As System.Windows.Forms.Label
        Dim Address_IDLabel As System.Windows.Forms.Label
        Dim DoctorIDLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.P_NumTextBox = New System.Windows.Forms.TextBox()
        Me.PatientsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.P_IDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.DOC_LU = New System.Windows.Forms.Button()
        Me.Add_LU = New System.Windows.Forms.Button()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.Date_Of_BirthDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.Marital_StatusTextBox = New System.Windows.Forms.TextBox()
        Me.Date_RegisteredDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Address_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Param1ToolStripTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Address = New System.Windows.Forms.Button()
        Me.NOKbtn = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.PatientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drug_Requisition_ViewTableAdapter1 = New WellMeadows_Hospital_G26.DatabaseG26DataSet1TableAdapters.Drug_Requisition_ViewTableAdapter()
        Me.PatientsTableAdapter1 = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.PatientsTableAdapter()
        Me.TableAdapterManager1 = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        P_NumLabel = New System.Windows.Forms.Label()
        P_IDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        Date_Of_BirthLabel = New System.Windows.Forms.Label()
        SexLabel = New System.Windows.Forms.Label()
        Marital_StatusLabel = New System.Windows.Forms.Label()
        Date_RegisteredLabel = New System.Windows.Forms.Label()
        Address_IDLabel = New System.Windows.Forms.Label()
        DoctorIDLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PatientsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.PatientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_NumLabel
        '
        P_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        P_NumLabel.AutoSize = True
        P_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        P_NumLabel.Location = New System.Drawing.Point(3, 7)
        P_NumLabel.Name = "P_NumLabel"
        P_NumLabel.Size = New System.Drawing.Size(123, 20)
        P_NumLabel.TabIndex = 0
        P_NumLabel.Text = "Patient Number:"
        '
        'P_IDLabel
        '
        P_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        P_IDLabel.AutoSize = True
        P_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        P_IDLabel.Location = New System.Drawing.Point(339, 7)
        P_IDLabel.Name = "P_IDLabel"
        P_IDLabel.Size = New System.Drawing.Size(84, 20)
        P_IDLabel.TabIndex = 2
        P_IDLabel.Text = "Patient ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        First_NameLabel.Location = New System.Drawing.Point(3, 41)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 4
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(339, 41)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 6
        Last_NameLabel.Text = "Last Name:"
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PhoneNumLabel.Location = New System.Drawing.Point(3, 75)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(96, 20)
        PhoneNumLabel.TabIndex = 8
        PhoneNumLabel.Text = "Phone Num:"
        '
        'Date_Of_BirthLabel
        '
        Date_Of_BirthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_Of_BirthLabel.AutoSize = True
        Date_Of_BirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_Of_BirthLabel.Location = New System.Drawing.Point(339, 75)
        Date_Of_BirthLabel.Name = "Date_Of_BirthLabel"
        Date_Of_BirthLabel.Size = New System.Drawing.Size(106, 20)
        Date_Of_BirthLabel.TabIndex = 10
        Date_Of_BirthLabel.Text = "Date Of Birth:"
        '
        'SexLabel
        '
        SexLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SexLabel.AutoSize = True
        SexLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        SexLabel.Location = New System.Drawing.Point(3, 112)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(40, 20)
        SexLabel.TabIndex = 12
        SexLabel.Text = "Sex:"
        '
        'Marital_StatusLabel
        '
        Marital_StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Marital_StatusLabel.AutoSize = True
        Marital_StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Marital_StatusLabel.Location = New System.Drawing.Point(339, 112)
        Marital_StatusLabel.Name = "Marital_StatusLabel"
        Marital_StatusLabel.Size = New System.Drawing.Size(111, 20)
        Marital_StatusLabel.TabIndex = 14
        Marital_StatusLabel.Text = "Marital Status:"
        '
        'Date_RegisteredLabel
        '
        Date_RegisteredLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_RegisteredLabel.AutoSize = True
        Date_RegisteredLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_RegisteredLabel.Location = New System.Drawing.Point(3, 147)
        Date_RegisteredLabel.Name = "Date_RegisteredLabel"
        Date_RegisteredLabel.Size = New System.Drawing.Size(130, 20)
        Date_RegisteredLabel.TabIndex = 16
        Date_RegisteredLabel.Text = "Date Registered:"
        '
        'Address_IDLabel
        '
        Address_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Address_IDLabel.AutoSize = True
        Address_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Address_IDLabel.Location = New System.Drawing.Point(339, 147)
        Address_IDLabel.Name = "Address_IDLabel"
        Address_IDLabel.Size = New System.Drawing.Size(93, 20)
        Address_IDLabel.TabIndex = 18
        Address_IDLabel.Text = "Address ID:"
        '
        'DoctorIDLabel
        '
        DoctorIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DoctorIDLabel.AutoSize = True
        DoctorIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DoctorIDLabel.Location = New System.Drawing.Point(339, 182)
        DoctorIDLabel.Name = "DoctorIDLabel"
        DoctorIDLabel.Size = New System.Drawing.Size(82, 20)
        DoctorIDLabel.TabIndex = 20
        DoctorIDLabel.Text = "Doctor ID:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.03647!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.37082!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.45289!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.13982!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83.0!))
        Me.TableLayoutPanel1.Controls.Add(P_NumLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.P_NumTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(P_IDLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.P_IDTextBox, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(First_NameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.First_NameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DOC_LU, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Add_LU, 4, 4)
        Me.TableLayoutPanel1.Controls.Add(Last_NameLabel, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Last_NameTextBox, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(PhoneNumLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.PhoneNumTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Date_Of_BirthLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Date_Of_BirthDateTimePicker, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(SexLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.SexTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Marital_StatusLabel, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Marital_StatusTextBox, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Date_RegisteredLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Date_RegisteredDateTimePicker, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Address_IDLabel, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Address_IDTextBox, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(DoctorIDLabel, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.DoctorIDTextBox, 3, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 164)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.65318!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.42593!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.98148!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(703, 213)
        Me.TableLayoutPanel1.TabIndex = 66
        '
        'P_NumTextBox
        '
        Me.P_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource1, "P_Num", True))
        Me.P_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.P_NumTextBox.Location = New System.Drawing.Point(139, 4)
        Me.P_NumTextBox.Name = "P_NumTextBox"
        Me.P_NumTextBox.Size = New System.Drawing.Size(194, 26)
        Me.P_NumTextBox.TabIndex = 1
        '
        'PatientsBindingSource1
        '
        Me.PatientsBindingSource1.DataMember = "Patients"
        Me.PatientsBindingSource1.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource1, "P_ID", True))
        Me.P_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.P_IDTextBox.Location = New System.Drawing.Point(459, 4)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(156, 26)
        Me.P_IDTextBox.TabIndex = 3
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource1, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(139, 38)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(194, 26)
        Me.First_NameTextBox.TabIndex = 5
        '
        'DOC_LU
        '
        Me.DOC_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DOC_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.DOC_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DOC_LU.ForeColor = System.Drawing.Color.Transparent
        Me.DOC_LU.Location = New System.Drawing.Point(621, 180)
        Me.DOC_LU.Name = "DOC_LU"
        Me.DOC_LU.Size = New System.Drawing.Size(24, 23)
        Me.DOC_LU.TabIndex = 52
        Me.DOC_LU.UseVisualStyleBackColor = True
        '
        'Add_LU
        '
        Me.Add_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Add_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Add_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Add_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Add_LU.Location = New System.Drawing.Point(621, 146)
        Me.Add_LU.Name = "Add_LU"
        Me.Add_LU.Size = New System.Drawing.Size(24, 22)
        Me.Add_LU.TabIndex = 51
        Me.Add_LU.UseVisualStyleBackColor = True
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource1, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(459, 38)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(156, 26)
        Me.Last_NameTextBox.TabIndex = 7
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource1, "PhoneNum", True))
        Me.PhoneNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(139, 72)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(194, 26)
        Me.PhoneNumTextBox.TabIndex = 9
        '
        'Date_Of_BirthDateTimePicker
        '
        Me.Date_Of_BirthDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Date_Of_BirthDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientsBindingSource1, "Date_Of_Birth", True))
        Me.Date_Of_BirthDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_Of_BirthDateTimePicker.Location = New System.Drawing.Point(459, 72)
        Me.Date_Of_BirthDateTimePicker.Name = "Date_Of_BirthDateTimePicker"
        Me.Date_Of_BirthDateTimePicker.Size = New System.Drawing.Size(156, 26)
        Me.Date_Of_BirthDateTimePicker.TabIndex = 11
        '
        'SexTextBox
        '
        Me.SexTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource1, "Sex", True))
        Me.SexTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SexTextBox.Location = New System.Drawing.Point(139, 109)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(194, 26)
        Me.SexTextBox.TabIndex = 13
        '
        'Marital_StatusTextBox
        '
        Me.Marital_StatusTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Marital_StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource1, "Marital_Status", True))
        Me.Marital_StatusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Marital_StatusTextBox.Location = New System.Drawing.Point(459, 109)
        Me.Marital_StatusTextBox.Name = "Marital_StatusTextBox"
        Me.Marital_StatusTextBox.Size = New System.Drawing.Size(156, 26)
        Me.Marital_StatusTextBox.TabIndex = 15
        '
        'Date_RegisteredDateTimePicker
        '
        Me.Date_RegisteredDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Date_RegisteredDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PatientsBindingSource1, "Date_Registered", True))
        Me.Date_RegisteredDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_RegisteredDateTimePicker.Location = New System.Drawing.Point(139, 146)
        Me.Date_RegisteredDateTimePicker.Name = "Date_RegisteredDateTimePicker"
        Me.Date_RegisteredDateTimePicker.Size = New System.Drawing.Size(194, 26)
        Me.Date_RegisteredDateTimePicker.TabIndex = 17
        '
        'Address_IDTextBox
        '
        Me.Address_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Address_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource1, "Address_ID", True))
        Me.Address_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Address_IDTextBox.Location = New System.Drawing.Point(459, 146)
        Me.Address_IDTextBox.Name = "Address_IDTextBox"
        Me.Address_IDTextBox.Size = New System.Drawing.Size(156, 26)
        Me.Address_IDTextBox.TabIndex = 19
        '
        'DoctorIDTextBox
        '
        Me.DoctorIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DoctorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientsBindingSource1, "doctorID", True))
        Me.DoctorIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DoctorIDTextBox.Location = New System.Drawing.Point(459, 179)
        Me.DoctorIDTextBox.Name = "DoctorIDTextBox"
        Me.DoctorIDTextBox.Size = New System.Drawing.Size(156, 26)
        Me.DoctorIDTextBox.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1299, 80)
        Me.Panel1.TabIndex = 68
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(228, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Patient Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox1.Location = New System.Drawing.Point(-178, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1647, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Panel2.Controls.Add(Me.Param1ToolStripTextBox)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1299, 81)
        Me.Panel2.TabIndex = 67
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.ForeColor = System.Drawing.Color.DimGray
        Me.Param1ToolStripTextBox.Location = New System.Drawing.Point(1087, 27)
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Param1ToolStripTextBox.TabIndex = 71
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources.vejq5m3sm4396c01m3etnnp4r8
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label2.Location = New System.Drawing.Point(83, 46)
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
        Me.Label1.Location = New System.Drawing.Point(82, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(283, 30)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Wellmeadows Hospital"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.48387!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.3871!))
        Me.TableLayoutPanel2.Controls.Add(Me.Address, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.NOKbtn, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(966, 664)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(255, 63)
        Me.TableLayoutPanel2.TabIndex = 62
        '
        'Address
        '
        Me.Address.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Address.Location = New System.Drawing.Point(135, 11)
        Me.Address.Margin = New System.Windows.Forms.Padding(11)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(109, 41)
        Me.Address.TabIndex = 11
        Me.Address.Text = "Address"
        Me.Address.UseVisualStyleBackColor = True
        '
        'NOKbtn
        '
        Me.NOKbtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NOKbtn.Location = New System.Drawing.Point(11, 11)
        Me.NOKbtn.Margin = New System.Windows.Forms.Padding(11)
        Me.NOKbtn.Name = "NOKbtn"
        Me.NOKbtn.Size = New System.Drawing.Size(102, 41)
        Me.NOKbtn.TabIndex = 10
        Me.NOKbtn.Text = "Patient Next of kin"
        Me.NOKbtn.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator1.BindingSource = Me.PatientsBindingSource1
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorDeleteItem1, Me.BindingNavigatorSeparator4, Me.ToolStripButton1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(76, 395)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(89, 29)
        Me.BindingNavigator1.TabIndex = 69
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Add
        Me.BindingNavigatorAddNewItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Delete
        Me.BindingNavigatorDeleteItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(26, 26)
        Me.ToolStripButton1.Text = "Save Data"
        '
        'PatientsDataGridView
        '
        Me.PatientsDataGridView.AutoGenerateColumns = False
        Me.PatientsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.PatientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.PatientsDataGridView.DataSource = Me.PatientsBindingSource1
        Me.PatientsDataGridView.Location = New System.Drawing.Point(76, 427)
        Me.PatientsDataGridView.Name = "PatientsDataGridView"
        Me.PatientsDataGridView.Size = New System.Drawing.Size(1145, 220)
        Me.PatientsDataGridView.TabIndex = 69
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "P_Num"
        Me.DataGridViewTextBoxColumn1.HeaderText = "P_Num"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "P_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "P_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PhoneNum"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PhoneNum"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Date_Of_Birth"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Date_Of_Birth"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Marital_Status"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Marital_Status"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Date_Registered"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date_Registered"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Address_ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Address_ID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "doctorID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "doctorID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Drug_Requisition_ViewTableAdapter1
        '
        Me.Drug_Requisition_ViewTableAdapter1.ClearBeforeFill = True
        '
        'PatientsTableAdapter1
        '
        Me.PatientsTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.AddressesTableAdapter = Nothing
        Me.TableAdapterManager1.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BedAllocationsTableAdapter = Nothing
        Me.TableAdapterManager1.BedsTableAdapter = Nothing
        Me.TableAdapterManager1.Clinic_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager1.DrugReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager1.DrugRequisitionTableAdapter = Nothing
        Me.TableAdapterManager1.Employment_ContractsTableAdapter = Nothing
        Me.TableAdapterManager1.InpatientsTableAdapter = Nothing
        Me.TableAdapterManager1.Local_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager1.Local_DoctorsTableAdapter = Nothing
        Me.TableAdapterManager1.Medication_DetailsTableAdapter = Nothing
        Me.TableAdapterManager1.Medication_HeadTableAdapter = Nothing
        Me.TableAdapterManager1.Outpatient_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager1.OutpatientsTableAdapter = Nothing
        Me.TableAdapterManager1.Patients_NextOfKinTableAdapter = Nothing
        Me.TableAdapterManager1.PatientsTableAdapter = Me.PatientsTableAdapter1
        Me.TableAdapterManager1.Pharmaceutical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager1.QualificationsTableAdapter = Nothing
        Me.TableAdapterManager1.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager1.StaffsTableAdapter = Nothing
        Me.TableAdapterManager1.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager1.Surgical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager1.SurgicalReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager1.SurgicalRequisitionTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.UsersTableAdapter = Nothing
        Me.TableAdapterManager1.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager1.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager1.WardsTableAdapter = Nothing
        Me.TableAdapterManager1.Work_ExperienceTableAdapter = Nothing
        '
        'Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1299, 772)
        Me.Controls.Add(Me.PatientsDataGridView)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Patients"
        Me.Text = "Patients"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PatientsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.PatientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DOC_LU As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Address As Button
    Friend WithEvents NOKbtn As Button
    Friend WithEvents Add_LU As Button
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents PatientsBindingSource1 As BindingSource
    Friend WithEvents PatientsTableAdapter1 As SQLEXPRESS_DatabaseG26DataSetTableAdapters.PatientsTableAdapter
    Friend WithEvents TableAdapterManager1 As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents P_NumTextBox As TextBox
    Friend WithEvents P_IDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents Date_Of_BirthDateTimePicker As DateTimePicker
    Friend WithEvents SexTextBox As TextBox
    Friend WithEvents Marital_StatusTextBox As TextBox
    Friend WithEvents Date_RegisteredDateTimePicker As DateTimePicker
    Friend WithEvents Address_IDTextBox As TextBox
    Friend WithEvents DoctorIDTextBox As TextBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents PatientsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Param1ToolStripTextBox As TextBox
    Friend WithEvents Drug_Requisition_ViewTableAdapter1 As DatabaseG26DataSet1TableAdapters.Drug_Requisition_ViewTableAdapter
End Class
