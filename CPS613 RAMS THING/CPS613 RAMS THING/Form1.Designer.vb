<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.CourseObject1 = New CPS613_RAMS_THING.CourseObject()
        Me.SuspendLayout()
        '
        'CourseObject1
        '
        Me.CourseObject1.BackColor = System.Drawing.SystemColors.Control
        Me.CourseObject1.Location = New System.Drawing.Point(99, 47)
        Me.CourseObject1.Name = "CourseObject1"
        Me.CourseObject1.Size = New System.Drawing.Size(170, 75)
        Me.CourseObject1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 426)
        Me.Controls.Add(Me.CourseObject1)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.Text = "Ryerson RAMS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CourseObject1 As CourseObject
End Class
