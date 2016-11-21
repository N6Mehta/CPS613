Public Class CourseObject
    Private prevName As String
    Private pre_rec As String

    Shared selectedCourse As CourseObject

    Private searchWindow As CourseSearch
    Public grade As Double

    Public Enum State
        open
        closed
        passed
        failed
        enrolled
    End Enum

    Private courseState As State

    Private Sub CourseObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.grade = 0.0
        Me.prevName = Me.CourseName.Text

        Me.changeState(State.open)
    End Sub
    'Called my the main form class
    Public Sub initialize()
        Me.changeState(State.open)
        Me.grade = 0.0
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        searchWindow = New CourseSearch
        searchWindow.connectCourse(Me)
        searchWindow.Show()
        Me.CourseName.Text = searchWindow.course.CourseName.Text
        Me.changeState(State.enrolled)
    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        Dim msgResult As DialogResult = MessageBox.Show("Are you sure you want to drop " + Me.CourseName.Text + "?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgResult = DialogResult.Yes Then
            Me.changeState(State.open)
            Me.CourseName.Text = prevName
            Me.CourseCode.Text = "Course Course"
            Me.grade = 0.0
        End If
    End Sub

    Private Sub CourseObject_Click(sender As Object, e As EventArgs) Handles Me.Click, CourseName.Click, CourseCode.Click
        MessageBox.Show("Course Name: " + Course_Code + " " + Course_Name + vbNewLine + "Grade: " + Course_Grade.ToString + vbNewLine + "Pre-requisite: " + Pre_Requisite, "Course Info")
    End Sub

    Public Sub changeState(state As State)
        If state.Equals(State.open) Then
            Me.AddButton.Enabled = True
            Me.DropButton.Enabled = False
            Me.BackColor = Color.SkyBlue
        ElseIf state.Equals(State.passed) Then
            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = False
            Me.BackColor = Color.LimeGreen
        ElseIf state.Equals(State.failed) Then
            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = False
            Me.BackColor = Color.IndianRed
        ElseIf state.Equals(State.closed) Then
            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = False
            Me.BackColor = Color.DarkGray
        ElseIf state.Equals(State.enrolled) Then
            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = True
            Me.BackColor = Color.Gold
        Else
            MsgBox("Incorrect State")
            Me.BackColor = Color.DarkGray
        End If
    End Sub

    Public Property Course_Name As String
        Get
            Return Me.CourseName.Text
        End Get
        Set(value As String)
            Me.CourseName.Text = value
        End Set
    End Property

    Public Property Course_Code As String
        Get
            Return Me.CourseCode.Text
        End Get
        Set(value As String)
            Me.CourseCode.Text = value
        End Set
    End Property

    Public Property Course_Grade As Double
        Get
            Return Me.grade
        End Get
        Set(value As Double)
            Me.grade = value
        End Set
    End Property

    Public Property Pre_Requisite As String
        Get
            Return pre_rec
        End Get
        Set(value As String)
            pre_rec = value
        End Set
    End Property



    Public Sub connectSearch(search As CourseSearch)
        Me.searchWindow = search
    End Sub
End Class
