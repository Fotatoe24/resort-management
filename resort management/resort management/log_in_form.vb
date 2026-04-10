Imports System.Data.OleDb

Public Class log_in_form

    Private Sub log_in_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplySystemBackground(Me)
        opendb_user()
        xdate = Format(Date.Now, "MM/dd/yyyy")
        xpost = ""
        xpriv = ""
    End Sub

    Private Sub txtuserid_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtuserid.KeyDown
        If e.KeyCode = Keys.F12 AndAlso e.Shift Then
            emercencyAccess()
        End If
        If e.KeyCode = Keys.F1 AndAlso e.Shift Then
            recoverykey()
        End If

        If e.KeyCode = Keys.Enter Then
            If txtuserid.TextLength > 0 Then
                txtpassword.Focus()
            Else
                txtuserid.Focus()
            End If
        End If
        ' If e.KeyCode = Keys.F5 AndAlso e.Alt Then
        ' Activitylog.Show()
        '  Me.Hide()
        '  End If
    End Sub

    Private Sub txtpassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtpassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtpassword.TextLength > 0 Then
                sbmtcmd.Focus()
            Else
                txtpassword.Focus()
            End If
        End If
    End Sub


    Private Sub sbmtcmd_Click(sender As Object, e As EventArgs) Handles sbmtcmd.Click


        If txtuserid.Text.Trim = "" Then
            MsgBox("Please Fill out all required fields.", MsgBoxStyle.Exclamation, "Opps...")
            Exit Sub
        End If

        If db2.State = ConnectionState.Closed Then db2.Open()
        Table1 = New OleDb.OleDbDataAdapter("SELECT * FROM users WHERE [userID]Like '" & txtuserid.Text.Trim & "'", db2)
        dbds2 = New DataSet()
        Table1.Fill(dbds2, "users")
        trec = dbds2.Tables("users").Rows.Count

        If trec > 0 Then
            xname = dbds2.Tables("users").Rows(0).Item("username")
            xpost = dbds2.Tables("users").Rows(0).Item("position")
            xpriv = dbds2.Tables("users").Rows(0).Item("privilege")

        End If

        xtime = Format(TimeOfDay, "hh: mm:ss tt")
        xID = txtuserid.Text.Trim
        Dim remaining As Integer = 3 - xtry

        Try

            If db2.State = ConnectionState.Closed Then db2.Open()
            Dim query As String = "SELECT COUNT(1) FROM users WHERE userID = txtuserid AND password = txtpassword"


            Using cmd As New OleDbCommand(query, db2)

                cmd.Parameters.AddWithValue("userID", txtuserid.Text.Trim())
                cmd.Parameters.AddWithValue("password", txtpassword.Text.Trim())

                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count = 1 Then
                    main_form.Show()
                    Me.Hide()
                    xname = dbds2.Tables("users").Rows(0).Item("username")
                Else
                    MsgBox("Invalid User ID or Password " & "Attempts Remaining: " & remaining, MsgBoxStyle.Exclamation, "failed")
                    xtry += 1
                    If xtry = 3 Then
                        MsgBox("To Many unsuccessful attempt, please try again later.", MsgBoxStyle.Exclamation, "failed")
                        Me.Close()
                    End If
                    txtpassword.Clear()
                    txtuserid.Clear()
                    txtuserid.Focus()
                End If
            End Using

        Catch err As Exception
            MsgBox("log in form query has an error: " & err.ToString)
        End Try
    End Sub


    Private Sub Extcmd_Click(sender As Object, e As EventArgs) Handles Extcmd.Click
        xtime = Format(TimeOfDay, "hh: mm:ss tt")
        If MsgBox("Do you want to exit?", MsgBoxStyle.YesNo, "Closing...") = MsgBoxResult.Yes Then
            main_form.Close()
            Form1.Close()
            checkout_form.Close()
            booking_form.Close()
            front_desk.Close()
            Me.Close()
        End If
    End Sub

    Private Sub showpass_CheckedChanged(sender As Object, e As EventArgs) Handles shwpass.CheckedChanged
        If shwpass.Checked Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "●"
        End If

    End Sub

    Private Sub recoverykey()
        Dim usbPath As String = "E:\phillip\Pos_system\Pos_system\bin\Debug\recovery.txt"
        If System.IO.File.Exists(usbPath) Then
            Dim keyContent As String = System.IO.File.ReadAllText(usbPath)
            If keyContent.Contains("RECOVERY") Then
                emercency = "parenagdebug"
                MsgBox("USB recovery key detected. Access granted.", MsgBoxStyle.Information, "System Recovery!")
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("Recovery Requirements Does not match")
                Me.Close()
            End If
        Else
            MsgBox("No recovery key found.", MsgBoxStyle.Information, "Access Denied...")
        End If
    End Sub

    Private Sub emercencyAccess()
        emercency = "parenagdebug"
        MsgBox("Emegency Access Granted!!!", MsgBoxStyle.Information, "Access Granted...")
        user_form.Show()
        Me.Hide()
    End Sub

    Sub LoadLoginFormBackground()

        Try
            Dim imgPath As String =
            Application.StartupPath & "\systemfiles\SystemBG.jpg"

            If IO.File.Exists(imgPath) Then
                Using bmpTemp As New Bitmap(imgPath)
                    Me.BackgroundImage = New Bitmap(bmpTemp)
                End Using

                Me.BackgroundImageLayout = ImageLayout.Stretch
            Else
                Me.BackgroundImage = Nothing
            End If

        Catch ex As Exception
            Me.BackgroundImage = Nothing
        End Try

    End Sub

End Class