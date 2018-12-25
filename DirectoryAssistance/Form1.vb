' Raymond McCann
Imports System.IO
Imports System.Linq
Public Class Form1
    Dim _employees() As Directory
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file() As String = IO.File.ReadAllLines("Employees.txt")
        ReDim _employees(file.Length)

        For i = 0 To file.Length - 1
            _employees(i) = New Directory(file(i))
        Next
    End Sub

    Function SearchNames()
        Dim pressedNumbers As String = txtCode.Text

        If txtCode.Text.Length = 4 Then
            For i As Integer = 0 To _employees.Length - 2
                Dim firstName As String = _employees(i).FirstName.Substring(0, 1).ToLower
                Dim lastName As String = _employees(i).LastName.Substring(0, 3).ToLower
                Dim code As String = _employees(i).Code
                Dim correctCount As Integer = 0
                Dim firstNameMatch As Boolean = False

                For j As Integer = 0 To lastName.Length - 1 Step 1
                    If pressedNumbers.Substring(j, 1) = "2" Then
                        If txtCode.Text.Substring(3, 1) = "2" Then
                            firstNameMatch = True
                        End If
                        If lastName.Substring(j, 1) = "a" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "b" Then
                            correctCount += 1

                        End If
                        If lastName.Substring(j, 1) = "c" Then
                            correctCount += 1
                        End If
                    End If

                    If pressedNumbers.Substring(j, 1) = "3" Then
                        If txtCode.Text.Substring(3, 1) = "3" Then
                            firstNameMatch = True
                        End If
                        If lastName.Substring(j, 1) = "d" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "e" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "f" Then
                            correctCount += 1
                        End If
                    End If

                    If pressedNumbers.Substring(j, 1) = "4" Then
                        If txtCode.Text.Substring(3, 1) = "4" Then
                            firstNameMatch = True
                        End If
                        If lastName.Substring(j, 1) = "g" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "h" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "i" Then
                            correctCount += 1
                        End If
                    End If

                    If pressedNumbers.Substring(j, 1) = "5" Then
                        If txtCode.Text.Substring(3, 1) = "5" Then
                            firstNameMatch = True
                        End If
                        If lastName.Substring(j, 1) = "j" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "k" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "l" Then
                            correctCount += 1
                        End If
                    End If

                    If pressedNumbers.Substring(j, 1) = "6" Then
                        If txtCode.Text.Substring(3, 1) = "6" Then
                            firstNameMatch = True
                        End If
                        If lastName.Substring(j, 1) = "m" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "n" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "o" Then
                            correctCount += 1
                        End If
                    End If

                    If pressedNumbers.Substring(j, 1) = "7" Then
                        If txtCode.Text.Substring(3, 1) = "7" Then
                            firstNameMatch = True
                        End If
                        If lastName.Substring(j, 1) = "p" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "q" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "r" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "s" Then
                            correctCount += 1
                        End If
                    End If

                    If pressedNumbers.Substring(j, 1) = "8" Then
                        If txtCode.Text.Substring(3, 1) = "8" Then
                            firstNameMatch = True
                        End If
                        If lastName.Substring(j, 1) = "t" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "u" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "v" Then
                            correctCount += 1
                        End If
                    End If

                    If pressedNumbers.Substring(j, 1) = "9" Then
                        If txtCode.Text.Substring(3, 1) = "9" Then
                            firstNameMatch = True
                        End If
                        If lastName.Substring(j, 1) = "w" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "x" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "y" Then
                            correctCount += 1
                        End If
                        If lastName.Substring(j, 1) = "z" Then
                            correctCount += 1
                        End If
                    End If

                    If correctCount = 3 Then
                        ListBox1.Items.Add(_employees(i).FirstName & " " & _employees(i).LastName & " x" & _employees(i).Code)
                        correctCount = 0
                        firstNameMatch = False
                        Return True
                    End If
                Next
            Next
        End If
        Return False
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtCode.Text.Length < 4 Then txtCode.Text = txtCode.Text & "2"
        SearchNames()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtCode.Text.Length < 4 Then txtCode.Text = txtCode.Text & "3"
        SearchNames()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txtCode.Text.Length < 4 Then txtCode.Text = txtCode.Text & "4"
        SearchNames()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If txtCode.Text.Length < 4 Then txtCode.Text = txtCode.Text & "5"
        SearchNames()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If txtCode.Text.Length < 4 Then txtCode.Text = txtCode.Text & "6"
        SearchNames()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If txtCode.Text.Length < 4 Then txtCode.Text = txtCode.Text & "7"
        SearchNames()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If txtCode.Text.Length < 4 Then txtCode.Text = txtCode.Text & "8"
        SearchNames()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If txtCode.Text.Length < 4 Then txtCode.Text = txtCode.Text & "9"
        SearchNames()
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MessageBox.Show("Enter the first three letters of the last name, followed by the first letter of the fist name.")
    End Sub

    Private Sub btnLookup_Click(sender As Object, e As EventArgs) Handles btnLookup.Click
        txtCode.Text = ""
        ListBox1.Items.Clear()
    End Sub
End Class

Structure Directory
    Public FirstName As String
    Public LastName As String
    Public Code As String

    Public Sub New(rawData As String)
        Dim Values() As String = Split(rawData, ",")
        FirstName = Values(1)
        LastName = Values(0)
        Code = Values(2)
    End Sub
End Structure
