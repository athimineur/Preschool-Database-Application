Option Strict On
Option Explicit On

Public Class Projection_GridMode

    Private Sub Projection_GridMode_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Load_Projection() ' upon activation of screen, reload grid
    End Sub

    ' activates when form loads
    Private Sub Projection_GridMode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' define classroom 
        lblClass.Text = "Turtles/Butterflies" ' start with Turtles/Butterflies, just because they are the first split classroom and will often need to be accessed first
        lblClass.Left = CInt(Me.Width / 2 - lblClass.Width / 2) ' center label horizontally


        ' define month and year
        Dim intCurrentMonth As Integer = CInt(strCurrentDate.Substring(0, 2))
        Dim strCurrentYear As String = strCurrentDate.Substring(6, 4)

        Dim strLabelMonth As String = GetCorrespondingMonth(intCurrentMonth) ' month that screen is on


        Me.Text = lblClass.Text & " - " & strLabelMonth & " " & strCurrentYear
        lblMonthYear.Text = strLabelMonth & " " & strCurrentYear
        lblMonthYear.Left = Me.Width - (lblMonthYear.Width + 10) ' positions lblMonthYear to be in the top right corner of form

        Load_Projection() ' call procedure Load_Projection
    End Sub

    ' function to get month (the word) from the month number in a date
    Private Function GetCorrespondingMonth(ByVal intMonthNumber As Integer) As String
        GetCorrespondingMonth = ""
        Select Case intMonthNumber ' depending on month number, assign correlating month name to strLabelMonth
            Case Is = 1
                GetCorrespondingMonth = "January"
            Case Is = 2
                GetCorrespondingMonth = "February"
            Case Is = 3
                GetCorrespondingMonth = "March"
            Case Is = 4
                GetCorrespondingMonth = "April"
            Case Is = 5
                GetCorrespondingMonth = "May"
            Case Is = 6
                GetCorrespondingMonth = "June"
            Case Is = 7
                GetCorrespondingMonth = "July"
            Case Is = 8
                GetCorrespondingMonth = "August"
            Case Is = 9
                GetCorrespondingMonth = "September"
            Case Is = 10
                GetCorrespondingMonth = "October"
            Case Is = 11
                GetCorrespondingMonth = "November"
            Case Is = 12
                GetCorrespondingMonth = "December"
        End Select
        Return GetCorrespondingMonth
    End Function

    ' this sub handles reloading the datagrid. 
    ' it starts by clearning current datagrid, then re-sorting lstChild, resetting counts, populating grid and displaying it, and then formatting the grid itself.
    ' sub Load_Projection is called VERY often, as it essentially is what handles reloading the datagrid.
    Private Sub Load_Projection()
        ' clear datagridview to reset
        dgvProjection.Rows.Clear()

        ' sort lstChild alphabetically by lastname, firstname
        Child.lstChild = Child.lstChild.OrderBy(Function(x) x.strLastName & ", " & x.strFirstName).ToList()

        ' reset days of the week number counts
        ResetNumbers()

        Populate() ' populates datagridview with data to display

        DataGridFormatting() ' formats data grid view

    End Sub

    Dim strCurrentDate As String = Date.Now.ToString("MM/dd/yyyy") ' current date (mm/dd/yyyy)
    Dim bolStartDateReady As Boolean ' checks start date compared to current date
    Dim bolEndDateReady As Boolean ' checks end date compared to current date
    Dim inc As Integer ' keeps track of current max row number
    Dim intMondayAM As Integer ' number of kids on monday AM
    Dim intTuesdayAM As Integer ' number of kids on tuesday AM
    Dim intWednesdayAM As Integer ' number of kids on wednesday AM
    Dim intThursdayAM As Integer ' number of kids on thursday AM
    Dim intFridayAM As Integer ' number of kids on friday AM
    Dim intMondayPM As Integer ' number of kids on monday PM
    Dim intTuesdayPM As Integer ' number of kids on tuesday PM
    Dim intWednesdayPM As Integer ' number of kids on wednesday PM
    Dim intThursdayPM As Integer ' number of kids on thursday PM
    Dim intFridayPM As Integer ' number of kids on friday PM
    Dim bolFlag As Boolean ' if yes, flag date has been passed
    Shared bolPrediction As Boolean ' whether prediction should be turned on or off (depends on button pressed)
    Dim strFlag As String ' either "FLAG" or "" depending on whether flag date (when checked) is lower or higher than current date
    Shared bolSpecific As Boolean ' checks whether specific classrooms are needed to be checked or not (used for split classrooms)
    Shared strSpecificClassroom As String  ' specific classroom the grid is showing (only given a value during splits between turtles and butterflies, fireflies and ladybugs, and dragonflies and lions
    Shared bolNeeded As Boolean = True ' checks to see if there needs to be a header for children unsorted 
    Shared bolCount As Boolean ' the count of the rooms to see if room is over or not
    Shared bolCheck As Boolean ' used to store the function value which checks if date is lower than current date
    Dim bolPredictionModeApproved As Boolean ' if prediction mode is on, this is true and prediction mode settings will apply
    Shared bolExtraBlank As Boolean ' checks if an extra blank row needs to be made in the datagridview

    Private Sub Populate() ' popluates datagridview
        lstUnique.Items.Clear()
        inc = 0 ' inc starts at 0
        Dim strClassroom As String = lblClass.Text ' classroom the grid is showing
        Dim intNextSpecific As Integer = 0 ' determines which specific class to populate grid with next 

        '*******************************************************************
        'CURRENTLY IN ROOM AS OF THE SPECIFIC MONTH AND YEAR
        '*******************************************************************
        dgvProjection.Rows.Add(strClassroom) ' add header row
        dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
        dgvProjection.Rows(inc).Height = 30 ' change row height
        inc += 1
        lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

        ' **************************
        ' PREDICTION MODE IS OFF
        ' **************************
        If bolPrediction = False Then ' if prediction mode is off then...
            Do ' loop
                ' for split classrooms only, plan how split is going to happen
                ' with each loop, one of the split classrooms will be populated (and lastly the unsorted children).
                ' depends on intNextSpecific to see which children are populated next
                bolCount = True
                Select Case strClassroom
                    Case Is = "Turtles/Butterflies"
                        Select Case intNextSpecific ' populate with turtles or butterflies depending on which loop number it's on 
                            Case Is = 0

                                dgvProjection.Rows.Add() ' add blank row (for spacing)
                                inc += 1
                                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.


                                dgvProjection.Rows.Add("Turtles") ' add header row
                                dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                dgvProjection.Rows(inc).Height = 30 ' change row height
                                inc += 1
                                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                                intNextSpecific = 1 ' add one to intNextSpecific, forcing loop to happen twice to allow both Turtles and Butterflies to be populated

                                strSpecificClassroom = "Turtles"

                            Case Is = 1
                                dgvProjection.Rows.Add("Butterflies") ' add header row
                                dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                dgvProjection.Rows(inc).Height = 30 ' change row height
                                inc += 1
                                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                                intNextSpecific = 2 ' loop can end

                                strSpecificClassroom = "Butterflies"

                            Case Is = 2
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strCurrentClassroom = "Turtles/Butterflies" Then
                                        If value.strCurrentSpecificClassroom = "" Then
                                            bolNeeded = True
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Not Sorted") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                Else
                                    bolCount = False
                                End If
                                intNextSpecific = 0 ' loop can end
                                strSpecificClassroom = ""
                        End Select

                    Case Is = "Fireflies/Ladybugs"

                        Select Case intNextSpecific ' populate with fireflies or ladybugs depending on which loop number it's on 
                            Case Is = 0

                                dgvProjection.Rows.Add() ' add blank row (for spacing)
                                inc += 1
                                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                                dgvProjection.Rows.Add("Fireflies") ' add header row
                                dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                dgvProjection.Rows(inc).Height = 30 ' change row height
                                inc += 1
                                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                                intNextSpecific = 1 ' add one to intNextSpecific, forcing loop to happen twice to allow both Turtles and Butterflies to be populated

                                strSpecificClassroom = "Fireflies"
                            Case Is = 1

                                dgvProjection.Rows.Add("Ladybugs") ' add header row
                                dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                dgvProjection.Rows(inc).Height = 30 ' change row height
                                inc += 1
                                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                                intNextSpecific = 2 ' loop can end

                                strSpecificClassroom = "Ladybugs"

                            Case Is = 2
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strCurrentClassroom = "Fireflies/Ladybugs" Then
                                        If value.strCurrentSpecificClassroom = "" Then
                                            bolNeeded = True
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Not Sorted") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                Else
                                    bolCount = False
                                End If
                                intNextSpecific = 0 ' loop can end
                                strSpecificClassroom = ""
                        End Select

                    Case Is = "Dragonflies/Lions"
                        Select Case intNextSpecific ' populate with dragonflies or lions depending on which loop number it's on 
                            Case Is = 0

                                dgvProjection.Rows.Add() ' add blank row (for spacing)
                                inc += 1
                                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                                dgvProjection.Rows.Add("Dragonflies") ' add header row
                                dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                dgvProjection.Rows(inc).Height = 30 ' change row height
                                inc += 1
                                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                                intNextSpecific = 1 ' add one to intNextSpecific, forcing loop to happen twice to allow both Turtles and Butterflies to be populated

                                strSpecificClassroom = "Dragonflies"
                            Case Is = 1

                                dgvProjection.Rows.Add("Lions") ' add header row
                                dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                dgvProjection.Rows(inc).Height = 30 ' change row height
                                inc += 1
                                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                                intNextSpecific = 2 ' loop can end

                                strSpecificClassroom = "Lions"

                            Case Is = 2
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strCurrentClassroom = "Dragonflies/Lions" Then
                                        If value.strCurrentSpecificClassroom = "" Then
                                            bolNeeded = True
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Not Sorted") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                Else
                                    bolCount = False
                                End If
                                intNextSpecific = 0 ' loop can end
                                strSpecificClassroom = ""
                        End Select
                    Case Else ' otherwise, add a blank row for spacing (for non split rooms)
                        dgvProjection.Rows.Add()
                        inc += 1
                        lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                End Select

                For Each value In Child.lstChild ' loop through list

                    '' if bolprediction is turned on, and prediction for the child has been approved, OR if prediction is false, move on
                    ' If value.strCurrentClassroom = strClassroom Then ' OrElse bolPrediction = True AndAlso bolPredictionModeApproved = True Then ' find all children of chosen class on screen
                    If value.strCurrentClassroom = strClassroom Then

                        ' checks to see if a check for child's specific classroom is needed: is only needed for split classrooms
                        ' child will be unsorted if: current classroom does not equal specific classroom being tested for and specific classroom does not equal nothing and child currentspecific classrom does not equal nothing, OR...
                        ' if child current specific classroom is nothing and if the specific classroom tested for is not equal to blank OR...
                        ' if child current classroom does not equal blank and the specific classroom being tested for is blank
                        bolSpecific = True
                        Select Case value.strCurrentClassroom
                            Case Is = "Turtles/Butterflies"
                                If value.strCurrentSpecificClassroom <> strSpecificClassroom And Not strSpecificClassroom = "" And value.strCurrentSpecificClassroom <> "" Then ' if there is a need (for split classrooms), check the children specific classrooms
                                    bolSpecific = False
                                ElseIf value.strCurrentSpecificClassroom = "" And strSpecificClassroom <> "" Then
                                    bolSpecific = False
                                ElseIf value.strCurrentSpecificClassroom <> "" And strSpecificClassroom = "" Then
                                    bolSpecific = False
                                End If
                            Case Is = "Fireflies/Ladybugs"
                                If value.strCurrentSpecificClassroom <> strSpecificClassroom And Not strSpecificClassroom = "" And value.strCurrentSpecificClassroom <> "" Then ' if there is a need (for split classrooms), check the children specific classrooms
                                    bolSpecific = False
                                ElseIf value.strCurrentSpecificClassroom = "" And strSpecificClassroom <> "" Then
                                    bolSpecific = False
                                ElseIf value.strCurrentSpecificClassroom <> "" And strSpecificClassroom = "" Then
                                    bolSpecific = False
                                End If
                            Case Is = "Dragonflies/Lions"
                                If value.strCurrentSpecificClassroom <> strSpecificClassroom And Not strSpecificClassroom = "" And value.strCurrentSpecificClassroom <> "" Then ' if there is a need (for split classrooms), check the children specific classrooms
                                    bolSpecific = False
                                ElseIf value.strCurrentSpecificClassroom = "" And strSpecificClassroom <> "" Then
                                    bolSpecific = False
                                ElseIf value.strCurrentSpecificClassroom <> "" And strSpecificClassroom = "" Then
                                    bolSpecific = False
                                End If
                        End Select
                        If bolSpecific = True Then
                            If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                ' check if start date is less than current date
                                bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                            End If

                            If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                ' check if end date is greater than current date
                                bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                            End If

                            ' check if start date is less than current date and check if end date is greater than current date
                            If bolStartDateReady = True Or value.strStartDate = "" Then
                                If bolEndDateReady = False Or value.strEndDate = "" Then

                                    If Not value.strFlagDate = "None" Then
                                        ' check if flag date has passed or not
                                        bolFlag = DateCheck(value.strFlagDate, "", "", False)
                                        If bolFlag = True Then ' if flag date is below current date, flag child
                                            strFlag = "FLAG"
                                        Else ' if flag date is above current date, child is not flagged
                                            strFlag = ""
                                        End If
                                    End If
                                End If

                                ' add children to datagrid
                                dgvProjection.Rows.Add(value.strLastName & ", " & value.strFirstName, strFlag, value.strBirthday, value.intAge, value.strMonday, value.strTuesday, value.strWednesday, value.strThursday, value.strFriday)
                                ' color them all green, which means they are currently in the room 
                                dgvProjection.Rows(inc).DefaultCellStyle.BackColor = Color.MediumSpringGreen
                                inc += 1
                                lstUnique.Items.Add(value.intUnique) ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                                ' add to numbers of days of the week, to get count for each day
                                DaysOfWeekCount(value)
                            End If
                        End If
                    End If
                Next


                ' only do this if it's needed (for split rooms, if there is no unsorted children, do not put a count for them)
                If bolCount = True Then
                    dgvProjection.Rows.Add() ' add blank row (for spacing)
                    inc += 1
                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.


                    ' add number counts to datagrid
                    dgvProjection.Rows.Add("", "", "", "", intMondayAM & "/" & intMondayPM, intTuesdayAM & "/" & intTuesdayPM, _
                                           intWednesdayAM & "/" & intWednesdayPM, intThursdayAM & "/" & intThursdayPM, intFridayAM & "/" & intFridayPM)
                    ResetNumbers()
                    ' format number count fonts
                    dgvProjection.Rows(inc).Cells(4).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell
                    dgvProjection.Rows(inc).Cells(5).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell
                    dgvProjection.Rows(inc).Cells(6).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell
                    dgvProjection.Rows(inc).Cells(7).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell
                    dgvProjection.Rows(inc).Cells(8).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell

                    ' if too many kids are there on a certain day at the same time, highlight number count in red 
                    ' caterpillars = 12 max, turtles/butterflies = 16 total - 8 split, ladybugs/fireflies = 16 total - 8 split...
                    ' dragonflies/lions = 30 total - split (df: 20/Lions: 10), tree frogs = 20 max, kindergarten = unlimited
                    Dim intLimit As Integer
                    intLimit = GetLimit(strClassroom, strSpecificClassroom) ' gets limit of kids max in specific room

                    If intMondayAM > intLimit Or intMondayPM > intLimit Then
                        dgvProjection.Rows(inc).Cells(4).Style.BackColor = Color.Red
                    Else
                        dgvProjection.Rows(inc).Cells(4).Style.BackColor = Color.MediumSpringGreen
                    End If
                    If intTuesdayAM > intLimit Or intTuesdayPM > intLimit Then
                        dgvProjection.Rows(inc).Cells(5).Style.BackColor = Color.Red
                    Else
                        dgvProjection.Rows(inc).Cells(5).Style.BackColor = Color.MediumSpringGreen
                    End If
                    If intWednesdayAM > intLimit Or intWednesdayPM > intLimit Then
                        dgvProjection.Rows(inc).Cells(6).Style.BackColor = Color.Red
                    Else
                        dgvProjection.Rows(inc).Cells(6).Style.BackColor = Color.MediumSpringGreen
                    End If
                    If intThursdayAM > intLimit Or intThursdayPM > intLimit Then
                        dgvProjection.Rows(inc).Cells(7).Style.BackColor = Color.Red
                    Else
                        dgvProjection.Rows(inc).Cells(7).Style.BackColor = Color.MediumSpringGreen
                    End If
                    If intFridayAM > intLimit Or intFridayPM > intLimit Then
                        dgvProjection.Rows(inc).Cells(8).Style.BackColor = Color.Red
                    Else
                        dgvProjection.Rows(inc).Cells(8).Style.BackColor = Color.MediumSpringGreen
                    End If
                    inc += 1
                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                    dgvProjection.Rows.Add() ' add blank row after numbers
                    inc += 1
                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                End If

            Loop Until intNextSpecific = 0 ' finish looping when all children of specific classroom have been populated, whether their sorted or not

            ' **********************
            ' PREDICTION MODE IS ON
            ' **********************

        ElseIf bolPrediction = True Then
            dgvProjection.Rows.Add() ' add blank row (for spacing)
            inc += 1
            lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

            For Each value In Child.lstChild
                bolPredictionModeApproved = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, True)
                If bolPredictionModeApproved = True Then

                    bolPredictedNext = CheckNextClassroom(value.strBirthday, value.strCurrentClassroom, strClassroom)

                    If bolPredictedNext = True Then
                        ' add rows of children who will be old enough to be in the room on this date
                        dgvProjection.Rows.Add(value.strLastName & ", " & value.strFirstName, strFlag, value.strBirthday, value.intAge, value.strMonday, value.strTuesday, value.strWednesday, value.strThursday, value.strFriday)
                        ' color them all green, which means they are currently in the room 
                        dgvProjection.Rows(inc).DefaultCellStyle.BackColor = Color.MediumSpringGreen
                        inc += 1
                        lstUnique.Items.Add(value.intUnique) ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                        ' add to numbers of days of the week, to get count for each day
                        DaysOfWeekCount(value)
                    End If
                End If
            Next
            dgvProjection.Rows.Add() ' add blank row (for spacing)
            inc += 1
            lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.


            ' add number counts to datagrid
            dgvProjection.Rows.Add("", "", "", "", intMondayAM & "/" & intMondayPM, intTuesdayAM & "/" & intTuesdayPM, _
                                   intWednesdayAM & "/" & intWednesdayPM, intThursdayAM & "/" & intThursdayPM, intFridayAM & "/" & intFridayPM)
            ResetNumbers()
            ' format number count fonts
            dgvProjection.Rows(inc).Cells(4).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell
            dgvProjection.Rows(inc).Cells(5).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell
            dgvProjection.Rows(inc).Cells(6).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell
            dgvProjection.Rows(inc).Cells(7).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell
            dgvProjection.Rows(inc).Cells(8).Style.Font = New Font("Calibri", 16, FontStyle.Italic) ' change font of cell

            ' if too many kids are there on a certain day at the same time, highlight number count in red 
            ' caterpillars = 12 max, turtles/butterflies = 16 total - 8 split, ladybugs/fireflies = 16 total - 8 split...
            ' dragonflies/lions = 30 total - split (df: 20/Lions: 10), tree frogs = 20 max, kindergarten = unlimited
            Dim intLimit As Integer
            intLimit = GetLimit(strClassroom, strSpecificClassroom) ' gets limit of kids max in specific room

            If intMondayAM > intLimit Or intMondayPM > intLimit Then
                dgvProjection.Rows(inc).Cells(4).Style.BackColor = Color.Red
            Else
                dgvProjection.Rows(inc).Cells(4).Style.BackColor = Color.MediumSpringGreen
            End If
            If intTuesdayAM > intLimit Or intTuesdayPM > intLimit Then
                dgvProjection.Rows(inc).Cells(5).Style.BackColor = Color.Red
            Else
                dgvProjection.Rows(inc).Cells(5).Style.BackColor = Color.MediumSpringGreen
            End If
            If intWednesdayAM > intLimit Or intWednesdayPM > intLimit Then
                dgvProjection.Rows(inc).Cells(6).Style.BackColor = Color.Red
            Else
                dgvProjection.Rows(inc).Cells(6).Style.BackColor = Color.MediumSpringGreen
            End If
            If intThursdayAM > intLimit Or intThursdayPM > intLimit Then
                dgvProjection.Rows(inc).Cells(7).Style.BackColor = Color.Red
            Else
                dgvProjection.Rows(inc).Cells(7).Style.BackColor = Color.MediumSpringGreen
            End If
            If intFridayAM > intLimit Or intFridayPM > intLimit Then
                dgvProjection.Rows(inc).Cells(8).Style.BackColor = Color.Red
            Else
                dgvProjection.Rows(inc).Cells(8).Style.BackColor = Color.MediumSpringGreen
            End If
            inc += 1
            lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

            dgvProjection.Rows.Add() ' add blank row (for spacing)
            inc += 1
            lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.


        End If


        '*********************************************************************************
        'PROJECTED (BENCHMARK HAS BEEN REACHED FOR SPECIFIC MONTH AND YEAR)
        '*********************************************************************************
        ' Projected is NOT used for Caterpillars and Kindergarten
        ' because Caterpillars are the first room and Kindergarden does not have the same relationship with transitions as the rest of the preschool classrooms
        ' is not shown in prediction mode
        If Not strClassroom = "Caterpillars" AndAlso Not strClassroom = "Kindergarten" AndAlso bolPrediction = False Then

            Do ' loop
                ' for split classrooms only, plan how split is going to happen
                ' with each loop, one of the split classrooms will be populated (and lastly the unsorted children).
                ' depends on intNextSpecific to see which children are populated next

                bolExtraBlank = False ' only set to true to add a blank row at end of loop for spacing: used for split classrooms of projections

                Select Case strClassroom
                    Case Is = "Turtles/Butterflies"
                        Select Case intNextSpecific ' populate with turtles or butterflies depending on which loop number it's on 
                            Case Is = 0 ' Turtles
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strNextSpecificClassroom = "Turtles" Then
                                        If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                            ' check if start date is less than current date
                                            bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                                        End If

                                        If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                            ' check if end date is greater than current date
                                            bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                                        End If

                                        ' check if start date is less than current date and check if end date is greater than current date
                                        If bolStartDateReady = True Or value.strStartDate = "" Then
                                            If bolEndDateReady = False Or value.strEndDate = "" Then

                                                ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                                ' calls function predict to find out
                                                bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)

                                                If bolCheck = True Then
                                                    bolNeeded = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Projected Turtles") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                    bolExtraBlank = True ' adds a blank row at the end of the sequence loop, used for spacing
                                End If

                                intNextSpecific = 1 ' add one to intNextSpecific, forcing loop to happen twice to allow both Turtles and Butterflies to be populated

                                strSpecificClassroom = "Turtles"
                            Case Is = 1 ' butterflies
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strNextSpecificClassroom = "Butterflies" Then
                                        If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                            ' check if start date is less than current date
                                            bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                                        End If

                                        If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                            ' check if end date is greater than current date
                                            bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                                        End If

                                        ' check if start date is less than current date and check if end date is greater than current date
                                        If bolStartDateReady = True Or value.strStartDate = "" Then
                                            If bolEndDateReady = False Or value.strEndDate = "" Then

                                                ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                                ' calls function predict to find out
                                                bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)

                                                If bolCheck = True Then
                                                    bolNeeded = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Projected Butterflies") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                    bolExtraBlank = True ' adds a blank row at the end of the sequence loop, used for spacing
                                End If

                                intNextSpecific = 2
                                strSpecificClassroom = "Butterflies"

                            Case Is = 2 ' turtles/butterflies 
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                        ' check if start date is less than current date
                                        bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                                    End If

                                    If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                        ' check if end date is greater than current date
                                        bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                                    End If

                                    ' check if start date is less than current date and check if end date is greater than current date
                                    If bolStartDateReady = True Or value.strStartDate = "" Then
                                        If bolEndDateReady = False Or value.strEndDate = "" Then

                                            ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                            ' calls function predict to find out
                                            bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)
                                            If value.strNextSpecificClassroom = "" Then

                                                If bolCheck = True Then
                                                    bolNeeded = True
                                                End If

                                            End If
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Projected Not Sorted") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                    bolExtraBlank = True ' adds a blank row at the end of the sequence loop, used for spacing
                                End If

                                intNextSpecific = 0 ' loop can end
                                strSpecificClassroom = ""
                        End Select

                    Case Is = "Fireflies/Ladybugs"

                        Select Case intNextSpecific ' populate with fireflies or ladybugs depending on which loop number it's on 
                            Case Is = 0 ' fireflies
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strNextSpecificClassroom = "Fireflies" Then
                                        If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                            ' check if start date is less than current date
                                            bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                                        End If

                                        If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                            ' check if end date is greater than current date
                                            bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                                        End If

                                        ' check if start date is less than current date and check if end date is greater than current date
                                        If bolStartDateReady = True Or value.strStartDate = "" Then
                                            If bolEndDateReady = False Or value.strEndDate = "" Then

                                                ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                                ' calls function predict to find out
                                                bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)

                                                If bolCheck = True Then
                                                    bolNeeded = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Projected Fireflies") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                    bolExtraBlank = True ' adds a blank row at the end of the sequence loop, used for spacing
                                End If

                                intNextSpecific = 1 ' add one to intNextSpecific, forcing loop to happen twice to allow both Turtles and Butterflies to be populated

                                strSpecificClassroom = "Fireflies"
                            Case Is = 1 ' ladybugs
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strNextSpecificClassroom = "Ladybugs" Then
                                        If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                            ' check if start date is less than current date
                                            bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                                        End If

                                        If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                            ' check if end date is greater than current date
                                            bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                                        End If

                                        ' check if start date is less than current date and check if end date is greater than current date
                                        If bolStartDateReady = True Or value.strStartDate = "" Then
                                            If bolEndDateReady = False Or value.strEndDate = "" Then

                                                ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                                ' calls function predict to find out
                                                bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)

                                                If bolCheck = True Then
                                                    bolNeeded = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Projected Ladybugs") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                    bolExtraBlank = True ' adds a blank row at the end of the sequence loop, used for spacing
                                End If

                                intNextSpecific = 2
                                strSpecificClassroom = "Ladybugs"

                            Case Is = 2 ' fireflies/ladybugs
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                        ' check if start date is less than current date
                                        bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                                    End If

                                    If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                        ' check if end date is greater than current date
                                        bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                                    End If

                                    ' check if start date is less than current date and check if end date is greater than current date
                                    If bolStartDateReady = True Or value.strStartDate = "" Then
                                        If bolEndDateReady = False Or value.strEndDate = "" Then

                                            ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                            ' calls function predict to find out
                                            bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)
                                            If value.strNextSpecificClassroom = "" Then

                                                If bolCheck = True Then
                                                    bolNeeded = True
                                                End If

                                            End If
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Projected Not Sorted") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                    bolExtraBlank = True ' adds a blank row at the end of the sequence loop, used for spacing
                                End If

                                intNextSpecific = 0 ' loop can end
                                strSpecificClassroom = ""
                        End Select

                    Case Is = "Dragonflies/Lions"
                        Select Case intNextSpecific ' populate with dragonflies or lions depending on which loop number it's on 
                            Case Is = 0 ' dragonflies
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strNextSpecificClassroom = "Dragonflies" Then
                                        If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                            ' check if start date is less than current date
                                            bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                                        End If

                                        If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                            ' check if end date is greater than current date
                                            bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                                        End If

                                        ' check if start date is less than current date and check if end date is greater than current date
                                        If bolStartDateReady = True Or value.strStartDate = "" Then
                                            If bolEndDateReady = False Or value.strEndDate = "" Then

                                                ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                                ' calls function predict to find out
                                                bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)

                                                If bolCheck = True Then
                                                    bolNeeded = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Projected Dragonflies") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                    bolExtraBlank = True ' adds a blank row at the end of the sequence loop, used for spacing
                                End If

                                intNextSpecific = 1 ' add one to intNextSpecific, forcing loop to happen twice to allow both Turtles and Butterflies to be populated

                                strSpecificClassroom = "Dragonflies"
                            Case Is = 1 ' lions
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strNextSpecificClassroom = "Lions" Then
                                        If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                            ' check if start date is less than current date
                                            bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                                        End If

                                        If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                            ' check if end date is greater than current date
                                            bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                                        End If

                                        ' check if start date is less than current date and check if end date is greater than current date
                                        If bolStartDateReady = True Or value.strStartDate = "" Then
                                            If bolEndDateReady = False Or value.strEndDate = "" Then

                                                ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                                ' calls function predict to find out
                                                bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)

                                                If bolCheck = True Then
                                                    bolNeeded = True
                                                End If
                                            End If
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Projected Lions") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                    bolExtraBlank = True ' adds a blank row at the end of the sequence loop, used for spacing
                                End If

                                intNextSpecific = 2
                                strSpecificClassroom = "Lions"

                            Case Is = 2 ' dragonflies/lions
                                bolNeeded = False
                                For Each value In Child.lstChild
                                    If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                        ' check if start date is less than current date
                                        bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                                    End If

                                    If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                        ' check if end date is greater than current date
                                        bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                                    End If

                                    ' check if start date is less than current date and check if end date is greater than current date
                                    If bolStartDateReady = True Or value.strStartDate = "" Then
                                        If bolEndDateReady = False Or value.strEndDate = "" Then

                                            ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                            ' calls function predict to find out
                                            bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)

                                            If value.strNextSpecificClassroom = "" Then

                                                If bolCheck = True Then
                                                    bolNeeded = True
                                                End If

                                            End If
                                        End If
                                    End If
                                Next

                                If bolNeeded = True Then
                                    dgvProjection.Rows.Add("Projected Not Sorted") ' add header row
                                    dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                                    dgvProjection.Rows(inc).Height = 30 ' change row height
                                    inc += 1
                                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                    bolExtraBlank = True ' adds a blank row at the end of the sequence loop, used for spacing
                                End If

                                intNextSpecific = 0 ' loop can end
                                strSpecificClassroom = ""
                        End Select
                    Case Is = "Tree Frogs"
                        bolNeeded = False
                        For Each value In Child.lstChild
                            If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                                ' check if start date is less than current date
                                bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                            End If

                            If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                                ' check if end date is greater than current date
                                bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                            End If

                            ' check if start date is less than current date and check if end date is greater than current date
                            If bolStartDateReady = True Or value.strStartDate = "" Then
                                If bolEndDateReady = False Or value.strEndDate = "" Then

                                    ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                    ' calls function predict to find out
                                    bolCheck = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)

                                    If bolCheck = True Then
                                        bolNeeded = True
                                    End If

                                    If bolCheck = True Then
                                        bolNeeded = True
                                    End If
                                End If
                            End If
                        Next

                        If bolNeeded = True Then
                            dgvProjection.Rows.Add("Projected") ' add header row
                            dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                            dgvProjection.Rows(inc).Height = 30 ' change row height
                            inc += 1
                            lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                            bolExtraBlank = True
                        End If
                End Select

                Dim bolSpecific As Boolean
                For Each value In Child.lstChild ' loop through list
                    ' checks to see if a check for child's specific classroom is needed: is only needed for split classrooms
                    ' child will be unsorted if: next classroom does not equal specific classroom being tested for and specific classroom does not equal nothing and child nextspecific classrom does not equal nothing, OR...
                    ' if child next specific classroom is nothing and if the specific classroom tested for is not equal to blank OR...
                    ' if child next classroom does not equal blank and the specific classroom being tested for is blank
                    bolSpecific = True
                    Select Case value.strNextSpecificClassroom
                        Case Is = "Turtles"
                            If value.strNextSpecificClassroom <> strSpecificClassroom And Not strSpecificClassroom = "" And value.strNextSpecificClassroom <> "" Then ' if there is a need (for split classrooms), check the children specific classrooms
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom = "" And strSpecificClassroom <> "" Then
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom <> "" And strSpecificClassroom = "" Then
                                bolSpecific = False
                            End If
                        Case Is = "Butterflies"
                            If value.strNextSpecificClassroom <> strSpecificClassroom And Not strSpecificClassroom = "" And value.strNextSpecificClassroom <> "" Then ' if there is a need (for split classrooms), check the children specific classrooms
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom = "" And strSpecificClassroom <> "" Then
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom <> "" And strSpecificClassroom = "" Then
                                bolSpecific = False
                            End If
                        Case Is = "Fireflies"
                            If value.strNextSpecificClassroom <> strSpecificClassroom And Not strSpecificClassroom = "" And value.strNextSpecificClassroom <> "" Then ' if there is a need (for split classrooms), check the children specific classrooms
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom = "" And strSpecificClassroom <> "" Then
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom <> "" And strSpecificClassroom = "" Then
                                bolSpecific = False
                            End If
                        Case Is = "Ladybugs"
                            If value.strNextSpecificClassroom <> strSpecificClassroom And Not strSpecificClassroom = "" And value.strNextSpecificClassroom <> "" Then ' if there is a need (for split classrooms), check the children specific classrooms
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom = "" And strSpecificClassroom <> "" Then
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom <> "" And strSpecificClassroom = "" Then
                                bolSpecific = False
                            End If
                        Case Is = "Dragonflies"
                            If value.strNextSpecificClassroom <> strSpecificClassroom And Not strSpecificClassroom = "" And value.strNextSpecificClassroom <> "" Then ' if there is a need (for split classrooms), check the children specific classrooms
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom = "" And strSpecificClassroom <> "" Then
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom <> "" And strSpecificClassroom = "" Then
                                bolSpecific = False
                            End If
                        Case Is = "Lions"
                            If value.strNextSpecificClassroom <> strSpecificClassroom And Not strSpecificClassroom = "" And value.strNextSpecificClassroom <> "" Then ' if there is a need (for split classrooms), check the children specific classrooms
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom = "" And strSpecificClassroom <> "" Then
                                bolSpecific = False
                            ElseIf value.strNextSpecificClassroom <> "" And strSpecificClassroom = "" Then
                                bolSpecific = False
                            End If
                        Case Else
                            If intNextSpecific = 0 Then
                                bolSpecific = True
                            Else
                                bolSpecific = False
                            End If
                    End Select

                    If bolSpecific = True Then
                        If value.strStartDate <> "" Then ' if start date isn't blank (it's an optional field)
                            ' check if start date is less than current date
                            bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                        End If

                        If value.strEndDate <> "" Then ' if end date isn't blank (it's an optional field)
                            ' check if end date is greater than current date
                            bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                        End If

                        ' check if start date is less than current date and check if end date is greater than current date
                        If bolStartDateReady = True Or value.strStartDate = "" Then
                            If bolEndDateReady = False Or value.strEndDate = "" Then

                                ' find which kids, according to birthday, will be in classroom this month but haven't transitioned yet
                                ' calls function predict to find out
                                Dim Predict As Boolean
                                Predict = DateCheck(value.strBirthday, strClassroom, value.strCurrentClassroom, False)
                                If Predict = True Then

                                    dgvProjection.Rows.Add(value.strLastName & ", " & value.strFirstName, "FLAG", value.strBirthday, value.intAge, value.strMonday, value.strTuesday, value.strWednesday, value.strThursday, value.strFriday)
                                    ' color them all purple, which means they are projected
                                    dgvProjection.Rows(inc).DefaultCellStyle.BackColor = Color.MediumPurple
                                    inc += 1
                                    lstUnique.Items.Add(value.intUnique) ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                                End If
                            End If
                        End If
                    End If
                Next

                If bolExtraBlank = True And bolNeeded = True Then ' only add blank row for spacing if bolNeeded = True AND bolSpecific = True (otherwise it will not be needed)
                    dgvProjection.Rows.Add() ' add blank row (for spacing)
                    inc += 1
                    lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
                End If

            Loop Until intNextSpecific = 0 ' loop until all classrooms have been accounted for (intNextSpecific only changes when a specific classroom [when dealing with split classrooms] comes into account)
        End If

        '***************************************************
        'EACH CHILD WHO HAS NOT STARTED YET 
        '***************************************************
        If bolPrediction = False Then ' if prediction mode is not on
            ' check to make sure "not started" header is needed (checks to see if there are any children who haven't started yet who are entered)
            bolNeeded = False
            For Each value In Child.lstChild ' loop through list
                If value.strCurrentClassroom = strClassroom Then ' check for all children in specific class
                    ' check to see if start and end dates for child are valid with the current date
                    If value.strStartDate <> "" Then
                        bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                    End If
                    If value.strEndDate <> "" Then
                        bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                    End If
                    ' if start date hasn't happened yet, but the end date hasn't happened yet either (or end date is blank)...
                    If bolStartDateReady = False And value.strStartDate <> "" Then
                        If bolEndDateReady = False Or value.strEndDate = "" Then
                            bolNeeded = True
                        End If
                    End If
                End If
            Next

            If bolNeeded = True Then
                dgvProjection.Rows.Add("Not Yet Started") ' add header for children not started yet
                dgvProjection.Rows(inc).Cells(0).Style.Font = New Font("Calibri", 15, FontStyle.Italic) ' change font of cell
                dgvProjection.Rows(inc).Height = 30
                inc += 1
                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.


                For Each value In Child.lstChild
                    If value.strCurrentClassroom = strClassroom Then ' find all children of class who have not started yet

                        ' check if start and end dates weren't left blank. Go to function and find out if the start date is ready or not and end date is ready or not
                        If value.strStartDate <> "" Then
                            bolStartDateReady = DateCheck(value.strStartDate, "", "", False)
                        End If
                        If value.strEndDate <> "" Then
                            bolEndDateReady = DateCheck(value.strEndDate, "", "", False)
                        End If

                        ' if start date hasn't happened yet, but the end date hasn't happened yet either (or end date is blank)...
                        If bolStartDateReady = False And value.strStartDate <> "" Then
                            If bolEndDateReady = False Or value.strEndDate = "" Then

                                ' check if flag date has passed or not
                                If Not value.strFlagDate = "None" Then ' if strFlagDate does not equal "None" (all tree frogs and kindergarten have flag dates that are "None")
                                    bolFlag = DateCheck(value.strFlagDate, "", "", False)
                                    If bolFlag = True Then ' if flag date is below current date, flag child
                                        strFlag = "FLAG"
                                    Else ' if flag date is above current date, child is not flagged
                                        strFlag = ""
                                    End If
                                Else ' if flag date is "None", child is not flagged
                                    strFlag = ""
                                End If

                                ' add children to datagrid
                                dgvProjection.Rows.Add(value.strLastName & ", " & value.strFirstName, strFlag, value.strBirthday, value.intAge, value.strMonday, value.strTuesday, value.strWednesday, value.strThursday, value.strFriday)
                                ' color them all blue, which means they are currently in the room 
                                dgvProjection.Rows(inc).DefaultCellStyle.BackColor = Color.LightBlue
                                inc += 1
                                lstUnique.Items.Add(value.intUnique) ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.

                            End If
                        End If
                    End If
                Next
                dgvProjection.Rows.Add() ' add blank row (for spacing)
                inc += 1
                lstUnique.Items.Add(" ") ' add row sequences and children to lstUnique to keep track. lstUnique is invisible to user.
            End If
        End If
    End Sub

    Private Sub ResetNumbers() ' resets all day counts
        intMondayAM = 0
        intTuesdayAM = 0
        intWednesdayAM = 0
        intThursdayAM = 0
        intFridayAM = 0
        intMondayPM = 0
        intTuesdayPM = 0
        intWednesdayPM = 0
        intThursdayPM = 0
        intFridayPM = 0
    End Sub

    Private Function GetLimit(ByVal strClassroom As String, ByVal strSpecificClassroom As String) As Integer
        Select Case strClassroom ' depending on classroom, set limit of kids that are allowed 
            Case Is = "Caterpillars"
                GetLimit = 12
            Case Is = "Turtles/Butterflies"
                Select Case strSpecificClassroom
                    Case Is = "Turtles"
                        GetLimit = 8
                    Case Is = "Butterflies"
                        GetLimit = 8
                End Select
            Case Is = "Fireflies/Ladybugs"
                Select Case strSpecificClassroom
                    Case Is = "Fireflies"
                        GetLimit = 8
                    Case Is = "Ladybugs"
                        GetLimit = 8
                End Select
            Case Is = "Dragonflies/Lions"
                Select Case strSpecificClassroom
                    Case Is = "Dragonflies"
                        GetLimit = 20
                    Case Is = "Lions"
                        GetLimit = 10
                End Select
            Case Is = "Tree Frogs"
                GetLimit = 20
        End Select
        Return GetLimit
    End Function

    ' get the counts for each day of the week for current month of year for current classroom
    Private Sub DaysOfWeekCount(oChild As Child)

        ' full day = 1 to both
        ' half am = 1 to am
        ' half pm = 1 to pm
        ' absent = none

        ' check monday
        Select Case oChild.strMonday
            Case Is = "Full Day"
                intMondayAM += 1
                intMondayPM += 1
            Case Is = "Half AM"
                intMondayAM += 1
            Case Is = "Half PM"
                intMondayPM += 1
        End Select

        ' check tuesday
        Select Case oChild.strTuesday
            Case Is = "Full Day"
                intTuesdayAM += 1
                intTuesdayPM += 1
            Case Is = "Half AM"
                intTuesdayAM += 1
            Case Is = "Half PM"
                intTuesdayPM += 1
        End Select

        ' check wednesday
        Select Case oChild.strWednesday
            Case Is = "Full Day"
                intWednesdayAM += 1
                intWednesdayPM += 1
            Case Is = "Half AM"
                intWednesdayAM += 1
            Case Is = "Half PM"
                intWednesdayPM += 1
        End Select

        ' check thursday
        Select Case oChild.strThursday
            Case Is = "Full Day"
                intThursdayAM += 1
                intThursdayPM += 1
            Case Is = "Half AM"
                intThursdayAM += 1
            Case Is = "Half PM"
                intThursdayPM += 1
        End Select

        ' check friday
        Select Case oChild.strFriday
            Case Is = "Full Day"
                intFridayAM += 1
                intFridayPM += 1
            Case Is = "Half AM"
                intFridayAM += 1
            Case Is = "Half PM"
                intFridayPM += 1
        End Select

    End Sub

    Shared intYearSequence As Integer = CInt(Date.Now.ToString("MM/dd/yyyy").Substring(6, 4)) ' current year
    Shared intMonthSequence As Integer = CInt(Date.Now.ToString("MM/dd/yyyy").Substring(0, 2)) ' current month
    Shared intDaySequence As Integer = CInt(Date.Now.ToString("MM/dd/yyyy").Substring(3, 2)) ' current day

    ' function to check if given date is less than current date
    Public Function DateCheck(ByVal strDate As String, ByVal strClassroom As String, ByVal strCurrentClassroom As String, ByVal bolPredictionOn As Boolean) As Boolean
        Dim intDateYear As Integer = CInt(strDate.Substring(6, 4)) ' start date year
        Dim intDateMonth As Integer = CInt(strDate.Substring(0, 2)) ' start date month
        Dim intDateDay As Integer = CInt(strDate.Substring(3, 2)) ' start date day
        Dim intCurrentYear As Integer = intYearSequence ' current date year on screen
        Dim intCurrentMonth As Integer = intMonthSequence ' current date month on screen
        Dim intCurrentDay As Integer = intDaySequence  ' current date day on screen

        ' checks which classroom (passed argument strClassroom) it is checking for. If no classroom is needed, "" is passed.
        ' Each room has a "rough" year predicted transition time. For each room, a year is added to intDateYear, to find out if child is predicted to be in that room at that year or not
        ' Caterpillars is omitted because it is the first room, therefore children can't transition into it.
        ' Kindergarten is omitted because it is not in the same "relationship" as the preschool classes
        Select Case strClassroom
            Case Is = "Turtles/Butterflies"
                intDateYear += 1
            Case Is = "Fireflies/Ladybugs"
                intDateYear += 2
            Case Is = "Dragonflies/Lions"
                intDateYear += 3
            Case Is = "Tree Frogs"
                intDateYear += 4
            Case Is = "" ' "" means the function is just checking the immediate date passed, rather than checking for a specific classroom
                intDateYear += 0
        End Select

        Dim intYearDifference As Integer = intCurrentYear - intDateYear ' subtract start year from current year
        ' if difference is above 0, start date is ready, no exceptions
        If intYearDifference > 0 Then
            DateCheck = True

            ' if difference is less than 0, start date is not ready, no exceptions
        ElseIf intYearDifference < 0 Then
            DateCheck = False

            ' if difference between years is 0, check months
        Else
            Dim intMonthDifference As Integer = intCurrentMonth - intDateMonth

            '  if difference is above 0, start date is ready, no exceptions
            If intMonthDifference > 0 Then
                DateCheck = True

                ' if difference is less than 0, start date is not ready, no exceptions
            ElseIf intMonthDifference < 0 Then
                DateCheck = False

                ' if difference between months is 0, check days
            Else
                Dim intDayDifference = intCurrentDay - intDateDay

                '  if difference is above 0, start date is ready, no exceptions
                If intDayDifference > 0 Then
                    DateCheck = True

                    ' if difference is below 0, start date is not ready, no exceptions
                ElseIf intDayDifference < 0 Then
                    DateCheck = False
                Else
                    DateCheck = True
                End If
            End If
        End If

        ' Child's strCurrentClassroom is passed to function
        ' If Child's strCurrentClassroom is a room higher than the classroom being looked at, do not show child in projection
        ' strCurrentClassroom can equal "", which indicates that the function is just being used to see if given date is smaller than current date, rather than having any classroom relation
        If bolPredictionOn = False Then
            Select Case strCurrentClassroom
                Case Is = "Caterpillars"
                    If strClassroom = "Caterpillars" Then
                        DateCheck = False
                    End If
                Case Is = "Turtles/Butterflies"
                    If strClassroom = "Caterpillars" Or strClassroom = "Turtles/Butterflies" Then
                        DateCheck = False
                    End If
                Case Is = "Fireflies/Ladybugs"
                    If strClassroom = "Caterpillars" Or strClassroom = "Turtles/Butterflies" Or strClassroom = "Fireflies/Ladybugs" Then
                        DateCheck = False
                    End If
                Case Is = "Dragonflies/Lions"
                    If strClassroom = "Caterpillars" Or strClassroom = "Turtles/Butterflies" Or strClassroom = "Fireflies/Ladybugs" _
                        Or strClassroom = "Dragonflies/Lions" Then
                        DateCheck = False
                    End If
                Case Is = "Tree Frogs"
                    If strClassroom = "Caterpillars" Or strClassroom = "Turtles/Butterflies" Or strClassroom = "Fireflies/Ladybugs" _
                         Or strClassroom = "Dragonflies/Lions" Or strClassroom = "Tree Frogs" Then
                        DateCheck = False
                    End If
                Case Is = "Kindergarten"
                    If strClassroom = "Caterpillars" Or strClassroom = "Turtles/Butterflies" Or strClassroom = "Fireflies/Ladybugs" _
                         Or strClassroom = "Dragonflies/Lions" Or strClassroom = "Tree Frogs" Then
                        DateCheck = False
                    End If
            End Select
        End If
        If strClassroom = "Kindergarten" Then
            DateCheck = False
        End If


        If bolPredictionOn = True Then
            Select Case strCurrentClassroom
                Case Is = "Turtles/Butterflies"
                    If strClassroom = "Caterpillars" Then
                        DateCheck = False
                    End If
                Case Is = "Fireflies/Ladybugs"
                    If strClassroom = "Caterpillars" Or strClassroom = "Turtles/Butterflies" Then
                        DateCheck = False
                    End If
                Case Is = "Dragonflies/Lions"
                    If strClassroom = "Caterpillars" Or strClassroom = "Turtles/Butterflies" Or strClassroom = "Fireflies/Ladybugs" Then
                        DateCheck = False
                    End If
                Case Is = "Tree Frogs"
                    If strClassroom = "Caterpillars" Or strClassroom = "Turtles/Butterflies" Or strClassroom = "Fireflies/Ladybugs" _
                         Or strClassroom = "Dragonflies/Lions" Then
                        DateCheck = False
                    End If
                Case Is = "Kindergarten"
                    If strClassroom = "Caterpillars" Or strClassroom = "Turtles/Butterflies" Or strClassroom = "Fireflies/Ladybugs" _
                         Or strClassroom = "Dragonflies/Lions" Or strClassroom = "Tree Frogs" Or strClassroom = "Kindergarten" Then
                        DateCheck = False
                    End If
            End Select
        End If

        Return DateCheck
    End Function


    Shared bolPredictedNext As Boolean
    ' check to find out which classroom child should be shown under, to make sure child is not shown under two rooms during the same month and year
    Private Function CheckNextClassroom(ByVal strBirthday As String, ByVal strCurrentClassroom As String, ByVal strClassroom As String) As Boolean
        Dim intDateYear As Integer = CInt(strBirthday.Substring(6, 4)) ' start date year
        Dim intDateMonth As Integer = CInt(strBirthday.Substring(0, 2)) ' start date month
        Dim intDateDay As Integer = CInt(strBirthday.Substring(3, 2)) ' start date day
        Dim intCurrentYear As Integer = intYearSequence ' current date year on screen
        Dim intCurrentMonth As Integer = intMonthSequence ' current date month on screen
        Dim intCurrentDay As Integer = intDaySequence  ' current date day on screen
        Dim intCounter As Integer

     
        ' LOOP
        ' Add one to intDateYear each loop
        ' if child birthday plus the year added to intDateYear is less than current date, keep looping
        ' loop until the child's date is no longer less than current date.
        Do
            intDateYear += 1 ' add one to intDateYear each time
            intCounter += 1 ' add one to counter
            Dim intYearDifference As Integer = intCurrentYear - intDateYear ' subtract start year from current year
            ' if difference is above 0, start date is ready, no exceptions
            If intYearDifference > 0 Then
                CheckNextClassroom = True

                ' if difference is less than 0, start date is not ready, no exceptions
            ElseIf intYearDifference < 0 Then
                CheckNextClassroom = False

                ' if difference between years is 0, check months
            Else
                Dim intMonthDifference As Integer = intCurrentMonth - intDateMonth

                '  if difference is above 0, start date is ready, no exceptions
                If intMonthDifference > 0 Then
                    CheckNextClassroom = True

                    ' if difference is less than 0, start date is not ready, no exceptions
                ElseIf intMonthDifference < 0 Then
                    CheckNextClassroom = False

                    ' if difference between months is 0, check days
                Else
                    Dim intDayDifference = intCurrentDay - intDateDay

                    '  if difference is above 0, start date is ready, no exceptions
                    If intDayDifference > 0 Then
                        CheckNextClassroom = True

                        ' if difference is below 0, start date is not ready, no exceptions
                    ElseIf intDayDifference < 0 Then
                        CheckNextClassroom = False
                    Else
                        CheckNextClassroom = True
                    End If
                End If
            End If
        Loop Until CheckNextClassroom = False

        ' check counter, which was incremented for each loop
        ' each loop represents a new room to be shown in, and depending on how old child is, they will be shown in correct room ONLY
        Select Case intCounter
            Case Is = 1
                If strClassroom <> "Caterpillars" Then
                    CheckNextClassroom = False
                Else
                    CheckNextClassroom = True
                End If
            Case Is = 2
                If strClassroom <> "Turtles/Butterflies" Then
                    CheckNextClassroom = False
                Else
                    CheckNextClassroom = True
                End If
            Case Is = 3
                If strClassroom <> "Fireflies/Ladybugs" Then
                    CheckNextClassroom = False
                Else
                    CheckNextClassroom = True
                End If
            Case Is = 4
                If strClassroom <> "Dragonflies/Lions" Then
                    CheckNextClassroom = False
                Else
                    CheckNextClassroom = True
                End If
            Case Is = 5
                If strClassroom <> "Tree Frogs" Then
                    CheckNextClassroom = False
                Else
                    CheckNextClassroom = True
                End If
        End Select

        Return CheckNextClassroom
    End Function

    ' formats datagridview
    Private Sub DataGridFormatting()
        dgvProjection.ClearSelection() ' clear auto select

        ' datagridview settings
        dgvProjection.Font = New Font("Calibri", 14) ' font style and size

        Dim column0 As DataGridViewColumn = dgvProjection.Columns(0)
        column0.Width = 300

        Dim column1 As DataGridViewColumn = dgvProjection.Columns(1)
        column1.Width = 60

        Dim column2 As DataGridViewColumn = dgvProjection.Columns(2)
        column2.Width = 120

        Dim column3 As DataGridViewColumn = dgvProjection.Columns(3)
        column3.Width = 55
    End Sub

    ' if btnUp is pressed (Up button)
    Private Sub btnUpClass_Click(sender As Object, e As EventArgs) Handles btnUpClass.Click
        lblClass.Text = GetClassroom("Up") ' get which classroom to change to from function GetClassroom
        Load_Projection() ' reload datagrid to show new classroom
        dgvProjection.Focus() ' give focus to datagrid
        Me.Text = lblClass.Text & " - " & lblMonthYear.Text
        lblClass.Left = CInt(Me.Width / 2 - lblClass.Width / 2) ' center label horizontally
    End Sub

    ' if btnDown is pressed (Down button)
    Private Sub btnDownClass_Click(sender As Object, e As EventArgs) Handles btnDownClass.Click
        lblClass.Text = GetClassroom("Down") ' get which classroom to change to from function GetClassroom
        Load_Projection() ' reload datagrid to show new classroom
        dgvProjection.Focus() ' give focus to datagrid
        Me.Text = lblClass.Text & " - " & lblMonthYear.Text
        lblClass.Left = CInt(Me.Width / 2 - lblClass.Width / 2) ' center label horizontally
    End Sub

    ' function to tell screen which classroom to look at next after either btnUp or btnDown is pressed
    Private Function GetClassroom(ByVal btn As String) As String
        GetClassroom = ""
        Select Case btn
            Case Is = "Up"
                Select Case lblClass.Text
                    Case Is = "Caterpillars"
                        GetClassroom = "Kindergarten"
                    Case Is = "Kindergarten"
                        GetClassroom = "Tree Frogs"
                    Case Is = "Tree Frogs"
                        GetClassroom = "Dragonflies/Lions"
                    Case Is = "Dragonflies/Lions"
                        GetClassroom = "Fireflies/Ladybugs"
                    Case Is = "Fireflies/Ladybugs"
                        GetClassroom = "Turtles/Butterflies"
                    Case Is = "Turtles/Butterflies"
                        GetClassroom = "Caterpillars"
                End Select
            Case Is = "Down"
                Select Case lblClass.Text
                    Case Is = "Caterpillars"
                        GetClassroom = "Turtles/Butterflies"
                    Case Is = "Turtles/Butterflies"
                        GetClassroom = "Fireflies/Ladybugs"
                    Case Is = "Fireflies/Ladybugs"
                        GetClassroom = "Dragonflies/Lions"
                    Case Is = "Dragonflies/Lions"
                        GetClassroom = "Tree Frogs"
                    Case Is = "Tree Frogs"
                        GetClassroom = "Kindergarten"
                    Case Is = "Kindergarten"
                        GetClassroom = "Caterpillars"
                End Select
        End Select
        Return GetClassroom
    End Function

    ' btnNextMonth is pressed (go to next month)
    Private Sub btnNextMonth_Click(sender As Object, e As EventArgs) Handles btnNextMonth.Click
        ' add to month sequence (next means go forward in the calendar)
        intMonthSequence += 1
        If intMonthSequence > 12 Then ' if months are over 12...
            intMonthSequence = 1 ' month sequence reverts back to 1 (January)
            intYearSequence += 1 ' a year is added to intYearSequence
        End If
        Dim strMonth As String = GetCorrespondingMonth(intMonthSequence) ' calls function to get written form of month depending on month number
        lblMonthYear.Text = strMonth & " " & intYearSequence.ToString ' display month in label
        lblMonthYear.Left = Me.Width - (lblMonthYear.Width + 10) ' positions lblMonthYear to be in the top right corner of form
        Me.Text = lblClass.Text & " - " & lblMonthYear.Text

        Load_Projection() ' reload datagrid
        dgvProjection.Focus() ' give focus to datagrid
    End Sub

    ' btnPreviousMonth is pressed (go to previous month)
    Private Sub btnPreviousMonth_Click(sender As Object, e As EventArgs) Handles btnPreviousMonth.Click
        ' add to month sequence (next means go forward in the calendar)
        intMonthSequence -= 1
        If intMonthSequence < 1 Then ' if months are under 1...
            intMonthSequence = 12 ' month sequence reverts back to 12 (December)
            intYearSequence -= 1 ' a year is subtracted from intYearSequence
        End If
        Dim strMonth As String = GetCorrespondingMonth(intMonthSequence) ' calls function to get written form of month depending on month number
        lblMonthYear.Text = strMonth & " " & intYearSequence.ToString ' display month in label
        lblMonthYear.Left = Me.Width - (lblMonthYear.Width + 10) ' positions lblMonthYear to be in the top right corner of form
        Me.Text = lblClass.Text & " - " & lblMonthYear.Text

        Load_Projection() ' reload datagrid
        dgvProjection.Focus() ' give focus to datagrid
    End Sub

    ' button Prediction toggles Prediction mode on or off
    Private Sub btnTogglePrediction_Click(sender As Object, e As EventArgs) Handles btnTogglePrediction.Click
        ' turn Prediction mode on or off
        If bolPrediction = False Then ' if prediction mode is off
            bolPrediction = True
            btnTogglePrediction.Text = "Turn Prediction Off"
            lblPrediction.Text = "Prediction = On"
        Else ' if prediction mode is on
            bolPrediction = False
            btnTogglePrediction.Text = "Turn Prediction On"
            lblPrediction.Text = "Prediction = Off"
        End If

        Load_Projection() ' reload datagrid
        dgvProjection.Focus()
    End Sub

    Private Sub dgvProjection_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProjection.CellDoubleClick
        Dim intRowNumber As Integer ' row number clicked on
        Try
            '   dgvProjection.Item(e.ColumnIndex, e.RowIndex).Value - - - - - remember this, it's how you take data from table
            intRowNumber = dgvProjection.CurrentRow.Index ' get current row index number
            CheckUnique(intRowNumber) ' search for child selected
        Catch ex As Exception
        End Try
    End Sub

    ' checks lstUnique for child unique identifier that was clicked.
    ' lstUnique is a listbox invisible to user, which stores all data from datagrid in order
    Private Sub CheckUnique(ByVal intRowNumber As Integer)
        Dim intUnique As Integer ' unique id of child 
        intUnique = CInt(lstUnique.Items(intRowNumber)) ' get unique id of child selected by getting the value of the row number selected in the list box lstUnique
        Dim frmEdit As New Edit
        frmEdit.lblUnique.Text = intUnique.ToString ' pass unique identifier to a invisible label in frmEdit
        frmEdit.ShowDialog() ' show frmEdit
    End Sub

    ' open main menu, close current form
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Dim oMain_Menu As New Main_Menu
        oMain_Menu.Show()
        Me.Close()
    End Sub
End Class