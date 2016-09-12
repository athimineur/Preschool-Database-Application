Option Strict On
Option Explicit On

Public Class Main_Menu

    ' when button Records is clicked, close main menu and open Records form
    Private Sub btnRecords_Click(sender As Object, e As EventArgs) Handles btnRecords.Click
        Dim frmRecords_Screen As New Records_Screen
        frmRecords_Screen.Show()
        Me.Close()
    End Sub

    ' when button classrooms is clicked, close main menu and open classrooms form
    Private Sub btnClassrooms_Click(sender As Object, e As EventArgs) Handles btnClassrooms.Click
        Dim frmProjection_GridMode As New Projection_GridMode
        frmProjection_GridMode.Show()
        Me.Close()
    End Sub

    ' when about is clicked on menu strip, display messagebox of information
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("Program created by: Alex Thimineur, 2014")
    End Sub

End Class