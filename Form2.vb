Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        GunaProgressBar1.Increment(1)
        If GunaProgressBar1.Value = 100 Then
            Interaction.MsgBox("Action failed. Try again!")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub GunaGradientPanel1_Click(sender As Object, e As EventArgs) Handles GunaGradientPanel1.Click

    End Sub
End Class