Public Class Login

    Friend user As String
    Dim pass As String
    Dim hayConfig As Boolean


    Private Sub ConfigureUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfigureUserToolStripMenuItem.Click
        If hayConfig = False Then
            cambiarPos()
            Configuration.Show()
        ElseIf hayConfig = True Then
            Dim resp As Integer
            resp = MsgBox("A configuration already exists, do you want to delete the existing" & _
            "Configuration and create a new one?", MsgBoxStyle.OkCancel, "Reset Configuration?")
            Console.WriteLine("resp = " & resp)
            If resp = 1 Then
                cambiarPos()
                Configuration.Show()
            End If
        End If
    End Sub

    Private Sub cambiarPos()        
        Me.Location = New Point(250, 272)
    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load        
        leerConfig()
    End Sub

    Private Sub leerConfig()
        Dim reader As System.IO.StreamReader
        reader = New System.IO.StreamReader(".../Data/config.txt")

        For i = 0 To 2
            If i = 0 Then
                user = reader.ReadLine()
            End If
            If i = 1 Then
                pass = reader.ReadLine()
            End If
        Next

        If user = Nothing Or pass = Nothing Then
            hayConfig = False
        Else
            hayConfig = True
        End If
    End Sub

    Private Sub enterBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterBoton.Click
        If userText.Text = user And passText.Text = pass Then
            Main.Show()
            Me.Hide()
        Else
            MsgBox("Invalid username or password.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class