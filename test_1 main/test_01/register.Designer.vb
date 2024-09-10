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
        Me.btclear = New System.Windows.Forms.Button()
        Me.btdel = New System.Windows.Forms.Button()
        Me.btedit = New System.Windows.Forms.Button()
        Me.btadd = New System.Windows.Forms.Button()
        Me.textboxgetmajor = New System.Windows.Forms.TextBox()
        Me.textboxgetlname = New System.Windows.Forms.TextBox()
        Me.textboxgetname = New System.Windows.Forms.TextBox()
        Me.textboxgetid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btclose = New System.Windows.Forms.Button()
        Me.btback = New System.Windows.Forms.Button()
        Me.textboxgetgender = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btclear)
        Me.GroupBox1.Controls.Add(Me.btdel)
        Me.GroupBox1.Controls.Add(Me.btedit)
        Me.GroupBox1.Controls.Add(Me.btadd)
        Me.GroupBox1.Controls.Add(Me.textboxgetmajor)
        Me.GroupBox1.Controls.Add(Me.textboxgetgender)
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
        'btclear
        '
        Me.btclear.Location = New System.Drawing.Point(347, 163)
        Me.btclear.Name = "btclear"
        Me.btclear.Size = New System.Drawing.Size(97, 31)
        Me.btclear.TabIndex = 3
        Me.btclear.Text = "ค่าเริ่มต้น"
        Me.btclear.UseVisualStyleBackColor = True
        '
        'btdel
        '
        Me.btdel.Location = New System.Drawing.Point(347, 120)
        Me.btdel.Name = "btdel"
        Me.btdel.Size = New System.Drawing.Size(97, 31)
        Me.btdel.TabIndex = 3
        Me.btdel.Text = "ลบ"
        Me.btdel.UseVisualStyleBackColor = True
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
        'btadd
        '
        Me.btadd.Location = New System.Drawing.Point(347, 33)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(97, 31)
        Me.btadd.TabIndex = 3
        Me.btadd.Text = "บันทีก"
        Me.btadd.UseVisualStyleBackColor = True
        '
        'textboxgetmajor
        '
        Me.textboxgetmajor.Location = New System.Drawing.Point(112, 203)
        Me.textboxgetmajor.Name = "textboxgetmajor"
        Me.textboxgetmajor.Size = New System.Drawing.Size(155, 20)
        Me.textboxgetmajor.TabIndex = 1
        '
        'textboxgetlname
        '
        Me.textboxgetlname.Location = New System.Drawing.Point(112, 120)
        Me.textboxgetlname.Name = "textboxgetlname"
        Me.textboxgetlname.Size = New System.Drawing.Size(155, 20)
        Me.textboxgetlname.TabIndex = 1
        '
        'textboxgetname
        '
        Me.textboxgetname.Location = New System.Drawing.Point(112, 75)
        Me.textboxgetname.Name = "textboxgetname"
        Me.textboxgetname.Size = New System.Drawing.Size(155, 20)
        Me.textboxgetname.TabIndex = 1
        '
        'textboxgetid
        '
        Me.textboxgetid.Location = New System.Drawing.Point(112, 33)
        Me.textboxgetid.Name = "textboxgetid"
        Me.textboxgetid.Size = New System.Drawing.Size(155, 20)
        Me.textboxgetid.TabIndex = 1
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(66, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เพศ:"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสนักเรียน:"
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
        'textboxgetgender
        '
        Me.textboxgetgender.Location = New System.Drawing.Point(112, 160)
        Me.textboxgetgender.Name = "textboxgetgender"
        Me.textboxgetgender.Size = New System.Drawing.Size(155, 20)
        Me.textboxgetgender.TabIndex = 1
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
    Friend WithEvents btdel As Button
    Friend WithEvents btedit As Button
    Friend WithEvents btadd As Button
    Friend WithEvents textboxgetmajor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btclose As Button
    Friend WithEvents btback As Button
    Friend WithEvents btclear As Button
    Friend WithEvents textboxgetgender As TextBox
End Class
