<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblUsername = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblUserType = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.itemTable = New System.Windows.Forms.DataGridView()
        Me.ItemidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemtypenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbldataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sample_dataset = New CRUD.sample_dataset()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnManageItems = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnManageUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.itemTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sample_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Controls.Add(Me.itemTable)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(940, 453)
        Me.Panel2.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Plum
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripSeparator1, Me.lblUsername, Me.ToolStripSeparator2, Me.ToolStripLabel3, Me.ToolStripSeparator3, Me.lblUserType, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 428)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(940, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripLabel1.Text = "Username:"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'lblUsername
        '
        Me.lblUsername.ForeColor = System.Drawing.Color.Blue
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(88, 22)
        Me.lblUsername.Text = "ToolStripLabel2"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripLabel3.Text = "User Type"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'lblUserType
        '
        Me.lblUserType.ForeColor = System.Drawing.Color.Red
        Me.lblUserType.Name = "lblUserType"
        Me.lblUserType.Size = New System.Drawing.Size(88, 22)
        Me.lblUserType.Text = "ToolStripLabel4"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton1.Text = "Logout"
        '
        'itemTable
        '
        Me.itemTable.AllowUserToAddRows = False
        Me.itemTable.AllowUserToDeleteRows = False
        Me.itemTable.AutoGenerateColumns = False
        Me.itemTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.itemTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.itemTable.BackgroundColor = System.Drawing.Color.White
        Me.itemTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemidDataGridViewTextBoxColumn, Me.ItemcodeDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.ItemtypenameDataGridViewTextBoxColumn, Me.SuppliernameDataGridViewTextBoxColumn, Me.CurrencyDataGridViewTextBoxColumn})
        Me.itemTable.DataSource = Me.TbldataBindingSource
        Me.itemTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemTable.Location = New System.Drawing.Point(0, 24)
        Me.itemTable.MultiSelect = False
        Me.itemTable.Name = "itemTable"
        Me.itemTable.ReadOnly = True
        Me.itemTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.itemTable.Size = New System.Drawing.Size(940, 429)
        Me.itemTable.TabIndex = 0
        '
        'ItemidDataGridViewTextBoxColumn
        '
        Me.ItemidDataGridViewTextBoxColumn.DataPropertyName = "item_id"
        Me.ItemidDataGridViewTextBoxColumn.HeaderText = "Item ID"
        Me.ItemidDataGridViewTextBoxColumn.Name = "ItemidDataGridViewTextBoxColumn"
        Me.ItemidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemidDataGridViewTextBoxColumn.Visible = False
        '
        'ItemcodeDataGridViewTextBoxColumn
        '
        Me.ItemcodeDataGridViewTextBoxColumn.DataPropertyName = "item_code"
        Me.ItemcodeDataGridViewTextBoxColumn.HeaderText = "Item Code"
        Me.ItemcodeDataGridViewTextBoxColumn.Name = "ItemcodeDataGridViewTextBoxColumn"
        Me.ItemcodeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemnameDataGridViewTextBoxColumn
        '
        Me.ItemnameDataGridViewTextBoxColumn.DataPropertyName = "item_name"
        Me.ItemnameDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ItemnameDataGridViewTextBoxColumn.Name = "ItemnameDataGridViewTextBoxColumn"
        Me.ItemnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemtypenameDataGridViewTextBoxColumn
        '
        Me.ItemtypenameDataGridViewTextBoxColumn.DataPropertyName = "item_type_name"
        Me.ItemtypenameDataGridViewTextBoxColumn.HeaderText = "Item Type"
        Me.ItemtypenameDataGridViewTextBoxColumn.Name = "ItemtypenameDataGridViewTextBoxColumn"
        Me.ItemtypenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppliernameDataGridViewTextBoxColumn
        '
        Me.SuppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name"
        Me.SuppliernameDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.SuppliernameDataGridViewTextBoxColumn.Name = "SuppliernameDataGridViewTextBoxColumn"
        Me.SuppliernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CurrencyDataGridViewTextBoxColumn
        '
        Me.CurrencyDataGridViewTextBoxColumn.DataPropertyName = "currency"
        Me.CurrencyDataGridViewTextBoxColumn.HeaderText = "Currency"
        Me.CurrencyDataGridViewTextBoxColumn.Name = "CurrencyDataGridViewTextBoxColumn"
        Me.CurrencyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TbldataBindingSource
        '
        Me.TbldataBindingSource.DataMember = "tbl_data"
        Me.TbldataBindingSource.DataSource = Me.Sample_dataset
        '
        'Sample_dataset
        '
        Me.Sample_dataset.DataSetName = "sample_dataset"
        Me.Sample_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Plum
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRefresh, Me.btnManageItems, Me.btnManageUsers})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(940, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(105, 20)
        Me.btnRefresh.Text = "Refresh Table"
        '
        'btnManageItems
        '
        Me.btnManageItems.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnEdit, Me.btnDel})
        Me.btnManageItems.Image = CType(resources.GetObject("btnManageItems.Image"), System.Drawing.Image)
        Me.btnManageItems.Name = "btnManageItems"
        Me.btnManageItems.Size = New System.Drawing.Size(141, 20)
        Me.btnManageItems.Text = "Manage Items Table"
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(123, 22)
        Me.btnAdd.Text = "Add item"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(123, 22)
        Me.btnEdit.Text = "Edit Item"
        '
        'btnDel
        '
        Me.btnDel.Image = CType(resources.GetObject("btnDel.Image"), System.Drawing.Image)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(123, 22)
        Me.btnDel.Text = "Delete"
        '
        'btnManageUsers
        '
        Me.btnManageUsers.Image = CType(resources.GetObject("btnManageUsers.Image"), System.Drawing.Image)
        Me.btnManageUsers.Name = "btnManageUsers"
        Me.btnManageUsers.Size = New System.Drawing.Size(109, 20)
        Me.btnManageUsers.Text = "Manage Users"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 453)
        Me.Controls.Add(Me.Panel2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.itemTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sample_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents itemTable As DataGridView
    Friend WithEvents TbldataBindingSource As BindingSource
    Friend WithEvents Sample_dataset As sample_dataset
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnRefresh As ToolStripMenuItem
    Friend WithEvents btnManageItems As ToolStripMenuItem
    Friend WithEvents btnEdit As ToolStripMenuItem
    Friend WithEvents btnDel As ToolStripMenuItem
    Friend WithEvents btnManageUsers As ToolStripMenuItem
    Friend WithEvents btnAdd As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblUsername As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents lblUserType As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ItemidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemtypenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppliernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
