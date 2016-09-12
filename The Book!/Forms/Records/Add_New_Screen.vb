Option Strict On
Option Explicit On

Public Class Add_New_Screen
    Dim New_Child As New Child ' Variable will hold new child entered
    Public Sub Add_Child()
        New_Child = New Child ' New Child Object
        With New_Child ' Child is an object and requires all of the variables below to hold values
            ' Values are gathered from textboxes, functions (that use radio buttons), and labels
            .strLastName = txtLastName.Text
            .strFirstName = txtFirstName.Text
            .strBirthday = txtBirthday.Text
            .strFlagDate = GetFlagDate(cboCurrentClassroom.Text, .strCurrentSpecificClassroom, txtBirthday.Text)
            .intAge = GetAge(txtBirthday.Text)
            .intMonths = GetMonths(txtBirthday.Text)
            .strCurrentClassroom = cboCurrentClassroom.Text
            .strNextClassroom = GetNextClassroom(cboCurrentClassroom.Text)
            .strMonday = DaysOfTheWeek("Monday")
            .strTuesday = DaysOfTheWeek("Tuesday")
            .strWednesday = DaysOfTheWeek("Wednesday")
            .strThursday = DaysOfTheWeek("Thursday")
            .strFriday = DaysOfTheWeek("Friday")
            .intUnique = CInt(txtUniqueIdentifier.Text)
            .strStartDate = txtStartDate.Text
        End With

        ' Add New Child to lstChild list
        Child.lstChild.Add(New_Child)

        ' unselect listbox
        Records_Screen.lstRecords.SelectedIndex = -1

        ' add child to database
        Dim oDatabase_Handling As New Database_Handling
        oDatabase_Handling.AddChild(New_Child.strLastName, New_Child.strFirstName, New_Child.strBirthday, New_Child.intAge, New_Child.intMonths, _
                                    New_Child.strFlagDate, New_Child.strCurrentClassroom, New_Child.strNextClassroom, _
                                    New_Child.strCurrentSpecificClassroom, New_Child.strNextSpecificClassroom, New_Child.strMonday, New_Child.strTuesday, _
                                    New_Child.strWednesday, New_Child.strThursday, New_Child.strFriday, New_Child.intUnique, New_Child.strStartDate, New_Child.strEndDate)

        ' close form
        Me.Close()
    End Sub

    ' function to get flag date
    Public Function GetFlagDate(ByVal strCurrentClassroom As String, ByVal strSpecificClassroom As String, ByVal strBirthday As String) As String
        Dim intDOBMonth As Integer = CInt(strBirthday.Substring(0, 2)) ' get birthday month
        Dim intDOBYear As Integer = CInt(strBirthday.Substring(6, 4)) ' get child age
        Dim intDOBDay As Integer = CInt(strBirthday.Substring(3, 2)) ' get child day of birth

        Dim strCurrentDate As String = DateTime.Now.ToString("MM/dd/yyyy") ' get current date
        Dim intCurrentMonth As Integer = CInt(strCurrentDate.Substring(0, 2)) ' get current month
        Dim intCurrentYear As Integer = CInt(strCurrentDate.Substring(6, 4)) ' get current year

        Dim bolNone As Boolean = False ' if true, flag date is set to "None" (see below, used when child is in tree frogs or kindergarten)

        ' check current classroom 
        ' check when child will reach benchmark to be able to transition to next room (benchmark depends on room)
        ' the flag date is the date the child will *officially* be able to move to the next room, but is NOT the date in which the child will ALWAYS move. It's just a reference point, a child needs to be ready to move also - transitioning is all USER controlled
        ' these all add the benchmark age to the child's birthday to get the flag date
        Select Case strCurrentClassroom

            ' caterpillars benchmark 
            Case Is = "Caterpillars" ' benchmark: 10 months
                intDOBMonth += 10
                If intDOBMonth > 12 Then
                    intDOBMonth -= 12
                    intDOBYear += 1
                End If

                ' turtles/butterflies benchmark 
            Case Is = "Turtles/Butterflies" ' benchmark: one year, 10 months
                intDOBYear += 1
                intDOBMonth += 10
                If intDOBMonth > 12 Then
                    intDOBMonth -= 12
                    intDOBYear += 1
                End If

                ' fireflies/ladybugs benchmark 
            Case Is = "Fireflies/Ladybugs" ' benchmark: two years, 10 months
                intDOBYear += 2
                intDOBMonth += 10
                If intDOBMonth > 12 Then
                    intDOBMonth -= 12
                    intDOBYear += 1
                End If

                ' dragonflies/lions benchmark
            Case Is = "Dragonflies/Lions" ' benchmark: three years, 10 months
                intDOBYear += 3
                intDOBMonth += 10
                If intDOBMonth > 12 Then
                    intDOBMonth -= 12
                    intDOBYear += 1
                End If

                ' tree frogs and kindergarten have no benchmark.
                ' tree frogs don't immediately precede another classroom.
                ' kindergarten isn't related to preschool the way the other rooms are related to eachother.
                ' in these cases, the flagdate is set to "None", and these children omit flag dates as data correlation
            Case Else
                bolNone = True
        End Select

        ' if day is above 28, check to make sure that month has that many days, and fix it if necessary
        Select Case intDOBMonth
            Case Is = 2 ' february, 28 days
                If intDOBDay > 28 Then
                    intDOBDay = 28
                End If
            Case Is = 4 ' april, 30 days
                If intDOBDay > 30 Then
                    intDOBDay = 30
                End If
            Case Is = 6
                If intDOBDay > 30 Then
                    intDOBDay = 30
                End If
            Case Is = 9
                If intDOBDay > 30 Then
                    intDOBDay = 30
                End If
            Case Is = 11
                If intDOBDay > 30 Then
                    intDOBDay = 30
                End If
        End Select

        ' add 0 when needed to keep mm/dd/yyyy format
        Dim strMonth As String
        If intDOBMonth < 10 Then
            strMonth = "0" & intDOBMonth.ToString
        Else
            strMonth = intDOBMonth.ToString
        End If
        ' add 0 when needed to keep mm/dd/yyyy format
        Dim strDay As String
        If intDOBDay < 10 Then
            strDay = "0" & intDOBDay.ToString
        Else
            strDay = intDOBDay.ToString
        End If

        If bolNone = False Then
            GetFlagDate = (strMonth & "/" & strDay & "/" & intDOBYear).ToString ' put date together 
        Else
            GetFlagDate = "None" ' when child in tree frogs or kindergarten, they have no flag date
        End If

        Return GetFlagDate
    End Function

    ' function to get child age
    Public Function GetAge(ByVal strBirthday As String) As Integer
        ' get age by checking birthday
        Dim strCurrentDate As String = DateTime.Now.ToString("MM/dd/yyyy")
        ' Dim intMonth As Integer = CInt(strBirthday.Substring(0, 2))
        Dim intDOBYear As Integer = CInt(strBirthday.Substring(6, 4))
        Dim intCurrentYear As Integer = CInt(strCurrentDate.Substring(6, 4))
        GetAge = intCurrentYear - intDOBYear

        Dim intDOBMonth As Integer = CInt(strBirthday.Substring(0, 2))
        Dim intCurrentMonth As Integer = CInt(strCurrentDate.Substring(0, 2))
        GetAge = intCurrentYear - intDOBYear
        Dim intMonth As Integer = intCurrentMonth - intDOBMonth
        If intMonth < 0 Then
            Math.Abs(intMonth)
            GetAge -= 1
        End If
        ' GetAge = CInt(Math.Floor(DateDiff(DateInterval.Month, DateValue(strBirthday), Now()) / 12))
        Return GetAge
    End Function

    ' function to get months old 
    Public Function GetMonths(ByVal strBirthday As String) As Integer
        Dim strCurrentDate = DateTime.Now.ToString("MM/dd/yyyy")
        Dim intDOBMonth As Integer = CInt(strBirthday.Substring(0, 2))
        Dim intCurrentMonth As Integer = CInt(strCurrentDate.Substring(0, 2))
        GetMonths = intCurrentMonth - intDOBMonth
        If GetMonths < 0 Then
            GetMonths = Math.Abs(GetMonths)
            GetMonths = 12 - GetMonths
        End If

        Return GetMonths
    End Function

    ' function to get next classroom
    Private Function GetNextClassroom(ByVal strCurrentClassroom As String) As String
        GetNextClassroom = ""
        Select Case strCurrentClassroom ' depending on current classroom, set next classroom based on it
            Case Is = "Caterpillars"
                GetNextClassroom = "Turtles/Butterflies"
            Case Is = "Turtles/Butterflies"
                GetNextClassroom = "Fireflies/Ladybugs"
            Case Is = "Fireflies/Ladybugs"
                GetNextClassroom = "Dragonflies/Lions"
            Case Is = "Dragonflies/Lions"
                GetNextClassroom = "Tree Frogs"
                ' Since Tree Frogs and Kindergarten don't have a logical next classroom, they are set to "TBA"
            Case Is = "Tree Frogs"
                GetNextClassroom = "TBA"
            Case Is = "Kindergarten"
                GetNextClassroom = "TBA"
        End Select

        Return GetNextClassroom
    End Function

    ' function to get time slots for each child on any given day
    Private Function DaysOfTheWeek(strDayTime As String) As String
        DaysOfTheWeek = ""
        ' depending on which radio buttons are pressed, that will be the child time slot on a given day
        Select Case strDayTime ' check which day is passed to function
            Case Is = "Monday"
                If rbFull_Day_Monday.Checked = True Then
                    DaysOfTheWeek = "Full Day"
                ElseIf rbHalf_AM_Monday.Checked = True Then
                    DaysOfTheWeek = "Half AM"
                ElseIf rbHalf_PM_Monday.Checked = True Then
                    DaysOfTheWeek = "Half PM"
                Else
                    DaysOfTheWeek = "Absent"
                End If
            Case Is = "Tuesday"
                If rbFull_Day_Tuesday.Checked = True Then
                    DaysOfTheWeek = "Full Day"
                ElseIf rbHalf_AM_Tuesday.Checked = True Then
                    DaysOfTheWeek = "Half AM"
                ElseIf rbHalf_PM_Tuesday.Checked = True Then
                    DaysOfTheWeek = "Half PM"
                Else
                    DaysOfTheWeek = "Absent"
                End If
            Case Is = "Wednesday"
                If rbFull_Day_Wednesday.Checked = True Then
                    DaysOfTheWeek = "Full Day"
                ElseIf rbHalf_AM_Wednesday.Checked = True Then
                    DaysOfTheWeek = "Half AM"
                ElseIf rbHalf_PM_Wednesday.Checked = True Then
                    DaysOfTheWeek = "Half PM"
                Else
                    DaysOfTheWeek = "Absent"
                End If
            Case Is = "Thursday"
                If rbFull_Day_Thursday.Checked = True Then
                    DaysOfTheWeek = "Full Day"
                ElseIf rbHalf_AM_Thursday.Checked = True Then
                    DaysOfTheWeek = "Half AM"
                ElseIf rbHalf_PM_Thursday.Checked = True Then
                    DaysOfTheWeek = "Half PM"
                Else
                    DaysOfTheWeek = "Absent"
                End If
            Case Is = "Friday"
                If rbFull_Day_Friday.Checked = True Then
                    DaysOfTheWeek = "Full Day"
                ElseIf rbHalf_AM_Friday.Checked = True Then
                    DaysOfTheWeek = "Half AM"
                ElseIf rbHalf_PM_Friday.Checked = True Then
                    DaysOfTheWeek = "Half PM"
                Else
                    DaysOfTheWeek = "Absent"
                End If
        End Select
        Return DaysOfTheWeek
    End Function

    ' function to get child unique identifier 
    Private Function GetUniqueIdentifier() As Integer
        Dim intID As Integer
        Dim oDatabase_Handling As New Database_Handling
        oDatabase_Handling.GetNextID(intID) ' go to Database_Handling and pass byRef intID to get the next unique identifier
        GetUniqueIdentifier = intID
        Return GetUniqueIdentifier
    End Function

    ' draws graphics to screen
    Private Sub Form_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim imgBorder As New Bitmap(My.Resources.AddNewBorder)
        imgBorder.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(New Bitmap(imgBorder), 42, 40, 740, 494)
    End Sub

    ' button to click when user believes he or she is done filling out info for adding a new child
    Private Sub clpAccept_Click(sender As Object, e As EventArgs) Handles clpAccept.Click
        InputValidation() ' goes to InputValidation sub to ensure all data is entered correctly
    End Sub

    ' sub is called when accept button is pressed
    Private Sub InputValidation()
        Dim bolError = False ' if true, there is an error
        If txtLastName.Text = "" Then ' is lastname text box empty?
            bolError = True
        ElseIf txtFirstName.Text = "" Then ' is firstname text box empty?
            bolError = True

            ' is current classroom one of the options available?
        ElseIf cboCurrentClassroom.Text <> "Caterpillars" And cboCurrentClassroom.Text <> "Turtles/Butterflies" And cboCurrentClassroom.Text <> "Fireflies/Ladybugs" _
            And cboCurrentClassroom.Text <> "Dragonflies/Lions" And cboCurrentClassroom.Text <> "Tree Frogs" And cboCurrentClassroom.Text <> "Kindergarten" Then
            bolError = True

            ' are dates entered correctly? (mm/dd/yyyy)
        ElseIf IsDate(txtBirthday.Text) = False Or txtBirthday.Text.Length <> 10 Then
            bolError = True

            ' are dates entered correctly? (mm/dd/yyyy) OR are fields left blank (which is okay, start date and end date are optional)
        ElseIf txtStartDate.Text <> "" Then
            If IsDate(txtStartDate.Text) = False Or txtStartDate.Text.Length <> 10 Then
                bolError = True
            End If

            ' is at least one radio button for each day of the week selected?
        ElseIf rbFull_Day_Monday.Checked = False And rbHalf_AM_Monday.Checked = False And rbHalf_PM_Monday.Checked = False And rbAbsent_Monday.Checked = False Then
            bolError = True
        ElseIf rbFull_Day_Tuesday.Checked = False And rbHalf_AM_Tuesday.Checked = False And rbHalf_PM_Tuesday.Checked = False And rbAbsent_Tuesday.Checked = False Then
            bolError = True
        ElseIf rbFull_Day_Wednesday.Checked = False And rbHalf_AM_Wednesday.Checked = False And rbHalf_PM_Wednesday.Checked = False And rbAbsent_Wednesday.Checked = False Then
            bolError = True
        ElseIf rbFull_Day_Thursday.Checked = False And rbHalf_AM_Thursday.Checked = False And rbHalf_PM_Thursday.Checked = False And rbAbsent_Thursday.Checked = False Then
            bolError = True
        ElseIf rbFull_Day_Friday.Checked = False And rbHalf_AM_Friday.Checked = False And rbHalf_PM_Friday.Checked = False And rbAbsent_Friday.Checked = False Then
            bolError = True
        End If

        If bolError = False Then ' if no error...
            Add_Child() ' go to sub Add_Child
        Else ' if error, display error message
            MessageBox.Show("Error - Please check the following:" & vbNewLine & vbNewLine & " - Required fields are not left blank." & vbNewLine _
                            & " - Date format is correct (mm/dd/yyyy)." & vbNewLine & " - Current classroom is one of the given options." & vbNewLine _
                            & " - One time slot is selected for each day of the week.", "Error")
        End If
    End Sub

    Private Sub Add_New_Screen_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtUniqueIdentifier.Text = GetUniqueIdentifier().ToString ' calls function GetUniqueIdentifier to update textbox Unique Identifier
    End Sub

    Private Sub Add_New_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboCurrentClassroom.Text = CStr(cboCurrentClassroom.Items(0)) ' put default value in combo box current classroom
    End Sub

    Private Sub clpCancel_Click(sender As Object, e As EventArgs) Handles clpCancel.Click
        ' checks to make sure user is okay with exiting add child and losing their possible previous inputs
        Dim intResult As Integer = MessageBox.Show("Are you sure you want to cancel adding a new child?" & vbNewLine & "Information will not be saved.", "Are you sure?", MessageBoxButtons.YesNoCancel)
        If intResult = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub


    Private Sub cboCurrentClassroom_DropDown(sender As Object, e As EventArgs) Handles cboCurrentClassroom.DropDown
        ' if default value is still in combobox when clicked ("select a classroom..."
        If cboCurrentClassroom.Items.Count = 7 Then
            cboCurrentClassroom.Items.RemoveAt(0) ' remove it
        End If
    End Sub
End Class