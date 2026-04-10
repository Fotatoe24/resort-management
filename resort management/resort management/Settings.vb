Public Class Settings
    Public bgname As String = "SystemBG"
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoomClassifications(lbclass)
        LoadFoodCategory(lbfoodCat)
        LoadRoomImage(bgname)
    End Sub

    Sub LoadRoomClassifications(ByVal cbo As ListBox)

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

    Sub LoadFoodCategory(ByVal cbo As ListBox)

        Dim connStr As String =
            "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" &
            Application.StartupPath & "\database\resortDb.mdb"

        Using conn As New OleDb.OleDbConnection(connStr)
            Using cmd As New OleDb.OleDbCommand(
                "SELECT foodCategoryName FROM foodCategory", conn)

                conn.Open()
                Using rdr As OleDb.OleDbDataReader = cmd.ExecuteReader()

                    cbo.Items.Clear()

                    While rdr.Read()
                        cbo.Items.Add(rdr("foodCategoryName").ToString())
                    End While

                End Using
            End Using
        End Using

    End Sub

    Private Sub Addclass_Click(sender As Object, e As EventArgs) Handles Addclass.Click

        If txtClassName.Text.Trim = "" Then
            MessageBox.Show("Please enter a room classification.")
            Exit Sub
        End If

        Dim connStr As String =
        "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" &
        Application.StartupPath & "\database\resortDb.mdb"

        Using conn As New OleDb.OleDbConnection(connStr)
            Using cmd As New OleDb.OleDbCommand(
            "INSERT INTO RoomClassifications (RoomClassName) VALUES (?)", conn)

                cmd.Parameters.AddWithValue("@RoomClassName", txtClassName.Text.Trim)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' Reload the listbox
        LoadRoomClassifications(lbclass)

        txtClassName.Clear()
        MessageBox.Show("Room classification added successfully!")
    End Sub
    Private Sub revClass_Click(sender As Object, e As EventArgs) Handles revClass.Click

        If lbclass.SelectedIndex = -1 Then
            MessageBox.Show("Please select a room classification to remove.")
            Exit Sub
        End If

        Dim className As String = lbclass.SelectedItem.ToString()

        Dim confirm = MessageBox.Show(
            "Are you sure you want to delete '" & className & "'?",
            "Confirm Delete",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If confirm = DialogResult.No Then Exit Sub

        Dim connStr As String =
            "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" &
            Application.StartupPath & "\database\resortDb.mdb"

        Using conn As New OleDb.OleDbConnection(connStr)
            Using cmd As New OleDb.OleDbCommand(
                "DELETE FROM RoomClassifications WHERE RoomClassName = ?", conn)

                cmd.Parameters.AddWithValue("@RoomClassName", className)

                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        LoadRoomClassifications(lbclass)

        MessageBox.Show("Room classification removed successfully.")

    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) _
    Handles LinkLabel1.LinkClicked

        ofd.FileName = ""
        ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                Dim imgFolder As String = Application.StartupPath & "\systemfiles\"
                Dim destPath As String = imgFolder & bgname & ".jpg"

                ' Ensure folder exists
                If Not IO.Directory.Exists(imgFolder) Then
                    IO.Directory.CreateDirectory(imgFolder)
                End If

                ' Copy selected image to system folder
                IO.File.Copy(ofd.FileName, destPath, True)

                ' Reload image
                LoadRoomImage(bgname)

                MessageBox.Show("Background image updated successfully!")
                ApplySystemBackground(log_in_form)
            Catch ex As Exception
                MsgBox("Image error: " & ex.Message)
            End Try
        End If
    End Sub


    Sub LoadRoomImage(design As String)
        Try
            picbox.Image = Nothing

            Dim imgPath As String = Application.StartupPath & "\systemfiles\" & design & ".jpg"

            If IO.File.Exists(imgPath) Then
                Using fs As New IO.FileStream(imgPath, IO.FileMode.Open, IO.FileAccess.Read)
                    picbox.Image = Image.FromStream(fs)
                End Using
            End If

        Catch ex As Exception
            picbox.Image = Nothing
        End Try
    End Sub
End Class