<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Experience
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
        Dim Wex_IDLabel As System.Windows.Forms.Label
        Dim OrganizationLabel As System.Windows.Forms.Label
        Dim PositionLabel As System.Windows.Forms.Label
        Dim Start_DateLabel As System.Windows.Forms.Label
        Dim End_DateLabel As System.Windows.Forms.Label
        Dim S_NumLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Wex_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Work_ExperienceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.OrganizationTextBox = New System.Windows.Forms.TextBox()
        Me.S_LU = New System.Windows.Forms.Button()
        Me.PositionTextBox = New System.Windows.Forms.TextBox()
        Me.Start_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.End_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.S_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Work_ExperienceTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Work_ExperienceTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Work_ExperienceBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Work_ExperienceBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Work_ExperienceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Wex_IDLabel = New System.Windows.Forms.Label()
        OrganizationLabel = New System.Windows.Forms.Label()
        PositionLabel = New System.Windows.Forms.Label()
        Start_DateLabel = New System.Windows.Forms.Label()
        End_DateLabel = New System.Windows.Forms.Label()
        S_NumLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Work_ExperienceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_ExperienceBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Work_ExperienceBindingNavigator.SuspendLayout()
        CType(Me.Work_ExperienceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Wex_IDLabel
        '
        Wex_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Wex_IDLabel.AutoSize = True
        Wex_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Wex_IDLabel.Location = New System.Drawing.Point(3, 5)
        Wex_IDLabel.Name = "Wex_IDLabel"
        Wex_IDLabel.Size = New System.Drawing.Size(65, 20)
        Wex_IDLabel.TabIndex = 0
        Wex_IDLabel.Text = "Wex ID:"
        '
        'OrganizationLabel
        '
        OrganizationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        OrganizationLabel.AutoSize = True
        OrganizationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        OrganizationLabel.Location = New System.Drawing.Point(3, 36)
        OrganizationLabel.Name = "OrganizationLabel"
        OrganizationLabel.Size = New System.Drawing.Size(103, 20)
        OrganizationLabel.TabIndex = 2
        OrganizationLabel.Text = "Organization:"
        '
        'PositionLabel
        '
        PositionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        PositionLabel.AutoSize = True
        PositionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        PositionLabel.Location = New System.Drawing.Point(3, 67)
        PositionLabel.Name = "PositionLabel"
        PositionLabel.Size = New System.Drawing.Size(69, 20)
        PositionLabel.TabIndex = 4
        PositionLabel.Text = "Position:"
        '
        'Start_DateLabel
        '
        Start_DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Start_DateLabel.AutoSize = True
        Start_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Start_DateLabel.Location = New System.Drawing.Point(3, 98)
        Start_DateLabel.Name = "Start_DateLabel"
        Start_DateLabel.Size = New System.Drawing.Size(87, 20)
        Start_DateLabel.TabIndex = 6
        Start_DateLabel.Text = "Start Date:"
        '
        'End_DateLabel
        '
        End_DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        End_DateLabel.AutoSize = True
        End_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        End_DateLabel.Location = New System.Drawing.Point(3, 129)
        End_DateLabel.Name = "End_DateLabel"
        End_DateLabel.Size = New System.Drawing.Size(81, 20)
        End_DateLabel.TabIndex = 8
        End_DateLabel.Text = "End Date:"
        '
        'S_NumLabel
        '
        S_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        S_NumLabel.AutoSize = True
        S_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        S_NumLabel.Location = New System.Drawing.Point(3, 160)
        S_NumLabel.Name = "S_NumLabel"
        S_NumLabel.Size = New System.Drawing.Size(108, 20)
        S_NumLabel.TabIndex = 10
        S_NumLabel.Text = "Staff Number:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 80)
        Me.Panel1.TabIndex = 58
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(191, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Work Experience"
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
        Me.Panel2.Size = New System.Drawing.Size(800, 81)
        Me.Panel2.TabIndex = 57
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.42553!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.57447!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Controls.Add(Wex_IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Wex_IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(OrganizationLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.OrganizationTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(PositionLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.S_LU, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.PositionTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Start_DateLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Start_DateDateTimePicker, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(End_DateLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.End_DateDateTimePicker, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(S_NumLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.S_NumTextBox, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 167)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(403, 219)
        Me.TableLayoutPanel1.TabIndex = 74
        '
        'Wex_IDTextBox
        '
        Me.Wex_IDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Wex_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "Wex_ID", True))
        Me.Wex_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Wex_IDTextBox.Location = New System.Drawing.Point(143, 3)
        Me.Wex_IDTextBox.Name = "Wex_IDTextBox"
        Me.Wex_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.Wex_IDTextBox.TabIndex = 1
        '
        'Work_ExperienceBindingSource
        '
        Me.Work_ExperienceBindingSource.DataMember = "Work_Experience"
        Me.Work_ExperienceBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrganizationTextBox
        '
        Me.OrganizationTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.OrganizationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "Organization", True))
        Me.OrganizationTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OrganizationTextBox.Location = New System.Drawing.Point(143, 34)
        Me.OrganizationTextBox.Name = "OrganizationTextBox"
        Me.OrganizationTextBox.Size = New System.Drawing.Size(200, 26)
        Me.OrganizationTextBox.TabIndex = 3
        '
        'S_LU
        '
        Me.S_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.S_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_LU.ForeColor = System.Drawing.Color.Transparent
        Me.S_LU.Location = New System.Drawing.Point(350, 159)
        Me.S_LU.Name = "S_LU"
        Me.S_LU.Size = New System.Drawing.Size(24, 22)
        Me.S_LU.TabIndex = 71
        Me.S_LU.UseVisualStyleBackColor = True
        '
        'PositionTextBox
        '
        Me.PositionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "Position", True))
        Me.PositionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PositionTextBox.Location = New System.Drawing.Point(143, 65)
        Me.PositionTextBox.Name = "PositionTextBox"
        Me.PositionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PositionTextBox.TabIndex = 5
        '
        'Start_DateDateTimePicker
        '
        Me.Start_DateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Start_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Work_ExperienceBindingSource, "Start_Date", True))
        Me.Start_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Start_DateDateTimePicker.Location = New System.Drawing.Point(143, 96)
        Me.Start_DateDateTimePicker.Name = "Start_DateDateTimePicker"
        Me.Start_DateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Start_DateDateTimePicker.TabIndex = 7
        '
        'End_DateDateTimePicker
        '
        Me.End_DateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.End_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Work_ExperienceBindingSource, "End_Date", True))
        Me.End_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.End_DateDateTimePicker.Location = New System.Drawing.Point(143, 127)
        Me.End_DateDateTimePicker.Name = "End_DateDateTimePicker"
        Me.End_DateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.End_DateDateTimePicker.TabIndex = 9
        '
        'S_NumTextBox
        '
        Me.S_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "S_Num", True))
        Me.S_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.S_NumTextBox.Location = New System.Drawing.Point(143, 158)
        Me.S_NumTextBox.Name = "S_NumTextBox"
        Me.S_NumTextBox.Size = New System.Drawing.Size(200, 26)
        Me.S_NumTextBox.TabIndex = 11
        '
        'Work_ExperienceTableAdapter
        '
        Me.Work_ExperienceTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Me.Work_ExperienceTableAdapter
        '
        'Work_ExperienceBindingNavigator
        '
        Me.Work_ExperienceBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Work_ExperienceBindingNavigator.BindingSource = Me.Work_ExperienceBindingSource
        Me.Work_ExperienceBindingNavigator.CountItem = Nothing
        Me.Work_ExperienceBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Work_ExperienceBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Work_ExperienceBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Work_ExperienceBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator1, Me.Work_ExperienceBindingNavigatorSaveItem})
        Me.Work_ExperienceBindingNavigator.Location = New System.Drawing.Point(76, 389)
        Me.Work_ExperienceBindingNavigator.MoveFirstItem = Nothing
        Me.Work_ExperienceBindingNavigator.MoveLastItem = Nothing
        Me.Work_ExperienceBindingNavigator.MoveNextItem = Nothing
        Me.Work_ExperienceBindingNavigator.MovePreviousItem = Nothing
        Me.Work_ExperienceBindingNavigator.Name = "Work_ExperienceBindingNavigator"
        Me.Work_ExperienceBindingNavigator.PositionItem = Nothing
        Me.Work_ExperienceBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.Work_ExperienceBindingNavigator.TabIndex = 75
        Me.Work_ExperienceBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'Work_ExperienceBindingNavigatorSaveItem
        '
        Me.Work_ExperienceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Work_ExperienceBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.Work_ExperienceBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Work_ExperienceBindingNavigatorSaveItem.Name = "Work_ExperienceBindingNavigatorSaveItem"
        Me.Work_ExperienceBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.Work_ExperienceBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Work_ExperienceDataGridView
        '
        Me.Work_ExperienceDataGridView.AutoGenerateColumns = False
        Me.Work_ExperienceDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.Work_ExperienceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Work_ExperienceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.Work_ExperienceDataGridView.DataSource = Me.Work_ExperienceBindingSource
        Me.Work_ExperienceDataGridView.Location = New System.Drawing.Point(76, 421)
        Me.Work_ExperienceDataGridView.Name = "Work_ExperienceDataGridView"
        Me.Work_ExperienceDataGridView.Size = New System.Drawing.Size(644, 220)
        Me.Work_ExperienceDataGridView.TabIndex = 75
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Wex_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Wex_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Organization"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Organization"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Position"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Position"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Start_Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Start_Date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "End_Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "End_Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "S_Num"
        Me.DataGridViewTextBoxColumn6.HeaderText = "S_Num"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Experience
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 769)
        Me.Controls.Add(Me.Work_ExperienceDataGridView)
        Me.Controls.Add(Me.Work_ExperienceBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Experience"
        Me.Text = "Work Experience"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Work_ExperienceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_ExperienceBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Work_ExperienceBindingNavigator.ResumeLayout(False)
        Me.Work_ExperienceBindingNavigator.PerformLayout()
        CType(Me.Work_ExperienceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents S_LU As Button
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents Work_ExperienceBindingSource As BindingSource
    Friend WithEvents Work_ExperienceTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Work_ExperienceTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Work_ExperienceBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents Work_ExperienceBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Wex_IDTextBox As TextBox
    Friend WithEvents OrganizationTextBox As TextBox
    Friend WithEvents PositionTextBox As TextBox
    Friend WithEvents Start_DateDateTimePicker As DateTimePicker
    Friend WithEvents End_DateDateTimePicker As DateTimePicker
    Friend WithEvents S_NumTextBox As TextBox
    Friend WithEvents Work_ExperienceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
