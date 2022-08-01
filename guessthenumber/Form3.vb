Public Class Form3
    Private Sub btnTimerStart_Click(sender As Object, e As EventArgs) Handles btnTimerStart.Click

        Timer1.Enabled = True

        Dim iattempts As Integer
        Dim inumber As Integer
        Dim bcorrect As Boolean
        Dim stguess As String
        Dim iUserGuess As Integer

        Randomize()
        inumber = Int(Rnd() * 100) + 1 'inumber is going to be the random number generated. "int" makes it a whole number "Rnd" is the random function * 100 is the max number
        bcorrect = False 'setting the default value to false because the user hasnt made a guess yet, much less a correct one
        iattempts = 1 'setting the default attempt to number one



        Do While iattempts < 1000 And bcorrect = False 'set a do while loop, set the loop to a large number so the user can't runout of attempts before the timer runs out,
            '_also, we want to continue as long as the correct number hasnt been guessed, so while bcorrect is false

            stguess = InputBox("please enter a number between 1-100")

            If Integer.TryParse(stguess, iUserGuess) Then 'they entered a valid number, check if they guess correctly
            Else
                MessageBox.Show("Please enter number from 1-100")
                Exit Sub
            End If

            Select Case iUserGuess
                Case 1 To 100
                Case Else
                    MessageBox.Show("please enter a number within range, 1-100")
                    Exit Sub
            End Select

            If iattempts = 1 Then
                iattempts = 1
            Else
                iattempts = iattempts + 1 - 1
            End If

            If Val(stguess) = inumber Then
                bcorrect = True
            Else
                If stguess < inumber Then
                    MsgBox("too low", vbExclamation, "attempt " & iattempts)
                Else
                    MsgBox("too high", vbExclamation, "attempt " & iattempts)
                End If

                iattempts = iattempts + 1

            End If

        Loop

        MessageBox.Show("the number was " & inumber)

    End Sub


    Private Sub btnTimerStop_Click(sender As Object, e As EventArgs) Handles btnTimerStop.Click

        frmNumberGuess.Show()
        Me.Close()


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label2.Text = Label2.Text - 1

        If Label2.Text = 0 Then
            Timer1.Enabled = False
            MessageBox.Show("Time is Up, Try Again")
        End If


    End Sub
End Class