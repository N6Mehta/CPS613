Public Class pageHome
    Public nam As String
    Public homeStreet As String = "100 Random Street"
    Public homeProvince As String = "Ontario"
    Public homeCity As String = "Toronto"
    Public homeCode As String = "M5V 123"


    Public mailStreet As String = "100 Random Street"
    Public mailProvince As String = "Ontario"
    Public mailCity As String = "Toronto"
    Public mailCode As String = "M5V 123"
    Private person As Personal_Information
    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim enroll As New Enrollment
        'Me.Close()
        Me.WindowState = FormWindowState.Minimized
        'Me.Visible = False
        enroll.MdiParent = MDI
        enroll.Show()

    End Sub

    Private Sub pageHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Address.Text = homeStreet & vbNewLine & homeCity & Space(1) & homeProvince & Space(1) & homeCode
        Me.mail.Text = mailStreet & vbNewLine & mailCity & Space(1) & mailProvince & Space(1) & mailCode

        Username.Text = "Welcome, " & nam
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            CheckBox1.Visible = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            CheckBox2.Visible = False
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            CheckBox3.Visible = False
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            CheckBox4.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        CheckBox3.Checked = True
        CheckBox4.Checked = True
    End Sub

    Private Sub GroupBox4_Enter(sender As Object, e As EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        ' Dim edit As New Personal_Information
        person = New Personal_Information
        'Me.Visible = False
        'Me.Close()
        'Me.WindowState = FormWindowState.Minimized
        person.personalConnect(Me)
        person.Show()
    End Sub

    Public Sub homeConnect(personal As Personal_Information)
        Me.person = personal
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim grades As New AcademicStanding
        grades.MdiParent = MDI
        Me.Visible = False
        grades.Show()
        Me.Close()
        'Me.WindowState = FormWindowState.Minimized

        'Me.Visible = False
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim view As New viewDocs
        view.MdiParent = MDI
        Me.Visible = False
        view.Show()
        'Me.WindowState = FormWindowState.Minimized
        Me.Close()
        ' Me.Visible = False
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Dim dialog As New gradDialog
        dialog.ShowDialog()
    End Sub
End Class