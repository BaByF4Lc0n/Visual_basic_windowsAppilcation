<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pagecutgrade
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
        Me.textboxgetname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textboxgetlname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textboxgetclass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textboxgetnumber = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.listsubject = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.textboxgetscore3 = New System.Windows.Forms.TextBox()
        Me.textboxgetscore2 = New System.Windows.Forms.TextBox()
        Me.textboxgetscore1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.textboxgetscorefinal = New System.Windows.Forms.TextBox()
        Me.textboxgetscoremidterm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.bttotal = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.showtotalscore = New System.Windows.Forms.TextBox()
        Me.btcutgrade = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.showresult = New System.Windows.Forms.Label()
        Me.btshowresult = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.btback = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textboxgetnumber)
        Me.GroupBox1.Controls.Add(Me.textboxgetclass)
        Me.GroupBox1.Controls.Add(Me.textboxgetlname)
        Me.GroupBox1.Controls.Add(Me.textboxgetname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(396, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "กรอกข้อมูลนักเรียน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ:"
        '
        'textboxgetname
        '
        Me.textboxgetname.Location = New System.Drawing.Point(61, 32)
        Me.textboxgetname.Name = "textboxgetname"
        Me.textboxgetname.Size = New System.Drawing.Size(274, 20)
        Me.textboxgetname.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "นามสกุล:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'textboxgetlname
        '
        Me.textboxgetlname.Location = New System.Drawing.Point(60, 72)
        Me.textboxgetlname.Name = "textboxgetlname"
        Me.textboxgetlname.Size = New System.Drawing.Size(274, 20)
        Me.textboxgetlname.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ระดับชั้น:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'textboxgetclass
        '
        Me.textboxgetclass.Location = New System.Drawing.Point(60, 114)
        Me.textboxgetclass.Name = "textboxgetclass"
        Me.textboxgetclass.Size = New System.Drawing.Size(274, 20)
        Me.textboxgetclass.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เลขที่:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'textboxgetnumber
        '
        Me.textboxgetnumber.Location = New System.Drawing.Point(61, 157)
        Me.textboxgetnumber.Name = "textboxgetnumber"
        Me.textboxgetnumber.Size = New System.Drawing.Size(274, 20)
        Me.textboxgetnumber.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "รหัสวิชา:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listsubject)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(42, 264)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 86)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ระดับชั้น"
        '
        'listsubject
        '
        Me.listsubject.FormattingEnabled = True
        Me.listsubject.Items.AddRange(New Object() {"ว30293 เขียนแบบเบื้องต้น", "ว30298 ฐานข้อมูลและมัลติมีเดีย"})
        Me.listsubject.Location = New System.Drawing.Point(61, 35)
        Me.listsubject.Name = "listsubject"
        Me.listsubject.Size = New System.Drawing.Size(273, 21)
        Me.listsubject.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.textboxgetscore3)
        Me.GroupBox3.Controls.Add(Me.textboxgetscore2)
        Me.GroupBox3.Controls.Add(Me.textboxgetscore1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(584, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(454, 170)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "คะแนนเก็บ 60 คะแนน"
        '
        'textboxgetscore3
        '
        Me.textboxgetscore3.Location = New System.Drawing.Point(134, 134)
        Me.textboxgetscore3.Name = "textboxgetscore3"
        Me.textboxgetscore3.Size = New System.Drawing.Size(274, 20)
        Me.textboxgetscore3.TabIndex = 1
        '
        'textboxgetscore2
        '
        Me.textboxgetscore2.Location = New System.Drawing.Point(134, 89)
        Me.textboxgetscore2.Name = "textboxgetscore2"
        Me.textboxgetscore2.Size = New System.Drawing.Size(274, 20)
        Me.textboxgetscore2.TabIndex = 1
        '
        'textboxgetscore1
        '
        Me.textboxgetscore1.Location = New System.Drawing.Point(134, 46)
        Me.textboxgetscore1.Name = "textboxgetscore1"
        Me.textboxgetscore1.Size = New System.Drawing.Size(274, 20)
        Me.textboxgetscore1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "คะแนนที่เก็บที่ 3:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "คะแนนที่เก็บที่ 2:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "คะแนนที่เก็บที่ 1:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(268, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "*คะแนนหน่วยละ 20 คะแนน"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btcutgrade)
        Me.GroupBox4.Controls.Add(Me.bttotal)
        Me.GroupBox4.Controls.Add(Me.showtotalscore)
        Me.GroupBox4.Controls.Add(Me.textboxgetscorefinal)
        Me.GroupBox4.Controls.Add(Me.textboxgetscoremidterm)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(584, 230)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(454, 250)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "คะแนนสอบ 40 คะแนน"
        '
        'textboxgetscorefinal
        '
        Me.textboxgetscorefinal.Location = New System.Drawing.Point(134, 89)
        Me.textboxgetscorefinal.Name = "textboxgetscorefinal"
        Me.textboxgetscorefinal.Size = New System.Drawing.Size(274, 20)
        Me.textboxgetscorefinal.TabIndex = 1
        '
        'textboxgetscoremidterm
        '
        Me.textboxgetscoremidterm.Location = New System.Drawing.Point(134, 46)
        Me.textboxgetscoremidterm.Name = "textboxgetscoremidterm"
        Me.textboxgetscoremidterm.Size = New System.Drawing.Size(274, 20)
        Me.textboxgetscoremidterm.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(19, 92)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "คะแนนสอบปลายภาค:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(268, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "*คะแนนหน่วยละ 20 คะแนน"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "คะแนนสอบกลางภาค:"
        '
        'bttotal
        '
        Me.bttotal.Location = New System.Drawing.Point(217, 115)
        Me.bttotal.Name = "bttotal"
        Me.bttotal.Size = New System.Drawing.Size(102, 37)
        Me.bttotal.TabIndex = 2
        Me.bttotal.Text = "รวมคะแนน"
        Me.bttotal.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(129, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "คะแนนรวม:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'showtotalscore
        '
        Me.showtotalscore.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.showtotalscore.Location = New System.Drawing.Point(200, 168)
        Me.showtotalscore.Name = "showtotalscore"
        Me.showtotalscore.ReadOnly = True
        Me.showtotalscore.Size = New System.Drawing.Size(143, 20)
        Me.showtotalscore.TabIndex = 1
        '
        'btcutgrade
        '
        Me.btcutgrade.Location = New System.Drawing.Point(200, 207)
        Me.btcutgrade.Name = "btcutgrade"
        Me.btcutgrade.Size = New System.Drawing.Size(102, 37)
        Me.btcutgrade.TabIndex = 2
        Me.btcutgrade.Text = "ตัดเกรด"
        Me.btcutgrade.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btshowresult)
        Me.GroupBox5.Controls.Add(Me.showresult)
        Me.GroupBox5.Location = New System.Drawing.Point(42, 370)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(396, 131)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "แสดงผล"
        '
        'showresult
        '
        Me.showresult.AutoSize = True
        Me.showresult.Location = New System.Drawing.Point(23, 28)
        Me.showresult.Name = "showresult"
        Me.showresult.Size = New System.Drawing.Size(0, 13)
        Me.showresult.TabIndex = 0
        '
        'btshowresult
        '
        Me.btshowresult.Location = New System.Drawing.Point(302, 102)
        Me.btshowresult.Name = "btshowresult"
        Me.btshowresult.Size = New System.Drawing.Size(75, 23)
        Me.btshowresult.TabIndex = 1
        Me.btshowresult.Text = "แสดงผล"
        Me.btshowresult.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(1055, 505)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(102, 37)
        Me.btclose.TabIndex = 2
        Me.btclose.Text = "ออก"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(924, 505)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(102, 37)
        Me.btback.TabIndex = 2
        Me.btback.Text = "ย้อนกลับ"
        Me.btback.UseVisualStyleBackColor = True
        '
        'pagecutgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 554)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "pagecutgrade"
        Me.Text = "pagecutgrade"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents textboxgetnumber As TextBox
    Friend WithEvents textboxgetclass As TextBox
    Friend WithEvents textboxgetlname As TextBox
    Friend WithEvents textboxgetname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents listsubject As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents textboxgetscore3 As TextBox
    Friend WithEvents textboxgetscore2 As TextBox
    Friend WithEvents textboxgetscore1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents textboxgetscorefinal As TextBox
    Friend WithEvents textboxgetscoremidterm As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btcutgrade As Button
    Friend WithEvents bttotal As Button
    Friend WithEvents showtotalscore As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents showresult As Label
    Friend WithEvents btshowresult As Button
    Friend WithEvents btclose As Button
    Friend WithEvents btback As Button
End Class
