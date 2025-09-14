<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Qualification
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
        Dim Qualification_IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim InstitutionLabel As System.Windows.Forms.Label
        Dim Date_of_QualificationLabel As System.Windows.Forms.Label
        Dim S_NumLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.S_LU = New System.Windows.Forms.Button()
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.QualificationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QualificationsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.QualificationsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.QualificationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.QualificationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.QualificationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qualification_IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.InstitutionTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_QualificationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.S_NumTextBox = New System.Windows.Forms.TextBox()
        Qualification_IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        InstitutionLabel = New System.Windows.Forms.Label()
        Date_of_QualificationLabel = New System.Windows.Forms.Label()
        S_NumLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QualificationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.QualificationsBindingNavigator.SuspendLayout()
        CType(Me.QualificationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(690, 80)
        Me.Panel1.TabIndex = 72
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(144, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Qualification"
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
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(690, 81)
        Me.Panel2.TabIndex = 71
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
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.05405!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.94595!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.TableLayoutPanel1.Controls.Add(Qualification_IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Qualification_IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(NameLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.NameTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(InstitutionLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.S_LU, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.InstitutionTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Date_of_QualificationLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Date_of_QualificationDateTimePicker, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(S_NumLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.S_NumTextBox, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 167)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(417, 153)
        Me.TableLayoutPanel1.TabIndex = 83
        '
        'S_LU
        '
        Me.S_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.S_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_LU.ForeColor = System.Drawing.Color.Transparent
        Me.S_LU.Location = New System.Drawing.Point(373, 125)
        Me.S_LU.Name = "S_LU"
        Me.S_LU.Size = New System.Drawing.Size(24, 23)
        Me.S_LU.TabIndex = 83
        Me.S_LU.UseVisualStyleBackColor = True
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'QualificationsBindingSource
        '
        Me.QualificationsBindingSource.DataMember = "Qualifications"
        Me.QualificationsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'QualificationsTableAdapter
        '
        Me.QualificationsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'QualificationsBindingNavigator
        '
        Me.QualificationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.QualificationsBindingNavigator.BindingSource = Me.QualificationsBindingSource
        Me.QualificationsBindingNavigator.CountItem = Nothing
        Me.QualificationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.QualificationsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.QualificationsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.QualificationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.QualificationsBindingNavigatorSaveItem})
        Me.QualificationsBindingNavigator.Location = New System.Drawing.Point(76, 323)
        Me.QualificationsBindingNavigator.MoveFirstItem = Nothing
        Me.QualificationsBindingNavigator.MoveLastItem = Nothing
        Me.QualificationsBindingNavigator.MoveNextItem = Nothing
        Me.QualificationsBindingNavigator.MovePreviousItem = Nothing
        Me.QualificationsBindingNavigator.Name = "QualificationsBindingNavigator"
        Me.QualificationsBindingNavigator.PositionItem = Nothing
        Me.QualificationsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.QualificationsBindingNavigator.TabIndex = 84
        Me.QualificationsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
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
        'QualificationsBindingNavigatorSaveItem
        '
        Me.QualificationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.QualificationsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.QualificationsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.QualificationsBindingNavigatorSaveItem.Name = "QualificationsBindingNavigatorSaveItem"
        Me.QualificationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.QualificationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'QualificationsDataGridView
        '
        Me.QualificationsDataGridView.AutoGenerateColumns = False
        Me.QualificationsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.QualificationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QualificationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.QualificationsDataGridView.DataSource = Me.QualificationsBindingSource
        Me.QualificationsDataGridView.Location = New System.Drawing.Point(76, 355)
        Me.QualificationsDataGridView.Name = "QualificationsDataGridView"
        Me.QualificationsDataGridView.Size = New System.Drawing.Size(544, 220)
        Me.QualificationsDataGridView.TabIndex = 84
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Qualification_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Qualification_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Institution"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Institution"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date_of_Qualification"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date_of_Qualification"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "S_Num"
        Me.DataGridViewTextBoxColumn5.HeaderText = "S_Num"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Qualification_IDLabel
        '
        Qualification_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Qualification_IDLabel.AutoSize = True
        Qualification_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Qualification_IDLabel.Location = New System.Drawing.Point(3, 5)
        Qualification_IDLabel.Name = "Qualification_IDLabel"
        Qualification_IDLabel.Size = New System.Drawing.Size(121, 20)
        Qualification_IDLabel.TabIndex = 0
        Qualification_IDLabel.Text = "Qualification ID:"
        '
        'Qualification_IDTextBox
        '
        Me.Qualification_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Qualification_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationsBindingSource, "Qualification_ID", True))
        Me.Qualification_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Qualification_IDTextBox.Location = New System.Drawing.Point(166, 3)
        Me.Qualification_IDTextBox.Name = "Qualification_IDTextBox"
        Me.Qualification_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Qualification_IDTextBox.TabIndex = 1
        '
        'NameLabel
        '
        NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        NameLabel.Location = New System.Drawing.Point(3, 35)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(55, 20)
        NameLabel.TabIndex = 2
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationsBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(166, 33)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NameTextBox.TabIndex = 3
        '
        'InstitutionLabel
        '
        InstitutionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        InstitutionLabel.AutoSize = True
        InstitutionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        InstitutionLabel.Location = New System.Drawing.Point(3, 65)
        InstitutionLabel.Name = "InstitutionLabel"
        InstitutionLabel.Size = New System.Drawing.Size(83, 20)
        InstitutionLabel.TabIndex = 4
        InstitutionLabel.Text = "Institution:"
        '
        'InstitutionTextBox
        '
        Me.InstitutionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.InstitutionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationsBindingSource, "Institution", True))
        Me.InstitutionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.InstitutionTextBox.Location = New System.Drawing.Point(166, 63)
        Me.InstitutionTextBox.Name = "InstitutionTextBox"
        Me.InstitutionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.InstitutionTextBox.TabIndex = 5
        '
        'Date_of_QualificationLabel
        '
        Date_of_QualificationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_of_QualificationLabel.AutoSize = True
        Date_of_QualificationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_of_QualificationLabel.Location = New System.Drawing.Point(3, 95)
        Date_of_QualificationLabel.Name = "Date_of_QualificationLabel"
        Date_of_QualificationLabel.Size = New System.Drawing.Size(157, 20)
        Date_of_QualificationLabel.TabIndex = 6
        Date_of_QualificationLabel.Text = "Date of Qualification:"
        '
        'Date_of_QualificationDateTimePicker
        '
        Me.Date_of_QualificationDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Date_of_QualificationDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.QualificationsBindingSource, "Date_of_Qualification", True))
        Me.Date_of_QualificationDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_of_QualificationDateTimePicker.Location = New System.Drawing.Point(166, 93)
        Me.Date_of_QualificationDateTimePicker.Name = "Date_of_QualificationDateTimePicker"
        Me.Date_of_QualificationDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Date_of_QualificationDateTimePicker.TabIndex = 7
        '
        'S_NumLabel
        '
        S_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        S_NumLabel.AutoSize = True
        S_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        S_NumLabel.Location = New System.Drawing.Point(3, 126)
        S_NumLabel.Name = "S_NumLabel"
        S_NumLabel.Size = New System.Drawing.Size(108, 20)
        S_NumLabel.TabIndex = 8
        S_NumLabel.Text = "Staff Number:"
        '
        'S_NumTextBox
        '
        Me.S_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.QualificationsBindingSource, "S_Num", True))
        Me.S_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.S_NumTextBox.Location = New System.Drawing.Point(166, 123)
        Me.S_NumTextBox.Name = "S_NumTextBox"
        Me.S_NumTextBox.Size = New System.Drawing.Size(200, 26)
        Me.S_NumTextBox.TabIndex = 9
        '
        'Qualification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 584)
        Me.Controls.Add(Me.QualificationsDataGridView)
        Me.Controls.Add(Me.QualificationsBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Qualification"
        Me.Text = "Qualification"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QualificationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.QualificationsBindingNavigator.ResumeLayout(False)
        Me.QualificationsBindingNavigator.PerformLayout()
        CType(Me.QualificationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents S_LU As Button
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents QualificationsBindingSource As BindingSource
    Friend WithEvents QualificationsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.QualificationsTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents QualificationsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents QualificationsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Qualification_IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents InstitutionTextBox As TextBox
    Friend WithEvents Date_of_QualificationDateTimePicker As DateTimePicker
    Friend WithEvents S_NumTextBox As TextBox
    Friend WithEvents QualificationsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
