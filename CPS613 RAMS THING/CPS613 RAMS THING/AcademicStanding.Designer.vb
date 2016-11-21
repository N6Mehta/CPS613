<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AcademicStanding
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
        Me.Title_Label = New System.Windows.Forms.Label()
        Me.StandingLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title_Label
        '
        Me.Title_Label.AutoSize = True
        Me.Title_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title_Label.Location = New System.Drawing.Point(12, 9)
        Me.Title_Label.Name = "Title_Label"
        Me.Title_Label.Size = New System.Drawing.Size(235, 32)
        Me.Title_Label.TabIndex = 0
        Me.Title_Label.Text = "View My Grades"
        '
        'StandingLabel
        '
        Me.StandingLabel.AutoSize = True
        Me.StandingLabel.Location = New System.Drawing.Point(15, 67)
        Me.StandingLabel.Name = "StandingLabel"
        Me.StandingLabel.Size = New System.Drawing.Size(99, 17)
        Me.StandingLabel.TabIndex = 1
        Me.StandingLabel.Text = "StandingLabel"
        '
        'AcademicStanding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 575)
        Me.Controls.Add(Me.StandingLabel)
        Me.Controls.Add(Me.Title_Label)
        Me.Name = "AcademicStanding"
        Me.Text = "AcademicStanding"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title_Label As Label
    Friend WithEvents StandingLabel As Label
End Class
