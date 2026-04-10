Public Class guest_form
    Private Sub guest_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb_guests()
        sqlquery_guests()
        dgvGuest.DataSource = dbds5.Tables("Guests")
    End Sub

    Private Sub dgvGuest_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGuest.CellClick
        If e.RowIndex >= 0 Then
            txtGname.Text = dgvGuest.Rows(e.RowIndex).Cells("guestName").Value.ToString()
            txtGcontact.Text = dgvGuest.Rows(e.RowIndex).Cells("guestContact").Value.ToString()
            txtGaddress.Text = dgvGuest.Rows(e.RowIndex).Cells("guestAddress").Value.ToString()
        End If
    End Sub

    Function GenerateGuestID() As String
        Return "GUEST-" & Date.Now.ToString("yyyyMMddHHmmss")
    End Function

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If dgvGuest.CurrentRow Is Nothing Then Exit Sub

        If db.State = ConnectionState.Closed Then db.Open()

        Dim guestID As String = dgvGuest.CurrentRow.Cells("GuestID").Value.ToString()
        If MessageBox.Show("Are you sure you want to delete this guest?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Try
                Dim cmd As New OleDb.OleDbCommand("DELETE FROM Guests WHERE GuestID=@id", db)
                cmd.Parameters.AddWithValue("@id", guestID)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Guest deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Refresh DataGridView
                sqlquery_guests()
                dgvGuest.DataSource = dbds5.Tables("Guests")
            Catch ex As Exception
                MessageBox.Show("Error deleting guest: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvGuest.CurrentRow Is Nothing Then Exit Sub
        If db.State = ConnectionState.Closed Then db.Open()
        Try
            Dim guestID As String = dgvGuest.CurrentRow.Cells("GuestID").Value.ToString()
            Dim cmd As New OleDb.OleDbCommand("UPDATE Guests SET guestName=@fn, guestContact=@contact, guestAddress=@address WHERE GuestID=@id", db)
            cmd.Parameters.AddWithValue("@fn", txtGname.Text)
            cmd.Parameters.AddWithValue("@contact", txtGcontact.Text)
            cmd.Parameters.AddWithValue("@address", txtGaddress.Text)
            cmd.Parameters.AddWithValue("@id", guestID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Guest updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView
            sqlquery_guests()
            dgvGuest.DataSource = dbds5.Tables("Guests")
        Catch ex As Exception
            MessageBox.Show("Error updating guest: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Try
            If db.State = ConnectionState.Closed Then db.Open()
            Dim cmdCheck As New OleDb.OleDbCommand("SELECT COUNT(*) FROM Guests WHERE guestName = @fn", db)
            cmdCheck.Parameters.AddWithValue("@fn", txtGname.Text.Trim())
            Dim count As Integer = CInt(cmdCheck.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Guest with this name already exists! Please check the name or update the existing guest.", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim cmd As New OleDb.OleDbCommand("INSERT INTO Guests (guestName, guestContact, guestAddress, guestID) VALUES (@fn,@contact,@address,@guestID)", db)
            cmd.Parameters.AddWithValue("@fn", txtGname.Text)
            cmd.Parameters.AddWithValue("@contact", txtGcontact.Text)
            cmd.Parameters.AddWithValue("@address", txtGaddress.Text)
            cmd.Parameters.AddWithValue("@guestID", GenerateGuestID)
            cmd.ExecuteNonQuery()
            MessageBox.Show("New guest added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh DataGridView
            sqlquery_guests()
            dgvGuest.DataSource = dbds5.Tables("Guests")
        Catch ex As Exception
            MessageBox.Show("Error adding guest: " & ex.Message)
        End Try
    End Sub

End Class