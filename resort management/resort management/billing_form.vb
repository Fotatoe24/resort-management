Public Class billing_form

    Public dtBookings As New DataTable
    Private Sub billing_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        LoadBillingData()
    End Sub


    Private Sub billing_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown


        If e.KeyCode = Keys.Escape Then
            If MsgBox("Would you like to exit?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Closing...") = MsgBoxResult.Yes Then
                main_form.Show()
                Me.Close()
            Else

            End If
            Exit Sub
        End If
    End Sub


    Sub LoadBillingData()

        dtBookings.Clear()
        Dim sql As String =
"SELECT 
    b.bookingID,
    g.guestName,
    r.roomNumber,
    r.roomName,

    b.TotalRprice,
    IIF(SUM(o.Total) IS NULL, 0, SUM(o.Total)) AS FoodTotal,

    (b.TotalRprice + IIF(SUM(o.Total) IS NULL, 0, SUM(o.Total))) AS TotalAmount,
    b.amountPaid,
    ((b.TotalRprice + IIF(SUM(o.Total) IS NULL, 0, SUM(o.Total))) - b.amountPaid) AS Balance,

    b.status,
    b.[check-out]

FROM 
    ((Bookings b
    INNER JOIN guests g ON b.guestID = g.guestID)
    INNER JOIN Rooms r ON b.RoomID = r.RoomID)
    LEFT JOIN guest_orders o ON b.bookingID = o.bookingID

WHERE b.status='OCCUPIED'

GROUP BY 
    b.bookingID, g.guestName, r.roomNumber, r.roomName,
    b.TotalRprice, b.amountPaid, b.status, b.[check-out]"

        Dim da As New OleDb.OleDbDataAdapter(sql, db)
        da.Fill(dtBookings)

        RenderBillingCards()

    End Sub

    Sub RenderBillingCards()

        FlowLayoutPanel1.Controls.Clear()

        For Each row As DataRow In dtBookings.Rows

            ' === Main ticket panel ===
            Dim pnl As New Panel()
            pnl.Width = 400
            pnl.Height = 250
            pnl.BorderStyle = BorderStyle.FixedSingle
            pnl.BackColor = Color.White
            pnl.Padding = New Padding(10)
            pnl.Tag = row("bookingID").ToString
            pnl.Margin = New Padding(10)

            ' === Top Panel: Guest & Room ===
            Dim topPanel As New Panel()
            topPanel.Dock = DockStyle.Top
            topPanel.Height = 50
            Dim status As String = row("status").ToString.ToUpper
            Select Case status
                Case "OCCUPIED" : topPanel.BackColor = Color.LightSkyBlue
                Case "RESERVED" : topPanel.BackColor = Color.Khaki
                Case "CHECKING OUT" : topPanel.BackColor = Color.Orange
                Case "CHECKED-OUT" : topPanel.BackColor = Color.LightGray
                Case Else : topPanel.BackColor = Color.White
            End Select

            Dim lblGuest As New Label()
            lblGuest.Text = row("guestName").ToString
            lblGuest.Font = New Font("Segoe UI", 14, FontStyle.Bold)
            lblGuest.ForeColor = Color.Black
            lblGuest.AutoSize = True
            lblGuest.Location = New Point(10, 10)



            topPanel.Controls.Add(lblGuest)
            'topPanel.Controls.Add(lblRoom)

            ' === Middle Panel: Total, Paid, Balance ===
            Dim midPanel As New Panel()
            midPanel.Dock = DockStyle.Fill
            midPanel.BackColor = Color.White

            Dim lblRoom As New Label()
            lblRoom.Text = row("roomNumber") & " - " & row("roomName")
            lblRoom.Font = New Font("Segoe UI", 12, FontStyle.Regular)
            lblRoom.ForeColor = Color.Black
            lblRoom.AutoSize = True
            lblRoom.Location = New Point(10, 10)

            Dim lblTotal As New Label()
            lblTotal.Text = "Total: ₱" & FormatNumber(row("TotalAmount"), 2)
            lblTotal.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblTotal.AutoSize = True
            lblTotal.Location = New Point(10, 45)

            Dim lblPaid As New Label()
            lblPaid.Text = "Paid: ₱" & FormatNumber(row("amountPaid"), 2)
            lblPaid.Font = New Font("Segoe UI", 12, FontStyle.Regular)
            lblPaid.AutoSize = True
            lblPaid.Location = New Point(10, 80)

            Dim lblBalance As New Label()
            lblBalance.Text = "Balance: ₱" & FormatNumber(row("balance"), 2)
            lblBalance.Font = New Font("Segoe UI", 12, FontStyle.Bold)
            lblBalance.AutoSize = True
            lblBalance.Location = New Point(10, 110)
            lblBalance.ForeColor = If(Val(row("balance")) > 0, Color.DarkRed, Color.Green)

            midPanel.Controls.Add(lblRoom)
            midPanel.Controls.Add(lblTotal)
            midPanel.Controls.Add(lblPaid)
            midPanel.Controls.Add(lblBalance)

            ' === Bottom Panel: Check-out Date ===
            Dim bottomPanel As New Panel()
            bottomPanel.Dock = DockStyle.Bottom
            bottomPanel.Height = 40
            bottomPanel.BackColor = Color.LightGray

            Dim lblCheckout As New Label()
            lblCheckout.Text = "Check-out: " & FormatDateTime(row("check-out"), DateFormat.ShortDate)
            lblCheckout.Font = New Font("Segoe UI", 11, FontStyle.Italic)
            lblCheckout.AutoSize = True
            lblCheckout.ForeColor = Color.DarkBlue
            lblCheckout.Location = New Point(10, 10)

            bottomPanel.Controls.Add(lblCheckout)

            ' === Add sections to main panel ===
            pnl.Controls.Add(midPanel)
            pnl.Controls.Add(bottomPanel)
            pnl.Controls.Add(topPanel)

            topPanel.Tag = pnl.Tag
            midPanel.Tag = pnl.Tag
            bottomPanel.Tag = pnl.Tag
            lblGuest.Tag = pnl.Tag
            lblRoom.Tag = pnl.Tag
            lblTotal.Tag = pnl.Tag
            lblPaid.Tag = pnl.Tag
            lblBalance.Tag = pnl.Tag
            lblCheckout.Tag = pnl.Tag

            ' === Make panel clickable ===
            AddClickHandler(pnl)

            FlowLayoutPanel1.Controls.Add(pnl)

        Next

    End Sub

    Private Sub AddClickHandler(ctrl As Control)
        AddHandler ctrl.Click, AddressOf BillingCard_Click

        ' Apply to all child controls recursively
        For Each c As Control In ctrl.Controls
            AddClickHandler(c)
        Next
    End Sub

    Sub BillingCard_Click(sender As Object, e As EventArgs)

        Dim ctrl As Control = CType(sender, Control)

        ' 🔥 Find control that has a Tag (bookingID)
        While ctrl IsNot Nothing AndAlso ctrl.Tag Is Nothing
            ctrl = ctrl.Parent
        End While

        If ctrl Is Nothing Then
            MessageBox.Show("No Booking ID found!", "Error")
            Exit Sub
        End If

        Dim bookingID As String = CType(sender, Control).Tag.ToString
        MessageBox.Show("Clicked ID: " & bookingID)
        Try
            Dim folio_form As New folio
            folio_form.SelectedBookingID = bookingID
            folio_form.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class