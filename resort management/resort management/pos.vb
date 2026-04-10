Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class pos
    Public bookingID As String

    Private Sub cashier_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb_temp()
        sqlquery_temp()
        opendb_stocks()
        sqlquery_stocks()
        sw4 = sw5 = True
        txtStockID.Focus()
        dbtemp.Open()

        dbcmd3 = New OleDb.OleDbCommand("DELETE * FROM tbltemp", dbtemp)
        dbcmd3.ExecuteNonQuery()
        dgTemp.DataSource = dbdstemp.Tables("tbltemp")
        dgTemp.ReadOnly = True
        dgTemp.Columns("change").Visible = False
        dgTemp.Columns("amount").Visible = False
        dgTemp.Columns("Cashier Name").Visible = False

        Panel1.Visible = False
        lbluname.Text = xname
        lbldate.Text = CStr(Format(Date.Now, "MM/dd/yyyy"))
        xGTotal = 0

    End Sub

    Private Sub txtStockID_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStockID.KeyDown

        If e.KeyCode = Keys.NumLock Then
            If MsgBox("Proceeding to Payment", MsgBoxStyle.YesNo, "Thank youu!!") = MsgBoxResult.Yes Then
                payment_Type.ShowDialog()
                If sw5 = True Then
                    Panel1.Visible = True
                    txtamt.Focus()
                Else

                    chargetoguest()
                    Exit Sub
                End If
            Else
                payment_Type.Close()
                txtStockID.Focus()
                Panel1.Visible = False
            End If
        End If








        If e.KeyCode = Keys.Escape Then
            If MsgBox("By closing this transaction, the next user will be required to log in. Would you like to continue?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Logging - off") = MsgBoxResult.Yes Then
                log_in_form.Show()
                log_in_form.txtuserid.Text = ""
                log_in_form.txtpassword.Text = ""
                log_in_form.txtuserid.Focus()
                xname = ""
                main_form.Close()
                Form1.Close()
                main_form.Close()
                Me.Close()

            Else
                txtamt.Focus()
            End If
            Exit Sub
        End If

        If e.KeyCode = Keys.F1 Then

            Dim deduct As String
            Dim minus As String

            deduct = InputBox("Enter stock ID to deduct: ")

            minus = InputBox("How many item??")


            If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()

            tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp WHERE [Stock ID] like '" & deduct.Trim & "'", dbtemp)
            dbdstemp = New DataSet()
            tbltemp.Fill(dbdstemp, "tbltemp")

            If deduct.Length > 0 Then

                Try
                    If dbdstemp.Tables("tbltemp").Rows.Count > 0 Then
                        Dim qty = dbdstemp.Tables("tbltemp").Rows(0).Item("Quantity")
                        Dim newqty = qty - minus

                        Dim xtotal = dbdstemp.Tables("tbltemp").Rows(0).Item("Unit Price")
                        Dim newval As Single = newqty * xtotal

                        Dim itemValue = dbdstemp.Tables("tbltemp").Rows(0).Item("Total")
                        Dim nwtotal = itemValue - newval


                        If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()
                        dbcmd3 = New OleDb.OleDbCommand("UPDATE tbltemp SET [Quantity] = '" & newqty & "',[Total] = '" & newval & "' WHERE [Stock ID] like '" & deduct.Trim & "'", dbtemp)
                        dbcmd3.ExecuteNonQuery()

                        sqlquery_temp()
                        dgTemp.DataSource = dbdstemp.Tables("tbltemp")

                        tbltemp = New OleDb.OleDbDataAdapter("SELECT sum([Total]) as xt  FROM tbltemp", dbtemp)
                        dbdstemp = New DataSet()
                        tbltemp.Fill(dbdstemp, "tbltemp")

                        If dbdstemp.Tables("tbltemp").Rows.Count > 0 Then
                            recpointer3 = 0
                            trec3 = CInt(dbdstemp.Tables("tbltemp").Rows.Count) - 1
                        End If

                        txtTotal.Text = dbdstemp.Tables("tbltemp").Rows(0).Item("xt")
                        txtStockID.Focus()
                        MsgBox("item is successfully Deducted",)
                    Else
                        MsgBox("no match item!",)
                    End If

                Catch err As Exception
                    MsgBox(err.ToString)
                Finally
                    dbtemp.Close()
                End Try
            Else
                MsgBox("Please enter a stock ID",)
            End If
        End If


        If e.KeyCode = Keys.Delete Then

            Dim void As String
            void = InputBox("Enter stock ID to void :    ")

            If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()

            tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp WHERE [Stock ID] like '" & void.Trim & "'", dbtemp)
            dbdstemp = New DataSet()
            tbltemp.Fill(dbdstemp, "tbltemp")

            'populateVoid()

            If void.Length > 0 Then

                Try

                    If dbdstemp.Tables("tbltemp").Rows.Count > 0 Then
                        Dim itemValue = dbdstemp.Tables("tbltemp").Rows(0).Item("Total")
                        txtTotal.Text = txtTotal.Text - itemValue

                        dbcmd3 = New OleDb.OleDbCommand("DELETE * FROM tbltemp WHERE [Stock ID] like '" & void.Trim & "'", dbtemp)
                        dbcmd3.ExecuteNonQuery()

                        sqlquery_temp()
                        dgTemp.DataSource = dbdstemp.Tables("tbltemp")
                        MsgBox("item is successfully voided",)
                    Else
                        MsgBox("no match item!",)
                    End If

                Catch err As Exception
                    MsgBox(err.ToString)
                Finally
                    dbtemp.Close()
                End Try
            Else
                MsgBox("Please enter a stock ID",)
            End If
        End If

        If e.KeyCode = Keys.Escape Then
            If MsgBox("By closing this transaction, the next user will be required to log in. Would you like to continue?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Logging - off") = MsgBoxResult.Yes Then
                log_in_form.Show()
                log_in_form.txtuserid.Text = ""
                log_in_form.txtpassword.Text = ""
                log_in_form.txtuserid.Focus()
                xname = ""
                main_form.Close()
                Form1.Close()
                main_form.Close()
                Me.Close()
                'frmlogin.cmdlogoff.Visible = True
            Else
                txtamt.Focus()
            End If
            Exit Sub
        End If

        If e.KeyCode = Keys.Enter Then
            If IsNumeric(txtStockID.Text.Trim) Then

                Try
                    tblstock = New OleDb.OleDbDataAdapter("SELECT * FROM Stocks WHERE [Stock ID] like '" & txtStockID.Text.Trim & "' ", db2)
                    dbds2 = New DataSet()
                    tblstock.Fill(dbds2, "Stocks")


                    If dbds2.Tables("Stocks").Rows.Count > 0 Then

                        xUP = dbds2.Tables("Stocks").Rows(0).Item("Selling price")
                        txtTotal.Text = CSng(xUP)

                        xDesc = dbds2.Tables("Stocks").Rows(0).Item("Description")
                        itemName = dbds2.Tables("Stocks").Rows(0).Item("Item Name")

                        txtinfo.Text = itemName & " " & CStr(xDesc)

                        tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp WHERE [Stock ID] like '" & txtStockID.Text.Trim & "'", dbtemp)
                        dbdstemp = New DataSet()
                        tbltemp.Fill(dbdstemp, "tbltemp")

                        If dbdstemp.Tables("tbltemp").Rows.Count > 0 Then
                            Dim itemExists As Boolean = False
                            For Each row As DataRow In dbdstemp.Tables("tbltemp").Rows
                                If row("Stock ID").ToString() = txtStockID.Text.Trim() Then
                                    itemExists = True
                                End If
                            Next
                            If MsgBox("This item is already on your list. Do you want to add it again?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                xtempq = dbdstemp.Tables("tbltemp").Rows(0).Item("Quantity")
                                xGTotal = dbdstemp.Tables("tbltemp").Rows(0).Item("Total")
                                txtquantity.Focus()
                                sw4 = False
                            Else

                                txtStockID.Clear()
                                txtinfo.Clear()
                                Exit Sub
                            End If
                        Else
                            sw4 = True
                            txtquantity.Focus()
                        End If
                    Else
                        MsgBox("No item matches the entered Stock No. Please provide a valid Stock No. Thank you!", , "Sorry..")
                        txtStockID.Clear()
                        txtStockID.Focus()
                    End If

                Catch err As Exception
                    MsgBox(err.ToString)
                Finally
                    If db2.State = ConnectionState.Open Then db2.Close()
                    If dbtemp.State = ConnectionState.Open Then dbtemp.Close()
                End Try
            Else
                MsgBox("Please enter a Numeric Data!", , "Oops")
                txtStockID.Clear()
            End If
        End If
    End Sub

    Private Sub txtquantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtquantity.KeyDown


        If e.KeyCode = Keys.Enter Then
            If IsNumeric(txtquantity.Text.Trim) Then

                If txtquantity.Text = "" AndAlso IsNumeric(txtquantity.Text.Trim) Then
                    MsgBox("Please enter a valid quantity for this item!", , "Oops")
                    txtquantity.Focus()
                    Exit Sub
                End If

                Try
                    ' Calculate total price

                    Dim total As Decimal = CSng(txtquantity.Text) * CSng(xUP)
                    txtTotal.Text = Format(Convert.ToDecimal(total), "F2")

                    ' Insert or update item in tbltemp
                    If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()

                    If sw4 = True Then

                        dbcmd3 = New OleDb.OleDbCommand("INSERT INTO tbltemp ([Stock ID],[Description],[Quantity],[Unit Price],[Total]) VALUES ('" & txtStockID.Text.Trim & "','" & txtinfo.Text.Trim & "','" & txtquantity.Text.Trim & "','" & xUP & "','" & txtTotal.Text.Trim & "')", dbtemp)
                        dbcmd3.ExecuteNonQuery()

                    End If

                    If sw4 = False Then

                        xtempq = xtempq + CSng(txtquantity.Text)
                        xGTotal = CSng(xGTotal) + CSng(txtTotal.Text)

                        dbcmd3 = New OleDb.OleDbCommand("UPDATE tbltemp SET [Quantity] = '" & xtempq & "', [Total] = '" & xGTotal & "' WHERE [Stock ID] LIKE '" & txtStockID.Text & "'", dbtemp)
                        dbcmd3.ExecuteNonQuery()

                    End If

                    ' Re-fetch the updated tbltemp data
                    sqlquery_temp()
                    dgTemp.DataSource = dbdstemp.Tables("tbltemp")
                    dgTemp.Refresh()

                    ' Clear inputs for the next item

                    txtquantity.Clear()
                    txtStockID.Clear()
                    txtStockID.Focus()

                    tbltemp = New OleDb.OleDbDataAdapter("SELECT sum([Total]) as xt  FROM tbltemp", dbtemp)
                    dbdstemp = New DataSet()
                    tbltemp.Fill(dbdstemp, "tbltemp")

                    If dbdstemp.Tables("tbltemp").Rows.Count > 0 Then
                        recpointer3 = 0
                        trec3 = CInt(dbdstemp.Tables("tbltemp").Rows.Count) - 1
                    End If

                    txtTotal.Text = dbdstemp.Tables("tbltemp").Rows(0).Item("xt")
                    txtStockID.Focus()

                Catch ex As Exception
                    MsgBox("txtQ has an error" & Err.ToString)
                Finally
                    If dbtemp.State = ConnectionState.Open Then dbtemp.Close()
                End Try
            Else
                MsgBox("Please enter a Numeric Data!", , "Oops")
                txtquantity.Clear()
            End If
        End If

        If e.KeyCode = Keys.Escape Then

            If MsgBox("Proceeding with this action will void the last transaction. Are you sure you want to continue?", MsgBoxStyle.DefaultButton1 + vbYesNo, "Warning....") = MsgBoxResult.Yes Then
                txtStockID.Focus()
                populateVoid()
                If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()
                dbcmd3 = New OleDb.OleDbCommand("DELETE * FROM tbltemp", dbtemp)
                dbcmd3.ExecuteNonQuery()
                sqlquery_temp()
                dgTemp.DataSource = dbdstemp.Tables("tbltemp")
                dgTemp.Refresh()

                xGTotal = 0

                txtStockID.Clear()
                txtTotal.Clear()
                txtamt.Clear()
                txtchange.Clear()
                txtinfo.Clear()
                Exit Sub
            End If
        End If
    End Sub
    Private Sub txtamt_Keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtamt.KeyDown
        Try
            If e.KeyCode = Keys.NumLock Then
                Panel1.Visible = False
                txtStockID.Focus()
                txtamt.Clear()
                Exit Sub
            End If

            If e.KeyCode <> Keys.Enter Then Exit Sub

            If Not IsNumeric(txtamt.Text.Trim) Then
                MsgBox("Please enter a numeric amount!", , "Oops")
                txtamt.Clear()
                Exit Sub
            End If

            If CSng(txtamt.Text) < CSng(txtTotal.Text) Then
                MsgBox("Insufficient funds. Please enter a valid amount", MsgBoxStyle.Information)
                txtamt.Clear()
                Exit Sub
            End If

            ' compute change
            Dim change As Single = CSng(txtamt.Text) - CSng(txtTotal.Text)
            txtchange.Text = Format(change, "F2")

            ' 🔑 SAVE ONLY HERE
            If IsGuest AndAlso PaymentMode = "CHARGE" Then
                chargetoguest()      ' → guest_orders
            Else
                savetotran()         ' → tbltran
            End If

        Catch err As Exception
            MsgBox("txtamt error: " & err.Message)
        End Try
    End Sub


    Private Sub savetotran()
        If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()


        dbcmd3 = New OleDb.OleDbCommand("UPDATE tbltemp SET [change] = '" & txtchange.Text.Trim & "', [amount] = '" & txtamt.Text.Trim & "',[Cashier Name] = '" & xname & "'", dbtemp)
        dbcmd3.ExecuteNonQuery()

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
                xtime = Format(TimeOfDay, "hh: mm:ss tt")

                dbcmd3 = New OleDb.OleDbCommand("INSERT INTO tbltran ([Stock ID],[Description],[Quantity],[Unit Price],[Total],[Date Tran],[Time Tran], [Cashier Name] ) VALUES ('" & xsn & "','" & xDesc & "','" & xqty & "','" & xUP & "','" & xtotal & "'," & xdate & ",'" & xtime & "','" & xname & "')", dbtemp)
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
        receiptdata()
        Receiptform.ShowDialog()
        Try 'AFTER PURCHASE
            MsgBox("We hope you enjoy your purchase!", MsgBoxStyle.Information, "Success")
            txtStockID.Clear()
            txtquantity.Clear()
            txtTotal.Clear()
            txtamt.Clear()
            txtchange.Clear()
            txtinfo.Clear()

            If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()
            dbcmd3 = New OleDb.OleDbCommand("DELETE * FROM tbltemp", dbtemp)
            dbcmd3.ExecuteNonQuery()
            sqlquery_temp()
            dgTemp.DataSource = dbdstemp.Tables("tbltemp")

            dgTemp.Refresh()

            txtStockID.Focus()
            Panel1.Visible = False
        Catch ex As Exception
            MsgBox("after purchase has an error")
        Finally

        End Try

        If stocksqty <= stockcrit Then
            MsgBox("The quantity of " & itemName & " is below the critical level. Please restock.", MsgBoxStyle.Exclamation, "Low Stock Alert")
        End If
        sqlquery_temp()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbltime.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub populateVoid()
        Try
            If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()
            tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", dbtemp)
            dbdstemp = New DataSet()
            tbltemp.Fill(dbdstemp, "tbltemp")

            If dbdstemp.Tables("tbltemp").Rows.Count > 0 Then
                trec3 = dbdstemp.Tables("tbltemp").Rows.Count - 1
                recpointer3 = 0

                For recpointer3 = 0 To trec3
                    xsn = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Stock ID")
                    xDesc = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Description")
                    xqty = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Quantity")
                    xUP = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Unit Price")
                    xdate = "#" & Format(Date.Now, "MM/dd/yyyy") & "#"
                    xtotal = dbdstemp.Tables("tbltemp").Rows(recpointer3).Item("Total")
                    xtime = Format(TimeOfDay, "hh:mm:ss tt")

                    dbcmd3 = New OleDb.OleDbCommand("INSERT INTO tblvoid ([Stock ID],[Description],[Quantity],[Unit Price],[Total],[Date Tran],[Time Tran], [Cashier Name] ) VALUES ('" & xsn & "','" & xDesc & "','" & xqty & "','" & xUP & "','" & xtotal & "'," & xdate & ",'" & xtime & "','" & xname & "')", dbtemp)
                    dbcmd3.ExecuteNonQuery()
                Next
            End If
        Catch err As Exception
            MsgBox("Error at populatevoid" & err.ToString)
        End Try
    End Sub
    Private Sub receiptdata()

        Dim reportPath As String = Application.StartupPath & "\CrptReceipt.rpt"
        crystal.Load(reportPath)
        crystal.Refresh()
        Receiptform.CrystalReportViewer1.ReportSource = crystal
        Receiptform.Refresh()

    End Sub

    Private Sub CrystalReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        crystal_form.Show()
        xbtn = "Cashier"
        LoadReport()
        Me.Hide()
    End Sub

    Private Sub LoadReport()
        Try
            ' Initialize the Crystal Report document

            crystal.Load(Application.StartupPath & "\CrptTransaction.rpt")

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

    Private Sub ExcelToolStripMenuItem_Click(sender As Object, e As EventArgs)
        '  Dim printer As New print()
        ' Dim filepath As String = Application.StartupPath & "\reports\transaction.xlsx"
        ' Dim connectionString As String = ("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\Database1.mdb")
        '  printer.ImportTransToExcel(filepath, connectionString)

    End Sub

    Private Sub chargetoguest()
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
        receiptdata()
        Receiptform.ShowDialog()
        Try 'AFTER PURCHASE
            MsgBox("We hope you enjoy your purchase!", MsgBoxStyle.Information, "Success")
            txtStockID.Clear()
            txtquantity.Clear()
            txtTotal.Clear()
            txtamt.Clear()
            txtchange.Clear()
            txtinfo.Clear()

            If dbtemp.State = ConnectionState.Closed Then dbtemp.Open()
            dbcmd3 = New OleDb.OleDbCommand("DELETE * FROM tbltemp", dbtemp)
            dbcmd3.ExecuteNonQuery()
            sqlquery_temp()
            dgTemp.DataSource = dbdstemp.Tables("tbltemp")

            dgTemp.Refresh()

            txtStockID.Focus()
            Panel1.Visible = False
        Catch ex As Exception
            MsgBox("after purchase has an error")
        Finally

        End Try

        If stocksqty <= stockcrit Then
            MsgBox("The quantity of " & itemName & " is below the critical level. Please restock.", MsgBoxStyle.Exclamation, "Low Stock Alert")
        End If
        sqlquery_temp()
    End Sub

End Class