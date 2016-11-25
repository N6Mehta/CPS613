Public Class Minors
    Private enroll As Enrollment
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PsyMinorLink.LinkClicked
        enroll.connectToMinor(Me)
        enroll.psy_minor.Show()
        Me.Hide()
    End Sub

    Public Sub connectToEnroll(page As Enrollment)
        Me.enroll = page
    End Sub
End Class