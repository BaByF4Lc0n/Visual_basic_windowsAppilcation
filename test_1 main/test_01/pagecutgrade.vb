Public Class pagecutgrade
    Dim id, sum, score1, score2, score3, midterm, final As Integer

    Private Sub bttotal_Click(sender As Object, e As EventArgs) Handles bttotal.Click
        sum = score1 + score2 + score3 + midterm + final 'รวมคะแนน
        showtotalscore.Text = sum 'นำคะแนนรวมจากตัวแปลก sum ไปแสดงที่ textbox
    End Sub

    Private Sub textboxgetname_TextChanged(sender As Object, e As EventArgs) Handles textboxgetname.TextChanged

    End Sub

    Private Sub textboxgetnumber_TextChanged(sender As Object, e As EventArgs) Handles textboxgetnumber.TextChanged
        If (IsNumeric(textboxgetnumber.Text)) Then  'เช็คเงื่อนไขของเลขที่ ถ้าหากไม่ใช่ตัวเลขจะclearค่าและแจ้งเตือน
            id = textboxgetnumber.Text
        Else
            textboxgetnumber.Clear()
            MessageBox.Show("ข้อมูลผิด Data type")
        End If
    End Sub

    Private Sub textboxgetscore1_TextChanged(sender As Object, e As EventArgs) Handles textboxgetscore1.TextChanged
        If (IsNumeric(textboxgetscore1.Text)) Then
            If (textboxgetscore1.Text > 20) Then
                textboxgetscore1.Clear()
                MessageBox.Show("คุณคะแนนเกิน 20 คะแนน")
            ElseIf (textboxgetscore1.Text < 0) Then
                textboxgetscore1.Clear()
                MessageBox.Show("คุณคะแนนต่ำกว่า 20 คะแนน")
            Else
                score1 = textboxgetscore1.Text
            End If
        Else
            textboxgetscore1.Clear()
            MessageBox.Show("ข้อมูลผิด Data type")
        End If
    End Sub

    Private Sub textboxgetscore2_TextChanged(sender As Object, e As EventArgs) Handles textboxgetscore2.TextChanged
        If (IsNumeric(textboxgetscore2.Text)) Then
            If (textboxgetscore2.Text > 20) Then
                textboxgetscore2.Clear()
                MessageBox.Show("คุณคะแนนเกิน 20 คะแนน")
            ElseIf (textboxgetscore2.Text < 0) Then
                textboxgetscore2.Clear()
                MessageBox.Show("คุณคะแนนต่ำกว่า 20 คะแนน")
            Else
                score2 = textboxgetscore2.Text
            End If
        Else
            textboxgetscore2.Clear()
            MessageBox.Show("ข้อมูลผิด Data type")
        End If
    End Sub

    Private Sub textboxgetscoremidterm_TextChanged(sender As Object, e As EventArgs) Handles textboxgetscoremidterm.TextChanged
        If (IsNumeric(textboxgetscoremidterm.Text)) Then
            If (textboxgetscoremidterm.Text > 20) Then
                textboxgetscoremidterm.Clear()
                MessageBox.Show("คุณคะแนนเกิน 20 คะแนน")
            ElseIf (textboxgetscoremidterm.Text < 0) Then
                textboxgetscoremidterm.Clear()
                MessageBox.Show("คุณคะแนนต่ำกว่า 20 คะแนน")
            Else
                midterm = textboxgetscoremidterm.Text
            End If
        Else
            textboxgetscoremidterm.Clear()
            MessageBox.Show("ข้อมูลผิด Data type")
        End If
    End Sub

    Private Sub textboxgetscorefinal_TextChanged(sender As Object, e As EventArgs) Handles textboxgetscorefinal.TextChanged
        If (IsNumeric(textboxgetscorefinal.Text)) Then 'เช็คเงื่อนไข ว่าเป็นตัวเลขหรือไม่
            If (textboxgetscorefinal.Text > 20) Then
                textboxgetscorefinal.Clear()
                MessageBox.Show("คุณคะแนนเกิน 20 คะแนน")
            ElseIf (textboxgetscorefinal.Text < 0) Then
                textboxgetscorefinal.Clear()
                MessageBox.Show("คุณคะแนนต่ำกว่า 20 คะแนน")
            Else
                final = textboxgetscorefinal.Text
            End If
        Else
            textboxgetscorefinal.Clear()
            MessageBox.Show("ข้อมูลผิด Data type")
        End If
    End Sub

    Private Sub btcutgrade_Click(sender As Object, e As EventArgs) Handles btcutgrade.Click
        If (sum >= 80) Then
            MessageBox.Show("ชื่อ:" & textboxgetname.Text & vbNewLine &
                            "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                            "ชั้น:" & textboxgetclass.Text & vbNewLine &
                            "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                            "วิชา:" & listsubject.Text & vbNewLine &
                            "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                            "เกรด: 4" & vbNewLine
            )
        ElseIf (sum >= 70) Then
            MessageBox.Show("ชื่อ:" & textboxgetname.Text & vbNewLine &
                                "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                                "ชั้น:" & textboxgetclass.Text & vbNewLine &
                                "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                                "วิชา:" & listsubject.Text & vbNewLine &
                                "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                                "เกรด: 3" & vbNewLine
            )
        ElseIf (sum >= 60) Then
            MessageBox.Show("ชื่อ:" & textboxgetname.Text & vbNewLine &
                                "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                                "ชั้น:" & textboxgetclass.Text & vbNewLine &
                                "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                                "วิชา:" & listsubject.Text & vbNewLine &
                                "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                                "เกรด: 2" & vbNewLine
            )
        ElseIf (sum >= 50) Then
            MessageBox.Show("ชื่อ:" & textboxgetname.Text & vbNewLine &
                                "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                                "ชั้น:" & textboxgetclass.Text & vbNewLine &
                                "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                                "วิชา:" & listsubject.Text & vbNewLine &
                                "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                                "เกรด: 1" & vbNewLine
            )
        ElseIf (sum < 50) Then
            MessageBox.Show("ชื่อ:" & textboxgetname.Text & vbNewLine &
                                "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                                "ชั้น:" & textboxgetclass.Text & vbNewLine &
                                "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                                "วิชา:" & listsubject.Text & vbNewLine &
                                "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                                "เกรด: 0" & vbNewLine
            )
        End If
    End Sub

    Private Sub btshowresult_Click(sender As Object, e As EventArgs) Handles btshowresult.Click
        If (sum >= 80) Then
            showresult.Text = "ชื่อ:" & textboxgetname.Text & vbNewLine &
                            "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                            "ชั้น:" & textboxgetclass.Text & vbNewLine &
                            "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                            "วิชา:" & listsubject.Text & vbNewLine &
                            "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                            "เกรด: 4" & vbNewLine
        ElseIf (sum >= 70) Then
            showresult.Text = "ชื่อ:" & textboxgetname.Text & vbNewLine &
                                "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                                "ชั้น:" & textboxgetclass.Text & vbNewLine &
                                "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                                "วิชา:" & listsubject.Text & vbNewLine &
                                "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                                "เกรด: 3" & vbNewLine
        ElseIf (sum >= 60) Then
            showresult.Text = "ชื่อ:" & textboxgetname.Text & vbNewLine &
                                "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                                "ชั้น:" & textboxgetclass.Text & vbNewLine &
                                "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                                "วิชา:" & listsubject.Text & vbNewLine &
                                "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                                "เกรด: 2" & vbNewLine
        ElseIf (sum >= 50) Then
            showresult.Text = "ชื่อ:" & textboxgetname.Text & vbNewLine &
                                "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                                "ชั้น:" & textboxgetclass.Text & vbNewLine &
                                "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                                "วิชา:" & listsubject.Text & vbNewLine &
                                "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                                "เกรด: 1" & vbNewLine
        ElseIf (sum < 50) Then
            showresult.Text = "ชื่อ:" & textboxgetname.Text & vbNewLine &
                                "นามสกุล:" & textboxgetlname.Text & vbNewLine &
                                "ชั้น:" & textboxgetclass.Text & vbNewLine &
                                "เลขที่:" & textboxgetnumber.Text & vbNewLine &
                                "วิชา:" & listsubject.Text & vbNewLine &
                                "คะแนนรวม:" & showtotalscore.Text & vbNewLine &
                                "เกรด: 0" & vbNewLine
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label5.Click, Label13.Click, Label12.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles textboxgetscore3.TextChanged
        If (IsNumeric(textboxgetscore3.Text)) Then
            If (textboxgetscore3.Text > 20) Then
                textboxgetscore3.Clear()
                MessageBox.Show("คุณคะแนนเกิน 20 คะแนน")
            ElseIf (textboxgetscore3.Text < 0) Then
                textboxgetscore3.Clear()
                MessageBox.Show("คุณคะแนนต่ำกว่า 20 คะแนน")
            Else
                score3 = textboxgetscore3.Text
            End If
        Else
            textboxgetscore3.Clear()
            MessageBox.Show("ข้อมูลผิด Data type")
        End If
    End Sub

    Private Sub showresult_Click(sender As Object, e As EventArgs) Handles showresult.Click
    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class