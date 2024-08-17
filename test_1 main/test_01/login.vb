Imports System.Data.OleDb
Imports System.Data
Imports System.IO

Public Class login
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\student.accdb")
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim ds As New DataSet
    Private Function che_ck()
        con.Open()
        dt = New DataTable
        ds = New DataSet
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("select * from login", con)
        da.Fill(dt)

        For Each DataRow In dt.Rows
            If getusername.Text = DataRow(0) And getpassword.Text = DataRow(1) Then
                con.Close()
                Return True
            End If
        Next
        con.Close()
    End Function



    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub getusername_TextChanged(sender As Object, e As EventArgs) Handles getusername.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If che_ck() = True Then 'เช็คข้อมูลusernameและpassword
            Me.Hide()
            MessageBox.Show("successfull", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
        Else
            MessageBox.Show("unsuccessfull", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class