Public Class Edit
    Dim intUniqueID As Integer
    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' find child name
        intUniqueID = lblUnique.Text ' lblUnique has unique identifier from projection screen (if activated from there)
            For Each value In Child.lstChild ' loop through list
            If intUniqueID = value.intUnique Then
                lblName.Text = value.strLastName & ", " & value.strFirstName ' lblName equals the child's last name, first name
                lblName.Left = CInt(Me.Width / 2 - lblName.Width / 2) ' center label horizontally
            End If
            Next

        ' fill in textboxes with child information
        FillTextBoxes(intUniqueID)
    End Sub

    Private Sub FillTextBoxes(ByVal intUnique As Integer)
        For Each value In Child.lstChild ' loop through lstChild
            If value.intUnique = intUniqueID Then ' if unique id matches
                ' fill in textboxes with child information
                txtLastName.Text = value.strLastName
                txtFirstName.Text = value.strFirstName
                txtBirthday.Text = value.strBirthday
                txtFlagDate.Text = value.strFlagDate
                txtStartDate.Text = value.strStartDate
                txtEndDate.Text = value.strEndDate
                txtUniqueIdentifier.Text = value.intUnique
                cboCurrentClassroom.Text = value.strCurrentClassroom
                cboNextClassroom.Text = value.strNextClassroom
                cboCurrentSpecificClassroom.Text = value.strCurrentSpecificClassroom
                cboNextSpecificClassroom.Text = value.strNextSpecificClassroom
                If cboCurrentSpecificClassroom.Text = "" Then
                    cboCurrentSpecificClassroom.Text = cboCurrentSpecificClassroom.Items(0)
                End If
                If cboNextSpecificClassroom.Text = "" Then
                    cboNextSpecificClassroom.Text = cboCurrentSpecificClassroom.Items(0)
                End If
               
                ' fill in days of the week radio buttons depending on child attendance
                Select Case value.strMonday
                    Case Is = "Full Day"
                        rbFull_Day_Monday.Checked = True
                    Case Is = "Half AM"
                        rbHalf_AM_Monday.Checked = True
                    Case Is = "Half PM"
                        rbHalf_PM_Monday.Checked = True
                    Case Is = "Absent"
                        rbAbsent_Monday.Checked = True
                End Select
                Select Case value.strTuesday
                    Case Is = "Full Day"
                        rbFull_Day_Tuesday.Checked = True
                    Case Is = "Half AM"
                        rbHalf_AM_Tuesday.Checked = True
                    Case Is = "Half PM"
                        rbHalf_PM_Tuesday.Checked = True
                    Case Is = "Absent"
                        rbAbsent_Tuesday.Checked = True
                End Select
                Select Case value.strWednesday
                    Case Is = "Full Day"
                        rbFull_Day_Wednesday.Checked = True
                    Case Is = "Half AM"
                        rbHalf_AM_Wednesday.Checked = True
                    Case Is = "Half PM"
                        rbHalf_PM_Wednesday.Checked = True
                    Case Is = "Absent"
                        rbAbsent_Wednesday.Checked = True
                End Select
                Select Case value.strThursday
                    Case Is = "Full Day"
                        rbFull_Day_Thursday.Checked = True
                    Case Is = "Half AM"
                        rbHalf_AM_Thursday.Checked = True
                    Case Is = "Half PM"
                        rbHalf_PM_Thursday.Checked = True
                    Case Is = "Absent"
                        rbAbsent_Thursday.Checked = True
                End Select
                Select Case value.strFriday
                    Case Is = "Full Day"
                        rbFull_Day_Friday.Checked = True
                    Case Is = "Half AM"
                        rbHalf_AM_Friday.Checked = True
                    Case Is = "Half PM"
                        rbHalf_PM_Friday.Checked = True
                    Case Is = "Absent"
                        rbAbsent_Friday.Checked = True
                End Select
            End If
        Next
    End Sub

    Private Sub cboCurrentClassroom_DropDown(sender As Object, e As EventArgs) Handles cboCurrentClassroom.DropDown
        ' if default value is still in combobox when clicked ("select a classroom..."
        If cboCurrentClassroom.Items.Count = 7 Then
            cboCurrentClassroom.Items.RemoveAt(0) ' remove it
        End If
    End Sub

    Private Sub cboNextClassroom_DropDown(sender As Object, e As EventArgs) Handles cboNextClassroom.DropDown
        ' if default value is still in combobox when clicked ("select a classroom..."
        If cboNextClassroom.Items.Count = 7 Then
            cboNextClassroom.Items.RemoveAt(0) ' remove it
        End If
    End Sub

    Private Sub cboCurrentSpecificClassroom_DropDown(sender As Object, e As EventArgs) Handles cboCurrentSpecificClassroom.DropDown
        ' if default value is still in combobox when clicked ("select a classroom..."
        If cboCurrentSpecificClassroom.Items.Count = 7 Then
            cboCurrentSpecificClassroom.Items.RemoveAt(0) ' remove it
        End If
    End Sub

    Private Sub cboNextSpecificClassroom_DropDown(sender As Object, e As EventArgs) Handles cboNextSpecificClassroom.DropDown
        ' if default value is still in combobox when clicked ("select a classroom..."
        If cboNextSpecificClassroom.Items.Count = 7 Then
            cboNextSpecificClassroom.Items.RemoveAt(0) ' remove it
        End If
    End Sub

    ' accept changes button
    Private Sub clpAccept_Click(sender As Object, e As EventArgs) Handles clpAccept.Click
        InputValidation() ' check for input validation
    End Sub

    Private Sub InputValidation()
        Dim bolError = False ' if true, there is an error
        If txtLastName.Text = "" Then ' is lastname text box empty?
            bolError = True
        ElseIf txtFirstName.Text = "" Then ' is firstname text box empty?
            bolError = True

            ' are classrooms one of the options available?
        ElseIf cboCurrentClassroom.Text <> "Caterpillars" And cboCurrentClassroom.Text <> "Turtles/Butterflies" And cboCurrentClassroom.Text <> "Fireflies/Ladybugs" _
            And cboCurrentClassroom.Text <> "Dragonflies/Lions" And cboCurrentClassroom.Text <> "Tree Frogs" And cboCurrentClassroom.Text <> "Kindergarten" Then
            bolError = True
        ElseIf cboNextClassroom.Text <> "Caterpillars" And cboNextClassroom.Text <> "Turtles/Butterflies" And cboNextClassroom.Text <> "Fireflies/Ladybugs" _
        And cboNextClassroom.Text <> "Dragonflies/Lions" And cboNextClassroom.Text <> "Tree Frogs" And cboNextClassroom.Text <> "Kindergarten" And cboNextClassroom.Text <> "TBA" Then
            bolError = True

            ' do specific classrooms line up with correct current and next classrooms?
        ElseIf cboCurrentSpecificClassroom.Text <> "Turtles" And cboCurrentSpecificClassroom.Text <> "Butterflies" And cboCurrentSpecificClassroom.Text <> "Fireflies" _
            And cboCurrentSpecificClassroom.Text <> "Ladybugs" And cboCurrentSpecificClassroom.Text <> "Dragonflies" And cboCurrentSpecificClassroom.Text <> "Lions" And cboCurrentSpecificClassroom.Text <> "" And cboCurrentSpecificClassroom.Text <> "Select a classroom..." Then
            bolError = True

        ElseIf cboCurrentSpecificClassroom.Text = "Turtles" Or cboCurrentSpecificClassroom.Text = "Butterflies" Then
            If cboCurrentClassroom.Text <> "Turtles/Butterflies" Then
                bolError = True
            End If
        ElseIf cboCurrentSpecificClassroom.Text = "Fireflies" Or cboCurrentSpecificClassroom.Text = "Ladybugs" Then
            If cboCurrentClassroom.Text <> "Fireflies/Ladybugs" Then
                bolError = True
            End If
        ElseIf cboCurrentSpecificClassroom.Text = "Dragonflies" Or cboCurrentSpecificClassroom.Text = "Lions" Then
            If cboCurrentClassroom.Text <> "Dragonflies/Lions" Then
                bolError = True
            End If
        ElseIf cboNextSpecificClassroom.Text <> "Turtles" And cboNextSpecificClassroom.Text <> "Butterflies" And cboNextSpecificClassroom.Text <> "Fireflies" _
      And cboNextSpecificClassroom.Text <> "Ladybugs" And cboNextSpecificClassroom.Text <> "Dragonflies" And cboNextSpecificClassroom.Text <> "Lions" And cboNextSpecificClassroom.Text <> "" And cboNextSpecificClassroom.Text <> "Select a classroom..." Then
            bolError = True
        ElseIf cboNextSpecificClassroom.Text = "Turtles" Or cboNextSpecificClassroom.Text = "Butterflies" Then
            If cboNextClassroom.Text <> "Turtles/Butterflies" Then
                bolError = True
            End If
        ElseIf cboNextSpecificClassroom.Text = "Fireflies" Or cboNextSpecificClassroom.Text = "Ladybugs" Then
            If cboNextClassroom.Text <> "Fireflies/Ladybugs" Then
                bolError = True
            End If
        ElseIf cboNextSpecificClassroom.Text = "Dragonflies" Or cboNextSpecificClassroom.Text = "Lions" Then
            If cboNextClassroom.Text <> "Dragonflies/Lions" Then
                bolError = True
            End If
      

            ' are dates entered correctly? (mm/dd/yyyy)
        ElseIf IsDate(txtBirthday.Text) = False Or txtBirthday.Text.Length <> 10 Then
            bolError = True
        ElseIf txtFlagDate.Text <> "" And txtFlagDate.Text <> "None" Then
            If IsDate(txtFlagDate.Text) = False Or txtFlagDate.Text.Length <> 10 Then
                bolError = True
            End If
        ElseIf txtStartDate.Text <> "" Then
            If IsDate(txtStartDate.Text) = False Or txtStartDate.Text.Length <> 10 Then
                bolError = True
            End If
        ElseIf txtEndDate.Text <> "" Then
            If IsDate(txtEndDate.Text) = False Or txtEndDate.Text.Length <> 10 Then
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

        If cboCurrentSpecificClassroom.Text = "Select a classroom..." Then
            cboCurrentSpecificClassroom.Text = ""
        End If

        If cboNextSpecificClassroom.Text = "Select a classroom..." Then
            cboNextSpecificClassroom.Text = ""
        End If

        If bolError = False Then ' if no error...
            UpdateChild() ' go to sub Update Child
        Else ' if error, display error message
            MessageBox.Show("Error - Please check the following:" & vbNewLine & vbNewLine & " - Required fields are not left blank." & vbNewLine _
                            & " - Date format is correct (mm/dd/yyyy)." & vbNewLine & " - Classrooms are one of the given options." & vbNewLine _
                            & " - One time slot is selected for each day of the week." & vbNewLine & " - Current Specific Classroom and Next Specific Classroom logically correspond" & vbNewLine & "     with what is selected in Current Classroom and Next Classroom, respectively.", " Error")
        End If
    End Sub

    Private Sub UpdateChild()
        Dim intUniqueIdentifier As Integer = CInt(txtUniqueIdentifier.Text)
        For Each value In Child.lstChild ' loop through list to find child being edited
            If value.intUnique = intUniqueIdentifier Then ' update all properties of child when correct one is found in list
                value.strLastName = txtLastName.Text
                value.strFirstName = txtFirstName.Text
                value.strBirthday = txtBirthday.Text
                value.strFlagDate = txtFlagDate.Text
                If value.strFlagDate = "" Then ' if flag date was left blank, replace it with "None"
                    value.strFlagDate = "None"
                End If
                value.strCurrentClassroom = cboCurrentClassroom.Text
                value.strNextClassroom = cboNextClassroom.Text
                value.strCurrentSpecificClassroom = cboCurrentSpecificClassroom.Text
                value.strNextSpecificClassroom = cboNextSpecificClassroom.Text
                value.strMonday = DaysOfTheWeek("Monday")
                value.strTuesday = DaysOfTheWeek("Tuesday")
                value.strWednesday = DaysOfTheWeek("Wednesday")
                value.strThursday = DaysOfTheWeek("Thursday")
                value.strFriday = DaysOfTheWeek("Friday")
                value.strStartDate = txtStartDate.Text
                value.strEndDate = txtEndDate.Text

                ' use function to get age and months in Add_New_Screen
                Dim oAdd_New_Screen As New Add_New_Screen
                value.intAge = oAdd_New_Screen.GetAge(txtBirthday.Text)
                value.intMonths = oAdd_New_Screen.GetMonths(txtBirthday.Text)


                ' update child in database
                Dim oDatabase_Handling As New Database_Handling
                oDatabase_Handling.EditChild(value.strLastName, value.strFirstName, value.strBirthday, value.strFlagDate, _
                                             value.strCurrentClassroom, value.strNextClassroom, value.strCurrentSpecificClassroom, _
                                             value.strNextSpecificClassroom, value.strMonday, value.strTuesday, value.strWednesday, _
                                             value.strThursday, value.strFriday, value.strStartDate, value.strEndDate, value.intAge, value.intMonths, _
                                             value.intUnique)


                Me.Close() ' close edit form
            End If
        Next
    End Sub

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

    ' x button (Cancel)
    Private Sub clpCancel_Click(sender As Object, e As EventArgs) Handles clpCancel.Click
        ' close form
        Me.Close()
    End Sub

End Class