Public Class CourseSearch
    Private Sub CourseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        searchListBox.Text = " Courses:"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged

    End Sub

    Private Sub searchListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchListBox.SelectedIndexChanged

    End Sub
End Class