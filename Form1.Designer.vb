<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        btnStudent = New Button()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label2 = New Label()
        btnInstructor = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 14F, FontStyle.Bold)
        Label1.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label1.Location = New Point(248, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(457, 37)
        Label1.TabIndex = 0
        Label1.Text = "Welcome to KCA Grading System"
        ' 
        ' btnStudent
        ' 
        btnStudent.BackColor = SystemColors.ActiveCaption
        btnStudent.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        btnStudent.Location = New Point(360, 174)
        btnStudent.Name = "btnStudent"
        btnStudent.Size = New Size(154, 67)
        btnStudent.TabIndex = 3
        btnStudent.Text = "Student"
        btnStudent.UseVisualStyleBackColor = False
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 14F, FontStyle.Bold)
        Label2.LiveSetting = Automation.AutomationLiveSetting.Assertive
        Label2.Location = New Point(330, 114)
        Label2.Name = "Label2"
        Label2.Size = New Size(167, 37)
        Label2.TabIndex = 5
        Label2.Text = "Log In as a:"
        ' 
        ' btnInstructor
        ' 
        btnInstructor.BackColor = SystemColors.ActiveCaption
        btnInstructor.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Bold)
        btnInstructor.Location = New Point(360, 246)
        btnInstructor.Name = "btnInstructor"
        btnInstructor.Size = New Size(154, 67)
        btnInstructor.TabIndex = 6
        btnInstructor.Text = "Instructor"
        btnInstructor.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(btnInstructor)
        Controls.Add(Label2)
        Controls.Add(btnStudent)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "welcome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStudent As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents btnInstructor As Button

End Class
