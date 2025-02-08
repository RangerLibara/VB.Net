<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_Item
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
        Me.TblitemtypesBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbldataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemtypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemtypesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemtypesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemtypesBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbItemTypes = New System.Windows.Forms.ComboBox()
        Me.TblitemsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbldataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblsuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbSuppliers = New System.Windows.Forms.ComboBox()
        Me.TblitemsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbldataBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblcurrenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbCurrencies = New System.Windows.Forms.ComboBox()
        Me.TblitemtypesBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblitemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TblitemtypesBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblsuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldataBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcurrenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemtypesBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblitemtypesBindingSource4
        '
        Me.TblitemtypesBindingSource4.DataMember = "tbl_item_types"
        '
        'btnAdd
        '
        Me.btnAdd.BackgroundImage = Global.Libara_CRUD.My.Resources.Resources.add_friend1
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdd.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(343, 317)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(161, 73)
        Me.btnAdd.TabIndex = 39
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(142, 125)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(361, 33)
        Me.txtPrice.TabIndex = 35
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(142, 82)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtName.MaxLength = 3000
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(361, 33)
        Me.txtName.TabIndex = 34
        '
        'txtCode
        '
        Me.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCode.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCode.Location = New System.Drawing.Point(142, 40)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCode.MaxLength = 3000
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(361, 33)
        Me.txtCode.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Currency:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 215)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Supplier:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 173)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Item name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Item code:"
        '
        'TbldataBindingSource
        '
        Me.TbldataBindingSource.DataMember = "tbl_data"
        '
        'TblitemtypesBindingSource
        '
        Me.TblitemtypesBindingSource.DataMember = "tbl_item_types"
        '
        'TblitemtypesBindingSource1
        '
        Me.TblitemtypesBindingSource1.DataMember = "tbl_item_types"
        '
        'TblitemtypesBindingSource2
        '
        Me.TblitemtypesBindingSource2.DataMember = "tbl_item_types"
        '
        'TblitemtypesBindingSource5
        '
        Me.TblitemtypesBindingSource5.DataMember = "tbl_item_types"
        '
        'cmbItemTypes
        '
        Me.cmbItemTypes.DataSource = Me.TblitemtypesBindingSource5
        Me.cmbItemTypes.DisplayMember = "item_type_name"
        Me.cmbItemTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemTypes.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbItemTypes.FormattingEnabled = True
        Me.cmbItemTypes.Location = New System.Drawing.Point(142, 173)
        Me.cmbItemTypes.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbItemTypes.Name = "cmbItemTypes"
        Me.cmbItemTypes.Size = New System.Drawing.Size(361, 34)
        Me.cmbItemTypes.TabIndex = 36
        Me.cmbItemTypes.ValueMember = "item_type_id"
        '
        'TblitemsBindingSource1
        '
        Me.TblitemsBindingSource1.DataMember = "tbl_items"
        '
        'TbldataBindingSource1
        '
        Me.TbldataBindingSource1.DataMember = "tbl_data"
        '
        'TblsuppliersBindingSource
        '
        Me.TblsuppliersBindingSource.DataMember = "tbl_suppliers"
        '
        'cmbSuppliers
        '
        Me.cmbSuppliers.DataSource = Me.TblsuppliersBindingSource
        Me.cmbSuppliers.DisplayMember = "supplier_name"
        Me.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSuppliers.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSuppliers.FormattingEnabled = True
        Me.cmbSuppliers.Location = New System.Drawing.Point(142, 215)
        Me.cmbSuppliers.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbSuppliers.Name = "cmbSuppliers"
        Me.cmbSuppliers.Size = New System.Drawing.Size(361, 34)
        Me.cmbSuppliers.TabIndex = 37
        Me.cmbSuppliers.ValueMember = "supplier_id"
        '
        'TblitemsBindingSource2
        '
        Me.TblitemsBindingSource2.DataMember = "tbl_items"
        '
        'TbldataBindingSource2
        '
        Me.TbldataBindingSource2.DataMember = "tbl_data"
        '
        'TblcurrenciesBindingSource
        '
        Me.TblcurrenciesBindingSource.DataMember = "tbl_currencies"
        '
        'cmbCurrencies
        '
        Me.cmbCurrencies.DataSource = Me.TblcurrenciesBindingSource
        Me.cmbCurrencies.DisplayMember = "currency"
        Me.cmbCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCurrencies.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCurrencies.FormattingEnabled = True
        Me.cmbCurrencies.Location = New System.Drawing.Point(142, 261)
        Me.cmbCurrencies.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.cmbCurrencies.Name = "cmbCurrencies"
        Me.cmbCurrencies.Size = New System.Drawing.Size(361, 34)
        Me.cmbCurrencies.TabIndex = 38
        Me.cmbCurrencies.ValueMember = "currency_id"
        '
        'TblitemtypesBindingSource3
        '
        Me.TblitemtypesBindingSource3.DataMember = "tbl_item_types"
        '
        'TblitemsBindingSource
        '
        Me.TblitemsBindingSource.DataMember = "tbl_items"
        '
        'add_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 404)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbItemTypes)
        Me.Controls.Add(Me.cmbSuppliers)
        Me.Controls.Add(Me.cmbCurrencies)
        Me.Font = New System.Drawing.Font("Showcard Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "add_Item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Item"
        CType(Me.TblitemtypesBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblsuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldataBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcurrenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemtypesBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblitemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TblitemtypesBindingSource4 As BindingSource
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtCode As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TbldataBindingSource As BindingSource
    Friend WithEvents TblitemtypesBindingSource As BindingSource
    Friend WithEvents TblitemtypesBindingSource1 As BindingSource
    Friend WithEvents TblitemtypesBindingSource2 As BindingSource
    Friend WithEvents TblitemtypesBindingSource5 As BindingSource
    Friend WithEvents cmbItemTypes As ComboBox
    Friend WithEvents TblitemsBindingSource1 As BindingSource
    Friend WithEvents TbldataBindingSource1 As BindingSource
    Friend WithEvents TblsuppliersBindingSource As BindingSource
    Friend WithEvents cmbSuppliers As ComboBox
    Friend WithEvents TblitemsBindingSource2 As BindingSource
    Friend WithEvents TbldataBindingSource2 As BindingSource
    Friend WithEvents TblcurrenciesBindingSource As BindingSource
    Friend WithEvents cmbCurrencies As ComboBox
    Friend WithEvents TblitemtypesBindingSource3 As BindingSource
    Friend WithEvents TblitemsBindingSource As BindingSource
End Class
