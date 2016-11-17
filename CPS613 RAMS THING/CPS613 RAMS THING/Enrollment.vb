Public Class Enrollment
    Dim complete = Color.LimeGreen
    Dim failed = Color.IndianRed
    Dim open = Color.SkyBlue
    Dim enrolled = Color.Yellow
    Dim unavailable = Color.DarkGray

    'Dim passedCourses As CourseObject() = {PCS110CO, CPS109CO, CPS213CO, LL1CO, MTH207CO, CPS412CO, CPS209CO, CPS310CO, LL2CO}
    'Dim enrolledCourses As CourseObject() = {MTH108CO, CMN300CO, CPS305CO, CPS393CO, CPS393CO, CPS406CO, CPS506CO, CPS590CO}

    Dim Year2InitLoc As Point
    Dim Y3Y4InitLoc As Point
    Dim break = 15

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles HelpLinkLabel.LinkClicked
        My.Forms.Help.Show()
    End Sub

    Private Sub Enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadFirstYear()
        LoadSecondYear()
        'For i As Integer = 0 To (passedCourses.Length - 1)
        'passedCourses(i).updateState("pass")
        'Next
        'For i As Integer = 1 To enrolledCourses.Length
        'enrolledCourses(i).updateState("enrolled")
        'Next
        Year2InitLoc = Y2BigPanel.Location
        Y3Y4InitLoc = Y3Y4Panel.Location
        closeYear1()
        closeYear2()
    End Sub

    Sub LoadFirstYear()
        MTH110CO.CourseCode.Text = "MTH110"
        MTH207CO.CourseCode.Text = "MTH207"
        CPS209CO.CourseCode.Text = "CPS209"
        CPS213CO.CourseCode.Text = "CPS213"
        CPS310CO.CourseCode.Text = "CPS310"
        CPS412CO.CourseCode.Text = "CPS412"
        CPS109CO.CourseCode.Text = "CPS109"
        LL1CO.CourseCode.Text = "Lower Level" + vbCrLf + "Liberal 1"
        LL2CO.CourseCode.Text = "Lower Level" + vbCrLf + "Liberal 2"
        PCS110CO.CourseCode.Text = "PCS110"


        MTH110CO.CourseName.Text = "Discrete Math I"
        MTH207CO.CourseName.Text = "Calculus and" + vbCrLf + "Comp. Methods I"
        CPS412CO.CourseName.Font = New Font(CPS412CO.CourseName.Font.FontFamily, 6, CPS412CO.CourseName.Font.Style)
        CPS412CO.CourseName.Text = "Social Issues, Ethics," + vbCrLf + "and Professionalism"
        CPS310CO.CourseName.Text = "Computer Org I"
        CPS213CO.CourseName.Text = "Computer Org II"
        CPS209CO.CourseName.Text = "Computer" + vbCrLf + "Science II"
        CPS109CO.CourseName.Text = "Computer" + vbCrLf + "Science I"
        LL2CO.CourseName.Text = ""
        LL1CO.CourseName.Text = ""
        PCS110CO.CourseCode.Text = "Physics"

        MTH110CO.updateState("fail")
        MTH207CO.BackColor = complete
        CPS109CO.BackColor = complete
        CPS209CO.BackColor = complete
        CPS213CO.BackColor = complete
        CPS310CO.BackColor = complete
        CPS412CO.BackColor = complete
        LL1CO.BackColor = complete
        LL2CO.BackColor = complete
        PCS110CO.BackColor = complete
    End Sub

    Sub LoadSecondYear()
        CPS406CO.CourseName.TextAlign = ContentAlignment.MiddleCenter
        MTH108CO.CourseCode.Text = "MTH108"
        CMN300CO.CourseCode.Text = "CMN300"
        CPS305CO.CourseCode.Text = "CPS305"
        CPS393CO.CourseCode.Text = "CPS393"
        CPS420CO.CourseCode.Text = "CPS420"
        CPS406CO.CourseCode.Text = "CPS406"
        CPS506CO.CourseCode.Text = "CPS506"
        CPS590CO.CourseCode.Text = "CPS590"
        OE1CO.CourseCode.Text = "Open Elective 1"
        OE2CO.CourseCode.Text = "Open Elective 2"

        MTH108CO.CourseName.Text = "Linear Algebra"
        CMN300CO.CourseName.Text = "Communications in" + vbCrLf + "Comp. Industry"
        CPS305CO.CourseName.Text = "Data Structures"
        CPS393CO.CourseName.Text = "C and UNIX"
        CPS420CO.CourseName.Text = "Discrete Structures"
        CPS406CO.CourseName.Text = "Software Engineering"
        CPS506CO.CourseName.Text = "Comparative Prog" + vbCrLf + "Languages"
        CPS590CO.CourseName.Text = "Operating Systems I"
        OE1CO.CourseName.Text = ""
        OE2CO.CourseName.Text = ""

        MTH108CO.BackColor = enrolled
        CMN300CO.BackColor = enrolled
        CPS305CO.BackColor = enrolled
        CPS393CO.BackColor = enrolled
        CPS420CO.updateState("close")
        CPS406CO.BackColor = enrolled
        CPS506CO.BackColor = enrolled
        CPS590CO.BackColor = enrolled
        OE1CO.updateState("open")
        OE2CO.updateState("open")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Year1OpenButton.Click
        Year1Panel.Visible = True
        Year1CloseButton.Visible = True
        Year1OpenButton.Visible = False
        Y2BigPanel.Location = Year2InitLoc
        Y3Y4Panel.Location = New Point(Y3Y4Panel.Location.X, Y3Y4Panel.Location.Y + break + Year1Panel.Height)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Year2OpenButton.Click
        Year2Panel.Visible = True
        Year2CloseButton.Visible = True
        Year2OpenButton.Visible = False
        Y3Y4Panel.Location = New Point(Y3Y4Panel.Location.X, Y3Y4Panel.Location.Y + break + Year2Panel.Height)
    End Sub

    Private Sub CloseYear1Button_Click(sender As Object, e As EventArgs) Handles Year1CloseButton.Click
        closeYear1()
    End Sub

    Private Sub CloseYear2Button_Click(sender As Object, e As EventArgs) Handles Year2CloseButton.Click
        closeYear2()
    End Sub

    Sub closeYear1()
        Year1Panel.Visible = False
        Year1OpenButton.Visible = True
        Year1CloseButton.Visible = False
        Y2BigPanel.Location = New Point(Y2BigPanel.Location.X, Year1Panel.Location.Y)
        Y3Y4Panel.Location = New Point(Y3Y4Panel.Location.X, Y3Y4Panel.Location.Y - break - Year1Panel.Height)
    End Sub

    Sub closeYear2()
        Year2Panel.Visible = False
        Year2CloseButton.Visible = False
        Year2OpenButton.Visible = True
        Y3Y4Panel.Location = New Point(Y3Y4Panel.Location.X, Y3Y4Panel.Location.Y - break - Year2Panel.Height)
    End Sub
End Class
