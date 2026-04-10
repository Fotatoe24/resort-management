Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class Form1

    Public isAddMode As Boolean = True
    Public dv As DataView

    ' ===== FORM LOAD =====
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        opendb() ' FROM YOUR MODULE

        dv = New DataView(dbds.Tables("Rooms"))
        dgvRooms.DataSource = dv

        dgvRooms.Columns("RoomPK").Visible = False
        dgvRooms.Columns("RoomID").Visible = False

        recpointer = 0
        display()
        lockControls()
        LoadRoomClassifications(cmbClass)
        LoadRoomClassifications(cmbSearchClassicification)
    End Sub

    ' ===== LOAD / REFRESH =====
    Sub LoadRooms()
        dbds.Tables("Rooms").Clear()
        Rooms.Fill(dbds, "Rooms")
        dv = New DataView(dbds.Tables("Rooms"))
        dgvRooms.DataSource = dv
    End Sub

    ' ===== DISPLAY =====
    Sub display()
        If dv.Count = 0 OrElse recpointer < 0 OrElse recpointer >= dv.Count Then Exit Sub

        Dim row As DataRowView = dv(recpointer)

        txtRoomID.Text = row("RoomID").ToString()
        txtRname.Text = row("roomName").ToString()
        txtRnum.Text = row("roomNumber").ToString()
        txtPrice.Text = row("Price").ToString()
        txtRcapacity.Text = row("capacity").ToString()
        cmbClass.Text = row("classification").ToString()
        cmbStatus.Text = row("status").ToString()

        rb_Ac.Checked = (row("Type").ToString() = "AC")
        rb_Nac.Checked = (row("Type").ToString() = "Non-AC")

        LoadRoomImage(txtRoomID.Text.Trim)

    End Sub

    ' ===== LOCK =====
    Sub lockControls()
        cmdAdd.Enabled = True
        cmdEdit.Enabled = True
        cmdDelete.Enabled = True
        cmdSave.Enabled = False
        cmdCancel.Enabled = False


        txtRname.ReadOnly = True
        txtRnum.ReadOnly = True
        txtPrice.ReadOnly = True
        txtRcapacity.ReadOnly = True
        cmbClass.Enabled = False
        cmbStatus.Enabled = False
        rb_Ac.Enabled = False
        rb_Nac.Enabled = False

        dgvRooms.Enabled = True
    End Sub

    Sub unlockControls()
        cmdAdd.Enabled = False
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False
        cmdSave.Enabled = True
        cmdCancel.Enabled = True
        lnkbrowse.Visible = True

        txtRname.ReadOnly = False
        txtRnum.ReadOnly = False
        txtPrice.ReadOnly = False
        txtRcapacity.ReadOnly = False
        cmbClass.Enabled = True
        cmbStatus.Enabled = True
        rb_Ac.Enabled = True
        rb_Nac.Enabled = True

        dgvRooms.Enabled = False
    End Sub

    ' ===== CLEAR =====
    Sub clearFields()
        txtRoomID.Clear()
        txtRname.Clear()
        txtRnum.Clear()
        txtPrice.Clear()
        txtRcapacity.Clear()
        cmbClass.Text = ""
        cmbStatus.Text = ""
        rb_Ac.Checked = False
        rb_Nac.Checked = False

    End Sub

    Sub clearFilter()
        txtSearchPrice.Clear()
        cmbSearchClassicification.Text = ""
        cmbSearchStatus.Text = ""
        txtSearchCapacity.Clear()



    End Sub

    ' ===== ADD =====
    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        picbox.Image = Nothing
        txtRnum.Focus()
        unlockControls()
        clearFields()
        txtRoomID.Text = GenerateRoomID()
        isAddMode = True
    End Sub

    ' ===== EDIT =====
    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        unlockControls()
        isAddMode = False
    End Sub

    ' ===== SAVE =====
    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Dim roomType As String = If(rb_Ac.Checked, "AC", "Non-AC")

        db.Open()

        Dim sql As String

        If isAddMode Then
            sql = "INSERT INTO Rooms (RoomID, roomName, roomNumber, Price, capacity, classification, status, Type)
                   VALUES (?,?,?,?,?,?,?,?)"
        Else
            sql = "UPDATE Rooms SET roomName=?, roomNumber=?, Price=?, capacity=?, classification=?, status=?, Type=?
                   WHERE RoomID=?"
        End If

        Using cmd As New OleDbCommand(sql, db)

            If isAddMode Then
                cmd.Parameters.AddWithValue("?", txtRoomID.Text)
            End If

            cmd.Parameters.AddWithValue("?", txtRname.Text)
            cmd.Parameters.AddWithValue("?", txtRnum.Text)
            cmd.Parameters.AddWithValue("?", txtPrice.Text)
            cmd.Parameters.AddWithValue("?", txtRcapacity.Text)
            cmd.Parameters.AddWithValue("?", cmbClass.Text)
            cmd.Parameters.AddWithValue("?", cmbStatus.Text)
            cmd.Parameters.AddWithValue("?", roomType)

            If Not isAddMode Then
                cmd.Parameters.AddWithValue("?", txtRoomID.Text)
            End If

            cmd.ExecuteNonQuery()
        End Using

        db.Close()

        LoadRooms()
        lockControls()
    End Sub

    ' ===== DELETE =====
    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        If MsgBox("Delete this room?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then Exit Sub

        db.Open()
        Using cmd As New OleDbCommand("DELETE FROM Rooms WHERE RoomID=?", db)
            cmd.Parameters.AddWithValue("?", txtRoomID.Text)
            cmd.ExecuteNonQuery()
        End Using
        db.Close()

        LoadRooms()
        lockControls()
    End Sub

    ' ===== ID =====
    Function GenerateRoomID() As String
        Return "RMS-" & Guid.NewGuid().ToString("N").Substring(0, 5).ToUpper()
    End Function


    ' ===== CANCEL =====
    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        dv.RowFilter = ""

        clearFilter()
        rbSearchAc.Checked = False
        rbSearchNac.Checked = False

        recpointer = 0
        display()
        lockControls()
    End Sub
    Sub ApplySearchFilter()
        Dim filters As New List(Of String)

        ' PRICE
        Dim price As Decimal
        If Decimal.TryParse(txtSearchPrice.Text, price) Then
            filters.Add($"Price <= {price}")
        End If

        ' CAPACITY
        Dim cap As Integer
        If Integer.TryParse(txtSearchCapacity.Text, cap) Then
            filters.Add($"capacity = {cap}")
        End If

        ' TYPE
        If rbSearchAc.Checked Then
            filters.Add("Type = 'AC'")
        ElseIf rbSearchNac.Checked Then
            filters.Add("Type = 'Non-AC'")
        End If

        ' STATUS
        If Not String.IsNullOrWhiteSpace(cmbSearchStatus.Text) Then
            filters.Add($"status = '{cmbSearchStatus.Text.Replace("'", "''")}'")
        End If

        ' CLASSIFICATION (FIXED)
        ' CLASSIFICATION (FIXED FOR FAMILY / COUPLE / ALL)
        If Not String.IsNullOrWhiteSpace(cmbSearchClassicification.Text) Then
            filters.Add($"classification LIKE '%{cmbSearchClassicification.Text.Replace("'", "''")}%'")
        End If

        dv.RowFilter = String.Join(" AND ", filters)


        recpointer = 0
        display()
        cmdCancel.Enabled = True


    End Sub



    Private Sub cmbSearchStatus_SelectedIndexChanged(sender As Object, e As EventArgs) _
    Handles cmbSearchStatus.SelectedIndexChanged

        ApplySearchFilter()
    End Sub

    Private Sub txtSearchPrice_TextChanged(sender As Object, e As EventArgs) Handles txtSearchPrice.TextChanged
        ApplySearchFilter()
    End Sub

    Private Sub rbSearchAc_CheckedChanged(sender As Object, e As EventArgs) Handles rbSearchAc.CheckedChanged
        ApplySearchFilter()
    End Sub

    Private Sub rbSearchNac_CheckedChanged(sender As Object, e As EventArgs) Handles rbSearchNac.CheckedChanged
        ApplySearchFilter()
    End Sub

    ' ===== GRID SYNC =====
    Private Sub dgvRooms_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRooms.RowEnter
        recpointer = e.RowIndex
        display()

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "Closing..") = MsgBoxResult.Yes Then
            main_form.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtSearchCapacity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearchCapacity.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSearchCapacity_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCapacity.TextChanged

        ApplySearchFilter()
    End Sub

    Private Sub cmbSearchClassicification_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearchClassicification.SelectedIndexChanged

        ApplySearchFilter()
    End Sub

    Private Sub TOBOTTOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOBOTTOMToolStripMenuItem.Click
        dgvRooms.Rows(recpointer).Selected = False
        recpointer = dgvRooms.RowCount - 2
        dgvRooms.Rows(recpointer).Selected = True
        display()


    End Sub

    Private Sub PREVIOUSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PREVIOUSToolStripMenuItem.Click
        If recpointer > 0 Then
            dgvRooms.Rows(recpointer).Selected = False
            recpointer = recpointer - 1
            dgvRooms.Rows(recpointer).Selected = True
            display()

        End If

    End Sub

    Private Sub NEXTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEXTToolStripMenuItem.Click
        Dim trec = dgvRooms.RowCount - 1
        If recpointer < trec Then
            dgvRooms.Rows(recpointer).Selected = False
            recpointer = recpointer + 1
            dgvRooms.Rows(recpointer).Selected = True
            display()


        End If


    End Sub

    Private Sub TOTOPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TOTOPToolStripMenuItem.Click
        dgvRooms.Rows(recpointer).Selected = False
        recpointer = 0
        dgvRooms.Rows(recpointer).Selected = True
        display()

    End Sub

    Private Sub cmdSearch_Click(sender As Object, e As EventArgs) Handles cmdSearch.Click

        Dim x As String = InputBox("Enter Room ID to search:", "Search Room")
        If String.IsNullOrWhiteSpace(x) Then Exit Sub

        x = x.Replace("'", "''")

        Dim filters As New List(Of String)

        ' Existing filters
        If dv.RowFilter <> "" Then
            filters.Add(dv.RowFilter)
        End If

        ' RoomID filter
        filters.Add($"RoomID LIKE '%{x}%'")

        dv.RowFilter = String.Join(" AND ", filters)

        If dv.Count > 0 Then
            recpointer = 0
            display()
            cmdCancel.Enabled = True
        Else
            MsgBox("No matching room found.", MsgBoxStyle.Information, "Unavailable")
            dv.RowFilter = ""
        End If
    End Sub

    Private Sub EXCELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXCELToolStripMenuItem.Click
        Dim printer As New print()
        Dim filepath As String = Application.StartupPath & "\reports\rooms.xlsx"
        Dim connectionString As String = ("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\resortDb.mdb")
        printer.ImportRoomsToExcel(filepath, connectionString)

    End Sub

    Private Sub SetDatabaseLogon(report As ReportDocument, server As String, database As String, userId As String, password As String)
        Dim logonInfo As New TableLogOnInfo()
        Dim connectionInfo As New ConnectionInfo()

        ' Set the new connection details
        connectionInfo.ServerName = server
        connectionInfo.DatabaseName = database
        connectionInfo.UserID = userId
        connectionInfo.Password = password

        ' Loop through each table in the report and apply the connection info
        For Each table As Table In report.Database.Tables
            logonInfo = table.LogOnInfo
            logonInfo.ConnectionInfo = connectionInfo
            table.ApplyLogOnInfo(logonInfo)

            ' Check table connectivity
            If Not table.TestConnectivity() Then
                MessageBox.Show("Test connectivity failed for table: " & table.Name)
                table.Location = database & ".dbo." & table.Location.Substring(table.Location.LastIndexOf(".") + 1)
            End If
        Next

        ' Apply connection info to subreports if any
        For Each subreport As ReportDocument In report.Subreports
            For Each table As Table In subreport.Database.Tables
                logonInfo = table.LogOnInfo
                logonInfo.ConnectionInfo = connectionInfo
                table.ApplyLogOnInfo(logonInfo)
            Next
        Next
    End Sub

    Private Sub LoadReport()
        Try
            ' Initialize the Crystal Report document
            Dim crystal As New ReportDocument()
            crystal.Load(Application.StartupPath & "\CrystalReport_Rooms.rpt")

            ' Set up connection details for the report
            Dim server As String = "" ' Your server name
            Dim database As String = Application.StartupPath & "\database\resortDb.mdb" ' Database path (Access in this case)
            Dim userId As String = "" ' Access uses empty string for UserID
            Dim password As String = "" ' Access uses empty string for Password

            ' Call SetDatabaseLogon to apply the database connection settings
            SetDatabaseLogon(crystal, server, database, userId, password)

            ' Set the report source to the CrystalReportViewer
            crystal_form.crptView.ReportSource = crystal
            crystal_form.crptView.Refresh()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
        End Try
    End Sub

    Private Sub CRYSTALREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CRYSTALREPORTToolStripMenuItem.Click
        crystal_form.Show()
        LoadReport()
        crystal_form.crptView.Refresh()
        xbtn = "Rooms"
        Me.Hide()
    End Sub

    Private Sub lnkbrowse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkbrowse.LinkClicked
        If txtRoomID.Text.Trim = "" Then
            MsgBox("Room ID is required.", MsgBoxStyle.Information)
            Exit Sub
        End If

        ofd.FileName = ""
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim imgFolder As String = Application.StartupPath & "\images\"
                Dim destPath As String = imgFolder & txtRoomID.Text.Trim & ".jpg"

                ' Ensure folder exists
                If Not IO.Directory.Exists(imgFolder) Then
                    IO.Directory.CreateDirectory(imgFolder)
                End If

                Using original As Image = Image.FromFile(ofd.FileName)
                    Using squareImg As Image = CropToSquare(original)
                        squareImg.Save(destPath, Imaging.ImageFormat.Jpeg)
                    End Using
                End Using

                LoadRoomImage(txtRoomID.Text.Trim)

            Catch ex As Exception
                MsgBox("Image error: " & ex.Message)
            End Try
        End If
    End Sub

    Sub LoadRoomImage(roomId As String)
        Try
            picbox.Image = Nothing

            Dim imgPath As String = Application.StartupPath & "\images\" & roomId & ".jpg"

            If IO.File.Exists(imgPath) Then
                Using fs As New IO.FileStream(imgPath, IO.FileMode.Open, IO.FileAccess.Read)
                    picbox.Image = Image.FromStream(fs)
                End Using
            End If

        Catch ex As Exception
            picbox.Image = Nothing
        End Try
    End Sub

    Function CropToSquare(src As Image) As Image
        Dim size As Integer = Math.Min(src.Width, src.Height)

        Dim x As Integer = (src.Width - size) \ 2
        Dim y As Integer = (src.Height - size) \ 2

        Dim cropRect As New Rectangle(x, y, size, size)

        Dim bmp As New Bitmap(size, size)
        Using g As Graphics = Graphics.FromImage(bmp)
            g.DrawImage(src, New Rectangle(0, 0, size, size), cropRect, GraphicsUnit.Pixel)
        End Using

        Return bmp
    End Function
    Sub LoadRoomClassifications(ByVal cbo As ComboBox)

        Dim connStr As String =
            "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" &
            Application.StartupPath & "\database\resortDb.mdb"

        Using conn As New OleDb.OleDbConnection(connStr)
            Using cmd As New OleDb.OleDbCommand(
                "SELECT RoomClassName FROM RoomClassifications", conn)

                conn.Open()
                Using rdr As OleDb.OleDbDataReader = cmd.ExecuteReader()

                    cbo.Items.Clear()

                    While rdr.Read()
                        cbo.Items.Add(rdr("RoomClassName").ToString())
                    End While

                End Using
            End Using
        End Using

    End Sub

End Class
