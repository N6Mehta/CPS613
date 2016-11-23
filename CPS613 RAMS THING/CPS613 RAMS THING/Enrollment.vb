Public Class EnrollementForm
    Dim Year2InitLoc As Point
    Dim break = 5
    Dim Year1Opened As Boolean = False
    Dim Year2Opened As Boolean = False
    Dim Year3Opened As Boolean = False
    Private searchWindow As CourseSearch

    Private Sub Enrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        LoadFirstYear()
        LoadSecondYear()
        LoadThirdYear()
        Year2InitLoc = Y2BigPanel.Location
        closeYear1()
        closeYear2()
        closeYear3()
    End Sub

    Sub LoadFirstYear()
        MTH110CO.Course_Code = "MTH110"
        MTH207CO.Course_Code = "MTH207"
        CPS209CO.Course_Code = "CPS209"
        CPS213CO.Course_Code = "CPS213"
        CPS310CO.Course_Code = "CPS310"
        CPS412CO.Course_Code = "CPS412"
        CPS109CO.Course_Code = "CPS109"
        LL1CO.Course_Code = "PSY105"
        LL2CO.Course_Code = "PSY304"
        PCS110CO.Course_Code = "PCS110"


        MTH110CO.Course_Name = "Discrete Math I"
        MTH207CO.Course_Name = "Calc and Comp." + vbCrLf + "Methods I"
        CPS412CO.Course_Name = "Social Issues," + vbCrLf + "Ethics..."
        CPS310CO.Course_Name = "Computer Org II"
        CPS213CO.Course_Name = "Computer Org I"
        CPS209CO.Course_Name = "Computer" + vbCrLf + "Science II"
        CPS109CO.Course_Name = "Computer" + vbCrLf + "Science I"
        LL2CO.Course_Name = "Perspectives in" + vbCrLf + "Psychology"
        LL1CO.Course_Name = "Psychology of" + vbCrLf + "Gender"
        PCS110CO.Course_Name = "Physics"

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

        MTH110CO.Course_Type = CourseObject.CourseType.Mandatory
        MTH207CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS109CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS209CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS213CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS310CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS412CO.Course_Type = CourseObject.CourseType.Mandatory
        PCS110CO.Course_Type = CourseObject.CourseType.Mandatory
        LL1CO.Course_Type = CourseObject.CourseType.Liberal
        LL2CO.Course_Type = CourseObject.CourseType.Liberal

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

        CPS209CO.Pre_Requisite = "CPS109"
        CPS310CO.Pre_Requisite = "CPS213"

    End Sub

    Sub LoadSecondYear()
        MTH108CO.Course_Code = "MTH108"
        CMN300CO.Course_Code = "CMN300"
        CPS305CO.Course_Code = "CPS305"
        CPS393CO.Course_Code = "CPS393"
        CPS420CO.Course_Code = "CPS420"
        CPS406CO.Course_Code = "CPS406"
        CPS506CO.Course_Code = "CPS506"
        CPS590CO.Course_Code = "CPS590"
        OE1CO.Course_Code = "Open Elective"
        OE2CO.Course_Code = "Open Elective"

        MTH108CO.Course_Name = "Linear Algebra"
        CMN300CO.Course_Name = "Cmn in" + vbCrLf + "Comp. Industry"
        CPS305CO.Course_Name = "Data Structures"
        CPS393CO.Course_Name = "C and UNIX"
        CPS420CO.Course_Name = "Discrete" + vbCrLf + "Structures"
        CPS406CO.Course_Name = "Software" + vbCrLf + "Engineering"
        CPS506CO.Course_Name = "Comparative" + vbCrLf + "Prog Languages"
        CPS590CO.Course_Name = "Operating" + vbCrLf + "Systems I"
        OE1CO.Course_Name = ""
        OE2CO.Course_Name = ""

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

        MTH108CO.Course_Type = CourseObject.CourseType.Mandatory
        CMN300CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS305CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS393CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS420CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS506CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS590CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS406CO.Course_Type = CourseObject.CourseType.Mandatory
        OE1CO.Course_Type = CourseObject.CourseType.Open_Elective
        OE2CO.Course_Type = CourseObject.CourseType.Open_Elective

        CPS305CO.Pre_Requisite = "CPS209"
        CPS393CO.Pre_Requisite = "CPS109"
        CPS420CO.Pre_Requisite = "MTH110"
        CPS406CO.Pre_Requisite = "CPS209"
        CPS506CO.Pre_Requisite = "CPS209"
        CPS590CO.Pre_Requisite = "CPS305, CPS393"
    End Sub

    Sub LoadThirdYear()
        Y3S1PRCO.Course_Code = "Professionally" + vbCrLf + "Related"
        Y3S2PR1CO.Course_Code = "Professionally" + vbCrLf + "Related"
        Y3S2PR2CO.Course_Code = "Professionally" + vbCrLf + "Related"
        CPS616CO.Course_Code = "CPS616"
        CPS633CO.Course_Code = "CPS633"
        CPS706CO.Course_Code = "CPS706"
        CPS721CO.Course_Code = "CPS721"
        CPS510CO.Course_Code = "CPS510"
        UL1CO.Course_Code = "Upper Liberal"
        LL3CO.Course_Code = "Lower Liberal"

        Y3S1PRCO.Course_Name = ""
        Y3S2PR1CO.Course_Name = ""
        Y3S2PR2CO.Course_Name = ""
        CPS616CO.Course_Name = "Algorithms"
        CPS633CO.Course_Name = "Computer" + vbCrLf + "Security"
        CPS706CO.Course_Name = "Networks I"
        CPS721CO.Course_Name = "Artificial" + vbCrLf + "Intelligence"
        CPS510CO.Course_Name = "Databases I"
        UL1CO.Course_Name = ""
        LL3CO.Course_Name = ""

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

        Y3S1PRCO.Course_Type = CourseObject.CourseType.Pro_Related
        Y3S2PR1CO.Course_Type = CourseObject.CourseType.Pro_Related
        Y3S2PR2CO.Course_Type = CourseObject.CourseType.Pro_Related
        CPS616CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS633CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS706CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS721CO.Course_Type = CourseObject.CourseType.Mandatory
        CPS510CO.Course_Type = CourseObject.CourseType.Mandatory
        UL1CO.Course_Type = CourseObject.CourseType.Liberal
        LL3CO.Course_Type = CourseObject.CourseType.Liberal

        Y3S1PRCO.Pre_Requisite = ""
        Y3S2PR1CO.Pre_Requisite = ""
        Y3S2PR2CO.Pre_Requisite = ""
        CPS616CO.Pre_Requisite = "CPS420, CPS305"
        CPS633CO.Pre_Requisite = "CPS393"
        CPS706CO.Pre_Requisite = "CPS590"
        CPS721CO.Pre_Requisite = "CPS420, CPS305"
        CPS510CO.Pre_Requisite = "CPS305"
        UL1CO.Pre_Requisite = ""
        LL3CO.Pre_Requisite = ""

        'Y3S1PRCO
        'Y3S2PR1CO
        'Y3S2PR2CO
        'CPS616CO
        'CPS633CO
        'CPS706CO
        'CPS721CO
        'CPS510CO
        'UL1CO
        'LL3CO
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

    Private Sub CloseYear1Button_Click(sender As Object, e As EventArgs) Handles Year1CloseButton.Click
        closeYear1()
    End Sub

    Private Sub CloseYear2Button_Click(sender As Object, e As EventArgs) Handles Year2CloseButton.Click
        closeYear2()
    End Sub

    Private Sub Year3CloseButton_Click(sender As Object, e As EventArgs) Handles Year3CloseButton.Click
        closeYear3()
    End Sub

    Sub openYear1()
        Year1Opened = True
        Year1Panel.Visible = True
        Year1CloseButton.Visible = True
        Year1OpenButton.Visible = False
        Y2BigPanel.Location = Year2InitLoc
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y + break + Year1Panel.Height)
    End Sub

    Sub openYear2()
        Year2Opened = True
        Year2Panel.Visible = True
        Year2CloseButton.Visible = True
        Year2OpenButton.Visible = False
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y + break + Year2Panel.Height)
    End Sub

    Sub openYear3()
        Year3Opened = True
        Year3Panel.Visible = True
        Year3CloseButton.Visible = True
        Year3OpenButton.Visible = False
    End Sub

    Sub closeYear1()
        Year1Opened = False
        Year1Panel.Visible = False
        Year1OpenButton.Visible = True
        Year1CloseButton.Visible = False
        Y2BigPanel.Location = New Point(Y2BigPanel.Location.X, Year1Panel.Location.Y)
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y - break - Year1Panel.Height)
    End Sub

    Sub closeYear2()
        Year2Opened = False
        Year2Panel.Visible = False
        Year2CloseButton.Visible = False
        Year2OpenButton.Visible = True
        Year3BigPanel.Location = New Point(Year3BigPanel.Location.X, Year3BigPanel.Location.Y - Year2Panel.Height - break)
        Year3BigPanel.BringToFront()
    End Sub

    Sub closeYear3()
        Year3Opened = False
        Year3Panel.Visible = False
        Year3CloseButton.Visible = False
        Year3OpenButton.Visible = True
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
        Minors.Show()
    End Sub
End Class