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
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P2PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P4PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.courseTableLayoutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'searchButton
        '
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.Location = New System.Drawing.Point(715, 44)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(74, 29)
        Me.searchButton.TabIndex = 0
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.ForeColor = System.Drawing.SystemColors.MenuText
        Me.searchTextBox.Location = New System.Drawing.Point(27, 44)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(682, 29)
        Me.searchTextBox.TabIndex = 1
        '
        'cancelButton
        '
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(408, 537)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(125, 37)
        Me.cancelButton.TabIndex = 3
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'doneButton
        '
        Me.doneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doneButton.Location = New System.Drawing.Point(244, 537)
        Me.doneButton.Name = "doneButton"
        Me.doneButton.Size = New System.Drawing.Size(123, 37)
        Me.doneButton.TabIndex = 4
        Me.doneButton.Text = "Done"
        Me.doneButton.UseVisualStyleBackColor = True
        '
        'courseListView
        '
        Me.courseListView.Location = New System.Drawing.Point(27, 113)
        Me.courseListView.Name = "courseListView"
        Me.courseListView.Size = New System.Drawing.Size(743, 403)
        Me.courseListView.TabIndex = 14
        Me.courseListView.UseCompatibleStateImageBehavior = False
        '
        'MCheckBox
        '
        Me.MCheckBox.AutoSize = True
        Me.MCheckBox.BackColor = System.Drawing.SystemColors.Window
        Me.MCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MCheckBox.Location = New System.Drawing.Point(4, 26)
        Me.MCheckBox.Name = "MCheckBox"
        Me.MCheckBox.Size = New System.Drawing.Size(68, 17)
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
        Me.legendLabel.Location = New System.Drawing.Point(427, 123)
        Me.legendLabel.Name = "legendLabel"
        Me.legendLabel.Size = New System.Drawing.Size(57, 16)
        Me.legendLabel.TabIndex = 17
        Me.legendLabel.Text = "Legend:"
        '
        'openLabel
        '
        Me.openLabel.AutoSize = True
        Me.openLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.openLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openLabel.Location = New System.Drawing.Point(516, 124)
        Me.openLabel.Name = "openLabel"
        Me.openLabel.Size = New System.Drawing.Size(37, 15)
        Me.openLabel.TabIndex = 19
        Me.openLabel.Text = "Open"
        '
        'closedLabel
        '
        Me.closedLabel.AutoSize = True
        Me.closedLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closedLabel.Location = New System.Drawing.Point(585, 124)
        Me.closedLabel.Name = "closedLabel"
        Me.closedLabel.Size = New System.Drawing.Size(45, 15)
        Me.closedLabel.TabIndex = 21
        Me.closedLabel.Text = "Closed"
        '
        'waitLabel
        '
        Me.waitLabel.AutoSize = True
        Me.waitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.waitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waitLabel.Location = New System.Drawing.Point(662, 124)
        Me.waitLabel.Name = "waitLabel"
        Me.waitLabel.Size = New System.Drawing.Size(46, 15)
        Me.waitLabel.TabIndex = 23
        Me.waitLabel.Text = "Waitlist"
        '
        'PictureBox3
        '
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.yellow_circle1
        Me.PictureBox3.InitialImage = Nothing
        Me.PictureBox3.Location = New System.Drawing.Point(636, 124)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(490, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.blue_circle1
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(559, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'courseLabel
        '
        Me.courseLabel.AutoSize = True
        Me.courseLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.courseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.courseLabel.Location = New System.Drawing.Point(4, 1)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(51, 16)
        Me.courseLabel.TabIndex = 24
        Me.courseLabel.Text = "Course"
        '
        'DescripLabel
        '
        Me.DescripLabel.AutoSize = True
        Me.DescripLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DescripLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripLabel.Location = New System.Drawing.Point(118, 1)
        Me.DescripLabel.Name = "DescripLabel"
        Me.DescripLabel.Size = New System.Drawing.Size(76, 16)
        Me.DescripLabel.TabIndex = 25
        Me.DescripLabel.Text = "Description"
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(337, 1)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(46, 16)
        Me.TimeLabel.TabIndex = 26
        Me.TimeLabel.Text = "Times"
        '
        'roomLabel
        '
        Me.roomLabel.AutoSize = True
        Me.roomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.roomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roomLabel.Location = New System.Drawing.Point(441, 1)
        Me.roomLabel.Name = "roomLabel"
        Me.roomLabel.Size = New System.Drawing.Size(45, 16)
        Me.roomLabel.TabIndex = 27
        Me.roomLabel.Text = "Room"
        '
        'UnitLabel
        '
        Me.UnitLabel.AutoSize = True
        Me.UnitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UnitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnitLabel.Location = New System.Drawing.Point(542, 1)
        Me.UnitLabel.Name = "UnitLabel"
        Me.UnitLabel.Size = New System.Drawing.Size(31, 16)
        Me.UnitLabel.TabIndex = 28
        Me.UnitLabel.Text = "Unit"
        '
        'statusLabel
        '
        Me.statusLabel.AutoSize = True
        Me.statusLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.statusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusLabel.Location = New System.Drawing.Point(633, 1)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(45, 16)
        Me.statusLabel.TabIndex = 29
        Me.statusLabel.Text = "Status"
        '
        'P2CheckBox
        '
        Me.P2CheckBox.AutoSize = True
        Me.P2CheckBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.P2CheckBox.Location = New System.Drawing.Point(4, 57)
        Me.P2CheckBox.Name = "P2CheckBox"
        Me.P2CheckBox.Size = New System.Drawing.Size(65, 17)
        Me.P2CheckBox.TabIndex = 30
        Me.P2CheckBox.Text = "PSY202"
        Me.P2CheckBox.UseVisualStyleBackColor = False
        Me.P2CheckBox.Visible = False
        '
        'P4CheckBox
        '
        Me.P4CheckBox.AutoSize = True
        Me.P4CheckBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.P4CheckBox.Location = New System.Drawing.Point(4, 88)
        Me.P4CheckBox.Name = "P4CheckBox"
        Me.P4CheckBox.Size = New System.Drawing.Size(61, 17)
        Me.P4CheckBox.TabIndex = 31
        Me.P4CheckBox.Text = "Psy214"
        Me.P4CheckBox.UseVisualStyleBackColor = False
        Me.P4CheckBox.Visible = False
        '
        'P2desLabel
        '
        Me.P2desLabel.AutoSize = True
        Me.P2desLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2desLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2desLabel.Location = New System.Drawing.Point(118, 54)
        Me.P2desLabel.Name = "P2desLabel"
        Me.P2desLabel.Size = New System.Drawing.Size(77, 15)
        Me.P2desLabel.TabIndex = 32
        Me.P2desLabel.Text = "Psychology II"
        Me.P2desLabel.Visible = False
        '
        'P4desLabel
        '
        Me.P4desLabel.AutoSize = True
        Me.P4desLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4desLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4desLabel.Location = New System.Drawing.Point(118, 85)
        Me.P4desLabel.Name = "P4desLabel"
        Me.P4desLabel.Size = New System.Drawing.Size(113, 15)
        Me.P4desLabel.TabIndex = 33
        Me.P4desLabel.Text = "Psychology of Idiots"
        Me.P4desLabel.Visible = False
        '
        'MdesLabel
        '
        Me.MdesLabel.AutoSize = True
        Me.MdesLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MdesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MdesLabel.Location = New System.Drawing.Point(118, 23)
        Me.MdesLabel.Name = "MdesLabel"
        Me.MdesLabel.Size = New System.Drawing.Size(126, 15)
        Me.MdesLabel.TabIndex = 34
        Me.MdesLabel.Text = "Discrete Mathematics"
        Me.MdesLabel.Visible = False
        '
        'MtimeLabel
        '
        Me.MtimeLabel.AutoSize = True
        Me.MtimeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MtimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MtimeLabel.Location = New System.Drawing.Point(337, 23)
        Me.MtimeLabel.Name = "MtimeLabel"
        Me.MtimeLabel.Size = New System.Drawing.Size(51, 26)
        Me.MtimeLabel.TabIndex = 35
        Me.MtimeLabel.Text = "Wed 3-4," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Fri 12-2"
        Me.MtimeLabel.Visible = False
        '
        'P2timeLabel
        '
        Me.P2timeLabel.AutoSize = True
        Me.P2timeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2timeLabel.Location = New System.Drawing.Point(337, 54)
        Me.P2timeLabel.Name = "P2timeLabel"
        Me.P2timeLabel.Size = New System.Drawing.Size(58, 26)
        Me.P2timeLabel.TabIndex = 36
        Me.P2timeLabel.Text = "Tues 12-1," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thur 2-4"
        Me.P2timeLabel.Visible = False
        '
        'P4timeLabel
        '
        Me.P4timeLabel.AutoSize = True
        Me.P4timeLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4timeLabel.Location = New System.Drawing.Point(337, 85)
        Me.P4timeLabel.Name = "P4timeLabel"
        Me.P4timeLabel.Size = New System.Drawing.Size(55, 26)
        Me.P4timeLabel.TabIndex = 37
        Me.P4timeLabel.Text = "Mon 8-10," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Wed 12-1"
        Me.P4timeLabel.Visible = False
        '
        'MroomLabel
        '
        Me.MroomLabel.AutoSize = True
        Me.MroomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MroomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MroomLabel.Location = New System.Drawing.Point(441, 23)
        Me.MroomLabel.Name = "MroomLabel"
        Me.MroomLabel.Size = New System.Drawing.Size(65, 15)
        Me.MroomLabel.TabIndex = 38
        Me.MroomLabel.Text = "KHE321-C"
        Me.MroomLabel.Visible = False
        '
        'P2roomLabel
        '
        Me.P2roomLabel.AutoSize = True
        Me.P2roomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2roomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2roomLabel.Location = New System.Drawing.Point(441, 54)
        Me.P2roomLabel.Name = "P2roomLabel"
        Me.P2roomLabel.Size = New System.Drawing.Size(46, 15)
        Me.P2roomLabel.TabIndex = 39
        Me.P2roomLabel.Text = "VIC500"
        Me.P2roomLabel.Visible = False
        '
        'P4roomLabel
        '
        Me.P4roomLabel.AutoSize = True
        Me.P4roomLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4roomLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P4roomLabel.Location = New System.Drawing.Point(441, 85)
        Me.P4roomLabel.Name = "P4roomLabel"
        Me.P4roomLabel.Size = New System.Drawing.Size(53, 15)
        Me.P4roomLabel.TabIndex = 40
        Me.P4roomLabel.Text = "KHE114"
        Me.P4roomLabel.Visible = False
        '
        'MunitLabel
        '
        Me.MunitLabel.AutoSize = True
        Me.MunitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MunitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MunitLabel.Location = New System.Drawing.Point(542, 23)
        Me.MunitLabel.Name = "MunitLabel"
        Me.MunitLabel.Size = New System.Drawing.Size(14, 15)
        Me.MunitLabel.TabIndex = 41
        Me.MunitLabel.Text = "1"
        Me.MunitLabel.Visible = False
        '
        'P2unitLabel
        '
        Me.P2unitLabel.AutoSize = True
        Me.P2unitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P2unitLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P2unitLabel.Location = New System.Drawing.Point(542, 54)
        Me.P2unitLabel.Name = "P2unitLabel"
        Me.P2unitLabel.Size = New System.Drawing.Size(14, 15)
        Me.P2unitLabel.TabIndex = 42
        Me.P2unitLabel.Text = "1"
        Me.P2unitLabel.Visible = False
        '
        'P4unitLabel
        '
        Me.P4unitLabel.AutoSize = True
        Me.P4unitLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.P4unitLabel.Location = New System.Drawing.Point(542, 85)
        Me.P4unitLabel.Name = "P4unitLabel"
        Me.P4unitLabel.Size = New System.Drawing.Size(13, 13)
        Me.P4unitLabel.TabIndex = 43
        Me.P4unitLabel.Text = "1"
        Me.P4unitLabel.Visible = False
        '
        'MPictureBox
        '
        Me.MPictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.green_circle2
        Me.MPictureBox.Location = New System.Drawing.Point(633, 26)
        Me.MPictureBox.Name = "MPictureBox"
        Me.MPictureBox.Size = New System.Drawing.Size(20, 20)
        Me.MPictureBox.TabIndex = 44
        Me.MPictureBox.TabStop = False
        Me.MPictureBox.Visible = False
        '
        'P2PictureBox
        '
        Me.P2PictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.blue_circle1
        Me.P2PictureBox.Location = New System.Drawing.Point(633, 57)
        Me.P2PictureBox.Name = "P2PictureBox"
        Me.P2PictureBox.Size = New System.Drawing.Size(20, 20)
        Me.P2PictureBox.TabIndex = 45
        Me.P2PictureBox.TabStop = False
        Me.P2PictureBox.Visible = False
        '
        'P4PictureBox
        '
        Me.P4PictureBox.Image = Global.CPS613_RAMS_THING.My.Resources.Resources.yellow_circle1
        Me.P4PictureBox.Location = New System.Drawing.Point(633, 88)
        Me.P4PictureBox.Name = "P4PictureBox"
        Me.P4PictureBox.Size = New System.Drawing.Size(20, 20)
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
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90.0!))
        Me.courseTableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
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
        Me.courseTableLayoutPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.courseTableLayoutPanel.Location = New System.Drawing.Point(43, 150)
        Me.courseTableLayoutPanel.Name = "courseTableLayoutPanel"
        Me.courseTableLayoutPanel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.courseTableLayoutPanel.RowCount = 11
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.50943!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.49057!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.courseTableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.courseTableLayoutPanel.Size = New System.Drawing.Size(711, 348)
        Me.courseTableLayoutPanel.TabIndex = 47
        '
        'CourseSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 586)
        Me.Controls.Add(Me.courseTableLayoutPanel)
        Me.Controls.Add(Me.waitLabel)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.closedLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.openLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.legendLabel)
        Me.Controls.Add(Me.courseListView)
        Me.Controls.Add(Me.doneButton)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.searchButton)
        Me.Name = "CourseSearch"
        Me.Text = "Search"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P2PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P4PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.courseTableLayoutPanel.ResumeLayout(False)
        Me.courseTableLayoutPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchButton As Button
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents doneButton As Button
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
End Class
