Public Class during_stay

    Public BookingID As String
    Public RoomID As String
    Public guestID As String
    Public dtCheckOut As Date
    Public dtCheckin As Date
    Public Roomprice As Integer
    Public amountpaid As Decimal

    Private Sub during_stay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb_booking()
        opendb_guests()
        opendb_ammenities()
        opendb()
        Me.KeyPreview = True   ' <-- important
        Me.Focus()
        loadBookinData()
    End Sub

    Private Sub during_stay_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Exit?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                ' Me.Close()
            End If
        End If
    End Sub


    Private Sub loadBookinData()
        Try
            If db4.State = ConnectionState.Closed Then db4.Open()
            tblbooking = New OleDb.OleDbDataAdapter("SELECT * FROM Bookings WHERE [bookingID ] Like '%" & BookingID & "%'", db4)
            dbds4 = New DataSet
            tblbooking.Fill(dbds4, "Bookings")

            If dbds4.Tables("Bookings").Rows.Count > 0 Then

                Dim row As DataRow = dbds4.Tables("Bookings").Rows(0)
                guestID = If(IsDBNull(row("guestID")) OrElse row("guestID").ToString().Trim() = "", "N/A", row("guestID").ToString())
                nudDriversRoom.Value = If(IsDBNull(row("drivers room")) OrElse row("drivers room").ToString().Trim() = "", "N/A", row("drivers room").ToString())
                nudExtraMat.Value = If(IsDBNull(row("extra mattress")) OrElse row("extra mattress").ToString().Trim() = "", "N/A", row("extra mattress").ToString())
                DateTimePicker1.Value = If(IsDBNull(row("check-out")) OrElse row("check-out").ToString().Trim() = "", "N/A", row("check-out").ToString())
                dtCheckOut = If(IsDBNull(row("check-out")) OrElse row("check-out").ToString().Trim() = "", "N/A", row("check-out").ToString())
                dtCheckin = If(IsDBNull(row("check-in")) OrElse row("check-in").ToString().Trim() = "", "N/A", row("check-in").ToString())
                amountpaid = If(IsDBNull(row("amountPaid")) OrElse row("amountPaid").ToString().Trim() = "", "N/A", row("amountPaid").ToString())
            End If



            If db5.State = ConnectionState.Closed Then db5.Open()
            tblguests = New OleDb.OleDbDataAdapter("SELECT * FROM Guests WHERE [guestID ] Like '%" & guestID & "%'", db5)
            dbds5 = New DataSet
            tblguests.Fill(dbds5, "Guests")

            If dbds5.Tables("Guests").Rows.Count > 0 Then

                Dim row As DataRow = dbds5.Tables("Guests").Rows(0)

                txtGname.Text = If(IsDBNull(row("guestName")) OrElse row("guestName").ToString().Trim() = "", "N/A", row("guestName").ToString())
                txtGcontact.Text = If(IsDBNull(row("guestContact")) OrElse row("guestContact").ToString().Trim() = "", "N/A", row("guestContact").ToString())
                txtGaddress.Text = If(IsDBNull(row("guestAddress")) OrElse row("guestAddress").ToString().Trim() = "", "N/A", row("guestAddress").ToString())
            End If


            If db.State = ConnectionState.Closed Then db.Open()
            Rooms = New OleDb.OleDbDataAdapter("SELECT * FROM Rooms WHERE [RoomID ] Like '%" & RoomID & "%'", db)
            dbds = New DataSet
            Rooms.Fill(dbds, "Rooms")

            If dbds.Tables("Rooms").Rows.Count > 0 Then
                Dim row As DataRow = dbds.Tables("Rooms").Rows(0)

                lblRoomNo.Text = If(IsDBNull(row("roomNumber")) OrElse row("roomNumber").ToString().Trim() = "", "N/A", row("roomNumber").ToString())
                lblRoomType.Text = If(IsDBNull(row("Type")) OrElse row("Type").ToString().Trim() = "", "N/A", row("Type").ToString())
                lblRoomClass.Text = If(IsDBNull(row("Classification")) OrElse row("Classification").ToString().Trim() = "", "N/A", row("Classification").ToString())
                Roomprice = If(IsDBNull(row("Price")) OrElse row("Price").ToString().Trim() = "", "N/A", row("Price").ToString())
                lblPrice.Text = "₱ " & Roomprice
            End If

            lblAmountpd.Text = "₱ " & amountpaid.ToString("N2")

            lblaccom.Text = "₱ " & calculateStayPrice().ToString("N2")

            LoadGuestOrders(BookingID)

            lbltotal.Text = "₱ " & calculateGrandTotal().ToString("N2")

            lblbalance.Text = "₱ " & calculatebalance().ToString("N2")


        Catch ex As Exception

        End Try
    End Sub

    Private Sub unlockfields()
        btnsave.Enabled = True
        btnedit.Enabled = False
        btncheckout.Enabled = False

        txtGname.Enabled = True
        txtGcontact.Enabled = True
        txtGaddress.Enabled = True

        DateTimePicker1.Enabled = True

        nudExtraMat.Enabled = True
        nudDriversRoom.Enabled = True
    End Sub

    Private Sub lockfields()
        btnsave.Enabled = False
        btnedit.Enabled = True
        btncheckout.Enabled = True

        txtGname.Enabled = False
        txtGcontact.Enabled = False
        txtGaddress.Enabled = False

        DateTimePicker1.Enabled = False

        nudExtraMat.Enabled = False
        nudDriversRoom.Enabled = False
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click

        unlockfields()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        lockfields()
        If MsgBox("Do you want to save the changes you made to its database?", MsgBoxStyle.DefaultButton1 + vbYesNo, "updating...") = MsgBoxResult.Yes Then
            If db5.State = ConnectionState.Closed Then db5.Open()
            dbcmd = New OleDb.OleDbCommand("UPDATE Guests SET [guestName]= '" & txtGname.Text.Trim & "',[guestContact]= '" & txtGcontact.Text.Trim & "',[guestAddress]= '" & txtGaddress.Text.Trim & "' WHERE [guestID]Like '" & guestID & "'", db5)
            dbcmd.ExecuteNonQuery()

            If db4.State = ConnectionState.Closed Then db4.Open()
            dbcmd = New OleDb.OleDbCommand("UPDATE Bookings SET [check-out]= '" & DateTimePicker1.Value & "',[drivers room]= '" & nudDriversRoom.Value & "',[extra mattress]= '" & nudExtraMat.Value & "' ,[amountPaid]= '" & lblAmountpd.Text.Trim & "' ,[TotalAmount]= '" & lblaccom.Text.Trim & "' ,[balance]= '" & lblbalance.Text.Trim & "'  WHERE [bookingID] Like '" & BookingID & "'", db4)
            dbcmd.ExecuteNonQuery()

            loadBookinData()
            lockfields()
        Else
            loadBookinData()
            lockfields()
        End If

    End Sub

    Private Sub btncheckout_Click(sender As Object, e As EventArgs) Handles btncheckout.Click
        If MsgBox("Are you sure you want to check out this guest?", MsgBoxStyle.YesNo, "Cheking out") = MsgBoxResult.Yes Then
            checkout_form.BookingID = BookingID
            checkout_form.RoomID = RoomID
            If checkout_form.ShowDialog() = DialogResult.OK Then
                Me.Close()
            End If

        End If
    End Sub

    Private Function calculateStayPrice() As Decimal

        Dim bdnights As Integer = (DateTimePicker1.Value - dtCheckin).Days
        If bdnights < 0 Then bdnights = 0

        Dim totalroomprice As Decimal = Roomprice * bdnights

        Dim driversPrice As Decimal = GetAmenityPrice("drivers Room") * nudDriversRoom.Value * bdnights
        Dim extrasmatPrice As Decimal = GetAmenityPrice("extra mattress") * nudExtraMat.Value * bdnights

        Return totalroomprice + driversPrice + extrasmatPrice

    End Function

    Private Function calculatebalance() As Decimal

        Dim grandTotal As Decimal = calculateGrandTotal()

        Return grandTotal - amountpaid

    End Function


    Private Function calculateGrandTotal() As Decimal

        Dim stayTotal As Decimal = calculateStayPrice()
        Dim ordersTotal As Decimal = GetOrdersTotal()

        Return stayTotal + ordersTotal

    End Function


    Private Function GetAmenityPrice(amenityName As String) As Decimal
        Dim price As Decimal = 0
        Try
            If db6.State = ConnectionState.Closed Then db6.Open()
            tblextras = New OleDb.OleDbDataAdapter("SELECT price FROM ammenities WHERE [classification] Like '%" & amenityName & "%'", db6)
            dbds6 = New DataSet
            tblextras.Fill(dbds6, "ammenities")

            If dbds6.Tables("ammenities").Rows.Count > 0 Then
                price = dbds6.Tables("ammenities").Rows(0).Item("price")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading amenity price: " & ex.Message)
        Finally
            If db6.State = ConnectionState.Open Then db6.Close()
        End Try
        Return price
    End Function

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        RefreshTotals()
    End Sub

    Private Sub nudDriversRoom_ValueChanged(sender As Object, e As EventArgs) Handles nudDriversRoom.ValueChanged
        RefreshTotals()
    End Sub

    Private Sub nudExtraMat_ValueChanged(sender As Object, e As EventArgs) Handles nudExtraMat.ValueChanged
        RefreshTotals()
    End Sub

    Sub LoadGuestOrders(ByVal bookingID As String)

        Try
            If db.State = ConnectionState.Closed Then
                db.Open()
            End If

            Dim sql As String = "SELECT * FROM guest_orders WHERE bookingID = ?"

            Dim cmd As New OleDb.OleDbCommand(sql, db)
            cmd.Parameters.AddWithValue("?", bookingID)

            tblorders = New OleDb.OleDbDataAdapter(cmd)
            dbds7 = New DataSet()
            tblorders.Fill(dbds7, "guest_orders")

            If dbds7.Tables("guest_orders").Rows.Count > 0 Then
                dvgOrders.DataSource = dbds7.Tables("guest_orders")
                dvgOrders.Columns("Stock ID").Visible = False
                dvgOrders.Columns("bookingID").Visible = False
                dvgOrders.Columns("Cashier Name").Visible = False
            Else
                dvgOrders.DataSource = Nothing
            End If

            lblOrdersTotal.Text = "₱ " & GetOrdersTotal().ToString("N2")
        Catch ex As Exception
            MessageBox.Show("Error loading guest orders: " & ex.Message)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try

    End Sub

    Private Function GetOrdersTotal() As Decimal

        Dim total As Decimal = 0

        Try
            If dbds7 IsNot Nothing AndAlso dbds7.Tables.Contains("guest_orders") Then
                For Each row As DataRow In dbds7.Tables("guest_orders").Rows
                    If Not IsDBNull(row("Total")) Then
                        total += Convert.ToDecimal(row("Total"))
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error computing orders total: " & ex.Message)
        End Try

        Return total

    End Function
    Private Sub RefreshTotals()

        lblaccom.Text = "₱ " & calculateStayPrice().ToString("N2")
        lbltotal.Text = "₱ " & calculateGrandTotal().ToString("N2")
        lblbalance.Text = "₱ " & calculatebalance().ToString("N2")

    End Sub

End Class
