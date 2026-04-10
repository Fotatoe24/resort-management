Module applicationSettings


    Public Sub ApplySystemBackground(frm As Form)
        Dim imgPath As String = Application.StartupPath & "\systemfiles\SystemBG.jpg"
        Try
            If IO.File.Exists(imgPath) Then
                Using bmpTemp As New Bitmap(imgPath)
                    frm.BackgroundImage = New Bitmap(bmpTemp)
                End Using
                frm.BackgroundImageLayout = ImageLayout.Stretch
            Else
                frm.BackgroundImage = Nothing
            End If
        Catch
            frm.BackgroundImage = Nothing
        End Try
    End Sub


End Module
