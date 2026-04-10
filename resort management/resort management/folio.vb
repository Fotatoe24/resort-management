Public Class folio
    Public Property SelectedBookingID As String

    Private Sub folio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(SelectedBookingID) Then
            LoadFolioDetails(SelectedBookingID)  ' Load guest, room, orders, totals
        End If
    End Sub

    Sub LoadFolioDetails(bookingID As String)
        ' Load guest info, room info, and orders like before
        ' Calculate grand total = room + amenities + orders
        ' Update Paid and Balance
    End Sub
End Class