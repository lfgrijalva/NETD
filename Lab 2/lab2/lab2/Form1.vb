Public Class lab2Form
    Dim input As Integer
    Dim minValue As Integer = 0
    Dim maxValue As Integer = 100
    Dim output(6) As Integer 'Vector used to store inputs
    Dim counter As Integer = 0 'Simple counter used to output data
    Dim day As Integer = 1 'Counter for the day
    Dim average As Double = 0
    Dim grade As String
    Private Sub txtCourse1_LostFoucs(sender As Object, e As EventArgs) Handles tbCourse1.LostFocus
        If tbCourse1.Text = "" Then
            ActiveControl = tbCourse1 'If it's empty, do nothing and keep focus on it
            Exit Sub
        End If
        If (Not Double.TryParse(tbCourse1.Text, input)) Then 'Error if input is not numeric
            NonNumeric() 'Call NonNumeric function, posts the appropiate error message
            ActiveControl = tbCourse1
            tbCourse1.Clear()
        ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
            OutsideRange() 'Call OutsideRange functions, posts the apropiate error message
            ActiveControl = tbCourse1
            tbCourse1.Clear()
        Else
            tbOutput.Clear()
            grade = CalculateGrade(input) 'Call the function to assign the correct grade
            lbCourse1.Text = grade 'Assign it to the label
        End If
    End Sub
    Private Sub txtCourse2_LostFoucs(sender As Object, e As EventArgs) Handles tbCourse2.LostFocus
        If tbCourse2.Text = "" Then
            ActiveControl = tbCourse2 'If it's empty, do nothing and keep focus on it
            Exit Sub
        End If
        If (Not Double.TryParse(tbCourse2.Text, input)) Then 'Error if input is not numeric
            NonNumeric() 'Call NonNumeric function, posts the appropiate error message
            ActiveControl = tbCourse2
            tbCourse2.Clear()
        ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
            OutsideRange() 'Call OutsideRange functions, posts the apropiate error message
            ActiveControl = tbCourse2
            tbCourse2.Clear()
        Else
            tbOutput.Clear()
            grade = CalculateGrade(input) 'Call the function to assign the correct grade
            lbCourse2.Text = grade
        End If
    End Sub
    Private Sub txtCourse3_LostFoucs(sender As Object, e As EventArgs) Handles tbCourse3.LostFocus
        If tbCourse3.Text = "" Then
            ActiveControl = tbCourse3 'If it's empty, do nothing and keep focus on it
            Exit Sub
        End If
        If (Not Double.TryParse(tbCourse3.Text, input)) Then 'Error if input is not numeric
            NonNumeric() 'Call NonNumeric function, posts the appropiate error message
            ActiveControl = tbCourse3
            tbCourse3.Clear()
        ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
            OutsideRange() 'Call OutsideRange functions, posts the apropiate error message
            ActiveControl = tbCourse3
            tbCourse3.Clear()
        Else
            tbOutput.Clear()
            grade = CalculateGrade(input) 'Call the function to assign the correct grade
            lbCourse3.Text = grade
        End If
    End Sub
    Private Sub txtCourse4_LostFoucs(sender As Object, e As EventArgs) Handles tbCourse4.LostFocus
        If tbCourse4.Text = "" Then
            ActiveControl = tbCourse4 'If it's empty, do nothing and keep focus on it
            Exit Sub
        End If
        If (Not Double.TryParse(tbCourse4.Text, input)) Then 'Error if input is not numeric
            NonNumeric() 'Call NonNumeric function, posts the appropiate error message
            ActiveControl = tbCourse4
            tbCourse4.Clear()
        ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
            OutsideRange() 'Call OutsideRange functions, posts the apropiate error message
            ActiveControl = tbCourse4
            tbCourse4.Clear()
        Else
            tbOutput.Clear()
            grade = CalculateGrade(input) 'Call the function to assign the correct grade
            lbCourse4.Text = grade
        End If
    End Sub
    Private Sub txtCourse5_LostFoucs(sender As Object, e As EventArgs) Handles tbCourse5.LostFocus
        If tbCourse5.Text = "" Then
            ActiveControl = tbCourse5 'If it's empty, do nothing and keep focus on it
            Exit Sub
        End If
        If (Not Double.TryParse(tbCourse5.Text, input)) Then 'Error if input is not numeric
            NonNumeric() 'Call NonNumeric function, posts the appropiate error message
            ActiveControl = tbCourse5
            tbCourse5.Clear()
        ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
            OutsideRange() 'Call OutsideRange functions, posts the apropiate error message
            ActiveControl = tbCourse5
            tbCourse5.Clear()
        Else
            tbOutput.Clear()
            grade = CalculateGrade(input) 'Call the function to assign the correct grade
            lbCourse5.Text = grade
        End If
    End Sub
    Private Sub txtCourse6_LostFoucs(sender As Object, e As EventArgs) Handles tbCourse6.LostFocus
        If tbCourse6.Text = "" Then
            ActiveControl = tbCourse6 'If it's empty, do nothing and keep focus on it
            Exit Sub
        End If
        If (Not Double.TryParse(tbCourse6.Text, input)) Then 'Error if input is not numeric
            NonNumeric() 'Call NonNumeric function, posts the appropiate error message
            ActiveControl = tbCourse6
            tbCourse6.Clear()
        ElseIf (input < minValue Or input > maxValue) Then 'Error if input is outside range
            OutsideRange() 'Call OutsideRange functions, posts the apropiate error message
            ActiveControl = tbCourse6
            tbCourse6.Clear()
        Else
            tbOutput.Clear()
            grade = CalculateGrade(input) 'Call the function to assign the correct grade
            lbCourse6.Text = grade
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Reset everything, clear textboxes and labels and re-enable the ones se to false when calculating semester grade. Set active control to tbCourse 1 to start entering new data
        tbCourse1.Clear()
        tbCourse2.Clear()
        tbCourse3.Clear()
        tbCourse4.Clear()
        tbCourse5.Clear()
        tbCourse6.Clear()
        tbOutput.Clear()
        lbCourse1.Text = ""
        lbCourse2.Text = ""
        lbCourse3.Text = ""
        lbCourse4.Text = ""
        lbCourse5.Text = ""
        lbCourse6.Text = ""
        lbSemesterOutput.Text = ""
        lbSemesterGrade.Text = ""
        tbCourse1.Enabled = True
        tbCourse2.Enabled = True
        tbCourse3.Enabled = True
        tbCourse4.Enabled = True
        tbCourse5.Enabled = True
        tbCourse6.Enabled = True
        btnCalculate.Enabled = True
        ActiveControl = tbCourse1

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the application
        Close()
    End Sub

    Function CalculateGrade(ByVal input As Integer) As String
        'A selec case with input as a parameter. Depending on the range of the input, it will set the variable grade to it and return it to the sub who called it
        Select Case input
            Case 0 To 49
                grade = "F"
            Case 50 To 52
                grade = "D-"
            Case 53 To 56
                grade = "D"
            Case 57 To 59
                grade = "D+"
            Case 60 To 62
                grade = "C-"
            Case 63 To 66
                grade = "C"
            Case 67 To 69
                grade = "C+"
            Case 70 To 72
                grade = "B-"
            Case 73 To 76
                grade = "B"
            Case 77 To 79
                grade = "B+"
            Case 80 To 84
                grade = "A-"
            Case 85 To 89
                grade = "A"
            Case 90 To 100
                grade = "A+"
        End Select
        Return grade

    End Function
    Public Function NonNumeric() As String
        'A function to be called. Displays the NonNumeric error for an input
        tbOutput.Clear()
        tbOutput.Text = "ERROR: Please ensure that your input is a whole number."
        Return Nothing
    End Function
    Public Function OutsideRange() As String
        'A function to be called. Displays the OutsideRange error for an input
        tbOutput.Clear()
        tbOutput.Text = "ERROR: Please ensure that your input less than " + CStr(maxValue) + " and bigger than " + CStr(minValue) + " ."
        Return Nothing
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim grade1 As Double
        Dim grade2 As Double
        Dim grade3 As Double
        Dim grade4 As Double
        Dim grade5 As Double
        Dim grade6 As Double
        Dim grade1Check As Boolean
        Dim grade2Check As Boolean
        Dim grade3Check As Boolean
        Dim grade4Check As Boolean
        Dim grade5Check As Boolean
        Dim grade6Check As Boolean
        Dim semesterGradeCheck(6) As Boolean
        Dim semesterAverage As Double
        Dim semesterGrade As String
        Dim output(7) As String
        Dim counter As Integer
        Dim i As Integer
        Dim semesterGrades(6) As Double
        Dim sum As Double = 0
        Dim checker As Boolean

        'Assign the pass/fail value to a variable for each course
        grade1Check = Double.TryParse(tbCourse1.Text, grade1)
        grade2Check = Double.TryParse(tbCourse2.Text, grade2)
        grade3Check = Double.TryParse(tbCourse3.Text, grade3)
        grade4Check = Double.TryParse(tbCourse4.Text, grade4)
        grade5Check = Double.TryParse(tbCourse5.Text, grade5)
        grade6Check = Double.TryParse(tbCourse6.Text, grade6)

        'Assign the numerical value of the grade from each course to a variable
        semesterGrades(0) = grade1
        semesterGrades(1) = grade2
        semesterGrades(2) = grade3
        semesterGrades(3) = grade4
        semesterGrades(4) = grade5
        semesterGrades(5) = grade6

        'Assign each value to a position in an array for it to be looped over
        semesterGradeCheck(0) = grade1Check
        semesterGradeCheck(1) = grade2Check
        semesterGradeCheck(2) = grade3Check
        semesterGradeCheck(3) = grade4Check
        semesterGradeCheck(4) = grade5Check
        semesterGradeCheck(5) = grade6Check

        'Check if any test for a course failed. If at least 1 did, display the ERROR(s) message
        If (grade1Check = False Or grade2Check = False Or grade3Check = False Or grade4Check = False Or grade5Check = False Or grade6Check = False) Then
            checker = True
            output(0) = "ERROR(s): " + vbCrLf
        End If
        'Loop over the array that contains the checks. Store the message on a different array to be displayed later. It's a specific message for each course
        For counter = 1 To 6
            If (semesterGradeCheck(counter - 1) = False) Then
                output(counter) = "Please ensure that your input in Course " + CStr(counter) + " is a whole number less than " + CStr(maxValue) + " and bigger than " + CStr(minValue) + " ." + vbCrLf
            End If
        Next
        If checker = True Then 'If at least 1 failed
            For i = 0 To 6
                tbOutput.Text += output(i) 'Loop over the errors array and display them
            Next
        Else 'If everything is OK
            For counter = 0 To 5
                sum += semesterGrades(counter) 'Loop over the array that contais the values for the grades and make a sum
            Next
            semesterAverage = Math.Round((sum / 6), 2) 'Calculate the average
            semesterGrade = CalculateGrade(semesterAverage) 'Call the function to get a grade
            lbSemesterOutput.Text = CStr(semesterAverage) 'Display the average
            lbSemesterGrade.Text = semesterGrade 'Display the grade

            tbCourse1.Enabled = False 'Disable the textboxes and the calculate button so no further inputs can be made until the form is reset
            tbCourse2.Enabled = False
            tbCourse3.Enabled = False
            tbCourse4.Enabled = False
            tbCourse5.Enabled = False
            tbCourse6.Enabled = False
            btnCalculate.Enabled = False
        End If



    End Sub
End Class
