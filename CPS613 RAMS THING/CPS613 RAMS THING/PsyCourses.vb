Public Class PsyCourses
    Private myEnroll As EnrollementForm
    Private Sub PsyCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myEnroll.connectToPSYMinor(Me)
        PSY105CO.changeState(CourseObject.State.passed)
        PSY304CO.changeState(CourseObject.State.passed)
    End Sub

    Private Sub CancelMinorButton_Click(sender As Object, e As EventArgs) Handles CancelMinorButton.Click
        Me.Hide()
        Minors.Show()
    End Sub

    Private Sub DoneMinorButton_Click(sender As Object, e As EventArgs) Handles DoneMinorButton.Click
        If (PSY202CO.courseState.Equals(CourseObject.State.enrolled)) Then
            myEnroll.OE1CO.Course_Name = PSY202CO.Course_Name
            myEnroll.OE1CO.Course_Code = PSY202CO.Course_Code
            myEnroll.OE1CO.changeState(CourseObject.State.enrolled)
        ElseIf (PSY124CO.courseState.Equals(CourseObject.State.enrolled)) Then
            myEnroll.OE1CO.Course_Name = PSY124CO.Course_Name
            myEnroll.OE1CO.Course_Code = PSY124CO.Course_Code
            myEnroll.OE1CO.changeState(CourseObject.State.enrolled)
        ElseIf (PSY325CO.courseState.Equals(CourseObject.State.enrolled)) Then
            myEnroll.OE1CO.Course_Name = PSY325CO.Course_Name
            myEnroll.OE1CO.Course_Code = PSY325CO.Course_Code
            myEnroll.OE1CO.changeState(CourseObject.State.enrolled)
        ElseIf (PSY504CO.courseState.Equals(CourseObject.State.enrolled)) Then
            myEnroll.OE1CO.Course_Name = PSY504CO.Course_Name
            myEnroll.OE1CO.Course_Code = PSY504CO.Course_Code
            myEnroll.OE1CO.changeState(CourseObject.State.enrolled)
        ElseIf (PSY209CO.courseState.Equals(CourseObject.State.enrolled)) Then
            myEnroll.OE2CO.Course_Name = PSY209CO.Course_Name
            myEnroll.OE2CO.Course_Code = PSY209CO.Course_Code
            myEnroll.OE2CO.changeState(CourseObject.State.enrolled)
        ElseIf (PSY217CO.courseState.Equals(CourseObject.State.enrolled)) Then
            myEnroll.OE2CO.Course_Name = PSY217CO.Course_Name
            myEnroll.OE2CO.Course_Code = PSY217CO.Course_Code
            myEnroll.OE2CO.changeState(CourseObject.State.enrolled)
        Else Minors.Show()
        End If
        Me.Hide()
    End Sub

    Public Sub connectToEnroll(page As EnrollementForm)
        Me.myEnroll = page
    End Sub
End Class