Public Class MDI
    Public user As String
    Public Shared home As New pageHome
    Public Shared enroll As New EnrollementForm
    Public Shared grades As New AcademicStanding
    Public Shared view As New viewDocs
    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'home.windows
        home.MdiParent = Me
        home.Visible = True
        'Dim login As New login2
        Me.WindowState = FormWindowState.Maximized
        'login.ShowDialog()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If enroll.Visible = True Or view.Visible = True Or grades.Visible = True Or home.Visible = True Then
            enroll.Visible = False
            view.Visible = False
            grades.Visible = False
            'home.Visible = True
        End If

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        'Dim home As New pageHome
        If enroll.Visible = True Or view.Visible = True Or grades.Visible = True Or home.Visible = True Then
            enroll.Visible = False
            view.Visible = False
            grades.Visible = False
            'home.Visible = True
        End If
        'ActiveMdiChild.Close()
        'home.nam = user
        'home.MdiParent = Me
        'home.Show()
        'If Me.ActiveMdiChild.Visible = True Then
        '  Me.ActiveMdiChild.Visible = False
        '   hombre.Visible = True
        'End If
    End Sub

    Private Sub CourseObject2_Load(sender As Object, e As EventArgs)
        'change here
    End Sub
End Class
