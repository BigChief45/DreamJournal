Public Class rcReminder

    Private Sub yesBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yesBoton.Click
        MsgBox("Now look at your surroundings, and do a Reality Check!", MsgBoxStyle.Critical, "Reality Check!")
        Me.Hide()
    End Sub

    Private Sub noBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noBoton.Click
        MsgBox("Now look at your surroundings, and do a Reality Check!", MsgBoxStyle.Critical, "Reality Check!")
        Me.Hide()
    End Sub
End Class