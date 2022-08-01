Public Class Form2

    Private Sub btnStart_Click_1(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim iattempts As Integer
        Dim inumber As Integer
        Dim bcorrect As Boolean
        Dim stguess As String
        Dim iUserGuess As Integer

        Randomize()
        inumber = Int(Rnd() * 100) + 1 ' inumber is going to be the random number generated. "int" makes it a whole number "Rnd" is the random function * 100 is the max number
        bcorrect = False               ' setting the default value to false because the user hasnt made a guess yet, much less a correct one
        iattempts = 1                  ' setting the default attempt to number one


        'set a do while loop, we only want to give the user 10 attempts, so the loop will continue while attempts is less than 11
        'also, we want to continue as long as the correct number hasnt been guessed, so while bcorrect is false
        Do While iattempts < 11 And bcorrect = False

            stguess = InputBox("please enter a number between 1-100")

            If Integer.TryParse(stguess, iUserGuess) Then
                'they entered a valid number, check if they guess correctly
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

    Private Sub btnExit2_Click(sender As Object, e As EventArgs) Handles btnExit2.Click
        frmNumberGuess.Show()
        Me.Close()
    End Sub
End Class