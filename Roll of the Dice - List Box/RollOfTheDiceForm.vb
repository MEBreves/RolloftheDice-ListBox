'Miranda Breves
'RCET0265
'Spring 2022
'Roll of the Dice Form Program
'https://github.com/MEBreves/RolloftheDice-ListBox

Option Strict On
Option Explicit On

Public Class RollOfTheDiceForm


    Function DoubleDiceRoll() As Integer 'Returns the equivalent sum of two dice being rolled.

        'Declaring Function Variables
        Dim die1 As Integer = 0
        Dim die2 As Integer = 0

        'Initializing the Rnd() function to return different values
        Randomize()

        'Getting the dice values via a random number between 1 and 6
        die1 = CInt(Math.Floor((6 * Rnd())) + 1)
        die2 = CInt(Math.Floor((6 * Rnd())) + 1)

        Return die1 + die2
    End Function

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click

        'Declaring Variables
        Dim rollValue As Integer
        Dim diceTotals(12) As Integer
        Dim headerString As String = ""
        Dim formattedDiceTotals As String = ""

        'Simulating dice roll and storing the sum values in diceTotals array
        For i As Integer = 1 To 1000
            rollValue = DoubleDiceRoll()
            diceTotals(rollValue) += 1
        Next

        'Formatting the output to show the numbers in a table style
        RollDisplayListBox.Items.Add("")
        RollDisplayListBox.Items.Add("Roll of The Dice".PadLeft(35))
        RollDisplayListBox.Items.Add(StrDup(55, "-"))

        'Creating the header string with columns for readability
        For j As Integer = 2 To 12
            headerString = headerString & (CStr(j) & "|").PadLeft(5)
        Next

        'Displaying the headerString and a seperation row
        RollDisplayListBox.Items.Add(headerString)
        RollDisplayListBox.Items.Add(StrDup(55, "-"))

        'Formatting the dice totals array with columns for readability
        For k As Integer = 2 To 12
            formattedDiceTotals = formattedDiceTotals & (CStr(diceTotals(k)) & "|").PadLeft(5)
        Next

        'Displaying the formattedDiceTotals string
        RollDisplayListBox.Items.Add(formattedDiceTotals)

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        RollDisplayListBox.Items.Clear()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseInnerTool.Click
        Me.Close()
    End Sub

    Private Sub InstructionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InstructionsInnerTool.Click
        MsgBox("The Roll The Dice box displays the totals of two dice thrown 1000 times. Press the " &
               "'Roll' button to show the totals, the 'Clear' button to clear the display box, and " &
               "the 'Exit' button to exit the program.")
    End Sub

End Class