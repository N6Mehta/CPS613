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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MCheckBox = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchButton
        '
        Me.searchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchButton.Location = New System.Drawing.Point(1072, 68)
        Me.searchButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(111, 45)
        Me.searchButton.TabIndex = 0
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTextBox.Location = New System.Drawing.Point(40, 68)
        Me.searchTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(1021, 40)
        Me.searchTextBox.TabIndex = 1
        '
        'cancelButton
        '
        Me.cancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelButton.Location = New System.Drawing.Point(612, 826)
        Me.cancelButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(188, 58)
        Me.cancelButton.TabIndex = 3
        Me.cancelButton.Text = "Cancel"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'doneButton
        '
        Me.doneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doneButton.Location = New System.Drawing.Point(366, 826)
        Me.doneButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.doneButton.Name = "doneButton"
        Me.doneButton.Size = New System.Drawing.Size(184, 58)
        Me.doneButton.TabIndex = 4
        Me.doneButton.Text = "Done"
        Me.doneButton.UseVisualStyleBackColor = True
        '
        'filterLabel
        '
        Me.filterLabel.AutoSize = True
        Me.filterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterLabel.Location = New System.Drawing.Point(46, 140)
        Me.filterLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.filterLabel.Name = "filterLabel"
        Me.filterLabel.Size = New System.Drawing.Size(86, 29)
        Me.filterLabel.TabIndex = 5
        Me.filterLabel.Text = "Filters:"
        '
        'LLCheckBox
        '
        Me.LLCheckBox.AutoSize = True
        Me.LLCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLCheckBox.Location = New System.Drawing.Point(82, 194)
        Me.LLCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LLCheckBox.Name = "LLCheckBox"
        Me.LLCheckBox.Size = New System.Drawing.Size(164, 29)
        Me.LLCheckBox.TabIndex = 6
        Me.LLCheckBox.Text = "Lower Liberals"
        Me.LLCheckBox.UseVisualStyleBackColor = True
        '
        'ULCheckBox
        '
        Me.ULCheckBox.AutoSize = True
        Me.ULCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ULCheckBox.Location = New System.Drawing.Point(82, 255)
        Me.ULCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ULCheckBox.Name = "ULCheckBox"
        Me.ULCheckBox.Size = New System.Drawing.Size(164, 29)
        Me.ULCheckBox.TabIndex = 7
        Me.ULCheckBox.Text = "Upper Liberals"
        Me.ULCheckBox.UseVisualStyleBackColor = True
        '
        'PRCheckBox
        '
        Me.PRCheckBox.AutoSize = True
        Me.PRCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRCheckBox.Location = New System.Drawing.Point(330, 194)
        Me.PRCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PRCheckBox.Name = "PRCheckBox"
        Me.PRCheckBox.Size = New System.Drawing.Size(235, 29)
        Me.PRCheckBox.TabIndex = 8
        Me.PRCheckBox.Text = "Professionally Related "
        Me.PRCheckBox.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(330, 255)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(131, 29)
        Me.CheckBox4.TabIndex = 9
        Me.CheckBox4.Text = "Mandatory"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'OECheckBox
        '
        Me.OECheckBox.AutoSize = True
        Me.OECheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OECheckBox.Location = New System.Drawing.Point(612, 194)
        Me.OECheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OECheckBox.Name = "OECheckBox"
        Me.OECheckBox.Size = New System.Drawing.Size(160, 29)
        Me.OECheckBox.TabIndex = 10
        Me.OECheckBox.Text = "Open Elective"
        Me.OECheckBox.UseVisualStyleBackColor = True
        '
        'FTCheckBox
        '
        Me.FTCheckBox.AutoSize = True
        Me.FTCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FTCheckBox.Location = New System.Drawing.Point(612, 255)
        Me.FTCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FTCheckBox.Name = "FTCheckBox"
        Me.FTCheckBox.Size = New System.Drawing.Size(120, 29)
        Me.FTCheckBox.TabIndex = 11
        Me.FTCheckBox.Text = "Fall Term"
        Me.FTCheckBox.UseVisualStyleBackColor = True
        '
        'WTCheckBox
        '
        Me.WTCheckBox.AutoSize = True
        Me.WTCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WTCheckBox.Location = New System.Drawing.Point(845, 194)
        Me.WTCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.WTCheckBox.Name = "WTCheckBox"
        Me.WTCheckBox.Size = New System.Drawing.Size(146, 29)
        Me.WTCheckBox.TabIndex = 12
        Me.WTCheckBox.Text = "Winter Term"
        Me.WTCheckBox.UseVisualStyleBackColor = True
        '
        'courseListView
        '
        Me.courseListView.Location = New System.Drawing.Point(40, 374)
        Me.courseListView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.courseListView.Name = "courseListView"
        Me.courseListView.Size = New System.Drawing.Size(1021, 442)
        Me.courseListView.TabIndex = 14
        Me.courseListView.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 399)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 25)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Courses:"
        '
        'MCheckBox
        '
        Me.MCheckBox.AutoSize = True
        Me.MCheckBox.BackColor = System.Drawing.SystemColors.Window
        Me.MCheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MCheckBox.Location = New System.Drawing.Point(82, 509)
        Me.MCheckBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MCheckBox.Name = "MCheckBox"
        Me.MCheckBox.Size = New System.Drawing.Size(96, 24)
        Me.MCheckBox.TabIndex = 16
        Me.MCheckBox.Text = "MTH110"
        Me.MCheckBox.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(76, 545)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(957, 231)
        Me.DataGridView1.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Column4"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Column5"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Column6"
        Me.Column6.Name = "Column6"
        '
        'PCheckBox
        '
        Me.PCheckBox.AutoSize = True
        Me.PCheckBox.Location = New System.Drawing.Point(198, 509)
        Me.PCheckBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PCheckBox.Name = "PCheckBox"
        Me.PCheckBox.Size = New System.Drawing.Size(98, 24)
        Me.PCheckBox.TabIndex = 19
        Me.PCheckBox.Text = "PSY 102"
        Me.PCheckBox.UseVisualStyleBackColor = True
        '
        'CourseSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 901)
        Me.Controls.Add(Me.PCheckBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MCheckBox)
        Me.Controls.Add(Me.Label1)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "CourseSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents MCheckBox As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents PCheckBox As CheckBox
End Class
