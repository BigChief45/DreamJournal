Public Class viewEntries
    Friend dreamName As String
    Friend dreamDate As String
    Friend dreamType As String
    Friend dreamTech As String
    Friend dreamDesc As String

    Private Sub viewEntries_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Llenar los anios disponibles
        Dim dirCount As Integer = My.Computer.FileSystem.GetDirectories(".../Data/Entries/").Count

        For i = 0 To dirCount - 1            
            Dim anio As String
            Dim charCount As Integer = My.Computer.FileSystem.GetDirectories(".../Data/Entries/").Item(i).Length
            anio = My.Computer.FileSystem.GetDirectories(".../Data/Entries/").Item(i).Substring(charCount - 4)
            yearCombo.Items.Add(anio)
        Next
    End Sub

    Private Sub monthCombo_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles monthCombo.SelectionChangeCommitted
        'Mostrar la lista de suenios en la listBox
        If Not yearCombo.Text = Nothing Then
            Dim valorMes As Integer = monthCombo.SelectedIndex + 1
            Dim valorAnio As Integer = yearCombo.Text
            Console.WriteLine("valorMes = " & valorMes)
            Console.WriteLine("count = " & My.Computer.FileSystem.GetFiles(".../Data/Entries/" & valorAnio & "/" & valorMes & "/").Count)

            For i = 0 To My.Computer.FileSystem.GetFiles(".../Data/Entries/" & valorAnio & "/" & valorMes & "/").Count - 1
                Dim tituloSuenio As String
                With My.Computer.FileSystem.GetFiles(".../Data/Entries/" & valorAnio & "/" & valorMes & "/").Item(i).ToString()
                    Console.WriteLine("string = " & .ToString())
                    Console.WriteLine("string count = " & .Length)
                    Console.WriteLine("index1 = " & .LastIndexOf("\"))
                    Console.WriteLine("index2 = " & .IndexOf("."))
                    Console.WriteLine("TEST = " & .Substring(.IndexOf(".")))

                    tituloSuenio = .Substring(.LastIndexOf("\") + 1)
                End With
                dreamList.Items.Add(tituloSuenio)
            Next
        End If
    End Sub

    Private Sub dreamList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dreamList.SelectedIndexChanged
        Me.Hide()
        getDreamInfo()
        entryView.Show()
    End Sub

    Private Sub getDreamInfo()
        dreamName = dreamList.SelectedItem.ToString()

        'Declarar un reader para obtener la info del suenio seleccionado
        Dim reader As System.IO.StreamReader
        Dim tempMonth As String = monthCombo.SelectedIndex + 1
        Dim tempYear As String = yearCombo.Text

        reader = New System.IO.StreamReader(".../Data/Entries/" & tempYear & "/" & tempMonth & "/" & dreamName)

        Dim dreamInfo() As String = reader.ReadToEnd().Split("#")
        dreamDate = dreamInfo(1).ToString()
        dreamType = dreamInfo(2).ToString()
        dreamTech = dreamInfo(3).ToString()
        dreamDesc = dreamInfo(4).ToString()

        reader.Close()

    End Sub

    Private Sub mirror_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mirror.Click
        Console.WriteLine("Point 2= " & entryView.Location.X & "," & entryView.Location.Y)
    End Sub
End Class