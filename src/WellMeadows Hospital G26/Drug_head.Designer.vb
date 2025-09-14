<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Drug_head
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
        Dim DrugReqIDLabel As System.Windows.Forms.Label
        Dim RequisitionDateLabel As System.Windows.Forms.Label
        Dim DateReceivedLabel As System.Windows.Forms.Label
        Dim Requisition_byLabel As System.Windows.Forms.Label
        Dim Received_byLabel As System.Windows.Forms.Label
        Dim Clinic_NumLabel As System.Windows.Forms.Label
        Dim W_NumLabel As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Order_noLabel As System.Windows.Forms.Label
        Dim Drug_noLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DrugReqIDTextBox = New System.Windows.Forms.TextBox()
        Me.DrugRequisitionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseG26DataSet2 = New WellMeadows_Hospital_G26.DatabaseG26DataSet2()
        Me.RequisitionDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DateReceivedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Requisition_byTextBox = New System.Windows.Forms.TextBox()
        Me.Received_byTextBox = New System.Windows.Forms.TextBox()
        Me.Clinic_NumTextBox = New System.Windows.Forms.TextBox()
        Me.W_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Cli_LU = New System.Windows.Forms.Button()
        Me.W_LU = New System.Windows.Forms.Button()
        Me.DrugRequisitionTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.DrugRequisitionTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.TableAdapterManager()
        Me.DrugRequisitionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DrugRequisitionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DrugRequisitionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugReq_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.User = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.DrugReq_DetailsTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.DrugReq_DetailsTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DrugReq_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DrugReq_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DrugReq_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Order_noTextBox = New System.Windows.Forms.TextBox()
        Me.Drug_noTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Parma_LU = New System.Windows.Forms.Button()
        DrugReqIDLabel = New System.Windows.Forms.Label()
        RequisitionDateLabel = New System.Windows.Forms.Label()
        DateReceivedLabel = New System.Windows.Forms.Label()
        Requisition_byLabel = New System.Windows.Forms.Label()
        Received_byLabel = New System.Windows.Forms.Label()
        Clinic_NumLabel = New System.Windows.Forms.Label()
        W_NumLabel = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Order_noLabel = New System.Windows.Forms.Label()
        Drug_noLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DrugRequisitionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseG26DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugRequisitionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DrugRequisitionBindingNavigator.SuspendLayout()
        CType(Me.DrugRequisitionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugReq_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugReq_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrugReq_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DrugReq_DetailsBindingNavigator.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DrugReqIDLabel
        '
        DrugReqIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DrugReqIDLabel.AutoSize = True
        DrugReqIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DrugReqIDLabel.Location = New System.Drawing.Point(3, 6)
        DrugReqIDLabel.Name = "DrugReqIDLabel"
        DrugReqIDLabel.Size = New System.Drawing.Size(152, 20)
        DrugReqIDLabel.TabIndex = 59
        DrugReqIDLabel.Text = "Drug Requisition ID:"
        '
        'RequisitionDateLabel
        '
        RequisitionDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        RequisitionDateLabel.AutoSize = True
        RequisitionDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        RequisitionDateLabel.Location = New System.Drawing.Point(3, 39)
        RequisitionDateLabel.Name = "RequisitionDateLabel"
        RequisitionDateLabel.Size = New System.Drawing.Size(131, 20)
        RequisitionDateLabel.TabIndex = 61
        RequisitionDateLabel.Text = "Requisition Date:"
        '
        'DateReceivedLabel
        '
        DateReceivedLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DateReceivedLabel.AutoSize = True
        DateReceivedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DateReceivedLabel.Location = New System.Drawing.Point(3, 72)
        DateReceivedLabel.Name = "DateReceivedLabel"
        DateReceivedLabel.Size = New System.Drawing.Size(118, 20)
        DateReceivedLabel.TabIndex = 63
        DateReceivedLabel.Text = "Date Received:"
        '
        'Requisition_byLabel
        '
        Requisition_byLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Requisition_byLabel.AutoSize = True
        Requisition_byLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Requisition_byLabel.Location = New System.Drawing.Point(3, 105)
        Requisition_byLabel.Name = "Requisition_byLabel"
        Requisition_byLabel.Size = New System.Drawing.Size(114, 20)
        Requisition_byLabel.TabIndex = 65
        Requisition_byLabel.Text = "Requisition By:"
        '
        'Received_byLabel
        '
        Received_byLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Received_byLabel.AutoSize = True
        Received_byLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Received_byLabel.Location = New System.Drawing.Point(3, 138)
        Received_byLabel.Name = "Received_byLabel"
        Received_byLabel.Size = New System.Drawing.Size(101, 20)
        Received_byLabel.TabIndex = 67
        Received_byLabel.Text = "Received By:"
        '
        'Clinic_NumLabel
        '
        Clinic_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Clinic_NumLabel.AutoSize = True
        Clinic_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Clinic_NumLabel.Location = New System.Drawing.Point(3, 171)
        Clinic_NumLabel.Name = "Clinic_NumLabel"
        Clinic_NumLabel.Size = New System.Drawing.Size(110, 20)
        Clinic_NumLabel.TabIndex = 69
        Clinic_NumLabel.Text = "Clinic Number:"
        '
        'W_NumLabel
        '
        W_NumLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        W_NumLabel.AutoSize = True
        W_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        W_NumLabel.Location = New System.Drawing.Point(3, 205)
        W_NumLabel.Name = "W_NumLabel"
        W_NumLabel.Size = New System.Drawing.Size(111, 20)
        W_NumLabel.TabIndex = 71
        W_NumLabel.Text = "Ward Number:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1363, 80)
        Me.Panel1.TabIndex = 57
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(247, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Drug Requisition Form"
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
        Me.Panel2.Size = New System.Drawing.Size(1363, 81)
        Me.Panel2.TabIndex = 56
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.58163!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.17347!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449!))
        Me.TableLayoutPanel1.Controls.Add(Me.DrugReqIDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(DrugReqIDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RequisitionDateDateTimePicker, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(RequisitionDateLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DateReceivedDateTimePicker, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(DateReceivedLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Requisition_byTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Requisition_byLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Received_byTextBox, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Received_byLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Clinic_NumTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Clinic_NumLabel, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.W_NumTextBox, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(W_NumLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Cli_LU, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.W_LU, 2, 6)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(83, 206)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(409, 233)
        Me.TableLayoutPanel1.TabIndex = 58
        '
        'DrugReqIDTextBox
        '
        Me.DrugReqIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DrugReqIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugRequisitionBindingSource, "DrugReqID", True))
        Me.DrugReqIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DrugReqIDTextBox.Location = New System.Drawing.Point(173, 3)
        Me.DrugReqIDTextBox.Name = "DrugReqIDTextBox"
        Me.DrugReqIDTextBox.Size = New System.Drawing.Size(182, 26)
        Me.DrugReqIDTextBox.TabIndex = 60
        '
        'DrugRequisitionBindingSource
        '
        Me.DrugRequisitionBindingSource.DataMember = "DrugRequisition"
        Me.DrugRequisitionBindingSource.DataSource = Me.DatabaseG26DataSet2
        '
        'DatabaseG26DataSet2
        '
        Me.DatabaseG26DataSet2.DataSetName = "DatabaseG26DataSet2"
        Me.DatabaseG26DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequisitionDateDateTimePicker
        '
        Me.RequisitionDateDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RequisitionDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DrugRequisitionBindingSource, "RequisitionDate", True))
        Me.RequisitionDateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.RequisitionDateDateTimePicker.Location = New System.Drawing.Point(173, 36)
        Me.RequisitionDateDateTimePicker.Name = "RequisitionDateDateTimePicker"
        Me.RequisitionDateDateTimePicker.Size = New System.Drawing.Size(182, 26)
        Me.RequisitionDateDateTimePicker.TabIndex = 62
        '
        'DateReceivedDateTimePicker
        '
        Me.DateReceivedDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateReceivedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DrugRequisitionBindingSource, "DateReceived", True))
        Me.DateReceivedDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.DateReceivedDateTimePicker.Location = New System.Drawing.Point(173, 69)
        Me.DateReceivedDateTimePicker.Name = "DateReceivedDateTimePicker"
        Me.DateReceivedDateTimePicker.Size = New System.Drawing.Size(182, 26)
        Me.DateReceivedDateTimePicker.TabIndex = 64
        '
        'Requisition_byTextBox
        '
        Me.Requisition_byTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Requisition_byTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugRequisitionBindingSource, "requisition_by", True))
        Me.Requisition_byTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Requisition_byTextBox.Location = New System.Drawing.Point(173, 102)
        Me.Requisition_byTextBox.Name = "Requisition_byTextBox"
        Me.Requisition_byTextBox.Size = New System.Drawing.Size(182, 26)
        Me.Requisition_byTextBox.TabIndex = 66
        '
        'Received_byTextBox
        '
        Me.Received_byTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Received_byTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugRequisitionBindingSource, "received_by", True))
        Me.Received_byTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Received_byTextBox.Location = New System.Drawing.Point(173, 135)
        Me.Received_byTextBox.Name = "Received_byTextBox"
        Me.Received_byTextBox.Size = New System.Drawing.Size(182, 26)
        Me.Received_byTextBox.TabIndex = 68
        '
        'Clinic_NumTextBox
        '
        Me.Clinic_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Clinic_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugRequisitionBindingSource, "Clinic_Num", True))
        Me.Clinic_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Clinic_NumTextBox.Location = New System.Drawing.Point(173, 168)
        Me.Clinic_NumTextBox.Name = "Clinic_NumTextBox"
        Me.Clinic_NumTextBox.Size = New System.Drawing.Size(182, 26)
        Me.Clinic_NumTextBox.TabIndex = 70
        '
        'W_NumTextBox
        '
        Me.W_NumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.W_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugRequisitionBindingSource, "W_Num", True))
        Me.W_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.W_NumTextBox.Location = New System.Drawing.Point(173, 202)
        Me.W_NumTextBox.Name = "W_NumTextBox"
        Me.W_NumTextBox.Size = New System.Drawing.Size(182, 26)
        Me.W_NumTextBox.TabIndex = 72
        '
        'Cli_LU
        '
        Me.Cli_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Cli_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Cli_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Cli_LU.Location = New System.Drawing.Point(361, 168)
        Me.Cli_LU.Name = "Cli_LU"
        Me.Cli_LU.Size = New System.Drawing.Size(24, 23)
        Me.Cli_LU.TabIndex = 50
        Me.Cli_LU.UseVisualStyleBackColor = True
        '
        'W_LU
        '
        Me.W_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.W_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.W_LU.ForeColor = System.Drawing.Color.Transparent
        Me.W_LU.Location = New System.Drawing.Point(361, 201)
        Me.W_LU.Name = "W_LU"
        Me.W_LU.Size = New System.Drawing.Size(24, 23)
        Me.W_LU.TabIndex = 52
        Me.W_LU.UseVisualStyleBackColor = True
        '
        'DrugRequisitionTableAdapter
        '
        Me.DrugRequisitionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DrugRequisitionTableAdapter = Me.DrugRequisitionTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'DrugRequisitionBindingNavigator
        '
        Me.DrugRequisitionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DrugRequisitionBindingNavigator.BindingSource = Me.DrugRequisitionBindingSource
        Me.DrugRequisitionBindingNavigator.CountItem = Nothing
        Me.DrugRequisitionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DrugRequisitionBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.DrugRequisitionBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DrugRequisitionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.DrugRequisitionBindingNavigatorSaveItem})
        Me.DrugRequisitionBindingNavigator.Location = New System.Drawing.Point(83, 442)
        Me.DrugRequisitionBindingNavigator.MoveFirstItem = Nothing
        Me.DrugRequisitionBindingNavigator.MoveLastItem = Nothing
        Me.DrugRequisitionBindingNavigator.MoveNextItem = Nothing
        Me.DrugRequisitionBindingNavigator.MovePreviousItem = Nothing
        Me.DrugRequisitionBindingNavigator.Name = "DrugRequisitionBindingNavigator"
        Me.DrugRequisitionBindingNavigator.PositionItem = Nothing
        Me.DrugRequisitionBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.DrugRequisitionBindingNavigator.TabIndex = 59
        Me.DrugRequisitionBindingNavigator.Text = "BindingNavigator1"
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
        'DrugRequisitionBindingNavigatorSaveItem
        '
        Me.DrugRequisitionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DrugRequisitionBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.DrugRequisitionBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DrugRequisitionBindingNavigatorSaveItem.Name = "DrugRequisitionBindingNavigatorSaveItem"
        Me.DrugRequisitionBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.DrugRequisitionBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DrugRequisitionDataGridView
        '
        Me.DrugRequisitionDataGridView.AutoGenerateColumns = False
        Me.DrugRequisitionDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.DrugRequisitionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrugRequisitionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DrugRequisitionDataGridView.DataSource = Me.DrugRequisitionBindingSource
        Me.DrugRequisitionDataGridView.Location = New System.Drawing.Point(531, 206)
        Me.DrugRequisitionDataGridView.Name = "DrugRequisitionDataGridView"
        Me.DrugRequisitionDataGridView.Size = New System.Drawing.Size(744, 233)
        Me.DrugRequisitionDataGridView.TabIndex = 59
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "DrugReqID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "DrugReqID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "RequisitionDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "RequisitionDate"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DateReceived"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DateReceived"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "requisition_by"
        Me.DataGridViewTextBoxColumn4.HeaderText = "requisition_by"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "received_by"
        Me.DataGridViewTextBoxColumn5.HeaderText = "received_by"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Clinic_Num"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Clinic_Num"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "W_Num"
        Me.DataGridViewTextBoxColumn7.HeaderText = "W_Num"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DrugReq_DetailsBindingSource
        '
        Me.DrugReq_DetailsBindingSource.DataMember = "DrugReq_Details"
        Me.DrugReq_DetailsBindingSource.DataSource = Me.DatabaseG26DataSet2
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox4.Location = New System.Drawing.Point(0, 189)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(900, 11)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 79
        Me.PictureBox4.TabStop = False
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.User.ForeColor = System.Drawing.Color.DimGray
        Me.User.Location = New System.Drawing.Point(82, 166)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(127, 20)
        Me.User.TabIndex = 80
        Me.User.Text = "Drug Requisition"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources.Lovepik_com_380156115_simple_thin_straight_line_thin_on_both_sides_black_simple_lines
        Me.PictureBox3.Location = New System.Drawing.Point(0, 533)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(900, 11)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 81
        Me.PictureBox3.TabStop = False
        '
        'DrugReq_DetailsTableAdapter
        '
        Me.DrugReq_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(82, 510)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Drug Order"
        '
        'DrugReq_DetailsDataGridView
        '
        Me.DrugReq_DetailsDataGridView.AutoGenerateColumns = False
        Me.DrugReq_DetailsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.DrugReq_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DrugReq_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DrugReq_DetailsDataGridView.DataSource = Me.DrugReq_DetailsBindingSource
        Me.DrugReq_DetailsDataGridView.Location = New System.Drawing.Point(531, 562)
        Me.DrugReq_DetailsDataGridView.Name = "DrugReq_DetailsDataGridView"
        Me.DrugReq_DetailsDataGridView.Size = New System.Drawing.Size(445, 130)
        Me.DrugReq_DetailsDataGridView.TabIndex = 85
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DrugReqID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DrugReqID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "order_no"
        Me.DataGridViewTextBoxColumn9.HeaderText = "order_no"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "drug_no"
        Me.DataGridViewTextBoxColumn10.HeaderText = "drug_no"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DrugReq_DetailsBindingNavigator
        '
        Me.DrugReq_DetailsBindingNavigator.AddNewItem = Me.ToolStripButton1
        Me.DrugReq_DetailsBindingNavigator.BindingSource = Me.DrugReq_DetailsBindingSource
        Me.DrugReq_DetailsBindingNavigator.CountItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.DeleteItem = Me.ToolStripButton2
        Me.DrugReq_DetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.DrugReq_DetailsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.DrugReq_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.DrugReq_DetailsBindingNavigatorSaveItem})
        Me.DrugReq_DetailsBindingNavigator.Location = New System.Drawing.Point(83, 702)
        Me.DrugReq_DetailsBindingNavigator.MoveFirstItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.MoveLastItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.MoveNextItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.MovePreviousItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.Name = "DrugReq_DetailsBindingNavigator"
        Me.DrugReq_DetailsBindingNavigator.PositionItem = Nothing
        Me.DrugReq_DetailsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.DrugReq_DetailsBindingNavigator.TabIndex = 84
        Me.DrugReq_DetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Add
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(24, 26)
        Me.ToolStripButton1.Text = "Add new"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Delete
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(24, 26)
        Me.ToolStripButton2.Text = "Delete"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'DrugReq_DetailsBindingNavigatorSaveItem
        '
        Me.DrugReq_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DrugReq_DetailsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.DrugReq_DetailsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DrugReq_DetailsBindingNavigatorSaveItem.Name = "DrugReq_DetailsBindingNavigatorSaveItem"
        Me.DrugReq_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.DrugReq_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.58163!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.17347!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.2449!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TextBox1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Label3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Order_noTextBox, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Order_noLabel, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Drug_noTextBox, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Drug_noLabel, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.QuantityTextBox, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(QuantityLabel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Parma_LU, 2, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(83, 559)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(392, 130)
        Me.TableLayoutPanel2.TabIndex = 83
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(346, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 62
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugReq_DetailsBindingSource, "DrugReqID", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(165, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 26)
        Me.TextBox1.TabIndex = 62
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Label3.Location = New System.Drawing.Point(3, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(152, 20)
        Label3.TabIndex = 61
        Label3.Text = "Drug Requisition ID:"
        '
        'Order_noTextBox
        '
        Me.Order_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugReq_DetailsBindingSource, "order_no", True))
        Me.Order_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Order_noTextBox.Location = New System.Drawing.Point(165, 35)
        Me.Order_noTextBox.Name = "Order_noTextBox"
        Me.Order_noTextBox.Size = New System.Drawing.Size(175, 26)
        Me.Order_noTextBox.TabIndex = 64
        '
        'Order_noLabel
        '
        Order_noLabel.AutoSize = True
        Order_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Order_noLabel.Location = New System.Drawing.Point(3, 32)
        Order_noLabel.Name = "Order_noLabel"
        Order_noLabel.Size = New System.Drawing.Size(75, 20)
        Order_noLabel.TabIndex = 63
        Order_noLabel.Text = "Order no:"
        '
        'Drug_noTextBox
        '
        Me.Drug_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugReq_DetailsBindingSource, "drug_no", True))
        Me.Drug_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Drug_noTextBox.Location = New System.Drawing.Point(165, 67)
        Me.Drug_noTextBox.Name = "Drug_noTextBox"
        Me.Drug_noTextBox.Size = New System.Drawing.Size(175, 26)
        Me.Drug_noTextBox.TabIndex = 66
        '
        'Drug_noLabel
        '
        Drug_noLabel.AutoSize = True
        Drug_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Drug_noLabel.Location = New System.Drawing.Point(3, 64)
        Drug_noLabel.Name = "Drug_noLabel"
        Drug_noLabel.Size = New System.Drawing.Size(70, 20)
        Drug_noLabel.TabIndex = 65
        Drug_noLabel.Text = "Drug no:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DrugReq_DetailsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(165, 99)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(175, 26)
        Me.QuantityTextBox.TabIndex = 68
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        QuantityLabel.Location = New System.Drawing.Point(3, 96)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(72, 20)
        QuantityLabel.TabIndex = 67
        QuantityLabel.Text = "Quantity:"
        '
        'Parma_LU
        '
        Me.Parma_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Parma_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Parma_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Parma_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Parma_LU.Location = New System.Drawing.Point(346, 68)
        Me.Parma_LU.Name = "Parma_LU"
        Me.Parma_LU.Size = New System.Drawing.Size(24, 23)
        Me.Parma_LU.TabIndex = 50
        Me.Parma_LU.UseVisualStyleBackColor = True
        '
        'Drug_head
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1363, 930)
        Me.Controls.Add(Me.DrugReq_DetailsDataGridView)
        Me.Controls.Add(Me.DrugReq_DetailsBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.User)
        Me.Controls.Add(Me.DrugRequisitionDataGridView)
        Me.Controls.Add(Me.DrugRequisitionBindingNavigator)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Drug_head"
        Me.Text = "Drug_head"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DrugRequisitionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseG26DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugRequisitionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DrugRequisitionBindingNavigator.ResumeLayout(False)
        Me.DrugRequisitionBindingNavigator.PerformLayout()
        CType(Me.DrugRequisitionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugReq_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugReq_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrugReq_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DrugReq_DetailsBindingNavigator.ResumeLayout(False)
        Me.DrugReq_DetailsBindingNavigator.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
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
    Friend WithEvents W_LU As Button
    Friend WithEvents DatabaseG26DataSet2 As DatabaseG26DataSet2
    Friend WithEvents DrugRequisitionBindingSource As BindingSource
    Friend WithEvents DrugRequisitionTableAdapter As DatabaseG26DataSet2TableAdapters.DrugRequisitionTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSet2TableAdapters.TableAdapterManager
    Friend WithEvents DrugRequisitionBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DrugRequisitionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DrugReqIDTextBox As TextBox
    Friend WithEvents RequisitionDateDateTimePicker As DateTimePicker
    Friend WithEvents DateReceivedDateTimePicker As DateTimePicker
    Friend WithEvents Requisition_byTextBox As TextBox
    Friend WithEvents Received_byTextBox As TextBox
    Friend WithEvents Clinic_NumTextBox As TextBox
    Friend WithEvents W_NumTextBox As TextBox
    Friend WithEvents DrugRequisitionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents User As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents DrugReq_DetailsBindingSource As BindingSource
    Friend WithEvents DrugReq_DetailsTableAdapter As DatabaseG26DataSet2TableAdapters.DrugReq_DetailsTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents DrugReq_DetailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DrugReq_DetailsBindingNavigator As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DrugReq_DetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Order_noTextBox As TextBox
    Friend WithEvents Drug_noTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Parma_LU As Button
End Class
