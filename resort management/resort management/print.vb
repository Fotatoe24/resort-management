Imports excel = Microsoft.Office.Interop.Excel
Imports System.Runtime.InteropServices
Imports System.Data.OleDb
Public Class print
    Public excelapp As New excel.Application()
    Public workbook As excel.Workbook
    Public wsheet As excel.Worksheet

    Public Sub ImportRoomsToExcel(filepath As String, Connection As String)
        Try
            Dim excelapp As New excel.Application()
            Dim workbook As excel.Workbook = excelapp.Workbooks.Open(filepath)
            Dim wsheet As excel.Worksheet = CType(workbook.Sheets(1), excel.Worksheet)

            Dim crrntRow As Integer = 6
            Using connect As New OleDbConnection(Connection)
                connect.Open()

                Dim cmd As New OleDbCommand("SELECT * FROM Rooms", connect)
                Dim dataRead As OleDbDataReader = cmd.ExecuteReader()


                With wsheet.PageSetup
                    .Zoom = False
                    '.CenterHorizontally = True
                    '.CenterVertically = False
                End With
                With wsheet.Range("A1:H1")
                    .Merge()
                    .Value = "REPUBLIC OF THE PHILIPPINES"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A2:H2")
                    .Merge()
                    .Value = "SAN NARCISO,ZAMBALES,2205"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A3:H3")
                    .Merge()
                    .Value = "RESORT MANAGEMENT"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A4:H4")
                    .Merge()
                    .Value = "ROOM LIST AS OF:"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A5:H5")
                    .Merge()
                    .Value = Now.ToString("MM/dd/yyyy")
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A6:H35")
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With



                wsheet.Cells(crrntRow, 1).value = "Room ID"
                wsheet.Cells(crrntRow, 2).value = "Room Name"
                wsheet.Cells(crrntRow, 3).value = "Room Number"
                wsheet.Cells(crrntRow, 4).value = "Capacity"
                wsheet.Cells(crrntRow, 5).value = "Classification"
                wsheet.Cells(crrntRow, 6).value = "Price"
                wsheet.Cells(crrntRow, 7).value = "Status"
                wsheet.Cells(crrntRow, 8).value = "Type"
                crrntRow += 1
                If dataRead.HasRows Then
                    While dataRead.Read()
                        ' Handle potential null values with If checks
                        wsheet.Cells(crrntRow, 1).value = If(IsDBNull(dataRead("RoomID")), "", dataRead("RoomID").ToString())
                        wsheet.Cells(crrntRow, 2).value = If(IsDBNull(dataRead("roomName")), "", dataRead("roomName").ToString())
                        wsheet.Cells(crrntRow, 3).value = If(IsDBNull(dataRead("roomNumber")), "", dataRead("roomNumber").ToString())
                        wsheet.Cells(crrntRow, 4).value = If(IsDBNull(dataRead("capacity")), "", dataRead("capacity").ToString())
                        wsheet.Cells(crrntRow, 5).value = If(IsDBNull(dataRead("classification")), "", dataRead("classification").ToString())
                        wsheet.Cells(crrntRow, 6).value = If(IsDBNull(dataRead("Price")), "", dataRead("Price").ToString())
                        wsheet.Cells(crrntRow, 7).value = If(IsDBNull(dataRead("Status")), "", dataRead("Status").ToString())
                        wsheet.Cells(crrntRow, 8).value = If(IsDBNull(dataRead("Type")), "", dataRead("Type").ToString())
                        ' Move to the next row
                        crrntRow += 1
                    End While
                Else
                    MessageBox.Show("No data found in the database.")
                End If
                dataRead.Close()
                Dim lastrow As Integer = crrntRow - 1
                With wsheet.Range("A1:H" & lastrow).Borders
                    .LineStyle = excel.XlLineStyle.xlDash
                    .Weight = excel.XlBorderWeight.xlThin
                End With
            End Using
            'workbook.Save()
            excelapp.Visible = True

            wsheet.Columns.AutoFit()

            Marshal.ReleaseComObject(wsheet)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(excelapp)

            wsheet = Nothing
            workbook = Nothing
            excelapp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()

        Catch err As Exception
            MessageBox.Show("An error occurred: " & err.ToString)
        Finally
            If wsheet IsNot Nothing Then Marshal.ReleaseComObject(wsheet)
            If workbook IsNot Nothing Then
                workbook.Close(False) ' Close without saving changes
                Marshal.ReleaseComObject(workbook)
            End If
            If excelapp IsNot Nothing Then
                excelapp.Quit()
                Marshal.ReleaseComObject(excelapp)
            End If

            ' Set objects to Nothing and force garbage collection
            wsheet = Nothing
            workbook = Nothing
            excelapp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Public Sub ImportUsrToExcel(filepath As String, Connection As String)
        Try
            Dim excelapp As New excel.Application()
            Dim workbook As excel.Workbook = excelapp.Workbooks.Open(filepath)
            Dim wsheet As excel.Worksheet = CType(workbook.Sheets(1), excel.Worksheet)

            Dim crrntRow As Integer = 7
            Using connect As New OleDbConnection(Connection)
                connect.Open()

                Dim cmd As New OleDbCommand("SELECT * FROM users", connect)
                Dim dataRead As OleDbDataReader = cmd.ExecuteReader()


                With wsheet.PageSetup
                    .Zoom = False
                    '.CenterHorizontally = True
                    '.CenterVertically = False
                End With
                With wsheet.Range("A1:D1")
                    .Merge()
                    .Value = "REPUBLIC OF THE PHILIPPINES"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A2:D2")
                    .Merge()
                    .Value = "IBA,ZAMBALES,2201"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A3:D3")
                    .Merge()
                    .Value = "RESORT MANAGEMENT SYSTEM"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A4:D4")
                    .Merge()
                    .Value = "USER LIST AS OF:"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A5:D5")
                    .Merge()
                    .Value = Now.ToString("MM/dd/yyyy")
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A6:D35")
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With

                With wsheet.Range("A1:D32").Borders
                    .LineStyle = excel.XlLineStyle.xlDash
                    .Weight = excel.XlBorderWeight.xlThin
                End With

                wsheet.Cells(crrntRow, 1).value = "USER ID"
                wsheet.Cells(crrntRow, 2).value = "USERNAME"
                wsheet.Cells(crrntRow, 3).value = "POSITION"
                wsheet.Cells(crrntRow, 4).value = "PRIVILEGE"
                crrntRow += 1
                If dataRead.HasRows Then
                    While dataRead.Read()
                        ' Handle potential null values with If checks
                        wsheet.Cells(crrntRow, 1).value = If(IsDBNull(dataRead("userID")), "", dataRead("userID").ToString())
                        wsheet.Cells(crrntRow, 2).value = If(IsDBNull(dataRead("username")), "", dataRead("username").ToString())
                        wsheet.Cells(crrntRow, 3).value = If(IsDBNull(dataRead("position")), "", dataRead("position").ToString())
                        wsheet.Cells(crrntRow, 4).value = If(IsDBNull(dataRead("privilege")), "", dataRead("privilege").ToString())

                        ' Move to the next row
                        crrntRow += 1
                    End While
                Else
                    MessageBox.Show("No data found in the database.")
                End If
                dataRead.Close()
            End Using
            'workbook.Save()
            excelapp.Visible = True

            wsheet.Columns.AutoFit()

            Marshal.ReleaseComObject(wsheet)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(excelapp)

            wsheet = Nothing
            workbook = Nothing
            excelapp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()

        Catch err As Exception
            MessageBox.Show("An error occurred: " & err.ToString)
        Finally
            If wsheet IsNot Nothing Then Marshal.ReleaseComObject(wsheet)
            If workbook IsNot Nothing Then
                workbook.Close(False) ' Close without saving changes
                Marshal.ReleaseComObject(workbook)
            End If
            If excelapp IsNot Nothing Then
                excelapp.Quit()
                Marshal.ReleaseComObject(excelapp)
            End If

            ' Set objects to Nothing and force garbage collection
            wsheet = Nothing
            workbook = Nothing
            excelapp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try
    End Sub

    Public Sub ImportStockToExcel(filepath As String, Connection As String)
        Try
            Dim excelapp As New excel.Application()
            Dim workbook As excel.Workbook = excelapp.Workbooks.Open(filepath)
            Dim wsheet As excel.Worksheet = CType(workbook.Sheets(1), excel.Worksheet)

            Dim crrntRow As Integer = 7
            Using connect As New OleDbConnection(Connection)

                connect.Open()

                Dim cmd As New OleDbCommand("SELECT * FROM Stocks", connect)
                Dim dataRead As OleDbDataReader = cmd.ExecuteReader()

                With wsheet.PageSetup
                    .Orientation = excel.XlPageOrientation.xlLandscape
                    ' .CenterVertically = True
                    .CenterHorizontally = True
                End With

                With wsheet.Range("A1:F1")
                    .Merge()
                    .Value = "REPUBLIC OF THE PHILIPPINES"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A2:F2")
                    .Merge()
                    .Value = "IBA,ZAMBALES,2201"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A3:F3")
                    .Merge()
                    .Value = "RESORT MANAGEMENT SYSTEM"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A4:F4")
                    .Merge()
                    .Value = "STOCK LIST AS OF:"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A5:F5")
                    .Merge()
                    .Value = Now.ToString("MM/dd/yyyy")
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With

                With wsheet.Range("A6:F350")
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A1:F309").Borders
                    .LineStyle = excel.XlLineStyle.xlDash
                    .Weight = excel.XlBorderWeight.xlThin
                End With


                wsheet.Cells(crrntRow, 1).value = "STOCK ID"
                wsheet.Cells(crrntRow, 2).value = "ITEM NAME"
                wsheet.Cells(crrntRow, 3).value = "DESCRIPTION"
                wsheet.Cells(crrntRow, 4).value = "QUANTITY"
                wsheet.Cells(crrntRow, 5).value = "CATEGORY"
                wsheet.Cells(crrntRow, 6).value = "SELLING PRICE"
                crrntRow += 1
                If dataRead.HasRows Then
                    While dataRead.Read()
                        'Handle potential null values with If checks
                        wsheet.Cells(crrntRow, 1).value = If(IsDBNull(dataRead("Stock ID")), "", dataRead("Stock ID").ToString())
                        wsheet.Cells(crrntRow, 2).value = If(IsDBNull(dataRead("Item Name")), "", dataRead("Item Name").ToString())
                        wsheet.Cells(crrntRow, 3).value = If(IsDBNull(dataRead("Description")), "", dataRead("Description").ToString())
                        wsheet.Cells(crrntRow, 4).value = If(IsDBNull(dataRead("Quantity")), "", dataRead("Quantity").ToString())
                        wsheet.Cells(crrntRow, 5).value = If(IsDBNull(dataRead("Category")), "", dataRead("Category").ToString())
                        wsheet.Cells(crrntRow, 6).value = If(IsDBNull(dataRead("Selling price")), "", dataRead("Selling price").ToString())

                        ' Move to the next row
                        crrntRow += 1
                    End While
                Else
                    MessageBox.Show("No data found in the database.")
                End If
                dataRead.Close()
            End Using
            'workbook.Save()
            excelapp.Visible = True

            wsheet.Columns.AutoFit()

            Marshal.ReleaseComObject(wsheet)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(excelapp)

            wsheet = Nothing
            workbook = Nothing
            excelapp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()

        Catch err As Exception
            MessageBox.Show("An error occurred: " & err.ToString)
        Finally
            If wsheet IsNot Nothing Then Marshal.ReleaseComObject(wsheet)
            If workbook IsNot Nothing Then
                workbook.Close(False) ' Close without saving changes
                Marshal.ReleaseComObject(workbook)
            End If
            If excelapp IsNot Nothing Then
                excelapp.Quit()
                Marshal.ReleaseComObject(excelapp)
            End If

            ' Set objects to Nothing and force garbage collection
            wsheet = Nothing
            workbook = Nothing
            excelapp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()

        End Try
    End Sub

    Public Sub ImportTransToExcel(filepath As String, Connection As String)
        Try
            Dim excelapp As New excel.Application()
            Dim workbook As excel.Workbook = excelapp.Workbooks.Open(filepath)
            Dim wsheet As excel.Worksheet = CType(workbook.Sheets(1), excel.Worksheet)

            Dim crrntRow As Integer = 7
            Using connect As New OleDbConnection(Connection)

                connect.Open()

                Dim cmd As New OleDbCommand("SELECT * FROM tbltran", connect)
                Dim dataRead As OleDbDataReader = cmd.ExecuteReader()

                With wsheet.PageSetup
                    .Orientation = excel.XlPageOrientation.xlLandscape
                    .CenterVertically = True
                End With

                With wsheet.Range("A1:H1")
                    .Merge()
                    .Value = "REPUBLIC OF THE PHILIPPINES"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A2:H2")
                    .Merge()
                    .Value = "IBA,ZAMBALES,2201"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A3:H3")
                    .Merge()
                    .Value = "RESORT MANAGEMENT SYSTEM"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A4:H4")
                    .Merge()
                    .Value = "TRANSACTION HISTORY AS OF:"
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A5:H5")
                    .Merge()
                    .Value = Now.ToString("MM/dd/yyyy")
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With

                With wsheet.Range("A6:H100")
                    .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
                    .HorizontalAlignment = excel.XlVAlign.xlVAlignCenter
                End With
                With wsheet.Range("A1:H50").Borders
                    .LineStyle = excel.XlLineStyle.xlDash
                    .Weight = excel.XlBorderWeight.xlThin
                End With


                wsheet.Cells(crrntRow, 1).value = "STOCK ID"
                wsheet.Cells(crrntRow, 2).value = "DESCRIPTION"
                wsheet.Cells(crrntRow, 3).value = "QUANTITY"
                wsheet.Cells(crrntRow, 4).value = "UNIT PRICE"
                wsheet.Cells(crrntRow, 5).value = "TOTAL"
                wsheet.Cells(crrntRow, 6).value = "DATE TRANS"
                wsheet.Cells(crrntRow, 7).value = "TIME TRANS"
                wsheet.Cells(crrntRow, 8).value = "CASHIER NAME"
                crrntRow += 1
                If dataRead.HasRows Then
                    While dataRead.Read()
                        'Handle potential null values with If checks
                        wsheet.Cells(crrntRow, 1).value = If(IsDBNull(dataRead("Stock ID")), "", dataRead("Stock ID").ToString())
                        wsheet.Cells(crrntRow, 2).value = If(IsDBNull(dataRead("Description")), "", dataRead("Description").ToString())
                        wsheet.Cells(crrntRow, 3).value = If(IsDBNull(dataRead("Quantity")), "", dataRead("Quantity").ToString())
                        wsheet.Cells(crrntRow, 4).value = If(IsDBNull(dataRead("Unit Price")), "", dataRead("Unit Price").ToString())
                        wsheet.Cells(crrntRow, 5).value = If(IsDBNull(dataRead("Total")), "", dataRead("Total").ToString())
                        wsheet.Cells(crrntRow, 6).value = If(IsDBNull(dataRead("Date tran")), "", dataRead("Date tran").ToString())
                        wsheet.Cells(crrntRow, 7).value = If(IsDBNull(dataRead("Time tran")), "", dataRead("Time tran").ToString())
                        wsheet.Cells(crrntRow, 8).value = If(IsDBNull(dataRead("Cashier Name")), "", dataRead("Cashier Name").ToString())
                        ' Move to the next row
                        crrntRow += 1
                    End While
                Else
                    MessageBox.Show("No data found in the database.")
                End If
                dataRead.Close()
            End Using
            'workbook.Save()
            excelapp.Visible = True

            wsheet.Columns.AutoFit()

            Marshal.ReleaseComObject(wsheet)
            Marshal.ReleaseComObject(workbook)
            Marshal.ReleaseComObject(excelapp)

            wsheet = Nothing
            workbook = Nothing
            excelapp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()

        Catch err As Exception
            MessageBox.Show("An error occurred: " & err.ToString)
        Finally
            If wsheet IsNot Nothing Then Marshal.ReleaseComObject(wsheet)
            If workbook IsNot Nothing Then
                workbook.Close(False) ' Close without saving changes
                Marshal.ReleaseComObject(workbook)
            End If
            If excelapp IsNot Nothing Then
                excelapp.Quit()
                Marshal.ReleaseComObject(excelapp)
            End If

            ' Set objects to Nothing and force garbage collection
            wsheet = Nothing
            workbook = Nothing
            excelapp = Nothing

            GC.Collect()
            GC.WaitForPendingFinalizers()

        End Try
    End Sub
End Class
