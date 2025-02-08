<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.TblusertypesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sample_dataset = New CRUD.sample_dataset()
        Me.UsersloginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TblusertypesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sample_dataset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersloginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(121, 49)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(296, 29)
        Me.txtUsername.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(121, 113)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(296, 29)
        Me.txtPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "User Type:"
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), System.Drawing.Image)
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddUser.Location = New System.Drawing.Point(312, 236)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(105, 51)
        Me.btnAddUser.TabIndex = 6
        Me.btnAddUser.Text = "Add"
        Me.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'cmbUserType
        '
        Me.cmbUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbUserType.DataSource = Me.TblusertypesBindingSource
        Me.cmbUserType.DisplayMember = "usertype_name"
        Me.cmbUserType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Location = New System.Drawing.Point(121, 179)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(296, 28)
        Me.cmbUserType.TabIndex = 7
        Me.cmbUserType.ValueMember = "usertype_id"
        '
        'TblusertypesBindingSource
        '
        Me.TblusertypesBindingSource.DataMember = "tbl_usertypes"
        Me.TblusertypesBindingSource.DataSource = Me.Sample_dataset
        '
        'Sample_dataset
        '
        Me.Sample_dataset.DataSetName = "sample_dataset"
        Me.Sample_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsersloginBindingSource
        '
        Me.UsersloginBindingSource.DataMember = "userslogin"
        Me.UsersloginBindingSource.DataSource = Me.Sample_dataset
        '
        'AddUser
        '
        Me.AcceptButton = Me.btnAddUser
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 310)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "AddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        CType(Me.TblusertypesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sample_dataset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersloginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddUser As Button
    Friend WithEvents cmbUserType As ComboBox
    Friend WithEvents UsersloginBindingSource As BindingSource
    Friend WithEvents Sample_dataset As sample_dataset
    Friend WithEvents TblusertypesBindingSource As BindingSource
End Class
