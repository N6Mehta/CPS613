Public Class pageHome
    Public nam As String

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim enroll As New EnrollementForm
        Me.Close()
        enroll.MdiParent = MDI
        enroll.Show()
    End Sub

    Private Sub pageHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Username.Text = "Welcome, " & nam
    End Sub
End Class