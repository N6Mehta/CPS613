Public Class Personal_Information
    Private home As pageHome
    Public hStreet As String
    Public hProvince As String
    Public hCity As String
    Public hCode As String

    Public mStreet As String
    Public mProvince As String
    Public mCity As String
    Public mCode As String

    Public emaily As String
    Public phony As String
    Private Sub Personal_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'home = New pageHome
        home.homeConnect(Me)
        Me.homeStreet.Text = pageHome.homeStreet
        Me.homeProvince.Text = pageHome.homeProvince
        Me.homeCity.Text = pageHome.homeCity
        Me.homeCode.Text = pageHome.homeCode


        Me.mailStreet.Text = pageHome.mailStreet
        Me.mailProvince.Text = pageHome.mailProvince
        Me.mailCity.Text = pageHome.mailCity
        Me.mailCode.Text = pageHome.mailCode


        Me.phone.Text = pageHome.Phone.Text
        Me.email.Text = pageHome.Email.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub personalConnect(homepage As pageHome)
        Me.home = homepage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim home As New pageHome
        'pageHome.Close()
        hStreet = Me.homeStreet.Text
        hProvince = Me.homeProvince.Text
        hCity = Me.homeCity.Text
        hCode = Me.homeCode.Text


        mStreet = Me.mailStreet.Text
        mProvince = Me.mailProvince.Text
        mCity = Me.mailCity.Text
        mCode = Me.mailCode.Text

        phony = Me.phone.Text
        emaily = Me.email.Text

        home.Address.Text = hStreet & vbNewLine & hCity & Space(1) & hProvince & Space(1) & hCode
        home.mail.Text = mStreet & vbNewLine & mCity & Space(1) & mProvince & Space(1) & mCode


        home.Phone.Text = phony
        home.Email.Text = emaily

        home.Show()

        Me.Close()
    End Sub
End Class