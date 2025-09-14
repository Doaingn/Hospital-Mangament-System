<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shift
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
        Dim Shift_IDLabel As System.Windows.Forms.Label
        Dim Shift_TypeLabel As System.Windows.Forms.Label
        Dim Start_TimeLabel As System.Windows.Forms.Label
        Dim End_TimeLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Shift_IDTextBox = New System.Windows.Forms.TextBox()
        Me.ShiftsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.Shift_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Start_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.End_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.ShiftsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.ShiftsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.ShiftsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShiftsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ShiftsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Shift_IDLabel = New System.Windows.Forms.Label()
        Shift_TypeLabel = New System.Windows.Forms.Label()
        Start_TimeLabel = New System.Windows.Forms.Label()
        End_TimeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ShiftsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShiftsBindingNavigator.SuspendLayout()
        CType(Me.ShiftsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Shift_IDLabel
        '
        Shift_IDLabel.AutoSize = True
        Shift_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Shift_IDLabel.Location = New System.Drawing.Point(3, 0)
        Shift_IDLabel.Name = "Shift_IDLabel"
        Shift_IDLabel.Size = New System.Drawing.Size(67, 20)
        Shift_IDLabel.TabIndex = 0
        Shift_IDLabel.Text = "Shift ID:"
        '
        'Shift_TypeLabel
        '
        Shift_TypeLabel.AutoSize = True
        Shift_TypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Shift_TypeLabel.Location = New System.Drawing.Point(3, 30)
        Shift_TypeLabel.Name = "Shift_TypeLabel"
        Shift_TypeLabel.Size = New System.Drawing.Size(84, 20)
        Shift_TypeLabel.TabIndex = 2
        Shift_TypeLabel.Text = "Shift Type:"
        '
        'Start_TimeLabel
        '
        Start_TimeLabel.AutoSize = True
        Start_TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Start_TimeLabel.Location = New System.Drawing.Point(3, 60)
        Start_TimeLabel.Name = "Start_TimeLabel"
        Start_TimeLabel.Size = New System.Drawing.Size(86, 20)
        Start_TimeLabel.TabIndex = 4
        Start_TimeLabel.Text = "Start Time:"
        '
        'End_TimeLabel
        '
        End_TimeLabel.AutoSize = True
        End_TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        End_TimeLabel.Location = New System.Drawing.Point(3, 90)
        End_TimeLabel.Name = "End_TimeLabel"
        End_TimeLabel.Size = New System.Drawing.Size(80, 20)
        End_TimeLabel.TabIndex = 6
        End_TimeLabel.Text = "End Time:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(599, 80)
        Me.Panel1.TabIndex = 54
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(60, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Shift"
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
        Me.Panel2.Size = New System.Drawing.Size(599, 81)
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
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.53251!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.46749!))
        Me.TableLayoutPanel1.Controls.Add(Shift_IDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Shift_IDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Shift_TypeLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Shift_TypeTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Start_TimeLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Start_TimeTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(End_TimeLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.End_TimeTextBox, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 167)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(289, 121)
        Me.TableLayoutPanel1.TabIndex = 72
        '
        'Shift_IDTextBox
        '
        Me.Shift_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShiftsBindingSource, "Shift_ID", True))
        Me.Shift_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Shift_IDTextBox.Location = New System.Drawing.Point(108, 3)
        Me.Shift_IDTextBox.Name = "Shift_IDTextBox"
        Me.Shift_IDTextBox.Size = New System.Drawing.Size(165, 26)
        Me.Shift_IDTextBox.TabIndex = 1
        '
        'ShiftsBindingSource
        '
        Me.ShiftsBindingSource.DataMember = "Shifts"
        Me.ShiftsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Shift_TypeTextBox
        '
        Me.Shift_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShiftsBindingSource, "Shift_Type", True))
        Me.Shift_TypeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Shift_TypeTextBox.Location = New System.Drawing.Point(108, 33)
        Me.Shift_TypeTextBox.Name = "Shift_TypeTextBox"
        Me.Shift_TypeTextBox.Size = New System.Drawing.Size(165, 26)
        Me.Shift_TypeTextBox.TabIndex = 3
        '
        'Start_TimeTextBox
        '
        Me.Start_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShiftsBindingSource, "Start_Time", True))
        Me.Start_TimeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Start_TimeTextBox.Location = New System.Drawing.Point(108, 63)
        Me.Start_TimeTextBox.Name = "Start_TimeTextBox"
        Me.Start_TimeTextBox.Size = New System.Drawing.Size(168, 26)
        Me.Start_TimeTextBox.TabIndex = 5
        '
        'End_TimeTextBox
        '
        Me.End_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ShiftsBindingSource, "End_Time", True))
        Me.End_TimeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.End_TimeTextBox.Location = New System.Drawing.Point(108, 93)
        Me.End_TimeTextBox.Name = "End_TimeTextBox"
        Me.End_TimeTextBox.Size = New System.Drawing.Size(165, 26)
        Me.End_TimeTextBox.TabIndex = 7
        '
        'ShiftsTableAdapter
        '
        Me.ShiftsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ShiftsTableAdapter = Me.ShiftsTableAdapter
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
        'ShiftsBindingNavigator
        '
        Me.ShiftsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ShiftsBindingNavigator.BindingSource = Me.ShiftsBindingSource
        Me.ShiftsBindingNavigator.CountItem = Nothing
        Me.ShiftsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ShiftsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ShiftsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ShiftsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.ShiftsBindingNavigatorSaveItem})
        Me.ShiftsBindingNavigator.Location = New System.Drawing.Point(76, 291)
        Me.ShiftsBindingNavigator.MoveFirstItem = Nothing
        Me.ShiftsBindingNavigator.MoveLastItem = Nothing
        Me.ShiftsBindingNavigator.MoveNextItem = Nothing
        Me.ShiftsBindingNavigator.MovePreviousItem = Nothing
        Me.ShiftsBindingNavigator.Name = "ShiftsBindingNavigator"
        Me.ShiftsBindingNavigator.PositionItem = Nothing
        Me.ShiftsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.ShiftsBindingNavigator.TabIndex = 73
        Me.ShiftsBindingNavigator.Text = "BindingNavigator1"
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
        'ShiftsBindingNavigatorSaveItem
        '
        Me.ShiftsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ShiftsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.ShiftsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ShiftsBindingNavigatorSaveItem.Name = "ShiftsBindingNavigatorSaveItem"
        Me.ShiftsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.ShiftsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ShiftsDataGridView
        '
        Me.ShiftsDataGridView.AutoGenerateColumns = False
        Me.ShiftsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.ShiftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShiftsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.ShiftsDataGridView.DataSource = Me.ShiftsBindingSource
        Me.ShiftsDataGridView.Location = New System.Drawing.Point(76, 323)
        Me.ShiftsDataGridView.Name = "ShiftsDataGridView"
        Me.ShiftsDataGridView.Size = New System.Drawing.Size(443, 220)
        Me.ShiftsDataGridView.TabIndex = 73
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Shift_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Shift_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Shift_Type"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Shift_Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Start_Time"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Start_Time"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "End_Time"
        Me.DataGridViewTextBoxColumn4.HeaderText = "End_Time"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Shift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 570)
        Me.Controls.Add(Me.ShiftsDataGridView)
        Me.Controls.Add(Me.ShiftsBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Shift"
        Me.Text = "Shift"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ShiftsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShiftsBindingNavigator.ResumeLayout(False)
        Me.ShiftsBindingNavigator.PerformLayout()
        CType(Me.ShiftsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents ShiftsBindingSource As BindingSource
    Friend WithEvents ShiftsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.ShiftsTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ShiftsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ShiftsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Shift_IDTextBox As TextBox
    Friend WithEvents Shift_TypeTextBox As TextBox
    Friend WithEvents Start_TimeTextBox As TextBox
    Friend WithEvents End_TimeTextBox As TextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ShiftsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
