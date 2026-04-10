Public Class main_form

    Private Sub main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        log_in_form.txtuserid.Text = ""
        log_in_form.txtpassword.Text = ""
        Try
            ' Default: lock everything
            DisableAllButtons()

            Select Case xpriv
                Case "User"
                    HandleUserAccess()

                Case "Admin"

                    EnableAdminAccess()
            End Select

        Catch ex As Exception
            MsgBox("Error loading permissions: " & ex.Message)
        End Try
    End Sub
    Private Sub HandleUserAccess()
        btnuser.Enabled = False
        btnreports.Enabled = False

        Select Case xpost.ToLower()

            Case "receptionist", "front desk agent"
                btnfrontdesk.Enabled = True
                btnrooms.Enabled = True
                btnStock.Enabled = False

            Case "housekeeper", "room attendant"
                btnrooms.Enabled = True

            Case "restaurant staff", "server", "bar staff"
                btnStock.Enabled = True
                btnCashier.Enabled = True

            Case "beach attendant", "pool attendant"
                ' Limited access – maybe future module
                btnfrontdesk.Enabled = False
            Case "Cashier"
                btnCashier.Enabled = True
        End Select
    End Sub

    Private Sub EnableAdminAccess()
        Button1.Visible = True
        btnuser.Enabled = True
        btnStock.Enabled = True
        btnfrontdesk.Enabled = True
        btnrooms.Enabled = True
        btnreports.Enabled = True
        btnCashier.Enabled = True

    End Sub

    Private Sub DisableAllButtons()
        btnuser.Enabled = False
        btnStock.Enabled = False
        btnfrontdesk.Enabled = False
        btnrooms.Enabled = False
        btnreports.Enabled = False
    End Sub

    Private Sub LayoutButtons()
        ' Calculate desired height and width for buttons
        Dim btnHeight As Integer = Me.ClientSize.Height \ 2 ' Use integer division
        Dim btnWidth As Integer = Me.ClientSize.Width \ 2

        ' Loop through all controls on the form
        For Each ctrl As Control In Me.Controls
            ' Only resize buttons
            If TypeOf ctrl Is Button Then
                ctrl.Height = btnHeight
                ctrl.Width = btnWidth
            End If
        Next
    End Sub

    Private Sub btnrooms_Click(sender As Object, e As EventArgs) Handles btnrooms.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnfrontdesk.Click
        Dim fd As New front_desk
        fd.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnuser.Click
        user_form.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        log_in_form.txtuserid.Text = ""
        log_in_form.txtpassword.Text = ""
        xpost = ""
        xpriv = ""
        log_in_form.Show()
        log_in_form.Refresh()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        resto_bar.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Settings.ShowDialog()
    End Sub

    Private Sub log_in_form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Check if closing is due to Alt+F4
        If e.CloseReason = CloseReason.UserClosing Then
            ' Optionally show a message
            ' MessageBox.Show("You cannot close this form using Alt+F4.", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Cancel = True   ' Cancels the close
        End If
    End Sub

    Private Sub btnCashier_Click(sender As Object, e As EventArgs) Handles btnCashier.Click
        posv2.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        reservations.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        billing_form.Show()
        Me.Hide()
    End Sub
End Class
