Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Public Class payment_Type
    Public guestName As String
    Public guestContact As String
    Public guestAddress As String
    Public guestRnum As String

    Private Sub payment_Type_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb_booking()
        sqlquery_booking()
        opendb_guests()
        sqlquery_guests()

        LoadOccupiedGuests()

    End Sub

    Private Sub LoadOccupiedGuests()
        Dim dt As DataTable = GetOccupiedGuestInfo()

        dgvGuest.AutoGenerateColumns = True
        dgvGuest.DataSource = dt

        ' Optional UI tweaks
        dgvGuest.ReadOnly = True
        dgvGuest.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvGuest.AllowUserToAddRows = False
    End Sub

    Public Function GetOccupiedGuestInfo() As DataTable
        Dim dt As New DataTable

        Dim sql As String = "
        SELECT 
            B.bookingID AS [booking ID],
            G.guestName AS [Guest Name],
            G.guestContact AS [Contact],
            G.guestAddress AS [Address],
            R.roomNumber AS [Room No]
        FROM 
            (Bookings AS B
            INNER JOIN Guests AS G ON B.guestID = G.guestID)
            INNER JOIN Rooms AS R ON B.roomID = R.roomID
        WHERE 
            B.status = 'OCCUPIED'
    "

        Using conn As New OleDbConnection(
        "PROVIDER=microsoft.jet.oledb.4.0; data source=" &
        Application.StartupPath & "\database\resortDb.mdb")

            Using da As New OleDbDataAdapter(sql, conn)
                da.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Private Sub btnPayNow_Click(sender As Object, e As EventArgs) Handles btnPayNow.Click
        sw5 = True
        PaymentMode = "PAYNOW"
        Me.Close()
    End Sub

    Private Sub btnCharge_Click(sender As Object, e As EventArgs) Handles btnCharge.Click
        If MsgBox("Are you Sure to Charge to guest " & guestName & " ?", MsgBoxStyle.YesNo, "Charging...") = MsgBoxResult.Yes Then
            sw5 = False
            PaymentMode = "CHARGE"
            Me.Close()
        End If
    End Sub

    Private Sub dgvGuest_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick

        If e.RowIndex < 0 Then Exit Sub   ' header clicked

        Dim row As DataGridViewRow = dgvGuest.Rows(e.RowIndex)
        posv2.bookingID = row.Cells("booking ID").Value.ToString()
        guestName = row.Cells("Guest Name").Value.ToString()
        guestContact = row.Cells("Contact").Value.ToString()
        guestAddress = row.Cells("Address").Value.ToString()
        guestRnum = row.Cells("Room No").Value.ToString()

    End Sub
End Class