Public Class register
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click, Label4.Click, Label5.Click

    End Sub

    Private Sub textboxgetlname_TextChanged(sender As Object, e As EventArgs) Handles textboxgetlname.TextChanged, textboxgetmajor.TextChanged

    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class