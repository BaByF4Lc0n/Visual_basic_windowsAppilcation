Public Class pagecalculator
    Dim a, b, c As Integer

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btminus_Click(sender As Object, e As EventArgs) Handles btminus.Click
        a = textboxgetnum_1.Text
        b = textboxgetnum_2.Text
        c = a - b
        MessageBox.Show("ชื่อ: " & textboxgetname.Text & "ชั้น: " & textboxgetclass.Text & "เลขที่: " & textboxgetid.Text & "ค่า: " & c)
    End Sub

    Private Sub bttimes_Click(sender As Object, e As EventArgs) Handles bttimes.Click
        a = textboxgetnum_1.Text
        b = textboxgetnum_2.Text
        c = a * b
        MessageBox.Show("ชื่อ: " & textboxgetname.Text & "ชั้น: " & textboxgetclass.Text & "เลขที่: " & textboxgetid.Text & "ค่า: " & c)
    End Sub

    Private Sub btdivi_Click(sender As Object, e As EventArgs) Handles btdivi.Click
        a = textboxgetnum_1.Text
        b = textboxgetnum_2.Text
        c = a / b
        MessageBox.Show("ชื่อ: " & textboxgetname.Text & "ชั้น: " & textboxgetclass.Text & "เลขที่: " & textboxgetid.Text & "ค่า: " & c)
    End Sub

    Private Sub btplus_Click(sender As Object, e As EventArgs) Handles btplus.Click
        a = textboxgetnum_1.Text
        b = textboxgetnum_2.Text
        c = a + b
        MessageBox.Show("ชื่อ: " & textboxgetname.Text & "ชั้น: " & textboxgetclass.Text & "เลขที่: " & textboxgetid.Text & "ค่า: " & c)
    End Sub

    Private Sub textboxgetname_TextChanged(sender As Object, e As EventArgs) Handles textboxgetname.TextChanged

    End Sub
End Class