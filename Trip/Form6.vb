Imports MySql.Data.MySqlClient
Public Class Form6
    Private Const V As String = " "
    Dim conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=example")
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim da As DataSet
    Dim Query As String
    Dim itemcoll(100) As String
    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        
        dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub

    Private Sub dgv1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub
End Class