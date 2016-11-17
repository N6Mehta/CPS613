Public Class CourseSearch
    Public courseSelected As String = " "
    Private course As CourseInfoObject

    Private Sub CourseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        course = New CourseInfoObject
        GroupBox1.Controls.Add(New CourseInfoObject)
        GroupBox1.Controls.Add(New Button)



    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged

    End Sub

    Private Sub searchListBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class