﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.lbMake = New System.Windows.Forms.Label()
        Me.lbModel = New System.Windows.Forms.Label()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lvwInventory = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CarToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbResult = New System.Windows.Forms.Label()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(95, 451)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.CarToolTip.SetToolTip(Me.btnEnter, "Click to add a customer.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(176, 451)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.CarToolTip.SetToolTip(Me.btnReset, "Click to reset the screen.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(257, 451)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.CarToolTip.SetToolTip(Me.btnExit, "Click to exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(84, 34)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(121, 20)
        Me.tbModel.TabIndex = 3
        Me.CarToolTip.SetToolTip(Me.tbModel, "Type the car's model here.")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Honda", "KIA", "Toyota", "BMW", "Ford", "Dodge"})
        Me.cmbMake.Location = New System.Drawing.Point(84, 7)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 21)
        Me.cmbMake.TabIndex = 1
        Me.CarToolTip.SetToolTip(Me.cmbMake, "Select the car's manufacturer.")
        '
        'lbMake
        '
        Me.lbMake.Location = New System.Drawing.Point(12, 7)
        Me.lbMake.Name = "lbMake"
        Me.lbMake.Size = New System.Drawing.Size(66, 13)
        Me.lbMake.TabIndex = 0
        Me.lbMake.Text = "&Make:"
        Me.lbMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbModel
        '
        Me.lbModel.Location = New System.Drawing.Point(12, 34)
        Me.lbModel.Name = "lbModel"
        Me.lbModel.Size = New System.Drawing.Size(66, 13)
        Me.lbModel.TabIndex = 2
        Me.lbModel.Text = "M&odel:"
        Me.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbModel.UseWaitCursor = True
        '
        'lbYear
        '
        Me.lbYear.Location = New System.Drawing.Point(12, 63)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(66, 13)
        Me.lbYear.TabIndex = 4
        Me.lbYear.Text = "&Year:"
        Me.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(15, 112)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(80, 24)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarToolTip.SetToolTip(Me.chkNew, "Check to identify if the car is new.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lvwInventory
        '
        Me.lvwInventory.CheckBoxes = True
        Me.lvwInventory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwInventory.FullRowSelect = True
        Me.lvwInventory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwInventory.Location = New System.Drawing.Point(2, 137)
        Me.lvwInventory.MultiSelect = False
        Me.lvwInventory.Name = "lvwInventory"
        Me.lvwInventory.Size = New System.Drawing.Size(400, 246)
        Me.lvwInventory.TabIndex = 9
        Me.CarToolTip.SetToolTip(Me.lvwInventory, "Display the inventory of cars available.")
        Me.lvwInventory.UseCompatibleStateImageBehavior = False
        Me.lvwInventory.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        '
        'colID
        '
        Me.colID.Text = "ID"
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 93
        '
        'lbResult
        '
        Me.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbResult.Location = New System.Drawing.Point(2, 386)
        Me.lbResult.Name = "lbResult"
        Me.lbResult.Size = New System.Drawing.Size(400, 60)
        Me.lbResult.TabIndex = 10
        Me.CarToolTip.SetToolTip(Me.lbResult, "Success or Error message will appear here.")
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(84, 86)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(121, 20)
        Me.tbPrice.TabIndex = 7
        Me.CarToolTip.SetToolTip(Me.tbPrice, "Type the car's price here.")
        '
        'lbPrice
        '
        Me.lbPrice.Location = New System.Drawing.Point(12, 89)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(66, 13)
        Me.lbPrice.TabIndex = 6
        Me.lbPrice.Text = "&Price:"
        Me.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.ItemHeight = 13
        Me.cmbYear.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019"})
        Me.cmbYear.Location = New System.Drawing.Point(84, 60)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 21)
        Me.cmbYear.TabIndex = 14
        Me.CarToolTip.SetToolTip(Me.cmbYear, "Select the year of fabrication.")
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(403, 520)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.lbResult)
        Me.Controls.Add(Me.lvwInventory)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.lbModel)
        Me.Controls.Add(Me.lbMake)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents tbModel As TextBox
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents lbMake As Label
    Friend WithEvents lbModel As Label
    Friend WithEvents lbYear As Label
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lvwInventory As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYear As ColumnHeader
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents CarToolTip As ToolTip
    Friend WithEvents lbResult As Label
    Friend WithEvents lbPrice As Label
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents cmbYear As ComboBox
End Class
