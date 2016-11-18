Public Class MDI
    Public user As String

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim login As New login
        Me.WindowState = FormWindowState.Maximized
        'login.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim home As New pageHome
        home.nam = user
        home.MdiParent = Me
        home.Show()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Dim hombre As New pageHome
        hombre.nam = user
        hombre.MdiParent = Me
        hombre.Show()
    End Sub

    Private Sub CourseObject2_Load(sender As Object, e As EventArgs) 

    End Sub
End Class
