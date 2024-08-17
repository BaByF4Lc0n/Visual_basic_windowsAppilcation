<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textboxgetid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textboxgetfullname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textboxgetmajor = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textboxsearch = New System.Windows.Forms.TextBox()
        Me.btsearch = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.btback = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสนักเรียน:"
        '
        'textboxgetid
        '
        Me.textboxgetid.Location = New System.Drawing.Point(182, 75)
        Me.textboxgetid.Name = "textboxgetid"
        Me.textboxgetid.Size = New System.Drawing.Size(252, 20)
        Me.textboxgetid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ-นามสกุล:"
        '
        'textboxgetfullname
        '
        Me.textboxgetfullname.Location = New System.Drawing.Point(182, 181)
        Me.textboxgetfullname.Name = "textboxgetfullname"
        Me.textboxgetfullname.Size = New System.Drawing.Size(252, 20)
        Me.textboxgetfullname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "แผนการเรียน:"
        '
        'textboxgetmajor
        '
        Me.textboxgetmajor.Location = New System.Drawing.Point(179, 283)
        Me.textboxgetmajor.Name = "textboxgetmajor"
        Me.textboxgetmajor.Size = New System.Drawing.Size(252, 20)
        Me.textboxgetmajor.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(99, 339)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(335, 183)
        Me.DataGridView1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btsearch)
        Me.GroupBox1.Controls.Add(Me.textboxsearch)
        Me.GroupBox1.Location = New System.Drawing.Point(682, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(356, 190)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "กรอกรหัสนักเรียน"
        '
        'textboxsearch
        '
        Me.textboxsearch.Location = New System.Drawing.Point(39, 50)
        Me.textboxsearch.Name = "textboxsearch"
        Me.textboxsearch.Size = New System.Drawing.Size(280, 20)
        Me.textboxsearch.TabIndex = 0
        '
        'btsearch
        '
        Me.btsearch.Location = New System.Drawing.Point(259, 152)
        Me.btsearch.Name = "btsearch"
        Me.btsearch.Size = New System.Drawing.Size(75, 23)
        Me.btsearch.TabIndex = 1
        Me.btsearch.Text = "search"
        Me.btsearch.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(1076, 509)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(83, 33)
        Me.btclose.TabIndex = 4
        Me.btclose.Text = "ออก"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(973, 509)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(83, 33)
        Me.btback.TabIndex = 4
        Me.btback.Text = "ย้อนกลับ"
        Me.btback.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 554)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.textboxgetmajor)
        Me.Controls.Add(Me.textboxgetfullname)
        Me.Controls.Add(Me.textboxgetid)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "search"
        Me.Text = "search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textboxgetid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textboxgetfullname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textboxgetmajor As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btsearch As Button
    Friend WithEvents textboxsearch As TextBox
    Friend WithEvents btclose As Button
    Friend WithEvents btback As Button
End Class
