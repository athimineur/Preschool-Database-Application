<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.btnRecords = New System.Windows.Forms.Button()
        Me.btnClassrooms = New System.Windows.Forms.Button()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRecords
        '
        Me.btnRecords.BackColor = System.Drawing.Color.Transparent
        Me.btnRecords.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecords.Location = New System.Drawing.Point(24, 60)
        Me.btnRecords.Name = "btnRecords"
        Me.btnRecords.Size = New System.Drawing.Size(286, 61)
        Me.btnRecords.TabIndex = 0
        Me.btnRecords.Text = "Records"
        Me.btnRecords.UseVisualStyleBackColor = False
        '
        'btnClassrooms
        '
        Me.btnClassrooms.BackColor = System.Drawing.Color.Transparent
        Me.btnClassrooms.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassrooms.Location = New System.Drawing.Point(24, 153)
        Me.btnClassrooms.Name = "btnClassrooms"
        Me.btnClassrooms.Size = New System.Drawing.Size(286, 61)
        Me.btnClassrooms.TabIndex = 2
        Me.btnClassrooms.Text = "Classrooms"
        Me.btnClassrooms.UseVisualStyleBackColor = False
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(334, 24)
        Me.mnuStrip.TabIndex = 3
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(52, 20)
        Me.mnuAbout.Text = "About"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Book_.My.Resources.Resources.Green
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(334, 274)
        Me.Controls.Add(Me.btnClassrooms)
        Me.Controls.Add(Me.btnRecords)
        Me.Controls.Add(Me.mnuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuStrip
        Me.MaximizeBox = False
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRecords As System.Windows.Forms.Button
    Friend WithEvents btnClassrooms As System.Windows.Forms.Button
    Friend WithEvents mnuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
End Class
