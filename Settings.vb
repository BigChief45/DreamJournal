Public Class Settings

    Dim minimizeToTray As Boolean = False
    Dim showFoodReminders As Boolean = False
    Dim foodTimeReminder As Integer = 0
    Dim showRealityCheckReminders As Boolean = False
    Dim rcTimeReminder As Integer = 0
    Dim showRandomEntry As Boolean = False

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        leerSettings()

        If minimizeCheck.Checked = False Then
            foodTimeRem.Text = "0"
            foodTimeRem.Enabled = False
            rcTimeRem.Text = "0"
            rcTimeRem.Enabled = False
        End If

        If foodRemCheck.Checked = False Then
            foodTimeRem.Text = "0"
            foodTimeRem.Enabled = False
        End If

        If rcRemCheck.Checked = False Then
            rcTimeRem.Text = "0"
            rcTimeRem.Enabled = False
        End If

    End Sub

    Private Sub leerSettings()
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

        'Aplicar los valores leidos a los componentes
        minimizeCheck.Checked = minimizeToTray
        foodRemCheck.Checked = showFoodReminders
        foodTimeRem.Text = foodTimeReminder
        rcRemCheck.Checked = showRealityCheckReminders
        rcTimeRem.Text = rcTimeReminder
        randomEntryCheck.Checked = showRandomEntry

        reader.Close()

    End Sub

    Private Sub minimizeCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minimizeCheck.CheckedChanged
        'El control ha sido checkeado/descheckeado

        If minimizeCheck.Checked = False Then
            'Deshabilitar opcion de minutos para Lucid Foods
            foodTimeRem.Text = "0"
            foodTimeRem.Enabled = False

            'Deshabilitar opcion de minutos para Reality Checks
            rcTimeRem.Text = "0"
            rcTimeRem.Enabled = False
        ElseIf minimizeCheck.Checked = True Then

            If foodRemCheck.Checked = True Then
                'Habilitar opcion de minutos para Lucid Foods
                foodTimeRem.Text = "0"
                foodTimeRem.Enabled = True
            End If

            If rcRemCheck.Checked = True Then
                'Habilitar opcion de minutos para Reality Checks
                rcTimeRem.Text = "0"
                rcTimeRem.Enabled = True
            End If
        End If


    End Sub

    Private Sub enterBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterBoton.Click
        'Guardar las settings obtenidas
        Dim writer As System.IO.StreamWriter
        writer = New System.IO.StreamWriter(".../Data/settings.txt", False)

        writer.WriteLine(minimizeCheck.Checked)
        writer.WriteLine(foodRemCheck.Checked & "#" & foodTimeRem.Text)        
        writer.WriteLine(rcRemCheck.Checked & "#" & rcTimeRem.Text)
        writer.WriteLine(randomEntryCheck.Checked)

        writer.Close()

        MsgBox("The new settings have been saved.", MsgBoxStyle.Exclamation, "Success")
        Main.loadSettings()
        Me.Hide()
    End Sub

    Private Sub foodRemCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles foodRemCheck.CheckedChanged
        If foodRemCheck.Checked = False Or minimizeCheck.Checked = False Then
            foodTimeRem.Text = "0"
            foodTimeRem.Enabled = False
        ElseIf foodRemCheck.Checked = True Then
            foodTimeRem.Text = "0"
            foodTimeRem.Enabled = True
        End If
    End Sub

    Private Sub rcRemCheck_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rcRemCheck.CheckedChanged
        If rcRemCheck.Checked = False Or minimizeCheck.Checked = False Then
            rcTimeRem.Text = "0"
            rcTimeRem.Enabled = False
        ElseIf rcRemCheck.Checked = True Then
            rcTimeRem.Text = "0"
            rcTimeRem.Enabled = True
        End If
    End Sub
End Class