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
        Me.buttontopagecalculator = New System.Windows.Forms.Button()
        Me.buttontopagecutgrade = New System.Windows.Forms.Button()
        Me.buttontopageregister = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttontopagecalculator
        '
        Me.buttontopagecalculator.Location = New System.Drawing.Point(73, 175)
        Me.buttontopagecalculator.Name = "buttontopagecalculator"
        Me.buttontopagecalculator.Size = New System.Drawing.Size(236, 130)
        Me.buttontopagecalculator.TabIndex = 0
        Me.buttontopagecalculator.Text = "โปรแกรมคิดเลข"
        Me.buttontopagecalculator.UseVisualStyleBackColor = True
        '
        'buttontopagecutgrade
        '
        Me.buttontopagecutgrade.Location = New System.Drawing.Point(450, 175)
        Me.buttontopagecutgrade.Name = "buttontopagecutgrade"
        Me.buttontopagecutgrade.Size = New System.Drawing.Size(236, 130)
        Me.buttontopagecutgrade.TabIndex = 0
        Me.buttontopagecutgrade.Text = "โปรแกรมตัดเกรด"
        Me.buttontopagecutgrade.UseVisualStyleBackColor = True
        '
        'buttontopageregister
        '
        Me.buttontopageregister.Location = New System.Drawing.Point(829, 175)
        Me.buttontopageregister.Name = "buttontopageregister"
        Me.buttontopageregister.Size = New System.Drawing.Size(236, 130)
        Me.buttontopageregister.TabIndex = 0
        Me.buttontopageregister.Text = "ลงทะเบียน"
        Me.buttontopageregister.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(1117, 511)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(78, 31)
        Me.btclose.TabIndex = 0
        Me.btclose.Text = "ออก"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1207, 554)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.buttontopageregister)
        Me.Controls.Add(Me.buttontopagecutgrade)
        Me.Controls.Add(Me.buttontopagecalculator)
        Me.Name = "Form1"
        Me.Text = "หน้าแรก"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents buttontopagecalculator As Button
    Friend WithEvents buttontopagecutgrade As Button
    Friend WithEvents btclose As Button
    Friend WithEvents buttontopageregister As Button
End Class
