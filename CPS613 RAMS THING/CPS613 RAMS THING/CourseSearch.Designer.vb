<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CourseSearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.doneButton = New System.Windows.Forms.Button()
        Me.filterLabel = New System.Windows.Forms.Label()
        Me.LLCheckBox = New System.Windows.Forms.CheckBox()
        Me.ULCheckBox = New System.Windows.Forms.CheckBox()
        Me.PRCheckBox = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.OECheckBox = New System.Windows.Forms.CheckBox()
        Me.FTCheckBox = New System.Windows.Forms.CheckBox()
        Me.WTCheckBox = New System.Windows.Forms.CheckBox()
        Me.courseListView = New System.Windows.Forms.ListView()
        Me.MCheckBox = New System.Windows.Forms.CheckBox()
        Me.legendLabel = New System.Windows.Forms.Label()
        Me.openLabel = New System.Windows.Forms.Label()
        Me.closedLabel = New System.Windows.Forms.Label()
        Me.waitLabel = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.courseLabel = New System.Windows.Forms.Label()
        Me.DescripLabel = New System.Windows.Forms.Label()
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.roomLabel = New System.Windows.Forms.Label()
        Me.UnitLabel = New System.Windows.Forms.Label()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.P2CheckBox = New System.Windows.Forms.CheckBox()
        Me.P4CheckBox = New System.Windows.Forms.CheckBox()
        Me.P2desLabel = New System.Windows.Forms.Label()
        Me.P4desLabel = New System.Windows.Forms.Label()
        Me.MdesLabel = New System.Windows.Forms.Label()
        Me.MtimeLabel = New System.Windows.Forms.Label()
        Me.P2timeLabel = New System.Windows.Forms.Label()
        Me.P4timeLabel = New System.Windows.Forms.Label()
        Me.MroomLabel = New System.Windows.Forms.Label()
        Me.P2roomLabel = New System.Windows.Forms.Label()
        Me.P4roomLabel = New System.Windows.Forms.Label()
        Me.MunitLabel = New System.Windows.Forms.Label()
        Me.P2unitLabel = New System.Windows.Forms.Label()
        Me.P4unitLabel = New System.Windows.Forms.Label()
        Me.MPictureBox = New System.Windows.Forms.PictureBox()
        Me.P2PictureBox = New System.Windows.Forms.PictureBox()
        Me.P4PictureBox = New System.Windows.Forms.PictureBox()
        Me.courseTableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.PSY209CB = New System.Windows.Forms.CheckBox()
        Me.P209Desc = New System.Windows.Forms.Label()
        Me.P209Time = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.P209Room = New System.Windows.Forms.Label()
        Me.P209Unit = New System.Windows.Forms.Label()
        Me.P209Status = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.courseTableLayoutPanel.SuspendLayout()
        CType(Me.P209Status, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchButton
        '
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.Location = New System.Drawing.Point(953, 54)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(4)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(99, 36)
        Me.searchButton.TabIndex = 0
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.searchTextBox.Location = New System.Drawing.Point(36, 54)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(908, 34)
        Me.searchTextBox.TabIndex = 1
        '
        'cancelButton
        '
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(544, 661)
        Me.cancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(167, 46)
        Me.cancelButton.TabIndex = 3
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'doneButton
        '
        Me.doneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doneButton.Location = New System.Drawing.Point(325, 661)
        Me.doneButton.Margin = New System.Windows.Forms.Padding(4)
        Me.doneButton.Name = "doneButton"
        Me.doneButton.Size = New System.Drawing.Size(164, 46)
        Me.doneButton.TabIndex = 4
        Me.doneButton.Text = "Done"
        Me.doneButton.UseVisualStyleBackColor = True
        '
        'filterLabel
        '
        Me.filterLabel.AutoSize = True
        Me.filterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterLabel.Location = New System.Drawing.Point(41, 112)
        Me.filterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.filterLabel.Name = "filterLabel"
        Me.filterLabel.Size = New System.Drawing.Size(167, 25)
        Me.filterLabel.TabIndex = 5
        Me.filterLabel.Text = "Course Category:"
        '
        'LLCheckBox
        '
        Me.LLCheckBox.AutoSize = True
        Me.LLCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLCheckBox.Location = New System.Drawing.Point(73, 155)
        Me.LLCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LLCheckBox.Name = "LLCheckBox"
        Me.LLCheckBox.Size = New System.Drawing.Size(142, 24)
        Me.LLCheckBox.TabIndex = 6
        Me.LLCheckBox.Text = "Lower Liberals"
        Me.LLCheckBox.UseVisualStyleBackColor = True
        '
        'ULCheckBox
        '
        Me.ULCheckBox.AutoSize = True
        Me.ULCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULCheckBox.Location = New System.Drawing.Point(73, 204)
        Me.ULCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ULCheckBox.Name = "ULCheckBox"
        Me.ULCheckBox.Size = New System.Drawing.Size(141, 24)
        Me.ULCheckBox.TabIndex = 7
        Me.ULCheckBox.Text = "Upper Liberals"
        Me.ULCheckBox.UseVisualStyleBackColor = True
        '
        'PRCheckBox
        '
        Me.PRCheckBox.AutoSize = True
        Me.PRCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRCheckBox.Location = New System.Drawing.Point(293, 155)
        Me.PRCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PRCheckBox.Name = "PRCheckBox"
        Me.PRCheckBox.Size = New System.Drawing.Size(203, 24)
        Me.PRCheckBox.TabIndex = 8
        Me.PRCheckBox.Text = "Professionally Related "
        Me.PRCheckBox.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(293, 204)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(109, 24)
        Me.CheckBox4.TabIndex = 9
        Me.CheckBox4.Text = "Mandatory"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'OECheckBox
        '
        Me.OECheckBox.AutoSize = True
        Me.OECheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OECheckBox.Location = New System.Drawing.Point(544, 155)
        Me.OECheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OECheckBox.Name = "OECheckBox"
        Me.OECheckBox.Size = New System.Drawing.Size(135, 24)
        Me.OECheckBox.TabIndex = 10
        Me.OECheckBox.Text = "Open Elective"
        Me.OECheckBox.UseVisualStyleBackColor = True
        '
        'FTCheckBox
        '
        Me.FTCheckBox.AutoSize = True
        Me.FTCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FTCheckBox.Location = New System.Drawing.Point(544, 204)
        Me.FTCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FTCheckBox.Name = "FTCheckBox"
        Me.FTCheckBox.Size = New System.Drawing.Size(102, 24)
        Me.FTCheckBox.TabIndex = 11
        Me.FTCheckBox.Text = "Fall Term"
        Me.FTCheckBox.UseVisualStyleBackColor = True
        '
        'WTCheckBox
        '
        Me.WTCheckBox.AutoSize = True
        Me.WTCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTCheckBox.Location = New System.Drawing.Point(750, 155)
        Me.WTCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.WTCheckBox.Name = "WTCheckBox"
        Me.WTCheckBox.Size = New System.Drawing.Size(124, 24)
        Me.WTCheckBox.TabIndex = 12
        Me.WTCheckBox.Text = "Winter Term"
        Me.WTCheckBox.UseVisualStyleBackColor = True
        '
        'courseListView
        '
        Me.courseListView.Location = New System.Drawing.Point(36, 299)
        Me.courseListView.Margin = New System.Windows.Forms.Padding(4)
        Me.courseListView.Name = "courseListView"
        Me.courseListView.Size = New System.Drawing.Size(908, 354)
        Me.courseListView.TabIndex = 14
        Me.courseListView.UseCompatibleStateImageBehavior = False
        '
        'MCheckBox
        '
        Me.MCheckBox.AutoSize = True
        Me.MCheckBox.BackColor = System.Drawing.SystemColors.Window
        Me.MCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MCheckBox.Location = New System.Drawing.Point(5, 27)
        Me.MCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MCheckBox.Name = "MCheckBox"
        Me.MCheckBox.Size = New System.Drawing.Size(84, 21)
        Me.MCheckBox.TabIndex = 16
        Me.MCheckBox.Text = "MTH110"
        Me.MCheckBox.UseVisualStyleBackColor = False
        Me.MCheckBox.Visible = False
        '
        'legendLabel
        '
        Me.legendLabel.AutoSize = True
        Me.legendLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.legendLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.legendLabel.Location = New System.Drawing.Point(556, 318)
        Me.legendLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.legendLabel.Name = "legendLabel"
        Me.legendLabel.Size = New System.Drawing.Size(69, 20)
        Me.legendLabel.TabIndex = 17
        Me.legendLabel.Text = "Legend:"
        '
        'openLabel
        '
        Me.openLabel.AutoSize = True
        Me.openLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.openLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openLabel.Location = New System.Drawing.Point(674, 318)
        Me.openLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.openLabel.Name = "openLabel"
        Me.openLabel.Size = New System.Drawing.Size(44, 18)
        Me.openLabel.TabIndex = 19
        Me.openLabel.Text = "Open"
        '
        'closedLabel
        '
        Me.closedLabel.AutoSize = True
        Me.closedLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closedLabel.Location = New System.Drawing.Point(766, 318)
        Me.closedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.closedLabel.Name = "closedLabel"
        Me.closedLabel.Size = New System.Drawing.Size(55, 18)
        Me.closedLabel.TabIndex = 21
        Me.closedLabel.Text = "Closed"
        '
        'waitLabel
        '
        Me.waitLabel.AutoSize = True
        Me.waitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.waitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waitLabel.Location = New System.Drawing.Point(871, 318)
        Me.waitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.waitLabel.Name = "waitLabel"
        Me.waitLabel.Size = New System.Drawing.Size(56, 18)
        Me.waitLabel.TabIndex = 23
        Me.waitLabel.Text = "Waitlist"
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.yellow_circle1
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(835, 315)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(637, 315)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.blue_circle1
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(731, 315)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 25)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'courseLabel
        '
        Me.courseLabel.AutoSize = True
        Me.courseLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.courseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.Location = New System.Drawing.Point(5, 1)
        Me.courseLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(63, 20)
        Me.courseLabel.TabIndex = 24
        Me.courseLabel.Text = "Course"
        '
        'DescripLabel
        '
        Me.DescripLabel.AutoSize = True
        Me.DescripLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DescripLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripLabel.Location = New System.Drawing.Point(111, 1)
        Me.DescripLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DescripLabel.Name = "DescripLabel"
        Me.DescripLabel.Size = New System.Drawing.Size(95, 20)
        Me.DescripLabel.TabIndex = 25
        Me.DescripLabel.Text = "Description"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(315, 1)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(55, 20)
        Me.TimeLabel.TabIndex = 26
        Me.TimeLabel.Text = "Times"
        '
        'roomLabel
        '
        Me.roomLabel.AutoSize = True
        Me.roomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.roomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomLabel.Location = New System.Drawing.Point(453, 1)
        Me.roomLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.roomLabel.Name = "roomLabel"
        Me.roomLabel.Size = New System.Drawing.Size(53, 20)
        Me.roomLabel.TabIndex = 27
        Me.roomLabel.Text = "Room"
        '
        'UnitLabel
        '
        Me.UnitLabel.AutoSize = True
        Me.UnitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitLabel.Location = New System.Drawing.Point(587, 1)
        Me.UnitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UnitLabel.Name = "UnitLabel"
        Me.UnitLabel.Size = New System.Drawing.Size(39, 20)
        Me.UnitLabel.TabIndex = 28
        Me.UnitLabel.Text = "Unit"
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(708, 1)
        Me.statusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(57, 20)
        Me.statusLabel.TabIndex = 29
        Me.statusLabel.Text = "Status"
        '
        'P2CheckBox
        '
        Me.P2CheckBox.AutoSize = True
        Me.P2CheckBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.P2CheckBox.Location = New System.Drawing.Point(5, 88)
        Me.P2CheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.P2CheckBox.Name = "P2CheckBox"
        Me.P2CheckBox.Size = New System.Drawing.Size(81, 21)
        Me.P2CheckBox.TabIndex = 30
        Me.P2CheckBox.Text = "PSY202"
        Me.P2CheckBox.UseVisualStyleBackColor = False
        Me.P2CheckBox.Visible = False
        '
        'P4CheckBox
        '
        Me.P4CheckBox.AutoSize = True
        Me.P4CheckBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.P4CheckBox.Location = New System.Drawing.Point(5, 138)
        Me.P4CheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.P4CheckBox.Name = "P4CheckBox"
        Me.P4CheckBox.Size = New System.Drawing.Size(81, 21)
        Me.P4CheckBox.TabIndex = 31
        Me.P4CheckBox.Text = "PSY124"
        Me.P4CheckBox.UseVisualStyleBackColor = False
        Me.P4CheckBox.Visible = False
        '
        'P2desLabel
        '
        Me.P2desLabel.AutoSize = True
        Me.P2desLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2desLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2desLabel.Location = New System.Drawing.Point(111, 84)
        Me.P2desLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P2desLabel.Name = "P2desLabel"
        Me.P2desLabel.Size = New System.Drawing.Size(111, 18)
        Me.P2desLabel.TabIndex = 32
        Me.P2desLabel.Text = "Intro to Psy 110"
        Me.P2desLabel.Visible = False
        '
        'P4desLabel
        '
        Me.P4desLabel.AutoSize = True
        Me.P4desLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4desLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4desLabel.Location = New System.Drawing.Point(111, 134)
        Me.P4desLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P4desLabel.Name = "P4desLabel"
        Me.P4desLabel.Size = New System.Drawing.Size(130, 18)
        Me.P4desLabel.TabIndex = 33
        Me.P4desLabel.Text = "Social Psychology"
        Me.P4desLabel.Visible = False
        '
        'MdesLabel
        '
        Me.MdesLabel.AutoSize = True
        Me.MdesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MdesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MdesLabel.Location = New System.Drawing.Point(111, 23)
        Me.MdesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MdesLabel.Name = "MdesLabel"
        Me.MdesLabel.Size = New System.Drawing.Size(152, 18)
        Me.MdesLabel.TabIndex = 34
        Me.MdesLabel.Text = "Discrete Mathematics"
        Me.MdesLabel.Visible = False
        '
        'MtimeLabel
        '
        Me.MtimeLabel.AutoSize = True
        Me.MtimeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MtimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtimeLabel.Location = New System.Drawing.Point(315, 23)
        Me.MtimeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MtimeLabel.Name = "MtimeLabel"
        Me.MtimeLabel.Size = New System.Drawing.Size(66, 34)
        Me.MtimeLabel.TabIndex = 35
        Me.MtimeLabel.Text = "Wed 3-4," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Fri 12-2"
        Me.MtimeLabel.Visible = False
        '
        'P2timeLabel
        '
        Me.P2timeLabel.AutoSize = True
        Me.P2timeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2timeLabel.Location = New System.Drawing.Point(315, 84)
        Me.P2timeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P2timeLabel.Name = "P2timeLabel"
        Me.P2timeLabel.Size = New System.Drawing.Size(77, 34)
        Me.P2timeLabel.TabIndex = 36
        Me.P2timeLabel.Text = "Tues 12-1," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thur 2-4"
        Me.P2timeLabel.Visible = False
        '
        'P4timeLabel
        '
        Me.P4timeLabel.AutoSize = True
        Me.P4timeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4timeLabel.Location = New System.Drawing.Point(315, 134)
        Me.P4timeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P4timeLabel.Name = "P4timeLabel"
        Me.P4timeLabel.Size = New System.Drawing.Size(72, 34)
        Me.P4timeLabel.TabIndex = 37
        Me.P4timeLabel.Text = "Mon 8-10," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wed 12-1"
        Me.P4timeLabel.Visible = False
        '
        'MroomLabel
        '
        Me.MroomLabel.AutoSize = True
        Me.MroomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MroomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MroomLabel.Location = New System.Drawing.Point(453, 23)
        Me.MroomLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MroomLabel.Name = "MroomLabel"
        Me.MroomLabel.Size = New System.Drawing.Size(79, 18)
        Me.MroomLabel.TabIndex = 38
        Me.MroomLabel.Text = "KHE321-C"
        Me.MroomLabel.Visible = False
        '
        'P2roomLabel
        '
        Me.P2roomLabel.AutoSize = True
        Me.P2roomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2roomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2roomLabel.Location = New System.Drawing.Point(453, 84)
        Me.P2roomLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P2roomLabel.Name = "P2roomLabel"
        Me.P2roomLabel.Size = New System.Drawing.Size(55, 18)
        Me.P2roomLabel.TabIndex = 39
        Me.P2roomLabel.Text = "VIC500"
        Me.P2roomLabel.Visible = False
        '
        'P4roomLabel
        '
        Me.P4roomLabel.AutoSize = True
        Me.P4roomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4roomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4roomLabel.Location = New System.Drawing.Point(453, 134)
        Me.P4roomLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P4roomLabel.Name = "P4roomLabel"
        Me.P4roomLabel.Size = New System.Drawing.Size(63, 18)
        Me.P4roomLabel.TabIndex = 40
        Me.P4roomLabel.Text = "KHE114"
        Me.P4roomLabel.Visible = False
        '
        'MunitLabel
        '
        Me.MunitLabel.AutoSize = True
        Me.MunitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MunitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MunitLabel.Location = New System.Drawing.Point(587, 23)
        Me.MunitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MunitLabel.Name = "MunitLabel"
        Me.MunitLabel.Size = New System.Drawing.Size(16, 18)
        Me.MunitLabel.TabIndex = 41
        Me.MunitLabel.Text = "1"
        Me.MunitLabel.Visible = False
        '
        'P2unitLabel
        '
        Me.P2unitLabel.AutoSize = True
        Me.P2unitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2unitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2unitLabel.Location = New System.Drawing.Point(587, 84)
        Me.P2unitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P2unitLabel.Name = "P2unitLabel"
        Me.P2unitLabel.Size = New System.Drawing.Size(16, 18)
        Me.P2unitLabel.TabIndex = 42
        Me.P2unitLabel.Text = "1"
        Me.P2unitLabel.Visible = False
        '
        'P4unitLabel
        '
        Me.P4unitLabel.AutoSize = True
        Me.P4unitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4unitLabel.Location = New System.Drawing.Point(587, 134)
        Me.P4unitLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P4unitLabel.Name = "P4unitLabel"
        Me.P4unitLabel.Size = New System.Drawing.Size(16, 17)
        Me.P4unitLabel.TabIndex = 43
        Me.P4unitLabel.Text = "1"
        Me.P4unitLabel.Visible = False
        '
        'MPictureBox
        '
        Me.MPictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.MPictureBox.Location = New System.Drawing.Point(708, 27)
        Me.MPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.MPictureBox.Name = "MPictureBox"
        Me.MPictureBox.Size = New System.Drawing.Size(27, 25)
        Me.MPictureBox.TabIndex = 44
        Me.MPictureBox.TabStop = False
        Me.MPictureBox.Visible = False
        '
        'P2PictureBox
        '
        Me.P2PictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.P2PictureBox.Location = New System.Drawing.Point(708, 88)
        Me.P2PictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.P2PictureBox.Name = "P2PictureBox"
        Me.P2PictureBox.Size = New System.Drawing.Size(27, 25)
        Me.P2PictureBox.TabIndex = 45
        Me.P2PictureBox.TabStop = False
        Me.P2PictureBox.Visible = False
        '
        'P4PictureBox
        '
        Me.P4PictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.P4PictureBox.Location = New System.Drawing.Point(708, 138)
        Me.P4PictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.P4PictureBox.Name = "P4PictureBox"
        Me.P4PictureBox.Size = New System.Drawing.Size(27, 25)
        Me.P4PictureBox.TabIndex = 46
        Me.P4PictureBox.TabStop = False
        Me.P4PictureBox.Visible = False
        '
        'courseTableLayoutPanel
        '
        Me.courseTableLayoutPanel.AutoScroll = True
        Me.courseTableLayoutPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.courseTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.courseTableLayoutPanel.ColumnCount = 6
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.22222!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.77778!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113.0!))
        Me.courseTableLayoutPanel.Controls.Add(Me.courseLabel, 0, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4PictureBox, 5, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.DescripLabel, 1, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2PictureBox, 5, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.TimeLabel, 2, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4unitLabel, 4, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.MPictureBox, 5, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2unitLabel, 4, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.roomLabel, 3, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4roomLabel, 3, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.UnitLabel, 4, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2roomLabel, 3, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.statusLabel, 5, 0)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4timeLabel, 2, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.MunitLabel, 4, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2timeLabel, 2, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.MCheckBox, 0, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.MtimeLabel, 2, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4CheckBox, 0, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.MroomLabel, 3, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2CheckBox, 0, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.MdesLabel, 1, 1)
        Me.courseTableLayoutPanel.Controls.Add(Me.P4desLabel, 1, 3)
        Me.courseTableLayoutPanel.Controls.Add(Me.P2desLabel, 1, 2)
        Me.courseTableLayoutPanel.Controls.Add(Me.PSY209CB, 0, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Desc, 1, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Time, 2, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Room, 3, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Unit, 4, 4)
        Me.courseTableLayoutPanel.Controls.Add(Me.P209Status, 5, 4)
        Me.courseTableLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.courseTableLayoutPanel.Location = New System.Drawing.Point(73, 348)
        Me.courseTableLayoutPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.courseTableLayoutPanel.Name = "courseTableLayoutPanel"
        Me.courseTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.courseTableLayoutPanel.RowCount = 6
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.1745!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.8255!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.courseTableLayoutPanel.Size = New System.Drawing.Size(819, 280)
        Me.courseTableLayoutPanel.TabIndex = 47
        '
        'PSY209CB
        '
        Me.PSY209CB.AutoSize = True
        Me.PSY209CB.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PSY209CB.Location = New System.Drawing.Point(5, 195)
        Me.PSY209CB.Margin = New System.Windows.Forms.Padding(4)
        Me.PSY209CB.Name = "PSY209CB"
        Me.PSY209CB.Size = New System.Drawing.Size(81, 21)
        Me.PSY209CB.TabIndex = 47
        Me.PSY209CB.Text = "PSY209"
        Me.PSY209CB.UseVisualStyleBackColor = False
        Me.PSY209CB.Visible = False
        '
        'P209Desc
        '
        Me.P209Desc.AutoSize = True
        Me.P209Desc.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P209Desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P209Desc.Location = New System.Drawing.Point(111, 191)
        Me.P209Desc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P209Desc.Name = "P209Desc"
        Me.P209Desc.Size = New System.Drawing.Size(147, 18)
        Me.P209Desc.TabIndex = 48
        Me.P209Desc.Text = "Industrial Psychology"
        Me.P209Desc.Visible = False
        '
        'P209Time
        '
        Me.P209Time.AutoSize = True
        Me.P209Time.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P209Time.Location = New System.Drawing.Point(315, 191)
        Me.P209Time.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P209Time.Name = "P209Time"
        Me.P209Time.Size = New System.Drawing.Size(72, 34)
        Me.P209Time.TabIndex = 49
        Me.P209Time.Text = "Mon 8-10," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wed 12-1"
        Me.P209Time.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(246, 20)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Please enter a course code:"
        '
        'P209Room
        '
        Me.P209Room.AutoSize = True
        Me.P209Room.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P209Room.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P209Room.Location = New System.Drawing.Point(453, 191)
        Me.P209Room.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P209Room.Name = "P209Room"
        Me.P209Room.Size = New System.Drawing.Size(63, 18)
        Me.P209Room.TabIndex = 50
        Me.P209Room.Text = "KHE114"
        Me.P209Room.Visible = False
        '
        'P209Unit
        '
        Me.P209Unit.AutoSize = True
        Me.P209Unit.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P209Unit.Location = New System.Drawing.Point(587, 191)
        Me.P209Unit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.P209Unit.Name = "P209Unit"
        Me.P209Unit.Size = New System.Drawing.Size(16, 17)
        Me.P209Unit.TabIndex = 51
        Me.P209Unit.Text = "1"
        Me.P209Unit.Visible = False
        '
        'P209Status
        '
        Me.P209Status.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.P209Status.InitialImage = Nothing
        Me.P209Status.Location = New System.Drawing.Point(708, 195)
        Me.P209Status.Margin = New System.Windows.Forms.Padding(4)
        Me.P209Status.Name = "P209Status"
        Me.P209Status.Size = New System.Drawing.Size(27, 25)
        Me.P209Status.TabIndex = 52
        Me.P209Status.TabStop = False
        '
        'CourseSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1068, 722)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.courseTableLayoutPanel)
        Me.Controls.Add(Me.waitLabel)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.closedLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.openLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.legendLabel)
        Me.Controls.Add(Me.courseListView)
        Me.Controls.Add(Me.WTCheckBox)
        Me.Controls.Add(Me.FTCheckBox)
        Me.Controls.Add(Me.OECheckBox)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.PRCheckBox)
        Me.Controls.Add(Me.ULCheckBox)
        Me.Controls.Add(Me.LLCheckBox)
        Me.Controls.Add(Me.filterLabel)
        Me.Controls.Add(Me.doneButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.searchButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CourseSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.courseTableLayoutPanel.ResumeLayout(False)
        Me.courseTableLayoutPanel.PerformLayout()
        CType(Me.P209Status, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchButton As Button
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents doneButton As Button
    Friend WithEvents filterLabel As Label
    Friend WithEvents LLCheckBox As CheckBox
    Friend WithEvents ULCheckBox As CheckBox
    Friend WithEvents PRCheckBox As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents OECheckBox As CheckBox
    Friend WithEvents FTCheckBox As CheckBox
    Friend WithEvents WTCheckBox As CheckBox
    Friend WithEvents courseListView As ListView
    Friend WithEvents MCheckBox As CheckBox
    Friend WithEvents legendLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents openLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents closedLabel As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents waitLabel As Label
    Friend WithEvents courseLabel As Label
    Friend WithEvents DescripLabel As Label
    Friend WithEvents TimeLabel As Label
    Friend WithEvents roomLabel As Label
    Friend WithEvents UnitLabel As Label
    Friend WithEvents statusLabel As Label
    Friend WithEvents P2CheckBox As CheckBox
    Friend WithEvents P4CheckBox As CheckBox
    Friend WithEvents P2desLabel As Label
    Friend WithEvents P4desLabel As Label
    Friend WithEvents MdesLabel As Label
    Friend WithEvents MtimeLabel As Label
    Friend WithEvents P2timeLabel As Label
    Friend WithEvents P4timeLabel As Label
    Friend WithEvents MroomLabel As Label
    Friend WithEvents P2roomLabel As Label
    Friend WithEvents P4roomLabel As Label
    Friend WithEvents MunitLabel As Label
    Friend WithEvents P2unitLabel As Label
    Friend WithEvents P4unitLabel As Label
    Friend WithEvents MPictureBox As PictureBox
    Friend WithEvents P2PictureBox As PictureBox
    Friend WithEvents P4PictureBox As PictureBox
    Public WithEvents courseTableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PSY209CB As CheckBox
    Friend WithEvents P209Desc As Label
    Friend WithEvents P209Time As Label
    Friend WithEvents P209Room As Label
    Friend WithEvents P209Unit As Label
    Friend WithEvents P209Status As PictureBox
End Class
