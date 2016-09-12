Option Strict On
Option Explicit On

Public Class StartUp_Form
    ' when enter is clicked (will take a few seconds to run through code)
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Try
            Dim oDatabase_Handling As New Database_Handling
            ' open database and load dataset 
            oDatabase_Handling.Open()

            ' put database into lstChild
            Dim inc As Integer = 0
            Dim MaxRows = Database_Handling.ds.Tables("Child").Rows.Count ' count rows in database
            For i = 0 To MaxRows - 1 ' loop through each row of database
                oDatabase_Handling.LoadList(inc) ' go to oDatabaseHandling
            Next
            If Child.lstChild.Count - 1 <> MaxRows - 1 Then ' if all rows in database were not able to transfer...
                ' display error message
                MessageBox.Show("Error: Not able to load some or all values from database.", "Error")
            Else ' otherwise, display success message
                MessageBox.Show("Database loaded successfully!", "Success")
            End If

            ' open main menu and close start up form
            Dim frmMain_Menu As New Main_Menu
            frmMain_Menu.Show()
            Me.Close()
        Catch ex As Exception
            ' if database could not be found, display this error message
            MessageBox.Show("Database could not be located!")
        End Try
    End Sub

End Class