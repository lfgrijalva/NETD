Option Strict On
Imports System.IO

Public Class frmTextEditor
    Dim currentFile As String = ""
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Text = "Opening"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Try
                Dim reader As New StreamReader(OpenFileDialog1.FileName)
                tbFile.Text() = reader.ReadToEnd()
                reader.Close()
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
        currentFile = OpenFileDialog1.FileName
        Me.Text = currentFile
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Save(currentFile)
    End Sub


    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Dim text As String = tbFile.SelectedText
        Copy(text)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        Dim text As String = tbFile.SelectedText
        Cut(text)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        Dim text As String = tbFile.SelectedText
        Paste()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("NETD - 2202" & vbCrLf & "Lab #5" & vbCrLf & "Luis Grijalva 100719475")
    End Sub
    Public Sub Copy(text As String)
        If (Not text = "") Then
            My.Computer.Clipboard.SetText(text)
        End If

    End Sub
    Public Sub Paste()
        tbFile.Text += My.Computer.Clipboard.GetText()
    End Sub
    Public Sub Cut(text As String)
        tbFile.SelectedText = ""
        If (Not text = "") Then
            My.Computer.Clipboard.SetText(text)
        End If

    End Sub
    Public Sub Save(ByRef currentFile As String)
        Me.Text = "Saving"
        SaveFileDialog1.Filter = "TXT Files (.txt)|*.txt"
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, tbFile.Text(), False)
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If
        currentFile = SaveFileDialog1.FileName
        Me.Text = currentFile
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        If currentFile = "" Then
            Save(currentFile)
        Else
            Try
                My.Computer.FileSystem.WriteAllText(currentFile, tbFile.Text(), False)
            Catch ex As Exception
                Console.WriteLine(ex.ToString())
            End Try
        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        Try
            If (Not currentFile = "") Then
                Dim temp As New StreamReader(currentFile)
                Dim tempText As String = temp.ReadToEnd()
                temp.Close()
                If (Not tbFile.Text = tempText) Then
                    Dim result As Integer = MessageBox.Show("You have unsaved changes, do you want to save the file?", "Unsaved Changes", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        tbFile.Text = ""
                        currentFile = ""
                        Me.Text = currentFile
                    ElseIf result = DialogResult.Yes Then
                        Save(currentFile)
                    End If
                Else
                    tbFile.Text = ""
                    currentFile = ""
                    Me.Text = currentFile
                End If
            Else
                Dim result As Integer = MessageBox.Show("You have unsaved changes, do you want to save the file?", "Unsaved Changes", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                    tbFile.Text = ""
                    currentFile = ""
                    Me.Text = currentFile
                ElseIf result = DialogResult.Yes Then
                    Save(currentFile)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())

        End Try



    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Try
            If (Not currentFile = "") Then
                Dim temp As New StreamReader(currentFile)
                Dim tempText As String = temp.ReadToEnd()
                temp.Close()
                If (Not tbFile.Text = tempText) Then
                    Dim result As Integer = MessageBox.Show("You have unsaved changes, do you want to save the file?", "Unsaved Changes", MessageBoxButtons.YesNoCancel)
                    If result = DialogResult.Cancel Then
                    ElseIf result = DialogResult.No Then
                        tbFile.Text = ""
                        currentFile = ""
                        Me.Text = currentFile
                    ElseIf result = DialogResult.Yes Then
                        Save(currentFile)
                    End If
                Else
                    tbFile.Text = ""
                    currentFile = ""
                    Me.Text = currentFile
                End If
            Else
                Dim result As Integer = MessageBox.Show("You have unsaved changes, do you want to save the file?", "Unsaved Changes", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Cancel Then
                ElseIf result = DialogResult.No Then
                    tbFile.Text = ""
                    currentFile = ""
                    Me.Text = currentFile
                ElseIf result = DialogResult.Yes Then
                    Save(currentFile)
                End If
            End If
        Catch ex As Exception
            Console.WriteLine(ex.ToString())

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

End Class

