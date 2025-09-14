<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Medication_Details
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
        Dim Medication_noLabel As System.Windows.Forms.Label
        Dim Order_noLabel As System.Windows.Forms.Label
        Dim Start_dateLabel As System.Windows.Forms.Label
        Dim Finish_dateLabel As System.Windows.Forms.Label
        Dim Drug_noLabel As System.Windows.Forms.Label
        Me.DatabaseG26DataSetReq_Details = New WellMeadows_Hospital_G26.DatabaseG26DataSetReq_Details()
        Me.Medication_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Medication_DetailsTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSetReq_DetailsTableAdapters.Medication_DetailsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSetReq_DetailsTableAdapters.TableAdapterManager()
        Me.Medication_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Medication_noTextBox = New System.Windows.Forms.TextBox()
        Me.Order_noTextBox = New System.Windows.Forms.TextBox()
        Me.Start_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Finish_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Drug_noTextBox = New System.Windows.Forms.TextBox()
        Me.Medication_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Pharma_LU = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Medication_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Medication_noLabel = New System.Windows.Forms.Label()
        Order_noLabel = New System.Windows.Forms.Label()
        Start_dateLabel = New System.Windows.Forms.Label()
        Finish_dateLabel = New System.Windows.Forms.Label()
        Drug_noLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseG26DataSetReq_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medication_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Medication_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Medication_DetailsBindingNavigator.SuspendLayout()
        CType(Me.Medication_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Medication_noLabel
        '
        Medication_noLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Medication_noLabel.AutoSize = True
        Medication_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Medication_noLabel.Location = New System.Drawing.Point(3, 7)
        Medication_noLabel.Name = "Medication_noLabel"
        Medication_noLabel.Size = New System.Drawing.Size(114, 20)
        Medication_noLabel.TabIndex = 38
        Medication_noLabel.Text = "Medication No:"
        '
        'Order_noLabel
        '
        Order_noLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Order_noLabel.AutoSize = True
        Order_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Order_noLabel.Location = New System.Drawing.Point(3, 41)
        Order_noLabel.Name = "Order_noLabel"
        Order_noLabel.Size = New System.Drawing.Size(77, 20)
        Order_noLabel.TabIndex = 40
        Order_noLabel.Text = "Order No:"
        '
        'Start_dateLabel
        '
        Start_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Start_dateLabel.AutoSize = True
        Start_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Start_dateLabel.Location = New System.Drawing.Point(3, 75)
        Start_dateLabel.Name = "Start_dateLabel"
        Start_dateLabel.Size = New System.Drawing.Size(87, 20)
        Start_dateLabel.TabIndex = 42
        Start_dateLabel.Text = "Start Date:"
        '
        'Finish_dateLabel
        '
        Finish_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Finish_dateLabel.AutoSize = True
        Finish_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Finish_dateLabel.Location = New System.Drawing.Point(3, 109)
        Finish_dateLabel.Name = "Finish_dateLabel"
        Finish_dateLabel.Size = New System.Drawing.Size(94, 20)
        Finish_dateLabel.TabIndex = 44
        Finish_dateLabel.Text = "Finish Date:"
        '
        'Drug_noLabel
        '
        Drug_noLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Drug_noLabel.AutoSize = True
        Drug_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Drug_noLabel.Location = New System.Drawing.Point(3, 143)
        Drug_noLabel.Name = "Drug_noLabel"
        Drug_noLabel.Size = New System.Drawing.Size(72, 20)
        Drug_noLabel.TabIndex = 46
        Drug_noLabel.Text = "Drug No:"
        '
        'DatabaseG26DataSetReq_Details
        '
        Me.DatabaseG26DataSetReq_Details.DataSetName = "DatabaseG26DataSetReq_Details"
        Me.DatabaseG26DataSetReq_Details.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Medication_DetailsBindingSource
        '
        Me.Medication_DetailsBindingSource.DataMember = "Medication_Details"
        Me.Medication_DetailsBindingSource.DataSource = Me.DatabaseG26DataSetReq_Details
        '
        'Medication_DetailsTableAdapter
        '
        Me.Medication_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DrugReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Medication_DetailsTableAdapter = Me.Medication_DetailsTableAdapter
        Me.TableAdapterManager.SurgicalReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSetReq_DetailsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Medication_DetailsBindingNavigator
        '
        Me.Medication_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Medication_DetailsBindingNavigator.BindingSource = Me.Medication_DetailsBindingSource
        Me.Medication_DetailsBindingNavigator.CountItem = Nothing
        Me.Medication_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Medication_DetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Medication_DetailsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Medication_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.Medication_DetailsBindingNavigatorSaveItem})
        Me.Medication_DetailsBindingNavigator.Location = New System.Drawing.Point(76, 370)
        Me.Medication_DetailsBindingNavigator.MoveFirstItem = Nothing
        Me.Medication_DetailsBindingNavigator.MoveLastItem = Nothing
        Me.Medication_DetailsBindingNavigator.MoveNextItem = Nothing
        Me.Medication_DetailsBindingNavigator.MovePreviousItem = Nothing
        Me.Medication_DetailsBindingNavigator.Name = "Medication_DetailsBindingNavigator"
        Me.Medication_DetailsBindingNavigator.PositionItem = Nothing
        Me.Medication_DetailsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.Medication_DetailsBindingNavigator.TabIndex = 38
        Me.Medication_DetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'Medication_noTextBox
        '
        Me.Medication_noTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Medication_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medication_DetailsBindingSource, "medication_no", True))
        Me.Medication_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Medication_noTextBox.Location = New System.Drawing.Point(129, 4)
        Me.Medication_noTextBox.Name = "Medication_noTextBox"
        Me.Medication_noTextBox.Size = New System.Drawing.Size(195, 26)
        Me.Medication_noTextBox.TabIndex = 39
        '
        'Order_noTextBox
        '
        Me.Order_noTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Order_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medication_DetailsBindingSource, "order_no", True))
        Me.Order_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Order_noTextBox.Location = New System.Drawing.Point(129, 38)
        Me.Order_noTextBox.Name = "Order_noTextBox"
        Me.Order_noTextBox.Size = New System.Drawing.Size(195, 26)
        Me.Order_noTextBox.TabIndex = 41
        '
        'Start_dateDateTimePicker
        '
        Me.Start_dateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Start_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Medication_DetailsBindingSource, "start_date", True))
        Me.Start_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Start_dateDateTimePicker.Location = New System.Drawing.Point(129, 72)
        Me.Start_dateDateTimePicker.Name = "Start_dateDateTimePicker"
        Me.Start_dateDateTimePicker.Size = New System.Drawing.Size(195, 26)
        Me.Start_dateDateTimePicker.TabIndex = 43
        '
        'Finish_dateDateTimePicker
        '
        Me.Finish_dateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Finish_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Medication_DetailsBindingSource, "finish_date", True))
        Me.Finish_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Finish_dateDateTimePicker.Location = New System.Drawing.Point(129, 106)
        Me.Finish_dateDateTimePicker.Name = "Finish_dateDateTimePicker"
        Me.Finish_dateDateTimePicker.Size = New System.Drawing.Size(195, 26)
        Me.Finish_dateDateTimePicker.TabIndex = 45
        '
        'Drug_noTextBox
        '
        Me.Drug_noTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Drug_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Medication_DetailsBindingSource, "drug_no", True))
        Me.Drug_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Drug_noTextBox.Location = New System.Drawing.Point(129, 140)
        Me.Drug_noTextBox.Name = "Drug_noTextBox"
        Me.Drug_noTextBox.Size = New System.Drawing.Size(195, 26)
        Me.Drug_noTextBox.TabIndex = 47
        '
        'Medication_DetailsDataGridView
        '
        Me.Medication_DetailsDataGridView.AutoGenerateColumns = False
        Me.Medication_DetailsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.Medication_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Medication_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Medication_DetailsDataGridView.DataSource = Me.Medication_DetailsBindingSource
        Me.Medication_DetailsDataGridView.Location = New System.Drawing.Point(76, 412)
        Me.Medication_DetailsDataGridView.Name = "Medication_DetailsDataGridView"
        Me.Medication_DetailsDataGridView.Size = New System.Drawing.Size(543, 220)
        Me.Medication_DetailsDataGridView.TabIndex = 47
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "medication_no"
        Me.DataGridViewTextBoxColumn1.HeaderText = "medication_no"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "order_no"
        Me.DataGridViewTextBoxColumn2.HeaderText = "order_no"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "start_date"
        Me.DataGridViewTextBoxColumn3.HeaderText = "start_date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "finish_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "finish_date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "drug_no"
        Me.DataGridViewTextBoxColumn5.HeaderText = "drug_no"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(699, 80)
        Me.Panel1.TabIndex = 70
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(234, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Medication Requition"
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
        Me.Panel2.Size = New System.Drawing.Size(699, 81)
        Me.Panel2.TabIndex = 69
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.80685!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.14425!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0489!))
        Me.TableLayoutPanel1.Controls.Add(Medication_noLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Order_noLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Start_dateLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Finish_dateLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Medication_noTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Drug_noLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Order_noTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Pharma_LU, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Start_dateDateTimePicker, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Drug_noTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Finish_dateDateTimePicker, 1, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 180)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(409, 171)
        Me.TableLayoutPanel1.TabIndex = 71
        '
        'Pharma_LU
        '
        Me.Pharma_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Pharma_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Pharma_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pharma_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Pharma_LU.Location = New System.Drawing.Point(330, 142)
        Me.Pharma_LU.Name = "Pharma_LU"
        Me.Pharma_LU.Size = New System.Drawing.Size(24, 23)
        Me.Pharma_LU.TabIndex = 50
        Me.Pharma_LU.UseVisualStyleBackColor = True
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
        'Medication_DetailsBindingNavigatorSaveItem
        '
        Me.Medication_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Medication_DetailsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.Medication_DetailsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Medication_DetailsBindingNavigatorSaveItem.Name = "Medication_DetailsBindingNavigatorSaveItem"
        Me.Medication_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.Medication_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Medication_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 702)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Medication_DetailsDataGridView)
        Me.Controls.Add(Me.Medication_DetailsBindingNavigator)
        Me.Name = "Medication_Details"
        Me.Text = "Medication_Details"
        CType(Me.DatabaseG26DataSetReq_Details, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medication_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Medication_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Medication_DetailsBindingNavigator.ResumeLayout(False)
        Me.Medication_DetailsBindingNavigator.PerformLayout()
        CType(Me.Medication_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseG26DataSetReq_Details As DatabaseG26DataSetReq_Details
    Friend WithEvents Medication_DetailsBindingSource As BindingSource
    Friend WithEvents Medication_DetailsTableAdapter As DatabaseG26DataSetReq_DetailsTableAdapters.Medication_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSetReq_DetailsTableAdapters.TableAdapterManager
    Friend WithEvents Medication_DetailsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Medication_DetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Medication_noTextBox As TextBox
    Friend WithEvents Order_noTextBox As TextBox
    Friend WithEvents Start_dateDateTimePicker As DateTimePicker
    Friend WithEvents Finish_dateDateTimePicker As DateTimePicker
    Friend WithEvents Drug_noTextBox As TextBox
    Friend WithEvents Medication_DetailsDataGridView As DataGridView
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
    Friend WithEvents Pharma_LU As Button
End Class
