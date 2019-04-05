Option Strict On
Public Class Car


    Private Shared carCount As Integer                 ' static or shared private variable to hold the number of customers
    Private carID As Integer = 0     ' private variable to hold the customer's identification number
    Private carMake As String = String.Empty         ' private variable to hold the customer's title
    Private carModel As String = String.Empty     ' private variable to hold the customer's first name
    Private carYear As String = String.Empty      ' private variable to hold the customer's last name
    Private carPrice As Double = 0
    Private carNewStatus As Boolean = False              ' private variable to hold the customer's status

    ''' <summary>
    ''' Constructor - Default - creates a new customer object
    ''' </summary>
    Public Sub New()

        carCount += 1      ' increment the shared/static variable counter by 1
        carID = carCount ' assign the customers id

    End Sub

    ''' <summary>
    ''' Constructor - Parameterized - creates a new customer object
    ''' </summary>
    Public Sub New(make As String, model As String, year As String, price As Double, status As Boolean)

        ' call the other constructor 
        ' to set the customer count and
        ' to set the customer id
        Me.New()


        carMake = make          ' set the customer title
        carModel = model  ' set the customer first name
        carYear = year    ' set the customer last name
        carPrice = price
        carNewStatus = status        ' set the customer status

    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of customers that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific customers identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carID
        End Get
    End Property

    ''' <summary>
    ''' VeryImportantPersonStatus Property - >Gets and Sets the Very Important Person status of a customer
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property Status() As Boolean
        Get
            Return carNewStatus
        End Get
        Set(ByVal value As Boolean)
            carNewStatus = value
        End Set
    End Property

    ''' <summary>
    ''' Title property - Gets and Sets the title of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' FirstName property - Gets and Sets the first name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' LastName property - Gets and Sets the last name of a customer
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Year() As String
        Get
            Return carYear
        End Get
        Set(ByVal value As String)
            carYear = value
        End Set
    End Property

    ''' <summary>
    ''' Price property - Gets and Sets the price of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Price() As Double
        Get
            Return carPrice
        End Get
        Set(ByVal value As Double)
            carPrice = value
        End Set
    End Property

    ''' <summary>
    ''' GetSalutation is a function that a salutation based on the private properties within the class scope
    ''' </summary>
    ''' <returns>String</returns>
    Public Function GetCarData() As String

        Return "This car is a " & carMake & " " & carModel & " " & carYear & ", costs $" & carPrice & IIf(carNewStatus = True, " and it is new.", "and it is not new.").ToString()

    End Function


End Class
