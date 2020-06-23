Public Class MenuAwal
    Private lstScan As Object

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles Btn_info_System.Click
        Dim CMD As New Process
        CMD.StartInfo.FileName = " c:\Program Files\Aone.id Oprek Tools\Script\GetInformationSystem.bat"
        CMD.StartInfo.UseShellExecute = False
        CMD.StartInfo.RedirectStandardInput = True
        CMD.StartInfo.RedirectStandardOutput = True
        CMD.StartInfo.CreateNoWindow = False
        CMD.Start()
        Dim SW As System.IO.StreamWriter = CMD.StandardInput
        Dim SR As System.IO.StreamReader = CMD.StandardOutput
        SW.WriteLine("dir")
        SW.WriteLine("Exit")
        TextBox_Info.Text = SR.ReadToEnd
        SW.Close()
        SR.Close()
        CMD.Close()
    End Sub

    Private Sub Btn_License_Click(sender As Object, e As EventArgs) Handles Btn_License.Click
        Dim lisensi As New License
        lisensi.Show()
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles Btn_Check.Click
        Dim CMD As New Process
        CMD.StartInfo.FileName = " c:\Program Files\Aone.id Oprek Tools\Script\DeviceCheck.bat"
        CMD.StartInfo.UseShellExecute = False
        CMD.StartInfo.RedirectStandardInput = True
        CMD.StartInfo.RedirectStandardOutput = True
        CMD.StartInfo.CreateNoWindow = False
        CMD.Start()
        Dim SW As System.IO.StreamWriter = CMD.StandardInput
        Dim SR As System.IO.StreamReader = CMD.StandardOutput
        SW.WriteLine("dir")
        SW.WriteLine("Exit")
        TextBox_Info.Text = SR.ReadToEnd
        SW.Close()
        SR.Close()
        CMD.Close()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles Btn_Info_Bootloader.Click
        Dim CMD As New Process
        CMD.StartInfo.FileName = " c:\Program Files\Aone.id Oprek Tools\Script\GetInformationBootloader.bat"
        CMD.StartInfo.UseShellExecute = False
        CMD.StartInfo.RedirectStandardInput = True
        CMD.StartInfo.RedirectStandardOutput = True
        CMD.StartInfo.CreateNoWindow = False
        CMD.Start()
        Dim SW As System.IO.StreamWriter = CMD.StandardInput
        Dim SR As System.IO.StreamReader = CMD.StandardOutput
        SW.WriteLine("dir")
        SW.WriteLine("Exit")
        TextBox_Info.Text = SR.ReadToEnd
        SW.Close()
        SR.Close()
        CMD.Close()
    End Sub

    Private Sub Btn_Save_Info_Click(sender As Object, e As EventArgs) Handles Btn_Save_Info.Click
        Dim SaveFile As New SaveFileDialog
        SaveFile.FileName = ""
        SaveFile.Filter = "Text Files (*.txt)|*.txt"
        SaveFile.Title = "Save"
        SaveFile.ShowDialog()
        Try
            Dim Write As New System.IO.StreamWriter(SaveFile.FileName)
            Write.Write(TextBox_Info.Text)
            Write.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btn_Web_Click(sender As Object, e As EventArgs) Handles Btn_Web.Click
        Process.Start("https://aone-id.github.io/")
    End Sub

    Private Sub Btn_Dmseg_Click(sender As Object, e As EventArgs) Handles Btn_Dmseg.Click
        Dim CMD As New Process
        CMD.StartInfo.FileName = " c:\Program Files\Aone.id Oprek Tools\Script\GetDmesg.bat"
        CMD.StartInfo.UseShellExecute = False
        CMD.StartInfo.RedirectStandardInput = True
        CMD.StartInfo.RedirectStandardOutput = True
        CMD.StartInfo.CreateNoWindow = False
        CMD.Start()
        Dim SW As System.IO.StreamWriter = CMD.StandardInput
        Dim SR As System.IO.StreamReader = CMD.StandardOutput
        SW.WriteLine("dir")
        SW.WriteLine("Exit")
        TextBox_Info.Text = SR.ReadToEnd
        SW.Close()
        SR.Close()
        CMD.Close()
    End Sub

    Private Sub Btn_Logcat_Click(sender As Object, e As EventArgs) Handles Btn_Logcat.Click
        Dim CMD As New Process
        CMD.StartInfo.FileName = " c:\Program Files\Aone.id Oprek Tools\Script\Getlogcat.bat"
        CMD.StartInfo.UseShellExecute = False
        CMD.StartInfo.RedirectStandardInput = True
        CMD.StartInfo.RedirectStandardOutput = True
        CMD.StartInfo.CreateNoWindow = False
        CMD.Start()
        Dim SW As System.IO.StreamWriter = CMD.StandardInput
        Dim SR As System.IO.StreamReader = CMD.StandardOutput
        SW.WriteLine("dir")
        SW.WriteLine("Exit")
        TextBox_Info.Text = SR.ReadToEnd
        SW.Close()
        SR.Close()
        CMD.Close()
    End Sub
End Class