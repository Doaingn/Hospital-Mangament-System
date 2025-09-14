<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Surgireq_detail
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
        Dim SurgicalReqIDLabel As System.Windows.Forms.Label
        Dim Order_noLabel As System.Windows.Forms.Label
        Dim Item_noLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Me.DatabaseG26DataSetReq_Details = New WellMeadows_Hospital_G26.DatabaseG26DataSetReq_Details()
        Me.SurgicalReq_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SurgicalReq_DetailsTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSetReq_DetailsTableAdapters.SurgicalReq_DetailsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSetReq_DetailsTableAdapters.TableAdapterManager()
        Me.SurgicalReq_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurgicalReqIDTextBox = New System.Windows.Forms.TextBox()
        Me.Order_noTextBox = New System.Windows.Forms.TextBox()
        Me.Item_noTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Parma_LU = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SurgicalReq_DetailsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.SurgicalReq_DetailsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SRbtn = New System.Windows.Forms.Button()
        SurgicalReqIDLabel = New System.Windows.Forms.Label()
        Order_noLabel = New System.Windows.Forms.Label()
        Item_noLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseG26DataSetReq_Details, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SurgicalReq_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SurgicalReq_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SurgicalReq_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SurgicalReq_DetailsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SurgicalReqIDLabel
        '
        SurgicalReqIDLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        SurgicalReqIDLabel.AutoSize = True
        SurgicalReqIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        SurgicalReqIDLabel.Location = New System.Drawing.Point(3, 9)
        SurgicalReqIDLabel.Name = "SurgicalReqIDLabel"
        SurgicalReqIDLabel.Size = New System.Drawing.Size(156, 20)
        SurgicalReqIDLabel.TabIndex = 29
        SurgicalReqIDLabel.Text = "Surgical Request ID:"
        '
        'Order_noLabel
        '
        Order_noLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Order_noLabel.AutoSize = True
        Order_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Order_noLabel.Location = New System.Drawing.Point(3, 48)
        Order_noLabel.Name = "Order_noLabel"
        Order_noLabel.Size = New System.Drawing.Size(75, 20)
        Order_noLabel.TabIndex = 31
        Order_noLabel.Text = "Order no:"
        '
        'Item_noLabel
        '
        Item_noLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Item_noLabel.AutoSize = True
        Item_noLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Item_noLabel.Location = New System.Drawing.Point(3, 87)
        Item_noLabel.Name = "Item_noLabel"
        Item_noLabel.Size = New System.Drawing.Size(67, 20)
        Item_noLabel.TabIndex = 33
        Item_noLabel.Text = "Item no:"
        '
        'QuantityLabel
        '
        QuantityLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        QuantityLabel.Location = New System.Drawing.Point(3, 127)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(72, 20)
        QuantityLabel.TabIndex = 35
        QuantityLabel.Text = "Quantity:"
        '
        'DatabaseG26DataSetReq_Details
        '
        Me.DatabaseG26DataSetReq_Details.DataSetName = "DatabaseG26DataSetReq_Details"
        Me.DatabaseG26DataSetReq_Details.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SurgicalReq_DetailsBindingSource
        '
        Me.SurgicalReq_DetailsBindingSource.DataMember = "SurgicalReq_Details"
        Me.SurgicalReq_DetailsBindingSource.DataSource = Me.DatabaseG26DataSetReq_Details
        '
        'SurgicalReq_DetailsTableAdapter
        '
        Me.SurgicalReq_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DrugReq_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Medication_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.SurgicalReq_DetailsTableAdapter = Me.SurgicalReq_DetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSetReq_DetailsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SurgicalReq_DetailsDataGridView
        '
        Me.SurgicalReq_DetailsDataGridView.AutoGenerateColumns = False
        Me.SurgicalReq_DetailsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.SurgicalReq_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SurgicalReq_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SurgicalReq_DetailsDataGridView.DataSource = Me.SurgicalReq_DetailsBindingSource
        Me.SurgicalReq_DetailsDataGridView.Location = New System.Drawing.Point(76, 407)
        Me.SurgicalReq_DetailsDataGridView.Name = "SurgicalReq_DetailsDataGridView"
        Me.SurgicalReq_DetailsDataGridView.Size = New System.Drawing.Size(439, 220)
        Me.SurgicalReq_DetailsDataGridView.TabIndex = 29
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "SurgicalReqID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SurgicalReqID"
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "item_no"
        Me.DataGridViewTextBoxColumn3.HeaderText = "item_no"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'SurgicalReqIDTextBox
        '
        Me.SurgicalReqIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SurgicalReqIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalReq_DetailsBindingSource, "SurgicalReqID", True))
        Me.SurgicalReqIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SurgicalReqIDTextBox.Location = New System.Drawing.Point(165, 6)
        Me.SurgicalReqIDTextBox.Name = "SurgicalReqIDTextBox"
        Me.SurgicalReqIDTextBox.Size = New System.Drawing.Size(175, 26)
        Me.SurgicalReqIDTextBox.TabIndex = 30
        '
        'Order_noTextBox
        '
        Me.Order_noTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Order_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalReq_DetailsBindingSource, "order_no", True))
        Me.Order_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Order_noTextBox.Location = New System.Drawing.Point(165, 45)
        Me.Order_noTextBox.Name = "Order_noTextBox"
        Me.Order_noTextBox.Size = New System.Drawing.Size(175, 26)
        Me.Order_noTextBox.TabIndex = 32
        '
        'Item_noTextBox
        '
        Me.Item_noTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Item_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalReq_DetailsBindingSource, "item_no", True))
        Me.Item_noTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Item_noTextBox.Location = New System.Drawing.Point(165, 84)
        Me.Item_noTextBox.Name = "Item_noTextBox"
        Me.Item_noTextBox.Size = New System.Drawing.Size(175, 26)
        Me.Item_noTextBox.TabIndex = 34
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SurgicalReq_DetailsBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(165, 124)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(175, 26)
        Me.QuantityTextBox.TabIndex = 36
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
        Me.Panel2.Size = New System.Drawing.Size(591, 81)
        Me.Panel2.TabIndex = 39
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
        Me.TableLayoutPanel1.Controls.Add(Me.SRbtn, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(SurgicalReqIDLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Order_noLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.QuantityTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Item_noTextBox, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Order_noTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.SurgicalReqIDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Item_noLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(QuantityLabel, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Parma_LU, 2, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 184)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(392, 157)
        Me.TableLayoutPanel1.TabIndex = 50
        '
        'Parma_LU
        '
        Me.Parma_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Parma_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Parma_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Parma_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Parma_LU.Location = New System.Drawing.Point(346, 86)
        Me.Parma_LU.Name = "Parma_LU"
        Me.Parma_LU.Size = New System.Drawing.Size(24, 23)
        Me.Parma_LU.TabIndex = 50
        Me.Parma_LU.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 80)
        Me.Panel1.TabIndex = 53
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(252, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "Surgical Request Form"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'SurgicalReq_DetailsBindingNavigator
        '
        Me.SurgicalReq_DetailsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SurgicalReq_DetailsBindingNavigator.AutoSize = False
        Me.SurgicalReq_DetailsBindingNavigator.BindingSource = Me.SurgicalReq_DetailsBindingSource
        Me.SurgicalReq_DetailsBindingNavigator.CountItem = Nothing
        Me.SurgicalReq_DetailsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SurgicalReq_DetailsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.SurgicalReq_DetailsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.SurgicalReq_DetailsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSeparator2, Me.SurgicalReq_DetailsBindingNavigatorSaveItem})
        Me.SurgicalReq_DetailsBindingNavigator.Location = New System.Drawing.Point(76, 357)
        Me.SurgicalReq_DetailsBindingNavigator.MoveFirstItem = Nothing
        Me.SurgicalReq_DetailsBindingNavigator.MoveLastItem = Nothing
        Me.SurgicalReq_DetailsBindingNavigator.MoveNextItem = Nothing
        Me.SurgicalReq_DetailsBindingNavigator.MovePreviousItem = Nothing
        Me.SurgicalReq_DetailsBindingNavigator.Name = "SurgicalReq_DetailsBindingNavigator"
        Me.SurgicalReq_DetailsBindingNavigator.PositionItem = Nothing
        Me.SurgicalReq_DetailsBindingNavigator.Size = New System.Drawing.Size(89, 30)
        Me.SurgicalReq_DetailsBindingNavigator.TabIndex = 29
        Me.SurgicalReq_DetailsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Add
        Me.BindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 27)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Delete
        Me.BindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 27)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'SurgicalReq_DetailsBindingNavigatorSaveItem
        '
        Me.SurgicalReq_DetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SurgicalReq_DetailsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.SurgicalReq_DetailsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SurgicalReq_DetailsBindingNavigatorSaveItem.Name = "SurgicalReq_DetailsBindingNavigatorSaveItem"
        Me.SurgicalReq_DetailsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 27)
        Me.SurgicalReq_DetailsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SRbtn
        '
        Me.SRbtn.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SRbtn.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.SRbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SRbtn.ForeColor = System.Drawing.Color.Transparent
        Me.SRbtn.Location = New System.Drawing.Point(346, 8)
        Me.SRbtn.Name = "SRbtn"
        Me.SRbtn.Size = New System.Drawing.Size(24, 23)
        Me.SRbtn.TabIndex = 54
        Me.SRbtn.UseVisualStyleBackColor = True
        '
        'Surgireq_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 660)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.SurgicalReq_DetailsDataGridView)
        Me.Controls.Add(Me.SurgicalReq_DetailsBindingNavigator)
        Me.Name = "Surgireq_detail"
        Me.Text = "Surgireq_detail"
        CType(Me.DatabaseG26DataSetReq_Details, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SurgicalReq_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SurgicalReq_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SurgicalReq_DetailsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SurgicalReq_DetailsBindingNavigator.ResumeLayout(False)
        Me.SurgicalReq_DetailsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DatabaseG26DataSetReq_Details As DatabaseG26DataSetReq_Details
    Friend WithEvents SurgicalReq_DetailsBindingSource As BindingSource
    Friend WithEvents SurgicalReq_DetailsTableAdapter As DatabaseG26DataSetReq_DetailsTableAdapters.SurgicalReq_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSetReq_DetailsTableAdapters.TableAdapterManager
    Friend WithEvents SurgicalReq_DetailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents SurgicalReqIDTextBox As TextBox
    Friend WithEvents Order_noTextBox As TextBox
    Friend WithEvents Item_noTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents SurgicalReq_DetailsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SurgicalReq_DetailsBindingNavigator As BindingNavigator
    Friend WithEvents Parma_LU As Button
    Friend WithEvents SRbtn As Button
End Class
