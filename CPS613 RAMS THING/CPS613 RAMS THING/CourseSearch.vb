Public Class CourseSearch
    Private courseName As String
    Private courseCode As String

    Public course As CourseObject
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub CourseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        course.connectSearch(Me)
        MCheckBox.Visible = False
        MdesLabel.Visible = False
        MtimeLabel.Visible = False
        MroomLabel.Visible = False
        MunitLabel.Visible = False
        MPictureBox.Visible = False

        P2CheckBox.Visible = False
        P2desLabel.Visible = False
        P2timeLabel.Visible = False
        P2roomLabel.Visible = False
        P2unitLabel.Visible = False
        P2PictureBox.Visible = False

        P4CheckBox.Visible = False
        P4desLabel.Visible = False
        P4timeLabel.Visible = False
        P4roomLabel.Visible = False
        P4unitLabel.Visible = False
        P4PictureBox.Visible = False

        PSY209CB.Visible = False
        P209Desc.Visible = False
        P209Time.Visible = False
        P209Room.Visible = False
        P209Unit.Visible = False
        P209Status.Visible = False
        searchTextBox.Select()



    End Sub

    Public Sub MCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MCheckBox.CheckedChanged
        courseCode = MCheckBox.Text
        courseName = MdesLabel.Text

    End Sub

    Private Sub doneButton_Click(sender As Object, e As EventArgs) Handles doneButton.Click
        course.CourseCode.Text = courseCode
        course.CourseName.Text = courseName
        course.changeState(CourseObject.State.enrolled)
        Me.Close()
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If searchTextBox.Text.ToUpper = "MTH110" Or searchTextBox.Text.ToUpper = "MTH 110" Or searchTextBox.Text.ToUpper = "MTH" Then
            MCheckBox.Visible = True
            MdesLabel.Visible = True
            MtimeLabel.Visible = True
            MroomLabel.Visible = True
            MunitLabel.Visible = True
            MPictureBox.Visible = True
            CheckBox4.Checked = True
        ElseIf searchTextBox.Text.ToUpper = "PSY202" Or searchTextBox.Text.ToUpper = "PSY 202" Then
            P2CheckBox.Visible = True
            P2desLabel.Visible = True
            P2timeLabel.Visible = True
            P2roomLabel.Visible = True
            P2unitLabel.Visible = True
            P2PictureBox.Visible = True
        ElseIf searchTextBox.Text.ToUpper = "PSY214" Or searchTextBox.Text.ToUpper = "PSY 214" Then
            P4CheckBox.Visible = True
            P4desLabel.Visible = True
            P4timeLabel.Visible = True
            P4roomLabel.Visible = True
            P4unitLabel.Visible = True
            P4PictureBox.Visible = True
        ElseIf searchTextBox.Text.ToUpper = "PSY" Then
            P2CheckBox.Visible = True
            P2desLabel.Visible = True
            P2timeLabel.Visible = True
            P2roomLabel.Visible = True
            P2unitLabel.Visible = True
            P2PictureBox.Visible = True
            P4CheckBox.Visible = True
            P4desLabel.Visible = True
            P4timeLabel.Visible = True
            P4roomLabel.Visible = True
            P4unitLabel.Visible = True
            P4PictureBox.Visible = True

            PSY209CB.Visible = True
            P209Desc.Visible = True
            P209Time.Visible = True
            P209Room.Visible = True
            P209Unit.Visible = True
            P209Status.Visible = True
        Else
            MCheckBox.Visible = True
            MdesLabel.Visible = True
            MtimeLabel.Visible = True
            MroomLabel.Visible = True
            MunitLabel.Visible = True
            MPictureBox.Visible = True
            CheckBox4.Checked = True

            P2CheckBox.Visible = True
            P2desLabel.Visible = True
            P2timeLabel.Visible = True
            P2roomLabel.Visible = True
            P2unitLabel.Visible = True
            P2PictureBox.Visible = True

            P4CheckBox.Visible = True
            P4desLabel.Visible = True
            P4timeLabel.Visible = True
            P4roomLabel.Visible = True
            P4unitLabel.Visible = True
            P4PictureBox.Visible = True

            P2CheckBox.Visible = True
            P2desLabel.Visible = True
            P2timeLabel.Visible = True
            P2roomLabel.Visible = True
            P2unitLabel.Visible = True
            P2PictureBox.Visible = True
            P4CheckBox.Visible = True
            P4desLabel.Visible = True
            P4timeLabel.Visible = True
            P4roomLabel.Visible = True
            P4unitLabel.Visible = True
            P4PictureBox.Visible = True

            PSY209CB.Visible = True
            P209Desc.Visible = True
            P209Time.Visible = True
            P209Room.Visible = True
            P209Unit.Visible = True
            P209Status.Visible = True

        End If
    End Sub

    Private Sub SelectCourse(sender As Object, e As EventArgs) Handles P2CheckBox.CheckedChanged, P4CheckBox.CheckedChanged, MCheckBox.CheckedChanged
        Dim tempBox As CheckBox
        tempBox = CType(sender, CheckBox)
        courseCode = tempBox.Text
    End Sub
    Private Sub P2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles P2CheckBox.CheckedChanged
        courseCode = P2CheckBox.Text
        courseName = P2desLabel.Text

    End Sub

    Private Sub P4CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles P4CheckBox.CheckedChanged
        courseCode = P4CheckBox.Text
        courseName = P4desLabel.Text

    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Public Sub connectCourse(newCourse As CourseObject)
        Me.course = newCourse
    End Sub

    Private Sub EnterClick(sender As Object, e As KeyEventArgs) Handles searchTextBox.KeyUp
        If e.KeyCode = Keys.Enter Then
            searchButton_Click(sender, e)
        End If
    End Sub

    Private Sub PSY209CB_CheckedChanged(sender As Object, e As EventArgs) Handles PSY209CB.CheckedChanged
        courseCode = PSY209CB.Text
        courseName = P209Desc.Text
    End Sub
End Class