Option Strict On
Option Explicit On

' Child Class (Creation of object "Child")
Public Class Child

    Public strLastName As String ' Last Name
    Public strFirstName As String ' First Name
    Public strBirthday As String ' Birthday
    Public strFlagDate As String ' Date to flag (10 months after birthday by default)
    Public intAge As Integer ' Age
    Public intMonths As Integer ' Months 
    Public strCurrentClassroom As String ' Classroom
    Public strNextClassroom As String ' Classroom after transition
    Public strCurrentSpecificClassroom As String ' Specific Classroom (in case of turtles/butterflies, ladybugs/fireflies, and dragonflies/lions
    Public strNextSpecificClassroom As String ' next specific classroom

    ' Days/Times student is at Preschool
    Public strMonday As String
    Public strTuesday As String
    Public strWednesday As String
    Public strThursday As String
    Public strFriday As String
   

    ' Child unique identifier
    Public intUnique As Integer

    ' Check if child is starting yet or not
    Public strStartDate As String
    Public strEndDate As String

    Public Shared lstChild As New List(Of Child) ' List of Child Objects
End Class

