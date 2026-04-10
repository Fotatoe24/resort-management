Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine

Module Connection

    Public db As New OleDbConnection
    Public db2 As New OleDbConnection
    Public db3 As New OleDbConnection
    Public db4 As New OleDbConnection
    Public emercency As String

    Public Rooms As New OleDbDataAdapter
    Public Table1 As New OleDbDataAdapter
    Public tblstock As New OleDbDataAdapter
    Public tblbooking As New OleDbDataAdapter
    Public tblguests As New OleDbDataAdapter
    Public tblextras As New OleDbDataAdapter
    Public tbltran As New OleDbDataAdapter
    Public tblorders As New OleDbDataAdapter

    Public dbcmd As New OleDbCommand
    Public dbcmd2 As New OleDbCommand
    Public dbcmd3 As New OleDbCommand

    Public reader As OleDbDataReader

    Public dbds As New DataSet      ' Rooms
    Public dbds2 As New DataSet     ' Users
    Public dbds3 As New DataSet     ' Stocks
    Public dbds4 As New DataSet     ' Bookings
    Public dbds5 As New DataSet     ' Guests
    Public dbds6 As New DataSet     ' ammenities
    Public dbdstemp As New DataSet
    Public dbds7 As New DataSet

    Public recpointer As Integer
    Public recpointer2 As Integer
    Public recpointer3 As Integer
    Public recpointer4 As Integer
    Public recpointer5 As Integer
    Public recpointer6 As Integer
    Public recpointer7 As Integer
    Public recpointer8 As Integer

    Public trec As Integer
    Public trec2 As Integer
    Public trec3 As Integer
    Public trec4 As Integer
    Public trec5 As Integer
    Public trec6 As Integer
    Public trec7 As Integer
    Public trec8 As Integer

    Public sw As Boolean
    Public sw2 As Boolean
    Public sw3 As Boolean
    Public sw4 As Boolean
    Public sw5 As Boolean

    Public db5 As New OleDbConnection
    Public db6 As New OleDbConnection
    Public dbtemp As New OleDbConnection

    Public tblstockcshr As New OleDbDataAdapter
    Public Tablecshr As New OleDbDataAdapter
    Public tbltemp As New OleDbDataAdapter
    Public tblvoid As New OleDbDataAdapter

    Public xtry As Integer
    Public xname As String
    Public xpost As String
    Public xpriv As String
    Public itemName As String
    Public xDesc As String
    Public xdate As String
    Public xUP As String
    Public xGTotal As String
    Public xtempq As Integer
    Public xqty As Integer
    Public xsn As String
    Public xtotal As Single
    Public stocksqty As Integer
    Public stockcrit As Integer
    Public xtime As String
    Public xbtn As String
    Public xID As String

    Public crystal As New ReportDocument

    Public PaymentMode As String  ' "PAYNOW" or "CHARGE"
    Public IsGuest As Boolean
    Sub opendb()
        Try
            db = New OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source=" & Application.StartupPath & "\database\resortDb.mdb")
            Rooms = New OleDbDataAdapter("SELECT * FROM Rooms", db)
            dbds = New DataSet()
            Rooms.Fill(dbds, "Rooms")

            If dbds.Tables("Rooms").Rows.Count > 0 Then
                recpointer = 0
                trec = dbds.Tables("Rooms").Rows.Count - 1
            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    Sub sqlquery()
        Try
            Rooms = New OleDbDataAdapter("SELECT * FROM Rooms", db)
            dbds = New DataSet()
            Rooms.Fill(dbds, "Rooms")

            If dbds.Tables("Rooms").Rows.Count > 0 Then
                recpointer = 0
                trec = dbds.Tables("Rooms").Rows.Count - 1
            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub

    Sub opendb_user()
        Try
            db2 = New OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source=" & Application.StartupPath & "\database\resortDb.mdb")
            Table1 = New OleDbDataAdapter("SELECT * FROM Users", db2)
            dbds2 = New DataSet()
            Table1.Fill(dbds2, "Users")

            If dbds2.Tables("Users").Rows.Count > 0 Then
                recpointer2 = 0
                trec2 = dbds2.Tables("Users").Rows.Count - 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db2.Close()
        End Try
    End Sub

    Sub sqlquery_user()
        Try
            Table1 = New OleDbDataAdapter("SELECT * FROM Users", db2)
            dbds2 = New DataSet()
            Table1.Fill(dbds2, "Users")

            If dbds2.Tables("Users").Rows.Count > 0 Then
                recpointer2 = 0
                trec2 = dbds2.Tables("Users").Rows.Count - 1
            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db2.Close()
        End Try
    End Sub

    Sub opendb_stocks()
        Try
            db3 = New OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source=" & Application.StartupPath & "\database\resortDb.mdb")
            tblstock = New OleDbDataAdapter("SELECT * FROM Stocks", db3)
            dbds3 = New DataSet()
            tblstock.Fill(dbds3, "Stocks")

            If dbds3.Tables("Stocks").Rows.Count > 0 Then
                recpointer3 = 0
                trec3 = dbds3.Tables("Stocks").Rows.Count - 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db3.Close()
        End Try
    End Sub

    Sub sqlquery_stocks()
        Try
            tblstock = New OleDbDataAdapter("SELECT * FROM Stocks", db3)
            dbds3 = New DataSet()
            tblstock.Fill(dbds3, "Stocks")

            If dbds3.Tables("Stocks").Rows.Count > 0 Then
                recpointer3 = 0
                trec3 = dbds3.Tables("Stocks").Rows.Count - 1
            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db3.Close()
        End Try
    End Sub

    Sub opendb_booking()
        Try
            db4 = New OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source=" & Application.StartupPath & "\database\resortDb.mdb")
            tblbooking = New OleDbDataAdapter("SELECT * FROM Bookings", db4)
            dbds4 = New DataSet()
            tblbooking.Fill(dbds4, "Bookings")

            If dbds4.Tables("Bookings").Rows.Count > 0 Then
                recpointer4 = 0
                trec4 = dbds4.Tables("Bookings").Rows.Count - 1
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db4.Close()
        End Try
    End Sub

    Sub sqlquery_booking()
        Try
            tblbooking = New OleDbDataAdapter("SELECT * FROM Bookings", db4)
            dbds4 = New DataSet()
            tblbooking.Fill(dbds4, "Bookings")

            If dbds4.Tables("Bookings").Rows.Count > 0 Then
                recpointer4 = 0
                trec4 = dbds4.Tables("Bookings").Rows.Count - 1
            End If
        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db4.Close()
        End Try
    End Sub

    Sub opendb_guests()
        Try
            db5 = New OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source=" &
                                  Application.StartupPath & "\database\resortDb.mdb")

            tblguests = New OleDbDataAdapter("SELECT * FROM Guests", db5)
            dbds5 = New DataSet()
            tblguests.Fill(dbds5, "Guests")

            If dbds5.Tables("Guests").Rows.Count > 0 Then
                recpointer5 = 0
                trec5 = dbds5.Tables("Guests").Rows.Count - 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db5.Close()
        End Try
    End Sub

    Sub sqlquery_guests()
        Try
            tblguests = New OleDbDataAdapter("SELECT * FROM Guests", db5)
            dbds5 = New DataSet()
            tblguests.Fill(dbds5, "Guests")

            If dbds5.Tables("Guests").Rows.Count > 0 Then
                recpointer5 = 0
                trec5 = dbds5.Tables("Guests").Rows.Count - 1
            End If

        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db5.Close()
        End Try
    End Sub


    Sub opendb_ammenities()
        Try
            db6 = New OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source=" &
                                  Application.StartupPath & "\database\resortDb.mdb")

            tblextras = New OleDbDataAdapter("SELECT * FROM ammenities", db6)
            dbds6 = New DataSet()
            tblextras.Fill(dbds6, "ammenities")

            If dbds6.Tables("ammenities").Rows.Count > 0 Then
                recpointer6 = 0
                trec6 = dbds6.Tables("ammenities").Rows.Count - 1
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db6.Close()
        End Try
    End Sub

    Sub sqlquery_ammenities()
        Try
            tblextras = New OleDbDataAdapter("SELECT * FROM ammenities", db6)
            dbds6 = New DataSet()
            tblextras.Fill(dbds6, "ammenities")

            If dbds6.Tables("ammenities").Rows.Count > 0 Then
                recpointer6 = 0
                trec6 = dbds6.Tables("ammenities").Rows.Count - 1
            End If

        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db6.Close()
        End Try
    End Sub


    Sub opendb_tran()
        Try
            db = New OleDb.OleDbConnection("PROVIDER=microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\resortDb.mdb")
            tbltran = New OleDb.OleDbDataAdapter("SELECT * FROM tbltran", db)
            dbdstemp = New DataSet()
            tbltran.Fill(dbdstemp, "tbltran")

            If dbdstemp.Tables("tbltran").Rows.Count > 0 Then
                recpointer7 = 0
                trec7 = CInt(dbdstemp.Tables("tbltran").Rows.Count) - 1
            End If

        Catch Err As Exception
            MsgBox(Err.ToString)
        Finally
            db.Close()
        End Try
    End Sub
    Sub sqlquery_tran()
        Try
            tbltran = New OleDb.OleDbDataAdapter("SELECT * FROM tbltran", db)
            dbdstemp = New DataSet()
            tbltran.Fill(dbdstemp, "tbltran")

            If dbdstemp.Tables("tbltran").Rows.Count > 0 Then
                recpointer7 = 0
                trec7 = CInt(dbdstemp.Tables("tbltran").Rows.Count) - 1
            End If

        Catch err As Exception
            MsgBox(err.ToString)
        Finally
            db.Close()
        End Try
    End Sub


    Sub opendb_temp()
        Try
            dbtemp = New OleDb.OleDbConnection("PROVIDER = microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\resortDb.mdb")
            tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp", dbtemp)
            dbdstemp = New DataSet()
            tbltemp.Fill(dbdstemp, "tbltemp")

            If dbdstemp.Tables("tbltemp").Rows.Count > 0 Then
                recpointer3 = 0
                trec3 = CInt(dbdstemp.Tables("tbltemp").Rows.Count) - 1
            End If

        Catch ex As Exception
            MsgBox("bobo my error")
        Finally
            dbtemp.Close()
        End Try

    End Sub

    Sub sqlquery_temp()
        Try
            tbltemp = New OleDb.OleDbDataAdapter("SELECT * FROM tbltemp ", dbtemp)
            dbdstemp = New DataSet()
            tbltemp.Fill(dbdstemp, "tbltemp")


            If dbdstemp.Tables("tbltemp").Rows.Count > 0 Then
                recpointer3 = 0
                trec3 = CInt(dbdstemp.Tables("tbltemp").Rows.Count) - 1
            End If
        Catch err As Exception
            MsgBox("haha")
        Finally
            dbtemp.Close()
        End Try
    End Sub

    Sub opendb_guestorder()
        Try
            db = New OleDb.OleDbConnection("PROVIDER = microsoft.jet.oledb.4.0; data source = " & Application.StartupPath & "\database\resortDb.mdb")
            tblorders = New OleDb.OleDbDataAdapter("SELECT * FROM guest_orders", db)
            dbds7 = New DataSet()
            tblorders.Fill(dbds7, "guest_orders")

            If dbds7.Tables("guest_orders").Rows.Count > 0 Then
                recpointer8 = 0
                trec8 = CInt(dbds7.Tables("guest_orders").Rows.Count) - 1
            End If

        Catch ex As Exception
            MsgBox("bobo my error")
        Finally
            dbtemp.Close()
        End Try

    End Sub

    Sub sqlquery_guestorder()
        Try
            tblorders = New OleDb.OleDbDataAdapter("SELECT * FROM guest_orders ", db)
            dbds7 = New DataSet()
            tblorders.Fill(dbds7, "guest_orders")


            If dbds7.Tables("guest_orders").Rows.Count > 0 Then
                recpointer8 = 0
                trec8 = CInt(dbds7.Tables("guest_orders").Rows.Count) - 1
            End If
        Catch err As Exception
            MsgBox("haha")
        Finally
            db.Close()
        End Try
    End Sub
End Module
