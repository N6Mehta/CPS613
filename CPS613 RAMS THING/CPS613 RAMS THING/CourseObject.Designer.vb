﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseObject
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DropButton = New System.Windows.Forms.Button()
        Me.CourseName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(164, 41)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(30, 30)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "+"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DropButton
        '
        Me.DropButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropButton.Location = New System.Drawing.Point(17, 37)
        Me.DropButton.Name = "DropButton"
        Me.DropButton.Size = New System.Drawing.Size(30, 30)
        Me.DropButton.TabIndex = 1
        Me.DropButton.Text = "-"
        Me.DropButton.UseVisualStyleBackColor = True
        '
        'CourseName
        '
        Me.CourseName.AutoSize = True
        Me.CourseName.Location = New System.Drawing.Point(81, 21)
        Me.CourseName.Name = "CourseName"
        Me.CourseName.Size = New System.Drawing.Size(68, 13)
        Me.CourseName.TabIndex = 2
        Me.CourseName.Text = "CourseName"
        '
        'CourseObject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CourseName)
        Me.Controls.Add(Me.DropButton)
        Me.Controls.Add(Me.AddButton)
        Me.Name = "CourseObject"
        Me.Size = New System.Drawing.Size(230, 120)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents DropButton As Button
    Friend WithEvents CourseName As Label
End Class