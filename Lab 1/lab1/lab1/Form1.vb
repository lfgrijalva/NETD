Public Class Form1
    Dim input As Double
    Dim minValue As Integer = 0
    Dim maxValue As Integer = 1000
    Dim output(6) As Integer 'Vector used to store inputs
    Dim counter As Integer = 0 'Simple counter used to output data
    Dim day As Integer = 1 'Counter for the day
    Dim average As Double = 0
    Public Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If (Not Double.TryParse(txtInput.Text, input)) Then 'Error if input is not numeric
            MessageBox.Show("Error: Input must be a numeric value")
            txtInput.Clear()
        ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
            MessageBox.Show("Error: Input must be bigger than " & minValue & " and lower than " & maxValue)
            txtInput.Clear()
        Else
            If (day = 7) Then 'Special procedure if it's the last day, calculate average
                output(counter) = input
                For i = 0 To counter
                    average += output(i)
                Next
                txtOutput.Text += CStr(output(counter)) & vbCrLf
                txtInput.ReadOnly = True
                average /= 7
                lblAverage.Text = "The average for the 7 days is: " & Math.Round(average, 2)
                btnEnter.Enabled = False
                txtInput.Clear()
            Else
                output(counter) = input 'Output the data and increase counter and day. Change value of the day label
                txtOutput.Text += CStr(output(counter)) & vbCrLf
                day += 1
                counter = day - 1
                lblDay.Text = "Day: " & CStr(day)
                txtInput.Clear()
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtInput.Clear()
        txtOutput.Clear()
        lblAverage.Text = ""
        counter = 0
        average = 0
        day = 1
        txtInput.ReadOnly = False
        btnEnter.Enabled = True
        ActiveControl = txtInput
        lblDay.Text = "Day: 1"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub
End Class
