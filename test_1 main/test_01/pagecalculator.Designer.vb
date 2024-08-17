<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pagecalculator
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
        Me.textboxgetname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textboxgetclass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textboxgetid = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textboxgetnum_1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textboxgetnum_2 = New System.Windows.Forms.TextBox()
        Me.btplus = New System.Windows.Forms.Button()
        Me.btminus = New System.Windows.Forms.Button()
        Me.bttimes = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.btback = New System.Windows.Forms.Button()
        Me.btdivi = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ-นามสกุล:"
        '
        'textboxgetname
        '
        Me.textboxgetname.Location = New System.Drawing.Point(278, 35)
        Me.textboxgetname.Name = "textboxgetname"
        Me.textboxgetname.Size = New System.Drawing.Size(390, 20)
        Me.textboxgetname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(684, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ระดับชั้น:"
        '
        'textboxgetclass
        '
        Me.textboxgetclass.Location = New System.Drawing.Point(748, 35)
        Me.textboxgetclass.Name = "textboxgetclass"
        Me.textboxgetclass.Size = New System.Drawing.Size(114, 20)
        Me.textboxgetclass.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(889, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เลขที่:"
        '
        'textboxgetid
        '
        Me.textboxgetid.Location = New System.Drawing.Point(934, 35)
        Me.textboxgetid.Name = "textboxgetid"
        Me.textboxgetid.Size = New System.Drawing.Size(52, 20)
        Me.textboxgetid.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btminus)
        Me.GroupBox1.Controls.Add(Me.btdivi)
        Me.GroupBox1.Controls.Add(Me.bttimes)
        Me.GroupBox1.Controls.Add(Me.btplus)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.textboxgetnum_2)
        Me.GroupBox1.Controls.Add(Me.textboxgetnum_1)
        Me.GroupBox1.Location = New System.Drawing.Point(75, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1022, 341)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เครื่องคิดเลข"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(134, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ชุดตัวเลขที่ 1:"
        '
        'textboxgetnum_1
        '
        Me.textboxgetnum_1.Location = New System.Drawing.Point(222, 53)
        Me.textboxgetnum_1.Name = "textboxgetnum_1"
        Me.textboxgetnum_1.Size = New System.Drawing.Size(139, 20)
        Me.textboxgetnum_1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(134, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ชุดตัวเลขที่ 2:"
        '
        'textboxgetnum_2
        '
        Me.textboxgetnum_2.Location = New System.Drawing.Point(222, 98)
        Me.textboxgetnum_2.Name = "textboxgetnum_2"
        Me.textboxgetnum_2.Size = New System.Drawing.Size(139, 20)
        Me.textboxgetnum_2.TabIndex = 1
        '
        'btplus
        '
        Me.btplus.Location = New System.Drawing.Point(496, 53)
        Me.btplus.Name = "btplus"
        Me.btplus.Size = New System.Drawing.Size(113, 62)
        Me.btplus.TabIndex = 2
        Me.btplus.Text = "บวก"
        Me.btplus.UseVisualStyleBackColor = True
        '
        'btminus
        '
        Me.btminus.Location = New System.Drawing.Point(719, 56)
        Me.btminus.Name = "btminus"
        Me.btminus.Size = New System.Drawing.Size(113, 62)
        Me.btminus.TabIndex = 2
        Me.btminus.Text = "ลบ"
        Me.btminus.UseVisualStyleBackColor = True
        '
        'bttimes
        '
        Me.bttimes.Location = New System.Drawing.Point(496, 166)
        Me.bttimes.Name = "bttimes"
        Me.bttimes.Size = New System.Drawing.Size(113, 62)
        Me.bttimes.TabIndex = 2
        Me.bttimes.Text = "คูณ"
        Me.bttimes.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(1090, 489)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(82, 40)
        Me.btclose.TabIndex = 2
        Me.btclose.Text = "ออก"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(968, 489)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(82, 40)
        Me.btback.TabIndex = 2
        Me.btback.Text = "ย้อนกลับ"
        Me.btback.UseVisualStyleBackColor = True
        '
        'btdivi
        '
        Me.btdivi.Location = New System.Drawing.Point(719, 166)
        Me.btdivi.Name = "btdivi"
        Me.btdivi.Size = New System.Drawing.Size(113, 62)
        Me.btdivi.TabIndex = 2
        Me.btdivi.Text = "หาร"
        Me.btdivi.UseVisualStyleBackColor = True
        '
        'pagecalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.textboxgetid)
        Me.Controls.Add(Me.textboxgetclass)
        Me.Controls.Add(Me.textboxgetname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pagecalculator"
        Me.Text = "pagecalculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textboxgetname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textboxgetclass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textboxgetid As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btminus As Button
    Friend WithEvents bttimes As Button
    Friend WithEvents btplus As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents textboxgetnum_2 As TextBox
    Friend WithEvents textboxgetnum_1 As TextBox
    Friend WithEvents btclose As Button
    Friend WithEvents btback As Button
    Friend WithEvents btdivi As Button
End Class
