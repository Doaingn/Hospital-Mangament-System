<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class local_doctor
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
        Dim DoctorIDLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim PhoneNumLabel As System.Windows.Forms.Label
        Dim ClinicIDLabel As System.Windows.Forms.Label
        Me.DatabaseG26DataSet = New WellMeadows_Hospital_G26.DatabaseG26DataSet()
        Me.Local_DoctorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Local_DoctorsTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.Local_DoctorsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Local_DoctorsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Local_DoctorsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DoctorIDTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.ClinicIDTextBox = New System.Windows.Forms.TextBox()
        Me.Local_DoctorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Add_LU = New System.Windows.Forms.Button()
        DoctorIDLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        PhoneNumLabel = New System.Windows.Forms.Label()
        ClinicIDLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Local_DoctorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Local_DoctorsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Local_DoctorsBindingNavigator.SuspendLayout()
        CType(Me.Local_DoctorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DoctorIDLabel
        '
        DoctorIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DoctorIDLabel.AutoSize = True
        DoctorIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DoctorIDLabel.Location = New System.Drawing.Point(3, 5)
        DoctorIDLabel.Name = "DoctorIDLabel"
        DoctorIDLabel.Size = New System.Drawing.Size(82, 20)
        DoctorIDLabel.TabIndex = 42
        DoctorIDLabel.Text = "Doctor ID:"
        '
        'First_NameLabel
        '
        First_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        First_NameLabel.Location = New System.Drawing.Point(3, 35)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 44
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(3, 65)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 46
        Last_NameLabel.Text = "Last Name:"
        '
        'PhoneNumLabel
        '
        PhoneNumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PhoneNumLabel.AutoSize = True
        PhoneNumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PhoneNumLabel.Location = New System.Drawing.Point(3, 95)
        PhoneNumLabel.Name = "PhoneNumLabel"
        PhoneNumLabel.Size = New System.Drawing.Size(96, 20)
        PhoneNumLabel.TabIndex = 48
        PhoneNumLabel.Text = "Phone Num:"
        '
        'ClinicIDLabel
        '
        ClinicIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ClinicIDLabel.AutoSize = True
        ClinicIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ClinicIDLabel.Location = New System.Drawing.Point(3, 127)
        ClinicIDLabel.Name = "ClinicIDLabel"
        ClinicIDLabel.Size = New System.Drawing.Size(71, 20)
        ClinicIDLabel.TabIndex = 50
        ClinicIDLabel.Text = "Clinic ID:"
        '
        'DatabaseG26DataSet
        '
        Me.DatabaseG26DataSet.DataSetName = "DatabaseG26DataSet"
        Me.DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Local_DoctorsBindingSource
        '
        Me.Local_DoctorsBindingSource.DataMember = "Local_Doctors"
        Me.Local_DoctorsBindingSource.DataSource = Me.DatabaseG26DataSet
        '
        'Local_DoctorsTableAdapter
        '
        Me.Local_DoctorsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Employment_ContractsTableAdapter = Nothing
        Me.TableAdapterManager.InpatientsTableAdapter = Nothing
        Me.TableAdapterManager.Local_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager.Local_DoctorsTableAdapter = Me.Local_DoctorsTableAdapter
        Me.TableAdapterManager.Medication_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Medication_HeadTableAdapter = Nothing
        Me.TableAdapterManager.Outpatient_ClinicsTableAdapter = Nothing
        Me.TableAdapterManager.OutpatientsTableAdapter = Nothing
        Me.TableAdapterManager.Patients_NextOfKinTableAdapter = Nothing
        Me.TableAdapterManager.PatientsTableAdapter = Nothing
        Me.TableAdapterManager.Pharmaceutical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.QualificationsTableAdapter = Nothing
        Me.TableAdapterManager.ShiftsTableAdapter = Nothing
        Me.TableAdapterManager.StaffsTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.Surgical_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalRequisitionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'Local_DoctorsBindingNavigator
        '
        Me.Local_DoctorsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Local_DoctorsBindingNavigator.BindingSource = Me.Local_DoctorsBindingSource
        Me.Local_DoctorsBindingNavigator.CountItem = Nothing
        Me.Local_DoctorsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Local_DoctorsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Local_DoctorsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Local_DoctorsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator1, Me.Local_DoctorsBindingNavigatorSaveItem})
        Me.Local_DoctorsBindingNavigator.Location = New System.Drawing.Point(76, 345)
        Me.Local_DoctorsBindingNavigator.MoveFirstItem = Nothing
        Me.Local_DoctorsBindingNavigator.MoveLastItem = Nothing
        Me.Local_DoctorsBindingNavigator.MoveNextItem = Nothing
        Me.Local_DoctorsBindingNavigator.MovePreviousItem = Nothing
        Me.Local_DoctorsBindingNavigator.Name = "Local_DoctorsBindingNavigator"
        Me.Local_DoctorsBindingNavigator.PositionItem = Nothing
        Me.Local_DoctorsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.Local_DoctorsBindingNavigator.TabIndex = 42
        Me.Local_DoctorsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Add
        Me.BindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Delete
        Me.BindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 26)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'Local_DoctorsBindingNavigatorSaveItem
        '
        Me.Local_DoctorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Local_DoctorsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.Local_DoctorsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Local_DoctorsBindingNavigatorSaveItem.Name = "Local_DoctorsBindingNavigatorSaveItem"
        Me.Local_DoctorsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.Local_DoctorsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DoctorIDTextBox
        '
        Me.DoctorIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DoctorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_DoctorsBindingSource, "doctorID", True))
        Me.DoctorIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DoctorIDTextBox.Location = New System.Drawing.Point(108, 3)
        Me.DoctorIDTextBox.Name = "DoctorIDTextBox"
        Me.DoctorIDTextBox.Size = New System.Drawing.Size(163, 26)
        Me.DoctorIDTextBox.TabIndex = 43
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_DoctorsBindingSource, "First_Name", True))
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(108, 33)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(163, 26)
        Me.First_NameTextBox.TabIndex = 45
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_DoctorsBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(108, 63)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(163, 26)
        Me.Last_NameTextBox.TabIndex = 47
        '
        'PhoneNumTextBox
        '
        Me.PhoneNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PhoneNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_DoctorsBindingSource, "PhoneNum", True))
        Me.PhoneNumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PhoneNumTextBox.Location = New System.Drawing.Point(108, 93)
        Me.PhoneNumTextBox.Name = "PhoneNumTextBox"
        Me.PhoneNumTextBox.Size = New System.Drawing.Size(163, 26)
        Me.PhoneNumTextBox.TabIndex = 49
        '
        'ClinicIDTextBox
        '
        Me.ClinicIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ClinicIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Local_DoctorsBindingSource, "clinicID", True))
        Me.ClinicIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ClinicIDTextBox.Location = New System.Drawing.Point(108, 124)
        Me.ClinicIDTextBox.Name = "ClinicIDTextBox"
        Me.ClinicIDTextBox.Size = New System.Drawing.Size(163, 26)
        Me.ClinicIDTextBox.TabIndex = 51
        '
        'Local_DoctorsDataGridView
        '
        Me.Local_DoctorsDataGridView.AutoGenerateColumns = False
        Me.Local_DoctorsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.Local_DoctorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Local_DoctorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Local_DoctorsDataGridView.DataSource = Me.Local_DoctorsBindingSource
        Me.Local_DoctorsDataGridView.Location = New System.Drawing.Point(76, 387)
        Me.Local_DoctorsDataGridView.Name = "Local_DoctorsDataGridView"
        Me.Local_DoctorsDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.Local_DoctorsDataGridView.TabIndex = 51
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "doctorID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "doctorID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PhoneNum"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PhoneNum"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "clinicID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "clinicID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(692, 80)
        Me.Panel1.TabIndex = 54
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(145, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Local Doctor"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox2.Location = New System.Drawing.Point(-96, 27)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1047, 50)
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
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 81)
        Me.Panel2.TabIndex = 53
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources.vejq5m3sm4396c01m3etnnp4r8
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.32753!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.67247!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Add_LU, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(DoctorIDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DoctorIDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(First_NameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ClinicIDTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(ClinicIDLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(PhoneNumLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Last_NameTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Last_NameLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.First_NameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PhoneNumTextBox, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 176)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(342, 154)
        Me.TableLayoutPanel1.TabIndex = 59
        '
        'Add_LU
        '
        Me.Add_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Add_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Add_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Add_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Add_LU.Location = New System.Drawing.Point(277, 125)
        Me.Add_LU.Name = "Add_LU"
        Me.Add_LU.Size = New System.Drawing.Size(24, 23)
        Me.Add_LU.TabIndex = 60
        Me.Add_LU.UseVisualStyleBackColor = True
        '
        'local_doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 635)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Local_DoctorsDataGridView)
        Me.Controls.Add(Me.Local_DoctorsBindingNavigator)
        Me.Name = "local_doctor"
        Me.Text = "local_doctor"
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Local_DoctorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Local_DoctorsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Local_DoctorsBindingNavigator.ResumeLayout(False)
        Me.Local_DoctorsBindingNavigator.PerformLayout()
        CType(Me.Local_DoctorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseG26DataSet As DatabaseG26DataSet
    Friend WithEvents Local_DoctorsBindingSource As BindingSource
    Friend WithEvents Local_DoctorsTableAdapter As DatabaseG26DataSetTableAdapters.Local_DoctorsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Local_DoctorsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Local_DoctorsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DoctorIDTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents PhoneNumTextBox As TextBox
    Friend WithEvents ClinicIDTextBox As TextBox
    Friend WithEvents Local_DoctorsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Add_LU As Button
End Class
