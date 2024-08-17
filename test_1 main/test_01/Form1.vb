Public Class Form1
    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub buttontopagecalculator_Click(sender As Object, e As EventArgs) Handles buttontopagecalculator.Click
        Me.Hide()
        pagecalculator.Show()
    End Sub

    Private Sub buttontopagecutgrade_Click(sender As Object, e As EventArgs) Handles buttontopagecutgrade.Click
        pagecutgrade.Show()
        Me.Hide()
    End Sub

    Private Sub buttontopageregister_Click(sender As Object, e As EventArgs) Handles buttontopageregister.Click
        Me.Hide()
        register.Show()
    End Sub
End Class
