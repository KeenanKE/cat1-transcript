﻿Imports System.IO
Imports System.Text

Public Class student
    Private Sub student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dropYear.Items.Add("2020/21")
        dropYear.Items.Add("2021/22")
        dropYear.Items.Add("2022/23")
        dropYear.Items.Add("2023/24")
        dropYear.Items.Add("2024/25")
        dropSem.Items.Clear()
        dropSem.Items.Add("Semester 1")
        dropSem.Items.Add("Semester 2")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LoadDataFromInstructor()
        ' Assuming instructorForm is an instance of the instructor form
        Dim instructorForm As New instructor()
        For Each row As DataGridViewRow In instructorForm.DataGridView1.Rows
            If Not row.IsNewRow Then
                Dim unitCode As String = row.Cells("unit code").Value.ToString()
                Dim grade As String = row.Cells("grade").Value.ToString()
                Dim comment As String = row.Cells("comment").Value.ToString()
                DataGridView1.Rows.Add(unitCode, grade, comment)
            End If
        Next
    End Sub

    'Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
    '    Dim filePath As String = "G:\WRITING\CLASS NOTES\App Program\cat\results.csv"
    '    If File.Exists(filePath) Then
    '        Using reader As New StreamReader(filePath, Encoding.Default)
    '            Dim line As String
    '            While Not reader.EndOfStream
    '                line = reader.ReadLine()
    '                Dim values As String() = line.Split(","c)
    '                If values.Length >= 3 Then
    '                    Dim unitCode As String = values(0).Trim()
    '                    Dim grade As String = values(1).Trim()
    '                    Dim comment As String = values(2).Trim()
    '                    If Not String.IsNullOrEmpty(unitCode) AndAlso Not String.IsNullOrEmpty(grade) AndAlso Not String.IsNullOrEmpty(comment) Then
    '                        DataGridView1.Rows.Add(unitCode, grade, comment)
    '                    End If
    '                End If
    '            End While
    '        End Using
    '    Else
    '        MessageBox.Show("File not found: " & filePath)
    '    End If
    'End Sub

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        'Dim filePath As String = "/mnt/data/results.csv"
        Dim filePath As String = "G:\WRITING\CLASS NOTES\App Program\cat\results.csv"

        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath, Encoding.Default)
                Dim line As String
                ' Read the first line to get headers
                Dim headers As String() = reader.ReadLine().Split(","c)

                ' Determine the index of "unit code", "grade", and "comment" columns
                Dim unitCodeIndex As Integer = Array.IndexOf(headers, "unit code")
                Dim gradeIndex As Integer = Array.IndexOf(headers, "grade")
                Dim commentIndex As Integer = Array.IndexOf(headers, "comment")

                If unitCodeIndex >= 0 And gradeIndex >= 0 And commentIndex >= 0 Then
                    ' Read the rest of the file and add the relevant columns to the DataGridView
                    While Not reader.EndOfStream
                        line = reader.ReadLine()
                        Dim values As String() = line.Split(","c)

                        ' Ensure the row has enough columns before accessing
                        If values.Length > unitCodeIndex And values.Length > gradeIndex And values.Length > commentIndex Then
                            Dim unitCode As String = values(unitCodeIndex).Trim()
                            Dim grade As String = values(gradeIndex).Trim()
                            Dim comment As String = values(commentIndex).Trim()

                            If Not String.IsNullOrEmpty(unitCode) AndAlso Not String.IsNullOrEmpty(grade) AndAlso Not String.IsNullOrEmpty(comment) Then
                                DataGridView1.Rows.Add(unitCode, grade, comment)
                            End If
                        End If
                    End While
                Else
                    MessageBox.Show("Required columns ('unit code', 'grade', 'comment') not found in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Else
            MessageBox.Show("File not found: " & filePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnInstructor_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click
        Dim instructorForm As New instructor()
        instructorForm.Show()
        Me.Hide()
    End Sub
End Class