<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Records_Screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Records_Screen))
        Me.lstRecords = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblFlagDate = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblCurrentClassroom = New System.Windows.Forms.Label()
        Me.lblNextClassroom = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblMondayTime = New System.Windows.Forms.Label()
        Me.lblTuesdayTime = New System.Windows.Forms.Label()
        Me.lblWednesdayTime = New System.Windows.Forms.Label()
        Me.lblThursdayTime = New System.Windows.Forms.Label()
        Me.lblFridayTime = New System.Windows.Forms.Label()
        Me.clpAdd = New System.Windows.Forms.PictureBox()
        Me.clpEdit = New System.Windows.Forms.PictureBox()
        Me.clpDelete = New System.Windows.Forms.PictureBox()
        Me.lstUnique = New System.Windows.Forms.ListBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.clpAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstRecords
        '
        Me.lstRecords.BackColor = System.Drawing.Color.ForestGreen
        Me.lstRecords.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRecords.FormattingEnabled = True
        Me.lstRecords.ItemHeight = 23
        Me.lstRecords.Location = New System.Drawing.Point(597, 76)
        Me.lstRecords.Name = "lstRecords"
        Me.lstRecords.Size = New System.Drawing.Size(299, 395)
        Me.lstRecords.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.ForestGreen
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.ForestGreen
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DOB:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.ForestGreen
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Flag Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.ForestGreen
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(49, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.ForestGreen
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(205, 25)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Current Classroom:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.ForestGreen
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Next Classroom:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Green
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(136, 85)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(2, 27)
        Me.lblName.TabIndex = 7
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.BackColor = System.Drawing.Color.Green
        Me.lblBirthday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBirthday.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.Location = New System.Drawing.Point(118, 126)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(2, 27)
        Me.lblBirthday.TabIndex = 8
        '
        'lblFlagDate
        '
        Me.lblFlagDate.AutoSize = True
        Me.lblFlagDate.BackColor = System.Drawing.Color.Green
        Me.lblFlagDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFlagDate.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlagDate.Location = New System.Drawing.Point(170, 168)
        Me.lblFlagDate.Name = "lblFlagDate"
        Me.lblFlagDate.Size = New System.Drawing.Size(2, 27)
        Me.lblFlagDate.TabIndex = 9
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Green
        Me.lblAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAge.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAge.Location = New System.Drawing.Point(116, 210)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(2, 27)
        Me.lblAge.TabIndex = 10
        '
        'lblCurrentClassroom
        '
        Me.lblCurrentClassroom.AutoSize = True
        Me.lblCurrentClassroom.BackColor = System.Drawing.Color.Green
        Me.lblCurrentClassroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCurrentClassroom.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentClassroom.Location = New System.Drawing.Point(260, 251)
        Me.lblCurrentClassroom.Name = "lblCurrentClassroom"
        Me.lblCurrentClassroom.Size = New System.Drawing.Size(2, 27)
        Me.lblCurrentClassroom.TabIndex = 11
        '
        'lblNextClassroom
        '
        Me.lblNextClassroom.AutoSize = True
        Me.lblNextClassroom.BackColor = System.Drawing.Color.Green
        Me.lblNextClassroom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNextClassroom.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNextClassroom.Location = New System.Drawing.Point(232, 292)
        Me.lblNextClassroom.Name = "lblNextClassroom"
        Me.lblNextClassroom.Size = New System.Drawing.Size(2, 27)
        Me.lblNextClassroom.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.ForestGreen
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 380)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Monday"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.ForestGreen
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(144, 380)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tuesday"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.ForestGreen
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(249, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 19)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Wednesday"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.ForestGreen
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(366, 380)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 19)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Thursday"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.ForestGreen
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(488, 380)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 19)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Friday"
        '
        'lblMondayTime
        '
        Me.lblMondayTime.AutoSize = True
        Me.lblMondayTime.BackColor = System.Drawing.Color.Green
        Me.lblMondayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMondayTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMondayTime.Location = New System.Drawing.Point(30, 420)
        Me.lblMondayTime.Name = "lblMondayTime"
        Me.lblMondayTime.Size = New System.Drawing.Size(2, 21)
        Me.lblMondayTime.TabIndex = 18
        '
        'lblTuesdayTime
        '
        Me.lblTuesdayTime.AutoSize = True
        Me.lblTuesdayTime.BackColor = System.Drawing.Color.Green
        Me.lblTuesdayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTuesdayTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTuesdayTime.Location = New System.Drawing.Point(143, 420)
        Me.lblTuesdayTime.Name = "lblTuesdayTime"
        Me.lblTuesdayTime.Size = New System.Drawing.Size(2, 21)
        Me.lblTuesdayTime.TabIndex = 19
        '
        'lblWednesdayTime
        '
        Me.lblWednesdayTime.AutoSize = True
        Me.lblWednesdayTime.BackColor = System.Drawing.Color.Green
        Me.lblWednesdayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblWednesdayTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWednesdayTime.Location = New System.Drawing.Point(256, 420)
        Me.lblWednesdayTime.Name = "lblWednesdayTime"
        Me.lblWednesdayTime.Size = New System.Drawing.Size(2, 21)
        Me.lblWednesdayTime.TabIndex = 20
        '
        'lblThursdayTime
        '
        Me.lblThursdayTime.AutoSize = True
        Me.lblThursdayTime.BackColor = System.Drawing.Color.Green
        Me.lblThursdayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThursdayTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThursdayTime.Location = New System.Drawing.Point(370, 420)
        Me.lblThursdayTime.Name = "lblThursdayTime"
        Me.lblThursdayTime.Size = New System.Drawing.Size(2, 21)
        Me.lblThursdayTime.TabIndex = 21
        '
        'lblFridayTime
        '
        Me.lblFridayTime.AutoSize = True
        Me.lblFridayTime.BackColor = System.Drawing.Color.Green
        Me.lblFridayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFridayTime.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFridayTime.Location = New System.Drawing.Point(481, 420)
        Me.lblFridayTime.Name = "lblFridayTime"
        Me.lblFridayTime.Size = New System.Drawing.Size(2, 21)
        Me.lblFridayTime.TabIndex = 22
        '
        'clpAdd
        '
        Me.clpAdd.Image = CType(resources.GetObject("clpAdd.Image"), System.Drawing.Image)
        Me.clpAdd.Location = New System.Drawing.Point(103, 521)
        Me.clpAdd.Name = "clpAdd"
        Me.clpAdd.Size = New System.Drawing.Size(76, 76)
        Me.clpAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpAdd.TabIndex = 23
        Me.clpAdd.TabStop = False
        '
        'clpEdit
        '
        Me.clpEdit.Image = CType(resources.GetObject("clpEdit.Image"), System.Drawing.Image)
        Me.clpEdit.Location = New System.Drawing.Point(249, 521)
        Me.clpEdit.Name = "clpEdit"
        Me.clpEdit.Size = New System.Drawing.Size(76, 76)
        Me.clpEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpEdit.TabIndex = 24
        Me.clpEdit.TabStop = False
        '
        'clpDelete
        '
        Me.clpDelete.Image = CType(resources.GetObject("clpDelete.Image"), System.Drawing.Image)
        Me.clpDelete.Location = New System.Drawing.Point(395, 521)
        Me.clpDelete.Name = "clpDelete"
        Me.clpDelete.Size = New System.Drawing.Size(76, 76)
        Me.clpDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpDelete.TabIndex = 25
        Me.clpDelete.TabStop = False
        '
        'lstUnique
        '
        Me.lstUnique.BackColor = System.Drawing.Color.ForestGreen
        Me.lstUnique.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUnique.FormattingEnabled = True
        Me.lstUnique.ItemHeight = 23
        Me.lstUnique.Location = New System.Drawing.Point(597, 76)
        Me.lstUnique.Name = "lstUnique"
        Me.lstUnique.Size = New System.Drawing.Size(299, 395)
        Me.lstUnique.TabIndex = 26
        Me.lstUnique.Visible = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMainMenu.Location = New System.Drawing.Point(831, 595)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 43)
        Me.btnMainMenu.TabIndex = 27
        Me.btnMainMenu.Text = "Return to Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.ForestGreen
        Me.Label12.Location = New System.Drawing.Point(126, 600)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Add"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.ForestGreen
        Me.Label13.Location = New System.Drawing.Point(273, 600)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Edit"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.ForestGreen
        Me.Label14.Location = New System.Drawing.Point(416, 600)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Delete"
        '
        'Records_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Book_.My.Resources.Resources.Green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(918, 650)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.clpDelete)
        Me.Controls.Add(Me.clpEdit)
        Me.Controls.Add(Me.clpAdd)
        Me.Controls.Add(Me.lblFridayTime)
        Me.Controls.Add(Me.lblThursdayTime)
        Me.Controls.Add(Me.lblWednesdayTime)
        Me.Controls.Add(Me.lblTuesdayTime)
        Me.Controls.Add(Me.lblMondayTime)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblNextClassroom)
        Me.Controls.Add(Me.lblCurrentClassroom)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.lblFlagDate)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstRecords)
        Me.Controls.Add(Me.lstUnique)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Records_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Records"
        CType(Me.clpAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpDelete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstRecords As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblBirthday As System.Windows.Forms.Label
    Friend WithEvents lblFlagDate As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents lblCurrentClassroom As System.Windows.Forms.Label
    Friend WithEvents lblNextClassroom As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblMondayTime As System.Windows.Forms.Label
    Friend WithEvents lblTuesdayTime As System.Windows.Forms.Label
    Friend WithEvents lblWednesdayTime As System.Windows.Forms.Label
    Friend WithEvents lblThursdayTime As System.Windows.Forms.Label
    Friend WithEvents lblFridayTime As System.Windows.Forms.Label
    Friend WithEvents clpAdd As System.Windows.Forms.PictureBox
    Friend WithEvents clpEdit As System.Windows.Forms.PictureBox
    Friend WithEvents clpDelete As System.Windows.Forms.PictureBox
    Friend WithEvents lstUnique As System.Windows.Forms.ListBox
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
