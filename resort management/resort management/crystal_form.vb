Public Class crystal_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case (xbtn)
            Case "Rooms"
                Form1.Show()
                Me.Close()
            Case "stocks"
                '   Stock_form.Show()
             '   Me.Close()
            Case "Cashier"
                '   cashier_form.Show()
             '   Me.Close()
            Case "report"
                '   Report_form.Show()
                '  Me.Close()
        End Select
        xbtn = ""
    End Sub

    Private Sub crystal_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crptView.Refresh()
    End Sub
End Class