Public Class login
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Assuming TextBox1 is for username and TextBox2 is for password
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        ' Simple logic to determine if the user is an instructor or student
        If username.StartsWith("instructor") Then
            ' Redirect to instructor.vb
            Dim instructorForm As New instructor()
            instructorForm.Show()
            Me.Hide()
        ElseIf username.StartsWith("student") Then
            ' Redirect to student.vb
            Dim studentForm As New student()
            studentForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid credentials")
        End If
    End Sub
End Class