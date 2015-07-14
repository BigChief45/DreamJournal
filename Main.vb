Public Class Main
    Dim minimizeToTray As Boolean = False
    Dim showFoodReminders As Boolean = False
    Dim foodTimeReminder As Integer = 0
    Dim showRealityCheckReminders As Boolean = False
    Dim rcTimeReminder As Integer = 0
    Dim showRandomEntry As Boolean = False

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        welcomeLabel.Text = "Welcome " & Login.user & "!"
        loadSettings()
    End Sub
    Public Sub loadSettings()
        'Cargar las User settings
        Dim reader As System.IO.StreamReader
        reader = New System.IO.StreamReader(".../Data/settings.txt")


        'Leer las settings y guardar sus valores
        For i = 0 To 3
            If i = 0 Then
                minimizeToTray = reader.ReadLine()
            End If
            If i = 1 Then
                Dim foodReminders As String = reader.ReadLine()
                Dim foodReminders_arreglo() As String = foodReminders.Split("#")
                showFoodReminders = foodReminders_arreglo(0).ToString()
                foodTimeReminder = foodReminders_arreglo(1).ToString()

            End If
            If i = 2 Then
                Dim rcReminders As String = reader.ReadLine()
                Dim rcReminders_arreglo() As String = rcReminders.Split("#")
                showRealityCheckReminders = rcReminders_arreglo(0).ToString()
                rcTimeReminder = rcReminders_arreglo(1).ToString()
            End If
            If i = 3 Then
                showRandomEntry = reader.ReadLine()
            End If
        Next

        reader.Close()
        applyTimerSettings()
    End Sub

    Private Sub applyTimerSettings()
        Console.WriteLine("foodInterval = " & foodTimeReminder)
        'Console.WriteLine("conversion = " & (foodTimeReminder * 60) * 1000)
        If foodTimeReminder > 0 Then
            foodTimer.Interval = (foodTimeReminder * 60) * 1000
        End If
        If rcTimeReminder > 0 Then
            rcTimer.Interval = (rcTimeReminder * 60) * 1000
        End If

        foodTimer.Enabled = showFoodReminders
        rcTimer.Enabled = showRealityCheckReminders

        If foodTimer.Enabled = True Then
            foodTimer.Start()
        End If

        If rcTimer.Enabled = True Then
            rcTimer.Start()
        End If
    End Sub
    Private Sub newEntryBoton_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newEntryBoton.MouseHover
        'Cambiar las ventanas
        leftWindow.Image = Image.FromFile(".../Imgs/Window4.gif")
        rightWindow.Image = Image.FromFile(".../Imgs/Window4.gif")
    End Sub

    Private Sub Main_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseHover
        'Cambiar las ventanas
        leftWindow.Image = Image.FromFile(".../Imgs/Window2.gif")
        rightWindow.Image = Image.FromFile(".../Imgs/Window2.gif")
    End Sub

    Private Sub readEntryBoton_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles readEntryBoton.MouseHover
        'Cambiar las ventanas
        leftWindow.Image = Image.FromFile(".../Imgs/Window5.gif")
        rightWindow.Image = Image.FromFile(".../Imgs/Window5.gif")
    End Sub

    Private Sub Main_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If minimizeToTray = False Then
            Application.Exit()
        Else
            Application.Exit()

        End If
    End Sub

    Private Sub newEntryBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newEntryBoton.Click
        newEntry.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        Settings.Show()
    End Sub

    Private Sub Button1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
        'Cambiar las ventanas
        leftWindow.Image = Image.FromFile(".../Imgs/Window6.gif")
        rightWindow.Image = Image.FromFile(".../Imgs/Window6.gif")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub foodTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles foodTimer.Tick
        foodReminder.Show()
    End Sub

    Private Sub rcTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rcTimer.Tick
        rcReminder.Show()
    End Sub

    Private Sub readEntryBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles readEntryBoton.Click
        viewEntries.Show()
    End Sub
End Class
