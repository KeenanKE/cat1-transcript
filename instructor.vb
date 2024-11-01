Public Class instructor
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        Label13.AutoSize = True
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles txtbxCAT.TextChanged
        Dim input As String = txtbxCAT.Text
        Dim value As Integer

        If Integer.TryParse(input, value) Then
            If value > 15 Or value < 0 Then
                MessageBox.Show("Please enter a value between 0 and 15.")
                txtbxCAT.Text = String.Empty
            End If
        Else
            txtbxCAT.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles txtbxAssn.TextChanged
        Dim input As String = txtbxAssn.Text
        Dim value As Integer

        If Integer.TryParse(input, value) Then
            If value > 5 Or value < 0 Then
                MessageBox.Show("Please enter a value between 0 and 5.")
                txtbxAssn.Text = String.Empty
            End If
        Else
            txtbxAssn.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtbxLab.TextChanged
        Dim input As String = txtbxLab.Text
        Dim value As Integer

        If Integer.TryParse(input, value) Then
            If value > 10 Or value < 0 Then
                MessageBox.Show("Please enter a value between 0 and 10.")
                txtbxLab.Text = String.Empty
            End If
        Else
            txtbxLab.Text = String.Empty
        End If
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles txtbxExam.TextChanged
        Dim input As String = txtbxExam.Text
        Dim value As Integer

        If Integer.TryParse(input, value) Then
            If value > 70 Or value < 0 Then
                MessageBox.Show("Please enter a value between 0 and 70.")
                txtbxExam.Text = String.Empty
            End If
        Else
            txtbxExam.Text = String.Empty
        End If
    End Sub


    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim catValue, examValue, assnValue, labValue, total As Integer

        If Integer.TryParse(txtbxCAT.Text, catValue) AndAlso
          Integer.TryParse(txtbxExam.Text, examValue) AndAlso
          Integer.TryParse(txtbxAssn.Text, assnValue) AndAlso
          Integer.TryParse(txtbxLab.Text, labValue) Then

            total = catValue + examValue + assnValue + labValue
            Dim grade As String
            Dim comments As String

            Select Case total
                Case > 90
                    grade = "A"
                Case 80 To 89
                    grade = "B"
                Case 70 To 79
                    grade = "C"
                Case 60 To 69
                    grade = "D"
                Case 50 To 59
                    grade = "E"
                Case 40 To 49
                    grade = "F"
                Case Else
                    grade = "Z"
            End Select

            If grade = "F" Then
                comments = "Failed"
            Else
                comments = "Pass"
            End If

            DataGridView1.Rows.Add(txtbxRegNo.Text, txtbxFirstName.Text, txtbxLastName.Text, txtbxUnitCode.Text, total, grade, comments)
        Else
            MessageBox.Show("Please ensure all inputs are valid integers.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Your code for Button2 click event

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Your code for DataGridView1 cell content click event
    End Sub

    Private Sub txtbxRegNo_TextChanged(sender As Object, e As EventArgs) Handles txtbxRegNo.TextChanged
        ' Your code for txtbxRegNo text changed event
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Your code for btnAdd click event
    End Sub

    Private Sub txtbxLastName_TextChanged(sender As Object, e As EventArgs) Handles txtbxLastName.TextChanged
        ' Your code for txtbxLastName text changed event
    End Sub

    Private Sub txtbxFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtbxFirstName.TextChanged
        ' Your code for txtbxFirstName text changed event
    End Sub

    Private Sub txtbxUnitCode_TextChanged(sender As Object, e As EventArgs) Handles txtbxUnitCode.TextChanged
        ' Your code for txtbxUnitCode text changed event
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropYear.SelectedIndexChanged
        dropYear.Items.Clear()
        dropYear.Items.Add("2020/21")
        dropYear.Items.Add("2021/22")
        dropYear.Items.Add("2022/23")
        dropYear.Items.Add("2023/24")
        dropYear.Items.Add("2024/25")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropSem.SelectedIndexChanged
        dropSem.Items.Clear()
        dropSem.Items.Add("Semester 1")
        dropSem.Items.Add("Semester 2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtbxCAT.Text = String.Empty
        txtbxAssn.Text = String.Empty
        txtbxLab.Text = String.Empty
        txtbxExam.Text = String.Empty
        txtbxRegNo.Text = String.Empty
        txtbxFirstName.Text = String.Empty
        txtbxLastName.Text = String.Empty
        txtbxUnitCode.Text = String.Empty
    End Sub



    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs)
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow = DataGridView1.SelectedRows(0)
            selectedRow.Cells("RegNo").Value = txtbxRegNo.Text
            selectedRow.Cells("FirstName").Value = txtbxFirstName.Text
            selectedRow.Cells("LastName").Value = txtbxLastName.Text
            selectedRow.Cells("UnitCode").Value = txtbxUnitCode.Text

            Dim catValue, examValue, assnValue, labValue, total As Integer

            If Integer.TryParse(txtbxCAT.Text, catValue) AndAlso
                   Integer.TryParse(txtbxExam.Text, examValue) AndAlso
                   Integer.TryParse(txtbxAssn.Text, assnValue) AndAlso
                   Integer.TryParse(txtbxLab.Text, labValue) Then

                total = catValue + examValue + assnValue + labValue
                Dim grade As String
                Dim comments As String

                Select Case total
                    Case > 90
                        grade = "A"
                    Case 80 To 89
                        grade = "B"
                    Case 70 To 79
                        grade = "C"
                    Case 60 To 69
                        grade = "D"
                    Case 50 To 59
                        grade = "E"
                    Case 40 To 49
                        grade = "F"
                    Case Else
                        grade = "Z"
                End Select

                If grade = "F" Then
                    comments = "Failed"
                Else
                    comments = "Pass"
                End If

                selectedRow.Cells("Total").Value = total
                selectedRow.Cells("Grade").Value = grade
                selectedRow.Cells("Comments").Value = comments
            Else
                MessageBox.Show("Please ensure all inputs are valid integers.")
            End If
        Else
            MessageBox.Show("Please select a row to update.")
        End If
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub btnSaveScript_Click(sender As Object, e As EventArgs) Handles btnSaveScript.Click

    End Sub
End Class

