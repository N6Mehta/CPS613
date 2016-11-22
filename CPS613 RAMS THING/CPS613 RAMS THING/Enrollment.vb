Public Class EnrollementForm
    Dim Year2InitLoc As Point
    Dim Y3Y4InitLoc As Point
    Dim break = 15
    Dim Year1Opened As Boolean = False
    Dim Year2Opened As Boolean = False

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        My.Forms.Help.Show()
    End Sub

    Private Sub Enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadFirstYear()
        LoadSecondYear()
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
        MTH207CO.CourseName.Text = "Calc and Comp." + vbCrLf + "Methods I"
        CPS412CO.CourseName.Text = "Social Issues," + vbCrLf + "Ethics..."
        CPS310CO.CourseName.Text = "Computer Org II"
        CPS213CO.CourseName.Text = "Computer Org I"
        CPS209CO.CourseName.Text = "Computer" + vbCrLf + "Science II"
        CPS109CO.CourseName.Text = "Computer" + vbCrLf + "Science Iiiii"
        LL2CO.CourseName.Text = ""
        LL1CO.CourseName.Text = ""
        PCS110CO.CourseName.Text = "Physics"

        MTH110CO.changeState(CourseObject.State.failed)
        MTH207CO.changeState(CourseObject.State.passed)
        CPS109CO.changeState(CourseObject.State.passed)
        CPS209CO.changeState(CourseObject.State.passed)
        CPS213CO.changeState(CourseObject.State.passed)
        CPS310CO.changeState(CourseObject.State.passed)
        CPS412CO.changeState(CourseObject.State.passed)
        LL1CO.changeState(CourseObject.State.passed)
        LL2CO.changeState(CourseObject.State.passed)
        PCS110CO.changeState(CourseObject.State.passed)

        MTH207CO.grade = 3.27
        CPS109CO.grade = 3.0
        CPS209CO.grade = 2.67
        CPS213CO.grade = 3.67
        CPS310CO.grade = 3.27
        CPS412CO.grade = 3.0
        PCS110CO.grade = 3.27
        LL1CO.grade = 2.27
        LL2CO.grade = 3.33
        MTH110CO.grade = 1.27
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
        CMN300CO.CourseName.Text = "Cmn in" + vbCrLf + "Comp. Industry"
        CPS305CO.CourseName.Text = "Data Structures"
        CPS393CO.CourseName.Text = "C and UNIX"
        CPS420CO.CourseName.Text = "Discrete" + vbCrLf + "Structures"
        CPS406CO.CourseName.Text = "Software" + vbCrLf + "Engineering"
        CPS506CO.CourseName.Text = "Comparative" + vbCrLf + "Prog Languages"
        CPS590CO.CourseName.Text = "Operating" + vbCrLf + "Systems I"
        OE1CO.CourseName.Text = ""
        OE2CO.CourseName.Text = ""

        MTH108CO.changeState(CourseObject.State.enrolled)
        CMN300CO.changeState(CourseObject.State.enrolled)
        CPS305CO.changeState(CourseObject.State.enrolled)
        CPS393CO.changeState(CourseObject.State.enrolled)
        CPS420CO.changeState(CourseObject.State.closed)
        CPS406CO.changeState(CourseObject.State.enrolled)
        CPS506CO.changeState(CourseObject.State.enrolled)
        CPS590CO.changeState(CourseObject.State.enrolled)
        OE1CO.changeState(CourseObject.State.open)
        OE2CO.changeState(CourseObject.State.open)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Year1OpenButton.Click
        openYear1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Year2OpenButton.Click
        openYear2()
    End Sub

    Private Sub CloseYear1Button_Click(sender As Object, e As EventArgs) Handles Year1CloseButton.Click
        closeYear1()
    End Sub

    Private Sub CloseYear2Button_Click(sender As Object, e As EventArgs) Handles Year2CloseButton.Click
        closeYear2()
    End Sub

    Sub openYear1()
        Year1Opened = True
        Year1Panel.Visible = True
        Year1CloseButton.Visible = True
        Year1OpenButton.Visible = False
        Y2BigPanel.Location = Year2InitLoc
        Y3Y4Panel.Location = New Point(Y3Y4Panel.Location.X, Y3Y4Panel.Location.Y + break + Year1Panel.Height)
    End Sub

    Sub openYear2()
        Year2Opened = True
        Year2Panel.Visible = True
        Year2CloseButton.Visible = True
        Year2OpenButton.Visible = False
        Y3Y4Panel.Location = New Point(Y3Y4Panel.Location.X, Y3Y4Panel.Location.Y + break + Year2Panel.Height)
    End Sub

    Sub closeYear1()
        Year1Opened = False
        Year1Panel.Visible = False
        Year1OpenButton.Visible = True
        Year1CloseButton.Visible = False
        Y2BigPanel.Location = New Point(Y2BigPanel.Location.X, Year1Panel.Location.Y)
        Y3Y4Panel.Location = New Point(Y3Y4Panel.Location.X, Y3Y4Panel.Location.Y - break - Year1Panel.Height)
    End Sub

    Sub closeYear2()
        Year2Opened = False
        Year2Panel.Visible = False
        Year2CloseButton.Visible = False
        Year2OpenButton.Visible = True
        Y3Y4Panel.Location = New Point(Y3Y4Panel.Location.X, Y3Y4Panel.Location.Y - break - Year2Panel.Height)
    End Sub

    Private Sub Year1Label_Click(sender As Object, e As EventArgs) Handles Year1Label.Click
        If Year1Opened Then
            closeYear1()
        Else openYear1()
        End If
    End Sub

    Private Sub Year2Label_Click(sender As Object, e As EventArgs) Handles Year2Label.Click
        If Year2Opened Then
            closeYear2()
        Else openYear2()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class