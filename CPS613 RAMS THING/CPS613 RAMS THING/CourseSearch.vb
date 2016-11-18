Public Class CourseSearch
    'Public courseSelected As String
    Private courseSelected As Boolean
    Private courseName As String

    Public course As CourseObject
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CourseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'searchListBox.Text = " Courses:"
        course.connectSearch(Me)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged

    End Sub

    Private Sub searchListBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MCheckBox.CheckedChanged, PCheckBox.CheckedChanged
        'courseSelected = MCheckBox.Text
        Dim temp As CheckBox
        temp = CType(sender, CheckBox)
        courseName = temp.Text
        courseSelected = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CourseSearch_Leave(sender As Object, e As EventArgs) Handles Me.Leave
    End Sub
    'Connects the class to the search object
    Public Sub connectCourse(newCourse As CourseObject)
        Me.course = newCourse
    End Sub

    Private Sub doneButton_Click(sender As Object, e As EventArgs) Handles doneButton.Click
        If courseSelected Then
            course.CourseName.Text = courseName
            Me.Close()
            courseSelected = False
        End If


    End Sub

    Private Sub PCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles PCheckBox.CheckedChanged

    End Sub
End Class