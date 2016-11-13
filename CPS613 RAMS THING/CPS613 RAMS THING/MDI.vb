Public Class MDI
    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim home As New pageHome
        Me.WindowState = FormWindowState.Maximized

        home.MdiParent = Me
        home.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim home As New CourseSearch

        home.MdiParent = Me
        home.Show()
    End Sub
End Class
