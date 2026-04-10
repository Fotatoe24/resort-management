Public Class checkout_form

    Public BookingID As String
    Public RoomID As String
    Private Sub checkout_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If db.State = ConnectionState.Closed Then db.Open()

            ' Adjusted query with proper brackets for Access
            Dim sql As String =
            "SELECT b.bookingID, b.guestID, b.RoomID, b.TotalAmount, b.amountPaid, b.[balance], " &
            "g.guestName, r.[roomNumber], r.[roomName], r.[Type], r.[classification], r.[Price] " &
            "FROM (Bookings AS b INNER JOIN Guests AS g ON b.guestID = g.guestID) " &
            "INNER JOIN Rooms AS r ON b.RoomID = r.RoomID " &
            "WHERE b.bookingID = ?"

            Using cmd As New OleDb.OleDbCommand(sql, db)
                ' Add parameter in the correct order
                cmd.Parameters.AddWithValue("?", BookingID)

                Using reader As OleDb.OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Guest info
                        txtGuestName.Text = If(IsDBNull(reader("guestName")), "", reader("guestName").ToString())
                        lblGuestID.Text = If(IsDBNull(reader("guestID")), "", reader("guestID").ToString())

                        ' Payment info
                        lblTotal.Text = If(IsDBNull(reader("TotalAmount")), "₱0.00", CDec(reader("TotalAmount")).ToString("₱ #,##0.00"))
                        lblAmountPaid.Text = If(IsDBNull(reader("amountPaid")), "₱0.00", CDec(reader("amountPaid")).ToString("₱ #,##0.00"))
                        lblBalance.Text = If(IsDBNull(reader("balance")), "₱0.00", CDec(reader("balance")).ToString("₱ #,##0.00"))

                        ' Room info
                        RoomID = If(IsDBNull(reader("RoomID")), "", reader("RoomID").ToString())
                        lblRoomNo.Text = If(IsDBNull(reader("roomNumber")), "", reader("roomNumber").ToString())
                        lblRoomName.Text = If(IsDBNull(reader("roomName")), "", reader("roomName").ToString())
                        lblRoomType.Text = If(IsDBNull(reader("Type")), "", reader("Type").ToString())
                        lblRoomClass.Text = If(IsDBNull(reader("classification")), "", reader("classification").ToString())
                        lblPrice.Text = If(IsDBNull(reader("Price")), "₱0.00", CDec(reader("Price")).ToString("₱ #,##0.00"))
                    Else
                        MessageBox.Show("Booking not found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Failed to load checkout data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("Confirm checkout for this guest?", "Confirm Checkout",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        Try
            If db.State = ConnectionState.Closed Then db.Open()

            ' 1. Update booking → CHECKED OUT
            Dim sqlBooking As String =
                "UPDATE Bookings SET " &
                "status = 'CHECKED OUT', " &
                "CheckOutDate = ?, " &
                "RoomID = NULL " &        ' unlink room
                "WHERE BookingID = ?"

            Using cmdBooking As New OleDb.OleDbCommand(sqlBooking, db)
                cmdBooking.Parameters.AddWithValue("@CheckOutDate", Date.Now)
                cmdBooking.Parameters.AddWithValue("@BookingID", BookingID)
                cmdBooking.ExecuteNonQuery()
            End Using

            ' 2. Update room status → AVAILABLE
            Dim sqlRoom As String =
                "UPDATE Rooms SET Status = 'AVAILABLE' WHERE RoomID = ?"

            Using cmdRoom As New OleDb.OleDbCommand(sqlRoom, db)
                cmdRoom.Parameters.AddWithValue("@RoomID", RoomID)
                cmdRoom.ExecuteNonQuery()
            End Using

            MessageBox.Show("Guest checked out successfully.", "Checkout Complete",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Checkout failed: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If db.State = ConnectionState.Open Then db.Close()
        End Try
    End Sub

End Class
