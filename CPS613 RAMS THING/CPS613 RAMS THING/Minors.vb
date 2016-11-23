Public Class Minors
    Private enroll As EnrollementForm
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles PsyMinorLink.LinkClicked
        enroll.connectToMinor(Me)
        enroll.psy_minor.Show()
        Me.Hide()
    End Sub

    Public Sub connectToEnroll(page As EnrollementForm)
        Me.enroll = page
    End Sub
End Class