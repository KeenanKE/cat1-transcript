<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student
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
        Label2 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        dropYear = New ComboBox()
        dropSem = New ComboBox()
        btnGrade = New Button()
        btnInstructor = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(335, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 25)
        Label1.TabIndex = 0
        Label1.Text = "Transcript"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(141, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 25)
        Label2.TabIndex = 1
        Label2.Text = "Academic Year"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(141, 197)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 25)
        Label3.TabIndex = 2
        Label3.Text = "Semester"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(95, 311)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1101, 225)
        DataGridView1.TabIndex = 3
        ' 
        ' dropYear
        ' 
        dropYear.FormattingEnabled = True
        dropYear.Location = New Point(307, 101)
        dropYear.Name = "dropYear"
        dropYear.Size = New Size(228, 33)
        dropYear.TabIndex = 4
        ' 
        ' dropSem
        ' 
        dropSem.FormattingEnabled = True
        dropSem.Location = New Point(307, 197)
        dropSem.Name = "dropSem"
        dropSem.Size = New Size(228, 33)
        dropSem.TabIndex = 5
        ' 
        ' btnGrade
        ' 
        btnGrade.Location = New Point(602, 142)
        btnGrade.Name = "btnGrade"
        btnGrade.RightToLeft = RightToLeft.Yes
        btnGrade.Size = New Size(112, 34)
        btnGrade.TabIndex = 6
        btnGrade.Text = "Display Grades"
        btnGrade.UseVisualStyleBackColor = True
        ' 
        ' btnInstructor
        ' 
        btnInstructor.Location = New Point(763, 573)
        btnInstructor.Name = "btnInstructor"
        btnInstructor.Size = New Size(167, 60)
        btnInstructor.TabIndex = 7
        btnInstructor.Text = "Instructor View"
        btnInstructor.UseVisualStyleBackColor = True
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Reg No"
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
        Column4.HeaderText = "Course Code"
        Column4.MinimumWidth = 8
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 150
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Total Marks"
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
        ' student
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1280, 778)
        Controls.Add(btnInstructor)
        Controls.Add(btnGrade)
        Controls.Add(dropSem)
        Controls.Add(dropYear)
        Controls.Add(DataGridView1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "student"
        Text = "student"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dropYear As ComboBox
    Friend WithEvents dropSem As ComboBox
    Friend WithEvents btnGrade As Button
    Friend WithEvents btnInstructor As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
