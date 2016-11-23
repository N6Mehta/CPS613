Public Class PsyCourses
    Private Sub PsyCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PSY105CO.changeState(CourseObject.State.passed)
        PSY304CO.changeState(CourseObject.State.passed)
    End Sub
End Class