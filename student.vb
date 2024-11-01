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
End Class