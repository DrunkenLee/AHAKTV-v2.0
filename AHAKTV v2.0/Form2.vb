
Public Class Form2
    Sub startbtn_Click(sender As Object, e As EventArgs) Handles startbtn.Click
        Dim screen As Screen
        screen = Screen.AllScreens(1)

        Try
            loadingbar.Value = 0
            Timer1.Start()
            Form3.StartPosition = FormStartPosition.Manual
            Form3.Location = screen.Bounds.Location + New Point(100, 100)
            Form3.ShowDialog()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loadingbar.Increment(5)
        If loadingbar.Value = 100 Then
            Try
                Timer1.Stop()
                Me.Hide()
                AHAKTV.ShowDialog()
                Form3.ShowDialog()

            Catch ex As Exception

            End Try
        End If
    End Sub
End Class