Public Class Personal_Information
    Private Sub Personal_Information_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

        pageHome.Hstreet.Text = Me.homeStreet.Text
        pageHome.Hprovince.Text = Me.homeProvince.Text
        pageHome.Hcity.Text = Me.homeCity.Text
        pageHome.Hcode.Text = Me.homeCode.Text


        pageHome.Mstreet.Text = Me.mailStreet.Text
        pageHome.Mprovince.Text = Me.mailProvince.Text
        pageHome.Mcity.Text = Me.mailCity.Text
        pageHome.Mcode.Text = Me.mailCode.Text


        pageHome.Phone.Text = Me.phone.Text
        pageHome.Email.Text = Me.email.Text
    End Sub
End Class