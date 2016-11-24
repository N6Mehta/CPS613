<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PsyCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PsyCourses))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DoneMinorButton = New System.Windows.Forms.Button()
        Me.CancelMinorButton = New System.Windows.Forms.Button()
        Me.PSY304CO = New CPS613_RAMS_THING.CourseObject()
        Me.PSY325CO = New CPS613_RAMS_THING.CourseObject()
        Me.PSY124CO = New CPS613_RAMS_THING.CourseObject()
        Me.PSY217CO = New CPS613_RAMS_THING.CourseObject()
        Me.PSY504CO = New CPS613_RAMS_THING.CourseObject()
        Me.PSY209CO = New CPS613_RAMS_THING.CourseObject()
        Me.PSY202CO = New CPS613_RAMS_THING.CourseObject()
        Me.PSY105CO = New CPS613_RAMS_THING.CourseObject()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Required courses (2):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(397, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Plus four (4) courses from:"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(30, 321)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(56, 144)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 35
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(30, 497)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(56, 144)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 81)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'DoneMinorButton
        '
        Me.DoneMinorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoneMinorButton.Location = New System.Drawing.Point(618, 705)
        Me.DoneMinorButton.Name = "DoneMinorButton"
        Me.DoneMinorButton.Size = New System.Drawing.Size(212, 79)
        Me.DoneMinorButton.TabIndex = 38
        Me.DoneMinorButton.Text = "Done"
        Me.DoneMinorButton.UseVisualStyleBackColor = True
        '
        'CancelMinorButton
        '
        Me.CancelMinorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelMinorButton.Location = New System.Drawing.Point(908, 705)
        Me.CancelMinorButton.Name = "CancelMinorButton"
        Me.CancelMinorButton.Size = New System.Drawing.Size(212, 79)
        Me.CancelMinorButton.TabIndex = 39
        Me.CancelMinorButton.Text = "Cancel"
        Me.CancelMinorButton.UseVisualStyleBackColor = True
        '
        'PSY304CO
        '
        Me.PSY304CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY304CO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSY304CO.Course_Code = "PSY304"
        Me.PSY304CO.Course_Grade = 0R
        Me.PSY304CO.Course_Name = "Psy of Gender"
        Me.PSY304CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Open_Elective
        Me.PSY304CO.Cursor = System.Windows.Forms.Cursors.Help
        Me.PSY304CO.Location = New System.Drawing.Point(95, 497)
        Me.PSY304CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY304CO.Name = "PSY304CO"
        Me.PSY304CO.Pre_Requisite = "PSY105"
        Me.PSY304CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY304CO.TabIndex = 10
        '
        'PSY325CO
        '
        Me.PSY325CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY325CO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSY325CO.Course_Code = "PSY325"
        Me.PSY325CO.Course_Grade = 0R
        Me.PSY325CO.Course_Name = "Psy Disorders"
        Me.PSY325CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.PSY325CO.Cursor = System.Windows.Forms.Cursors.Help
        Me.PSY325CO.Location = New System.Drawing.Point(544, 321)
        Me.PSY325CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY325CO.Name = "PSY325CO"
        Me.PSY325CO.Pre_Requisite = "PSY105"
        Me.PSY325CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY325CO.TabIndex = 9
        '
        'PSY124CO
        '
        Me.PSY124CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY124CO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSY124CO.Course_Code = "PSY124"
        Me.PSY124CO.Course_Grade = 0R
        Me.PSY124CO.Course_Name = "Social Psycology"
        Me.PSY124CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.PSY124CO.Cursor = System.Windows.Forms.Cursors.Help
        Me.PSY124CO.Location = New System.Drawing.Point(95, 321)
        Me.PSY124CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY124CO.Name = "PSY124CO"
        Me.PSY124CO.Pre_Requisite = "PSY105"
        Me.PSY124CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY124CO.TabIndex = 8
        '
        'PSY217CO
        '
        Me.PSY217CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY217CO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSY217CO.Course_Code = "PSY217"
        Me.PSY217CO.Course_Grade = 0R
        Me.PSY217CO.Course_Name = "Psy and Design"
        Me.PSY217CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.PSY217CO.Cursor = System.Windows.Forms.Cursors.Help
        Me.PSY217CO.Location = New System.Drawing.Point(993, 497)
        Me.PSY217CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY217CO.Name = "PSY217CO"
        Me.PSY217CO.Pre_Requisite = Nothing
        Me.PSY217CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY217CO.TabIndex = 7
        '
        'PSY504CO
        '
        Me.PSY504CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY504CO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSY504CO.Course_Code = "PSY504"
        Me.PSY504CO.Course_Grade = 0R
        Me.PSY504CO.Course_Name = "Social Psy"
        Me.PSY504CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.PSY504CO.Cursor = System.Windows.Forms.Cursors.Help
        Me.PSY504CO.Location = New System.Drawing.Point(993, 321)
        Me.PSY504CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY504CO.Name = "PSY504CO"
        Me.PSY504CO.Pre_Requisite = "PSY105"
        Me.PSY504CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY504CO.TabIndex = 6
        '
        'PSY209CO
        '
        Me.PSY209CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY209CO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSY209CO.Course_Code = "PSY209"
        Me.PSY209CO.Course_Grade = 0R
        Me.PSY209CO.Course_Name = "Industrial Psy"
        Me.PSY209CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.PSY209CO.Cursor = System.Windows.Forms.Cursors.Help
        Me.PSY209CO.Location = New System.Drawing.Point(544, 497)
        Me.PSY209CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY209CO.Name = "PSY209CO"
        Me.PSY209CO.Pre_Requisite = Nothing
        Me.PSY209CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY209CO.TabIndex = 5
        '
        'PSY202CO
        '
        Me.PSY202CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY202CO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSY202CO.Course_Code = "PSY202"
        Me.PSY202CO.Course_Grade = 0R
        Me.PSY202CO.Course_Name = "Intro to Psy II"
        Me.PSY202CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Liberal
        Me.PSY202CO.Cursor = System.Windows.Forms.Cursors.Help
        Me.PSY202CO.Location = New System.Drawing.Point(544, 79)
        Me.PSY202CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY202CO.Name = "PSY202CO"
        Me.PSY202CO.Pre_Requisite = "PSY105"
        Me.PSY202CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY202CO.TabIndex = 3
        '
        'PSY105CO
        '
        Me.PSY105CO.BackColor = System.Drawing.Color.SkyBlue
        Me.PSY105CO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PSY105CO.Course_Code = "PSY105"
        Me.PSY105CO.Course_Grade = 0R
        Me.PSY105CO.Course_Name = "Perspect in Psy"
        Me.PSY105CO.Course_Type = CPS613_RAMS_THING.CourseObject.CourseType.Open_Elective
        Me.PSY105CO.Cursor = System.Windows.Forms.Cursors.Help
        Me.PSY105CO.Location = New System.Drawing.Point(95, 81)
        Me.PSY105CO.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.PSY105CO.Name = "PSY105CO"
        Me.PSY105CO.Pre_Requisite = Nothing
        Me.PSY105CO.Size = New System.Drawing.Size(340, 144)
        Me.PSY105CO.TabIndex = 2
        '
        'PsyCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1501, 894)
        Me.Controls.Add(Me.CancelMinorButton)
        Me.Controls.Add(Me.DoneMinorButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PSY304CO)
        Me.Controls.Add(Me.PSY325CO)
        Me.Controls.Add(Me.PSY124CO)
        Me.Controls.Add(Me.PSY217CO)
        Me.Controls.Add(Me.PSY504CO)
        Me.Controls.Add(Me.PSY209CO)
        Me.Controls.Add(Me.PSY202CO)
        Me.Controls.Add(Me.PSY105CO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PsyCourses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PsyCourses"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PSY105CO As CourseObject
    Friend WithEvents PSY202CO As CourseObject
    Friend WithEvents PSY209CO As CourseObject
    Friend WithEvents PSY504CO As CourseObject
    Friend WithEvents PSY217CO As CourseObject
    Friend WithEvents PSY124CO As CourseObject
    Friend WithEvents PSY325CO As CourseObject
    Friend WithEvents PSY304CO As CourseObject
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DoneMinorButton As Button
    Friend WithEvents CancelMinorButton As Button
End Class
