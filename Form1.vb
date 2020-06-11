Public Class Form1

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 4 Then
            Quality_Indicator.Text = "MAXRES"
        End If
        If TrackBar1.Value = 3 Then
            Quality_Indicator.Text = "SD"
        End If
        If TrackBar1.Value = 2 Then
            Quality_Indicator.Text = "HQ"
        End If
        If TrackBar1.Value = 1 Then
            Quality_Indicator.Text = "MQ"
        End If
    End Sub
    Private Sub get_imglink()
        If TrackBar1.Value = 1 Then
            imgurl.Text = "https://i.ytimg.com/vi/" + Class1.id + "/mqdefault.jpg"
        End If
        If TrackBar1.Value = 2 Then
            imgurl.Text = "https://i.ytimg.com/vi/" + Class1.id + "/hqdefault.jpg"
        End If
        If TrackBar1.Value = 3 Then
            imgurl.Text = "https://i.ytimg.com/vi/" + Class1.id + "/sddefault.jpg"
        End If
        If TrackBar1.Value = 4 Then
            imgurl.Text = "https://i.ytimg.com/vi/" + Class1.id + "/maxresdefault.jpg"
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Mid(TextBox1.Text, 1, 8) = "https://" Then
        Else
            If Mid(TextBox1.Text, 1, 7) = "http://" Then
                TextBox1.Text = "https://" + Mid(TextBox1.Text, 8, TextBox1.Text.Length - 7)
            Else
                Class1.id = ""
                Class1.t = 0
                Class1.s = False
                MessageBox.Show("This is not a correct URL to a YouTube video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
        If Mid(TextBox1.Text, 1, 32) = "https://www.youtube.com/watch?v=" Then
            Class1.t = 1
            Class1.s = True
        End If
        If Mid(TextBox1.Text, 1, 17) = "https://youtu.be/" Then
            Class1.t = 2
            Class1.s = True
        End If
        If Mid(TextBox1.Text, 1, 30) = "https://www.youtube.com/embed/" Then
            Class1.t = 3
            Class1.s = True
        End If
        If Class1.s = True Then
            If Class1.t = 1 Then
                Class1.id = Mid(TextBox1.Text, 33, 11)
            End If
            If Class1.t = 2 Then
                Class1.id = Mid(TextBox1.Text, 18, 11)
            End If
            If Class1.t = 3 Then
                Class1.id = Mid(TextBox1.Text, 31, 11)
            End If
            get_imglink()
        Else
            MessageBox.Show("This is not a correct URL to a YouTube video.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Class1.s = False
        Class1.t = 0
        Class1.id = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Class1.s = True Then
            WebBrowser1.Navigate(imgurl.Text)
        Else
            MessageBox.Show("Sumbit First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Class1.s = True Then
            System.Diagnostics.Process.Start(imgurl.Text)
        Else
            MessageBox.Show("Sumbit First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Class1.s = True Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim Obj_Lob As New System.Net.WebClient()
                Obj_Lob.DownloadFile(imgurl.Text, SaveFileDialog1.FileName.ToString)
            End If
        Else
            MessageBox.Show("Sumbit First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
