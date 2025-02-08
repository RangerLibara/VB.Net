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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRef = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataTable = New System.Windows.Forms.DataGridView()
        Me.ItemidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemtypeidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplieridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemtypenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuppliernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblitemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Libara_CRUD.DataSet1()
        Me.TblitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemtypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnDel)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnRef)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 428)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(829, 80)
        Me.Panel1.TabIndex = 2
        '
        'btnDel
        '
        Me.btnDel.BackgroundImage = Global.Libara_CRUD.My.Resources.Resources.trash1
        Me.btnDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDel.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.Location = New System.Drawing.Point(618, 13)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(186, 54)
        Me.btnDel.TabIndex = 1
        Me.btnDel.Text = "delete"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.Libara_CRUD.My.Resources.Resources.resume1
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEdit.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(422, 13)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(190, 54)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "edit"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.Libara_CRUD.My.Resources.Resources.add_friend1
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(226, 13)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(190, 54)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRef
        '
        Me.btnRef.BackgroundImage = Global.Libara_CRUD.My.Resources.Resources.refresh2
        Me.btnRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRef.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRef.Location = New System.Drawing.Point(30, 13)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(190, 54)
        Me.btnRef.TabIndex = 1
        Me.btnRef.Text = "Refresh"
        Me.btnRef.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRef.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRef.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DataTable)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(829, 508)
        Me.Panel2.TabIndex = 3
        '
        'DataTable
        '
        Me.DataTable.AllowUserToAddRows = False
        Me.DataTable.AllowUserToDeleteRows = False
        Me.DataTable.AutoGenerateColumns = False
        Me.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemidDataGridViewTextBoxColumn, Me.ItemcodeDataGridViewTextBoxColumn, Me.ItemnameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.ItemtypeidDataGridViewTextBoxColumn, Me.SupplieridDataGridViewTextBoxColumn, Me.CurrencyidDataGridViewTextBoxColumn, Me.ItemtypenameDataGridViewTextBoxColumn, Me.SuppliernameDataGridViewTextBoxColumn, Me.CurrencyDataGridViewTextBoxColumn})
        Me.DataTable.DataSource = Me.TblitemsBindingSource1
        Me.DataTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataTable.Location = New System.Drawing.Point(0, 0)
        Me.DataTable.MultiSelect = False
        Me.DataTable.Name = "DataTable"
        Me.DataTable.ReadOnly = True
        Me.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataTable.Size = New System.Drawing.Size(827, 506)
        Me.DataTable.TabIndex = 0
        '
        'ItemidDataGridViewTextBoxColumn
        '
        Me.ItemidDataGridViewTextBoxColumn.DataPropertyName = "item_id"
        Me.ItemidDataGridViewTextBoxColumn.HeaderText = "Item ID"
        Me.ItemidDataGridViewTextBoxColumn.Name = "ItemidDataGridViewTextBoxColumn"
        Me.ItemidDataGridViewTextBoxColumn.ReadOnly = True
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
        'ItemtypeidDataGridViewTextBoxColumn
        '
        Me.ItemtypeidDataGridViewTextBoxColumn.DataPropertyName = "item_type_id"
        Me.ItemtypeidDataGridViewTextBoxColumn.HeaderText = "Item Type"
        Me.ItemtypeidDataGridViewTextBoxColumn.Name = "ItemtypeidDataGridViewTextBoxColumn"
        Me.ItemtypeidDataGridViewTextBoxColumn.ReadOnly = True
        Me.ItemtypeidDataGridViewTextBoxColumn.Visible = False
        '
        'SupplieridDataGridViewTextBoxColumn
        '
        Me.SupplieridDataGridViewTextBoxColumn.DataPropertyName = "supplier_id"
        Me.SupplieridDataGridViewTextBoxColumn.HeaderText = "Supplier"
        Me.SupplieridDataGridViewTextBoxColumn.Name = "SupplieridDataGridViewTextBoxColumn"
        Me.SupplieridDataGridViewTextBoxColumn.ReadOnly = True
        Me.SupplieridDataGridViewTextBoxColumn.Visible = False
        '
        'CurrencyidDataGridViewTextBoxColumn
        '
        Me.CurrencyidDataGridViewTextBoxColumn.DataPropertyName = "currency_id"
        Me.CurrencyidDataGridViewTextBoxColumn.HeaderText = "Currency ID"
        Me.CurrencyidDataGridViewTextBoxColumn.Name = "CurrencyidDataGridViewTextBoxColumn"
        Me.CurrencyidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CurrencyidDataGridViewTextBoxColumn.Visible = False
        '
        'ItemtypenameDataGridViewTextBoxColumn
        '
        Me.ItemtypenameDataGridViewTextBoxColumn.DataPropertyName = "item_type_name"
        Me.ItemtypenameDataGridViewTextBoxColumn.HeaderText = "Item Type Name"
        Me.ItemtypenameDataGridViewTextBoxColumn.Name = "ItemtypenameDataGridViewTextBoxColumn"
        Me.ItemtypenameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SuppliernameDataGridViewTextBoxColumn
        '
        Me.SuppliernameDataGridViewTextBoxColumn.DataPropertyName = "supplier_name"
        Me.SuppliernameDataGridViewTextBoxColumn.HeaderText = "Supplier Name"
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
        'TblitemsBindingSource1
        '
        Me.TblitemsBindingSource1.DataMember = "tbl_items"
        Me.TblitemsBindingSource1.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblitemsBindingSource
        '
        Me.TblitemsBindingSource.DataMember = "tbl_items"
        '
        'TblitemtypesBindingSource
        '
        Me.TblitemtypesBindingSource.DataMember = "tbl_item_types"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 508)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CRUD"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDel As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnRef As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataTable As DataGridView
    Friend WithEvents TblitemsBindingSource As BindingSource
    Friend WithEvents TblitemtypesBindingSource As BindingSource
    Friend WithEvents TblitemsBindingSource1 As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ItemidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemtypeidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SupplieridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrencyidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemtypenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuppliernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
