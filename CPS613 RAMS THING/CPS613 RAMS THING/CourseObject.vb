Public Class CourseObject
    Private failedCourse As Boolean
    Private passedCourse As Boolean
    Private openCourse As Boolean
    Private closedCourse As Boolean
    Private enrolledCourse As Boolean

    Shared selectedCourse As CourseObject

    Private searchWindow As CourseSearch
    Private grade As Double

    Private Sub CourseObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.updateState("open")
        Me.grade = 0.0
    End Sub
    'Called my the main form class
    Public Sub initialize()
        Me.updateState("open")
        Me.grade = 0.0
        Me.openCourse = True
        Me.updateColor()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        searchWindow = New CourseSearch
        searchWindow.Show()
        CourseName.Text = searchWindow.courseSelected
    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        Dim msgResult As DialogResult = MessageBox.Show("Are you sure you want to drop " + Me.CourseCode.Text + Me.CourseName.Text, "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgResult = DialogResult.Yes Then
            Me.updateState("open")
            Me.CourseName.Text = "Course Name"
            Me.CourseCode.Text = "Course Course"
            Me.grade = 0.0
        End If
    End Sub

    Private Sub CourseObject_Click(sender As Object, e As EventArgs) Handles Me.Click, CourseName.Click, CourseCode.Click
        MessageBox.Show("Course Name: " + Me.CourseCode.Text + " " + Me.CourseName.Text + vbNewLine + "Grade: " + Me.grade.ToString, "Course Info")
    End Sub

    Public Sub updateState(state As String)
        If state.Equals("open") Then
            openCourse = True
            passedCourse = False
            failedCourse = False
            closedCourse = False
            enrolledCourse = False


            Me.AddButton.Enabled = True
            Me.DropButton.Enabled = False

            Me.updateColor()
        ElseIf state.Equals("pass") Then
            passedCourse = True
            openCourse = False
            failedCourse = False
            closedCourse = False
            enrolledCourse = False


            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = False

            Me.updateColor()

        ElseIf state.Equals("fail") Then
            failedCourse = True
            openCourse = False
            passedCourse = False
            closedCourse = False
            enrolledCourse = False


            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = False

            Me.updateColor()

        ElseIf state.Equals("close") Then
            closedCourse = True
            openCourse = False
            passedCourse = False
            failedCourse = False
            enrolledCourse = False


            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = False

            Me.updateColor()
        ElseIf state.Equals("enroll") Then
            enrolledCourse = True
            closedCourse = False
            openCourse = False
            passedCourse = False
            failedCourse = False

            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = True

            Me.updateColor()

        Else
            MsgBox("Incorrect State")
        End If
    End Sub
    Private Sub updateColor()
        If passedCourse Then
            Me.BackColor = Color.LimeGreen
        ElseIf failedCourse Then
            Me.BackColor = Color.IndianRed
        ElseIf openCourse Then
            Me.BackColor = Color.SkyBlue
        ElseIf closedCourse Then
            Me.BackColor = Color.DarkGray
        ElseIf enrolledCourse Then
            Me.BackColor = Color.Gold
        Else
            Me.BackColor = Color.LightGray
        End If
    End Sub
End Class
