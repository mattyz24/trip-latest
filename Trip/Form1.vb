Public Class Form1


    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        With Form3
            .TopLevel = False
            Panel3.Controls.Add(Form3)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        With Form2
            .TopLevel = False
            Panel3.Controls.Add(Form2)
            .BringToFront()
            .Show()
        End With

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        With Form4
            .TopLevel = False
            Panel3.Controls.Add(Form4)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        With Form6
            .TopLevel = False
            Panel3.Controls.Add(Form6)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        With Form5
            .TopLevel = False
            Panel3.Controls.Add(Form5)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        With Form7
            .TopLevel = False
            Panel3.Controls.Add(Form7)
            .BringToFront()
            .Show()
        End With
    End Sub

  
    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub
End Class
