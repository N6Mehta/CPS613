Public Class PsyCourses
    Private Sub PsyCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PSY105CO.changeState(CourseObject.State.passed)
        PSY304CO.changeState(CourseObject.State.passed)
    End Sub

    Private Sub CancelMinorButton_Click(sender As Object, e As EventArgs) Handles CancelMinorButton.Click
        Me.Hide()
        Minors.Show()
    End Sub

    Private Sub DoneMinorButton_Click(sender As Object, e As EventArgs) Handles DoneMinorButton.Click
        If (PSY202CO.State.enrolled) Then
            EnrollementForm.OE1CO = PSY202CO
        ElseIf PSY124CO.State.enrolled Then
            EnrollementForm.OE1CO = PSY124CO
        ElseIf PSY325CO.State.enrolled Then
            EnrollementForm.OE1CO = PSY325CO
        ElseIf PSY504CO.State.enrolled Then
            EnrollementForm.OE1CO = PSY504CO
        ElseIf PSY209CO.State.enrolled Then
            EnrollementForm.OE2CO = PSY209CO
        ElseIf PSY217CO.State.enrolled Then
            EnrollementForm.OE2CO = PSY217CO
        Else Minors.Show()
        End If
        Me.Hide()
    End Sub
End Class