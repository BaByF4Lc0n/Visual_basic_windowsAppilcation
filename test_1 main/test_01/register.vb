Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient


Public Class register
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\student.accdb")
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim ds As New DataSet
    Private Sub Register_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
            MsgBox("open")
        End If
    End Sub
    Private Function Checkdata()
        Dim result As Boolean
        If textboxgetid.Text = "" Or textboxgetname.Text = "" Or textboxgetlname.Text = "" Or textboxgetgender.Text = "" Or textboxgetmajor.Text = "" Then
            MessageBox.Show("กรุณาใส่ข้อมูลให้ครบ")
            result = False
        Else
            result = True
        End If
        Return result
    End Function
    Private Sub showtable()
        Dim sqlQuery As String
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        sqlQuery = "select * from std"
        da = New OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns.Item(0).HeaderText() = "รหัสนักเรียน"
        DataGridView1.Columns.Item(1).HeaderText() = "ชื่อ"
        DataGridView1.Columns.Item(2).HeaderText() = "นามสกุล"
        DataGridView1.Columns.Item(3).HeaderText() = "เพศ"
        DataGridView1.Columns.Item(4).HeaderText() = "ภาควิชา"
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label3.Click, Label4.Click, Label5.Click

    End Sub

    Private Sub textboxgetlname_TextChanged(sender As Object, e As EventArgs) Handles textboxgetlname.TextChanged, textboxgetmajor.TextChanged, textboxgetgender.TextChanged

    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        textboxgetid.Text = DataGridView1.Item(0, i).Value
        textboxgetname.Text = DataGridView1.Item(1, i).Value
        textboxgetlname.Text = DataGridView1.Item(2, i).Value
        textboxgetgender.Text = DataGridView1.Item(3, i).Value
        textboxgetmajor.Text = DataGridView1.Item(4, i).Value
    End Sub

    Private Sub btclear_Click(sender As Object, e As EventArgs) Handles btclear.Click
        textboxgetid.Clear()
        textboxgetname.Clear()
        textboxgetlname.Clear()
        textboxgetgender.Clear()
        textboxgetmajor.Clear()
    End Sub

    Private Sub btadd_Click(sender As Object, e As EventArgs) Handles btadd.Click
        Dim sqlQuery As String
        Dim result As Boolean
        result = Checkdata()
        If result = True Then
            Try
                sqlQuery = "INSERT INTO std(std_id,std_Name,std_Sname,std_Gender,std_Major) VALUES ('" & textboxgetid.Text & "','" & textboxgetname.Text & "','" & textboxgetlname.Text & "','" & textboxgetgender.Text & "','" & textboxgetmajor.Text & "')"
                Dim cmd As New OleDbCommand(sqlQuery, con)
                cmd.ExecuteNonQuery()
                MsgBox("บันทีกข้อมูลสำเร็จ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showtable()
    End Sub

    Private Sub btedit_Click(sender As Object, e As EventArgs) Handles btedit.Click
        Dim sqlQuery As String
        Dim result As Boolean
        result = Checkdata()
        If result = True Then
            Try
                sqlQuery = "UPDATE std SET std_Name = '" & textboxgetname.Text & "', std_Sname = '" & textboxgetlname.Text & "',std_Gender = '" & textboxgetgender.Text & "',std_Major = '" & textboxgetmajor.Text & "' WHERE std_id = '" & textboxgetid.Text & "'"
                Dim cmd As New OleDbCommand(sqlQuery, con)
                cmd.ExecuteNonQuery()
                MsgBox("แก้ไขข้อมูลสำเร็จ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showtable()
    End Sub

    Private Sub btreset_Click(sender As Object, e As EventArgs) Handles btdel.Click
        Dim sqlQuery As String
        Dim result As Boolean
        result = Checkdata()
        If result = True Then
            Try
                sqlQuery = "DELETE FROM std WHERE std_id = '" & textboxgetid.Text & "'" '& textboxgetname.Text & "','" & textboxgetlname.Text & "','" & textboxgetgender.Text & "','" & textboxgetmajor.Text & "')"
                Dim cmd As New OleDbCommand(sqlQuery, con)
                cmd.ExecuteNonQuery()
                MsgBox("ลบข้อมูลสำเร็จ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showtable()
    End Sub
End Class