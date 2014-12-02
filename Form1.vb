Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim intInputValue As Integer = Val(InputBox("Enter a Number Greater Than 3", "INPUT"))
        Dim intCounter As Integer = 0

        If intInputValue <= 3 Then
            Me.lblOut.Text = "Enter a Number Greater Than Three"
        ElseIf intInputValue > 3 Then
            Dim intOne As Integer
            Dim intTwo As Integer
            Dim intThree As Integer
            Do

                Randomize()
                intOne = Int((intInputValue - 1 + 1) * Rnd() + 1)
                intTwo = Int((intInputValue - 1 + 1) * Rnd() + 1)
                intThree = Int((intInputValue - 1 + 1) * Rnd() + 1)

                Me.lblOne.Text = Val(intOne)
                Me.lblTwo.Text = Val(intTwo)
                Me.lblThree.Text = Val(intThree)

                intCounter += 1
            Loop Until (intOne <> intTwo) And (intTwo <> intThree) And (intOne <> intThree)
            Me.lblOut.Text = "Looped " & Val(intCounter) & " Times"
        End If

    End Sub
End Class
