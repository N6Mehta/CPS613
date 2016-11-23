<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PsyCourses
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PSY105CO = New CPS613_RAMS_THING.CourseObject()
        Me.PSY202CO = New CPS613_RAMS_THING.CourseObject()
        Me.CourseObject3 = New CPS613_RAMS_THING.CourseObject()
        Me.CourseObject4 = New CPS613_RAMS_THING.CourseObject()
        Me.CourseObject5 = New CPS613_RAMS_THING.CourseObject()
        Me.CourseObject6 = New CPS613_RAMS_THING.CourseObject()
        Me.CourseObject7 = New CPS613_RAMS_THING.CourseObject()
        Me.CourseObject8 = New CPS613_RAMS_THING.CourseObject()
        Me.PSY304CO = New CPS613_RAMS_THING.CourseObject()
        Me.CourseObject10 = New CPS613_RAMS_THING.CourseObject()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Required courses (2):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(397, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Plus four (4) courses from:"
        '
        'PSY105CO
        '
        Me.PSY105CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY105CO.Course_Code = "PSY105"
        Me.PSY105CO.Course_Grade = 2.27R
        Me.PSY105CO.Course_Name = "Perspect in Psy"
        Me.PSY105CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Open_Elective
        Me.PSY105CO.Location = New System.Drawing.Point(54, 79)
        Me.PSY105CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY105CO.Name = "PSY105CO"
        Me.PSY105CO.Pre_Requisite = Nothing
        Me.PSY105CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY105CO.TabIndex = 2
        '
        'PSY202CO
        '
        Me.PSY202CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY202CO.Course_Code = "PSY202"
        Me.PSY202CO.Course_Grade = 0R
        Me.PSY202CO.Course_Name = "Intro to Psy II"
        Me.PSY202CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.PSY202CO.Location = New System.Drawing.Point(498, 79)
        Me.PSY202CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY202CO.Name = "PSY202CO"
        Me.PSY202CO.Pre_Requisite = Nothing
        Me.PSY202CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY202CO.TabIndex = 3
        '
        'CourseObject3
        '
        Me.CourseObject3.BackColor = System.Drawing.Color.SkyBlue
        Me.CourseObject3.Course_Code = "Course Code"
        Me.CourseObject3.Course_Grade = 0R
        Me.CourseObject3.Course_Name = "Course Name"
        Me.CourseObject3.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.CourseObject3.Location = New System.Drawing.Point(54, 847)
        Me.CourseObject3.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CourseObject3.Name = "CourseObject3"
        Me.CourseObject3.Pre_Requisite = Nothing
        Me.CourseObject3.Size = New System.Drawing.Size(340, 144)
        Me.CourseObject3.TabIndex = 4
        '
        'CourseObject4
        '
        Me.CourseObject4.BackColor = System.Drawing.Color.SkyBlue
        Me.CourseObject4.Course_Code = "Course Code"
        Me.CourseObject4.Course_Grade = 0R
        Me.CourseObject4.Course_Name = "Course Name"
        Me.CourseObject4.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.CourseObject4.Location = New System.Drawing.Point(498, 495)
        Me.CourseObject4.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CourseObject4.Name = "CourseObject4"
        Me.CourseObject4.Pre_Requisite = Nothing
        Me.CourseObject4.Size = New System.Drawing.Size(340, 144)
        Me.CourseObject4.TabIndex = 5
        '
        'CourseObject5
        '
        Me.CourseObject5.BackColor = System.Drawing.Color.SkyBlue
        Me.CourseObject5.Course_Code = "Course Code"
        Me.CourseObject5.Course_Grade = 0R
        Me.CourseObject5.Course_Name = "Course Name"
        Me.CourseObject5.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.CourseObject5.Location = New System.Drawing.Point(498, 671)
        Me.CourseObject5.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CourseObject5.Name = "CourseObject5"
        Me.CourseObject5.Pre_Requisite = Nothing
        Me.CourseObject5.Size = New System.Drawing.Size(340, 144)
        Me.CourseObject5.TabIndex = 6
        '
        'CourseObject6
        '
        Me.CourseObject6.BackColor = System.Drawing.Color.SkyBlue
        Me.CourseObject6.Course_Code = "Course Code"
        Me.CourseObject6.Course_Grade = 0R
        Me.CourseObject6.Course_Name = "Course Name"
        Me.CourseObject6.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.CourseObject6.Location = New System.Drawing.Point(54, 671)
        Me.CourseObject6.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CourseObject6.Name = "CourseObject6"
        Me.CourseObject6.Pre_Requisite = Nothing
        Me.CourseObject6.Size = New System.Drawing.Size(340, 144)
        Me.CourseObject6.TabIndex = 7
        '
        'CourseObject7
        '
        Me.CourseObject7.BackColor = System.Drawing.Color.SkyBlue
        Me.CourseObject7.Course_Code = "Course Code"
        Me.CourseObject7.Course_Grade = 0R
        Me.CourseObject7.Course_Name = "Course Name"
        Me.CourseObject7.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.CourseObject7.Location = New System.Drawing.Point(54, 495)
        Me.CourseObject7.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CourseObject7.Name = "CourseObject7"
        Me.CourseObject7.Pre_Requisite = Nothing
        Me.CourseObject7.Size = New System.Drawing.Size(340, 144)
        Me.CourseObject7.TabIndex = 8
        '
        'CourseObject8
        '
        Me.CourseObject8.BackColor = System.Drawing.Color.SkyBlue
        Me.CourseObject8.Course_Code = "Course Code"
        Me.CourseObject8.Course_Grade = 0R
        Me.CourseObject8.Course_Name = "Course Name"
        Me.CourseObject8.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.CourseObject8.Location = New System.Drawing.Point(498, 319)
        Me.CourseObject8.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CourseObject8.Name = "CourseObject8"
        Me.CourseObject8.Pre_Requisite = Nothing
        Me.CourseObject8.Size = New System.Drawing.Size(340, 144)
        Me.CourseObject8.TabIndex = 9
        '
        'PSY304CO
        '
        Me.PSY304CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY304CO.Course_Code = "PSY304"
        Me.PSY304CO.Course_Grade = 3.33R
        Me.PSY304CO.Course_Name = "Psy of Gender"
        Me.PSY304CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Open_Elective
        Me.PSY304CO.Location = New System.Drawing.Point(54, 319)
        Me.PSY304CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY304CO.Name = "PSY304CO"
        Me.PSY304CO.Pre_Requisite = Nothing
        Me.PSY304CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY304CO.TabIndex = 10
        '
        'CourseObject10
        '
        Me.CourseObject10.BackColor = System.Drawing.Color.SkyBlue
        Me.CourseObject10.Course_Code = "Course Code"
        Me.CourseObject10.Course_Grade = 0R
        Me.CourseObject10.Course_Name = "Course Name"
        Me.CourseObject10.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.CourseObject10.Location = New System.Drawing.Point(498, 847)
        Me.CourseObject10.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CourseObject10.Name = "CourseObject10"
        Me.CourseObject10.Pre_Requisite = Nothing
        Me.CourseObject10.Size = New System.Drawing.Size(340, 144)
        Me.CourseObject10.TabIndex = 11
        '
        'PsyCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 1215)
        Me.Controls.Add(Me.CourseObject10)
        Me.Controls.Add(Me.PSY304CO)
        Me.Controls.Add(Me.CourseObject8)
        Me.Controls.Add(Me.CourseObject7)
        Me.Controls.Add(Me.CourseObject6)
        Me.Controls.Add(Me.CourseObject5)
        Me.Controls.Add(Me.CourseObject4)
        Me.Controls.Add(Me.CourseObject3)
        Me.Controls.Add(Me.PSY202CO)
        Me.Controls.Add(Me.PSY105CO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PsyCourses"
        Me.Text = "PsyCourses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PSY105CO As CourseObject
    Friend WithEvents PSY202CO As CourseObject
    Friend WithEvents CourseObject3 As CourseObject
    Friend WithEvents CourseObject4 As CourseObject
    Friend WithEvents CourseObject5 As CourseObject
    Friend WithEvents CourseObject6 As CourseObject
    Friend WithEvents CourseObject7 As CourseObject
    Friend WithEvents CourseObject8 As CourseObject
    Friend WithEvents PSY304CO As CourseObject
    Friend WithEvents CourseObject10 As CourseObject
End Class
