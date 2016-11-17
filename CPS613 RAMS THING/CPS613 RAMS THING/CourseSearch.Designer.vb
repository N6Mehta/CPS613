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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.filterLabel.Size = New System.Drawing.Size(70, 25)
        Me.filterLabel.TabIndex = 5
        Me.filterLabel.Text = "Filters:"
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
        Me.WTCheckBox.Location = New System.Drawing.Point(751, 155)
        Me.WTCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.WTCheckBox.Name = "WTCheckBox"
        Me.WTCheckBox.Size = New System.Drawing.Size(124, 24)
        Me.WTCheckBox.TabIndex = 12
        Me.WTCheckBox.Text = "Winter Term"
        Me.WTCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(36, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(908, 250)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'CourseSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 721)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Text = "Search For Courses "
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
    Friend WithEvents GroupBox1 As GroupBox
End Class
