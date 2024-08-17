<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.getusername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.getpassword = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อผู้ใช้งาน:"
        '
        'getusername
        '
        Me.getusername.Location = New System.Drawing.Point(161, 86)
        Me.getusername.Name = "getusername"
        Me.getusername.Size = New System.Drawing.Size(278, 20)
        Me.getusername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รหัสผ่าน:"
        '
        'getpassword
        '
        Me.getpassword.Location = New System.Drawing.Point(161, 183)
        Me.getpassword.Name = "getpassword"
        Me.getpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.getpassword.Size = New System.Drawing.Size(278, 20)
        Me.getpassword.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(183, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 60)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "เข้าสู่ระบบ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btclose.Location = New System.Drawing.Point(538, 409)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(94, 29)
        Me.btclose.TabIndex = 2
        Me.btclose.Text = "ออก"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 450)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.getpassword)
        Me.Controls.Add(Me.getusername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "เข้าสู่ระบบการใช้งาน: "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents getusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents getpassword As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btclose As Button
End Class
