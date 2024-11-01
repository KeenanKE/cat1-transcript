Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        Dim loginForm As New login()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnInstructor.Click
        Dim loginForm As New login()
        loginForm.Show()
        Me.Hide()
    End Sub

    Private Sub welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
