Imports System.IO
Imports System.Net

Public Class Update
    Private Sub Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Cek Koneksi Internet Pada Pc
        Try
            If My.Computer.Network.Ping("www.google.com") Then
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 'Mengatasi Error Ssl 
                Dim address As String = "https://aone-id.github.io/ota/Aone.Id.Oprek.Tools/CatatanRilis.txt"
                Dim client As WebClient = New WebClient()
                Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
                RichTxtBox_Chagelog.Text = reader.ReadToEnd
            End If

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 'Mengatasi Error Ssl 
            Dim chkterbaru As String = "https://aone-id.github.io/ota/Aone.Id.Oprek.Tools/VersiTerbaru.txt"
            Dim pengguna As WebClient = New WebClient()
            Dim baca As StreamReader = New StreamReader(pengguna.OpenRead(chkterbaru))
            TxtBox_VersiUrl.Text = baca.ReadToEnd

            If lbl_version.Text Like TxtBox_VersiUrl.Text Then
                Lbl_Psn_Lama.Visible = False
                Lbl_Psn_Terbaru.Visible = True
                Btn_Download.Visible = False

            Else
                Lbl_Psn_Lama.Visible = True
                Lbl_Psn_Terbaru.Visible = False
            End If

        Catch ex As Exception

            '' Else ''

            MsgBox("No Detected Internet Conection!", MessageBoxIcon.Exclamation, "No Internet Conection!")
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbl_version_Click(sender As Object, e As EventArgs) Handles lbl_version.Click

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles Btn_Download.Click
        'Cek Koneksi Internet Pada Pc
        Try
            If My.Computer.Network.Ping("www.google.com") Then
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 'Mengatasi Error Ssl 
                Dim address As String = "https://aone-id.github.io/ota/Aone.Id.Oprek.Tools/DownloadLink.txt"
                Dim client As WebClient = New WebClient()
                Dim downloadurl As String
                Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
                downloadurl = reader.ReadToEnd
                Process.Start(downloadurl)
            End If
        Catch ex As Exception

            '' Else ''

            MsgBox("No Detected Internet Conection!", MessageBoxIcon.Exclamation, "No Internet Conection!")
        End Try
    End Sub
End Class