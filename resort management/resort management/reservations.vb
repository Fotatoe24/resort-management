
Imports System.Data
Imports System.Data.OleDb

Public Class reservations
    Private Sub reservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        LoadCalendar()
    End Sub

    Private Sub dgvCalendar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCalendar.CellClick

        ' Ignore header row/column clicks
        If e.RowIndex < 0 Or e.ColumnIndex < 1 Then Exit Sub

        Dim row As DataGridViewRow = dgvCalendar.Rows(e.RowIndex)

        ' Ensure room exists
        If row.Tag Is Nothing Then
            MessageBox.Show("Invalid room selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim roomID As String = row.Tag.ToString()

        ' Get the date of the clicked column
        Dim selectedDate As Date
        If dgvCalendar.Columns(e.ColumnIndex).Tag IsNot Nothing Then
            selectedDate = CType(dgvCalendar.Columns(e.ColumnIndex).Tag, Date)
        Else
            If Not Date.TryParse(dgvCalendar.Columns(e.ColumnIndex).Name, selectedDate) Then
                MessageBox.Show("Invalid date selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If

        ' Get the BookingID or ReservationID from the cell.Tag
        Dim recordTag As String = If(row.Cells(e.ColumnIndex).Tag, "")
        Dim bookingID As String = Nothing
        Dim isReservation As Boolean = False

        If Not String.IsNullOrEmpty(recordTag) Then
            ' Stored as "RecordID|SourceTable"
            Dim parts() As String = recordTag.Split("|"c)
            If parts.Length = 2 Then
                bookingID = parts(0)
                isReservation = (parts(1) = "Reservation")
            End If
        End If

        ' Open Reservation_form
        Dim frm As New Reservation_form

        Try
            If String.IsNullOrEmpty(recordTag) Then

                ' NEW reservation
                frm.SelectedRoomID = roomID
                frm.BookingID = GenerateReservationID()
                frm.dtCheckIn.Value = selectedDate
                frm.dtCheckOut.Value = selectedDate.AddDays(1)
                frm.IsReservation = True
                frm.IsCheckIn = False
            Else

                ' EXISTING reservation/booking
                frm.BookingID = bookingID
                frm.IsReservation = isReservation
                frm.IsCheckIn = True
                frm.IsReservation = False
            End If

            ' Show form as dialog and refresh calendar after closing
            frm.ShowDialog()
            LoadCalendar()

        Catch ex As Exception
            MessageBox.Show("Error opening reservation: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadCalendar()

        dgvCalendar.Columns.Clear()
        dgvCalendar.Rows.Clear()

        ' First column = Room Name
        dgvCalendar.Columns.Add("Room", "Room")

        Dim startDate As Date = dtpStartDate.Value
        Dim totalDays As Integer = numDays.Value

        For i As Integer = 0 To totalDays - 1
            Dim d As Date = startDate.AddDays(i)
            Dim colIndex As Integer = dgvCalendar.Columns.Add(d.ToShortDateString(), d.ToString("MMM dd"))
            dgvCalendar.Columns(colIndex).Tag = d   ' store actual DateTime
        Next

        LoadRooms()
        LoadReservationsToCalendar()

    End Sub

    Function GenerateReservationID() As String
        Return "RES-" & Date.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Sub LoadRooms()

        Dim sql As String = "SELECT RoomID, RoomNumber FROM Rooms ORDER BY RoomNumber"
        Dim da As New OleDbDataAdapter(sql, db)
        Dim dt As New DataTable
        da.Fill(dt)

        For Each row As DataRow In dt.Rows
            Dim index As Integer = dgvCalendar.Rows.Add()
            dgvCalendar.Rows(index).Cells(0).Value = row("RoomNumber") ' displayed
            dgvCalendar.Rows(index).Tag = row("RoomID")                 ' internal logic
        Next

        ResizeRowsToFill()
    End Sub

    'HELPER FUCNTIONS
    Private Sub ResizeRowsToFill()

        If dgvCalendar.Rows.Count = 0 Then Exit Sub

        Dim totalHeight As Integer = dgvCalendar.ClientSize.Height
        Dim headerHeight As Integer = dgvCalendar.ColumnHeadersHeight
        Dim availableHeight As Integer = totalHeight - headerHeight

        Dim rowHeight As Integer = availableHeight \ dgvCalendar.Rows.Count

        For Each row As DataGridViewRow In dgvCalendar.Rows
            row.Height = rowHeight
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadCalendar()
    End Sub
    Private Sub LoadReservationsToCalendar()

        ' Clear previous display
        For Each row As DataGridViewRow In dgvCalendar.Rows
            For col As Integer = 1 To dgvCalendar.Columns.Count - 1
                row.Cells(col).Value = ""
                row.Cells(col).Style.BackColor = Color.White
                row.Cells(col).Tag = Nothing
            Next
        Next

        ' SQL combining Reservations and Bookings
        Dim sql As String = "
        SELECT ReservationID AS RecordID, RoomID, [check-in], [check-out], status, 'Reservation' AS SourceTable
        FROM Reservations
        WHERE status <> 'CANCELLED'

        UNION ALL

        SELECT bookingID AS RecordID, RoomID, [check-in], [check-out], status, 'Booking' AS SourceTable
        FROM Bookings
        WHERE status <> 'CANCELLED'
    "

        Dim da As New OleDbDataAdapter(sql, db)
        Dim dt As New DataTable
        da.Fill(dt)

        For Each res As DataRow In dt.Rows

            Dim recordID As String = res("RecordID").ToString()
            Dim roomID As String = res("RoomID").ToString()
            Dim status As String = res("status").ToString()
            Dim source As String = res("SourceTable").ToString()

            Dim checkIn As Date
            Dim checkOut As Date

            If Not Date.TryParse(res("check-in").ToString(), checkIn) Then Continue For
            If Not Date.TryParse(res("check-out").ToString(), checkOut) Then Continue For

            ' Find the row for this room
            For Each row As DataGridViewRow In dgvCalendar.Rows

                If row.Tag IsNot Nothing AndAlso row.Tag.ToString() = roomID Then

                    For col As Integer = 1 To dgvCalendar.Columns.Count - 1

                        Dim columnDate As Date = Date.Parse(dgvCalendar.Columns(col).Name)

                        If columnDate.Date >= checkIn.Date And columnDate.Date <= checkOut.Date Then

                            ' Check-in day
                            If columnDate.Date = checkIn.Date Then
                                row.Cells(col).Value = status
                                row.Cells(col).Style.BackColor = Color.LightGreen

                                ' Check-out day
                            ElseIf columnDate.Date = checkOut.Date Then
                                row.Cells(col).Value = "CHECK-OUT"
                                row.Cells(col).Style.BackColor = Color.LightBlue

                            Else
                                row.Cells(col).Style.BackColor = Color.LightCoral
                            End If

                            ' Store record reference
                            row.Cells(col).Tag = recordID & "|" & source

                        End If

                    Next

                End If

            Next

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MsgBox("Do you want to exit?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Closing...") = MsgBoxResult.Yes Then
            main_form.Show()
            Me.Close()
        Else

        End If

    End Sub
End Class