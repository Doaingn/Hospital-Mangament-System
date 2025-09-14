<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllocationWard
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
        Dim Allocation_idLabel As System.Windows.Forms.Label
        Dim WaitingListDateLabel As System.Windows.Forms.Label
        Dim Expected_stayLabel As System.Windows.Forms.Label
        Dim Date_placedLabel As System.Windows.Forms.Label
        Dim Date_leaveLabel As System.Windows.Forms.Label
        Dim Date_actual_leaveLabel As System.Windows.Forms.Label
        Dim W_NumLabel As System.Windows.Forms.Label
        Dim P_NumLabel As System.Windows.Forms.Label
        Dim Bed_allocation_idLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Allocation_idTextBox = New System.Windows.Forms.TextBox()
        Me.Ward_AllocationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.Expected_stayTextBox = New System.Windows.Forms.TextBox()
        Me.Date_leaveDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WaitingListDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_placedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_actual_leaveDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.P_NumTextBox = New System.Windows.Forms.TextBox()
        Me.W_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Bed_allocation_idTextBox = New System.Windows.Forms.TextBox()
        Me.BA_LU = New System.Windows.Forms.Button()
        Me.P_LU = New System.Windows.Forms.Button()
        Me.W_LU = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Ward_AllocationsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.Ward_AllocationsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.Ward_AllocationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Ward_AllocationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Ward_AllocationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Allocation_idLabel = New System.Windows.Forms.Label()
        WaitingListDateLabel = New System.Windows.Forms.Label()
        Expected_stayLabel = New System.Windows.Forms.Label()
        Date_placedLabel = New System.Windows.Forms.Label()
        Date_leaveLabel = New System.Windows.Forms.Label()
        Date_actual_leaveLabel = New System.Windows.Forms.Label()
        W_NumLabel = New System.Windows.Forms.Label()
        P_NumLabel = New System.Windows.Forms.Label()
        Bed_allocation_idLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Ward_AllocationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ward_AllocationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ward_AllocationsBindingNavigator.SuspendLayout()
        CType(Me.Ward_AllocationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Allocation_idLabel
        '
        Allocation_idLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Allocation_idLabel.AutoSize = True
        Allocation_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Allocation_idLabel.Location = New System.Drawing.Point(3, 8)
        Allocation_idLabel.Name = "Allocation_idLabel"
        Allocation_idLabel.Size = New System.Drawing.Size(103, 20)
        Allocation_idLabel.TabIndex = 0
        Allocation_idLabel.Text = "Allocation ID:"
        '
        'WaitingListDateLabel
        '
        WaitingListDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        WaitingListDateLabel.AutoSize = True
        WaitingListDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        WaitingListDateLabel.Location = New System.Drawing.Point(3, 118)
        WaitingListDateLabel.Name = "WaitingListDateLabel"
        WaitingListDateLabel.Size = New System.Drawing.Size(134, 20)
        WaitingListDateLabel.TabIndex = 2
        WaitingListDateLabel.Text = "Waiting List Date:"
        '
        'Expected_stayLabel
        '
        Expected_stayLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Expected_stayLabel.AutoSize = True
        Expected_stayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Expected_stayLabel.Location = New System.Drawing.Point(3, 152)
        Expected_stayLabel.Name = "Expected_stayLabel"
        Expected_stayLabel.Size = New System.Drawing.Size(116, 20)
        Expected_stayLabel.TabIndex = 4
        Expected_stayLabel.Text = "Expected Stay:"
        '
        'Date_placedLabel
        '
        Date_placedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_placedLabel.AutoSize = True
        Date_placedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_placedLabel.Location = New System.Drawing.Point(480, 44)
        Date_placedLabel.Name = "Date_placedLabel"
        Date_placedLabel.Size = New System.Drawing.Size(100, 20)
        Date_placedLabel.TabIndex = 6
        Date_placedLabel.Text = "Date Placed:"
        '
        'Date_leaveLabel
        '
        Date_leaveLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_leaveLabel.AutoSize = True
        Date_leaveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_leaveLabel.Location = New System.Drawing.Point(3, 186)
        Date_leaveLabel.Name = "Date_leaveLabel"
        Date_leaveLabel.Size = New System.Drawing.Size(95, 20)
        Date_leaveLabel.TabIndex = 8
        Date_leaveLabel.Text = "Date Leave:"
        '
        'Date_actual_leaveLabel
        '
        Date_actual_leaveLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Date_actual_leaveLabel.AutoSize = True
        Date_actual_leaveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Date_actual_leaveLabel.Location = New System.Drawing.Point(480, 80)
        Date_actual_leaveLabel.Name = "Date_actual_leaveLabel"
        Date_actual_leaveLabel.Size = New System.Drawing.Size(144, 20)
        Date_actual_leaveLabel.TabIndex = 10
        Date_actual_leaveLabel.Text = "Date Actual Leave:"
        '
        'W_NumLabel
        '
        W_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        W_NumLabel.AutoSize = True
        W_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        W_NumLabel.Location = New System.Drawing.Point(3, 80)
        W_NumLabel.Name = "W_NumLabel"
        W_NumLabel.Size = New System.Drawing.Size(111, 20)
        W_NumLabel.TabIndex = 12
        W_NumLabel.Text = "Ward Number:"
        '
        'P_NumLabel
        '
        P_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        P_NumLabel.AutoSize = True
        P_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        P_NumLabel.Location = New System.Drawing.Point(3, 44)
        P_NumLabel.Name = "P_NumLabel"
        P_NumLabel.Size = New System.Drawing.Size(123, 20)
        P_NumLabel.TabIndex = 14
        P_NumLabel.Text = "Patient Number:"
        '
        'Bed_allocation_idLabel
        '
        Bed_allocation_idLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Bed_allocation_idLabel.AutoSize = True
        Bed_allocation_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Bed_allocation_idLabel.Location = New System.Drawing.Point(480, 8)
        Bed_allocation_idLabel.Name = "Bed_allocation_idLabel"
        Bed_allocation_idLabel.Size = New System.Drawing.Size(136, 20)
        Bed_allocation_idLabel.TabIndex = 16
        Bed_allocation_idLabel.Text = "Bed Allocation ID:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.20513!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.8718!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15385!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.15385!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.25641!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.15385!))
        Me.TableLayoutPanel1.Controls.Add(Allocation_idLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Allocation_idTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(P_NumLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.P_NumTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(W_NumLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.W_NumTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.W_LU, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(WaitingListDateLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.WaitingListDateDateTimePicker, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Expected_stayLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Expected_stayTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Date_leaveLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Date_leaveDateTimePicker, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.P_LU, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.BA_LU, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Bed_allocation_idLabel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Date_placedLabel, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Date_placedDateTimePicker, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Date_actual_leaveLabel, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Date_actual_leaveDateTimePicker, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Bed_allocation_idTextBox, 4, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 167)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87598!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87598!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87598!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.8383!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.65777!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87598!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(971, 215)
        Me.TableLayoutPanel1.TabIndex = 67
        '
        'Allocation_idTextBox
        '
        Me.Allocation_idTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Allocation_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ward_AllocationsBindingSource, "allocation_id", True))
        Me.Allocation_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Allocation_idTextBox.Location = New System.Drawing.Point(160, 5)
        Me.Allocation_idTextBox.Name = "Allocation_idTextBox"
        Me.Allocation_idTextBox.Size = New System.Drawing.Size(168, 26)
        Me.Allocation_idTextBox.TabIndex = 1
        '
        'Ward_AllocationsBindingSource
        '
        Me.Ward_AllocationsBindingSource.DataMember = "Ward_Allocations"
        Me.Ward_AllocationsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Expected_stayTextBox
        '
        Me.Expected_stayTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Expected_stayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ward_AllocationsBindingSource, "expected_stay", True))
        Me.Expected_stayTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Expected_stayTextBox.Location = New System.Drawing.Point(160, 151)
        Me.Expected_stayTextBox.Name = "Expected_stayTextBox"
        Me.Expected_stayTextBox.Size = New System.Drawing.Size(168, 26)
        Me.Expected_stayTextBox.TabIndex = 5
        '
        'Date_leaveDateTimePicker
        '
        Me.Date_leaveDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Date_leaveDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Ward_AllocationsBindingSource, "date_leave", True))
        Me.Date_leaveDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_leaveDateTimePicker.Location = New System.Drawing.Point(160, 183)
        Me.Date_leaveDateTimePicker.Name = "Date_leaveDateTimePicker"
        Me.Date_leaveDateTimePicker.Size = New System.Drawing.Size(168, 26)
        Me.Date_leaveDateTimePicker.TabIndex = 9
        '
        'WaitingListDateDateTimePicker
        '
        Me.WaitingListDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.WaitingListDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Ward_AllocationsBindingSource, "waitingListDate", True))
        Me.WaitingListDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.WaitingListDateDateTimePicker.Location = New System.Drawing.Point(160, 115)
        Me.WaitingListDateDateTimePicker.Name = "WaitingListDateDateTimePicker"
        Me.WaitingListDateDateTimePicker.Size = New System.Drawing.Size(168, 26)
        Me.WaitingListDateDateTimePicker.TabIndex = 3
        '
        'Date_placedDateTimePicker
        '
        Me.Date_placedDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Date_placedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Ward_AllocationsBindingSource, "date_placed", True))
        Me.Date_placedDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_placedDateTimePicker.Location = New System.Drawing.Point(656, 41)
        Me.Date_placedDateTimePicker.Name = "Date_placedDateTimePicker"
        Me.Date_placedDateTimePicker.Size = New System.Drawing.Size(174, 26)
        Me.Date_placedDateTimePicker.TabIndex = 7
        '
        'Date_actual_leaveDateTimePicker
        '
        Me.Date_actual_leaveDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Date_actual_leaveDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Ward_AllocationsBindingSource, "date_actual_leave", True))
        Me.Date_actual_leaveDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Date_actual_leaveDateTimePicker.Location = New System.Drawing.Point(656, 77)
        Me.Date_actual_leaveDateTimePicker.Name = "Date_actual_leaveDateTimePicker"
        Me.Date_actual_leaveDateTimePicker.Size = New System.Drawing.Size(174, 26)
        Me.Date_actual_leaveDateTimePicker.TabIndex = 11
        '
        'P_NumTextBox
        '
        Me.P_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ward_AllocationsBindingSource, "P_Num", True))
        Me.P_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.P_NumTextBox.Location = New System.Drawing.Point(160, 41)
        Me.P_NumTextBox.Name = "P_NumTextBox"
        Me.P_NumTextBox.Size = New System.Drawing.Size(168, 26)
        Me.P_NumTextBox.TabIndex = 15
        '
        'W_NumTextBox
        '
        Me.W_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.W_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ward_AllocationsBindingSource, "W_Num", True))
        Me.W_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.W_NumTextBox.Location = New System.Drawing.Point(160, 77)
        Me.W_NumTextBox.Name = "W_NumTextBox"
        Me.W_NumTextBox.Size = New System.Drawing.Size(168, 26)
        Me.W_NumTextBox.TabIndex = 13
        '
        'Bed_allocation_idTextBox
        '
        Me.Bed_allocation_idTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Bed_allocation_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Ward_AllocationsBindingSource, "bed_allocation_id", True))
        Me.Bed_allocation_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Bed_allocation_idTextBox.Location = New System.Drawing.Point(656, 5)
        Me.Bed_allocation_idTextBox.Name = "Bed_allocation_idTextBox"
        Me.Bed_allocation_idTextBox.Size = New System.Drawing.Size(174, 26)
        Me.Bed_allocation_idTextBox.TabIndex = 17
        '
        'BA_LU
        '
        Me.BA_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BA_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.BA_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BA_LU.ForeColor = System.Drawing.Color.Transparent
        Me.BA_LU.Location = New System.Drawing.Point(872, 6)
        Me.BA_LU.Name = "BA_LU"
        Me.BA_LU.Size = New System.Drawing.Size(24, 23)
        Me.BA_LU.TabIndex = 53
        Me.BA_LU.UseVisualStyleBackColor = True
        '
        'P_LU
        '
        Me.P_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.P_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_LU.ForeColor = System.Drawing.Color.Transparent
        Me.P_LU.Location = New System.Drawing.Point(343, 42)
        Me.P_LU.Name = "P_LU"
        Me.P_LU.Size = New System.Drawing.Size(24, 23)
        Me.P_LU.TabIndex = 52
        Me.P_LU.UseVisualStyleBackColor = True
        '
        'W_LU
        '
        Me.W_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.W_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.W_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.W_LU.ForeColor = System.Drawing.Color.Transparent
        Me.W_LU.Location = New System.Drawing.Point(343, 78)
        Me.W_LU.Name = "W_LU"
        Me.W_LU.Size = New System.Drawing.Size(24, 23)
        Me.W_LU.TabIndex = 71
        Me.W_LU.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1099, 80)
        Me.Panel1.TabIndex = 70
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(178, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Ward Allocation"
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
        Me.Panel2.Size = New System.Drawing.Size(1099, 81)
        Me.Panel2.TabIndex = 69
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
        'Ward_AllocationsTableAdapter
        '
        Me.Ward_AllocationsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Me.Ward_AllocationsTableAdapter
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'Ward_AllocationsBindingNavigator
        '
        Me.Ward_AllocationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Ward_AllocationsBindingNavigator.BindingSource = Me.Ward_AllocationsBindingSource
        Me.Ward_AllocationsBindingNavigator.CountItem = Nothing
        Me.Ward_AllocationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Ward_AllocationsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.Ward_AllocationsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Ward_AllocationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.Ward_AllocationsBindingNavigatorSaveItem})
        Me.Ward_AllocationsBindingNavigator.Location = New System.Drawing.Point(76, 385)
        Me.Ward_AllocationsBindingNavigator.MoveFirstItem = Nothing
        Me.Ward_AllocationsBindingNavigator.MoveLastItem = Nothing
        Me.Ward_AllocationsBindingNavigator.MoveNextItem = Nothing
        Me.Ward_AllocationsBindingNavigator.MovePreviousItem = Nothing
        Me.Ward_AllocationsBindingNavigator.Name = "Ward_AllocationsBindingNavigator"
        Me.Ward_AllocationsBindingNavigator.PositionItem = Nothing
        Me.Ward_AllocationsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.Ward_AllocationsBindingNavigator.TabIndex = 72
        Me.Ward_AllocationsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'Ward_AllocationsBindingNavigatorSaveItem
        '
        Me.Ward_AllocationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ward_AllocationsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.Ward_AllocationsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Ward_AllocationsBindingNavigatorSaveItem.Name = "Ward_AllocationsBindingNavigatorSaveItem"
        Me.Ward_AllocationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.Ward_AllocationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Ward_AllocationsDataGridView
        '
        Me.Ward_AllocationsDataGridView.AutoGenerateColumns = False
        Me.Ward_AllocationsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.Ward_AllocationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Ward_AllocationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Ward_AllocationsDataGridView.DataSource = Me.Ward_AllocationsBindingSource
        Me.Ward_AllocationsDataGridView.Location = New System.Drawing.Point(76, 417)
        Me.Ward_AllocationsDataGridView.Name = "Ward_AllocationsDataGridView"
        Me.Ward_AllocationsDataGridView.Size = New System.Drawing.Size(944, 220)
        Me.Ward_AllocationsDataGridView.TabIndex = 72
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "allocation_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "allocation_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "waitingListDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "waitingListDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "expected_stay"
        Me.DataGridViewTextBoxColumn3.HeaderText = "expected_stay"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "date_placed"
        Me.DataGridViewTextBoxColumn4.HeaderText = "date_placed"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "date_leave"
        Me.DataGridViewTextBoxColumn5.HeaderText = "date_leave"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "date_actual_leave"
        Me.DataGridViewTextBoxColumn6.HeaderText = "date_actual_leave"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "W_Num"
        Me.DataGridViewTextBoxColumn7.HeaderText = "W_Num"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "P_Num"
        Me.DataGridViewTextBoxColumn8.HeaderText = "P_Num"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "bed_allocation_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "bed_allocation_id"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'AllocationWard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 701)
        Me.Controls.Add(Me.Ward_AllocationsDataGridView)
        Me.Controls.Add(Me.Ward_AllocationsBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AllocationWard"
        Me.Text = "AllocationWard"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Ward_AllocationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ward_AllocationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ward_AllocationsBindingNavigator.ResumeLayout(False)
        Me.Ward_AllocationsBindingNavigator.PerformLayout()
        CType(Me.Ward_AllocationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BA_LU As Button
    Friend WithEvents P_LU As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents W_LU As Button
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents Ward_AllocationsBindingSource As BindingSource
    Friend WithEvents Ward_AllocationsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.Ward_AllocationsTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents Ward_AllocationsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Ward_AllocationsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Allocation_idTextBox As TextBox
    Friend WithEvents WaitingListDateDateTimePicker As DateTimePicker
    Friend WithEvents Expected_stayTextBox As TextBox
    Friend WithEvents Date_placedDateTimePicker As DateTimePicker
    Friend WithEvents Date_leaveDateTimePicker As DateTimePicker
    Friend WithEvents Date_actual_leaveDateTimePicker As DateTimePicker
    Friend WithEvents W_NumTextBox As TextBox
    Friend WithEvents P_NumTextBox As TextBox
    Friend WithEvents Bed_allocation_idTextBox As TextBox
    Friend WithEvents Ward_AllocationsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
