Imports System.Data.OleDb
Imports System.Math
Public Class Form1
    Dim _id As Int16
    Dim _v1 As Double
    Dim _v2 As Double
    Dim _m As Double
    Dim _h As Double
    Dim _r As Double
    Const G As Double = 0.00000000006672
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BDPlanetDataSet.Планеты". При необходимости она может быть перемещена или удалена.
        Me.ПланетыTableAdapter.Fill(Me.BDPlanetDataSet.Планеты)
        Conn = New OleDbConnection
        conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Planet\Planet\BDPlanet.mdb"
    End Sub
    Private Sub Refresh_grid()
        Fill_grid(Grid1, "[Select] * From Планеты", "Планеты")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CalsVelocity()
        TextBox1.Text = _v1.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CalsVelocity()
        TextBox2.Text = _v2.ToString()
    End Sub

    Private Sub CalsVelocity()
        _v1 = Sqrt((G * _m) / (_r + _h))
        _v2 = _v1 * Sqrt(2)
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s1, s2, s3 As String
        Dim r As DialogResult
        Form2.ShowDialog()
        s1 = Form2.TextBox1.Text
        s2 = Form2.TextBox2.Text
        s3 = Form2.TextBox3.Text
        r = Form2.DialogResult
        Form2.Close()
        If r <> DialogResult.OK Then
            Exit Sub
        End If
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "onsert into [Планеты](Name,M,R) values ('" & s1 & "','" & s2 & "','" & s3 & "')"
        c.ExecuteNonQuery()
        Refresh_grid()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim k As Integer
        Dim c As New OleDbCommand
        c.Connection = conn
        k = Grid1.CurrentRow.Cells("КОД").Value
        c.CommandText = "delete from Планеты where КОД=" & k
        c.ExecuteNonQuery()
        Refresh_grid()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim s1, s2, s3 As String
        Dim r As DialogResult
        Dim k As Integer
        k = Grid1.CurrentRow.Cells("Код").Value
        Form2.TextBox1.Text = Grid1.CurrentRow.Cells("Name").Value
        Form2.TextBox2.Text = Grid1.CurrentRow.Cells("M").Value
        Form2.TextBox3.Text = Grid1.CurrentRow.Cells("R").Value
        Form2.ShowDialog()
        s1 = Form2.TextBox1.Text
        s2 = Form2.TextBox2.Text
        s3 = Form2.TextBox3.Text
        r = Form2.DialogResult
        Form2.Close()
        If r <> DialogResult.OK Then
            Exit Sub
        End If
        Dim c As New OleDbCommand
        c.Connection = conn
        c.CommandText = "update Планеты set Name='" & s1 & "',M='" & s2 & "',R='" & s3 &
        c.ExecuteNonQuery()
        Refresh_grid()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Refresh_grid()
        Grid1.Columns("КОД").Visible = False
        Getplanetinfo()
    End Sub

End Class
