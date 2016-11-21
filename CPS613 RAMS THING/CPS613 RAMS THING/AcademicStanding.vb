Public Class AcademicStanding
    Private stand As String

    Private Sub AcademicStanding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grades_15_Panel.Visible = False
        Standing = "Clear"
        Me.StandingLabel.Text = " Academic Standing: " + Standing
    End Sub

    Public Property Standing As String
        Get
            Return stand
        End Get
        Set(value As String)
            stand = value
        End Set
    End Property

    Private Sub Grades_15_Button_Click(sender As Object, e As EventArgs) Handles Grades_15_Button.Click
        If Grades_15_Panel.Visible = False Then
            Grades_15_Panel.Visible = True
        Else
            Grades_15_Panel.Visible = False
        End If
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub
End Class