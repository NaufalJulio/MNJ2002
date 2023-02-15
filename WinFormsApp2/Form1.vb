Public Class Form1
    Dim awal, akhir, i As Integer

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim checkBox1State As Boolean = CheckBox1.Checked
        Dim checkBox2State As Boolean = CheckBox2.Checked
        Dim checkBox3State As Boolean = CheckBox3.Checked

        Dim fileName As String = "checkboxes.txt"
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)

        file.WriteLine(checkBox1State)
        file.WriteLine(checkBox2State)
        file.WriteLine(checkBox3State)

        file.Close()
        MessageBox.Show("Pengaturan kotak centang berhasil disimpan ke dalam file txt.")
    End Sub

    Private Sub load_Click(sender As Object, e As EventArgs) Handles load.Click
        Dim fileName As String = "checkboxes.txt"
        Dim file As System.IO.StreamReader
        file = My.Computer.FileSystem.OpenTextFileReader(fileName)

        Dim checkBox1State As Boolean = Boolean.Parse(file.ReadLine())
        Dim checkBox2State As Boolean = Boolean.Parse(file.ReadLine())
        Dim checkBox3State As Boolean = Boolean.Parse(file.ReadLine())

        CheckBox1.Checked = checkBox1State
        CheckBox2.Checked = checkBox2State
        CheckBox3.Checked = checkBox3State

        file.Close()

        MessageBox.Show("Pengaturan kotak centang berhasil dimuat dari file txt.")
    End Sub

    Private Sub clrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        List.Items.Clear()
        List2.Items.Clear()
        List3.Items.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        List.Items.Clear()
        List2.Items.Clear()
        List3.Items.Clear()
        If CheckBox1.Checked = False And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            MessageBox.Show("Silahkan pilih opsi terlebih dahulu")
        End If
        If CheckBox1.Checked = True Then
            akhir = TextBox1.Text
            awal = TextBox2.Text
            For i = awal To akhir
                List.Items.Add(i)
            Next
        End If

        If CheckBox2.Checked = True Then
            akhir = TextBox1.Text
            awal = TextBox2.Text
            For i = awal To akhir
                If i Mod 2 = 0 Then
                    List2.Items.Add(i)
                End If
            Next
        End If

        If CheckBox3.Checked = True Then
            akhir = TextBox1.Text
            awal = TextBox2.Text
            For i = awal To akhir
                If i Mod 2 <> 0 Then
                    List3.Items.Add(i)
                End If
            Next
        End If
    End Sub
End Class
