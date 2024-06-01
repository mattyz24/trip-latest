Imports mysql.data.mysqlclient
Public Class Form2
    Dim driver As String
    Dim vehicle As String
    Private Const V As String = " "
    Dim conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=example")
    Dim Command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim da As DataSet
    Dim Query As String
    Dim itemcoll(100) As String

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dt1.MinDate = Date.Today
        dt2.MinDate = Date.Today

       
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Try
            conn.Open()
            Query = " INSERT INTO `t1` (`date_of_request`,`date_of_travel`,`place_of_travel`,`office`,`purpose`,`driver`,`plate_number`,`time`,`dispatcher`) VALUES ('" & dt1.Text & "','" & dt2.Text & "','" & tb3.Text & "','" & tb2.Text & "','" & tb4.Text & "','" & driver & "','" & vehicle & "','" & tb7.Text & "','" & tb6.Text & "')"
            Command = New MySqlCommand(Query, conn)
            reader = Command.ExecuteReader

            MessageBox.Show("Request Ticket Save")
            conn.Close()
            

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            driver = "Marlon B. Martin"

        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            driver = "Jerome C. Flores"

        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            driver = "Dominador L. Espiritu Jr."

        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            driver = "Jerome P. Ualat"

        End If
    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton8.CheckedChanged
        If RadioButton8.Checked Then
            vehicle = "VAN(1312-0000441415)"

        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton7.Checked Then
            vehicle = "VAN(1312-0000441416)"

        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            vehicle = "BUS(SKY-667)"

        End If
    End Sub
End Class