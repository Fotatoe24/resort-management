
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class user_form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If emercency = "parenagdebug" Then
            opendb_user()
            sqlquery_user()
            dguser.DataSource = dbds2.Tables("users")
            mnudisable()
            enableaccess()
            display()
            MsgBox("You can now replace the password or add new user", MsgBoxStyle.Information, "Emergency Access!!!")
        Else

            opendb_user()
            sqlquery_user()
            dguser.DataSource = dbds2.Tables("users")
            lock()
            display()
            browsecmd.Visible = False

        End If
    End Sub

    Sub txtclear()

        txtuid.Text = ""
        txtuname.Text = ""
        txtpw.Text = ""
        txtpost.Text = ""
        cbxpriv.Text = ""
        txtrpw.Text = ""

    End Sub
    Sub mnudisable()
        savecmd.Enabled = True
        newusercmd.Enabled = True
        editcmd.Enabled = False
        Printcmd.Enabled = False
        cancelcmd.Enabled = False
        srchcmd.Enabled = False
        delcmd.Enabled = False
        browsecmd.Visible = False
    End Sub

    Sub enableaccess()

        txtuid.ReadOnly = True
        txtuname.ReadOnly = True
        txtpw.ReadOnly = False
        txtrpw.ReadOnly = False
        txtpost.ReadOnly = True
        cbxpriv.Enabled = True

    End Sub
    Sub lock()

        txtuid.ReadOnly = True
        txtuname.ReadOnly = True
        txtpw.ReadOnly = True
        txtpost.ReadOnly = True
        cbxpriv.Enabled = True
        txtrpw.ReadOnly = True

    End Sub
    Sub unlock()

        txtuid.ReadOnly = False
        txtuname.ReadOnly = False
        txtpw.ReadOnly = False
        txtrpw.ReadOnly = False
        txtpost.ReadOnly = False

    End Sub
    Sub display()
        Try
            txtuid.Text = dbds2.Tables("users").Rows(recpointer2).Item("userID")
            txtuname.Text = dbds2.Tables("users").Rows(recpointer2).Item("username")
            txtpost.Text = dbds2.Tables("users").Rows(recpointer2).Item("position")
            cbxpriv.Text = dbds2.Tables("users").Rows(recpointer2).Item("privilege")

            LoadRoomImage(txtuid.Text.Trim)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub totopcmd_Click(sender As Object, e As EventArgs) Handles totopcmd.Click
        dguser.Rows(recpointer2).Selected = False
        recpointer2 = 0
        dguser.Rows(recpointer2).Selected = True
        display()
    End Sub

    Private Sub nxtcmd_Click(sender As Object, e As EventArgs) Handles nxtcmd.Click
        If recpointer2 < trec2 Then
            dguser.Rows(recpointer2).Selected = False
            recpointer2 = recpointer2 + 1
            dguser.Rows(recpointer2).Selected = True
            display()

        End If
    End Sub

    Private Sub prevcmd_Click(sender As Object, e As EventArgs) Handles prevcmd.Click
        If recpointer2 > 0 Then
            dguser.Rows(recpointer2).Selected = False
            recpointer2 = recpointer2 - 1
            dguser.Rows(recpointer2).Selected = True
            display()


        End If
    End Sub

    Private Sub tobttmcmd_Click(sender As Object, e As EventArgs) Handles tobttmcmd.Click
        dguser.Rows(recpointer2).Selected = False
        recpointer2 = trec2
        dguser.Rows(recpointer2).Selected = True
        display()
    End Sub

    Function GenerateUserID() As String
        Dim prefix As String = "rms-"
        Dim currentCount As Integer = dbds2.Tables("users").Rows.Count + 1
        Dim newID As String = prefix & currentCount.ToString("D5")
        Return newID
    End Function

    Private Sub newusercmd_Click(sender As Object, e As EventArgs) Handles newusercmd.Click
        sw = True
        dguser.Enabled = False
        Picbox.Visible = True

        db2.Close()

        browsecmd.Visible = True
        txtrpw.Visible = True
        lblrpw.Visible = True
        cbxpriv.Enabled = True
        savecmd.Enabled = True
        cancelcmd.Enabled = True
        Picbox.Image = Nothing
        unlock()
        txtuid.Focus()
        txtclear()
        txtuid.Text = GenerateUserID()
        txtuid.ReadOnly = True

    End Sub

    Private Sub savecmd_Click(sender As Object, e As EventArgs) Handles savecmd.Click
        If txtpw.Text.Trim = txtrpw.Text.Trim Then

            If sw = True Then
                If MsgBox("The data(s) are now being stored in the database...", MsgBoxStyle.DefaultButton1 + vbYesNo, "saving...") = MsgBoxResult.Yes Then
                    db2.Open()
                    dbcmd = New OleDb.OleDbCommand("INSERT INTO users([userID],[username],[password],[position],[privilege]) VALUES ('" & txtuid.Text.Trim & "','" & txtuname.Text.Trim & "','" & txtpw.Text.Trim & "','" & txtpost.Text.Trim & "','" & cbxpriv.Text.Trim & "')", db2)
                    dbcmd.ExecuteNonQuery()
                    sqlquery_user()
                    lock()

                    dguser.Enabled = True
                    Picbox.Visible = True
                    dguser.DataSource = dbds2.Tables("users")

                Else
                    txtuid.Focus()
                End If
            End If

            If sw = False Then
                If MsgBox("Do you want to save the changes you made to its database?", MsgBoxStyle.DefaultButton1 + vbYesNo, "updating...") = MsgBoxResult.Yes Then
                    db2.Open()
                    dbcmd = New OleDb.OleDbCommand("UPDATE users SET [password]= '" & txtpw.Text.Trim & "'  WHERE [userID]Like '" & txtuid.Text.Trim & "'", db2)
                    dbcmd.ExecuteNonQuery()
                    sqlquery_user()
                    lock()

                    dguser.Enabled = True
                    Picbox.Visible = True
                    dguser.DataSource = dbds2.Tables("users")
                Else


                End If
            End If
        Else
            MsgBox("Kindly re-type the password properly!!", , "reminder!!!")
            txtpw.Focus()
            txtpw.Clear()
            txtrpw.Clear()

        End If

    End Sub

    Private Sub editcmd_Click(sender As Object, e As EventArgs) Handles editcmd.Click
        sw = False
        txtpw.ReadOnly = False
        txtrpw.ReadOnly = False
        txtpw.Clear()
        txtrpw.Clear()
        savecmd.Enabled = True
        cancelcmd.Enabled = True
        dguser.Enabled = False
        cbxpriv.Enabled = True
        Picbox.Visible = True
        browsecmd.Visible = True
        txtpw.Focus()
        Picbox.Refresh()

    End Sub

    Private Sub srchcmd_Click(sender As Object, e As EventArgs) Handles srchcmd.Click

        Dim x As String
        x = InputBox("Enter User ID to Search : ")

        If x.Length < 1 Then
        Else
            Try
                Table1 = New OleDb.OleDbDataAdapter("SELECT * FROM users WHERE [userID] like '%" & x.Trim & "%'", db2)
                dbds2 = New DataSet
                Table1.Fill(dbds2, "users")
                If dbds2.Tables("users").Rows.Count > 0 Then
                    recpointer2 = 0
                    trec2 = CInt(dbds2.Tables("users").Rows.Count) - 1
                    dguser.DataSource = dbds2.Tables("users")
                    cancelcmd.Enabled = True
                    dguser.Columns("Password").Visible = False
                Else
                    MsgBox("there is no exixting data.",, "Unavailable")
                End If
            Catch ex As Exception
                MsgBox("An error occured.")
            Finally
                db2.Close()
            End Try
        End If
    End Sub

    Private Sub delcmd_Click(sender As Object, e As EventArgs) Handles delcmd.Click
        If MsgBox("If you'll continue the record will permanently deleted!!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "delete") = MsgBoxResult.Yes Then
            db2.Open()
            dbcmd = New OleDb.OleDbCommand("DELETE FROM users WHERE [userID] like '" & txtuid.Text.Trim & "'", db2)
            dbcmd.ExecuteNonQuery()
            sqlquery_user()
            dguser.DataSource = dbds2.Tables("users")
            txtclear()
        End If
    End Sub

    Private Sub cancelcmd_Click(sender As Object, e As EventArgs) Handles cancelcmd.Click

        dguser.Enabled = True
        lock()
        Picbox.Visible = True
        browsecmd.Visible = False
        savecmd.Enabled = False
        cancelcmd.Enabled = False
        txtclear()

        sqlquery_user()
        dguser.DataSource = dbds2.Tables("users")

    End Sub

    Private Sub browsecmd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles browsecmd.LinkClicked
        If txtuid.Text.Trim = "" Then
            MsgBox("user ID is required.", MsgBoxStyle.Information)
            Exit Sub
        End If

        ofd.FileName = ""
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim imgFolder As String = Application.StartupPath & "\stocks\"
                Dim destPath As String = imgFolder & txtuid.Text.Trim & ".jpg"

                ' Ensure folder exists
                If Not IO.Directory.Exists(imgFolder) Then
                    IO.Directory.CreateDirectory(imgFolder)
                End If

                Using original As Image = Image.FromFile(ofd.FileName)
                    Using squareImg As Image = CropToSquare(original)
                        squareImg.Save(destPath, Imaging.ImageFormat.Jpeg)
                    End Using
                End Using

                LoadRoomImage(txtuid.Text.Trim)

            Catch ex As Exception
                MsgBox("Image error: " & ex.Message)
            End Try
        End If
    End Sub


    Sub LoadRoomImage(userID As String)
        Try
            Picbox.Image = Nothing

            Dim imgPath As String = Application.StartupPath & "\users\" & userID & ".jpg"

            If IO.File.Exists(imgPath) Then
                Using fs As New IO.FileStream(imgPath, IO.FileMode.Open, IO.FileAccess.Read)
                    Picbox.Image = Image.FromStream(fs)
                End Using
            End If

        Catch ex As Exception
            Picbox.Image = Nothing
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

    Private Sub extcmd_Click(sender As Object, e As EventArgs) Handles extcmd.Click
        If MsgBox("This action will close the current window? Would you like to proceed?", MsgBoxStyle.YesNo, "closing...") = MsgBoxResult.Yes Then
            If emercency = "parenagdebug" Then
                log_in_form.Show()
                emercency = ""
                Me.Close()
            Else
                main_form.Show()
                Me.Close()
            End If
        Else
            txtuid.Focus()
        End If
    End Sub

    Private Sub dguser_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dguser.RowEnter
        recpointer2 = e.RowIndex
        display()

    End Sub

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcelToolStripMenuItem.Click
        Dim printer As New print()
        Dim filepath As String = Application.StartupPath & "\reports\userlist.xlsx"
        Dim connectionString As String = ("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\resortDb.mdb")
        printer.ImportUsrToExcel(filepath, connectionString)

    End Sub

    Private Sub CrystalReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrystalReportToolStripMenuItem.Click
        crystal_form.Show()
        LoadReport()
        crystal_form.crptView.Refresh()
        xbtn = "User"
        Me.Hide()
    End Sub

    '   Private Sub LoadReport()
    '  Try
    '         ' Initialize the Crystal Report document
    '
    '       crystal.Load(Application.StartupPath & "\CrptUser.rpt")
    '
    '' Dynamic database connection (for example: Access database)
    '  Dim connectionInfo As New ConnectionInfo()
    '         connectionInfo.DatabaseName = ""
    '        connectionInfo.ServerName = Application.StartupPath & "\database\Database1.mdb"
    '       connectionInfo.UserID = "" ' Leave empty for Access
    '      connectionInfo.Password = "" ' Leave empty for Access
    '
    ' Apply the connection settings to all tables in the report
    'For Each table As Table In crystal.Database.Tables
    'Dim tableLogOnInfo As TableLogOnInfo = table.LogOnInfo
    '           tableLogOnInfo.ConnectionInfo = connectionInfo
    '          table.ApplyLogOnInfo(tableLogOnInfo)
    'Next

    ' Set the report source to the CrystalReportViewer

    '       Crystalrpt_Form.crptView.ReportSource = crystal
    '      Crystalrpt_Form.crptView.Refresh()
    '
    'Catch ex As Exception
    ''        MessageBox.Show("Error: " & ex.Message)
    'End Try
    'End Sub

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
            crystal.Load(Application.StartupPath & "\CrptUser.rpt")

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
End Class

