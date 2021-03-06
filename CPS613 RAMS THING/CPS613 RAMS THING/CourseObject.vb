﻿Public Class CourseObject
    Private defName As String
    Private defCode As String
    Private pre_rec As String
    Shared selectedCourse As CourseObject
    Private searchWindow As CourseSearch
    Private type As CourseType
    Public grade As Double

    Public Enum CourseType
        Liberal
        Mandatory
        Open_Elective
        Pro_Related
        No_Type
        PSY
    End Enum
    Public Enum State
        open
        closed
        passed
        failed
        enrolled
    End Enum

    Public courseState As State

    Private Sub CourseObject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.grade = 0.0
        Me.changeState(State.open)
        Me.Course_Code = CourseCode.Text
        Me.Course_Name = CourseName.Text
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        searchWindow = New CourseSearch
        searchWindow.connectCourse(Me)
        searchWindow.Show()
        If Me.type.Equals(CourseType.PSY) Then
        Else
            Course_Code = searchWindow.course.CourseCode.Text
            Course_Name = searchWindow.course.CourseName.Text
        End If



    End Sub

    Private Sub DropButton_Click(sender As Object, e As EventArgs) Handles DropButton.Click
        Dim msgResult As DialogResult = MessageBox.Show("Are you sure you want to drop " + Course_Code + ": " + Course_Name + "?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If msgResult = DialogResult.Yes Then
            Me.reset()
        End If
    End Sub

    Private Sub CourseObject_Click(sender As Object, e As EventArgs) Handles Me.Click, CourseName.Click, CourseCode.Click
        MessageBox.Show("Course Name: " + Course_Code + " " + Course_Name + vbNewLine + "Grade: " + Course_Grade.ToString + vbNewLine + "Pre-requisite: " + Pre_Requisite, "Course Info")
    End Sub

    Public Sub changeState(state As State)
        If state.Equals(State.open) Then
            Me.Cursor = Cursors.Help
            Me.AddButton.Enabled = True
            Me.DropButton.Enabled = False
            Me.BackColor = Color.SkyBlue
            Me.AddButton.Cursor = Cursors.Hand
            Me.DropButton.Cursor = Cursors.No
            Me.courseState = state
        ElseIf state.Equals(State.passed) Then
            Me.Cursor = Cursors.Help
            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = False
            Me.BackColor = Color.LimeGreen
            Me.courseState = state

        ElseIf state.Equals(State.failed) Then
            Me.Cursor = Cursors.Help
            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = False
            Me.BackColor = Color.IndianRed
            Me.courseState = state

        ElseIf state.Equals(State.closed) Then
            Me.Cursor = Cursors.Help
            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = True
            Me.BackColor = Color.DarkGray
            Me.DropButton.Cursor = Cursors.Hand
            Me.courseState = state

        ElseIf state.Equals(State.enrolled) Then
            Me.Cursor = Cursors.Help
            Me.AddButton.Enabled = False
            Me.DropButton.Enabled = True
            Me.BackColor = Color.Gold
            Me.AddButton.Cursor = Cursors.Hand
            Me.DropButton.Cursor = Cursors.Hand
            Me.courseState = state

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

    Public Property Course_Type As CourseType
        Get
            Return Me.type
        End Get
        Set(value As CourseType)
            Me.type = value
        End Set
    End Property

    Private Sub reset()
        Me.changeState(State.open)
        updateType()
        Me.CourseCode.Text = defCode
        Me.CourseName.Text = defName
        Me.grade = 0.0
        Me.pre_rec = ""
    End Sub

    Private Sub updateType()
        If type.Equals(CourseType.Liberal) Then
            Me.defCode = "Add Liberal"
            Me.defName = ""
        ElseIf type.Equals(CourseType.Open_Elective) Then
            Me.defCode = "Add Open Elective"
            Me.defName = ""
        ElseIf type.Equals(CourseType.Mandatory) Then
            Me.defCode = "Add Mandatory "
            Me.defName = ""
        ElseIf type.Equals(CourseType.Pro_Related) Then
            Me.defCode = "Add Pro-Related"
            Me.defName = ""
        ElseIf type.Equals(CourseType.No_Type) Then
            Me.defCode = "Add Course"
            Me.defName = ""

        End If

    End Sub

    Public Sub connectSearch(search As CourseSearch)
        Me.searchWindow = search
    End Sub
End Class
