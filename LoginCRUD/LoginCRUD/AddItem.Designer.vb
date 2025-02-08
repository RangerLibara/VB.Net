<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddItem))
        Me.TblitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCurrencies = New System.Windows.Forms.ComboBox()
        Me.TblcurrenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sample_dataset = New CRUD.sample_dataset()
        Me.TbldataBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbSuppliers = New System.Windows.Forms.ComboBox()
        Me.TblsuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sample_dataset1 = New CRUD.sample_dataset()
        Me.TbldataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbItemTypes = New System.Windows.Forms.ComboBox()
        Me.TblitemtypesBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemtypesBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemtypesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sample_dataset2 = New CRUD.sample_dataset()
        Me.TblitemtypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemtypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbldataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.TblitemtypesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemtypesBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcurrenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sample_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldataBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sample_dataset1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sample_dataset2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblitemsBindingSource
        '
        Me.TblitemsBindingSource.DataMember = "tbl_items"
        '
        'cmbCurrencies
        '
        Me.cmbCurrencies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbCurrencies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbCurrencies.DataSource = Me.TblcurrenciesBindingSource
        Me.cmbCurrencies.DisplayMember = "currency"
        Me.cmbCurrencies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCurrencies.FormattingEnabled = True
        Me.cmbCurrencies.Location = New System.Drawing.Point(113, 240)
        Me.cmbCurrencies.Name = "cmbCurrencies"
        Me.cmbCurrencies.Size = New System.Drawing.Size(310, 28)
        Me.cmbCurrencies.TabIndex = 25
        Me.cmbCurrencies.ValueMember = "currency_id"
        '
        'TblcurrenciesBindingSource
        '
        Me.TblcurrenciesBindingSource.DataMember = "tbl_currencies"
        Me.TblcurrenciesBindingSource.DataSource = Me.Sample_dataset
        '
        'Sample_dataset
        '
        Me.Sample_dataset.DataSetName = "sample_dataset"
        Me.Sample_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbldataBindingSource2
        '
        Me.TbldataBindingSource2.DataMember = "tbl_data"
        Me.TbldataBindingSource2.DataSource = Me.Sample_dataset
        '
        'TblitemsBindingSource2
        '
        Me.TblitemsBindingSource2.DataMember = "tbl_items"
        '
        'cmbSuppliers
        '
        Me.cmbSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbSuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbSuppliers.DataSource = Me.TblsuppliersBindingSource
        Me.cmbSuppliers.DisplayMember = "supplier_name"
        Me.cmbSuppliers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuppliers.FormattingEnabled = True
        Me.cmbSuppliers.Location = New System.Drawing.Point(113, 198)
        Me.cmbSuppliers.Name = "cmbSuppliers"
        Me.cmbSuppliers.Size = New System.Drawing.Size(310, 28)
        Me.cmbSuppliers.TabIndex = 24
        Me.cmbSuppliers.ValueMember = "supplier_id"
        '
        'TblsuppliersBindingSource
        '
        Me.TblsuppliersBindingSource.DataMember = "tbl_suppliers"
        Me.TblsuppliersBindingSource.DataSource = Me.Sample_dataset1
        '
        'Sample_dataset1
        '
        Me.Sample_dataset1.DataSetName = "sample_dataset"
        Me.Sample_dataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbldataBindingSource1
        '
        Me.TbldataBindingSource1.DataMember = "tbl_data"
        Me.TbldataBindingSource1.DataSource = Me.Sample_dataset
        '
        'TblitemsBindingSource1
        '
        Me.TblitemsBindingSource1.DataMember = "tbl_items"
        '
        'cmbItemTypes
        '
        Me.cmbItemTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbItemTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbItemTypes.DataSource = Me.TblitemtypesBindingSource6
        Me.cmbItemTypes.DisplayMember = "item_type_name"
        Me.cmbItemTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemTypes.FormattingEnabled = True
        Me.cmbItemTypes.Location = New System.Drawing.Point(113, 159)
        Me.cmbItemTypes.Name = "cmbItemTypes"
        Me.cmbItemTypes.Size = New System.Drawing.Size(310, 28)
        Me.cmbItemTypes.TabIndex = 23
        Me.cmbItemTypes.ValueMember = "item_type_id"
        '
        'TblitemtypesBindingSource6
        '
        Me.TblitemtypesBindingSource6.DataMember = "tbl_item_types"
        Me.TblitemtypesBindingSource6.DataSource = Me.Sample_dataset
        '
        'TblitemtypesBindingSource5
        '
        Me.TblitemtypesBindingSource5.DataMember = "tbl_item_types"
        Me.TblitemtypesBindingSource5.DataSource = Me.Sample_dataset
        '
        'TblitemtypesBindingSource2
        '
        Me.TblitemtypesBindingSource2.DataMember = "tbl_item_types"
        Me.TblitemtypesBindingSource2.DataSource = Me.Sample_dataset2
        '
        'Sample_dataset2
        '
        Me.Sample_dataset2.DataSetName = "sample_dataset"
        Me.Sample_dataset2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblitemtypesBindingSource1
        '
        Me.TblitemtypesBindingSource1.DataMember = "tbl_item_types"
        Me.TblitemtypesBindingSource1.DataSource = Me.Sample_dataset
        '
        'TblitemtypesBindingSource
        '
        Me.TblitemtypesBindingSource.DataMember = "tbl_item_types"
        Me.TblitemtypesBindingSource.DataSource = Me.Sample_dataset
        '
        'TbldataBindingSource
        '
        Me.TbldataBindingSource.DataMember = "tbl_data"
        Me.TbldataBindingSource.DataSource = Me.Sample_dataset
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(113, 114)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(310, 26)
        Me.txtPrice.TabIndex = 22
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(113, 74)
        Me.txtName.MaxLength = 3000
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(310, 26)
        Me.txtName.TabIndex = 21
        '
        'txtCode
        '
        Me.txtCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(113, 35)
        Me.txtCode.MaxLength = 3000
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(310, 26)
        Me.txtCode.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 240)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Currency:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Supplier:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Item name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Item code:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Image)
        Me.btnAdd.Location = New System.Drawing.Point(20, 312)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(406, 51)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'TblitemtypesBindingSource3
        '
        Me.TblitemtypesBindingSource3.DataMember = "tbl_item_types"
        Me.TblitemtypesBindingSource3.DataSource = Me.Sample_dataset2
        '
        'TblitemtypesBindingSource4
        '
        Me.TblitemtypesBindingSource4.DataMember = "tbl_item_types"
        Me.TblitemtypesBindingSource4.DataSource = Me.Sample_dataset
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Plum
        Me.ClientSize = New System.Drawing.Size(437, 429)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.cmbCurrencies)
        Me.Controls.Add(Me.cmbSuppliers)
        Me.Controls.Add(Me.cmbItemTypes)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddItem"
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcurrenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sample_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldataBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sample_dataset1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sample_dataset2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TblitemsBindingSource As BindingSource
    Friend WithEvents cmbCurrencies As ComboBox
    Friend WithEvents TblitemsBindingSource2 As BindingSource
    Friend WithEvents cmbSuppliers As ComboBox
    Friend WithEvents TblitemsBindingSource1 As BindingSource
    Friend WithEvents cmbItemTypes As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents TbldataBindingSource2 As BindingSource
    Friend WithEvents Sample_dataset As sample_dataset
    Friend WithEvents TbldataBindingSource1 As BindingSource
    Friend WithEvents TbldataBindingSource As BindingSource
    Friend WithEvents TblsuppliersBindingSource As BindingSource
    Friend WithEvents Sample_dataset1 As sample_dataset
    Friend WithEvents TblcurrenciesBindingSource As BindingSource
    Friend WithEvents TblitemtypesBindingSource As BindingSource
    Friend WithEvents TblitemtypesBindingSource1 As BindingSource
    Friend WithEvents TblitemtypesBindingSource2 As BindingSource
    Friend WithEvents Sample_dataset2 As sample_dataset
    Friend WithEvents TblitemtypesBindingSource3 As BindingSource
    Friend WithEvents TblitemtypesBindingSource4 As BindingSource
    Friend WithEvents TblitemtypesBindingSource5 As BindingSource
    Friend WithEvents TblitemtypesBindingSource6 As BindingSource
End Class
