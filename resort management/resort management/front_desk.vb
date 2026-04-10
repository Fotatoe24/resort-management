
Imports System.Data
Imports System.Data.OleDb
Public Class front_desk
    Public RoomsTable As DataTable
    Public dv As DataView
    Public SelectedDate As Date = Date.Today
    Dim allowClose As Boolean = False

    Private Sub front_desk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        LoadRoomsData()
        LoadRoomTiles()
        DateTimePicker2.Value = Date.Now.AddDays(1)
    End Sub

    Sub LoadRoomsData()
        ' Load all rooms and bookings
        Dim sql As String =
        "SELECT Rooms.RoomID AS RRoomID, Rooms.roomNumber, Rooms.Price, Rooms.Type, " &
        "Rooms.classification, Rooms.capacity, Rooms.Status as roomStatus, " &
        "Bookings.bookingID AS BookingID, Bookings.guestID AS BookingGuestID, " &
        "Bookings.amountPaid, Bookings.balance, Bookings.TotalAmount, " &
        "Bookings.status AS BookingStatus, Bookings.[check-in], Bookings.[check-out], " &
        "Guests.guestID AS GuestID, Guests.guestName " &
        "FROM (Rooms " &
        "LEFT JOIN Bookings ON Rooms.RoomID = Bookings.RoomID) " &
        "LEFT JOIN Guests ON Bookings.guestID = Guests.guestID"

        Dim cmd As New OleDbCommand(sql, db)
        Rooms = New OleDbDataAdapter(cmd)
        dbds = New DataSet()
        Rooms.Fill(dbds, "Rooms")

        RoomsTable = dbds.Tables("Rooms")
        dv = New DataView(RoomsTable)

        UpdateDashboard(dv)
    End Sub
    ' Build tiles from DataView
    Sub LoadRoomTiles(Optional view As DataView = Nothing)
        If view Is Nothing Then view = dv
        FlowLayoutPanel1.Controls.Clear()

        Dim selectedDate As Date = DateTimePicker1.Value.Date

        ' Group rows by RoomID to avoid duplicates
        Dim grouped = RoomsTable.AsEnumerable().
                  GroupBy(Function(r) r("RRoomID").ToString())

        For Each roomGroup In grouped
            Dim row = roomGroup.First()
            Dim pnl As New Panel With {
            .Size = New Size(450, 550),
            .Margin = New Padding(10),
            .BorderStyle = BorderStyle.FixedSingle,
            .Cursor = Cursors.Hand,
            .Tag = row("RRoomID").ToString()
        }

            ' Default room status from Rooms table
            Dim roomStatus As String = "AVAILABLE" ' default tile status
            Dim guestName As String = ""

            ' Check all bookings for the selected date
            For Each bookingRow In roomGroup
                If Not IsDBNull(bookingRow("BookingID")) AndAlso
       Not IsDBNull(bookingRow("check-in")) AndAlso
       Not IsDBNull(bookingRow("check-out")) Then

                    Dim dbCheckIn As Date = CDate(bookingRow("check-in")).Date
                    Dim dbCheckOut As Date = CDate(bookingRow("check-out")).Date
                    Dim bookingStatus As String = bookingRow("BookingStatus").ToString().ToUpper()

                    ' Only override if selected date is inside booking
                    If selectedDate >= dbCheckIn AndAlso selectedDate < dbCheckOut Then
                        If bookingStatus = "OCCUPIED" Then
                            roomStatus = "OCCUPIED"
                        ElseIf bookingStatus = "RESERVED" Then
                            roomStatus = "RESERVED"
                        End If
                        guestName = If(Not IsDBNull(bookingRow("GuestName")), bookingRow("GuestName").ToString(), "")
                        Exit For ' Stop after finding today's booking
                    End If
                End If
            Next

            ' Override Rooms table status for maintenance / cleaning
            Dim baseStatus As String = row("roomStatus").ToString().ToUpper()
            If baseStatus = "MAINTENANCE" Then
                roomStatus = "MAINTENANCE"
            ElseIf baseStatus = "CLEANING" And roomStatus = "AVAILABLE" Then
                roomStatus = "CLEANING"
            End If

            ' Determine if room has a check-out today
            Dim isCheckoutToday As Boolean = False
            For Each bookingRow In roomGroup
                If Not IsDBNull(bookingRow("check-out")) Then
                    Dim dbCheckOut As Date = CDate(bookingRow("check-out")).Date
                    If dbCheckOut = selectedDate Then
                        isCheckoutToday = True
                        Exit For
                    End If
                End If
            Next

            ' Set tile color
            Select Case roomStatus
                Case "AVAILABLE" : pnl.BackColor = Color.LimeGreen
                Case "OCCUPIED" : pnl.BackColor = Color.LightCoral
                Case "RESERVED" : pnl.BackColor = Color.Yellow
                Case "CLEANING" : pnl.BackColor = Color.LightSkyBlue
                Case "MAINTENANCE" : pnl.BackColor = Color.Gray
            End Select

            ' Add a border or subtle highlight if checkout is today
            If isCheckoutToday Then
                pnl.BorderStyle = BorderStyle.Fixed3D
                pnl.BackColor = ControlPaint.Light(pnl.BackColor, 0.3) ' light tint
            End If

            ' Labels
            Dim lblRoom As New Label With {.Text = "Room " & row("roomNumber").ToString(), .Font = New Font("Segoe UI", 16, FontStyle.Bold), .Location = New Point(45, 405), .AutoSize = True}
            Dim lblClass As New Label With {.Text = row("classification").ToString(), .Font = New Font("Segoe UI", 14), .Location = New Point(45, 440), .AutoSize = True}
            Dim lblCap As New Label With {.Text = row("capacity").ToString() & " pax", .Font = New Font("Segoe UI", 14), .Location = New Point(45, 470), .AutoSize = True}
            Dim lblType As New Label With {.Text = row("Type").ToString(), .Font = New Font("Segoe UI", 14), .Location = New Point(250, 440), .AutoSize = True}
            Dim lblStatus As New Label With {.Text = roomStatus, .Font = New Font("Segoe UI", 14, FontStyle.Bold), .Location = New Point(250, 410), .AutoSize = True}
            Dim lblPrice As New Label With {.Text = "₱ " & row("Price").ToString() & "/night", .Font = New Font("Segoe UI", 16, FontStyle.Bold), .Location = New Point(240, 470), .AutoSize = True}
            Dim lblGuest As New Label With {.Font = New Font("Segoe UI", 12, FontStyle.Italic), .Location = New Point(45, 505), .AutoSize = True, .ForeColor = Color.Black}
            lblGuest.Text = If((roomStatus = "OCCUPIED" Or roomStatus = "RESERVED") And guestName <> "", "Guest: " & guestName, "")

            If isCheckoutToday Then
                Dim lblCheckout As New Label With {
        .Text = "CHECK-OUT TODAY",
        .ForeColor = Color.Black,
        .Font = New Font("Segoe UI", 10, FontStyle.Bold),
        .BackColor = Color.Orange,
        .AutoSize = True,
        .Location = New Point(10, 10)
    }
                pnl.Controls.Add(lblCheckout)
            End If
            ' Room image
            Dim pic As New PictureBox With {.Size = New Size(360, 360), .Location = New Point(45, 40), .SizeMode = PictureBoxSizeMode.Zoom, .BackColor = Color.WhiteSmoke, .BorderStyle = BorderStyle.FixedSingle, .Cursor = Cursors.Hand, .Tag = row("roomNumber").ToString()}
            Dim img As Image = LoadRoomImageForTile(row("RRoomID").ToString())
            If img IsNot Nothing Then
                pic.Image = img
            Else
                pic.Image = Nothing
                pic.BackColor = Color.Gainsboro
                Dim lblNoImg As New Label With {.Text = "NO IMAGE", .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleCenter, .Font = New Font("Segoe UI", 8, FontStyle.Italic), .ForeColor = Color.DimGray}
                pic.Controls.Add(lblNoImg)
            End If

            pnl.Controls.AddRange({lblRoom, lblCap, lblClass, lblType, lblStatus, lblPrice, pic, lblGuest})

            ' Click events
            AddHandler pnl.Click, AddressOf RoomTile_Click
            AddHandler lblRoom.Click, AddressOf RoomTile_Click
            AddHandler lblClass.Click, AddressOf RoomTile_Click
            AddHandler lblStatus.Click, AddressOf RoomTile_Click
            AddHandler pic.Click, AddressOf RoomTile_Click

            FlowLayoutPanel1.Controls.Add(pnl)
        Next
    End Sub
    Private Sub txtamt_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSearchGuest.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "Closing...") = MsgBoxResult.Yes Then
                allowClose = True
                main_form.Show()
                Me.Close()
            Else

            End If
        End If
    End Sub
    ' Apply search filter to DataView and reload tiles
    Sub ApplySearchFilter()
        Dim filters As New List(Of String)

        ' CAPACITY
        If txtSearchCapacity.Value > 0 Then
            filters.Add($"capacity >= {txtSearchCapacity.Value}")
        End If

        ' TYPE
        If rbSearchAc.Checked Then
            filters.Add("Type = 'AC'")
        ElseIf rbSearchNac.Checked Then
            filters.Add("Type = 'Non-AC'")
        End If
        ' rbSearchAll.Checked -> no Type filter (show all)

        ' STATUS
        If Not String.IsNullOrWhiteSpace(cmbSearchStatus.Text) Then
            filters.Add($"roomStatus = '{cmbSearchStatus.Text.Replace("'", "''")}'")
        End If

        ' CLASSIFICATION (FAMILY / COUPLE / ALL)
        If Not String.IsNullOrWhiteSpace(cmbSearchClassicification.Text) Then
            filters.Add($"classification LIKE '%{cmbSearchClassicification.Text.Replace("'", "''")}%'")
        End If

        If Not String.IsNullOrWhiteSpace(txtSearchGuest.Text) Then
            Dim guest As String = txtSearchGuest.Text.Replace("'", "''")
            filters.Add($"GuestName LIKE '%{guest}%'")
        End If

        ' Apply filter
        dv.RowFilter = String.Join(" AND ", filters)

        ' Reload tiles
        LoadRoomTiles(dv)

        UpdateDashboard(dv)
    End Sub

    ' Auto-search when controls change
    Private Sub Search_Changed(sender As Object, e As EventArgs) _
        Handles txtSearchGuest.TextChanged,
        txtSearchCapacity.ValueChanged,
                cmbSearchStatus.SelectedIndexChanged,
                cmbSearchClassicification.SelectedIndexChanged,
                rbSearchAc.CheckedChanged,
                rbSearchNac.CheckedChanged,
                rbSearchAll.CheckedChanged

        ApplySearchFilter()
    End Sub
    Sub RoomTile_Click(sender As Object, e As EventArgs)

        Dim pnl As Panel = Nothing

        ' Find clicked panel
        Dim ctrl As Control = CType(sender, Control)
        While ctrl IsNot Nothing AndAlso Not TypeOf ctrl Is Panel
            ctrl = ctrl.Parent
        End While

        If ctrl Is Nothing OrElse ctrl.Tag Is Nothing Then
            MessageBox.Show("Room data not found.", "Error")
            Exit Sub
        End If

        pnl = CType(ctrl, Panel)
        Dim roomID As String = pnl.Tag.ToString()
        Dim selectedDate As Date = DateTimePicker1.Value.Date

        ' Get ALL rows for this room
        Dim rows() As DataRow = RoomsTable.Select($"RRoomID = '{roomID}'")

        If rows.Length = 0 Then Exit Sub

        Dim baseRow As DataRow = rows(0)

        ' Maintenance check
        If baseRow("roomStatus").ToString().ToUpper() = "MAINTENANCE" Then
            MsgBox("This room is under maintenance.", MsgBoxStyle.Exclamation, "Unavailable")
            Exit Sub
        End If

        Dim activeBookingRow As DataRow = Nothing
        Dim checkoutBookingRow As DataRow = Nothing

        For Each r As DataRow In rows

            If Not IsDBNull(r("BookingID")) AndAlso
       Not IsDBNull(r("check-in")) AndAlso
       Not IsDBNull(r("check-out")) Then

                Dim dbCheckIn As Date = CDate(r("check-in")).Date
                Dim dbCheckOut As Date = CDate(r("check-out")).Date

                ' Guest currently staying
                If selectedDate >= dbCheckIn AndAlso selectedDate < dbCheckOut Then
                    activeBookingRow = r
                    Exit For
                End If

                ' Checkout day
                If selectedDate = dbCheckOut Then
                    checkoutBookingRow = r
                End If

            End If

        Next

        ' =============================
        ' OCCUPIED / RESERVED
        ' =============================
        If activeBookingRow IsNot Nothing Then

            Dim bookingStatus As String = activeBookingRow("BookingStatus").ToString().ToUpper()

            If bookingStatus = "OCCUPIED" Then

                Dim infoForm As New during_stay
                infoForm.RoomID = roomID
                infoForm.BookingID = activeBookingRow("BookingID").ToString()
                infoForm.ShowDialog()

            ElseIf bookingStatus = "RESERVED" Then

                Dim booking As New booking_form
                booking.SelectedRoomID = roomID
                booking.BookingID = activeBookingRow("BookingID").ToString()
                booking.IsCheckIn = True
                booking.IsReservation = True
                booking.ShowDialog()

            End If


            ' =============================
            ' CHECKOUT TODAY
            ' =============================
        ElseIf checkoutBookingRow IsNot Nothing Then

            Dim infoForm As New during_stay
            infoForm.RoomID = roomID
            infoForm.BookingID = checkoutBookingRow("BookingID").ToString()
            ' infoForm.IsCheckoutMode = True
            infoForm.ShowDialog()


            ' =============================
            ' AVAILABLE
            ' =============================
        Else

            Dim booking As New booking_form
            booking.SelectedRoomID = baseRow("RRoomID")
            booking.BookingID = GenerateBookingID()
            booking.RoomNumber = baseRow("roomNumber")
            booking.RoomType = baseRow("Type")
            booking.Classification = baseRow("classification")
            booking.Price = baseRow("Price")

            booking.ShowDialog()

        End If

        ' Refresh dashboard
        LoadRoomsData()
        LoadRoomTiles()
        UpdateDashboard(dv)

    End Sub

    Function GenerateGuestID() As String
        Return "GUEST-" & Date.Now.ToString("yyyyMMddHHmmss")
    End Function

    Function GenerateBookingID() As String
        Return "BOOK-" & Date.Now.ToString("yyyyMMddHHmmss")
    End Function

    Function LoadRoomImageForTile(roomId As String) As Image
        Try
            Dim imgPath As String = Application.StartupPath & "\images\" & roomId & ".jpg"

            If IO.File.Exists(imgPath) Then
                Using fs As New IO.FileStream(imgPath, IO.FileMode.Open, IO.FileAccess.Read)
                    Return Image.FromStream(fs)
                End Using
            End If

        Catch ex As Exception
        End Try

        Return Nothing
    End Function
    Sub UpdateDashboard(Optional ByVal view As DataView = Nothing)
        If view Is Nothing Then view = dv

        Dim totalRooms As Integer = 0
        Dim guestsInHouse As Integer = 0
        Dim unitsFree As Integer = 0
        Dim checkins As Integer = 0
        Dim checkouts As Integer = 0
        Dim staying As Integer = 0

        Dim selectedDate As Date = DateTimePicker1.Value.Date

        For Each rowView As DataRowView In view
            Dim row As DataRow = rowView.Row
            Dim baseStatus As String = row("roomStatus").ToString().ToUpper()
            totalRooms += 1

            ' Skip maintenance from availability count
            If baseStatus = "MAINTENANCE" Then Continue For

            ' Default availability
            Dim roomStatus As String = "AVAILABLE"

            ' Check bookings for the selected date
            If Not IsDBNull(row("BookingID")) AndAlso
           Not IsDBNull(row("check-in")) AndAlso
           Not IsDBNull(row("check-out")) Then

                Dim dbCheckIn As Date = CDate(row("check-in")).Date
                Dim dbCheckOut As Date = CDate(row("check-out")).Date
                Dim bookingStatus As String = row("BookingStatus").ToString().ToUpper()

                If selectedDate >= dbCheckIn AndAlso selectedDate < dbCheckOut Then
                    If bookingStatus = "OCCUPIED" Then
                        roomStatus = "OCCUPIED"
                        guestsInHouse += 1
                        staying += 1
                    ElseIf bookingStatus = "RESERVED" Then
                        roomStatus = "RESERVED"
                    End If
                End If

                ' Check-in today
                If dbCheckIn = selectedDate Then checkins += 1
                ' Check-out today
                If dbCheckOut = selectedDate Then checkouts += 1
            End If

            ' Count free units
            If roomStatus = "AVAILABLE" Then unitsFree += 1

        Next

        ' Update labels
        lblTroom.Text = totalRooms.ToString()
        lblTavailable.Text = unitsFree.ToString()
        lblTcheckin.Text = checkins.ToString()
        lblTcheckouts.Text = checkouts.ToString()
        lblTstay.Text = staying.ToString()
    End Sub

    Sub ClearAllFilters()
        ' Prevent triggering Search_Changed multiple times
        RemoveHandler txtSearchGuest.TextChanged, AddressOf Search_Changed
        RemoveHandler txtSearchCapacity.ValueChanged, AddressOf Search_Changed
        RemoveHandler cmbSearchStatus.SelectedIndexChanged, AddressOf Search_Changed
        RemoveHandler cmbSearchClassicification.SelectedIndexChanged, AddressOf Search_Changed
        RemoveHandler rbSearchAc.CheckedChanged, AddressOf Search_Changed
        RemoveHandler rbSearchNac.CheckedChanged, AddressOf Search_Changed
        RemoveHandler rbSearchAll.CheckedChanged, AddressOf Search_Changed

        ' Reset controls
        txtSearchGuest.Clear()
        txtSearchCapacity.Value = 0

        cmbSearchStatus.SelectedIndex = -1
        cmbSearchClassicification.SelectedIndex = -1

        rbSearchAll.Checked = True

        ' Clear DataView filter
        dv.RowFilter = ""

        ' Reload all tiles
        LoadRoomTiles(dv)
        UpdateDashboard(dv)

        ' Reattach handlers
        AddHandler txtSearchGuest.TextChanged, AddressOf Search_Changed
        AddHandler txtSearchCapacity.ValueChanged, AddressOf Search_Changed
        AddHandler cmbSearchStatus.SelectedIndexChanged, AddressOf Search_Changed
        AddHandler cmbSearchClassicification.SelectedIndexChanged, AddressOf Search_Changed
        AddHandler rbSearchAc.CheckedChanged, AddressOf Search_Changed
        AddHandler rbSearchNac.CheckedChanged, AddressOf Search_Changed
        AddHandler rbSearchAll.CheckedChanged, AddressOf Search_Changed
    End Sub

    Private Sub ROOMSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearAllFilters()
    End Sub

    Private Sub frontdesk_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not allowClose Then
            e.Cancel = True
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        LoadRoomsData()
        LoadRoomTiles()
    End Sub

    ' Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
    '      LoadRoomsData()
    '     LoadRoomTiles()
  '  End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        reservations.ShowDialog()
        LoadRoomsData()
        LoadRoomTiles()
    End Sub
End Class
