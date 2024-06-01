Imports MySql.Data.MySqlClient
Public Class Form7
    Private Const V As String = " "
    Dim conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=example")
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim da As DataSet
    Dim dt As New DataTable
    Dim daa As New MySqlDataAdapter
    Dim Query As String
    Dim itemcoll(100) As String
    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        conn.Open()
        Dim cmd As New MySqlCommand("Select t1.date_of_request, t1.date_of_travel, t1.place_of_travel, t1.office, t1.purpose, t1.driver, t1.plate_number, t1.time, t1.dispatcher, t2.date_of_request, t2.stock_balance_in_tank, t2.fuel_consumption, t2.remaining_balance_in_tank, t2.distance_traveled, t2.liters_loaded, t2.amount_of_diesel_purchased FROM t1 INNER JOIN t2 ON t1.date_of_request = t2.date_of_request", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        dt.Clear()
        da.Fill(dt)
        dgv1.DataSource = dt
        conn.Close()




        dgv1.MultiSelect = True
        dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

    End Sub
    Private Sub dgv1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub


    Private Sub reload(p1 As String, dataGridView As DataGridView)
        Throw New NotImplementedException
    End Sub

    Private Sub dgv1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgv1.CellMouseClick


       

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim fuelTotal As Double = 0.0
        Dim travelTotal As Double = 0.0
        Dim loadedTotal As Double = 0.0
        Dim purchasedTotal As Double = 0.0

        For i As Integer = dgv1.CurrentCell.RowIndex + 1 To dgv1.Rows.Count - 1

            fuelTotal += Convert.ToDouble(dgv1.Rows(i).Cells(11).Value)
            travelTotal += Convert.ToDouble(dgv1.Rows(i).Cells(12).Value)
            loadedTotal += Convert.ToDouble(dgv1.Rows(i).Cells(13).Value)
            purchasedTotal += Convert.ToDouble(dgv1.Rows(i).Cells(14).Value)

        Next

        fuel.Text = fuelTotal.ToString()
        travel.Text = travelTotal.ToString()
        loaded.Text = loadedTotal.ToString()
        purchased.Text = purchasedTotal.ToString()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        Dim sql As String
        conn.Close()

        Try
            conn.Open()
            dgv1.DataSource.Clear()
            dgv1.Refresh()
            sql = "Select * from t1 where date_of_travel like ' " & TextBox1.Text & " % ' "
            With Command
                .Connection = conn
                .CommandText = sql
            End With
            daa.SelectCommand = Command

            dgv1.Refresh()
            daa.Fill(dt)
            dgv1.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class