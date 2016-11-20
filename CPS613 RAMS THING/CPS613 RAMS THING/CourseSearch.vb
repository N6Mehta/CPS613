Public Class CourseSearch
    Public courseSelected As String
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

    End Sub

    Public Sub MCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MCheckBox.CheckedChanged
        courseSelected = MCheckBox.Text
    End Sub

    Private Sub doneButton_Click(sender As Object, e As EventArgs) Handles doneButton.Click
        course.CourseName.Text = courseSelected
        Me.Close()
    End Sub

    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        If searchTextBox.Text = "MTH110" Then
            MCheckBox.Visible = True
            MdesLabel.Visible = True
            MtimeLabel.Visible = True
            MroomLabel.Visible = True
            MunitLabel.Visible = True
            MPictureBox.Visible = True
            CheckBox4.Checked = True
        ElseIf searchTextBox.Text = "PSY202" Then
            P2CheckBox.Visible = True
            P2desLabel.Visible = True
            P2timeLabel.Visible = True
            P2roomLabel.Visible = True
            P2unitLabel.Visible = True
            P2PictureBox.Visible = True
        ElseIf searchTextBox.Text = "PSY214" Then
            P4CheckBox.Visible = True
            P4desLabel.Visible = True
            P4timeLabel.Visible = True
            P4roomLabel.Visible = True
            P4unitLabel.Visible = True
            P4PictureBox.Visible = True
        ElseIf searchTextBox.Text = "PSY" Then
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
        End If
    End Sub

    Private Sub P2CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles P2CheckBox.CheckedChanged
        courseSelected = P2CheckBox.Text
    End Sub

    Private Sub P4CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles P4CheckBox.CheckedChanged
        courseSelected = P4CheckBox.Text
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Public Sub connectCourse(newCourse As CourseObject)
        Me.course = newCourse
    End Sub

End Class