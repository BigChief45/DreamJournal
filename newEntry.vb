Public Class newEntry

    Dim camposValidados As Boolean = True
    Private Sub enterBoton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterBoton.Click


        validarCampos()

        If camposValidados = True Then
            crearCarpetas()
            guardarEntry()

        End If
    End Sub
    Private Sub crearCarpetas()
        If My.Computer.FileSystem.DirectoryExists(".../Data/Entries/" & dreamDate.Text) = False Then
            My.Computer.FileSystem.CreateDirectory(".../Data/Entries/" & dreamDate.Value.Year)
            My.Computer.FileSystem.CreateDirectory(".../Data/Entries/" & dreamDate.Value.Year & "/" & dreamDate.Value.Month.ToString())
        End If
    End Sub
    Private Sub guardarEntry()

        'Chequear si existe un archivo con el mismo titulo
        If My.Computer.FileSystem.FileExists(".../Data/Entries/" & dreamDate.Value.Year & "/" & dreamDate.Value.Month.ToString() & "/" & titleText.Text & ".txt") Then
            MsgBox("There is already an entry with that Dream Title, please select another one.", MsgBoxStyle.Critical, "Dream Title already taken")
            Exit Sub
        End If

        Dim writer As System.IO.StreamWriter
        Console.Write("Month = ")
        Console.WriteLine(dreamDate.Value.Month.ToString())

        writer = New System.IO.StreamWriter(".../Data/Entries/" & dreamDate.Value.Year & "/" & dreamDate.Value.Month.ToString() & "/" & titleText.Text & ".txt", True)



        writer.Write(titleText.Text & "#")
        writer.Write(dreamDate.Text & "#")
        writer.Write(dreamType.Text & "#")
        writer.Write(techUsed.Text & "#")
        writer.Write(descText.Text & "#")

        writer.Close()

        MsgBox("Entry saved successfully!", MsgBoxStyle.Exclamation, "Success!")
        Me.Close()
    End Sub

    Private Sub validarCampos()
        camposValidados = True
        validador.Clear()

        If titleText.Text = Nothing Then
            validador.SetError(titleText, "You must enter a title for your dream!")
            camposValidados = False
        End If

        If dreamType.Text = Nothing Then
            validador.SetError(dreamType, "You must select a dream type!")
            camposValidados = False
        End If

        If techUsed.Text = Nothing Then
            validador.SetError(techUsed, "If no technique was used, please select ''None'' from the list!")
            camposValidados = False
        End If

        If descText.Text = Nothing Then
            camposValidados = False
            MsgBox("You must describe or narrate your dream", MsgBoxStyle.Exclamation, "No Dream?")
        End If

    End Sub
End Class