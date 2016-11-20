Public Class login2
    Private Sub login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim err As New erro2
        Dim home As New pageHome
        If Masked1.Text = "" Then
            err.ShowDialog()

        ElseIf Username.Text = "" Then
            err.ShowDialog()

        End If

        If Masked1.Text <> "" And Username.Text <> "" Then
            home.nam = Me.Username.Text
            MDI.user = Me.Username.Text
            Me.Close()
            home.MdiParent = MDI
            home.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class