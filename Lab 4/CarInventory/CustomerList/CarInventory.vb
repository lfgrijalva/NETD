﻿
Option Strict On

''' <summary>
''' Author Name:    Luis Grijalva
''' Project Name:   Car Inventory
''' Date:           3/14/19
''' </summary>

Public Class frmCarInventory

    Private carList As New SortedList                                 ' collection of all the customerList in the list
    Private carID As String = String.Empty ' current selected customer identification number
    Private editMode As Boolean = False
    Private tempPrice As Double
    Private formattedPrice As String

    ''' <summary>
    ''' btnEnter_Click - Will validate that the data entered into the controls is appropriate.
    '''                - Once the data is validated a customer object will be create using the  
    '''                - parameterized constructor. It will also insert the new customer object
    '''                - into the customerList collection. It will also check to see if the data in
    '''                - the controls has been selected from the listview by the user. In that case
    '''                - it will need to update the data in the specific customer object and the 
    '''                - listview as well.
    ''' </summary>
    ''' <param name="sender">Object</param>
    ''' <param name="e">EventArgs</param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car            ' declare a Customer class
        Dim carList As ListViewItem    ' declare a ListViewItem class

        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            ' 
            lbResult.Text = "It worked!"

            ' if the current customer identification number has a no value
            ' then this is not an existing item from the listview
            If carID.Trim.Length = 0 Then

                ' create a new customer object using the parameterized constructor
                car = New Car(cmbMake.Text, tbModel.Text, cmbYear.Text, Double.Parse(tbPrice.Text), chkNew.Checked)

                ' add the customer to the customerList collection
                ' using the identoification number as the key
                ' which will make the customer object easier to
                ' find in the customerList collection later
                Me.carList.Add(car.IdentificationNumber.ToString(), car)

            Else
                ' if the current customer identification number has a value
                ' then the user has selected something from the list view
                ' so the data in the customer object in the customerList collection
                ' must be updated

                ' so get the customer from the custmers collection
                ' using the selected key
                car = CType(Me.carList.Item(carID), Car)

                ' update the data in the specific object
                ' from the controls
                car.Make = cmbMake.Text
                car.Model = tbModel.Text
                car.Year = cmbYear.Text
                car.Price = CDbl(tbPrice.Text)
                car.Status = chkNew.Checked
            End If

            ' clear the items from the listview control
            lvwInventory.Items.Clear()

            ' loop through the customerList collection
            ' and populate the list view
            For Each carEntry As DictionaryEntry In Me.carList

                ' instantiate a new ListViewItem
                carList = New ListViewItem()

                ' get the customer from the list
                car = CType(carEntry.Value, Car)
                ' assign the values to the ckecked control
                'format the price
                formattedPrice = FormatCurrency(car.Price, , , TriState.True, TriState.True)
                ' and the subitems
                carList.Checked = car.Status
                carList.SubItems.Add(car.IdentificationNumber.ToString())
                carList.SubItems.Add(car.Make)
                carList.SubItems.Add(car.Model)
                carList.SubItems.Add(car.Year)
                carList.SubItems.Add(formattedPrice)

                ' add the new instantiated and populated ListViewItem
                ' to the listview control
                lvwInventory.Items.Add(carList)

            Next carEntry

            ' Alternate looping strategy
            'For index As Integer = 0 To customerList.Count - 1

            '    ' instantiate a new ListViewItem
            '    customerItem = New ListViewItem()

            '    ' get the customer from the list
            '    customer = CType(customerList(customerList.GetKey(index)), Customer)

            '    ' assign the values to the ckecked control
            '    ' and the subitems
            '    customerItem.Checked = customer.VeryImportantPersonStatus
            '    customerItem.SubItems.Add(customer.IdentificationNumber.ToString())
            '    customerItem.SubItems.Add(customer.Title)
            '    customerItem.SubItems.Add(customer.FirstName)
            '    customerItem.SubItems.Add(customer.LastName)

            '    ' add the new instantiated and populated ListViewItem
            '    ' to the listview control
            '    lvwCustomers.Items.Add(customerItem)

            'Next index

            ' clear the controls
            Reset()

            ' set the edit flag to false
            editMode = False

        End If

    End Sub

    ''' <summary>
    ''' Reset - set the controls back to their default state.
    ''' </summary>
    Private Sub Reset()


        tbModel.Text = String.Empty
        cmbYear.SelectedIndex = -1
        chkNew.Checked = False
        cmbMake.SelectedIndex = -1
        tbPrice.Text = String.Empty
        lbResult.Text = String.Empty

        carID = String.Empty

    End Sub

    ''' <summary>
    ''' IsValidInput - validates the data in each control to ensure that the user has entered apprpriate values
    ''' </summary>
    ''' <returns>Boolean</returns>
    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        ' check if the title has been selected
        If cmbMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's make." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If tbModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's model." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If cmbYear.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please enter the car's year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        ' check if the first name has been entered
        If (Not Double.TryParse(tbPrice.Text, tempPrice)) Then

            ' If not set the error message
            outputMessage += "Please enter a numeric value as a price." & vbCrLf

            ' And, set the return value to false
            returnValue = False
        ElseIf (tempPrice < 0) Then
            ' If not set the error message
            outputMessage += "Please enter a value bigger than zero as a price." & vbCrLf

            ' And, set the return value to false
            returnValue = False
        End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lbResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function

    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box. 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' call the rest sub routine
        Reset()

    End Sub
    ''' <summary>
    ''' Event is declared as private because it is only accessible within the form
    ''' The code in the btnExit_Click EventHandler will close the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This will close the form
        Me.Close()

    End Sub

    ''' <summary>
    ''' lvwCustomers_ItemCheck - used to prevent the user from checking the check box in the list view
    '''                        - if it is not in edit mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCustomers_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwInventory.ItemCheck

        ' if it is not in edit mode
        If editMode = False Then

            ' the new value to the current value
            ' so it cannot be set in the listview by the user
            e.NewValue = e.CurrentValue

        End If

    End Sub

    ''' <summary>
    ''' lvwCustomers_SelectedIndexChanged - when the user selected a row in the list it will populate the fields for editing
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub lvwCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwInventory.SelectedIndexChanged

        ' constant that represents the index of the subitem in the list that
        ' holds the customer identification number 
        Const identificationSubItemIndex As Integer = 1

        ' Get the customer identification number 
        carID = lvwInventory.Items(lvwInventory.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        ' Use the customer identification number to get the customer from the collection object
        Dim car As Car = CType(carList.Item(carID), Car)

        ' set the controls on the form
        tbModel.Text = car.Model               ' get the first name and set the text box
        cmbYear.Text = car.Year                 ' get the last name and set the text box
        cmbMake.Text = car.Make                     ' get the title and set the combo box
        chkNew.Checked = car.Status ' get the very important person status and set the combo box
        tbPrice.Text = CStr(car.Price)
        lbResult.Text = car.GetCarData()


    End Sub

    'Private Sub lvwCustomers_Click(sender As Object, e As EventArgs) Handles lvwCustomers.Click
    '    lbResult.Text = "aaa"
    'End Sub
End Class

