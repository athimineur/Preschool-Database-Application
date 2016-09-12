Option Strict On
Option Explicit On

Public Class Records_Screen
    ' Procedure called when a list box selection is clicked (lstRecords)
    Private Sub lstRecords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRecords.SelectedIndexChanged
        If lstRecords.SelectedIndex >= 0 Then ' The index must be above -1, aka something must be selected
            Dim strSelectedItem As String = CStr(lstUnique.Items(lstRecords.SelectedIndex)) ' strSelectedItem = the equivalent index number in lstUnique as the item selected in lstRecords [lstUnique is an invisible listbox behind lstRecords)
            Dim strUnique As String = strSelectedItem.Substring(strSelectedItem.LastIndexOf(" ")) ' strUnique is equal to the last instance of a " " and the string after that, in this case will be the unique identifier of each child
            strUnique = strUnique.Substring(1, strUnique.Length - 1)
            For Each Value In Child.lstChild ' loop through list lstChild
                If Value.intUnique.ToString = strUnique Then ' if the unique identifier of a child in the list matches the unique identifier of the child selected on the listbox...
                    ' update all labels to show the child's information from lstChild
                    lblName.Text = Value.strLastName & ", " & Value.strFirstName
                    lblBirthday.Text = Value.strBirthday
                    lblFlagDate.Text = Value.strFlagDate
                    lblAge.Text = Value.intAge.ToString & " Yrs., " & Value.intMonths.ToString & " Mos."
                    lblCurrentClassroom.Text = Value.strCurrentClassroom
                    lblNextClassroom.Text = Value.strNextClassroom
                    lblMondayTime.Text = Value.strMonday
                    lblTuesdayTime.Text = Value.strTuesday
                    lblWednesdayTime.Text = Value.strWednesday
                    lblThursdayTime.Text = Value.strThursday
                    lblFridayTime.Text = Value.strFriday


                    ' make labels visible
                    lblName.Visible = True
                    lblBirthday.Visible = True
                    lblFlagDate.Visible = True
                    lblAge.Visible = True
                    lblCurrentClassroom.Visible = True
                    lblNextClassroom.Visible = True
                    lblMondayTime.Visible = True
                    lblTuesdayTime.Visible = True
                    lblWednesdayTime.Visible = True
                    lblThursdayTime.Visible = True
                    lblFridayTime.Visible = True

                End If
            Next
        End If
    End Sub
    Shared bolDelete As Boolean
    ' Every time Records Screen receives focus, repopulate listboxes with possible updates from lstChild
    Private Sub Records_Screen_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If bolDelete = False Then ' if delete wasn't pressed and form is regaining focus, reload listboxes
            ' fill listboxes
            FillListBox()
        End If

        ' hide labels when they aren't displaying anything
        HideLabels()

    End Sub

    Private Sub FillListBox()
        ' Clear both listboxes in Records_Screen
        lstRecords.Items.Clear()
        lstUnique.Items.Clear()

        For Each Value In Child.lstChild ' loop through lstChild
            If Value.strLastName <> "" Then
                ' add each child last name and first name to lstRecords listbox
                lstRecords.Items.Add(Value.strLastName & ", " & Value.strFirstName)
                lstRecords.Sorted = True ' alphabatize it

                ' add each child last name and first name and unique identifier to lstUnique listbox (not visible to user)
                lstUnique.Items.Add(Value.strLastName & ", " & Value.strFirstName & ", " & Value.intUnique.ToString)
                lstUnique.Sorted = True ' alphabatize it
            End If
        Next
    End Sub

    ' Draws graphics to screen
    Private Sub Form_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim imgTurtleUpsideDown As New Bitmap(My.Resources.TurtleUpsideDown)
        imgTurtleUpsideDown.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(New Bitmap(imgTurtleUpsideDown), 640, 510, 186, 91)

        Dim imgInfoBorder As New Bitmap(My.Resources.BoarderInfo)
        imgInfoBorder.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(New Bitmap(imgInfoBorder), 12, 70, 560, 263)

        Dim imgInfoDays As New Bitmap(My.Resources.BorderDays)
        imgInfoDays.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(New Bitmap(imgInfoDays), 12, 370, 107, 103)

        Dim imgInfoDays1 As New Bitmap(My.Resources.BorderDays)
        imgInfoDays.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(New Bitmap(imgInfoDays), 125, 370, 107, 103)

        Dim imgInfoDays2 As New Bitmap(My.Resources.BorderDays)
        imgInfoDays.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(New Bitmap(imgInfoDays), 238, 370, 107, 103)

        Dim imgInfoDays3 As New Bitmap(My.Resources.BorderDays)
        imgInfoDays.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(New Bitmap(imgInfoDays), 351, 370, 107, 103)

        Dim imgInfoDays4 As New Bitmap(My.Resources.BorderDays)
        imgInfoDays.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(New Bitmap(imgInfoDays), 464, 370, 107, 103)

        Dim imgButtonBorder As New Bitmap(My.Resources.ButtonBorder)
        imgButtonBorder.MakeTransparent(Color.Magenta)
        e.Graphics.DrawImage(New Bitmap(imgButtonBorder), 42, 491, 494, 137)
    End Sub

    ' Plus button (add button)
    Private Sub clpAdd_Click(sender As Object, e As EventArgs) Handles clpAdd.Click
        ' Show Add_New_Screen to allow user to enter new child (model)
        Dim frmAdd_New_Screen As New Add_New_Screen
        frmAdd_New_Screen.ShowDialog()
    End Sub

    ' if edit button is pressed, open edit form
    Private Sub clpEdit_Click(sender As Object, e As EventArgs) Handles clpEdit.Click
        If lstRecords.SelectedIndex > -1 Then ' as long as something in listbox is selected
            Dim strSelectedItem As String = CStr(lstUnique.Items(lstRecords.SelectedIndex)) ' strSelectedItem = the equivalent index number in lstUnique as the item selected in lstRecords [lstUnique is an invisible listbox behind lstRecords)
            Dim strUnique As String = strSelectedItem.Substring(strSelectedItem.LastIndexOf(" ")) ' strUnique is equal to the last instance of a " " and the string after that, in this case will be the unique identifier of each child
            strUnique = strUnique.Substring(1, strUnique.Length - 1) ' take only the number from strUnique
            Dim frmEdit As New Edit
            frmEdit.lblUnique.Text = strUnique ' send unique ID to label in edit form
            frmEdit.Show() ' show edit form
        End If
    End Sub

    ' button to delete child
    Private Sub clpDelete_Click(sender As Object, e As EventArgs) Handles clpDelete.Click

        Dim intUniqueID As Integer
        If lstRecords.SelectedIndex > -1 Then ' as long as something in listbox is selected
            Dim strSelectedItem As String = CStr(lstUnique.Items(lstRecords.SelectedIndex)) ' strSelectedItem = the equivalent index number in lstUnique as the item selected in lstRecords [lstUnique is an invisible listbox behind lstRecords)
            Dim strUnique As String = strSelectedItem.Substring(strSelectedItem.LastIndexOf(" ")) ' strUnique is equal to the last instance of a " " and the string after that, in this case will be the unique identifier of each child
            strUnique = strUnique.Substring(1, strUnique.Length - 1) ' take only the number from strUnique
            intUniqueID = CInt(strUnique)
            ' checks to make sure user is okay with deleting child
            Dim intResult As Integer = MessageBox.Show("Are you sure you want to delete child?" & vbNewLine & "This cannot be undone.", "Are you sure?", MessageBoxButtons.YesNoCancel)
            If intResult = DialogResult.Yes Then
                ' go to DeleteChild sub in Database_Handling to remove child from database
                Dim oDatabase_Handling As New Database_Handling
                oDatabase_Handling.DeleteChild(intUniqueID)

                ' remove child from lstChild
                Child.lstChild.RemoveAll(Function(Child) Child.intUnique = intUniqueID)
                FillListBox() ' refill listbox 
                HideLabels() ' hide all labels
            End If
        End If

        
    End Sub

    Private Sub Records_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' hide labels when they aren't displaying anything
        HideLabels()
    End Sub

    Private Sub HideLabels()
        ' hide labels when they aren't displaying anything
        lblName.Visible = False
        lblBirthday.Visible = False
        lblFlagDate.Visible = False
        lblAge.Visible = False
        lblCurrentClassroom.Visible = False
        lblNextClassroom.Visible = False
        lblMondayTime.Visible = False
        lblTuesdayTime.Visible = False
        lblWednesdayTime.Visible = False
        lblThursdayTime.Visible = False
        lblFridayTime.Visible = False
    End Sub

    ' return to main menu button
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        ' return to main menu
        Dim oMain_Menu As New Main_Menu
        oMain_Menu.Show()
        Me.Close()
    End Sub
End Class