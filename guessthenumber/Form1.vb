Public Class frmNumberGuess

    Private Sub btnGuessMode_Click(sender As Object, e As EventArgs) Handles btnGuessMode.Click

        Form2.Show()
        Me.Hide()

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form3.Show()
        Me.Hide()

    End Sub
End Class
