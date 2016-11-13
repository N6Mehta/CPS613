<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Enrollment
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
        Me.HelpLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'HelpLinkLabel
        '
        Me.HelpLinkLabel.AutoSize = True
        Me.HelpLinkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpLinkLabel.Location = New System.Drawing.Point(1915, 86)
        Me.HelpLinkLabel.Name = "HelpLinkLabel"
        Me.HelpLinkLabel.Size = New System.Drawing.Size(157, 31)
        Me.HelpLinkLabel.TabIndex = 3
        Me.HelpLinkLabel.TabStop = True
        Me.HelpLinkLabel.Text = "Need Help?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(881, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(393, 51)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Computer Science"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(89, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 37)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Year "
        '
        'Enrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(2155, 910)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HelpLinkLabel)
        Me.Name = "Enrollment"
        Me.Text = "Compupter Science Program"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpLinkLabel As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
