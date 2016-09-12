<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Projection_GridMode
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
        Me.dgvProjection = New System.Windows.Forms.DataGridView()
        Me.colChild = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFlag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAge = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMonday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTuesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colWednesday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colThursday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFriday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMonthYear = New System.Windows.Forms.Label()
        Me.btnUpClass = New System.Windows.Forms.Button()
        Me.btnNextMonth = New System.Windows.Forms.Button()
        Me.btnDownClass = New System.Windows.Forms.Button()
        Me.btnPreviousMonth = New System.Windows.Forms.Button()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.btnTogglePrediction = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPrediction = New System.Windows.Forms.Label()
        Me.lstUnique = New System.Windows.Forms.ListBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        CType(Me.dgvProjection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvProjection
        '
        Me.dgvProjection.AllowUserToAddRows = False
        Me.dgvProjection.AllowUserToDeleteRows = False
        Me.dgvProjection.AllowUserToResizeColumns = False
        Me.dgvProjection.AllowUserToResizeRows = False
        Me.dgvProjection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProjection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProjection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colChild, Me.colFlag, Me.colDOB, Me.colAge, Me.colMonday, Me.colTuesday, Me.colWednesday, Me.colThursday, Me.colFriday})
        Me.dgvProjection.Location = New System.Drawing.Point(88, 173)
        Me.dgvProjection.MultiSelect = False
        Me.dgvProjection.Name = "dgvProjection"
        Me.dgvProjection.ReadOnly = True
        Me.dgvProjection.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvProjection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvProjection.Size = New System.Drawing.Size(1089, 394)
        Me.dgvProjection.TabIndex = 0
        '
        'colChild
        '
        Me.colChild.HeaderText = "Child"
        Me.colChild.Name = "colChild"
        Me.colChild.ReadOnly = True
        Me.colChild.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colFlag
        '
        Me.colFlag.HeaderText = "Flag?"
        Me.colFlag.Name = "colFlag"
        Me.colFlag.ReadOnly = True
        Me.colFlag.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDOB
        '
        Me.colDOB.HeaderText = "DOB"
        Me.colDOB.Name = "colDOB"
        Me.colDOB.ReadOnly = True
        Me.colDOB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colAge
        '
        Me.colAge.HeaderText = "Age"
        Me.colAge.Name = "colAge"
        Me.colAge.ReadOnly = True
        Me.colAge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colMonday
        '
        Me.colMonday.HeaderText = "Monday"
        Me.colMonday.Name = "colMonday"
        Me.colMonday.ReadOnly = True
        Me.colMonday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTuesday
        '
        Me.colTuesday.HeaderText = "Tuesday"
        Me.colTuesday.Name = "colTuesday"
        Me.colTuesday.ReadOnly = True
        Me.colTuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colWednesday
        '
        Me.colWednesday.HeaderText = "Wednesday"
        Me.colWednesday.Name = "colWednesday"
        Me.colWednesday.ReadOnly = True
        Me.colWednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colThursday
        '
        Me.colThursday.HeaderText = "Thursday"
        Me.colThursday.Name = "colThursday"
        Me.colThursday.ReadOnly = True
        Me.colThursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colFriday
        '
        Me.colFriday.HeaderText = "Friday"
        Me.colFriday.Name = "colFriday"
        Me.colFriday.ReadOnly = True
        Me.colFriday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lblMonthYear
        '
        Me.lblMonthYear.AutoSize = True
        Me.lblMonthYear.BackColor = System.Drawing.Color.Transparent
        Me.lblMonthYear.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthYear.Location = New System.Drawing.Point(960, 2)
        Me.lblMonthYear.Name = "lblMonthYear"
        Me.lblMonthYear.Size = New System.Drawing.Size(0, 45)
        Me.lblMonthYear.TabIndex = 22
        '
        'btnUpClass
        '
        Me.btnUpClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpClass.Location = New System.Drawing.Point(591, 9)
        Me.btnUpClass.Name = "btnUpClass"
        Me.btnUpClass.Size = New System.Drawing.Size(82, 38)
        Me.btnUpClass.TabIndex = 23
        Me.btnUpClass.Text = "▲"
        Me.btnUpClass.UseVisualStyleBackColor = True
        '
        'btnNextMonth
        '
        Me.btnNextMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextMonth.Location = New System.Drawing.Point(1209, 295)
        Me.btnNextMonth.Name = "btnNextMonth"
        Me.btnNextMonth.Size = New System.Drawing.Size(44, 69)
        Me.btnNextMonth.TabIndex = 24
        Me.btnNextMonth.Text = "►"
        Me.btnNextMonth.UseVisualStyleBackColor = True
        '
        'btnDownClass
        '
        Me.btnDownClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDownClass.Location = New System.Drawing.Point(591, 608)
        Me.btnDownClass.Name = "btnDownClass"
        Me.btnDownClass.Size = New System.Drawing.Size(82, 38)
        Me.btnDownClass.TabIndex = 25
        Me.btnDownClass.Text = "▼"
        Me.btnDownClass.UseVisualStyleBackColor = True
        '
        'btnPreviousMonth
        '
        Me.btnPreviousMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreviousMonth.Location = New System.Drawing.Point(12, 295)
        Me.btnPreviousMonth.Name = "btnPreviousMonth"
        Me.btnPreviousMonth.Size = New System.Drawing.Size(44, 69)
        Me.btnPreviousMonth.TabIndex = 26
        Me.btnPreviousMonth.Text = "◄"
        Me.btnPreviousMonth.UseVisualStyleBackColor = True
        '
        'lblClass
        '
        Me.lblClass.AutoSize = True
        Me.lblClass.BackColor = System.Drawing.Color.Transparent
        Me.lblClass.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClass.Location = New System.Drawing.Point(524, 72)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(0, 45)
        Me.lblClass.TabIndex = 28
        '
        'btnTogglePrediction
        '
        Me.btnTogglePrediction.Location = New System.Drawing.Point(11, 51)
        Me.btnTogglePrediction.Name = "btnTogglePrediction"
        Me.btnTogglePrediction.Size = New System.Drawing.Size(105, 23)
        Me.btnTogglePrediction.TabIndex = 29
        Me.btnTogglePrediction.Text = "Turn Prediction On"
        Me.btnTogglePrediction.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblPrediction)
        Me.GroupBox1.Controls.Add(Me.btnTogglePrediction)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(127, 88)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prediction"
        '
        'lblPrediction
        '
        Me.lblPrediction.AutoSize = True
        Me.lblPrediction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrediction.Location = New System.Drawing.Point(15, 22)
        Me.lblPrediction.Name = "lblPrediction"
        Me.lblPrediction.Size = New System.Drawing.Size(97, 16)
        Me.lblPrediction.TabIndex = 33
        Me.lblPrediction.Text = "Prediction = Off"
        '
        'lstUnique
        '
        Me.lstUnique.FormattingEnabled = True
        Me.lstUnique.Location = New System.Drawing.Point(171, 22)
        Me.lstUnique.Name = "lstUnique"
        Me.lstUnique.Size = New System.Drawing.Size(120, 95)
        Me.lstUnique.TabIndex = 34
        Me.lstUnique.Visible = False
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(1178, 614)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 35)
        Me.btnMainMenu.TabIndex = 35
        Me.btnMainMenu.Text = "Return to Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'Projection_GridMode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LimeGreen
        Me.BackgroundImage = Global.The_Book_.My.Resources.Resources.Green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1265, 658)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lstUnique)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.btnPreviousMonth)
        Me.Controls.Add(Me.btnDownClass)
        Me.Controls.Add(Me.btnNextMonth)
        Me.Controls.Add(Me.btnUpClass)
        Me.Controls.Add(Me.lblMonthYear)
        Me.Controls.Add(Me.dgvProjection)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Projection_GridMode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Book!"
        CType(Me.dgvProjection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents dgvProjection As System.Windows.Forms.DataGridView
    Friend WithEvents lblMonthYear As System.Windows.Forms.Label
    Friend WithEvents btnUpClass As System.Windows.Forms.Button
    Friend WithEvents btnNextMonth As System.Windows.Forms.Button
    Friend WithEvents btnDownClass As System.Windows.Forms.Button
    Friend WithEvents btnPreviousMonth As System.Windows.Forms.Button
    Friend WithEvents lblClass As System.Windows.Forms.Label
    Friend WithEvents colChild As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFlag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDOB As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAge As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMonday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTuesday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWednesday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colThursday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFriday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnTogglePrediction As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPrediction As System.Windows.Forms.Label
    Friend WithEvents lstUnique As System.Windows.Forms.ListBox
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
End Class
