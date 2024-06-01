Imports MySql.Data.MySqlClient
Public Class Form4
    Dim driver As String
    Dim vehicle As String
    Private Const V As String = " "
    Dim conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=example")
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim da As DataSet
    Dim Query As String
    Dim itemcoll(100) As String
    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim rowIndex As Integer = 0

        For columnIndex As Integer = 0 To dgv2.Columns.Count - 1
            dgv2.Rows(rowIndex).Cells(columnIndex).Style.BackColor = Color.Red
        Next

    End Sub
End Class