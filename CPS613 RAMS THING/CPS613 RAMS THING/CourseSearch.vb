Public Class CourseSearch
    Public courseSelected As String = " "
    Private course As CourseInfoObject

    Private Sub CourseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        course = New CourseInfoObject
        CourseList.Controls.Add(course)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged

    End Sub

    Private Sub searchListBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MCheckBox_CheckedChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub courseListView_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub CourseList_Click(sender As Object, e As EventArgs) Handles CourseList.Click

    End Sub

    Private Sub CourseInfoObject1_Load(sender As Object, e As EventArgs) 

    End Sub
End Class