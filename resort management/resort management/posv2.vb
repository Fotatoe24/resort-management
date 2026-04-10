Imports System.Data
Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class posv2
    Public OrderTable As DataTable
    Public dv As DataView
    Public bookingID As String

    Private Sub posv2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb_stocks()
        opendb_temp()
        LoadStockData()
        LoadItemTiles()
        lblTotal.Text = "₱ 0.00"
        Me.KeyPreview = True
        LoadfoodTypes(cbxCategory)


        dbtemp.Open()
        dbcmd3 = New OleDb.OleDbCommand("DELETE * FROM tbltemp", dbtemp)
        dbcmd3.ExecuteNonQuery()

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", dbtemp)
        da.Fill(dbdstemp, "tbltemp")

        dgvcart.DataSource = dbdstemp.Tables("tbltemp")
        dgvcart.Columns("Stock ID").Visible = False
        dgvcart.Columns("amount").Visible = False
        dgvcart.Columns("change").Visible = False
        dgvcart.Columns("Cashier Name").Visible = False
    End Sub

    Private Sub posv2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then

            If dgvcart.SelectedRows.Count = 0 Then
                MessageBox.Show("Please select an item in the cart first.")
                Exit Sub
            End If

            ' Get Stock ID from selected row
            Dim stockID As String =
        dgvcart.SelectedRows(0).Cells("Stock ID").Value.ToString()

            Dim qtyStr As String = InputBox("How many to deduct?")
            If Not IsNumeric(qtyStr) Then
                MessageBox.Show("Enter numeric quantity.")
                Exit Sub
            End If

            DeductItem(stockID, CInt(qtyStr))

        End If


        If e.KeyCode = Keys.Delete Then

            If dgvcart.SelectedRows.Count = 0 Then
                MessageBox.Show("Select item first.")
                Exit Sub
            End If

            Dim stockID As String =
        dgvcart.SelectedRows(0).Cells("Stock ID").Value.ToString()

            VoidItem(stockID)

        End If

        If e.KeyCode = Keys.F5 Then
            If MsgBox("Proceeding to Payment", MsgBoxStyle.YesNo, "Thank youu!!") = MsgBoxResult.Yes Then
                payment_Type.ShowDialog()
                If sw5 = True Then
                    Panel2.Enabled = True
                    txtamt.Focus()
                Else
                    chargetoguest()
                    Exit Sub
                End If
            Else
                payment_Type.Close()
                Panel2.Enabled = False
            End If
        End If


        If e.KeyCode = Keys.F2 Then

            If MessageBox.Show("Clear entire cart?", "Confirm",
                           MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()

                Dim cmd As New OleDb.OleDbCommand("DELETE FROM tbltemp", dbtemp)
                cmd.ExecuteNonQuery()

                RefreshCart()

            End If

        End If

        If e.KeyCode = Keys.Escape Then
            If MsgBox("By closing this transaction, the next user will be required to log in. Would you like to continue?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Logging - off") = MsgBoxResult.Yes Then
                Application.Restart()

            Else
                dgvcart.Focus()
            End If
            Exit Sub
        End If

        If e.Control AndAlso e.KeyCode = Keys.X Then
            ClearSearchFilters()
        End If


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
                If cbo Is cbxCategory Then
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



    Sub LoadItemTiles(Optional view As DataView = Nothing)

        If view Is Nothing Then view = dv
        flp.Controls.Clear()

        For Each row As DataRowView In view

            ' Panel container
            Dim pnl As New Panel With {
            .Size = New Size(430, 150),
            .Margin = New Padding(5),
            .BorderStyle = BorderStyle.FixedSingle,
            .Cursor = Cursors.Hand,
            .Tag = row("Stock ID").ToString()
        }

            Dim quantity As Integer = CInt(row("Quantity"))
            Dim critical As Integer = CInt(row("Critical level"))

            ' Stock Status Colors
            If quantity <= 0 Then
                pnl.BackColor = Color.LightGray
            ElseIf quantity <= critical Then
                pnl.BackColor = Color.MistyRose
            Else
                pnl.BackColor = Color.White
            End If

            ' ===== IMAGE on LEFT =====
            Dim pic As New PictureBox With {
            .Size = New Size(130, 130),
            .Location = New Point(10, 10),
            .SizeMode = PictureBoxSizeMode.Zoom,
            .BackColor = Color.WhiteSmoke,
            .BorderStyle = BorderStyle.FixedSingle,
            .Cursor = Cursors.Hand,
            .Tag = row("Stock ID").ToString()
        }

            Dim img As Image = LoadItemImage(row("Stock ID").ToString())
            If img IsNot Nothing Then
                pic.Image = img
            Else
                pic.BackColor = Color.Gainsboro
                Dim lblNoImg As New Label With {
                .Text = "NO IMAGE",
                .Dock = DockStyle.Fill,
                .TextAlign = ContentAlignment.MiddleCenter,
                .Font = New Font("Segoe UI", 10, FontStyle.Italic),
                .ForeColor = Color.DimGray
            }
                pic.Controls.Add(lblNoImg)
            End If

            ' ===== TEXT on RIGHT =====
            Dim xText As Integer = 150
            Dim yText As Integer = 15

            Dim lblName As New Label With {
            .Text = row("Item Name").ToString(),
            .Font = New Font("Segoe UI", 14, FontStyle.Bold),
            .Location = New Point(xText, yText),
            .AutoSize = True
        }

            yText += lblName.Height + 5

            Dim lblDesc As New Label With {
            .Text = row("Description").ToString(),
            .Font = New Font("Segoe UI", 10),
            .Location = New Point(xText, yText),
            .Size = New Size(280, 30)
        }

            yText += lblDesc.Height + 2

            Dim lblCategory As New Label With {
            .Text = row("Category").ToString() & " | Stock: " & row("Quantity").ToString(),
            .Font = New Font("Segoe UI", 10, FontStyle.Italic),
            .Location = New Point(xText, yText),
            .AutoSize = True,
            .ForeColor = Color.Gray
        }

            xText += lblCategory.Width + 50
            yText += lblCategory.Height + 2
            Dim lblPrice As New Label With {
            .Text = "₱ " & row("Selling price").ToString(),
            .Font = New Font("Segoe UI", 16, FontStyle.Bold),
            .Location = New Point(xText, yText),
            .AutoSize = True,
            .ForeColor = Color.Green
        }

            ' Add controls to panel
            pnl.Controls.AddRange({pic, lblName, lblDesc, lblCategory, lblPrice})

            ' Click events
            AddHandler pnl.Click, AddressOf ItemTile_Click
            AddHandler pic.Click, AddressOf ItemTile_Click
            AddHandler lblName.Click, AddressOf ItemTile_Click

            flp.Controls.Add(pnl)

        Next

    End Sub




    Sub LoadStockData()

        Dim sql As String =
        "SELECT [Stock ID], [Item Name], Description, Quantity, Category, " &
        "[Selling price], [Critical level] FROM Stocks"

        Dim da As New OleDb.OleDbDataAdapter(sql, db3)
        Dim ds As New DataSet()
        da.Fill(ds, "Stocks")

        OrderTable = ds.Tables("Stocks")
        dv = New DataView(OrderTable)

    End Sub



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
    Sub ItemTile_Click(sender As Object, e As EventArgs)

        If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()

        Dim ctrl As Control = CType(sender, Control)

        While ctrl IsNot Nothing AndAlso Not TypeOf ctrl Is Panel
            ctrl = ctrl.Parent
        End While

        If ctrl Is Nothing OrElse ctrl.Tag Is Nothing Then Exit Sub

        Dim stockID As String = ctrl.Tag.ToString()

        ' Get stock row
        Dim stockRow As DataRow = OrderTable.Select("[Stock ID] = '" & stockID & "'").FirstOrDefault()
        If stockRow Is Nothing Then Exit Sub

        Dim quantityInStock As Integer = CInt(stockRow("Quantity"))

        If quantityInStock <= 0 Then
            MessageBox.Show("Item is out of stock.", "Unavailable")
            Exit Sub
        End If

        ' ===== ASK USER FOR QUANTITY =====
        Dim qtyStr As String = InputBox("Enter quantity:", "Quantity")

        If String.IsNullOrWhiteSpace(qtyStr) Then Exit Sub

        If Not IsNumeric(qtyStr) Then
            MessageBox.Show("Please enter a valid number.")
            Exit Sub
        End If

        Dim qtyToAdd As Integer = CInt(qtyStr)

        If qtyToAdd <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.")
            Exit Sub
        End If

        If qtyToAdd > quantityInStock Then
            MessageBox.Show("Not enough stock available. Only " & quantityInStock & " left.")
            Exit Sub
        End If

        Dim itemName As String = stockRow("Item Name").ToString()
        Dim price As Decimal = CDec(stockRow("Selling price"))

        ' Check if item already exists in cart
        Dim checkCmd As New OleDb.OleDbCommand(
        "SELECT Quantity FROM tbltemp WHERE [Stock ID] = ?", dbtemp)
        checkCmd.Parameters.AddWithValue("?", stockID)

        Dim existingQtyObj = checkCmd.ExecuteScalar()

        If existingQtyObj IsNot Nothing Then

            Dim currentQty As Integer = CInt(existingQtyObj)
            Dim newQty As Integer = currentQty + qtyToAdd

            If newQty > quantityInStock Then
                MessageBox.Show("Not enough stock available.")
                Exit Sub
            End If

            Dim updateCmd As New OleDb.OleDbCommand(
            "UPDATE tbltemp SET Quantity = ?, Total = ? WHERE [Stock ID] = ?", dbtemp)

            updateCmd.Parameters.AddWithValue("?", newQty)
            updateCmd.Parameters.AddWithValue("?", newQty * price)
            updateCmd.Parameters.AddWithValue("?", stockID)
            updateCmd.ExecuteNonQuery()

        Else

            Dim insertCmd As New OleDb.OleDbCommand(
            "INSERT INTO tbltemp ([Stock ID],[Description],[Quantity],[Unit Price],[Total],[Cashier Name]) 
             VALUES (?,?,?,?,?,?)", dbtemp)

            insertCmd.Parameters.AddWithValue("?", stockID)
            insertCmd.Parameters.AddWithValue("?", itemName)
            insertCmd.Parameters.AddWithValue("?", qtyToAdd)
            insertCmd.Parameters.AddWithValue("?", price)
            insertCmd.Parameters.AddWithValue("?", qtyToAdd * price)
            insertCmd.Parameters.AddWithValue("?", xname)
            insertCmd.ExecuteNonQuery()

        End If

        ' ===== Recompute total =====
        RefreshCart()

        ' Refresh stock tiles
        LoadStockData()
        LoadItemTiles()

    End Sub



    Function LoadItemImage(stockId As String) As Image
        Try
            Dim imgPath As String = Application.StartupPath & "\stocks\" & stockId & ".jpg"

            If IO.File.Exists(imgPath) Then
                Using fs As New IO.FileStream(imgPath, IO.FileMode.Open, IO.FileAccess.Read)
                    Return Image.FromStream(fs)
                End Using
            End If

        Catch ex As Exception
        End Try

        Return Nothing
    End Function
    Sub ApplySearchFilter()

        Dim filters As New List(Of String)

        ' ===== SEARCH BY ITEM NAME =====
        If Not String.IsNullOrWhiteSpace(txtIname.Text) Then
            Dim name As String = txtIname.Text.Replace("'", "''")
            filters.Add($"[Item Name] LIKE '%{name}%'")
        End If

        ' ===== FILTER BY CATEGORY =====
        If cbxCategory.SelectedIndex > -1 AndAlso cbxCategory.Text <> "All" Then
            Dim category As String = cbxCategory.Text.Replace("'", "''")
            filters.Add("[Category] = '" & category & "'")
        End If

        ' ===== SHOW ONLY AVAILABLE ITEMS (Optional) =====
        ' If you want to hide out-of-stock
        filters.Add("Quantity > 0")

        ' ===== APPLY FILTER =====
        If filters.Count > 0 Then
            dv.RowFilter = String.Join(" AND ", filters)
        Else
            dv.RowFilter = ""
        End If

        ' ===== Reload Tiles with filtered view =====
        LoadItemTiles(dv)

    End Sub


    Private Sub txtIname_TextChanged(sender As Object, e As EventArgs) Handles txtIname.TextChanged
        ApplySearchFilter()
    End Sub

    Private Sub cbxCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategory.SelectedIndexChanged
        ApplySearchFilter()
    End Sub

    Sub DeductItem(stockID As String, minusQty As Integer)

        If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()

        Dim cmd As New OleDb.OleDbCommand(
        "SELECT Quantity, [Unit Price] FROM tbltemp WHERE [Stock ID] = ?", dbtemp)
        cmd.Parameters.AddWithValue("?", stockID)

        Dim reader = cmd.ExecuteReader()

        If reader.Read() Then

            Dim currentQty As Integer = CInt(reader("Quantity"))
            Dim unitPrice As Decimal = CDec(reader("Unit Price"))

            Dim newQty As Integer = currentQty - minusQty

            If newQty <= 0 Then
                ' Remove item completely
                Dim delCmd As New OleDb.OleDbCommand(
                "DELETE FROM tbltemp WHERE [Stock ID] = ?", dbtemp)
                delCmd.Parameters.AddWithValue("?", stockID)
                delCmd.ExecuteNonQuery()
            Else
                ' Update quantity
                Dim newTotal As Decimal = newQty * unitPrice

                Dim updateCmd As New OleDb.OleDbCommand(
                "UPDATE tbltemp SET Quantity = ?, Total = ? WHERE [Stock ID] = ?", dbtemp)

                updateCmd.Parameters.AddWithValue("?", newQty)
                updateCmd.Parameters.AddWithValue("?", newTotal)
                updateCmd.Parameters.AddWithValue("?", stockID)
                updateCmd.ExecuteNonQuery()
            End If

        Else
            MessageBox.Show("Item not found in cart.")
        End If

        reader.Close()

        RefreshCart()

    End Sub

    Sub VoidItem(stockID As String)

        If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()

        Dim cmd As New OleDb.OleDbCommand(
        "DELETE FROM tbltemp WHERE [Stock ID] = ?", dbtemp)

        cmd.Parameters.AddWithValue("?", stockID)
        cmd.ExecuteNonQuery()

        RefreshCart()

    End Sub

    Sub RefreshCart()

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", dbtemp)
        dbdstemp.Tables("tbltemp").Clear()
        da.Fill(dbdstemp, "tbltemp")

        ' Recompute total
        Dim totalCmd As New OleDb.OleDbCommand(
        "SELECT SUM([Total]) FROM tbltemp", dbtemp)

        Dim totalObj = totalCmd.ExecuteScalar()

        If IsDBNull(totalObj) OrElse totalObj Is Nothing Then
            lblTotal.Text = "₱ 0.00"
        Else
            lblTotal.Text = "₱ " & Format(CDec(totalObj), "N2")
        End If

    End Sub
    Sub SaveTransaction()

        If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()

        dbcmd3 = New OleDb.OleDbCommand("UPDATE tbltemp SET [change] = '" & txtchange.Text.Trim & "', [amount] = '" & txtamt.Text.Trim & "',[Cashier Name] = '" & xname & "'", dbtemp)
        dbcmd3.ExecuteNonQuery()

        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", dbtemp)
        Dim ds As New DataSet()
        da.Fill(ds, "tbltemp")

        For Each row As DataRow In ds.Tables("tbltemp").Rows

            Dim stockID As String = row("Stock ID").ToString()
            Dim desc As String = row("Description").ToString()
            Dim qty As Integer = CInt(row("Quantity"))
            Dim unitPrice As Decimal = CDec(row("Unit Price"))
            Dim total As Decimal = CDec(row("Total"))

            ' INSERT INTO tbltran
            Dim insertCmd As New OleDb.OleDbCommand(
            "INSERT INTO tbltran 
            ([Stock ID],[Description],[Quantity],[Unit Price],[Total],[Date Tran],[Time Tran],[Cashier Name])
            VALUES (?,?,?,?,?,?,?,?)", dbtemp)

            insertCmd.Parameters.AddWithValue("?", stockID)
            insertCmd.Parameters.AddWithValue("?", desc)
            insertCmd.Parameters.AddWithValue("?", qty)
            insertCmd.Parameters.AddWithValue("?", unitPrice)
            insertCmd.Parameters.AddWithValue("?", total)
            insertCmd.Parameters.AddWithValue("?", Date.Now.Date)
            insertCmd.Parameters.AddWithValue("?", Date.Now.ToString("hh:mm:ss tt"))
            insertCmd.Parameters.AddWithValue("?", xname)

            insertCmd.ExecuteNonQuery()

            ' DEDUCT FROM STOCKS TABLE
            UpdateStockQuantity(stockID, qty)

        Next
        LoadReport()
        Receiptform.ShowDialog()
        ' CLEAR CART
        Dim clearCmd As New OleDb.OleDbCommand("DELETE FROM tbltemp", dbtemp)
        clearCmd.ExecuteNonQuery()

        RefreshCart()
        LoadStockData()
        LoadItemTiles()

    End Sub
    Sub UpdateStockQuantity(stockID As String, soldQty As Integer)

        If db3.State = ConnectionState.Closed Then db3.Open()

        Dim cmd As New OleDb.OleDbCommand(
        "SELECT Quantity, [Critical level] FROM Stocks WHERE [Stock ID] = ?", db3)

        cmd.Parameters.AddWithValue("?", stockID)

        Dim reader = cmd.ExecuteReader()

        If reader.Read() Then

            Dim currentQty As Integer = CInt(reader("Quantity"))
            Dim critical As Integer = CInt(reader("Critical level"))

            Dim newQty As Integer = currentQty - soldQty

            reader.Close()

            Dim updateCmd As New OleDb.OleDbCommand(
            "UPDATE Stocks SET Quantity = ? WHERE [Stock ID] = ?", db3)

            updateCmd.Parameters.AddWithValue("?", newQty)
            updateCmd.Parameters.AddWithValue("?", stockID)
            updateCmd.ExecuteNonQuery()

            If newQty <= critical Then
                MessageBox.Show("⚠ Low stock alert for item: " & stockID)
            End If

        Else
            reader.Close()
        End If

    End Sub

    Sub ProcessPayment()
        ' Ensure cart is not empty
        Dim totalStr As String = lblTotal.Text.Replace("₱", "").Trim()
        Dim totalAmt As Decimal = 0
        If Not Decimal.TryParse(totalStr, totalAmt) Then
            MessageBox.Show("Invalid total amount.")
            Exit Sub
        End If

        If totalAmt <= 0 Then
            MessageBox.Show("Cart is empty.")
            Exit Sub
        End If

        If PaymentMode = "" Then
            MessageBox.Show("Payment cancelled.")
            Exit Sub
        End If

        ' ----- CASH PAYMENT -----
        If PaymentMode = "PAYNOW" Then
            Dim cashReceived As Decimal = 0
            If Not Decimal.TryParse(txtamt.Text, cashReceived) Then
                MessageBox.Show("Enter a valid numeric amount in Cash Received.")
                Exit Sub
            End If

            If cashReceived < totalAmt Then
                MessageBox.Show("Insufficient cash. Please provide at least ₱ " & Format(totalAmt, "N2"))
                Exit Sub
            End If

            ' Calculate change
            Dim change As Decimal = cashReceived - totalAmt
            txtchange.Text = Format(change, "N2")

            ' Save transaction
            SaveTransaction()
            MessageBox.Show("Cash payment successful! Change: ₱ " & Format(change, "N2"))

            ' ----- CHARGE TO GUEST -----
        ElseIf PaymentMode = "CHARGE" Then
            If Not IsGuest OrElse bookingID = "" Then
                MessageBox.Show("Guest info missing. Cannot charge.")
                Exit Sub
            End If

            chargetoguest()
            MessageBox.Show("Charged to guest account successfully!")
        End If

        ' Clear inputs
        txtamt.Text = ""
        txtchange.Text = ""
        Panel2.Enabled = False
        dgvcart.Focus()
    End Sub


    Private Sub txtamt_TextChanged(sender As Object, e As EventArgs) Handles txtamt.TextChanged
        Dim totalStr As String = lblTotal.Text.Replace("₱", "").Trim()
        Dim totalAmt As Decimal = 0
        If Not Decimal.TryParse(totalStr, totalAmt) Then Exit Sub

        Dim cashReceived As Decimal = 0
        If Decimal.TryParse(txtamt.Text, cashReceived) Then
            Dim change As Decimal = cashReceived - totalAmt
            If change < 0 Then
                txtchange.Text = "0.00"
            Else
                txtchange.Text = Format(change, "N2")
            End If
        Else
            txtchange.Text = "0.00"
        End If
    End Sub

    Private Sub txtamt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtamt.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Prevent ding sound
            ProcessPayment()
        End If
    End Sub

    Private Sub chargetoguest()


        Dim grandTotal As Decimal = 0 ' ✅ total of all orders
        If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()


        tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", dbtemp)
        dbdstemp = New DataSet()
        tbltemp.Fill(dbdstemp, "tbltemp")

        If dbdstemp.Tables("tbltemp").Rows.Count > 0 Then
            trec3 = dbdstemp.Tables("tbltemp").Rows.Count - 1
            recpointer3 = 0
            If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()

            For recpointer3 = 0 To trec3
                xsn = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Stock ID")
                xDesc = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Description")
                xqty = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Quantity")
                xUP = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Unit Price")
                xdate = "#" & Format(Date.Now, "MM/dd/yyyy") & "#"
                xtotal = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Total")

                grandTotal += Convert.ToDecimal(xtotal)

                xtime = Format(TimeOfDay, "hh: mm:ss tt")

                dbcmd3 = New OleDb.OleDbCommand("INSERT INTO guest_orders ([Stock ID],[bookingID],[Description],[Quantity],[Unit Price],[Total],[Date Tran],[Time Tran], [Cashier Name] ) VALUES ('" & xsn & "','" & bookingID & "','" & xDesc & "','" & xqty & "','" & xUP & "','" & xtotal & "'," & xdate & ",'" & xtime & "','" & xname & "')", dbtemp)
                dbcmd3.ExecuteNonQuery()

                If db2.State = ConnectionState.Closed Then db2.Open()

                tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM Stocks WHERE [Stock ID] like '" & xsn & "' ", db2)
                dbds2 = New DataSet()
                tblstock.Fill(dbds2, "Stocks")

                stocksqty = dbds2.Tables("Stocks").Rows(0).Item("Quantity")
                stockcrit = dbds2.Tables("Stocks").Rows(0).Item("Critical level")
                stocksqty = stocksqty - xqty

                If db2.State = ConnectionState.Closed Then db2.Open()
                dbcmd3 = New OleDb.OleDbCommand("UPDATE Stocks SET [Quantity] = '" & stocksqty & "' WHERE [Stock ID] like '" & xsn & "'", db2)
                dbcmd3.ExecuteNonQuery()

            Next
        End If
        LoadReport()
        Receiptform.ShowDialog()
        Try 'AFTER PURCHASE
            MsgBox("We hope you enjoy your purchase!", MsgBoxStyle.Information, "Success")

            txtamt.Clear()
            txtchange.Clear()


            If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()
            dbcmd3 = New OleDb.OleDbCommand("DELETE * FROM tbltemp", dbtemp)
            dbcmd3.ExecuteNonQuery()
            sqlquery_temp()
            dgvcart.DataSource = dbdstemp.Tables("tbltemp")

            dgvcart.Refresh()
            Panel2.Enabled = False
        Catch ex As Exception
            MsgBox("after purchase has an error")
        Finally

        End Try

        If stocksqty <= stockcrit Then
            MsgBox("The quantity of " & itemName & " is below the critical level. Please restock.", MsgBoxStyle.Exclamation, "Low Stock Alert")
        End If
        sqlquery_temp()
    End Sub

    Private Sub receiptdata()

        Dim reportPath As String = Application.StartupPath & "\CrptReceipt.rpt"
        crystal.Load(reportPath)
        crystal.Refresh()
        Receiptform.CrystalReportViewer1.ReportSource = crystal
        Receiptform.Refresh()

    End Sub



    Private Sub posv2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if closing is due to Alt+F4
        If e.CloseReason = CloseReason.UserClosing Then
            ' Optionally show a message
            ' MessageBox.Show("You cannot close this form using Alt+F4.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True   ' Cancels the close
        End If
    End Sub

    Sub ClearSearchFilters()

        ' Prevent triggering filter multiple times
        RemoveHandler txtIname.TextChanged, AddressOf txtIname_TextChanged
        RemoveHandler cbxCategory.SelectedIndexChanged, AddressOf cbxCategory_SelectedIndexChanged

        ' Reset controls
        txtIname.Clear()
        cbxCategory.SelectedIndex = -1

        ' Clear DataView filter
        dv.RowFilter = ""

        ' Reload all item tiles
        LoadItemTiles(dv)

        ' Reattach handlers
        AddHandler txtIname.TextChanged, AddressOf txtIname_TextChanged
        AddHandler cbxCategory.SelectedIndexChanged, AddressOf cbxCategory_SelectedIndexChanged

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
            crystal.Load(Application.StartupPath & "\CrptReceipt.rpt")

            ' Set up connection details for the report
            Dim server As String = "" ' Your server name
            Dim database As String = Application.StartupPath & "\database\resortDb.mdb" ' Database path (Access in this case)
            Dim userId As String = "" ' Access uses empty string for UserID
            Dim password As String = "" ' Access uses empty string for Password

            ' Call SetDatabaseLogon to apply the database connection settings
            SetDatabaseLogon(crystal, server, database, userId, password)

            crystal.Refresh()
            ' Set the report source to the CrystalReportViewer
            Receiptform.CrystalReportViewer1.ReportSource = crystal
            Receiptform.CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.ToString)
        End Try
    End Sub
End Class