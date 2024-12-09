<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class instructor
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
        Label1 = New Label()
        lblRegNo = New Label()
        lblLastName = New Label()
        lblFirstName = New Label()
        lblUnitCode = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        btnCompute = New Button()
        btnAdd = New Button()
        Button3 = New Button()
        btnDelete = New Button()
        btnSaveScript = New Button()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        txtbxRegNo = New TextBox()
        txtbxLastName = New TextBox()
        txtbxFirstName = New TextBox()
        txtbxUnitCode = New TextBox()
        txtbxCAT = New TextBox()
        txtbxAssn = New TextBox()
        txtbxLab = New TextBox()
        txtbxExam = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        dropYear = New ComboBox()
        dropSem = New ComboBox()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(544, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 25)
        Label1.TabIndex = 0
        Label1.Text = "Grading System"
        ' 
        ' lblRegNo
        ' 
        lblRegNo.AutoSize = True
        lblRegNo.Location = New Point(50, 93)
        lblRegNo.Name = "lblRegNo"
        lblRegNo.Size = New Size(79, 25)
        lblRegNo.TabIndex = 1
        lblRegNo.Text = "Reg. No."
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Location = New Point(50, 167)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(95, 25)
        lblLastName.TabIndex = 2
        lblLastName.Text = "Last Name"
        ' 
        ' lblFirstName
        ' 
        lblFirstName.AutoSize = True
        lblFirstName.Location = New Point(50, 248)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(97, 25)
        lblFirstName.TabIndex = 3
        lblFirstName.Text = "First Name"
        ' 
        ' lblUnitCode
        ' 
        lblUnitCode.AutoSize = True
        lblUnitCode.Location = New Point(50, 335)
        lblUnitCode.Name = "lblUnitCode"
        lblUnitCode.Size = New Size(91, 25)
        lblUnitCode.TabIndex = 4
        lblUnitCode.Text = "Unit Code"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(410, 93)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 25)
        Label6.TabIndex = 5
        Label6.Text = "Year"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(410, 167)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 25)
        Label7.TabIndex = 6
        Label7.Text = "Semester"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(410, 248)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 25)
        Label8.TabIndex = 7
        Label8.Text = "CAT(s)"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(410, 335)
        Label9.Name = "Label9"
        Label9.Size = New Size(124, 25)
        Label9.TabIndex = 8
        Label9.Text = "Assignment(s)"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(759, 93)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 25)
        Label10.TabIndex = 9
        Label10.Text = "Lab(s)"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(759, 167)
        Label11.Name = "Label11"
        Label11.Size = New Size(54, 25)
        Label11.TabIndex = 10
        Label11.Text = "Exam"
        ' 
        ' btnCompute
        ' 
        btnCompute.Location = New Point(50, 387)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(112, 67)
        btnCompute.TabIndex = 11
        btnCompute.Text = "Compute Grade"
        btnCompute.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(270, 387)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 67)
        btnAdd.TabIndex = 12
        btnAdd.Text = "Add to Transcript"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(520, 387)
        Button3.Name = "Button3"
        Button3.Size = New Size(112, 67)
        Button3.TabIndex = 13
        Button3.Text = "Clear All Fields"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(737, 387)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 67)
        btnDelete.TabIndex = 15
        btnDelete.Text = "Delete Transcript"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnSaveScript
        ' 
        btnSaveScript.Location = New Point(949, 387)
        btnSaveScript.Name = "btnSaveScript"
        btnSaveScript.Size = New Size(112, 67)
        btnSaveScript.TabIndex = 16
        btnSaveScript.Text = "Save Transcript"
        btnSaveScript.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(50, 476)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1098, 225)
        DataGridView1.TabIndex = 17
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Reg. No."
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 150
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Last Name"
        Column2.MinimumWidth = 8
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "First Name"
        Column3.MinimumWidth = 8
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Unit Code"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Unit Name"
        Column5.MinimumWidth = 8
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 150
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Grade"
        Column6.MinimumWidth = 8
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 150
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Comments"
        Column7.MinimumWidth = 8
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 150
        ' 
        ' txtbxRegNo
        ' 
        txtbxRegNo.Location = New Point(192, 90)
        txtbxRegNo.Name = "txtbxRegNo"
        txtbxRegNo.Size = New Size(150, 31)
        txtbxRegNo.TabIndex = 18
        ' 
        ' txtbxLastName
        ' 
        txtbxLastName.Location = New Point(192, 167)
        txtbxLastName.Name = "txtbxLastName"
        txtbxLastName.Size = New Size(150, 31)
        txtbxLastName.TabIndex = 19
        ' 
        ' txtbxFirstName
        ' 
        txtbxFirstName.Location = New Point(192, 248)
        txtbxFirstName.Name = "txtbxFirstName"
        txtbxFirstName.Size = New Size(150, 31)
        txtbxFirstName.TabIndex = 20
        ' 
        ' txtbxUnitCode
        ' 
        txtbxUnitCode.Location = New Point(192, 332)
        txtbxUnitCode.Name = "txtbxUnitCode"
        txtbxUnitCode.Size = New Size(150, 31)
        txtbxUnitCode.TabIndex = 21
        ' 
        ' txtbxCAT
        ' 
        txtbxCAT.Location = New Point(556, 245)
        txtbxCAT.Name = "txtbxCAT"
        txtbxCAT.Size = New Size(150, 31)
        txtbxCAT.TabIndex = 22
        ' 
        ' txtbxAssn
        ' 
        txtbxAssn.Location = New Point(556, 332)
        txtbxAssn.Name = "txtbxAssn"
        txtbxAssn.Size = New Size(150, 31)
        txtbxAssn.TabIndex = 23
        ' 
        ' txtbxLab
        ' 
        txtbxLab.Location = New Point(860, 93)
        txtbxLab.Name = "txtbxLab"
        txtbxLab.Size = New Size(150, 31)
        txtbxLab.TabIndex = 24
        ' 
        ' txtbxExam
        ' 
        txtbxExam.Location = New Point(860, 164)
        txtbxExam.Name = "txtbxExam"
        txtbxExam.Size = New Size(150, 31)
        txtbxExam.TabIndex = 25
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(805, 229)
        Label12.Name = "Label12"
        Label12.Size = New Size(0, 25)
        Label12.TabIndex = 26
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(860, 213)
        Label13.Name = "Label13"
        Label13.Size = New Size(234, 150)
        Label13.TabIndex = 27
        Label13.Text = "Maximum Allowable Scores:" & vbCrLf & "CAT - 15" & vbCrLf & "Assignments - 5" & vbCrLf & "Lab - 10" & vbCrLf & "Exams - 15" & vbCrLf & "Total - 100"
        ' 
        ' dropYear
        ' 
        dropYear.FormattingEnabled = True
        dropYear.Location = New Point(544, 93)
        dropYear.Name = "dropYear"
        dropYear.Size = New Size(182, 33)
        dropYear.TabIndex = 28
        ' 
        ' dropSem
        ' 
        dropSem.FormattingEnabled = True
        dropSem.Location = New Point(544, 167)
        dropSem.Name = "dropSem"
        dropSem.Size = New Size(182, 33)
        dropSem.TabIndex = 29
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1003, 40)
        Button1.Name = "Button1"
        Button1.Size = New Size(183, 34)
        Button1.TabIndex = 30
        Button1.Text = "Student View"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' instructor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1198, 713)
        Controls.Add(Button1)
        Controls.Add(dropSem)
        Controls.Add(dropYear)
        Controls.Add(Label13)
        Controls.Add(Label12)
        Controls.Add(txtbxExam)
        Controls.Add(txtbxLab)
        Controls.Add(txtbxAssn)
        Controls.Add(txtbxCAT)
        Controls.Add(txtbxUnitCode)
        Controls.Add(txtbxFirstName)
        Controls.Add(txtbxLastName)
        Controls.Add(txtbxRegNo)
        Controls.Add(DataGridView1)
        Controls.Add(btnSaveScript)
        Controls.Add(btnDelete)
        Controls.Add(Button3)
        Controls.Add(btnAdd)
        Controls.Add(btnCompute)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(lblUnitCode)
        Controls.Add(lblFirstName)
        Controls.Add(lblLastName)
        Controls.Add(lblRegNo)
        Controls.Add(Label1)
        Name = "instructor"
        Text = "instructor"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblRegNo As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblUnitCode As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSaveScript As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txtbxRegNo As TextBox
    Friend WithEvents txtbxLastName As TextBox
    Friend WithEvents txtbxFirstName As TextBox
    Friend WithEvents txtbxUnitCode As TextBox
    Friend WithEvents txtbxCAT As TextBox
    Friend WithEvents txtbxAssn As TextBox
    Friend WithEvents txtbxLab As TextBox
    Friend WithEvents txtbxExam As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dropYear As ComboBox
    Friend WithEvents dropSem As ComboBox
    Friend WithEvents Button1 As Button
End Class
