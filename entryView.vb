Public Class entryView

    Private Sub entryView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = "Viewing Entry: " & viewEntries.dreamName
        titleLabel.Text = viewEntries.dreamName

        typeLabel.Text = "Dream Type: " & viewEntries.dreamType
        dateLabel.Text = "Dream Date: " & viewEntries.dreamDate
        techLabel.Text = "Technique Used: " & viewEntries.dreamTech

        'dreamText.Text = viewEntries.dreamDesc
        dreamText.AppendText(viewEntries.dreamDesc)


    End Sub

    Private Sub entryView_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        viewEntries.Show()
        Me.Hide()

    End Sub
End Class