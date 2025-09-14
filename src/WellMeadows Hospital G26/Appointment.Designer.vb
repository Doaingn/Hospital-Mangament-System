<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Appointment
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
        Dim AppointmentIDLabel As System.Windows.Forms.Label
        Dim P_NumLabel As System.Windows.Forms.Label
        Dim Clinic_NumLabel As System.Windows.Forms.Label
        Dim S_NumLabel As System.Windows.Forms.Label
        Dim Appointment_dateLabel As System.Windows.Forms.Label
        Dim ReasonsLabel As System.Windows.Forms.Label
        Me.P_LU = New System.Windows.Forms.Button()
        Me.Cli_LU = New System.Windows.Forms.Button()
        Me.S_LU = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Param1ToolStripTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AppointmentIDTextBox = New System.Windows.Forms.TextBox()
        Me.AppointmentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLEXPRESS_DatabaseG26DataSet = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSet()
        Me.P_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Clinic_NumTextBox = New System.Windows.Forms.TextBox()
        Me.S_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Appointment_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ReasonsTextBox = New System.Windows.Forms.TextBox()
        Me.AppointmentsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StaffsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AppointmentsTableAdapter = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.AppointmentsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager()
        AppointmentIDLabel = New System.Windows.Forms.Label()
        P_NumLabel = New System.Windows.Forms.Label()
        Clinic_NumLabel = New System.Windows.Forms.Label()
        S_NumLabel = New System.Windows.Forms.Label()
        Appointment_dateLabel = New System.Windows.Forms.Label()
        ReasonsLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppointmentsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AppointmentIDLabel
        '
        AppointmentIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        AppointmentIDLabel.AutoSize = True
        AppointmentIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        AppointmentIDLabel.Location = New System.Drawing.Point(3, 5)
        AppointmentIDLabel.Name = "AppointmentIDLabel"
        AppointmentIDLabel.Size = New System.Drawing.Size(125, 20)
        AppointmentIDLabel.TabIndex = 0
        AppointmentIDLabel.Text = "Appointment ID:"
        '
        'P_NumLabel
        '
        P_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        P_NumLabel.AutoSize = True
        P_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        P_NumLabel.Location = New System.Drawing.Point(3, 34)
        P_NumLabel.Name = "P_NumLabel"
        P_NumLabel.Size = New System.Drawing.Size(123, 20)
        P_NumLabel.TabIndex = 2
        P_NumLabel.Text = "Patient Number:"
        '
        'Clinic_NumLabel
        '
        Clinic_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Clinic_NumLabel.AutoSize = True
        Clinic_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Clinic_NumLabel.Location = New System.Drawing.Point(3, 64)
        Clinic_NumLabel.Name = "Clinic_NumLabel"
        Clinic_NumLabel.Size = New System.Drawing.Size(87, 20)
        Clinic_NumLabel.TabIndex = 4
        Clinic_NumLabel.Text = "Clinic Num:"
        '
        'S_NumLabel
        '
        S_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        S_NumLabel.AutoSize = True
        S_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        S_NumLabel.Location = New System.Drawing.Point(3, 95)
        S_NumLabel.Name = "S_NumLabel"
        S_NumLabel.Size = New System.Drawing.Size(108, 20)
        S_NumLabel.TabIndex = 6
        S_NumLabel.Text = "Staff Number:"
        '
        'Appointment_dateLabel
        '
        Appointment_dateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Appointment_dateLabel.AutoSize = True
        Appointment_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Appointment_dateLabel.Location = New System.Drawing.Point(3, 125)
        Appointment_dateLabel.Name = "Appointment_dateLabel"
        Appointment_dateLabel.Size = New System.Drawing.Size(143, 20)
        Appointment_dateLabel.TabIndex = 8
        Appointment_dateLabel.Text = "Appointment Date:"
        '
        'ReasonsLabel
        '
        ReasonsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ReasonsLabel.AutoSize = True
        ReasonsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        ReasonsLabel.Location = New System.Drawing.Point(3, 157)
        ReasonsLabel.Name = "ReasonsLabel"
        ReasonsLabel.Size = New System.Drawing.Size(77, 20)
        ReasonsLabel.TabIndex = 10
        ReasonsLabel.Text = "Reasons:"
        '
        'P_LU
        '
        Me.P_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.P_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.P_LU.ForeColor = System.Drawing.Color.Transparent
        Me.P_LU.Location = New System.Drawing.Point(360, 33)
        Me.P_LU.Name = "P_LU"
        Me.P_LU.Size = New System.Drawing.Size(24, 23)
        Me.P_LU.TabIndex = 64
        Me.P_LU.UseVisualStyleBackColor = True
        '
        'Cli_LU
        '
        Me.Cli_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cli_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Cli_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Cli_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Cli_LU.Location = New System.Drawing.Point(360, 63)
        Me.Cli_LU.Name = "Cli_LU"
        Me.Cli_LU.Size = New System.Drawing.Size(24, 23)
        Me.Cli_LU.TabIndex = 65
        Me.Cli_LU.UseVisualStyleBackColor = True
        '
        'S_LU
        '
        Me.S_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.S_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.S_LU.ForeColor = System.Drawing.Color.Transparent
        Me.S_LU.Location = New System.Drawing.Point(360, 93)
        Me.S_LU.Name = "S_LU"
        Me.S_LU.Size = New System.Drawing.Size(24, 23)
        Me.S_LU.TabIndex = 66
        Me.S_LU.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 80)
        Me.Panel1.TabIndex = 64
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(224, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Patient Appointment"
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
        Me.Panel2.Controls.Add(Me.Param1ToolStripTextBox)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 81)
        Me.Panel2.TabIndex = 63
        '
        'Param1ToolStripTextBox
        '
        Me.Param1ToolStripTextBox.Location = New System.Drawing.Point(588, 26)
        Me.Param1ToolStripTextBox.Name = "Param1ToolStripTextBox"
        Me.Param1ToolStripTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Param1ToolStripTextBox.TabIndex = 70
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.06358!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.93642!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.TableLayoutPanel1.Controls.Add(AppointmentIDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AppointmentIDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(P_NumLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.P_NumTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.S_LU, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Cli_LU, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.P_LU, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Clinic_NumLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Clinic_NumTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(S_NumLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.S_NumTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Appointment_dateLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Appointment_dateDateTimePicker, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(ReasonsLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ReasonsTextBox, 1, 5)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 164)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.76087!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.84783!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.6632!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(467, 184)
        Me.TableLayoutPanel1.TabIndex = 60
        '
        'AppointmentIDTextBox
        '
        Me.AppointmentIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AppointmentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "appointmentID", True))
        Me.AppointmentIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AppointmentIDTextBox.Location = New System.Drawing.Point(157, 3)
        Me.AppointmentIDTextBox.Name = "AppointmentIDTextBox"
        Me.AppointmentIDTextBox.Size = New System.Drawing.Size(197, 26)
        Me.AppointmentIDTextBox.TabIndex = 1
        '
        'AppointmentsBindingSource
        '
        Me.AppointmentsBindingSource.DataMember = "Appointments"
        Me.AppointmentsBindingSource.DataSource = Me.SQLEXPRESS_DatabaseG26DataSet
        '
        'SQLEXPRESS_DatabaseG26DataSet
        '
        Me.SQLEXPRESS_DatabaseG26DataSet.DataSetName = "SQLEXPRESS_DatabaseG26DataSet"
        Me.SQLEXPRESS_DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'P_NumTextBox
        '
        Me.P_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.P_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "P_Num", True))
        Me.P_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.P_NumTextBox.Location = New System.Drawing.Point(157, 33)
        Me.P_NumTextBox.Name = "P_NumTextBox"
        Me.P_NumTextBox.Size = New System.Drawing.Size(197, 26)
        Me.P_NumTextBox.TabIndex = 3
        '
        'Clinic_NumTextBox
        '
        Me.Clinic_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Clinic_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "Clinic_Num", True))
        Me.Clinic_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Clinic_NumTextBox.Location = New System.Drawing.Point(157, 62)
        Me.Clinic_NumTextBox.Name = "Clinic_NumTextBox"
        Me.Clinic_NumTextBox.Size = New System.Drawing.Size(197, 26)
        Me.Clinic_NumTextBox.TabIndex = 5
        '
        'S_NumTextBox
        '
        Me.S_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.S_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "S_Num", True))
        Me.S_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.S_NumTextBox.Location = New System.Drawing.Point(157, 93)
        Me.S_NumTextBox.Name = "S_NumTextBox"
        Me.S_NumTextBox.Size = New System.Drawing.Size(197, 26)
        Me.S_NumTextBox.TabIndex = 7
        '
        'Appointment_dateDateTimePicker
        '
        Me.Appointment_dateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Appointment_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AppointmentsBindingSource, "appointment_date", True))
        Me.Appointment_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Appointment_dateDateTimePicker.Location = New System.Drawing.Point(157, 123)
        Me.Appointment_dateDateTimePicker.Name = "Appointment_dateDateTimePicker"
        Me.Appointment_dateDateTimePicker.Size = New System.Drawing.Size(197, 26)
        Me.Appointment_dateDateTimePicker.TabIndex = 9
        '
        'ReasonsTextBox
        '
        Me.ReasonsTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ReasonsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AppointmentsBindingSource, "reasons", True))
        Me.ReasonsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ReasonsTextBox.Location = New System.Drawing.Point(157, 154)
        Me.ReasonsTextBox.Name = "ReasonsTextBox"
        Me.ReasonsTextBox.Size = New System.Drawing.Size(197, 26)
        Me.ReasonsTextBox.TabIndex = 11
        '
        'AppointmentsDataGridView
        '
        Me.AppointmentsDataGridView.AutoGenerateColumns = False
        Me.AppointmentsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.AppointmentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.AppointmentsDataGridView.DataSource = Me.AppointmentsBindingSource
        Me.AppointmentsDataGridView.Location = New System.Drawing.Point(76, 383)
        Me.AppointmentsDataGridView.Name = "AppointmentsDataGridView"
        Me.AppointmentsDataGridView.Size = New System.Drawing.Size(644, 318)
        Me.AppointmentsDataGridView.TabIndex = 67
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "appointmentID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "appointmentID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "P_Num"
        Me.DataGridViewTextBoxColumn2.HeaderText = "P_Num"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Clinic_Num"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Clinic_Num"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "S_Num"
        Me.DataGridViewTextBoxColumn4.HeaderText = "S_Num"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "appointment_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "appointment_date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "reasons"
        Me.DataGridViewTextBoxColumn6.HeaderText = "reasons"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.AppointmentsBindingSource
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.None
        Me.BindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator1, Me.StaffsBindingNavigatorSaveItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(76, 351)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(89, 29)
        Me.BindingNavigator1.TabIndex = 68
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'StaffsBindingNavigatorSaveItem
        '
        Me.StaffsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StaffsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.StaffsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.StaffsBindingNavigatorSaveItem.Name = "StaffsBindingNavigatorSaveItem"
        Me.StaffsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.StaffsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AppointmentsTableAdapter
        '
        Me.AppointmentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressesTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentsTableAdapter = Me.AppointmentsTableAdapter
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
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 728)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.AppointmentsDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Appointment"
        Me.Text = "Patient Appointment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AppointmentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLEXPRESS_DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppointmentsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
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
    Friend WithEvents P_LU As Button
    Friend WithEvents Cli_LU As Button
    Friend WithEvents S_LU As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SQLEXPRESS_DatabaseG26DataSet As SQLEXPRESS_DatabaseG26DataSet
    Friend WithEvents AppointmentsBindingSource As BindingSource
    Friend WithEvents AppointmentsTableAdapter As SQLEXPRESS_DatabaseG26DataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents TableAdapterManager As SQLEXPRESS_DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AppointmentIDTextBox As TextBox
    Friend WithEvents P_NumTextBox As TextBox
    Friend WithEvents Clinic_NumTextBox As TextBox
    Friend WithEvents S_NumTextBox As TextBox
    Friend WithEvents Appointment_dateDateTimePicker As DateTimePicker
    Friend WithEvents ReasonsTextBox As TextBox
    Friend WithEvents AppointmentsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents StaffsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Param1ToolStripTextBox As TextBox
End Class
