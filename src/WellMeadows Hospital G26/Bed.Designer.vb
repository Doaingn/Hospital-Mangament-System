<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bed))
        Dim Bed_IDLabel As System.Windows.Forms.Label
        Dim Bed_NumLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim W_NumLabel As System.Windows.Forms.Label
        Me.DatabaseG26DataSet = New WellMeadows_Hospital_G26.DatabaseG26DataSet()
        Me.BedsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BedsTableAdapter = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.BedsTableAdapter()
        Me.TableAdapterManager = New WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager()
        Me.BedsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BedsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BedsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Bed_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Bed_NumTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.W_NumTextBox = New System.Windows.Forms.TextBox()
        Bed_IDLabel = New System.Windows.Forms.Label()
        Bed_NumLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        W_NumLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BedsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BedsBindingNavigator.SuspendLayout()
        CType(Me.BedsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatabaseG26DataSet
        '
        Me.DatabaseG26DataSet.DataSetName = "DatabaseG26DataSet"
        Me.DatabaseG26DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BedsBindingSource
        '
        Me.BedsBindingSource.DataMember = "Beds"
        Me.BedsBindingSource.DataSource = Me.DatabaseG26DataSet
        '
        'BedsTableAdapter
        '
        Me.BedsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AddressesTableAdapter = Nothing
        Me.TableAdapterManager.AppointmentsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedAllocationsTableAdapter = Nothing
        Me.TableAdapterManager.BedsTableAdapter = Me.BedsTableAdapter
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
        Me.TableAdapterManager.UpdateOrder = WellMeadows_Hospital_G26.DatabaseG26DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Ward_AllocationsTableAdapter = Nothing
        Me.TableAdapterManager.Ward_Shift_RotasTableAdapter = Nothing
        Me.TableAdapterManager.WardsTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'BedsBindingNavigator
        '
        Me.BedsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BedsBindingNavigator.BindingSource = Me.BedsBindingSource
        Me.BedsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BedsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BedsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BedsBindingNavigatorSaveItem})
        Me.BedsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BedsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BedsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BedsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BedsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BedsBindingNavigator.Name = "BedsBindingNavigator"
        Me.BedsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BedsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.BedsBindingNavigator.TabIndex = 0
        Me.BedsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Leelawadee UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BedsDataGridView
        '
        Me.BedsDataGridView.AutoGenerateColumns = False
        Me.BedsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BedsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.BedsDataGridView.DataSource = Me.BedsBindingSource
        Me.BedsDataGridView.Location = New System.Drawing.Point(461, 132)
        Me.BedsDataGridView.Name = "BedsDataGridView"
        Me.BedsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.BedsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Bed_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Bed_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Bed_Num"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Bed_Num"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "W_Num"
        Me.DataGridViewTextBoxColumn4.HeaderText = "W_Num"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BedsBindingNavigatorSaveItem
        '
        Me.BedsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BedsBindingNavigatorSaveItem.Image = CType(resources.GetObject("BedsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BedsBindingNavigatorSaveItem.Name = "BedsBindingNavigatorSaveItem"
        Me.BedsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BedsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Bed_IDLabel
        '
        Bed_IDLabel.AutoSize = True
        Bed_IDLabel.Location = New System.Drawing.Point(154, 79)
        Bed_IDLabel.Name = "Bed_IDLabel"
        Bed_IDLabel.Size = New System.Drawing.Size(43, 13)
        Bed_IDLabel.TabIndex = 2
        Bed_IDLabel.Text = "Bed ID:"
        '
        'Bed_IDTextBox
        '
        Me.Bed_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedsBindingSource, "Bed_ID", True))
        Me.Bed_IDTextBox.Location = New System.Drawing.Point(214, 76)
        Me.Bed_IDTextBox.Name = "Bed_IDTextBox"
        Me.Bed_IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bed_IDTextBox.TabIndex = 3
        '
        'Bed_NumLabel
        '
        Bed_NumLabel.AutoSize = True
        Bed_NumLabel.Location = New System.Drawing.Point(154, 105)
        Bed_NumLabel.Name = "Bed_NumLabel"
        Bed_NumLabel.Size = New System.Drawing.Size(54, 13)
        Bed_NumLabel.TabIndex = 4
        Bed_NumLabel.Text = "Bed Num:"
        '
        'Bed_NumTextBox
        '
        Me.Bed_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedsBindingSource, "Bed_Num", True))
        Me.Bed_NumTextBox.Location = New System.Drawing.Point(214, 102)
        Me.Bed_NumTextBox.Name = "Bed_NumTextBox"
        Me.Bed_NumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Bed_NumTextBox.TabIndex = 5
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(154, 131)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 6
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedsBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(214, 128)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextBox.TabIndex = 7
        '
        'W_NumLabel
        '
        W_NumLabel.AutoSize = True
        W_NumLabel.Location = New System.Drawing.Point(154, 157)
        W_NumLabel.Name = "W_NumLabel"
        W_NumLabel.Size = New System.Drawing.Size(46, 13)
        W_NumLabel.TabIndex = 8
        W_NumLabel.Text = "W Num:"
        '
        'W_NumTextBox
        '
        Me.W_NumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BedsBindingSource, "W_Num", True))
        Me.W_NumTextBox.Location = New System.Drawing.Point(214, 154)
        Me.W_NumTextBox.Name = "W_NumTextBox"
        Me.W_NumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.W_NumTextBox.TabIndex = 9
        '
        'Bed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Bed_IDLabel)
        Me.Controls.Add(Me.Bed_IDTextBox)
        Me.Controls.Add(Bed_NumLabel)
        Me.Controls.Add(Me.Bed_NumTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(W_NumLabel)
        Me.Controls.Add(Me.W_NumTextBox)
        Me.Controls.Add(Me.BedsDataGridView)
        Me.Controls.Add(Me.BedsBindingNavigator)
        Me.Name = "Bed"
        Me.Text = "Bed"
        CType(Me.DatabaseG26DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BedsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BedsBindingNavigator.ResumeLayout(False)
        Me.BedsBindingNavigator.PerformLayout()
        CType(Me.BedsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseG26DataSet As DatabaseG26DataSet
    Friend WithEvents BedsBindingSource As BindingSource
    Friend WithEvents BedsTableAdapter As DatabaseG26DataSetTableAdapters.BedsTableAdapter
    Friend WithEvents TableAdapterManager As DatabaseG26DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BedsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BedsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BedsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Bed_IDTextBox As TextBox
    Friend WithEvents Bed_NumTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents W_NumTextBox As TextBox
End Class
