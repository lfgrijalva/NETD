<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lab3Form
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
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lbOutput4 = New System.Windows.Forms.Label()
        Me.lbOutput3 = New System.Windows.Forms.Label()
        Me.lbOutput2 = New System.Windows.Forms.Label()
        Me.lbOutput1 = New System.Windows.Forms.Label()
        Me.lbEmployee3 = New System.Windows.Forms.Label()
        Me.lbEmployee2 = New System.Windows.Forms.Label()
        Me.lbEmployee1 = New System.Windows.Forms.Label()
        Me.tbUnits = New System.Windows.Forms.TextBox()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.tbEmployee3 = New System.Windows.Forms.TextBox()
        Me.tbEmployee2 = New System.Windows.Forms.TextBox()
        Me.tbEmployee1 = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(321, 387)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(119, 35)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Close the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(173, 387)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(119, 35)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Reset and clear the form to allow the calculation for a fresh week")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(28, 387)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(119, 35)
        Me.btnEnter.TabIndex = 13
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Enter the amount of units shipped and proceed to the next day. If the current day" &
        " is the seventh, continue to the next employee")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lbOutput4
        '
        Me.lbOutput4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput4.Location = New System.Drawing.Point(28, 344)
        Me.lbOutput4.Name = "lbOutput4"
        Me.lbOutput4.Size = New System.Drawing.Size(412, 31)
        Me.lbOutput4.TabIndex = 12
        Me.lbOutput4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbOutput4, "Once entered, the total average units shipped will be displayed here")
        '
        'lbOutput3
        '
        Me.lbOutput3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput3.Location = New System.Drawing.Point(321, 302)
        Me.lbOutput3.Name = "lbOutput3"
        Me.lbOutput3.Size = New System.Drawing.Size(119, 31)
        Me.lbOutput3.TabIndex = 11
        Me.lbOutput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbOutput3, "Once entered, the average units shipped for employee 3 will be displayed here")
        '
        'lbOutput2
        '
        Me.lbOutput2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput2.Location = New System.Drawing.Point(173, 302)
        Me.lbOutput2.Name = "lbOutput2"
        Me.lbOutput2.Size = New System.Drawing.Size(119, 31)
        Me.lbOutput2.TabIndex = 10
        Me.lbOutput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbOutput2, "Once entered, the average units shipped for employee 2 will be displayed here")
        '
        'lbOutput1
        '
        Me.lbOutput1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput1.Location = New System.Drawing.Point(28, 302)
        Me.lbOutput1.Name = "lbOutput1"
        Me.lbOutput1.Size = New System.Drawing.Size(119, 31)
        Me.lbOutput1.TabIndex = 9
        Me.lbOutput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.lbOutput1, "Once entered, the average units shipped for employee 1 will be displayed here")
        '
        'lbEmployee3
        '
        Me.lbEmployee3.Location = New System.Drawing.Point(345, 89)
        Me.lbEmployee3.Name = "lbEmployee3"
        Me.lbEmployee3.Size = New System.Drawing.Size(62, 13)
        Me.lbEmployee3.TabIndex = 7
        Me.lbEmployee3.Text = "Employee &3"
        Me.lbEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployee2
        '
        Me.lbEmployee2.Location = New System.Drawing.Point(199, 89)
        Me.lbEmployee2.Name = "lbEmployee2"
        Me.lbEmployee2.Size = New System.Drawing.Size(62, 13)
        Me.lbEmployee2.TabIndex = 5
        Me.lbEmployee2.Text = "Employee &2"
        Me.lbEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployee1
        '
        Me.lbEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmployee1.Location = New System.Drawing.Point(54, 89)
        Me.lbEmployee1.Name = "lbEmployee1"
        Me.lbEmployee1.Size = New System.Drawing.Size(72, 13)
        Me.lbEmployee1.TabIndex = 3
        Me.lbEmployee1.Text = "Employee &1"
        Me.lbEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbUnits
        '
        Me.tbUnits.Location = New System.Drawing.Point(68, 42)
        Me.tbUnits.Name = "tbUnits"
        Me.tbUnits.Size = New System.Drawing.Size(62, 20)
        Me.tbUnits.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbUnits, "Insert the units shipped on the current day for the current employee")
        '
        'lbUnits
        '
        Me.lbUnits.Location = New System.Drawing.Point(28, 45)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(34, 13)
        Me.lbUnits.TabIndex = 1
        Me.lbUnits.Text = "&Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbDay
        '
        Me.lbDay.Location = New System.Drawing.Point(25, 12)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(35, 13)
        Me.lbDay.TabIndex = 0
        Me.lbDay.Text = "Day 1"
        '
        'tbEmployee3
        '
        Me.tbEmployee3.Location = New System.Drawing.Point(321, 114)
        Me.tbEmployee3.Multiline = True
        Me.tbEmployee3.Name = "tbEmployee3"
        Me.tbEmployee3.ReadOnly = True
        Me.tbEmployee3.Size = New System.Drawing.Size(119, 162)
        Me.tbEmployee3.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.tbEmployee3, "The units shipped per day for employee 3 will be displayed here")
        '
        'tbEmployee2
        '
        Me.tbEmployee2.Location = New System.Drawing.Point(173, 114)
        Me.tbEmployee2.Multiline = True
        Me.tbEmployee2.Name = "tbEmployee2"
        Me.tbEmployee2.ReadOnly = True
        Me.tbEmployee2.Size = New System.Drawing.Size(119, 162)
        Me.tbEmployee2.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.tbEmployee2, "The units shipped per day for employee 2 will be displayed here")
        '
        'tbEmployee1
        '
        Me.tbEmployee1.Location = New System.Drawing.Point(28, 114)
        Me.tbEmployee1.Multiline = True
        Me.tbEmployee1.Name = "tbEmployee1"
        Me.tbEmployee1.ReadOnly = True
        Me.tbEmployee1.Size = New System.Drawing.Size(119, 162)
        Me.tbEmployee1.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.tbEmployee1, "The units shipped per day for employee 1 will be displayed here")
        '
        'lab3Form
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(468, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbOutput4)
        Me.Controls.Add(Me.lbOutput3)
        Me.Controls.Add(Me.lbOutput2)
        Me.Controls.Add(Me.lbOutput1)
        Me.Controls.Add(Me.lbEmployee3)
        Me.Controls.Add(Me.lbEmployee2)
        Me.Controls.Add(Me.lbEmployee1)
        Me.Controls.Add(Me.tbUnits)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.lbDay)
        Me.Controls.Add(Me.tbEmployee3)
        Me.Controls.Add(Me.tbEmployee2)
        Me.Controls.Add(Me.tbEmployee1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "lab3Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents btnExit As Button
    Private WithEvents btnReset As Button
    Private WithEvents btnEnter As Button
    Private WithEvents lbOutput4 As Label
    Private WithEvents lbOutput3 As Label
    Private WithEvents lbOutput2 As Label
    Private WithEvents lbOutput1 As Label
    Private WithEvents lbEmployee3 As Label
    Private WithEvents lbEmployee2 As Label
    Private WithEvents lbEmployee1 As Label
    Private WithEvents tbUnits As TextBox
    Private WithEvents lbUnits As Label
    Private WithEvents lbDay As Label
    Private WithEvents tbEmployee3 As TextBox
    Private WithEvents tbEmployee2 As TextBox
    Private WithEvents tbEmployee1 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
