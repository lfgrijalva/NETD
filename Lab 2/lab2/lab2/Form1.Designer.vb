<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lab2Form
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
        Me.tbCourse1 = New System.Windows.Forms.TextBox()
        Me.tbCourse2 = New System.Windows.Forms.TextBox()
        Me.tbCourse3 = New System.Windows.Forms.TextBox()
        Me.tbCourse4 = New System.Windows.Forms.TextBox()
        Me.tbCourse5 = New System.Windows.Forms.TextBox()
        Me.tbCourse6 = New System.Windows.Forms.TextBox()
        Me.lbC1 = New System.Windows.Forms.Label()
        Me.lbC2 = New System.Windows.Forms.Label()
        Me.lbC3 = New System.Windows.Forms.Label()
        Me.lbC4 = New System.Windows.Forms.Label()
        Me.lbC5 = New System.Windows.Forms.Label()
        Me.lbC6 = New System.Windows.Forms.Label()
        Me.lbCourse1 = New System.Windows.Forms.Label()
        Me.tbOutput = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lbCourse2 = New System.Windows.Forms.Label()
        Me.lbCourse6 = New System.Windows.Forms.Label()
        Me.lbCourse3 = New System.Windows.Forms.Label()
        Me.lbCourse4 = New System.Windows.Forms.Label()
        Me.lbCourse5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbSemesterGrade = New System.Windows.Forms.Label()
        Me.lbSemester = New System.Windows.Forms.Label()
        Me.lbSemesterOutput = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCourse1
        '
        Me.tbCourse1.Location = New System.Drawing.Point(130, 3)
        Me.tbCourse1.Name = "tbCourse1"
        Me.tbCourse1.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse1.TabIndex = 0
        Me.tbCourse1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse1, "Insert here your grade for course 1")
        '
        'tbCourse2
        '
        Me.tbCourse2.Location = New System.Drawing.Point(130, 29)
        Me.tbCourse2.Name = "tbCourse2"
        Me.tbCourse2.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse2.TabIndex = 1
        Me.tbCourse2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse2, "Insert here your grade for course 2")
        '
        'tbCourse3
        '
        Me.tbCourse3.Location = New System.Drawing.Point(130, 55)
        Me.tbCourse3.Name = "tbCourse3"
        Me.tbCourse3.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse3.TabIndex = 2
        Me.tbCourse3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse3, "Insert here your grade for course 3")
        '
        'tbCourse4
        '
        Me.tbCourse4.Location = New System.Drawing.Point(130, 81)
        Me.tbCourse4.Name = "tbCourse4"
        Me.tbCourse4.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse4.TabIndex = 3
        Me.tbCourse4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse4, "Insert here your grade for course 4")
        '
        'tbCourse5
        '
        Me.tbCourse5.Location = New System.Drawing.Point(130, 107)
        Me.tbCourse5.Name = "tbCourse5"
        Me.tbCourse5.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse5.TabIndex = 4
        Me.tbCourse5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse5, "Insert here your grade for course 5")
        '
        'tbCourse6
        '
        Me.tbCourse6.Location = New System.Drawing.Point(130, 133)
        Me.tbCourse6.Name = "tbCourse6"
        Me.tbCourse6.Size = New System.Drawing.Size(100, 20)
        Me.tbCourse6.TabIndex = 5
        Me.tbCourse6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbCourse6, "Insert here your grade for course 6")
        '
        'lbC1
        '
        Me.lbC1.Location = New System.Drawing.Point(3, 0)
        Me.lbC1.Name = "lbC1"
        Me.lbC1.Size = New System.Drawing.Size(49, 13)
        Me.lbC1.TabIndex = 0
        Me.lbC1.Text = "Course &1"
        Me.lbC1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbC2
        '
        Me.lbC2.Location = New System.Drawing.Point(3, 26)
        Me.lbC2.Name = "lbC2"
        Me.lbC2.Size = New System.Drawing.Size(49, 13)
        Me.lbC2.TabIndex = 1
        Me.lbC2.Text = "Course &2"
        Me.lbC2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbC3
        '
        Me.lbC3.Location = New System.Drawing.Point(3, 52)
        Me.lbC3.Name = "lbC3"
        Me.lbC3.Size = New System.Drawing.Size(49, 13)
        Me.lbC3.TabIndex = 2
        Me.lbC3.Text = "Course &3"
        Me.lbC3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbC4
        '
        Me.lbC4.Location = New System.Drawing.Point(3, 78)
        Me.lbC4.Name = "lbC4"
        Me.lbC4.Size = New System.Drawing.Size(49, 13)
        Me.lbC4.TabIndex = 3
        Me.lbC4.Text = "Course &4"
        Me.lbC4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbC5
        '
        Me.lbC5.Location = New System.Drawing.Point(3, 104)
        Me.lbC5.Name = "lbC5"
        Me.lbC5.Size = New System.Drawing.Size(49, 13)
        Me.lbC5.TabIndex = 4
        Me.lbC5.Text = "Course &5"
        Me.lbC5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbC6
        '
        Me.lbC6.Location = New System.Drawing.Point(3, 130)
        Me.lbC6.Name = "lbC6"
        Me.lbC6.Size = New System.Drawing.Size(49, 13)
        Me.lbC6.TabIndex = 5
        Me.lbC6.Text = "Course &6"
        Me.lbC6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbCourse1
        '
        Me.lbCourse1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse1.Location = New System.Drawing.Point(356, 0)
        Me.lbCourse1.Name = "lbCourse1"
        Me.lbCourse1.Size = New System.Drawing.Size(74, 19)
        Me.lbCourse1.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.lbCourse1, "Your grade for course 1 will be displayed here")
        '
        'tbOutput
        '
        Me.tbOutput.Location = New System.Drawing.Point(130, 182)
        Me.tbOutput.Multiline = True
        Me.tbOutput.Name = "tbOutput"
        Me.tbOutput.ReadOnly = True
        Me.tbOutput.Size = New System.Drawing.Size(220, 308)
        Me.tbOutput.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.tbOutput, "Errors will be displayed here")
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(3, 496)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "&Calculate"
        Me.ToolTip1.SetToolTip(Me.btnCalculate, "Calculate the average semester grade")
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(130, 496)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Reset the form to enter new data")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(356, 496)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exit the application")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lbCourse2
        '
        Me.lbCourse2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse2.Location = New System.Drawing.Point(356, 26)
        Me.lbCourse2.Name = "lbCourse2"
        Me.lbCourse2.Size = New System.Drawing.Size(74, 19)
        Me.lbCourse2.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.lbCourse2, "Your grade for course 2 will be displayed here")
        '
        'lbCourse6
        '
        Me.lbCourse6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse6.Location = New System.Drawing.Point(356, 130)
        Me.lbCourse6.Name = "lbCourse6"
        Me.lbCourse6.Size = New System.Drawing.Size(74, 19)
        Me.lbCourse6.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.lbCourse6, "Your grade for course 6 will be displayed here")
        '
        'lbCourse3
        '
        Me.lbCourse3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse3.Location = New System.Drawing.Point(356, 52)
        Me.lbCourse3.Name = "lbCourse3"
        Me.lbCourse3.Size = New System.Drawing.Size(74, 19)
        Me.lbCourse3.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.lbCourse3, "Your grade for course 3 will be displayed here")
        '
        'lbCourse4
        '
        Me.lbCourse4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse4.Location = New System.Drawing.Point(356, 78)
        Me.lbCourse4.Name = "lbCourse4"
        Me.lbCourse4.Size = New System.Drawing.Size(74, 19)
        Me.lbCourse4.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.lbCourse4, "Your grade for course 4 will be displayed here")
        '
        'lbCourse5
        '
        Me.lbCourse5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbCourse5.Location = New System.Drawing.Point(356, 104)
        Me.lbCourse5.Name = "lbCourse5"
        Me.lbCourse5.Size = New System.Drawing.Size(74, 19)
        Me.lbCourse5.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.lbCourse5, "Your grade for course 5 will be displayed here")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.93221!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.06779!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbSemesterGrade, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExit, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lbC1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReset, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCalculate, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lbCourse5, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbC2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbCourse4, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbC3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbCourse3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbC4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbC5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbCourse2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbC6, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCourse1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCourse2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCourse3, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCourse4, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbCourse1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCourse5, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbCourse6, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSemester, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.lbSemesterOutput, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.tbOutput, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lbCourse6, 2, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(453, 543)
        Me.TableLayoutPanel1.TabIndex = 27
        '
        'lbSemesterGrade
        '
        Me.lbSemesterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterGrade.Location = New System.Drawing.Point(356, 156)
        Me.lbSemesterGrade.Name = "lbSemesterGrade"
        Me.lbSemesterGrade.Size = New System.Drawing.Size(74, 23)
        Me.lbSemesterGrade.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.lbSemesterGrade, "When calculated, your semester average grade will be displayed here")
        '
        'lbSemester
        '
        Me.lbSemester.Location = New System.Drawing.Point(3, 156)
        Me.lbSemester.Name = "lbSemester"
        Me.lbSemester.Size = New System.Drawing.Size(51, 13)
        Me.lbSemester.TabIndex = 6
        Me.lbSemester.Text = "&Semester"
        Me.lbSemester.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbSemesterOutput
        '
        Me.lbSemesterOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSemesterOutput.Location = New System.Drawing.Point(130, 156)
        Me.lbSemesterOutput.Name = "lbSemesterOutput"
        Me.lbSemesterOutput.Size = New System.Drawing.Size(100, 23)
        Me.lbSemesterOutput.TabIndex = 6
        Me.lbSemesterOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.lbSemesterOutput, "When calculated, your semester average will be displayed here")
        '
        'lab2Form
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(453, 543)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "lab2Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semester Grades"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbCourse1 As TextBox
    Friend WithEvents tbCourse2 As TextBox
    Friend WithEvents tbCourse3 As TextBox
    Friend WithEvents tbCourse4 As TextBox
    Friend WithEvents tbCourse5 As TextBox
    Friend WithEvents tbCourse6 As TextBox
    Friend WithEvents lbC1 As Label
    Friend WithEvents lbC2 As Label
    Friend WithEvents lbC3 As Label
    Friend WithEvents lbC4 As Label
    Friend WithEvents lbC5 As Label
    Friend WithEvents lbC6 As Label
    Friend WithEvents lbCourse1 As Label
    Friend WithEvents tbOutput As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lbCourse2 As Label
    Friend WithEvents lbCourse6 As Label
    Friend WithEvents lbCourse3 As Label
    Friend WithEvents lbCourse4 As Label
    Friend WithEvents lbCourse5 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbSemesterGrade As Label
    Friend WithEvents lbSemester As Label
    Friend WithEvents lbSemesterOutput As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
