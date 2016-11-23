Public Class EnrollementForm
    Dim Year2InitLoc As Point
    Dim break = 5
    Dim Year1Opened As Boolean = False
    Dim Year2Opened As Boolean = False
    Dim Year3Opened As Boolean = False
    Dim Year4Opened As Boolean = False

    Public psy_minor As PsyCourses
    Private minorPage As Minors
    Private searchWindow As CourseSearch

    Private Sub Enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadFirstYear()
        LoadSecondYear()
        LoadThirdYear()
        Year2InitLoc = Y2BigPanel.Location
        closeYear3()
        closeYear4()
    End Sub

    Sub LoadFirstYear()

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

        MTH207CO.Course_Grade = 3.27
        CPS109CO.Course_Grade = 3.0
        CPS209CO.Course_Grade = 2.67
        CPS213CO.Course_Grade = 3.67
        CPS310CO.Course_Grade = 3.27
        CPS412CO.Course_Grade = 3.0
        PCS110CO.Course_Grade = 3.27
        LL1CO.Course_Grade = 2.27
        LL2CO.Course_Grade = 3.33
        MTH110CO.Course_Grade = 1.27

    End Sub

    Sub LoadSecondYear()

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

    Sub LoadThirdYear()
        Y3S1PRCO.changeState(CourseObject.State.open)
        Y3S2PR1CO.changeState(CourseObject.State.open)
        Y3S2PR2CO.changeState(CourseObject.State.open)
        CPS616CO.changeState(CourseObject.State.closed)
        CPS633CO.changeState(CourseObject.State.closed)
        CPS706CO.changeState(CourseObject.State.closed)
        CPS721CO.changeState(CourseObject.State.closed)
        CPS510CO.changeState(CourseObject.State.closed)
        UL1CO.changeState(CourseObject.State.open)
        LL3CO.changeState(CourseObject.State.open)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Year1OpenButton.Click
        openYear1()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Year2OpenButton.Click
        openYear2()
    End Sub

    Private Sub Year3OpenButton_Click(sender As Object, e As EventArgs) Handles Year3OpenButton.Click
        openYear3()
    End Sub

    Private Sub Year4OpenButton_Click(sender As Object, e As EventArgs) Handles Year4OpenButton.Click
        openYear4()
    End Sub

    Private Sub CloseYear1Button_Click(sender As Object, e As EventArgs) Handles Year1CloseButton.Click
        closeYear1()
    End Sub

    Private Sub CloseYear2Button_Click(sender As Object, e As EventArgs) Handles Year2CloseButton.Click
        closeYear2()
    End Sub

    Private Sub Year3CloseButton_Click(sender As Object, e As EventArgs) Handles Year3CloseButton.Click
        closeYear3()
    End Sub

    Private Sub Year4CloseButton_Click(sender As Object, e As EventArgs) Handles Year4CloseButton.Click
        closeYear4()
    End Sub

    Sub openYear1()
        Year1Opened = True
        Year1Panel.Visible = True
        Year1CloseButton.Visible = True
        Year1OpenButton.Visible = False
        Y2BigPanel.Location = Year2InitLoc
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y + Year1Panel.Height)
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y + Year1Panel.Height)
    End Sub

    Sub openYear2()
        Year2Opened = True
        Year2Panel.Visible = True
        Year2CloseButton.Visible = True
        Year2OpenButton.Visible = False
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y + Year2Panel.Height)
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y + Year2Panel.Height)
    End Sub

    Sub openYear3()
        Year3Opened = True
        Year3Panel.Visible = True
        Year3CloseButton.Visible = True
        Year3OpenButton.Visible = False
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y + Year3Panel.Height)
    End Sub

    Sub openYear4()
        Year4Opened = True
        Year4Panel.Visible = True
        Year4CloseButton.Visible = True
        Year4OpenButton.Visible = False
    End Sub

    Sub closeYear1()
        Year1Opened = False
        Year1Panel.Visible = False
        Year1OpenButton.Visible = True
        Year1CloseButton.Visible = False
        Y2BigPanel.Location = New Point(Y2BigPanel.Location.X, Year1Panel.Location.Y)
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y - Year1Panel.Height)
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y - Year1Panel.Height)
    End Sub

    Sub closeYear2()
        Year2Opened = False
        Year2Panel.Visible = False
        Year2CloseButton.Visible = False
        Year2OpenButton.Visible = True
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y - Year2Panel.Height)
        Year3BigPanel.BringToFront()
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y - Year2Panel.Height)
        Year4BigPanel.BringToFront()
    End Sub

    Sub closeYear3()
        Year3Opened = False
        Year3Panel.Visible = False
        Year3CloseButton.Visible = False
        Year3OpenButton.Visible = True
        Year4BigPanel.Location = New Point(Year4BigPanel.Location.X, Year4BigPanel.Location.Y - Year3Panel.Height)
        Year4BigPanel.BringToFront()
    End Sub

    Sub closeYear4()
        Year4Opened = False
        Year4Panel.Visible = False
        Year4CloseButton.Visible = False
        Year4OpenButton.Visible = True
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

    Private Sub Year3Label_Click(sender As Object, e As EventArgs) Handles Year3Label.Click
        If Year3Opened Then
            closeYear3()
        Else openYear3()
        End If
    End Sub

    Private Sub Year4Label_Click(sender As Object, e As EventArgs) Handles Year4Label.Click
        If Year4Opened Then
            closeYear4()
        Else openYear4()
        End If
    End Sub

    Private Sub Y2S1AddButton_Click(sender As Object, e As EventArgs) Handles Y2S1AddButton.Click
        searchWindow = New CourseSearch
        searchWindow.connectCourse(Y2S16thCO)
        searchWindow.Show()
        Y2S16thCO.Visible = True
        Y2S16thCO.CourseName.Text = searchWindow.course.CourseName.Text
        Y2S16thCO.changeState(CourseObject.State.enrolled)
        Y2S16thCO.Location = New Point(Y2S1AddButton.Location.X, MTH108CO.Location.Y)
        Y2S1AddButton.Visible = False
    End Sub

    Private Sub Y2S2AddButton_Click(sender As Object, e As EventArgs) Handles Y2S2AddButton.Click
        searchWindow = New CourseSearch
        searchWindow.connectCourse(Y2S26thCO)
        searchWindow.Show()
        Y2S26thCO.Visible = True
        Y2S26thCO.CourseName.Text = searchWindow.course.CourseName.Text
        Y2S26thCO.changeState(CourseObject.State.enrolled)
        Y2S26thCO.Location = New Point(Y2S2AddButton.Location.X, OE2CO.Location.Y)
        Y2S2AddButton.Visible = False
    End Sub

    Private Sub MinorsButton_Click(sender As Object, e As EventArgs) Handles MinorsButton.Click
        minorPage = New Minors
        psy_minor = New PsyCourses
        minorPage.connectToEnroll(Me)

        psy_minor.connectToEnroll(Me)
        minorPage.Show()
    End Sub

    Public Sub connectToPSYMinor(page As PsyCourses)
        Me.psy_minor = page
    End Sub

    Public Sub connectToMinor(page As Minors)
        Me.minorPage = page
    End Sub
End Class