Imports MySql.Data.MySqlClient
Public Class Form5
    Dim driver As String
    Dim vehicle As String
    Private Const V As String = " "
    Dim conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=example")
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim da As DataSet
    Dim Query As String
    Dim itemcoll(100) As String

    Private Sub save_Click(sender As System.Object, e As System.EventArgs) Handles save.Click
        Try
            conn.Open()
            Query = " INSERT INTO `t2` (`date_of_request`,`stock_balance_in_tank`,`fuel_consumption`,`remaining_balance_in_tank`,`distance_traveled`,`liters_loaded`,`amount_of_diesel_purchased`) VALUES ('" & dt1.Text & "','" & tb1.Text & "','" & tb2.Text & "','" & tb3.Text & "','" & tb4.Text & "','" & tb5.Text & "','" & tb6.Text & "')"
            Command = New MySqlCommand(Query, conn)
            reader = Command.ExecuteReader

            MessageBox.Show("Trip Ticket Save")
            conn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class