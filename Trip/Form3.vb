Imports MySql.Data.MySqlClient
Public Class Form3
    Private Const V As String = " "
    Dim conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=example")
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim da As DataSet
    Dim Query As String
    Dim itemcoll(100) As String

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim str As String = "Data source=localhost; user id=root; password=; database=example"
        Dim con As New MySqlConnection(str)
        Dim comm As String = "select date_of_request as 'date of request', date_of_travel as 'date of travel',place_of_travel as 'place of travel', office as 'office', purpose as 'purpose', driver as 'driver', plate_number as 'plate number',time as 'time', dispatcher as 'dispatcher' from t1"
        Dim adapt As New MySqlDataAdapter(comm, con)
        Dim ds As New DataSet()

        adapt.Fill(ds, "INFO")
        dgv1.DataSource = ds.Tables(0)

        Dim box As New DataGridViewCheckBoxColumn
        box.Width = 50
        box.Name = "checkbox"
        box.HeaderText = "Check"
        dgv1.Columns.Insert(0, box)


        dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
    End Sub
   
    Private Sub Cancel_Click(sender As System.Object, e As System.EventArgs) Handles Cancel.Click
        Dim dt1 As New DataTable

        dt1.Columns.Add("date of request", Type.GetType("System.String"))
        dt1.Columns.Add("date of travel", Type.GetType("System.String"))
        dt1.Columns.Add("place of travel", Type.GetType("System.String"))
        dt1.Columns.Add("office", Type.GetType("System.String"))
        dt1.Columns.Add("purpose", Type.GetType("System.String"))
        dt1.Columns.Add("driver", Type.GetType("System.String"))
        dt1.Columns.Add("plate number", Type.GetType("System.String"))
        dt1.Columns.Add("time", Type.GetType("System.String"))
        dt1.Columns.Add("dispatcher", Type.GetType("System.String"))

        For Each row As DataGridViewRow In dgv1.Rows
            Dim sel As Boolean = Convert.ToBoolean(row.Cells("checkbox").Value)
            If sel Then
                dt1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)

            End If
        Next
        Form4.dgv2.DataSource = dt1

    End Sub

    Private Sub Approved_Click(sender As System.Object, e As System.EventArgs) Handles Approved.Click
        Dim dt1 As New DataTable

        dt1.Columns.Add("date of request", Type.GetType("System.String"))
        dt1.Columns.Add("date of travel", Type.GetType("System.String"))
        dt1.Columns.Add("place of travel", Type.GetType("System.String"))
        dt1.Columns.Add("office", Type.GetType("System.String"))
        dt1.Columns.Add("purpose", Type.GetType("System.String"))
        dt1.Columns.Add("driver", Type.GetType("System.String"))
        dt1.Columns.Add("plate number", Type.GetType("System.String"))
        dt1.Columns.Add("time", Type.GetType("System.String"))
        dt1.Columns.Add("dispatcher", Type.GetType("System.String"))

        For Each row As DataGridViewRow In dgv1.Rows
            Dim sel As Boolean = Convert.ToBoolean(row.Cells("checkbox").Value)
            If sel Then
                dt1.Rows.Add(row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)

            End If
        Next
        Form6.dgv1.DataSource = dt1
    End Sub
End Class