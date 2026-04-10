

Imports System.Data
Imports System.Data.OleDb

Public Class Reservation_form
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
    Public ReservationStatus As String = ""

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
            btnReserve.Enabled = False
            lblBookingID.Text = BookingID
            LoadReservationDetails()

        Else
            LoadRoomDetails()
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


        If Not IsReservation Then
            UpdateTotals()
        End If
    End Sub
    Public Sub LoadReservationDetails()

        ' MessageBox.Show("RoomID: " & BookingID)
        IsLoadingReservation = True

        txtDownpayment.Enabled = False
        If String.IsNullOrEmpty(BookingID) Then Exit Sub
        If db.State = ConnectionState.Closed Then db.Open()
        Dim sql As String =
        "SELECT r.reservationID AS RecordID, r.guestID, r.RoomID,
         r.[check-in], r.[check-out],
         r.TotalAmount, r.paymentType, r.amountPaid, r.balance, r.status,
         g.guestName, g.guestContact, g.guestAddress,
         ro.roomNumber, ro.Type, ro.classification, ro.Price, ro.roomName
        FROM (Reservations r
        INNER JOIN Guests g ON r.guestID = g.guestID)
        INNER JOIN Rooms ro ON r.RoomID = ro.RoomID
        WHERE r.reservationID = ?

        UNION ALL

        SELECT b.BookingID AS RecordID, b.guestID, b.RoomID,
         b.[check-in], b.[check-out],
         b.TotalAmount, b.paymentType, b.amountPaid, b.balance, b.status,
         g.guestName, g.guestContact, g.guestAddress,
         ro.roomNumber, ro.Type, ro.classification, ro.Price, ro.roomName
        FROM (Bookings b
        INNER JOIN Guests g ON b.guestID = g.guestID)
        INNER JOIN Rooms ro ON b.RoomID = ro.RoomID
        WHERE b.BookingID = ?"

        Using cmd As New OleDbCommand(sql, db)
            cmd.Parameters.AddWithValue("@p1", BookingID)
            cmd.Parameters.AddWithValue("@p2", BookingID)

            Using reader As OleDbDataReader = cmd.ExecuteReader()
                If reader.Read() Then

                    '================ ROOM INFO ================
                    SelectedRoomID = reader("RoomID").ToString()
                    RoomID = SelectedRoomID
                    RoomNumber = reader("roomNumber").ToString()
                    RoomName = reader("roomName").ToString()
                    RoomType = reader("Type").ToString()
                    Classification = reader("classification").ToString()
                    Price = CDec(reader("Price"))
                    ReservationStatus = reader("status").ToString().ToUpper()


                    lblRoomNo.Text = RoomNumber
                    lblRoomName.Text = RoomName
                    lblRoomType.Text = RoomType
                    lblRoomClass.Text = Classification
                    lblPrice.Text = "₱" & Price.ToString("N2")


                    '================ GUEST INFO ================
                    cboGuest.Text = reader("guestName").ToString()
                    txtGuestContact.Text = reader("guestContact").ToString()
                    txtGuestAddress.Text = reader("guestAddress").ToString()
                    guestsID = reader("guestID").ToString()

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
                    lblGuestID.Text = guestsID
                    '================ EXTRAS ===================

                    IsLoadingReservation = False


                End If
            End Using
        End Using
    End Sub

    Private Sub LoadRoomDetails()

        ' MessageBox.Show("RoomID: " & SelectedRoomID)
        If String.IsNullOrEmpty(SelectedRoomID) Then Exit Sub

        If db.State = ConnectionState.Closed Then db.Open()

        Dim sql As String = "
        SELECT roomNumber, Type, classification, Price, roomName
        FROM Rooms
        WHERE RoomID = ?"

        Using cmd As New OleDbCommand(sql, db)

            cmd.Parameters.AddWithValue("@p1", SelectedRoomID)

            Using reader As OleDbDataReader = cmd.ExecuteReader()

                If reader.Read() Then

                    RoomNumber = reader("roomNumber").ToString()
                    RoomName = reader("roomName").ToString()
                    RoomType = reader("Type").ToString()
                    Classification = reader("Classification").ToString()
                    Price = CDec(reader("Price"))

                    lblRoomName.Text = RoomName
                    lblRoomNo.Text = RoomNumber
                    lblRoomType.Text = RoomType
                    lblRoomClass.Text = Classification
                    lblPrice.Text = "₱" & Price.ToString("N2")

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
                "UPDATE Reservations SET status='CANCELLED' WHERE ReservationID=?", db)
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

    Sub CheckInReservedBooking(paid As Decimal, payType As String)

        Dim grandTotal As Decimal = CalculateGrandTotal()

        If db.State = ConnectionState.Closed Then db.Open()

        ' 1️⃣ Insert to BOOKINGS
        Using cmd As New OleDbCommand(
    "INSERT INTO Bookings
    (BookingID, guestID, RoomID, [check-in], [check-out],
     TotalAmount, PaymentType, amountPaid, balance, status)
     VALUES (?,?,?,?,?,?,?,?,?,?)", db)

            cmd.Parameters.AddWithValue("@p1", BookingID)
            cmd.Parameters.AddWithValue("@p2", guestsID)
            cmd.Parameters.AddWithValue("@p3", SelectedRoomID)
            cmd.Parameters.AddWithValue("@p4", dtCheckIn.Value)
            cmd.Parameters.AddWithValue("@p5", dtCheckOut.Value)
            cmd.Parameters.AddWithValue("@p6", grandTotal)
            cmd.Parameters.AddWithValue("@p7", payType)
            cmd.Parameters.AddWithValue("@p8", paid)
            cmd.Parameters.AddWithValue("@p9", grandTotal - paid)
            cmd.Parameters.AddWithValue("@p10", "RESERVED")

            cmd.ExecuteNonQuery()
        End Using


        ' 2️⃣ Remove reservation
        Using cmdDelete As New OleDbCommand(
        "DELETE FROM Reservations WHERE ReservationID=?", db)

            cmdDelete.Parameters.AddWithValue("@p1", BookingID)
            cmdDelete.ExecuteNonQuery()

        End Using


        ' 3️⃣ Update Room Status
        Using cmdRoom As New OleDbCommand(
    "UPDATE Rooms SET Status='RESERVED' WHERE RoomID=?", db)

            cmdRoom.Parameters.AddWithValue("@p1", SelectedRoomID)
            cmdRoom.ExecuteNonQuery()

        End Using

    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click

        If cboGuest.Text = "" Then
            MessageBox.Show("Guest Name Required")
            Exit Sub
        End If

        If db.State = ConnectionState.Closed Then db.Open()

        Dim sqlCheck As String =
"SELECT COUNT(*) FROM Reservations 
 WHERE RoomID=? 
 AND ? < [check-out] 
 AND ? > [check-in] 
 AND status <> 'CANCELLED'"

        Using cmdCheck As New OleDbCommand(sqlCheck, db)
            cmdCheck.Parameters.AddWithValue("@p1", SelectedRoomID)
            cmdCheck.Parameters.AddWithValue("@p2", dtCheckOut.Value)
            cmdCheck.Parameters.AddWithValue("@p3", dtCheckIn.Value)

            Dim conflict As Integer = CInt(cmdCheck.ExecuteScalar())

            If conflict > 0 Then
                MessageBox.Show("Room already reserved for those dates.")
                Exit Sub
            End If
        End Using



        Dim grandTotal As Decimal = CalculateGrandTotal()
        Dim paid As Decimal
        Dim payType As String

        If rbFullPayment.Checked Then
            payType = "FULL"
            paid = grandTotal
        Else
            payType = "DOWN"
            Decimal.TryParse(txtDownpayment.Text, paid)
        End If

        Dim balance = grandTotal - paid

        Try
            Using cmdRes As New OleDbCommand(
        "INSERT INTO Reservations
        (ReservationID, guestID, RoomID, [check-in], [check-out],
         TotalAmount, PaymentType, amountPaid, balance, status)
         VALUES (?,?,?,?,?,?,?,?,?,?)", db)

                cmdRes.Parameters.AddWithValue("@p1", BookingID)
                cmdRes.Parameters.AddWithValue("@p2", guestsID)
                cmdRes.Parameters.AddWithValue("@p3", SelectedRoomID)
                cmdRes.Parameters.AddWithValue("@p4", dtCheckIn.Value)
                cmdRes.Parameters.AddWithValue("@p5", dtCheckOut.Value)
                cmdRes.Parameters.AddWithValue("@p6", grandTotal)
                cmdRes.Parameters.AddWithValue("@p7", payType)
                cmdRes.Parameters.AddWithValue("@p8", paid)
                cmdRes.Parameters.AddWithValue("@p9", balance)
                cmdRes.Parameters.AddWithValue("@p10", "RESERVED")

                cmdRes.ExecuteNonQuery()

            End Using
            Me.Close()

        Catch ex As Exception
            MsgBox("reservation error " & ex.ToString)
        End Try

    End Sub

    Private Function CalculateGrandTotal() As Decimal

        Dim nights As Integer = (dtCheckOut.Value - dtCheckIn.Value).Days
        If nights < 1 Then nights = 1

        Dim roomTotal As Decimal = Price * nights

        Return roomTotal

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


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim grandTotal As Decimal = CalculateGrandTotal()
        Dim paid As Decimal
        Dim payType As String

        If rbFullPayment.Checked Then
            payType = "FULL"
            paid = grandTotal
        Else
            payType = "DOWN"
            Decimal.TryParse(txtDownpayment.Text, paid)
        End If

        CheckInReservedBooking(paid, payType)

        MessageBox.Show("Guest successfully checked-in.", "Check-In Complete")

        Me.Close()
    End Sub
End Class
