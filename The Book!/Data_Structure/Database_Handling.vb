Option Strict On
Option Explicit On

Public Class Database_Handling

    Dim con As New OleDb.OleDbConnection ' creates a new database connection

    Dim dbProvider As String ' provider that will open database
    Dim dbSource As String ' database file source

    Public Shared ds As New DataSet ' dataset (where data table is stored)
    Public Shared da As OleDb.OleDbDataAdapter ' allows SQL to be used in database from program
    Dim sql As String ' sql commands to be used

    Public Sub Open()
        If System.IO.File.Exists("The_Book!_Database.accdb") Then
            dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;"
            dbSource = "Data Source = The_Book!_Database.accdb"

            con.ConnectionString = dbProvider & dbSource

            sql = "SELECT * FROM Child"
            da = New OleDb.OleDbDataAdapter(sql, con)
            da.Fill(ds, "Child")

            con.Open() ' Database is now open
            con.Close() ' Database is now Closed
        End If
    End Sub

    Dim Load_Child As New Child ' used to load child from database
    Public Sub LoadList(ByRef inc As Integer)
        ' load child objects from database, add them to lstChild
        Load_Child = New Child
        Try
            Load_Child.strLastName = ds.Tables("Child").Rows(inc).Item(1).ToString ' last name
            Load_Child.strFirstName = ds.Tables("Child").Rows(inc).Item(2).ToString ' first name
            Load_Child.strBirthday = ds.Tables("Child").Rows(inc).Item(3).ToString ' birthday
            Load_Child.strFlagDate = ds.Tables("Child").Rows(inc).Item(4).ToString ' flag date
            Load_Child.intAge = CInt(ds.Tables("Child").Rows(inc).Item(5)) ' age
            Load_Child.intMonths = CInt(ds.Tables("Child").Rows(inc).Item(6)) ' months
            Load_Child.strCurrentClassroom = ds.Tables("Child").Rows(inc).Item(7).ToString ' current classroom
            Load_Child.strNextClassroom = ds.Tables("Child").Rows(inc).Item(8).ToString ' next classroom
            Load_Child.strCurrentSpecificClassroom = ds.Tables("Child").Rows(inc).Item(9).ToString ' current specific classroom
            Load_Child.strNextSpecificClassroom = ds.Tables("Child").Rows(inc).Item(10).ToString ' next specific classroom
            Load_Child.strMonday = ds.Tables("Child").Rows(inc).Item(11).ToString ' monday
            Load_Child.strTuesday = ds.Tables("Child").Rows(inc).Item(12).ToString ' tuesday
            Load_Child.strWednesday = ds.Tables("Child").Rows(inc).Item(13).ToString ' wednesday
            Load_Child.strThursday = ds.Tables("Child").Rows(inc).Item(14).ToString ' thursday
            Load_Child.strFriday = ds.Tables("Child").Rows(inc).Item(15).ToString ' friday
            Load_Child.intUnique = CInt(ds.Tables("Child").Rows(inc).Item(16)) ' unique identifier
            Load_Child.strStartDate = ds.Tables("Child").Rows(inc).Item(17).ToString ' start date
            Load_Child.strEndDate = ds.Tables("Child").Rows(inc).Item(18).ToString ' end date

            ' add to lstChild list
            Child.lstChild.Add(Load_Child)
            ' add one to the increment
            inc += 1
        Catch ex As Exception
        End Try

    End Sub

    ' adds new child to database
    Public Sub AddChild(ByVal strLastName As String, ByVal strFirstName As String, ByVal strBirthday As String, ByVal intAge As Integer, ByVal intMonths As Integer, _
                                    ByVal strFlagDate As String, strCurrentClassroom As String, ByVal strNextClassroom As String, _
                                    ByVal strCurrentSpecificClassroom As String, ByVal strNextSpecificClassroom As String, ByVal strMonday As String, ByVal strTuesday As String, _
                                    ByVal strWednesday As String, ByVal strThursday As String, ByVal strFriday As String, ByVal intUnique As Integer, ByVal strStartDate As String, ByVal strEndDate As String)

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        Dim dsNewRow As DataRow ' dimension a row in the database

        dsNewRow = ds.Tables("Child").NewRow() ' new row in database

        ' put new child information in the new row
        dsNewRow.Item("Last Name") = strLastName
        dsNewRow.Item("First Name") = strFirstName
        dsNewRow.Item("Birthday") = strBirthday
        dsNewRow.Item("Flag Date") = strFlagDate
        dsNewRow.Item("Age") = intAge
        dsNewRow.Item("Months") = intMonths
        dsNewRow.Item("Current Classroom") = strCurrentClassroom
        dsNewRow.Item("Next Classroom") = strNextClassroom
        dsNewRow.Item("Current Specific Classroom") = strCurrentSpecificClassroom
        dsNewRow.Item("Next Specific Classroom") = strNextSpecificClassroom
        dsNewRow.Item("Monday") = strMonday
        dsNewRow.Item("Tuesday") = strTuesday
        dsNewRow.Item("Wednesday") = strWednesday
        dsNewRow.Item("Thursday") = strThursday
        dsNewRow.Item("Friday") = strFriday
        dsNewRow.Item("Unique Identifier") = intUnique
        dsNewRow.Item("Start Date") = strStartDate
        dsNewRow.Item("End Date") = strEndDate

        ' add the row
        ds.Tables("Child").Rows.Add(dsNewRow)

        ' update database
        da.Update(ds, "Child")


    End Sub

    ' gets the next unused Unique Identifier for new child
    Public Sub GetNextID(ByRef intID As Integer)
        '  Open() ' open database, fill dataset with most recent contents
        Dim intMaxRows As Integer = ds.Tables("Child").Rows.Count ' get the number of total rows in dataset
        Dim intMore As Integer
        ' MessageBox.Show(intMaxRows.ToString)
        If Not intMaxRows = 0 Then
            For i = 0 To intMaxRows - 1
                intMore = CInt(ds.Tables("Child").Rows(i).Item(16))
                If intMore > intID Then
                    intID = intMore
                End If


                'intID = CInt(ds.Tables("Child").Rows(intMaxRows - 1).Item(16)) ' the last ID number in the dataset is set to intID
                'intID += 1 ' add one to that ID number to get the next one to use
            Next
            intID += 1
        Else
            intID = 1
        End If
    End Sub

    ' updates child in database after being edited
    Public Sub EditChild(ByVal strLastName As String, ByVal strFirstName As String, ByVal strBirthday As String, ByVal strFlagDate As String, _
                         ByVal strCurrentClassroom As String, ByVal strNextClassroom As String, ByVal strCurrentSpecificClassroom As String, _
                         ByVal strNextSpecificClassroom As String, ByVal strMonday As String, ByVal strTuesday As String, ByVal strWednesday As String, _
                         ByVal strThursday As String, ByVal strFriday As String, ByVal strStartDate As String, ByVal strEndDate As String, ByVal intAge As Integer, _
                         ByVal intMonths As Integer, ByVal intUnique As Integer)

        Open() ' reopen database and build dataset

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        Dim intRowNumber As Integer
        Dim intMaxRows As Integer = ds.Tables("Child").Rows.Count 'get the number of total rows in dataset
        Dim intUniqueID As Integer
        For i = 0 To intMaxRows - 1 ' loop through rows of database
            intUniqueID = CInt(ds.Tables("Child").Rows(i).Item(16)) ' intUniqueID equals each UniqueIdentifier in the database
            If intUniqueID = intUnique Then ' if the unique ID of a child matches the unique ID of the edited child, update that child's data in the database
                intRowNumber = i
            End If
        Next

        ds.Tables("Child").Rows(intRowNumber).Item("Last Name") = strLastName
        ds.Tables("Child").Rows(intRowNumber).Item("First Name") = strFirstName
        ds.Tables("Child").Rows(intRowNumber).Item("Birthday") = strBirthday
        ds.Tables("Child").Rows(intRowNumber).Item("Flag Date") = strFlagDate
        ds.Tables("Child").Rows(intRowNumber).Item("Age") = intAge
        ds.Tables("Child").Rows(intRowNumber).Item("Months") = intMonths
        ds.Tables("Child").Rows(intRowNumber).Item("Current Classroom") = strCurrentClassroom
        ds.Tables("Child").Rows(intRowNumber).Item("Next Classroom") = strNextClassroom
        ds.Tables("Child").Rows(intRowNumber).Item("Current Specific Classroom") = strCurrentSpecificClassroom
        ds.Tables("Child").Rows(intRowNumber).Item("Next Specific Classroom") = strNextSpecificClassroom
        ds.Tables("Child").Rows(intRowNumber).Item("Monday") = strMonday
        ds.Tables("Child").Rows(intRowNumber).Item("Tuesday") = strTuesday
        ds.Tables("Child").Rows(intRowNumber).Item("Wednesday") = strWednesday
        ds.Tables("Child").Rows(intRowNumber).Item("Thursday") = strThursday
        ds.Tables("Child").Rows(intRowNumber).Item("Friday") = strFriday
        ds.Tables("Child").Rows(intRowNumber).Item("Start Date") = strStartDate
        ds.Tables("Child").Rows(intRowNumber).Item("End Date") = strEndDate

        ' update database
        da.Update(ds, "Child")
    End Sub

    Public Sub DeleteChild(ByVal intUnique As Integer)
        Open() ' reopen database and build dataset

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"

        Dim intRowNumber As Integer
        Dim intMaxRows As Integer = ds.Tables("Child").Rows.Count 'get the number of total rows in dataset
        Dim intUniqueID As Integer
        For i = 0 To intMaxRows - 1 ' loop through rows of database
            intUniqueID = CInt(ds.Tables("Child").Rows(i).Item(16)) ' intUniqueID equals each UniqueIdentifier in the database
            If intUniqueID = intUnique Then ' if the unique ID of a child matches the unique ID of the edited child, update that child's data in the database
                intRowNumber = i
            End If
        Next
        ' delete child from database
        ds.Tables("Child").Rows(intRowNumber).Delete()
        da.Update(ds, "Child")

    End Sub


End Class
