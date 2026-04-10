
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class resto_bar
    Private Sub Stock_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb_stocks()
        sqlquery_stocks()
        lock()


        dgstock.DataSource = dbds3.Tables("Stocks")
        svcmd.Enabled = False
        cnlcmd.Enabled = False
        browsepic.Visible = False
        LoadfoodTypes(cbxCategory)
        LoadfoodTypes(cbxFilterCategory)
    End Sub

    Sub txtclear()

        txtbrcd.Text = ""
        txtiname.Text = ""
        txtdes.Text = ""
        txtquan.Text = ""
        txtcrit.Text = ""
        cbxCategory.Text = ""
        txtsellp.Text = ""

    End Sub

    Sub lock()

        txtbrcd.ReadOnly = True
        txtiname.ReadOnly = True
        txtdes.ReadOnly = True
        txtquan.ReadOnly = True
        txtcrit.ReadOnly = True
        cbxCategory.Enabled = False
        txtsellp.ReadOnly = True

    End Sub
    Sub unlock()

        txtbrcd.ReadOnly = False
        txtiname.ReadOnly = False
        txtdes.ReadOnly = False
        txtquan.ReadOnly = False
        txtcrit.ReadOnly = False
        cbxCategory.Enabled = True
        txtsellp.ReadOnly = False

    End Sub

    Sub display()
        Try
            txtbrcd.Text = dbds3.Tables("Stocks").Rows(recpointer2).Item("Stock ID")
            txtiname.Text = dbds3.Tables("Stocks").Rows(recpointer2).Item("Item Name")
            txtdes.Text = dbds3.Tables("Stocks").Rows(recpointer2).Item("Description")
            txtquan.Text = dbds3.Tables("Stocks").Rows(recpointer2).Item("Quantity")
            txtcrit.Text = dbds3.Tables("Stocks").Rows(recpointer2).Item("Critical level")
            cbxCategory.Text = dbds3.Tables("Stocks").Rows(recpointer2).Item("Category")
            txtsellp.Text = dbds3.Tables("Stocks").Rows(recpointer2).Item("Selling price")


            LoadRoomImage(txtbrcd.Text.Trim)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub totopcmd_Click(sender As Object, e As EventArgs) Handles totopcmd.Click
        dgstock.Rows(recpointer2).Selected = False
        recpointer2 = 0
        dgstock.Rows(recpointer2).Selected = True
        display()
    End Sub

    Private Sub nextcmd_Click(sender As Object, e As EventArgs) Handles nextcmd.Click
        If recpointer2 < trec2 Then
            dgstock.Rows(recpointer2).Selected = False
            recpointer2 = recpointer2 + 1
            dgstock.Rows(recpointer2).Selected = True
            display()
        End If
    End Sub

    Private Sub prevcmd_Click(sender As Object, e As EventArgs) Handles prevcmd.Click
        If recpointer2 > 0 Then
            dgstock.Rows(recpointer2).Selected = False
            recpointer2 = recpointer2 - 1
            dgstock.Rows(recpointer2).Selected = True
            display()

        End If
    End Sub

    Private Sub tobttmcmd_Click(sender As Object, e As EventArgs) Handles tobttmcmd.Click
        dgstock.Rows(recpointer2).Selected = False
        recpointer2 = trec2
        dgstock.Rows(recpointer2).Selected = True
        display()
    End Sub

    Private Sub newitemcmd_Click(sender As Object, e As EventArgs) Handles nwitemcmd.Click
        'okay na
        sw2 = True
        dgstock.Enabled = False
        Picbox.Visible = True
        Picbox.Image = Nothing
        db3.Close()
        browsepic.Visible = True
        svcmd.Enabled = True
        cnlcmd.Enabled = True
        txtclear()
        unlock()
        txtbrcd.Text = GenerateStockID()
    End Sub

    Private Sub savecmd_Click(sender As Object, e As EventArgs) Handles svcmd.Click
        'okay na
        If sw2 = True Then
            If MsgBox("The data are now being stored..", MsgBoxStyle.DefaultButton1 + vbYesNo, "saving...") = MsgBoxResult.Yes Then
                db3.Open()
                dbcmd2 = New OleDb.OleDbCommand("INSERT INTO Stocks([Stock ID],[Item Name],[Description],[Quantity],[Category],[Selling price],[Critical level]) VALUES ('" & txtbrcd.Text.Trim & "','" & txtiname.Text.Trim & "','" & txtdes.Text.Trim & "','" & txtquan.Text.Trim & "','" & cbxCategory.Text.Trim & "','" & txtsellp.Text.Trim & "','" & txtcrit.Text.Trim & "')", db3)
                dbcmd2.ExecuteNonQuery()
                sqlquery_stocks()
                lock()

                Picbox.Visible = True
                dgstock.DataSource = dbds3.Tables("Stocks")

            End If
        End If
        'okay
        If sw2 = False Then
            If MsgBox("Do you want to save the changes you made?", MsgBoxStyle.DefaultButton1 + vbYesNo, "updating...") = MsgBoxResult.Yes Then
                db3.Open()
                dbcmd2 = New OleDb.OleDbCommand("UPDATE Stocks SET [Description]= '" & txtdes.Text.Trim & "', [Quantity] = '" & txtquan.Text.Trim & "', [Critical level] = '" & txtcrit.Text.Trim & "', [Category] = '" & cbxCategory.Text.Trim & "',[Selling price] = '" & txtsellp.Text.Trim & "'  WHERE [Stock ID] Like '" & txtbrcd.Text.Trim & "'", db3)
                dbcmd2.ExecuteNonQuery()
                sqlquery_stocks()
                lock()
                dgstock.Enabled = True
                Picbox.Visible = True
                dgstock.DataSource = dbds3.Tables("Stocks")
            Else


            End If
        End If

    End Sub

    Private Sub editcmd_Click(sender As Object, e As EventArgs) Handles edtcmd.Click
        'okay na
        sw2 = False
        txtbrcd.ReadOnly = True
        txtiname.ReadOnly = True
        dgstock.Enabled = False
        Picbox.Visible = True
        browsepic.Visible = True
        unlock()
        txtbrcd.ReadOnly = True
        txtiname.ReadOnly = True
        svcmd.Enabled = True
        cnlcmd.Enabled = True

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles searchcmd.Click
        'okay na
        Dim x As String
        x = InputBox("Enter Stock Name to Search :    ")

        If x.Length < 1 Then
        Else
            Try
                tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM Stocks WHERE [Item Name] Like '%" & x.Trim & "%'", db3)
                dbds3 = New DataSet
                tblstock.Fill(dbds3, "Stocks")
                If dbds3.Tables("Stocks").Rows.Count > 0 Then
                    recpointer2 = 0
                    trec2 = CInt(dbds3.Tables("Stocks").Rows.Count) - 1
                    dgstock.DataSource = dbds3.Tables("Stocks")
                    cnlcmd.Enabled = True

                Else
                    MsgBox("there is no existing data.",)
                End If
            Catch ex As Exception
                MsgBox("An error occured.")
            Finally
                db3.Close()
            End Try
        End If
    End Sub

    Private Sub delcmd_Click(sender As Object, e As EventArgs) Handles delcmd.Click
        'okay na
        If MsgBox("If you'll continue the record will permanently deleted!!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, "delete") = MsgBoxResult.Yes Then
            db3.Open()
            dbcmd2 = New OleDb.OleDbCommand("DELETE FROM Stocks WHERE [Item Name] like '" & txtiname.Text.Trim & "'", db3)
            dbcmd2.ExecuteNonQuery()
            sqlquery_stocks()
            dgstock.DataSource = dbds3.Tables("Stocks")
        End If
    End Sub

    Private Sub cancelcmd_Click(sender As Object, e As EventArgs) Handles cnlcmd.Click
        'okay na 
        dgstock.Enabled = True
        lock()
        Picbox.Visible = True
        browsepic.Visible = False
        svcmd.Enabled = False
        cnlcmd.Enabled = False
        txtclear()
        sqlquery_stocks()
        dgstock.DataSource = dbds3.Tables("Stocks")

    End Sub

    Private Sub browsecmd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles browsepic.LinkClicked
        If txtbrcd.Text.Trim = "" Then
            MsgBox("user ID is required.", MsgBoxStyle.Information)
            Exit Sub
        End If

        ofd.FileName = ""
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim imgFolder As String = Application.StartupPath & "\stocks\"
                Dim destPath As String = imgFolder & txtbrcd.Text.Trim & ".jpg"

                ' Ensure folder exists
                If Not IO.Directory.Exists(imgFolder) Then
                    IO.Directory.CreateDirectory(imgFolder)
                End If

                Using original As Image = Image.FromFile(ofd.FileName)
                    Using squareImg As Image = CropToSquare(original)
                        squareImg.Save(destPath, Imaging.ImageFormat.Jpeg)
                    End Using
                End Using

                LoadRoomImage(txtbrcd.Text.Trim)

            Catch ex As Exception
                MsgBox("Image error: " & ex.Message)
            End Try
        End If
    End Sub


    Sub LoadRoomImage(userID As String)
        Try
            Picbox.Image = Nothing

            Dim imgPath As String = Application.StartupPath & "\stocks\" & userID & ".jpg"

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
        'okay na
        If MsgBox("This action will close the current window? Would you like to proceed?", MsgBoxStyle.YesNo, "closing...") = MsgBoxResult.Yes Then

            Me.Hide()
            main_form.Show()

        Else
            'cmdclose.Focus()
        End If
    End Sub

    Private Sub dgstock_RowEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgstock.RowEnter
        'okay na
        recpointer2 = e.RowIndex
        display()
    End Sub

    Private Sub excelprint_Click(sender As Object, e As EventArgs) Handles excelprint.Click
        Dim printer As New print()
        Dim filepath As String = Application.StartupPath & "\reports\stocklist.xlsx"
        Dim connectionString As String = ("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\resortDb.mdb")
        printer.ImportStockToExcel(filepath, connectionString)
    End Sub

    Private Sub Crystalprint_Click(sender As Object, e As EventArgs) Handles Crystalprint.Click
        crystal_form.Show()
        LoadReport()
        xbtn = "stocks"
        Me.Hide()
    End Sub

    Function GenerateStockID() As String
        Dim newID As String = "STK0001"

        Try
            db3.Open()

            Dim cmd As New OleDb.OleDbCommand("SELECT MAX([Stock ID]) FROM Stocks", db3)
            Dim result = cmd.ExecuteScalar()

            If Not IsDBNull(result) Then
                Dim lastID As String = result.ToString()
                Dim number As Integer = CInt(lastID.Substring(3)) + 1
                newID = "STK" & number.ToString("0000")
            End If

        Catch ex As Exception
            MsgBox("Error generating Stock ID")
        Finally
            db3.Close()
        End Try

        Return newID
    End Function

    Private Sub LoadReport()
        Try
            ' Initialize the Crystal Report document

            crystal.Load(Application.StartupPath & "\Crptstocks.rpt")

            ' Dynamic database connection (for example: Access database)
            Dim connectionInfo As New ConnectionInfo()
            connectionInfo.DatabaseName = ""
            connectionInfo.ServerName = Application.StartupPath & "\database\resortDb.mdb"
            connectionInfo.UserID = "" ' Leave empty for Access
            connectionInfo.Password = "" ' Leave empty for Access

            ' Apply the connection settings to all tables in the report
            For Each table As Table In crystal.Database.Tables
                Dim tableLogOnInfo As TableLogOnInfo = table.LogOnInfo
                tableLogOnInfo.ConnectionInfo = connectionInfo
                table.ApplyLogOnInfo(tableLogOnInfo)
            Next

            ' Set the report source to the CrystalReportViewer

            crystal_form.crptView.ReportSource = crystal
            crystal_form.crptView.Refresh()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Sub FilterCategory()

        Try

            If cbxFilterCategory.Text = "All" Then
                sqlquery_stocks()
                dgstock.DataSource = dbds3.Tables("Stocks")
            Else

                tblstock = New OleDb.OleDbDataAdapter(
                "SELECT * FROM Stocks WHERE [Category] = '" & cbxFilterCategory.Text & "'", db3)

                dbds3 = New DataSet
                tblstock.Fill(dbds3, "Stocks")

                dgstock.DataSource = dbds3.Tables("Stocks")

            End If

        Catch ex As Exception
            MsgBox("Filter error.")
        End Try

    End Sub
    Sub LoadfoodTypes(ByVal cbo As ComboBox)

        Dim connStr As String =
        "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        Application.StartupPath & "\database\resortDb.mdb"

        Using conn As New OleDb.OleDbConnection(connStr)
            Using cmd As New OleDb.OleDbCommand(
            "SELECT foodCategoryName FROM foodCategory", conn)

                conn.Open()

                cbo.Items.Clear()

                'Add ALL option only for filter combobox
                If cbo Is cbxFilterCategory Then
                    cbo.Items.Add("All")
                End If

                Using rdr As OleDb.OleDbDataReader = cmd.ExecuteReader()

                    While rdr.Read()
                        cbo.Items.Add(rdr("foodCategoryName").ToString())
                    End While

                End Using
            End Using
        End Using

    End Sub

    Private Sub cbxFilterCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFilterCategory.SelectedIndexChanged
        FilterCategory()
    End Sub
End Class