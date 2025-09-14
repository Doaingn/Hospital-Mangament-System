<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InPatients
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
        Dim P_NumLabel As System.Windows.Forms.Label
        Dim Allocation_idLabel As System.Windows.Forms.Label
        Me.DatabaseG26DataSet = New WellMeadows_Hospital_G26.DatabaseG26DataSet()
        Me.InpatientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InpatientsTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.InpatientsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.InpatientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.InpatientsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.P_NumTextBox = New System.Windows.Forms.TextBox()
        Me.Allocation_idTextBox = New System.Windows.Forms.TextBox()
        Me.InpatientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Add_LU = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SHeadLB = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        P_NumLabel = New System.Windows.Forms.Label()
        Allocation_idLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InpatientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InpatientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InpatientsBindingNavigator.SuspendLayout()
        CType(Me.InpatientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'P_NumLabel
        '
        P_NumLabel.AutoSize = True
        P_NumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        P_NumLabel.Location = New System.Drawing.Point(3, 0)
        P_NumLabel.Name = "P_NumLabel"
        P_NumLabel.Size = New System.Drawing.Size(123, 20)
        P_NumLabel.TabIndex = 40
        P_NumLabel.Text = "Patient Number:"
        '
        'Allocation_idLabel
        '
        Allocation_idLabel.AutoSize = True
        Allocation_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Allocation_idLabel.Location = New System.Drawing.Point(3, 33)
        Allocation_idLabel.Name = "Allocation_idLabel"
        Allocation_idLabel.Size = New System.Drawing.Size(98, 20)
        Allocation_idLabel.TabIndex = 42
        Allocation_idLabel.Text = "Allocation id:"
        '
        'DatabaseG26DataSet
        '
        Me.DatabaseG26DataSet.DataSetName = "DatabaseG26DataSet"
        Me.DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InpatientsBindingSource
        '
        Me.InpatientsBindingSource.DataMember = "Inpatients"
        Me.InpatientsBindingSource.DataSource = Me.DatabaseG26DataSet
        '
        'InpatientsTableAdapter
        '
        Me.InpatientsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.InpatientsTableAdapter = Me.InpatientsTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'InpatientsBindingNavigator
        '
        Me.InpatientsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InpatientsBindingNavigator.BindingSource = Me.InpatientsBindingSource
        Me.InpatientsBindingNavigator.CountItem = Nothing
        Me.InpatientsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InpatientsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.InpatientsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.InpatientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.InpatientsBindingNavigatorSaveItem})
        Me.InpatientsBindingNavigator.Location = New System.Drawing.Point(76, 261)
        Me.InpatientsBindingNavigator.MoveFirstItem = Nothing
        Me.InpatientsBindingNavigator.MoveLastItem = Nothing
        Me.InpatientsBindingNavigator.MoveNextItem = Nothing
        Me.InpatientsBindingNavigator.MovePreviousItem = Nothing
        Me.InpatientsBindingNavigator.Name = "InpatientsBindingNavigator"
        Me.InpatientsBindingNavigator.PositionItem = Nothing
        Me.InpatientsBindingNavigator.Size = New System.Drawing.Size(89, 29)
        Me.InpatientsBindingNavigator.TabIndex = 40
        Me.InpatientsBindingNavigator.Text = "BindingNavigator1"
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
        'InpatientsBindingNavigatorSaveItem
        '
        Me.InpatientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InpatientsBindingNavigatorSaveItem.Image = Global.WellMeadows_Hospital_G26.My.Resources.Resources._1_Save
        Me.InpatientsBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InpatientsBindingNavigatorSaveItem.Name = "InpatientsBindingNavigatorSaveItem"
        Me.InpatientsBindingNavigatorSaveItem.Size = New System.Drawing.Size(26, 26)
        Me.InpatientsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'P_NumTextBox
        '
        Me.P_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InpatientsBindingSource, "P_Num", True))
        Me.P_NumTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.P_NumTextBox.Location = New System.Drawing.Point(148, 3)
        Me.P_NumTextBox.Name = "P_NumTextBox"
        Me.P_NumTextBox.Size = New System.Drawing.Size(169, 26)
        Me.P_NumTextBox.TabIndex = 41
        '
        'Allocation_idTextBox
        '
        Me.Allocation_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InpatientsBindingSource, "allocation_id", True))
        Me.Allocation_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Allocation_idTextBox.Location = New System.Drawing.Point(148, 36)
        Me.Allocation_idTextBox.Name = "Allocation_idTextBox"
        Me.Allocation_idTextBox.Size = New System.Drawing.Size(169, 26)
        Me.Allocation_idTextBox.TabIndex = 43
        '
        'InpatientsDataGridView
        '
        Me.InpatientsDataGridView.AutoGenerateColumns = False
        Me.InpatientsDataGridView.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.InpatientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InpatientsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.InpatientsDataGridView.DataSource = Me.InpatientsBindingSource
        Me.InpatientsDataGridView.Location = New System.Drawing.Point(76, 302)
        Me.InpatientsDataGridView.Name = "InpatientsDataGridView"
        Me.InpatientsDataGridView.Size = New System.Drawing.Size(243, 220)
        Me.InpatientsDataGridView.TabIndex = 43
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "P_Num"
        Me.DataGridViewTextBoxColumn1.HeaderText = "P_Num"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "allocation_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "allocation_id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.32753!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.67247!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Add_LU, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(P_NumLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Allocation_idTextBox, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Allocation_idLabel, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.P_NumTextBox, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(76, 179)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(437, 66)
        Me.TableLayoutPanel1.TabIndex = 60
        '
        'Add_LU
        '
        Me.Add_LU.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Add_LU.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Add_LU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Add_LU.ForeColor = System.Drawing.Color.Transparent
        Me.Add_LU.Location = New System.Drawing.Point(381, 38)
        Me.Add_LU.Name = "Add_LU"
        Me.Add_LU.Size = New System.Drawing.Size(24, 23)
        Me.Add_LU.TabIndex = 60
        Me.Add_LU.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SHeadLB)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(528, 80)
        Me.Panel1.TabIndex = 62
        '
        'SHeadLB
        '
        Me.SHeadLB.AutoSize = True
        Me.SHeadLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.SHeadLB.Location = New System.Drawing.Point(71, 24)
        Me.SHeadLB.Name = "SHeadLB"
        Me.SHeadLB.Size = New System.Drawing.Size(113, 25)
        Me.SHeadLB.TabIndex = 50
        Me.SHeadLB.Text = "In-Patient"
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
        Me.Panel2.Size = New System.Drawing.Size(528, 81)
        Me.Panel2.TabIndex = 61
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
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Button1.BackgroundImage = Global.WellMeadows_Hospital_G26.My.Resources.Resources._2_Search_icon
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(381, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 63
        Me.Button1.UseVisualStyleBackColor = True
        '
        'InPatients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 548)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.InpatientsDataGridView)
        Me.Controls.Add(Me.InpatientsBindingNavigator)
        Me.Name = "InPatients"
        Me.Text = "InPatients"
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InpatientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InpatientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InpatientsBindingNavigator.ResumeLayout(False)
        Me.InpatientsBindingNavigator.PerformLayout()
        CType(Me.InpatientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseG26DataSet As DatabaseG26DataSet
    Friend WithEvents InpatientsBindingSource As BindingSource
    Friend WithEvents InpatientsTableAdapter As DatabaseG26DataSetTableAdapters.InpatientsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents InpatientsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents InpatientsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents P_NumTextBox As TextBox
    Friend WithEvents Allocation_idTextBox As TextBox
    Friend WithEvents InpatientsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Add_LU As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SHeadLB As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
