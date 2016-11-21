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
        Me.homeStreet.Text = pageHome.Hstreet.Text
        Me.homeProvince.Text = pageHome.Hprovince.Text
        Me.homeCity.Text = pageHome.Hcity.Text
        Me.homeCode.Text = pageHome.Hcode.Text


        Me.mailStreet.Text = pageHome.Mstreet.Text
        Me.mailProvince.Text = pageHome.Mprovince.Text
        Me.mailCity.Text = pageHome.Mcity.Text
        Me.mailCode.Text = pageHome.Mcode.Text


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


        home.Hstreet.Text = hStreet
        home.Hprovince.Text = hProvince
        home.Hcity.Text = hCity
        home.Hcode.Text = hCode


        home.Mstreet.Text = mStreet
        home.Mprovince.Text = mProvince
        home.Mcity.Text = mCity
        home.Mcode.Text = mCode


        home.Phone.Text = Me.phone.Text
        home.Email.Text = Me.email.Text
        ' home.Show()

        Me.Close()
    End Sub
End Class