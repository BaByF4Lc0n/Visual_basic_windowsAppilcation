<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textboxgetid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textboxgetname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textboxgetlname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textboxgetmajor = New System.Windows.Forms.TextBox()
        Me.btadd = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.btreset = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btclose = New System.Windows.Forms.Button()
        Me.btback = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btreset)
        Me.GroupBox1.Controls.Add(Me.btedit)
        Me.GroupBox1.Controls.Add(Me.btadd)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.textboxgetmajor)
        Me.GroupBox1.Controls.Add(Me.textboxgetlname)
        Me.GroupBox1.Controls.Add(Me.textboxgetname)
        Me.GroupBox1.Controls.Add(Me.textboxgetid)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 243)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ลงทะเบียนนักเรียน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสนักรเรียน:"
        '
        'textboxgetid
        '
        Me.textboxgetid.Location = New System.Drawing.Point(112, 33)
        Me.textboxgetid.Name = "textboxgetid"
        Me.textboxgetid.Size = New System.Drawing.Size(155, 20)
        Me.textboxgetid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ:"
        '
        'textboxgetname
        '
        Me.textboxgetname.Location = New System.Drawing.Point(112, 75)
        Me.textboxgetname.Name = "textboxgetname"
        Me.textboxgetname.Size = New System.Drawing.Size(155, 20)
        Me.textboxgetname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "นามสกุล:"
        '
        'textboxgetlname
        '
        Me.textboxgetlname.Location = New System.Drawing.Point(112, 120)
        Me.textboxgetlname.Name = "textboxgetlname"
        Me.textboxgetlname.Size = New System.Drawing.Size(155, 20)
        Me.textboxgetlname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เพศ:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(112, 163)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ชาย"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(182, 163)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "หญิง"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ภาควิชา:"
        '
        'textboxgetmajor
        '
        Me.textboxgetmajor.Location = New System.Drawing.Point(112, 203)
        Me.textboxgetmajor.Name = "textboxgetmajor"
        Me.textboxgetmajor.Size = New System.Drawing.Size(155, 20)
        Me.textboxgetmajor.TabIndex = 1
        '
        'btadd
        '
        Me.btadd.Location = New System.Drawing.Point(347, 33)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(97, 31)
        Me.btadd.TabIndex = 3
        Me.btadd.Text = "เพิ่ม"
        Me.btadd.UseVisualStyleBackColor = True
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(347, 78)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(97, 31)
        Me.btedit.TabIndex = 3
        Me.btedit.Text = "แก้ไข"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'btreset
        '
        Me.btreset.Location = New System.Drawing.Point(347, 120)
        Me.btreset.Name = "btreset"
        Me.btreset.Size = New System.Drawing.Size(97, 31)
        Me.btreset.TabIndex = 3
        Me.btreset.Text = "ลบ"
        Me.btreset.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(71, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(491, 210)
        Me.DataGridView1.TabIndex = 1
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(1092, 502)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(89, 40)
        Me.btclose.TabIndex = 2
        Me.btclose.Text = "ออก"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(975, 502)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(89, 40)
        Me.btback.TabIndex = 2
        Me.btback.Text = "ย้อนกลับ"
        Me.btback.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 554)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "register"
        Me.Text = "register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textboxgetname As TextBox
    Friend WithEvents textboxgetid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents textboxgetlname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btreset As Button
    Friend WithEvents btedit As Button
    Friend WithEvents btadd As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents textboxgetmajor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btclose As Button
    Friend WithEvents btback As Button
End Class
