<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllocationBed
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
        Dim Bed_allocation_idLabel As System.Windows.Forms.Label
        Dim Admit_dateLabel As System.Windows.Forms.Label
        Dim Discharge_dateLabel As System.Windows.Forms.Label
        Dim Bed_IDLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Bed_allocation_idTextBox = New System.Windows.Forms.TextBox()
        Me.BedAllocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.Admit_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BEd_LU = New System.Windows.Forms.Button()
        Me.Discharge_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Bed_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BedAllocationsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.BedAllocationsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.BedAllocationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BedAllocationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BedAllocationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Bed_allocation_idLabel = New System.Windows.Forms.Label()
        Admit_dateLabel = New System.Windows.Forms.Label()
        Discharge_dateLabel = New System.Windows.Forms.Label()
        Bed_IDLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BedAllocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BedAllocationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BedAllocationsBindingNavigator.SuspendLayout()
        CType(Me.BedAllocationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bed_allocation_idLabel
        '
        Bed_allocation_idLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Bed_allocation_idLabel.AutoSize = True
        Bed_allocation_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Bed_allocation_idLabel.Location = New System.Drawing.Point(3, 5)
        Bed_allocation_idLabel.Name = "Bed_allocation_idLabel"
        Bed_allocation_idLabel.Size = New System.Drawing.Size(136, 20)
        Bed_allocation_idLabel.TabIndex = 0
        Bed_allocation_idLabel.Text = "Bed Allocation ID:"
        '
        'Admit_dateLabel
        '
        Admit_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Admit_dateLabel.AutoSize = True
        Admit_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Admit_dateLabel.Location = New System.Drawing.Point(3, 35)
        Admit_dateLabel.Name = "Admit_dateLabel"
        Admit_dateLabel.Size = New System.Drawing.Size(93, 20)
        Admit_dateLabel.TabIndex = 2
        Admit_dateLabel.Text = "Admit Date:"
        '
        'Discharge_dateLabel
        '
        Discharge_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Discharge_dateLabel.AutoSize = True
        Discharge_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Discharge_dateLabel.Location = New System.Drawing.Point(3, 65)
        Discharge_dateLabel.Name = "Discharge_dateLabel"
        Discharge_dateLabel.Size = New System.Drawing.Size(124, 20)
        Discharge_dateLabel.TabIndex = 4
        Discharge_dateLabel.Text = "Discharge Date:"
        '
        'Bed_IDLabel
        '
        Bed_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Bed_IDLabel.AutoSize = True
        Bed_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Bed_IDLabel.Location = New System.Drawing.Point(3, 95)
        Bed_IDLabel.Name = "Bed_IDLabel"
        Bed_IDLabel.Size = New System.Drawing.Size(63, 20)
        Bed_IDLabel.TabIndex = 6
        Bed_IDLabel.Text = "Bed ID:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.10345!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.89655!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 63.0!))
        Me.TableLayoutPanel1.Controls.Add(Bed_allocation_idLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Bed_allocation_idTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Admit_dateLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Admit_dateDateTimePicker, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Discharge_dateLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.BEd_LU, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Discharge_dateDateTimePicker, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Bed_IDLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Bed_IDTextBox, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 179)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(421, 121)
        Me.TableLayoutPanel1.TabIndex = 61
        '
        'Bed_allocation_idTextBox
        '
        Me.Bed_allocation_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedAllocationsBindingSource, "bed_allocation_id", True))
        Me.Bed_allocation_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bed_allocation_idTextBox.Location = New System.Drawing.Point(157, 3)
        Me.Bed_allocation_idTextBox.Name = "Bed_allocation_idTextBox"
        Me.Bed_allocation_idTextBox.Size = New System.Drawing.Size(197, 26)
        Me.Bed_allocation_idTextBox.TabIndex = 1
        '
        'BedAllocationsBindingSource
        '
        Me.BedAllocationsBindingSource.DataMember = "BedAllocations"
        Me.BedAllocationsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Admit_dateDateTimePicker
        '
        Me.Admit_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BedAllocationsBindingSource, "admit_date", True))
        Me.Admit_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Admit_dateDateTimePicker.Location = New System.Drawing.Point(157, 33)
        Me.Admit_dateDateTimePicker.Name = "Admit_dateDateTimePicker"
        Me.Admit_dateDateTimePicker.Size = New System.Drawing.Size(197, 26)
        Me.Admit_dateDateTimePicker.TabIndex = 3
        '
        'BEd_LU
        '
        Me.BEd_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BEd_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.BEd_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BEd_LU.ForeColor = System.Drawing.Color.Transparent
        Me.BEd_LU.Location = New System.Drawing.Point(360, 94)
        Me.BEd_LU.Name = "BEd_LU"
        Me.BEd_LU.Size = New System.Drawing.Size(24, 23)
        Me.BEd_LU.TabIndex = 66
        Me.BEd_LU.UseVisualStyleBackColor = True
        '
        'Discharge_dateDateTimePicker
        '
        Me.Discharge_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BedAllocationsBindingSource, "discharge_date", True))
        Me.Discharge_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Discharge_dateDateTimePicker.Location = New System.Drawing.Point(157, 63)
        Me.Discharge_dateDateTimePicker.Name = "Discharge_dateDateTimePicker"
        Me.Discharge_dateDateTimePicker.Size = New System.Drawing.Size(197, 26)
        Me.Discharge_dateDateTimePicker.TabIndex = 5
        '
        'Bed_IDTextBox
        '
        Me.Bed_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedAllocationsBindingSource, "Bed_ID", True))
        Me.Bed_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bed_IDTextBox.Location = New System.Drawing.Point(157, 93)
        Me.Bed_IDTextBox.Name = "Bed_IDTextBox"
        Me.Bed_IDTextBox.Size = New System.Drawing.Size(197, 26)
        Me.Bed_IDTextBox.TabIndex = 7
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
        Me.Panel2.Size = New System.Drawing.Size(601, 81)
        Me.Panel2.TabIndex = 65
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
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(164, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Bed Allocation"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 80)
        Me.Panel1.TabIndex = 66
        '
        'BedAllocationsTableAdapter
        '
        Me.BedAllocationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressesTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedAllocationsTableAdapter = Me.BedAllocationsTableAdapter
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
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'BedAllocationsBindingNavigator
        '
        Me.BedAllocationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BedAllocationsBindingNavigator.BindingSource = Me.BedAllocationsBindingSource
        Me.BedAllocationsBindingNavigator.CountItem = Nothing
        Me.BedAllocationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BedAllocationsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.BedAllocationsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BedAllocationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.BedAllocationsBindingNavigatorSaveItem})
        Me.BedAllocationsBindingNavigator.Location = New System.Drawing.Point(76, 303)
        Me.BedAllocationsBindingNavigator.MoveFirstItem = Nothing
        Me.BedAllocationsBindingNavigator.MoveLastItem = Nothing
        Me.BedAllocationsBindingNavigator.MoveNextItem = Nothing
        Me.BedAllocationsBindingNavigator.MovePreviousItem = Nothing
        Me.BedAllocationsBindingNavigator.Name = "BedAllocationsBindingNavigator"
        Me.BedAllocationsBindingNavigator.PositionItem = Nothing
        Me.BedAllocationsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.BedAllocationsBindingNavigator.TabIndex = 67
        Me.BedAllocationsBindingNavigator.Text = "BindingNavigator1"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BedAllocationsBindingNavigatorSaveItem
        '
        Me.BedAllocationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BedAllocationsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.BedAllocationsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BedAllocationsBindingNavigatorSaveItem.Name = "BedAllocationsBindingNavigatorSaveItem"
        Me.BedAllocationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.BedAllocationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BedAllocationsDataGridView
        '
        Me.BedAllocationsDataGridView.AutoGenerateColumns = False
        Me.BedAllocationsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.BedAllocationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BedAllocationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.BedAllocationsDataGridView.DataSource = Me.BedAllocationsBindingSource
        Me.BedAllocationsDataGridView.Location = New System.Drawing.Point(76, 335)
        Me.BedAllocationsDataGridView.Name = "BedAllocationsDataGridView"
        Me.BedAllocationsDataGridView.Size = New System.Drawing.Size(444, 220)
        Me.BedAllocationsDataGridView.TabIndex = 67
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "bed_allocation_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "bed_allocation_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "admit_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "admit_date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "discharge_date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "discharge_date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Bed_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Bed_ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'AllocationBed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 581)
        Me.Controls.Add(Me.BedAllocationsDataGridView)
        Me.Controls.Add(Me.BedAllocationsBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AllocationBed"
        Me.Text = "a"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BedAllocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BedAllocationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BedAllocationsBindingNavigator.ResumeLayout(False)
        Me.BedAllocationsBindingNavigator.PerformLayout()
        CType(Me.BedAllocationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BEd_LU As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SHeadLB As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents BedAllocationsBindingSource As BindingSource
    Friend WithEvents BedAllocationsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.BedAllocationsTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BedAllocationsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BedAllocationsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Bed_allocation_idTextBox As TextBox
    Friend WithEvents Admit_dateDateTimePicker As DateTimePicker
    Friend WithEvents Discharge_dateDateTimePicker As DateTimePicker
    Friend WithEvents Bed_IDTextBox As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BedAllocationsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
