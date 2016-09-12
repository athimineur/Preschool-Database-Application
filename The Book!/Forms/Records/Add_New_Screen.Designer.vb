<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_New_Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_New_Screen))
        Me.grpNames = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Classrooms = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCurrentClassroom = New System.Windows.Forms.ComboBox()
        Me.grpDates = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBirthday = New System.Windows.Forms.TextBox()
        Me.grpAutoAssigned = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUniqueIdentifier = New System.Windows.Forms.TextBox()
        Me.grpMonday = New System.Windows.Forms.GroupBox()
        Me.rbAbsent_Monday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_PM_Monday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_AM_Monday = New System.Windows.Forms.RadioButton()
        Me.rbFull_Day_Monday = New System.Windows.Forms.RadioButton()
        Me.Tuesday = New System.Windows.Forms.GroupBox()
        Me.rbAbsent_Tuesday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_PM_Tuesday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_AM_Tuesday = New System.Windows.Forms.RadioButton()
        Me.rbFull_Day_Tuesday = New System.Windows.Forms.RadioButton()
        Me.grpWednesday = New System.Windows.Forms.GroupBox()
        Me.rbAbsent_Wednesday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_PM_Wednesday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_AM_Wednesday = New System.Windows.Forms.RadioButton()
        Me.rbFull_Day_Wednesday = New System.Windows.Forms.RadioButton()
        Me.grpThursday = New System.Windows.Forms.GroupBox()
        Me.rbAbsent_Thursday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_PM_Thursday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_AM_Thursday = New System.Windows.Forms.RadioButton()
        Me.rbFull_Day_Thursday = New System.Windows.Forms.RadioButton()
        Me.grpFriday = New System.Windows.Forms.GroupBox()
        Me.rbAbsent_Friday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_PM_Friday = New System.Windows.Forms.RadioButton()
        Me.rbHalf_AM_Friday = New System.Windows.Forms.RadioButton()
        Me.rbFull_Day_Friday = New System.Windows.Forms.RadioButton()
        Me.clpAccept = New System.Windows.Forms.PictureBox()
        Me.clpCancel = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.grpNames.SuspendLayout()
        Me.Classrooms.SuspendLayout()
        Me.grpDates.SuspendLayout()
        Me.grpAutoAssigned.SuspendLayout()
        Me.grpMonday.SuspendLayout()
        Me.Tuesday.SuspendLayout()
        Me.grpWednesday.SuspendLayout()
        Me.grpThursday.SuspendLayout()
        Me.grpFriday.SuspendLayout()
        CType(Me.clpAccept, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clpCancel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpNames
        '
        Me.grpNames.BackColor = System.Drawing.Color.ForestGreen
        Me.grpNames.Controls.Add(Me.Label2)
        Me.grpNames.Controls.Add(Me.Label1)
        Me.grpNames.Controls.Add(Me.txtFirstName)
        Me.grpNames.Controls.Add(Me.txtLastName)
        Me.grpNames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpNames.Location = New System.Drawing.Point(69, 55)
        Me.grpNames.Name = "grpNames"
        Me.grpNames.Size = New System.Drawing.Size(315, 100)
        Me.grpNames.TabIndex = 0
        Me.grpNames.TabStop = False
        Me.grpNames.Text = "Names"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "* First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "* Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(127, 57)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(154, 22)
        Me.txtFirstName.TabIndex = 8
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(127, 24)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(154, 22)
        Me.txtLastName.TabIndex = 7
        '
        'Classrooms
        '
        Me.Classrooms.BackColor = System.Drawing.Color.ForestGreen
        Me.Classrooms.Controls.Add(Me.Label3)
        Me.Classrooms.Controls.Add(Me.cboCurrentClassroom)
        Me.Classrooms.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Classrooms.Location = New System.Drawing.Point(416, 55)
        Me.Classrooms.Name = "Classrooms"
        Me.Classrooms.Size = New System.Drawing.Size(338, 100)
        Me.Classrooms.TabIndex = 1
        Me.Classrooms.TabStop = False
        Me.Classrooms.Text = "Classrooms"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "* Current Classroom:"
        '
        'cboCurrentClassroom
        '
        Me.cboCurrentClassroom.FormattingEnabled = True
        Me.cboCurrentClassroom.Items.AddRange(New Object() {"Select a classroom...", "Caterpillars", "Turtles/Butterflies", "Fireflies/Ladybugs", "Dragonflies/Lions", "Tree Frogs", "Kindergarten"})
        Me.cboCurrentClassroom.Location = New System.Drawing.Point(171, 43)
        Me.cboCurrentClassroom.Name = "cboCurrentClassroom"
        Me.cboCurrentClassroom.Size = New System.Drawing.Size(148, 24)
        Me.cboCurrentClassroom.TabIndex = 7
        '
        'grpDates
        '
        Me.grpDates.BackColor = System.Drawing.Color.ForestGreen
        Me.grpDates.Controls.Add(Me.Label4)
        Me.grpDates.Controls.Add(Me.txtStartDate)
        Me.grpDates.Controls.Add(Me.Label5)
        Me.grpDates.Controls.Add(Me.txtBirthday)
        Me.grpDates.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDates.Location = New System.Drawing.Point(69, 172)
        Me.grpDates.Name = "grpDates"
        Me.grpDates.Size = New System.Drawing.Size(315, 108)
        Me.grpDates.TabIndex = 1
        Me.grpDates.TabStop = False
        Me.grpDates.Text = "Dates (mm/dd/yyyy)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Start Date:"
        '
        'txtStartDate
        '
        Me.txtStartDate.Location = New System.Drawing.Point(127, 73)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(155, 22)
        Me.txtStartDate.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "* Birthday:"
        '
        'txtBirthday
        '
        Me.txtBirthday.Location = New System.Drawing.Point(127, 33)
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.Size = New System.Drawing.Size(155, 22)
        Me.txtBirthday.TabIndex = 9
        '
        'grpAutoAssigned
        '
        Me.grpAutoAssigned.BackColor = System.Drawing.Color.ForestGreen
        Me.grpAutoAssigned.Controls.Add(Me.Label8)
        Me.grpAutoAssigned.Controls.Add(Me.txtUniqueIdentifier)
        Me.grpAutoAssigned.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAutoAssigned.Location = New System.Drawing.Point(416, 181)
        Me.grpAutoAssigned.Name = "grpAutoAssigned"
        Me.grpAutoAssigned.Size = New System.Drawing.Size(338, 88)
        Me.grpAutoAssigned.TabIndex = 2
        Me.grpAutoAssigned.TabStop = False
        Me.grpAutoAssigned.Text = "Unique Identifier"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(130, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Unique Identifier:"
        '
        'txtUniqueIdentifier
        '
        Me.txtUniqueIdentifier.Enabled = False
        Me.txtUniqueIdentifier.Location = New System.Drawing.Point(171, 39)
        Me.txtUniqueIdentifier.Name = "txtUniqueIdentifier"
        Me.txtUniqueIdentifier.Size = New System.Drawing.Size(138, 22)
        Me.txtUniqueIdentifier.TabIndex = 8
        '
        'grpMonday
        '
        Me.grpMonday.BackColor = System.Drawing.Color.ForestGreen
        Me.grpMonday.Controls.Add(Me.rbAbsent_Monday)
        Me.grpMonday.Controls.Add(Me.rbHalf_PM_Monday)
        Me.grpMonday.Controls.Add(Me.rbHalf_AM_Monday)
        Me.grpMonday.Controls.Add(Me.rbFull_Day_Monday)
        Me.grpMonday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMonday.Location = New System.Drawing.Point(112, 298)
        Me.grpMonday.Name = "grpMonday"
        Me.grpMonday.Size = New System.Drawing.Size(115, 115)
        Me.grpMonday.TabIndex = 2
        Me.grpMonday.TabStop = False
        Me.grpMonday.Text = "* Monday "
        '
        'rbAbsent_Monday
        '
        Me.rbAbsent_Monday.AutoSize = True
        Me.rbAbsent_Monday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAbsent_Monday.Location = New System.Drawing.Point(16, 88)
        Me.rbAbsent_Monday.Name = "rbAbsent_Monday"
        Me.rbAbsent_Monday.Size = New System.Drawing.Size(78, 24)
        Me.rbAbsent_Monday.TabIndex = 12
        Me.rbAbsent_Monday.TabStop = True
        Me.rbAbsent_Monday.Text = "Absent"
        Me.rbAbsent_Monday.UseVisualStyleBackColor = True
        '
        'rbHalf_PM_Monday
        '
        Me.rbHalf_PM_Monday.AutoSize = True
        Me.rbHalf_PM_Monday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_PM_Monday.Location = New System.Drawing.Point(16, 65)
        Me.rbHalf_PM_Monday.Name = "rbHalf_PM_Monday"
        Me.rbHalf_PM_Monday.Size = New System.Drawing.Size(83, 24)
        Me.rbHalf_PM_Monday.TabIndex = 11
        Me.rbHalf_PM_Monday.TabStop = True
        Me.rbHalf_PM_Monday.Text = "Half PM"
        Me.rbHalf_PM_Monday.UseVisualStyleBackColor = True
        '
        'rbHalf_AM_Monday
        '
        Me.rbHalf_AM_Monday.AutoSize = True
        Me.rbHalf_AM_Monday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_AM_Monday.Location = New System.Drawing.Point(16, 42)
        Me.rbHalf_AM_Monday.Name = "rbHalf_AM_Monday"
        Me.rbHalf_AM_Monday.Size = New System.Drawing.Size(84, 24)
        Me.rbHalf_AM_Monday.TabIndex = 10
        Me.rbHalf_AM_Monday.TabStop = True
        Me.rbHalf_AM_Monday.Text = "Half AM"
        Me.rbHalf_AM_Monday.UseVisualStyleBackColor = True
        '
        'rbFull_Day_Monday
        '
        Me.rbFull_Day_Monday.AutoSize = True
        Me.rbFull_Day_Monday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFull_Day_Monday.Location = New System.Drawing.Point(16, 19)
        Me.rbFull_Day_Monday.Name = "rbFull_Day_Monday"
        Me.rbFull_Day_Monday.Size = New System.Drawing.Size(84, 24)
        Me.rbFull_Day_Monday.TabIndex = 9
        Me.rbFull_Day_Monday.TabStop = True
        Me.rbFull_Day_Monday.Text = "Full Day"
        Me.rbFull_Day_Monday.UseVisualStyleBackColor = True
        '
        'Tuesday
        '
        Me.Tuesday.BackColor = System.Drawing.Color.ForestGreen
        Me.Tuesday.Controls.Add(Me.rbAbsent_Tuesday)
        Me.Tuesday.Controls.Add(Me.rbHalf_PM_Tuesday)
        Me.Tuesday.Controls.Add(Me.rbHalf_AM_Tuesday)
        Me.Tuesday.Controls.Add(Me.rbFull_Day_Tuesday)
        Me.Tuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tuesday.Location = New System.Drawing.Point(233, 298)
        Me.Tuesday.Name = "Tuesday"
        Me.Tuesday.Size = New System.Drawing.Size(115, 115)
        Me.Tuesday.TabIndex = 3
        Me.Tuesday.TabStop = False
        Me.Tuesday.Text = "* Tuesday"
        '
        'rbAbsent_Tuesday
        '
        Me.rbAbsent_Tuesday.AutoSize = True
        Me.rbAbsent_Tuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAbsent_Tuesday.Location = New System.Drawing.Point(16, 88)
        Me.rbAbsent_Tuesday.Name = "rbAbsent_Tuesday"
        Me.rbAbsent_Tuesday.Size = New System.Drawing.Size(78, 24)
        Me.rbAbsent_Tuesday.TabIndex = 13
        Me.rbAbsent_Tuesday.TabStop = True
        Me.rbAbsent_Tuesday.Text = "Absent"
        Me.rbAbsent_Tuesday.UseVisualStyleBackColor = True
        '
        'rbHalf_PM_Tuesday
        '
        Me.rbHalf_PM_Tuesday.AutoSize = True
        Me.rbHalf_PM_Tuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_PM_Tuesday.Location = New System.Drawing.Point(16, 65)
        Me.rbHalf_PM_Tuesday.Name = "rbHalf_PM_Tuesday"
        Me.rbHalf_PM_Tuesday.Size = New System.Drawing.Size(83, 24)
        Me.rbHalf_PM_Tuesday.TabIndex = 12
        Me.rbHalf_PM_Tuesday.TabStop = True
        Me.rbHalf_PM_Tuesday.Text = "Half PM"
        Me.rbHalf_PM_Tuesday.UseVisualStyleBackColor = True
        '
        'rbHalf_AM_Tuesday
        '
        Me.rbHalf_AM_Tuesday.AutoSize = True
        Me.rbHalf_AM_Tuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_AM_Tuesday.Location = New System.Drawing.Point(16, 42)
        Me.rbHalf_AM_Tuesday.Name = "rbHalf_AM_Tuesday"
        Me.rbHalf_AM_Tuesday.Size = New System.Drawing.Size(84, 24)
        Me.rbHalf_AM_Tuesday.TabIndex = 11
        Me.rbHalf_AM_Tuesday.TabStop = True
        Me.rbHalf_AM_Tuesday.Text = "Half AM"
        Me.rbHalf_AM_Tuesday.UseVisualStyleBackColor = True
        '
        'rbFull_Day_Tuesday
        '
        Me.rbFull_Day_Tuesday.AutoSize = True
        Me.rbFull_Day_Tuesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFull_Day_Tuesday.Location = New System.Drawing.Point(16, 19)
        Me.rbFull_Day_Tuesday.Name = "rbFull_Day_Tuesday"
        Me.rbFull_Day_Tuesday.Size = New System.Drawing.Size(84, 24)
        Me.rbFull_Day_Tuesday.TabIndex = 10
        Me.rbFull_Day_Tuesday.TabStop = True
        Me.rbFull_Day_Tuesday.Text = "Full Day"
        Me.rbFull_Day_Tuesday.UseVisualStyleBackColor = True
        '
        'grpWednesday
        '
        Me.grpWednesday.BackColor = System.Drawing.Color.ForestGreen
        Me.grpWednesday.Controls.Add(Me.rbAbsent_Wednesday)
        Me.grpWednesday.Controls.Add(Me.rbHalf_PM_Wednesday)
        Me.grpWednesday.Controls.Add(Me.rbHalf_AM_Wednesday)
        Me.grpWednesday.Controls.Add(Me.rbFull_Day_Wednesday)
        Me.grpWednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpWednesday.Location = New System.Drawing.Point(354, 298)
        Me.grpWednesday.Name = "grpWednesday"
        Me.grpWednesday.Size = New System.Drawing.Size(115, 115)
        Me.grpWednesday.TabIndex = 4
        Me.grpWednesday.TabStop = False
        Me.grpWednesday.Text = "* Wednesday"
        '
        'rbAbsent_Wednesday
        '
        Me.rbAbsent_Wednesday.AutoSize = True
        Me.rbAbsent_Wednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAbsent_Wednesday.Location = New System.Drawing.Point(16, 88)
        Me.rbAbsent_Wednesday.Name = "rbAbsent_Wednesday"
        Me.rbAbsent_Wednesday.Size = New System.Drawing.Size(78, 24)
        Me.rbAbsent_Wednesday.TabIndex = 14
        Me.rbAbsent_Wednesday.TabStop = True
        Me.rbAbsent_Wednesday.Text = "Absent"
        Me.rbAbsent_Wednesday.UseVisualStyleBackColor = True
        '
        'rbHalf_PM_Wednesday
        '
        Me.rbHalf_PM_Wednesday.AutoSize = True
        Me.rbHalf_PM_Wednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_PM_Wednesday.Location = New System.Drawing.Point(16, 65)
        Me.rbHalf_PM_Wednesday.Name = "rbHalf_PM_Wednesday"
        Me.rbHalf_PM_Wednesday.Size = New System.Drawing.Size(83, 24)
        Me.rbHalf_PM_Wednesday.TabIndex = 13
        Me.rbHalf_PM_Wednesday.TabStop = True
        Me.rbHalf_PM_Wednesday.Text = "Half PM"
        Me.rbHalf_PM_Wednesday.UseVisualStyleBackColor = True
        '
        'rbHalf_AM_Wednesday
        '
        Me.rbHalf_AM_Wednesday.AutoSize = True
        Me.rbHalf_AM_Wednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_AM_Wednesday.Location = New System.Drawing.Point(16, 42)
        Me.rbHalf_AM_Wednesday.Name = "rbHalf_AM_Wednesday"
        Me.rbHalf_AM_Wednesday.Size = New System.Drawing.Size(84, 24)
        Me.rbHalf_AM_Wednesday.TabIndex = 12
        Me.rbHalf_AM_Wednesday.TabStop = True
        Me.rbHalf_AM_Wednesday.Text = "Half AM"
        Me.rbHalf_AM_Wednesday.UseVisualStyleBackColor = True
        '
        'rbFull_Day_Wednesday
        '
        Me.rbFull_Day_Wednesday.AutoSize = True
        Me.rbFull_Day_Wednesday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFull_Day_Wednesday.Location = New System.Drawing.Point(16, 19)
        Me.rbFull_Day_Wednesday.Name = "rbFull_Day_Wednesday"
        Me.rbFull_Day_Wednesday.Size = New System.Drawing.Size(84, 24)
        Me.rbFull_Day_Wednesday.TabIndex = 11
        Me.rbFull_Day_Wednesday.TabStop = True
        Me.rbFull_Day_Wednesday.Text = "Full Day"
        Me.rbFull_Day_Wednesday.UseVisualStyleBackColor = True
        '
        'grpThursday
        '
        Me.grpThursday.BackColor = System.Drawing.Color.ForestGreen
        Me.grpThursday.Controls.Add(Me.rbAbsent_Thursday)
        Me.grpThursday.Controls.Add(Me.rbHalf_PM_Thursday)
        Me.grpThursday.Controls.Add(Me.rbHalf_AM_Thursday)
        Me.grpThursday.Controls.Add(Me.rbFull_Day_Thursday)
        Me.grpThursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpThursday.Location = New System.Drawing.Point(475, 298)
        Me.grpThursday.Name = "grpThursday"
        Me.grpThursday.Size = New System.Drawing.Size(115, 115)
        Me.grpThursday.TabIndex = 5
        Me.grpThursday.TabStop = False
        Me.grpThursday.Text = "* Thursday"
        '
        'rbAbsent_Thursday
        '
        Me.rbAbsent_Thursday.AutoSize = True
        Me.rbAbsent_Thursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAbsent_Thursday.Location = New System.Drawing.Point(16, 88)
        Me.rbAbsent_Thursday.Name = "rbAbsent_Thursday"
        Me.rbAbsent_Thursday.Size = New System.Drawing.Size(78, 24)
        Me.rbAbsent_Thursday.TabIndex = 14
        Me.rbAbsent_Thursday.TabStop = True
        Me.rbAbsent_Thursday.Text = "Absent"
        Me.rbAbsent_Thursday.UseVisualStyleBackColor = True
        '
        'rbHalf_PM_Thursday
        '
        Me.rbHalf_PM_Thursday.AutoSize = True
        Me.rbHalf_PM_Thursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_PM_Thursday.Location = New System.Drawing.Point(16, 65)
        Me.rbHalf_PM_Thursday.Name = "rbHalf_PM_Thursday"
        Me.rbHalf_PM_Thursday.Size = New System.Drawing.Size(83, 24)
        Me.rbHalf_PM_Thursday.TabIndex = 14
        Me.rbHalf_PM_Thursday.TabStop = True
        Me.rbHalf_PM_Thursday.Text = "Half PM"
        Me.rbHalf_PM_Thursday.UseVisualStyleBackColor = True
        '
        'rbHalf_AM_Thursday
        '
        Me.rbHalf_AM_Thursday.AutoSize = True
        Me.rbHalf_AM_Thursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_AM_Thursday.Location = New System.Drawing.Point(16, 42)
        Me.rbHalf_AM_Thursday.Name = "rbHalf_AM_Thursday"
        Me.rbHalf_AM_Thursday.Size = New System.Drawing.Size(84, 24)
        Me.rbHalf_AM_Thursday.TabIndex = 13
        Me.rbHalf_AM_Thursday.TabStop = True
        Me.rbHalf_AM_Thursday.Text = "Half AM"
        Me.rbHalf_AM_Thursday.UseVisualStyleBackColor = True
        '
        'rbFull_Day_Thursday
        '
        Me.rbFull_Day_Thursday.AutoSize = True
        Me.rbFull_Day_Thursday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFull_Day_Thursday.Location = New System.Drawing.Point(16, 19)
        Me.rbFull_Day_Thursday.Name = "rbFull_Day_Thursday"
        Me.rbFull_Day_Thursday.Size = New System.Drawing.Size(84, 24)
        Me.rbFull_Day_Thursday.TabIndex = 12
        Me.rbFull_Day_Thursday.TabStop = True
        Me.rbFull_Day_Thursday.Text = "Full Day"
        Me.rbFull_Day_Thursday.UseVisualStyleBackColor = True
        '
        'grpFriday
        '
        Me.grpFriday.BackColor = System.Drawing.Color.ForestGreen
        Me.grpFriday.Controls.Add(Me.rbAbsent_Friday)
        Me.grpFriday.Controls.Add(Me.rbHalf_PM_Friday)
        Me.grpFriday.Controls.Add(Me.rbHalf_AM_Friday)
        Me.grpFriday.Controls.Add(Me.rbFull_Day_Friday)
        Me.grpFriday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFriday.Location = New System.Drawing.Point(596, 298)
        Me.grpFriday.Name = "grpFriday"
        Me.grpFriday.Size = New System.Drawing.Size(115, 115)
        Me.grpFriday.TabIndex = 6
        Me.grpFriday.TabStop = False
        Me.grpFriday.Text = "* Friday"
        '
        'rbAbsent_Friday
        '
        Me.rbAbsent_Friday.AutoSize = True
        Me.rbAbsent_Friday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAbsent_Friday.Location = New System.Drawing.Point(16, 88)
        Me.rbAbsent_Friday.Name = "rbAbsent_Friday"
        Me.rbAbsent_Friday.Size = New System.Drawing.Size(78, 24)
        Me.rbAbsent_Friday.TabIndex = 15
        Me.rbAbsent_Friday.TabStop = True
        Me.rbAbsent_Friday.Text = "Absent"
        Me.rbAbsent_Friday.UseVisualStyleBackColor = True
        '
        'rbHalf_PM_Friday
        '
        Me.rbHalf_PM_Friday.AutoSize = True
        Me.rbHalf_PM_Friday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_PM_Friday.Location = New System.Drawing.Point(16, 65)
        Me.rbHalf_PM_Friday.Name = "rbHalf_PM_Friday"
        Me.rbHalf_PM_Friday.Size = New System.Drawing.Size(83, 24)
        Me.rbHalf_PM_Friday.TabIndex = 15
        Me.rbHalf_PM_Friday.TabStop = True
        Me.rbHalf_PM_Friday.Text = "Half PM"
        Me.rbHalf_PM_Friday.UseVisualStyleBackColor = True
        '
        'rbHalf_AM_Friday
        '
        Me.rbHalf_AM_Friday.AutoSize = True
        Me.rbHalf_AM_Friday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbHalf_AM_Friday.Location = New System.Drawing.Point(16, 42)
        Me.rbHalf_AM_Friday.Name = "rbHalf_AM_Friday"
        Me.rbHalf_AM_Friday.Size = New System.Drawing.Size(84, 24)
        Me.rbHalf_AM_Friday.TabIndex = 14
        Me.rbHalf_AM_Friday.TabStop = True
        Me.rbHalf_AM_Friday.Text = "Half AM"
        Me.rbHalf_AM_Friday.UseVisualStyleBackColor = True
        '
        'rbFull_Day_Friday
        '
        Me.rbFull_Day_Friday.AutoSize = True
        Me.rbFull_Day_Friday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbFull_Day_Friday.Location = New System.Drawing.Point(16, 19)
        Me.rbFull_Day_Friday.Name = "rbFull_Day_Friday"
        Me.rbFull_Day_Friday.Size = New System.Drawing.Size(84, 24)
        Me.rbFull_Day_Friday.TabIndex = 13
        Me.rbFull_Day_Friday.TabStop = True
        Me.rbFull_Day_Friday.Text = "Full Day"
        Me.rbFull_Day_Friday.UseVisualStyleBackColor = True
        '
        'clpAccept
        '
        Me.clpAccept.Image = CType(resources.GetObject("clpAccept.Image"), System.Drawing.Image)
        Me.clpAccept.Location = New System.Drawing.Point(318, 427)
        Me.clpAccept.Name = "clpAccept"
        Me.clpAccept.Size = New System.Drawing.Size(76, 76)
        Me.clpAccept.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpAccept.TabIndex = 7
        Me.clpAccept.TabStop = False
        '
        'clpCancel
        '
        Me.clpCancel.Image = CType(resources.GetObject("clpCancel.Image"), System.Drawing.Image)
        Me.clpCancel.Location = New System.Drawing.Point(431, 427)
        Me.clpCancel.Name = "clpCancel"
        Me.clpCancel.Size = New System.Drawing.Size(76, 76)
        Me.clpCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.clpCancel.TabIndex = 8
        Me.clpCancel.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.ForestGreen
        Me.Label7.Location = New System.Drawing.Point(66, 504)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Required Field"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.ForestGreen
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(49, 500)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.ForestGreen
        Me.Label6.Location = New System.Drawing.Point(333, 504)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Accept"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.ForestGreen
        Me.Label10.Location = New System.Drawing.Point(452, 504)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Cancel"
        '
        'Add_New_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Book_.My.Resources.Resources.Green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(822, 572)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.clpCancel)
        Me.Controls.Add(Me.clpAccept)
        Me.Controls.Add(Me.grpFriday)
        Me.Controls.Add(Me.grpThursday)
        Me.Controls.Add(Me.grpWednesday)
        Me.Controls.Add(Me.Tuesday)
        Me.Controls.Add(Me.grpMonday)
        Me.Controls.Add(Me.grpAutoAssigned)
        Me.Controls.Add(Me.grpDates)
        Me.Controls.Add(Me.Classrooms)
        Me.Controls.Add(Me.grpNames)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Add_New_Screen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Child"
        Me.grpNames.ResumeLayout(False)
        Me.grpNames.PerformLayout()
        Me.Classrooms.ResumeLayout(False)
        Me.Classrooms.PerformLayout()
        Me.grpDates.ResumeLayout(False)
        Me.grpDates.PerformLayout()
        Me.grpAutoAssigned.ResumeLayout(False)
        Me.grpAutoAssigned.PerformLayout()
        Me.grpMonday.ResumeLayout(False)
        Me.grpMonday.PerformLayout()
        Me.Tuesday.ResumeLayout(False)
        Me.Tuesday.PerformLayout()
        Me.grpWednesday.ResumeLayout(False)
        Me.grpWednesday.PerformLayout()
        Me.grpThursday.ResumeLayout(False)
        Me.grpThursday.PerformLayout()
        Me.grpFriday.ResumeLayout(False)
        Me.grpFriday.PerformLayout()
        CType(Me.clpAccept, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clpCancel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpNames As System.Windows.Forms.GroupBox
    Friend WithEvents Classrooms As System.Windows.Forms.GroupBox
    Friend WithEvents grpDates As System.Windows.Forms.GroupBox
    Friend WithEvents grpAutoAssigned As System.Windows.Forms.GroupBox
    Friend WithEvents grpMonday As System.Windows.Forms.GroupBox
    Friend WithEvents Tuesday As System.Windows.Forms.GroupBox
    Friend WithEvents grpWednesday As System.Windows.Forms.GroupBox
    Friend WithEvents grpThursday As System.Windows.Forms.GroupBox
    Friend WithEvents grpFriday As System.Windows.Forms.GroupBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtBirthday As System.Windows.Forms.TextBox
    Friend WithEvents cboCurrentClassroom As System.Windows.Forms.ComboBox
    Friend WithEvents txtUniqueIdentifier As System.Windows.Forms.TextBox
    Friend WithEvents rbFull_Day_Monday As System.Windows.Forms.RadioButton
    Friend WithEvents rbFull_Day_Tuesday As System.Windows.Forms.RadioButton
    Friend WithEvents rbFull_Day_Wednesday As System.Windows.Forms.RadioButton
    Friend WithEvents rbFull_Day_Thursday As System.Windows.Forms.RadioButton
    Friend WithEvents rbFull_Day_Friday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_AM_Monday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_AM_Tuesday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_AM_Wednesday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_AM_Thursday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_AM_Friday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_PM_Monday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_PM_Tuesday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_PM_Wednesday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_PM_Thursday As System.Windows.Forms.RadioButton
    Friend WithEvents rbHalf_PM_Friday As System.Windows.Forms.RadioButton
    Friend WithEvents rbAbsent_Monday As System.Windows.Forms.RadioButton
    Friend WithEvents rbAbsent_Tuesday As System.Windows.Forms.RadioButton
    Friend WithEvents rbAbsent_Wednesday As System.Windows.Forms.RadioButton
    Friend WithEvents rbAbsent_Thursday As System.Windows.Forms.RadioButton
    Friend WithEvents rbAbsent_Friday As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents clpAccept As System.Windows.Forms.PictureBox
    Friend WithEvents clpCancel As System.Windows.Forms.PictureBox
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
