Public Class Minors
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PsyMinorLink.LinkClicked
        PsyCourses.Show()
        Me.Hide()
    End Sub
End Class