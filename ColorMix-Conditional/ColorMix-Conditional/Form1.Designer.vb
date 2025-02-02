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
        Me.box1 = New System.Windows.Forms.PictureBox()
        Me.box2 = New System.Windows.Forms.PictureBox()
        Me.pbmix = New System.Windows.Forms.PictureBox()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.cb2 = New System.Windows.Forms.ComboBox()
        Me.mixbtn = New System.Windows.Forms.Button()
        CType(Me.box1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.box2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmix, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'box1
        '
        Me.box1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.box1.Location = New System.Drawing.Point(70, 53)
        Me.box1.Name = "box1"
        Me.box1.Size = New System.Drawing.Size(164, 151)
        Me.box1.TabIndex = 0
        Me.box1.TabStop = False
        '
        'box2
        '
        Me.box2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.box2.Location = New System.Drawing.Point(695, 53)
        Me.box2.Name = "box2"
        Me.box2.Size = New System.Drawing.Size(164, 151)
        Me.box2.TabIndex = 0
        Me.box2.TabStop = False
        '
        'pbmix
        '
        Me.pbmix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbmix.Location = New System.Drawing.Point(262, 53)
        Me.pbmix.Name = "pbmix"
        Me.pbmix.Size = New System.Drawing.Size(414, 151)
        Me.pbmix.TabIndex = 0
        Me.pbmix.TabStop = False
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Items.AddRange(New Object() {"Nothing", "Blue", "Red", "Green"})
        Me.cb1.Location = New System.Drawing.Point(70, 210)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(164, 21)
        Me.cb1.TabIndex = 1
        '
        'cb2
        '
        Me.cb2.FormattingEnabled = True
        Me.cb2.Items.AddRange(New Object() {"Nothing", "Blue", "Red", "Green"})
        Me.cb2.Location = New System.Drawing.Point(695, 210)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(164, 21)
        Me.cb2.TabIndex = 1
        '
        'mixbtn
        '
        Me.mixbtn.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.mixbtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mixbtn.ForeColor = System.Drawing.Color.Red
        Me.mixbtn.Location = New System.Drawing.Point(428, 210)
        Me.mixbtn.Name = "mixbtn"
        Me.mixbtn.Size = New System.Drawing.Size(80, 57)
        Me.mixbtn.TabIndex = 2
        Me.mixbtn.Text = "MIX"
        Me.mixbtn.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 544)
        Me.Controls.Add(Me.mixbtn)
        Me.Controls.Add(Me.cb2)
        Me.Controls.Add(Me.cb1)
        Me.Controls.Add(Me.box2)
        Me.Controls.Add(Me.pbmix)
        Me.Controls.Add(Me.box1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.box1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.box2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmix, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents box1 As PictureBox
    Friend WithEvents box2 As PictureBox
    Friend WithEvents pbmix As PictureBox
    Friend WithEvents cb1 As ComboBox
    Friend WithEvents cb2 As ComboBox
    Friend WithEvents mixbtn As Button
End Class
