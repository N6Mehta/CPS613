<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Minors
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PsyMinorLink = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Available Minors:"
        '
        'PsyMinorLink
        '
        Me.PsyMinorLink.AutoSize = True
        Me.PsyMinorLink.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PsyMinorLink.Location = New System.Drawing.Point(41, 123)
        Me.PsyMinorLink.Name = "PsyMinorLink"
        Me.PsyMinorLink.Size = New System.Drawing.Size(161, 37)
        Me.PsyMinorLink.TabIndex = 1
        Me.PsyMinorLink.TabStop = True
        Me.PsyMinorLink.Text = "Psycology"
        '
        'Minors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 758)
        Me.Controls.Add(Me.PsyMinorLink)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Minors"
        Me.Text = "Minors"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PsyMinorLink As LinkLabel
End Class
