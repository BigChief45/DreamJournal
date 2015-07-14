Public Class Configuration
    Dim validacionCorrecta As Boolean = True

    Private Sub submitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles submitButton.Click
        validador.Clear()

        validacionCorrecta = True

        If userText.Text = Nothing Then
            validador.SetError(userText, "You must type a desired username")
            validacionCorrecta = False
        End If
        If passText.Text = Nothing Then
            validador.SetError(passText, "Username must contain a password!")
            validacionCorrecta = False
        End If
        If rpassText.Text = Nothing Then
            validador.SetError(rpassText, "You must retype the password")
            validacionCorrecta = False
        End If

        If Not passText.Text = rpassText.Text Then
            validador.SetError(rpassText, "Passwords do not match")
            validacionCorrecta = False
        End If

        If validacionCorrecta = True Then
            guardarConfig()
        End If
    End Sub

    Private Sub guardarConfig()

        Dim writer As System.IO.StreamWriter
        writer = New System.IO.StreamWriter(".../Data/config.txt", False)

        writer.WriteLine(userText.Text)
        writer.WriteLine(passText.Text)
        writer.Close()

        MsgBox("Configuration successful.", MsgBoxStyle.Exclamation, "Configuration")
        Login.Location = New Point(438, 272) 'Punto Inicial, CENTER SCREEN
        Me.Close()
    End Sub

    Private Sub Configuration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(700, 272)
    End Sub

    Private Sub Configuration_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Location = New Point(438, 272) 'Punto Inicial, CENTER SCREEN
    End Sub
End Class