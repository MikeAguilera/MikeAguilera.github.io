Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Globalization

Public Class ChangePasswordModel
    Private oldPasswordValue As String
    Private newPasswordValue As String
    Private confirmPasswordValue As String

    <Required()> _
    <DataType(DataType.Password)> _
    <Display(Name:="Current password")> _
    Public Property OldPassword() As String
        Get
            Return oldPasswordValue
        End Get
        Set(ByVal value As String)
            oldPasswordValue = value
        End Set
    End Property

    <Required()> _
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)> _
    <DataType(DataType.Password)> _
    <Display(Name:="New password")> _
    Public Property NewPassword() As String
        Get
            Return newPasswordValue
        End Get
        Set(ByVal value As String)
            newPasswordValue = value
        End Set
    End Property

    <DataType(DataType.Password)> _
    <Display(Name:="Confirm new password")> _
    <Compare("NewPassword", ErrorMessage:="The new password and confirmation password do not match.")> _
    Public Property ConfirmPassword() As String
        Get
            Return confirmPasswordValue
        End Get
        Set(ByVal value As String)
            confirmPasswordValue = value
        End Set
    End Property
End Class

Public Class LoginModel
    Private userNameValue As String
    Private passwordValue As String
    Private rememberMeValue As Boolean

    <Required()> _
    <Display(Name:="User name")> _
    Public Property UserName() As String
        Get
            Return userNameValue
        End Get
        Set(ByVal value As String)
            userNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Password)> _
    <Display(Name:="Password")> _
    Public Property Password() As String
        Get
            Return passwordValue
        End Get
        Set(ByVal value As String)
            passwordValue = value
        End Set
    End Property

    <Display(Name:="Remember me?")> _
    Public Property RememberMe() As Boolean
        Get
            Return rememberMeValue
        End Get
        Set(ByVal value As Boolean)
            rememberMeValue = value
        End Set
    End Property
End Class

Public Class RegisterModel
    Private userNameValue As String
    Private passwordValue As String
    Private confirmPasswordValue As String
    Private emailValue As String

    <Required()> _
    <Display(Name:="User name")> _
    Public Property UserName() As String
        Get
            Return userNameValue
        End Get
        Set(ByVal value As String)
            userNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.EmailAddress)> _
    <Display(Name:="Email address")> _
    Public Property Email() As String
        Get
            Return emailValue
        End Get
        Set(ByVal value As String)
            emailValue = value
        End Set
    End Property

    <Required()> _
    <StringLength(100, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=6)> _
    <DataType(DataType.Password)> _
    <Display(Name:="Password")> _
    Public Property Password() As String
        Get
            Return passwordValue
        End Get
        Set(ByVal value As String)
            passwordValue = value
        End Set
    End Property

    <DataType(DataType.Password)> _
    <Display(Name:="Confirm password")> _
    <Compare("Password", ErrorMessage:="The password and confirmation password do not match.")> _
    Public Property ConfirmPassword() As String
        Get
            Return confirmPasswordValue
        End Get
        Set(ByVal value As String)
            confirmPasswordValue = value
        End Set
    End Property
End Class

Public Class CaseModel
    Private lastNameValue As String
    Private firstNameValue As String
    Private dateOfBirthValue As String
    Private placementValue As String

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Last Name")> _
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="First Name")> _
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get
        Set(ByVal value As String)
            firstNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
   <Display(Name:="DOB")> _
    Public Property DateOfBirth() As String
        Get
            Return dateOfBirthValue
        End Get
        Set(ByVal value As String)
            dateOfBirthValue = value
        End Set
    End Property

    <Required()> _
   <DataType(DataType.Text)> _
   <Display(Name:="Placement Request #")> _
    Public Property Placement() As String
        Get
            Return placementValue
        End Get
        Set(ByVal value As String)
            placementValue = value
        End Set
    End Property
End Class

Public Class CaseModelCaseload
    Private lastNameValue As String
    Private firstNameValue As String
    Private dateOfBirthValue As String
    Private placementValue As String

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Last Name")> _
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="First Name")> _
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get
        Set(ByVal value As String)
            firstNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
   <Display(Name:="DOB")> _
    Public Property DateOfBirth() As String
        Get
            Return dateOfBirthValue
        End Get
        Set(ByVal value As String)
            dateOfBirthValue = value
        End Set
    End Property

    <Required()> _
   <DataType(DataType.Text)> _
   <Display(Name:="Placement Home")> _
    Public Property Placement() As String
        Get
            Return placementValue
        End Get
        Set(ByVal value As String)
            placementValue = value
        End Set
    End Property
End Class

Public Class CsCaseModel
    Private lastNameValue As String
    Private firstNameValue As String
    Private dateOfBirthValue As String
    Private placementValue As String

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Last Name")> _
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="First Name")> _
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get
        Set(ByVal value As String)
            firstNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="DOB")> _
    Public Property DateOfBirth() As String
        Get
            Return dateOfBirthValue
        End Get
        Set(ByVal value As String)
            dateOfBirthValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Placement Address")> _
    Public Property Placement() As String
        Get
            Return placementValue
        End Get
        Set(ByVal value As String)
            placementValue = value
        End Set
    End Property
End Class

Public Class ErCaseModel
    Private lastNameValue As String
    Private firstNameValue As String
    Private dateOfBirthValue As String
    Private placementValue As String
    Private referralValue As String

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Last Name")> _
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="First Name")> _
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get
        Set(ByVal value As String)
            firstNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
   <Display(Name:="DOB")> _
    Public Property DateOfBirth() As String
        Get
            Return dateOfBirthValue
        End Get
        Set(ByVal value As String)
            dateOfBirthValue = value
        End Set
    End Property

    <Required()> _
   <DataType(DataType.Text)> _
   <Display(Name:="Placement Address")> _
    Public Property Placement() As String
        Get
            Return placementValue
        End Get
        Set(ByVal value As String)
            placementValue = value
        End Set
    End Property

    <Required()> _
  <DataType(DataType.Text)> _
  <Display(Name:="Referral Number")> _
    Public Property Referral() As String
        Get
            Return referralValue
        End Get
        Set(ByVal value As String)
            referralValue = value
        End Set
    End Property

End Class

Public Class PendingPlacementModel
    Private lastNameValue As String
    Private firstNameValue As String
    Private dateOfBirthValue As String
    Private placementValue As String

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Last Name")> _
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="First Name")> _
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get
        Set(ByVal value As String)
            firstNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="DOB")> _
    Public Property DateOfBirth() As String
        Get
            Return dateOfBirthValue
        End Get
        Set(ByVal value As String)
            dateOfBirthValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Placement Address")> _
    Public Property Placement() As String
        Get
            Return placementValue
        End Get
        Set(ByVal value As String)
            placementValue = value
        End Set
    End Property
End Class

Public Class ConfirmedPlacementModel
    Private lastNameValue As String
    Private firstNameValue As String
    Private dateOfBirthValue As String
    Private placementValue As String
    Private startDateValue As String


    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Last Name")> _
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="First Name")> _
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get
        Set(ByVal value As String)
            firstNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="DOB")> _
    Public Property DateOfBirth() As String
        Get
            Return dateOfBirthValue
        End Get
        Set(ByVal value As String)
            dateOfBirthValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Placement Home")> _
    Public Property Placement() As String
        Get
            Return placementValue
        End Get
        Set(ByVal value As String)
            placementValue = value
        End Set
    End Property
    <Required()> _
   <DataType(DataType.Text)> _
   <Display(Name:="Start Date")> _
    Public Property StartDate() As String
        Get
            Return startDateValue
        End Get
        Set(ByVal value As String)
            startDateValue = value
        End Set
    End Property

End Class
Public Class CaseSearchModel
    Private lastNameValue As String
    Private firstNameValue As String
    Private dateOfBirthValue As String
    Private placementValue As String

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="Last Name")> _
    Public Property LastName() As String
        Get
            Return lastNameValue
        End Get
        Set(ByVal value As String)
            lastNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
    <Display(Name:="First Name")> _
    Public Property FirstName() As String
        Get
            Return firstNameValue
        End Get
        Set(ByVal value As String)
            firstNameValue = value
        End Set
    End Property

    <Required()> _
    <DataType(DataType.Text)> _
   <Display(Name:="DOB")> _
    Public Property DateOfBirth() As String
        Get
            Return dateOfBirthValue
        End Get
        Set(ByVal value As String)
            dateOfBirthValue = value
        End Set
    End Property

    <Required()> _
   <DataType(DataType.Text)> _
   <Display(Name:="Placement Request #")> _
    Public Property Placement() As String
        Get
            Return placementValue
        End Get
        Set(ByVal value As String)
            placementValue = value
        End Set
    End Property
End Class
