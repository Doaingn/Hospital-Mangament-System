<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeContract
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
        Dim S_NumLabel As System.Windows.Forms.Label
        Dim Salary_Payment_TypeLabel As System.Windows.Forms.Label
        Dim Contract_TypeLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Contract_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Employment_ContractsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.Hours_Worked_per_WeekTextBox = New System.Windows.Forms.TextBox()
        Me.Cli_LU = New System.Windows.Forms.Button()
        Me.S_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Employment_ContractsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Employment_ContractsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Employment_ContractsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.Employment_ContractsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Employment_ContractsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contract_TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Salary_Payment_TypeComboBox = New System.Windows.Forms.ComboBox()
        Contract_IDLabel = New System.Windows.Forms.Label()
        Hours_Worked_per_WeekLabel = New System.Windows.Forms.Label()
        S_NumLabel = New System.Windows.Forms.Label()
        Salary_Payment_TypeLabel = New System.Windows.Forms.Label()
        Contract_TypeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Employment_ContractsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employment_ContractsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Employment_ContractsBindingNavigator.SuspendLayout()
        CType(Me.Employment_ContractsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Contract_IDLabel
        '
        Contract_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Contract_IDLabel.AutoSize = True
        Contract_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Contract_IDLabel.Location = New System.Drawing.Point(3, 5)
        Contract_IDLabel.Name = "Contract_IDLabel"
        Contract_IDLabel.Size = New System.Drawing.Size(95, 20)
        Contract_IDLabel.TabIndex = 0
        Contract_IDLabel.Text = "Contract ID:"
        '
        'Hours_Worked_per_WeekLabel
        '
        Hours_Worked_per_WeekLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Hours_Worked_per_WeekLabel.AutoSize = True
        Hours_Worked_per_WeekLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Hours_Worked_per_WeekLabel.Location = New System.Drawing.Point(3, 36)
        Hours_Worked_per_WeekLabel.Name = "Hours_Worked_per_WeekLabel"
        Hours_Worked_per_WeekLabel.Size = New System.Drawing.Size(187, 20)
        Hours_Worked_per_WeekLabel.TabIndex = 2
        Hours_Worked_per_WeekLabel.Text = "Hours Worked per Week:"
        '
        'S_NumLabel
        '
        S_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        S_NumLabel.AutoSize = True
        S_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        S_NumLabel.Location = New System.Drawing.Point(3, 130)
        S_NumLabel.Name = "S_NumLabel"
        S_NumLabel.Size = New System.Drawing.Size(108, 20)
        S_NumLabel.TabIndex = 8
        S_NumLabel.Text = "Staff Number:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(710, 80)
        Me.Panel1.TabIndex = 56
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(157, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Staff Contract"
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
        Me.Panel2.Size = New System.Drawing.Size(710, 81)
        Me.Panel2.TabIndex = 55
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.38272!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.61728!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Controls.Add(Contract_IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Salary_Payment_TypeComboBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Contract_IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Hours_Worked_per_WeekLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Contract_TypeComboBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Hours_Worked_per_WeekTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Contract_TypeLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Cli_LU, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Salary_Payment_TypeLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(S_NumLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.S_NumTextBox, 1, 4)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 167)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(449, 156)
        Me.TableLayoutPanel1.TabIndex = 66
        '
        'Contract_IDTextBox
        '
        Me.Contract_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Contract_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "Contract_ID", True))
        Me.Contract_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Contract_IDTextBox.Location = New System.Drawing.Point(202, 3)
        Me.Contract_IDTextBox.Name = "Contract_IDTextBox"
        Me.Contract_IDTextBox.Size = New System.Drawing.Size(198, 26)
        Me.Contract_IDTextBox.TabIndex = 1
        '
        'Employment_ContractsBindingSource
        '
        Me.Employment_ContractsBindingSource.DataMember = "Employment_Contracts"
        Me.Employment_ContractsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Hours_Worked_per_WeekTextBox
        '
        Me.Hours_Worked_per_WeekTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Hours_Worked_per_WeekTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "Hours_Worked_per_Week", True))
        Me.Hours_Worked_per_WeekTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Hours_Worked_per_WeekTextBox.Location = New System.Drawing.Point(202, 34)
        Me.Hours_Worked_per_WeekTextBox.Name = "Hours_Worked_per_WeekTextBox"
        Me.Hours_Worked_per_WeekTextBox.Size = New System.Drawing.Size(198, 26)
        Me.Hours_Worked_per_WeekTextBox.TabIndex = 3
        '
        'Cli_LU
        '
        Me.Cli_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cli_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Cli_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Cli_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Cli_LU.Location = New System.Drawing.Point(406, 128)
        Me.Cli_LU.Name = "Cli_LU"
        Me.Cli_LU.Size = New System.Drawing.Size(24, 23)
        Me.Cli_LU.TabIndex = 50
        Me.Cli_LU.UseVisualStyleBackColor = True
        '
        'S_NumTextBox
        '
        Me.S_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "S_Num", True))
        Me.S_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.S_NumTextBox.Location = New System.Drawing.Point(202, 127)
        Me.S_NumTextBox.Name = "S_NumTextBox"
        Me.S_NumTextBox.Size = New System.Drawing.Size(198, 26)
        Me.S_NumTextBox.TabIndex = 9
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
        Me.TableAdapterManager.QualificationsTableAdapter = Nothing
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
        'Employment_ContractsBindingNavigator
        '
        Me.Employment_ContractsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Employment_ContractsBindingNavigator.BindingSource = Me.Employment_ContractsBindingSource
        Me.Employment_ContractsBindingNavigator.CountItem = Nothing
        Me.Employment_ContractsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Employment_ContractsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Employment_ContractsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Employment_ContractsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator, Me.Employment_ContractsBindingNavigatorSaveItem})
        Me.Employment_ContractsBindingNavigator.Location = New System.Drawing.Point(76, 326)
        Me.Employment_ContractsBindingNavigator.MoveFirstItem = Nothing
        Me.Employment_ContractsBindingNavigator.MoveLastItem = Nothing
        Me.Employment_ContractsBindingNavigator.MoveNextItem = Nothing
        Me.Employment_ContractsBindingNavigator.MovePreviousItem = Nothing
        Me.Employment_ContractsBindingNavigator.Name = "Employment_ContractsBindingNavigator"
        Me.Employment_ContractsBindingNavigator.PositionItem = Nothing
        Me.Employment_ContractsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.Employment_ContractsBindingNavigator.TabIndex = 67
        Me.Employment_ContractsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'Employment_ContractsBindingNavigatorSaveItem
        '
        Me.Employment_ContractsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Employment_ContractsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.Employment_ContractsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Employment_ContractsBindingNavigatorSaveItem.Name = "Employment_ContractsBindingNavigatorSaveItem"
        Me.Employment_ContractsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.Employment_ContractsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Employment_ContractsDataGridView
        '
        Me.Employment_ContractsDataGridView.AutoGenerateColumns = False
        Me.Employment_ContractsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.Employment_ContractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Employment_ContractsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Employment_ContractsDataGridView.DataSource = Me.Employment_ContractsBindingSource
        Me.Employment_ContractsDataGridView.Location = New System.Drawing.Point(76, 358)
        Me.Employment_ContractsDataGridView.Name = "Employment_ContractsDataGridView"
        Me.Employment_ContractsDataGridView.Size = New System.Drawing.Size(544, 220)
        Me.Employment_ContractsDataGridView.TabIndex = 67
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Contract_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Contract_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Hours_Worked_per_Week"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Hours_Worked_per_Week"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Contract_Type"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Contract_Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Salary_Payment_Type"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Salary_Payment_Type"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "S_Num"
        Me.DataGridViewTextBoxColumn5.HeaderText = "S_Num"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Contract_TypeComboBox
        '
        Me.Contract_TypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Contract_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "Contract_Type", True))
        Me.Contract_TypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Contract_TypeComboBox.FormattingEnabled = True
        Me.Contract_TypeComboBox.Items.AddRange(New Object() {"Full-Time", "Part-Time"})
        Me.Contract_TypeComboBox.Location = New System.Drawing.Point(202, 67)
        Me.Contract_TypeComboBox.Name = "Contract_TypeComboBox"
        Me.Contract_TypeComboBox.Size = New System.Drawing.Size(198, 28)
        Me.Contract_TypeComboBox.TabIndex = 68
        '
        'Salary_Payment_TypeComboBox
        '
        Me.Salary_Payment_TypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Salary_Payment_TypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Employment_ContractsBindingSource, "Salary_Payment_Type", True))
        Me.Salary_Payment_TypeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Salary_Payment_TypeComboBox.FormattingEnabled = True
        Me.Salary_Payment_TypeComboBox.Items.AddRange(New Object() {"Weekly", "Monthly"})
        Me.Salary_Payment_TypeComboBox.Location = New System.Drawing.Point(202, 98)
        Me.Salary_Payment_TypeComboBox.Name = "Salary_Payment_TypeComboBox"
        Me.Salary_Payment_TypeComboBox.Size = New System.Drawing.Size(198, 28)
        Me.Salary_Payment_TypeComboBox.TabIndex = 69
        '
        'Salary_Payment_TypeLabel
        '
        Salary_Payment_TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Salary_Payment_TypeLabel.AutoSize = True
        Salary_Payment_TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Salary_Payment_TypeLabel.Location = New System.Drawing.Point(3, 98)
        Salary_Payment_TypeLabel.Name = "Salary_Payment_TypeLabel"
        Salary_Payment_TypeLabel.Size = New System.Drawing.Size(161, 20)
        Salary_Payment_TypeLabel.TabIndex = 6
        Salary_Payment_TypeLabel.Text = "Salary Payment Type:"
        '
        'Contract_TypeLabel
        '
        Contract_TypeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Contract_TypeLabel.AutoSize = True
        Contract_TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Contract_TypeLabel.Location = New System.Drawing.Point(3, 67)
        Contract_TypeLabel.Name = "Contract_TypeLabel"
        Contract_TypeLabel.Size = New System.Drawing.Size(112, 20)
        Contract_TypeLabel.TabIndex = 4
        Contract_TypeLabel.Text = "Contract Type:"
        '
        'EmployeeContract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 589)
        Me.Controls.Add(Me.Employment_ContractsDataGridView)
        Me.Controls.Add(Me.Employment_ContractsBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "EmployeeContract"
        Me.Text = "Employee Contract"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Employment_ContractsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employment_ContractsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Employment_ContractsBindingNavigator.ResumeLayout(False)
        Me.Employment_ContractsBindingNavigator.PerformLayout()
        CType(Me.Employment_ContractsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Cli_LU As Button
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents Employment_ContractsBindingSource As BindingSource
    Friend WithEvents Employment_ContractsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Employment_ContractsTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Employment_ContractsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Employment_ContractsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Contract_IDTextBox As TextBox
    Friend WithEvents Hours_Worked_per_WeekTextBox As TextBox
    Friend WithEvents S_NumTextBox As TextBox
    Friend WithEvents Employment_ContractsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Salary_Payment_TypeComboBox As ComboBox
    Friend WithEvents Contract_TypeComboBox As ComboBox
End Class
