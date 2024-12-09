Imports System.IO
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

    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click
        Dim filePath As String = "G:\WRITING\CLASS NOTES\App Program\cat\results.csv"
        If File.Exists(filePath) Then
            Using reader As New StreamReader(filePath, Encoding.Default)
                Dim line As String
                While Not reader.EndOfStream
                    line = reader.ReadLine()
                    Dim values As String() = line.Split(","c)
                    If values.Length >= 3 Then
                        Dim unitCode As String = values(0).Trim()
                        Dim grade As String = values(1).Trim()
                        Dim comment As String = values(2).Trim()
                        If Not String.IsNullOrEmpty(unitCode) AndAlso Not String.IsNullOrEmpty(grade) AndAlso Not String.IsNullOrEmpty(comment) Then
                            DataGridView1.Rows.Add(unitCode, grade, comment)
                        End If
                    End If
                End While
            End Using
        Else
            MessageBox.Show("File not found: " & filePath)
        End If
    End Sub
End Class