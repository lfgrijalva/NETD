Public Class lab3Form
    Dim input As Integer
    Dim minValue As Integer = 0
    Dim maxValue As Integer = 1000
    Dim output(6) As Integer 'Vector used to store inputs
    Dim counter As Integer = 0 'Simple counter used to output data
    Dim day As Integer = 1 'Counter for the day
    Dim employee As Integer = 0 'Counter for the employee number
    Dim average As Double = 0
    Dim data(6, 2) As Integer 'Dim the data array
    Dim units As Integer
    Dim totalAverage As Double = 0
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        counter = day - 1
        Select Case employee
            Case 0
                lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Bold)
                If (Not Integer.TryParse(tbUnits.Text, input)) Then 'Error if input is not numeric
                    NonNumeric() 'Call NonNumeric function, posts the appropiate error message
                ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
                    OutsideRange() 'Call OutsideRange functions, posts the apropiate error message
                Else
                    If (day = 7) Then
                        tbEmployee1.Text += input & vbCrLf
                        CalculateAverage(data, employee, day)
                        employee += 1
                        day = 1
                        lbDay.Text = "Day " & day
                        lbOutput1.Text = "Average: " & CStr(average)
                        lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Regular)
                        lbEmployee2.Font = New Font(lbEmployee2.Font, FontStyle.Bold)
                    Else
                        tbUnits.Clear()
                        tbEmployee1.Text += input & vbCrLf
                        data(counter, employee) = input
                        day += 1
                        lbDay.Text = "Day " & day
                    End If
                End If
            Case 1
                If (Not Integer.TryParse(tbUnits.Text, input)) Then 'Error if input is not numeric
                    NonNumeric() 'Call NonNumeric function, posts the appropiate error message
                ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
                    OutsideRange() 'Call OutsideRange functions, posts the apropiate error message
                Else
                    If (day = 7) Then
                        tbEmployee2.Text += input & vbCrLf
                        CalculateAverage(data, employee, day)
                        employee += 1
                        day = 1
                        lbDay.Text = "Day " & day
                        lbOutput2.Text = "Average: " & CStr(average)
                        lbEmployee2.Font = New Font(lbEmployee2.Font, FontStyle.Regular)
                        lbEmployee3.Font = New Font(lbEmployee3.Font, FontStyle.Bold)
                    Else
                        tbUnits.Clear()
                        tbEmployee2.Text += input & vbCrLf
                        data(counter, employee) = input
                        day += 1
                        lbDay.Text = "Day " & day
                    End If
                End If
            Case 2
                If (Not Integer.TryParse(tbUnits.Text, input)) Then 'Error if input is not numeric
                    NonNumeric() 'Call NonNumeric function, posts the appropiate error message
                ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
                    OutsideRange() 'Call OutsideRange functions, posts the apropiate error message
                Else
                    If (day = 7) Then
                        tbUnits.Clear()
                        tbEmployee3.Text += input & vbCrLf
                        CalculateAverage(data, employee, day)
                        lbOutput3.Text = "Average: " & CStr(average)
                        employee += 1
                        For j = 0 To 2
                            For i = 0 To 6
                                totalAverage += data(i, j)
                            Next
                        Next
                        totalAverage /= 21
                        totalAverage = Math.Round(totalAverage, 2)
                        lbOutput4.Text = "Average per day: " & CStr(totalAverage)
                        tbUnits.Enabled = False
                        btnEnter.Enabled = False
                        lbDay.Text = "Done"
                        lbEmployee3.Font = New Font(lbEmployee3.Font, FontStyle.Regular)
                        ActiveControl = tbUnits
                    Else
                        tbUnits.Clear()
                        tbEmployee3.Text += input & vbCrLf
                        data(counter, employee) = input
                        day += 1
                        lbDay.Text = "Day " & day
                    End If
                End If
        End Select
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbEmployee1.Clear()
        tbEmployee2.Clear()
        tbEmployee3.Clear()
        tbUnits.Clear()
        lbOutput1.Text = ""
        lbOutput2.Text = ""
        lbOutput3.Text = ""
        lbOutput4.Text = ""
        lbDay.Text = "Day 1"
        tbUnits.Enabled = True
        btnEnter.Enabled = True
        ActiveControl = tbUnits
        Array.Clear(data, 0, data.Length)
        totalAverage = 0
        lbEmployee1.Font = New Font(lbEmployee1.Font, FontStyle.Bold)
        day = 1
        employee = 0
    End Sub
    Public Function NonNumeric() As String
        'A function to be called. Displays the NonNumeric error for an input
        tbUnits.Clear()
        MessageBox.Show("ERROR: Please ensure that your input is a whole number.")
        ActiveControl = tbUnits
        Return Nothing
    End Function
    Public Function OutsideRange() As String
        'A function to be called. Displays the OutsideRange error for an input
        tbUnits.Clear()
        MessageBox.Show("ERROR: Please ensure that your input less than " + CStr(maxValue) + " and bigger than " + CStr(minValue) + " .")
        ActiveControl = tbUnits
        Return Nothing
    End Function
    Public Function CalculateAverage(data(,) As Integer, employee As Integer, day As Integer) As Double
        tbUnits.Clear()
        counter = day - 1
        data(counter, employee) = input
        average = 0
        For i = 0 To 6
            average += data(i, employee)
        Next
        average /= 7
        average = Math.Round(average, 2)
        Return average
    End Function
End Class

