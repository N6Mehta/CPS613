Public Class CourseSearch
    Public courseSelected As String
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub CourseSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles searchTextBox.TextChanged

    End Sub

    Private Sub searchListBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Public Sub MCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles MCheckBox.CheckedChanged
        courseSelected = MCheckBox.Text

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub CourseSearch_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        MsgBox("fuck")
    End Sub

    Private Sub doneButton_Click(sender As Object, e As EventArgs) Handles doneButton.Click
        Me.Close()
    End Sub

End Class