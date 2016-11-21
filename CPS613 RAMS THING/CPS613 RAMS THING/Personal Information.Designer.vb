<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Personal_Information
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.homeStreet = New System.Windows.Forms.TextBox()
        Me.homeCity = New System.Windows.Forms.TextBox()
        Me.homeProvince = New System.Windows.Forms.TextBox()
        Me.homeCode = New System.Windows.Forms.TextBox()
        Me.mailCode = New System.Windows.Forms.TextBox()
        Me.mailProvince = New System.Windows.Forms.TextBox()
        Me.mailCity = New System.Windows.Forms.TextBox()
        Me.mailStreet = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(206, 435)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(444, 435)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Home Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 286)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Home Phone"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(478, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mailing Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(478, 286)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ryerson Email"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(86, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Street"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "City"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 172)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Province"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 206)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Postal Code"
        '
        'homeStreet
        '
        Me.homeStreet.Location = New System.Drawing.Point(148, 100)
        Me.homeStreet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.homeStreet.Name = "homeStreet"
        Me.homeStreet.Size = New System.Drawing.Size(148, 26)
        Me.homeStreet.TabIndex = 14
        '
        'homeCity
        '
        Me.homeCity.Location = New System.Drawing.Point(148, 134)
        Me.homeCity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.homeCity.Name = "homeCity"
        Me.homeCity.Size = New System.Drawing.Size(148, 26)
        Me.homeCity.TabIndex = 15
        '
        'homeProvince
        '
        Me.homeProvince.Location = New System.Drawing.Point(148, 168)
        Me.homeProvince.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.homeProvince.Name = "homeProvince"
        Me.homeProvince.Size = New System.Drawing.Size(148, 26)
        Me.homeProvince.TabIndex = 16
        '
        'homeCode
        '
        Me.homeCode.Location = New System.Drawing.Point(148, 202)
        Me.homeCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.homeCode.Name = "homeCode"
        Me.homeCode.Size = New System.Drawing.Size(148, 26)
        Me.homeCode.TabIndex = 17
        '
        'mailCode
        '
        Me.mailCode.Location = New System.Drawing.Point(544, 200)
        Me.mailCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mailCode.Name = "mailCode"
        Me.mailCode.Size = New System.Drawing.Size(148, 26)
        Me.mailCode.TabIndex = 25
        '
        'mailProvince
        '
        Me.mailProvince.Location = New System.Drawing.Point(544, 166)
        Me.mailProvince.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mailProvince.Name = "mailProvince"
        Me.mailProvince.Size = New System.Drawing.Size(148, 26)
        Me.mailProvince.TabIndex = 24
        '
        'mailCity
        '
        Me.mailCity.Location = New System.Drawing.Point(544, 132)
        Me.mailCity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mailCity.Name = "mailCity"
        Me.mailCity.Size = New System.Drawing.Size(148, 26)
        Me.mailCity.TabIndex = 23
        '
        'mailStreet
        '
        Me.mailStreet.Location = New System.Drawing.Point(544, 98)
        Me.mailStreet.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.mailStreet.Name = "mailStreet"
        Me.mailStreet.Size = New System.Drawing.Size(148, 26)
        Me.mailStreet.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(440, 205)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 20)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "Postal Code"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(459, 171)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 20)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Province"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(496, 137)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 20)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "City"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(482, 103)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 20)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Street"
        '
        'phone
        '
        Me.phone.Location = New System.Drawing.Point(70, 314)
        Me.phone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(148, 26)
        Me.phone.TabIndex = 26
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(470, 314)
        Me.email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(148, 26)
        Me.email.TabIndex = 27
        '
        'Personal_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 566)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.mailCode)
        Me.Controls.Add(Me.mailProvince)
        Me.Controls.Add(Me.mailCity)
        Me.Controls.Add(Me.mailStreet)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.homeCode)
        Me.Controls.Add(Me.homeProvince)
        Me.Controls.Add(Me.homeCity)
        Me.Controls.Add(Me.homeStreet)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Personal_Information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Personal Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents homeStreet As TextBox
    Friend WithEvents homeCity As TextBox
    Friend WithEvents homeProvince As TextBox
    Friend WithEvents homeCode As TextBox
    Friend WithEvents mailCode As TextBox
    Friend WithEvents mailProvince As TextBox
    Friend WithEvents mailCity As TextBox
    Friend WithEvents mailStreet As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents phone As TextBox
    Friend WithEvents email As TextBox
End Class
