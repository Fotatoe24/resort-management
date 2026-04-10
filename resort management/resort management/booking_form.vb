Imports System.Data
Imports System.Data.OleDb

Public Class booking_form
    Public SelectedRoomID As String
    Public RoomNumber As String
    Public guestsID As String
    Public RoomID As String
    Public RoomName As String
    Public RoomType As String
    Public Classification As String
    Public Price As Decimal

    Public Property IsCheckIn As Boolean = False
    Public Property IsReservation As Boolean = False
    Private DriverUnitPrice As Decimal
    Private ExtraMatUnitPrice As Decimal


    Public Property BookingID As String
    Private IsLoadingReservation As Boolean = False
    Public Property IsFromReservation As Boolean = False

    Private Sub booking_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsCheckIn Then
            ' Disable editing of room selection, guest info, etc.
            cboGuest.Enabled = False
            btnNew.Enabled = False
            rbDownPayment.Enabled = False
            rbFullPayment.Enabled = False
            dtCheckIn.Enabled = False
            dtCheckOut.Enabled = False
            txtDownpayment.Enabled = False
            ' Load reserved guest info for check-in

            btnCheckIN.Text = "Check-In Guest"
            btnReserve.Enabled = False
            btnNoshow.Visible = True
            LoadReservationDetails()
        Else
            btnNew.Enabled = True
            btnNoshow.Visible = False
            rbFullPayment.Checked = True
            txtDownpayment.Enabled = False
            lblGuestID.Text = guestsID
            lblBookingID.Text = BookingID
            lblRoomNo.Text = RoomNumber
            lblRoomType.Text = RoomType
            lblRoomName.Text = RoomName
            lblRoomClass.Text = Classification
            lblPrice.Text = "₱" & Price.ToString("N2")
            dtCheckIn.Value = Date.Now
            dtCheckOut.Value = Date.Now.AddDays(1)
            LoadGuests()
        End If


        dtCheckIn.MinDate = Date.Now
        dtCheckOut.MinDate = Date.Now.AddDays(1)
        DriverUnitPrice = GetAmenityPrice("drivers Room")
        ExtraMatUnitPrice = GetAmenityPrice("extra Mattress")


        If Not IsReservation Then
            UpdateTotals()
        End If
    End Sub
    Public Sub LoadReservationDetails()
        IsLoadingReservation = True

        txtDownpayment.Enabled = False
        If String.IsNullOrEmpty(BookingID) Then Exit Sub
        If db.State = ConnectionState.Closed Then db.Open()
        Dim sql As String =
        "SELECT " &
        "b.bookingID, b.guestID, b.RoomID, " &
        "b.[check-in], b.[check-out], " &
        "b.TotalAmount, b.paymentType, b.amountPaid, b.balance, " &
        "b.[drivers room], b.[extra mattress], " &
        "g.guestName, g.guestContact, g.guestAddress, " &
        "r.roomNumber, r.Type, r.classification, r.Price " &
        "FROM (Bookings b " &
        "INNER JOIN Guests g ON b.guestID = g.guestID) " &
        "INNER JOIN Rooms r ON b.RoomID = r.RoomID " &
        "WHERE b.bookingID = ?"

        Using cmd As New OleDbCommand(sql, db)
            cmd.Parameters.AddWithValue("?", BookingID)

            Using reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then

                    '================ ROOM INFO ================
                    RoomID = reader("RoomID").ToString()
                    RoomNumber = reader("roomNumber").ToString()
                    RoomType = reader("Type").ToString()
                    Classification = reader("classification").ToString()
                    Price = CDec(reader("Price"))

                    lblRoomNo.Text = RoomNumber
                    lblRoomName.Text = RoomNumber
                    lblRoomType.Text = RoomType
                    lblRoomClass.Text = Classification
                    lblPrice.Text = "₱" & Price.ToString("N2")

                    '================ GUEST INFO ================
                    cboGuest.Text = reader("guestName").ToString()
                    txtGuestContact.Text = reader("guestContact").ToString()
                    txtGuestAddress.Text = reader("guestAddress").ToString()

                    '================ DATES ====================
                    dtCheckIn.Value = CDate(reader("check-in"))
                    dtCheckOut.Value = CDate(reader("check-out"))

                    '================ PAYMENT ==================
                    If reader("paymentType").ToString().ToUpper() = "FULL" Then
                        rbFullPayment.Checked = True
                    Else
                        rbDownPayment.Checked = True
                        txtDownpayment.Enabled = False
                    End If

                    Dim nights As Integer = (dtCheckOut.Value - dtCheckIn.Value).Days
                    If nights < 1 Then nights = 1
                    lblNights.Text = nights.ToString()

                    txtDownpayment.Text = CDec(reader("amountPaid")).ToString("N2")
                    lblBalance.Text = "₱" & CDec(reader("balance")).ToString("N2")
                    lblTotal.Text = "₱" & CDec(reader("TotalAmount")).ToString("N2")
                    '================ EXTRAS ===================
                    nudDriversRoom.Value =
                    If(IsDBNull(reader("drivers room")), 0, CInt(reader("drivers room")))

                    nudExtraMat.Value =
                    If(IsDBNull(reader("extra mattress")), 0, CInt(reader("extra mattress")))

                    CheckBox1.Enabled = True
                    CheckBox2.Enabled = True
                    nudDriversRoom.Enabled = CheckBox1.Checked
                    nudExtraMat.Enabled = CheckBox2.Checked

                    IsLoadingReservation = False


                End If
            End Using
        End Using
    End Sub

    Private Sub dtCheckIn_ValueChanged(sender As Object, e As EventArgs) Handles dtCheckIn.ValueChanged
        If IsLoadingReservation Then Exit Sub
        UpdateTotals()
    End Sub

    Private Sub dtCheckOut_ValueChanged(sender As Object, e As EventArgs) Handles dtCheckOut.ValueChanged
        If IsLoadingReservation Then Exit Sub
        UpdateTotals()
    End Sub

    Public Sub UpdateTotals()
        If IsLoadingReservation Then Exit Sub

        Dim nights As Integer = (dtCheckOut.Value - dtCheckIn.Value).Days
        If nights < 1 Then nights = 1
        lblNights.Text = nights.ToString()

        Dim grandTotal As Decimal = CalculateGrandTotal()
        lblTotal.Text = "₱" & grandTotal.ToString("N2")

        ' Update balance for downpayment
        UpdateBalance()
    End Sub


    Private Sub rbFullPayment_CheckedChanged(sender As Object, e As EventArgs) Handles rbFullPayment.CheckedChanged

        txtDownpayment.Enabled = False
        txtDownpayment.Text = ""
        lblBalance.Text = "₱0.00"

    End Sub

    Private Sub rbDownPayment_CheckedChanged(sender As Object, e As EventArgs) Handles rbDownPayment.CheckedChanged

        txtDownpayment.Enabled = True


        ' Recalculate balance dynamically
        UpdateBalance()
    End Sub

    Private Sub txtDownPayment_TextChanged(sender As Object, e As EventArgs) Handles txtDownpayment.TextChanged
        UpdateBalance()
    End Sub
    Sub UpdateBalance()
        Dim grandTotal As Decimal = CalculateGrandTotal()
        Dim down As Decimal = 0
        Decimal.TryParse(txtDownpayment.Text, down)

        If rbDownPayment.Checked Then
            ' For reservations, just calculate balance but do NOT overwrite user input
            lblBalance.Text = "₱" & (grandTotal - down).ToString("N2")
        Else
            ' Full payment
            txtDownpayment.Text = ""
            lblBalance.Text = "₱0.00"
        End If
    End Sub


    Private Sub LoadGuests()
        If db.State = ConnectionState.Closed Then db.Open()

        cboGuest.Items.Clear()

        Dim cmd As New OleDbCommand("SELECT guestID, guestName, guestContact, guestAddress FROM Guests ORDER BY guestName", db)
        Dim reader As OleDbDataReader = cmd.ExecuteReader()

        While reader.Read()
            ' Use a simple class to store both ID and Name
            Dim item As New ComboItem With {
            .Text = reader("guestName").ToString(),
            .Value = reader("guestID").ToString(),
            .Contact = reader("guestContact").ToString(),
            .Address = reader("guestAddress").ToString()
        }
            cboGuest.Items.Add(item)
        End While
        reader.Close()
    End Sub

    ' Class to store guest info in ComboBox
    Public Class ComboItem
        Public Property Text As String
        Public Property Value As String
        Public Property Contact As String
        Public Property Address As String
        Public Overrides Function ToString() As String
            Return Text
        End Function
    End Class


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        ' Only cancel if this is a reservation
        If IsCheckIn AndAlso Not String.IsNullOrEmpty(BookingID) Then

            Dim result = MessageBox.Show(
            "Are you sure you want to cancel this reservation?",
            "Cancel Reservation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

            If result = DialogResult.No Then Exit Sub

            Try
                If db.State = ConnectionState.Closed Then db.Open()

                ' Cancel booking
                Using cmdBooking As New OleDbCommand(
                "UPDATE Bookings SET status='CANCELLED', RoomID='' WHERE bookingID=?", db)
                    cmdBooking.Parameters.AddWithValue("@p1", BookingID)
                    cmdBooking.ExecuteNonQuery()
                End Using

                ' Set room back to AVAILABLE
                Using cmdRoom As New OleDbCommand(
                "UPDATE Rooms SET Status='AVAILABLE' WHERE RoomID=?", db)
                    cmdRoom.Parameters.AddWithValue("@p1", SelectedRoomID)
                    cmdRoom.ExecuteNonQuery()
                End Using

                'MessageBox.Show("Reservation cancelled successfully.", "Cancelled")
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error cancelling reservation: " & ex.Message)
            Finally
                If db.State = ConnectionState.Open Then db.Close()
            End Try

        Else
            ' Not a reservation → just close
            Me.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCheckIN.Click
        If cboGuest.Text = "" Then
            MessageBox.Show("Guest Name Required")
            Exit Sub
        End If

        Dim grandTotal As Decimal = CalculateGrandTotal() ' includes room + driver + mattress
        Dim paid As Decimal

        Dim payType As String

        If rbFullPayment.Checked Then
            payType = "FULL"
            paid = grandTotal
        Else
            payType = "DOWN"
            Decimal.TryParse(txtDownpayment.Text, paid)
        End If

        If paid < grandTotal * 0.5D Then
            MessageBox.Show("Downpayment for reservation must be at least 50% of the total amount.", "Invalid Downpayment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtDownpayment.Text = ""
            txtDownpayment.Focus()
            Exit Sub
        End If


        Try
            If db.State = ConnectionState.Closed Then db.Open()

            If IsCheckIn Then
                ' Check-in from reservation
                CheckInReservedBooking(paid, payType)
            Else
                ' Normal walk-in check-in
                InsertNewBooking(paid, payType)
            End If

            'MessageBox.Show("Checked-in Successfully", "Success")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub


    Sub CheckInReservedBooking(paid As Decimal, payType As String)


        Try


            ' Enforce minimum 50% downpayment for reservations
            Dim grandTotal As Decimal = CalculateGrandTotal()


            If db.State = ConnectionState.Closed Then db.Open()
            Using cmd As New OleDbCommand(
            "UPDATE Bookings SET 
            [check-in]=?, 
            [check-out]=?,
            TotalAmount=?,
            PaymentType=?,
            amountPaid=?,
            balance=?,
            status=?,
            [drivers room]=?, 
            [extra mattress]=?,
            TotalRprice=?
         WHERE bookingID=?", db)

                cmd.Parameters.AddWithValue("@p1", dtCheckIn.Value)
                cmd.Parameters.AddWithValue("@p2", dtCheckOut.Value)
                cmd.Parameters.AddWithValue("@p3", grandTotal)
                cmd.Parameters.AddWithValue("@p4", payType)
                cmd.Parameters.AddWithValue("@p5", paid)
                cmd.Parameters.AddWithValue("@p6", grandTotal - paid)
                cmd.Parameters.AddWithValue("@p7", "OCCUPIED")
                cmd.Parameters.AddWithValue("@p8", nudDriversRoom.Value)
                cmd.Parameters.AddWithValue("@p9", nudExtraMat.Value)
                cmd.Parameters.AddWithValue("@p10", grandTotal)
                cmd.Parameters.AddWithValue("@p11", BookingID)

                cmd.ExecuteNonQuery()
            End Using

            ' Update room status
            Using cmdRoom As New OleDbCommand(
            "UPDATE Rooms SET Status='OCCUPIED' WHERE RoomID=?", db)
                cmdRoom.Parameters.AddWithValue("@p1", SelectedRoomID)
                cmdRoom.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error during check-in: " & ex.ToString)
        Finally

        End Try

    End Sub




    Sub InsertNewBooking(paid As Decimal, payType As String)

        Dim newCheckIn As Date = dtCheckIn.Value
        Dim newCheckOut As Date = dtCheckOut.Value

        ' 🚨 PREVENT DOUBLE BOOKING
        Dim sqlCheck As String =
        "SELECT COUNT(*) FROM Bookings " &
        "WHERE RoomID = ? " &
        "AND ? < [check-out] " &
        "AND ? > [check-in] " &
        "AND status <> 'CANCELLED'"

        Using cmdCheck As New OleDbCommand(sqlCheck, db)
            cmdCheck.Parameters.AddWithValue("@p1", SelectedRoomID)
            cmdCheck.Parameters.AddWithValue("@p2", newCheckOut)
            cmdCheck.Parameters.AddWithValue("@p3", newCheckIn)

            Dim conflict As Integer = CInt(cmdCheck.ExecuteScalar())

            If conflict > 0 Then
                MessageBox.Show("Room already booked for selected dates.",
                            "Double Booking Prevented",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using

        Dim grandTotal As Decimal = CalculateGrandTotal()
        ' Insert Guest
        If db.State = ConnectionState.Closed Then db.Open()
        '  Using cmdGuest As New OleDbCommand(
        '  "INSERT INTO Guests (guestID, guestName, guestContact, guestAddress) VALUES (?,?,?,?)", db)
        '      cmdGuest.Parameters.AddWithValue("@p1", guestsID)
        '      cmdGuest.Parameters.AddWithValue("@p2", cboGuest.Text)
        'cmdGuest.Parameters.AddWithValue("@p3", txtGuestContact.Text)
        'cmdGuest.Parameters.AddWithValue("@p4", txtGuestAddress.Text)
        'cmdGuest.ExecuteNonQuery()
        ' End Using

        ' Insert Booking
        Using cmdBooking As New OleDbCommand(
        "INSERT INTO Bookings 
         (bookingID, guestID, RoomID, [check-in], [check-out],
          TotalAmount, PaymentType, amountPaid, balance, status, roomUsed, [drivers room], [extra mattress],TotalRprice)
         VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?)", db)

            cmdBooking.Parameters.AddWithValue("@p1", BookingID)
            cmdBooking.Parameters.AddWithValue("@p2", guestsID)
            cmdBooking.Parameters.AddWithValue("@p3", SelectedRoomID)
            cmdBooking.Parameters.AddWithValue("@p4", dtCheckIn.Value)
            cmdBooking.Parameters.AddWithValue("@p5", dtCheckOut.Value)
            cmdBooking.Parameters.AddWithValue("@p6", grandTotal)
            cmdBooking.Parameters.AddWithValue("@p7", payType)
            cmdBooking.Parameters.AddWithValue("@p8", paid)
            cmdBooking.Parameters.AddWithValue("@p9", grandTotal - paid)
            cmdBooking.Parameters.AddWithValue("@p10", "OCCUPIED")
            cmdBooking.Parameters.AddWithValue("@p11", SelectedRoomID)
            cmdBooking.Parameters.AddWithValue("@p12", nudDriversRoom.Value)
            cmdBooking.Parameters.AddWithValue("@p13", nudExtraMat.Value)
            cmdBooking.Parameters.AddWithValue("@p14", grandTotal)
            cmdBooking.ExecuteNonQuery()
        End Using

        ' Update room status
        Using cmdRoom As New OleDbCommand(
        "UPDATE Rooms SET Status='OCCUPIED' WHERE RoomID=?", db)
            cmdRoom.Parameters.AddWithValue("@p1", SelectedRoomID)
            cmdRoom.ExecuteNonQuery()
        End Using
    End Sub
    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click
        If db.State = ConnectionState.Closed Then db.Open()
        Dim newCheckIn As Date = dtCheckIn.Value
        Dim newCheckOut As Date = dtCheckOut.Value

        ' 🚨 PREVENT DOUBLE BOOKING
        Dim sqlCheck As String =
        "SELECT COUNT(*) FROM Bookings " &
        "WHERE RoomID = ? " &
        "AND ? < [check-out] " &
        "AND ? > [check-in] " &
        "AND status <> 'CANCELLED'"

        Using cmdCheck As New OleDbCommand(sqlCheck, db)
            cmdCheck.Parameters.AddWithValue("@p1", SelectedRoomID)
            cmdCheck.Parameters.AddWithValue("@p2", newCheckOut)
            cmdCheck.Parameters.AddWithValue("@p3", newCheckIn)

            Dim conflict As Integer = CInt(cmdCheck.ExecuteScalar())

            If conflict > 0 Then
                MessageBox.Show("Room already booked for selected dates.",
                            "Double Booking Prevented",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
                Exit Sub
            End If
        End Using

        If db.State = ConnectionState.Closed Then db.Open()

        If cboGuest.Text = "" Then
            MessageBox.Show("Guest Name Required", "Oops")
            Exit Sub
        End If

        Dim grandTotal As Decimal = CalculateGrandTotal() ' includes room + driver + mattress
        Dim paid As Decimal
        Dim payType As String

        ' Determine payment type
        If rbFullPayment.Checked Then
            payType = "FULL"
            paid = grandTotal
            txtDownpayment.Text = ""
        Else
            payType = "DOWN"
            Decimal.TryParse(txtDownpayment.Text, paid)

            ' Enforce minimum 50% downpayment
            If paid < grandTotal * 0.5D Then
                MessageBox.Show("Downpayment for reservation must be at least 50% of the total amount. Please enter a valid amount.", "Invalid Downpayment", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtDownpayment.Text = ""
                txtDownpayment.Focus()
                Exit Sub
            End If
        End If

        Try
            If db.State = ConnectionState.Closed Then db.Open()

            ' --- Insert Guest ---
            ' Using cmdGuest As New OleDbCommand(
            ' "INSERT INTO Guests (guestID, guestName, guestContact, guestAddress) VALUES (?,?,?,?)", db)

            'cmdGuest.Parameters.AddWithValue("@p1", guestsID)
            ' cmdGuest.Parameters.AddWithValue("@p2", cboGuest.Text)
            '  cmdGuest.Parameters.AddWithValue("@p3", txtGuestContact.Text)
            '  cmdGuest.Parameters.AddWithValue("@p4", txtGuestAddress.Text)
            'cmdGuest.ExecuteNonQuery()
            ' End Using

            ' --- Insert Booking as RESERVED ---
            Using cmdBooking As New OleDbCommand(
            "INSERT INTO Bookings
             (bookingID, guestID, RoomID, [check-in], [check-out],
              TotalAmount, PaymentType, amountPaid, balance, status, roomUsed, [drivers room], [extra mattress], TotalRprice)
             VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?)", db)

                cmdBooking.Parameters.AddWithValue("@p1", BookingID)
                cmdBooking.Parameters.AddWithValue("@p2", guestsID)
                cmdBooking.Parameters.AddWithValue("@p3", SelectedRoomID)
                cmdBooking.Parameters.AddWithValue("@p4", dtCheckIn.Value)
                cmdBooking.Parameters.AddWithValue("@p5", dtCheckOut.Value)
                cmdBooking.Parameters.AddWithValue("@p6", grandTotal)
                cmdBooking.Parameters.AddWithValue("@p7", payType)
                cmdBooking.Parameters.AddWithValue("@p8", paid)
                cmdBooking.Parameters.AddWithValue("@p9", grandTotal - paid)
                cmdBooking.Parameters.AddWithValue("@p10", "RESERVED")
                cmdBooking.Parameters.AddWithValue("@p11", SelectedRoomID)
                cmdBooking.Parameters.AddWithValue("@p12", nudDriversRoom.Value)
                cmdBooking.Parameters.AddWithValue("@p13", nudExtraMat.Value)
                cmdBooking.Parameters.AddWithValue("@p14", grandTotal)

                cmdBooking.ExecuteNonQuery()
            End Using

            ' --- Update Room Status ---
            Using cmdRoom As New OleDbCommand(
            "UPDATE Rooms SET Status='RESERVED' WHERE RoomID=?", db)
                cmdRoom.Parameters.AddWithValue("@p1", SelectedRoomID)
                cmdRoom.ExecuteNonQuery()
            End Using

            MessageBox.Show("Room Reserved Successfully!", "Reservation")
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        nudDriversRoom.Enabled = CheckBox1.Checked

        If Not CheckBox1.Checked Then
            nudDriversRoom.Value = 0
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        nudExtraMat.Enabled = CheckBox2.Checked

        If Not CheckBox2.Checked Then
            nudExtraMat.Value = 0
        End If
    End Sub

    Private Sub nudDriversRoom_ValueChanged(sender As Object, e As EventArgs) Handles nudDriversRoom.ValueChanged
        If IsLoadingReservation Then Exit Sub
        UpdateTotals()
    End Sub

    Private Sub nudExtraMat_ValueChanged(sender As Object, e As EventArgs) Handles nudExtraMat.ValueChanged
        If IsLoadingReservation Then Exit Sub
        UpdateTotals()
    End Sub

    Private Function GetAmenityPrice(amenityName As String) As Decimal
        Dim price As Decimal = 0
        Try
            If db.State = ConnectionState.Closed Then db.Open()
            Using cmd As New OleDbCommand(
                "SELECT price FROM ammenities WHERE classification=?", db)
                cmd.Parameters.AddWithValue("@p1", amenityName)
                Dim result = cmd.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    price = CDec(result)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading amenity price: " & ex.Message)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
        Return price
    End Function

    Private Function CalculateGrandTotal() As Decimal

        ' Calculate number of nights
        Dim nights As Integer = (dtCheckOut.Value - dtCheckIn.Value).Days
        If nights < 1 Then nights = 1

        ' Base room total
        Dim roomTotal As Decimal = Price * nights

        ' Drivers Room total
        Dim driversTotal As Decimal = 0
        If nudDriversRoom.Value > 0 Then
            driversTotal = DriverUnitPrice * nudDriversRoom.Value * nights
        End If

        ' Extra Mattress total
        Dim extraMatTotal As Decimal = 0
        If nudExtraMat.Value > 0 Then
            extraMatTotal = ExtraMatUnitPrice * nudExtraMat.Value * nights
        End If

        Return roomTotal + driversTotal + extraMatTotal

    End Function
    Private Sub cboGuest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboGuest.SelectedIndexChanged
        If cboGuest.SelectedItem Is Nothing Then Exit Sub
        Dim selectedGuest As ComboItem = DirectCast(cboGuest.SelectedItem, ComboItem)

        guestsID = selectedGuest.Value ' store guestID for reservation

        lblGuestID.Text = guestsID
        txtGuestContact.Text = selectedGuest.Contact
        txtGuestAddress.Text = selectedGuest.Address

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        guest_form.ShowDialog()
        LoadGuests()
    End Sub

    Private Sub btnNoshow_Click(sender As Object, e As EventArgs) Handles btnNoshow.Click
        Dim result = MessageBox.Show(
      "Mark this reservation as NO SHOW?",
      "No Show",
      MessageBoxButtons.YesNo,
      MessageBoxIcon.Question)

        If result = DialogResult.No Then Exit Sub

        Try
            If db.State = ConnectionState.Closed Then db.Open()

            ' Update reservation status
            Using cmd As New OleDbCommand(
            "UPDATE Bookings SET status='NO SHOW', RoomID = '' WHERE bookingID=?", db)

                cmd.Parameters.AddWithValue("@p1", BookingID)
                cmd.ExecuteNonQuery()

            End Using

            ' Make room available again
            Using cmdRoom As New OleDbCommand(
            "UPDATE Rooms SET Status='AVAILABLE' WHERE RoomID=?", db)

                cmdRoom.Parameters.AddWithValue("@p1", SelectedRoomID)
                cmdRoom.ExecuteNonQuery()

            End Using

            MessageBox.Show("Reservation marked as NO SHOW.", "No Show")

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class