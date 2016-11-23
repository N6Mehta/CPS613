<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewDocs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewDocs))
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Taxform = New System.Windows.Forms.RichTextBox()
        Me.saveTax = New System.Windows.Forms.LinkLabel()
        Me.Transcript = New System.Windows.Forms.RichTextBox()
        Me.saveTrans = New System.Windows.Forms.LinkLabel()
        Me.TaxInformation = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(33, 83)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(254, 29)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Unofficial Transcript "
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Taxform)
        Me.GroupBox1.Controls.Add(Me.saveTax)
        Me.GroupBox1.Controls.Add(Me.Transcript)
        Me.GroupBox1.Controls.Add(Me.saveTrans)
        Me.GroupBox1.Location = New System.Drawing.Point(508, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(993, 1042)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preview Box"
        '
        'Taxform
        '
        Me.Taxform.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Taxform.Location = New System.Drawing.Point(12, 45)
        Me.Taxform.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Taxform.Name = "Taxform"
        Me.Taxform.Size = New System.Drawing.Size(968, 986)
        Me.Taxform.TabIndex = 4
        Me.Taxform.Text = "This is your Tax information. " & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Taxform.Visible = False
        '
        'saveTax
        '
        Me.saveTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveTax.AutoSize = True
        Me.saveTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveTax.Location = New System.Drawing.Point(926, 17)
        Me.saveTax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.saveTax.Name = "saveTax"
        Me.saveTax.Size = New System.Drawing.Size(55, 22)
        Me.saveTax.TabIndex = 3
        Me.saveTax.TabStop = True
        Me.saveTax.Text = "Save"
        Me.saveTax.Visible = False
        '
        'Transcript
        '
        Me.Transcript.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Transcript.Location = New System.Drawing.Point(14, 45)
        Me.Transcript.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Transcript.Name = "Transcript"
        Me.Transcript.Size = New System.Drawing.Size(968, 986)
        Me.Transcript.TabIndex = 2
        Me.Transcript.Text = resources.GetString("Transcript.Text")
        Me.Transcript.Visible = False
        '
        'saveTrans
        '
        Me.saveTrans.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.saveTrans.AutoSize = True
        Me.saveTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveTrans.Location = New System.Drawing.Point(926, 17)
        Me.saveTrans.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.saveTrans.Name = "saveTrans"
        Me.saveTrans.Size = New System.Drawing.Size(55, 22)
        Me.saveTrans.TabIndex = 1
        Me.saveTrans.TabStop = True
        Me.saveTrans.Text = "Save"
        Me.saveTrans.Visible = False
        '
        'TaxInformation
        '
        Me.TaxInformation.AutoSize = True
        Me.TaxInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaxInformation.Location = New System.Drawing.Point(34, 229)
        Me.TaxInformation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TaxInformation.Name = "TaxInformation"
        Me.TaxInformation.Size = New System.Drawing.Size(193, 29)
        Me.TaxInformation.TabIndex = 3
        Me.TaxInformation.TabStop = True
        Me.TaxInformation.Text = "Tax Information"
        '
        'viewDocs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1509, 1038)
        Me.Controls.Add(Me.TaxInformation)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "viewDocs"
        Me.Text = "View Documents"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents saveTrans As LinkLabel
    Friend WithEvents Transcript As RichTextBox
    Friend WithEvents Taxform As RichTextBox
    Friend WithEvents saveTax As LinkLabel
    Friend WithEvents TaxInformation As LinkLabel
End Class
