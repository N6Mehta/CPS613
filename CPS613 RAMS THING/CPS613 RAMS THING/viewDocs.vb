Public Class viewDocs
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If Taxform.Visible = True Then
            Taxform.Visible = False
            saveTax.Visible = False

            saveTrans.Visible = True
            Transcript.Visible = True

        ElseIf Taxform.Visible = False Then
            saveTrans.Visible = True
            Transcript.Visible = True
        End If
    End Sub

    Private Sub TaxInformation_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TaxInformation.LinkClicked
        If Transcript.Visible = True Then
            Transcript.Visible = False
            saveTrans.Visible = False

            Taxform.Visible = True
            saveTax.Visible = True

        ElseIf Transcript.Visible = False Then
            saveTax.Visible = True
            Taxform.Visible = True
        End If

    End Sub

    Private Sub saveTax_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles saveTax.LinkClicked
        Dim save As New SaveFileDialog
        'Dim newform As New TxtFile
        'newform = Me.ActiveMdiChild


        save.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        save.Filter = "Text [*.txt*]|*.txt|All Files [*.*]|*.*"


        If (save.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim file As String = save.FileName
            Dim writer As System.IO.StreamWriter

            Try
                writer = System.IO.File.AppendText(save.FileName)
                writer.Write(Taxform.Text)
                writer.Flush()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub saveTrans_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles saveTrans.LinkClicked
        Dim save As New SaveFileDialog
        'Dim newform As New TxtFile
        'newform = Me.ActiveMdiChild


        save.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        save.Filter = "Text [*.pdf*]|*.rtf|All Files [*.*]|*.*"


        If (save.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim file As String = save.FileName
            Dim writer As System.IO.StreamWriter

            Try
                writer = System.IO.File.AppendText(save.FileName)
                writer.Write(Transcript.Text)
                writer.Flush()
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class