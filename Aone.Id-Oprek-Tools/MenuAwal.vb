Imports System.IO
Imports System.Threading
Public Class MenuAwal
    'sebagian Tutorial ada disini  https://forum.xda-developers.com/showthread.php?t=2315695
    'Turorial Menjalankan Shell dan Mendapatkan Output nya https://stackoverflow.com/questions/8809194/get-the-output-of-a-shell-command-in-vb-net
    'Tutorial Pesam Box http://rani-irsan.blogspot.com/2015/12/vbnet-bekerja-dengan-messagebox.html

    Private lstScan As Object

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles Btn_info_System.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("adb\adb.exe", "shell getprop")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        Console.WriteLine(sOutput)
        TextBox_Info.Text = sOutput
    End Sub

    Private Sub Btn_License_Click(sender As Object, e As EventArgs) Handles Btn_License.Click
        Dim lisensi As New License
        lisensi.Show()
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles Btn_Check.Click
        Dim x As Object = MessageBox.Show("Are You In Fastboot Mode?", "Confirmation",
                         MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Question)

        If x = System.Windows.Forms.DialogResult.No Then
            Dim oProcess As New Process()
            Dim oStartInfo As New ProcessStartInfo("adb\adb.exe", "devices")
            oStartInfo.UseShellExecute = False
            oStartInfo.RedirectStandardOutput = True
            oProcess.StartInfo = oStartInfo
            oProcess.Start()

            Dim sOutput As String
            Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
                sOutput = oStreamReader.ReadToEnd()
            End Using
            Console.WriteLine(sOutput)
            TextBox_Info.Text = sOutput

        ElseIf x = System.Windows.Forms.DialogResult.Yes Then

            Dim oProcess As New Process()
            Dim oStartInfo As New ProcessStartInfo("adb\fastboot.exe", "devices")
            oStartInfo.UseShellExecute = False
            oStartInfo.RedirectStandardOutput = True
            oProcess.StartInfo = oStartInfo
            oProcess.Start()

            Dim sOutput As String
            Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
                sOutput = oStreamReader.ReadToEnd()
            End Using
            Console.WriteLine(sOutput)
            TextBox_Info.Text = sOutput
        Else
            '' tidak ada karena buat cancel
        End If


    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles Btn_Info_Bootloader.Click
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("adb\fastboot.exe", "getvar all ")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        Console.WriteLine(sOutput)
        TextBox_Info.Text = sOutput
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
        Shell("""ADB\adb.exe"" logcat >log.text", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_Logcat_Click(sender As Object, e As EventArgs) Handles Btn_Logcat.Click
        Shell("""ADB\adb.exe"" shell su -c dmesg >logdmseg.text", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_rbt_System_Click(sender As Object, e As EventArgs) Handles Btn_rbt_System.Click
        Shell("""ADB\adb.exe"" reboot system", AppWinStyle.NormalFocus, True, 30000)
        Shell("""ADB\fastboot.exe"" reboot", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_rbt_Bootloader_Click(sender As Object, e As EventArgs) Handles Btn_rbt_Bootloader.Click
        Shell("""Adb\adb.exe"" reboot bootloader", AppWinStyle.NormalFocus, True, 30000)
        Shell("""Adb\fastboot.exe"" reboot", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_rbt_Recovery_Click(sender As Object, e As EventArgs) Handles Btn_rbt_Recovery.Click
        Shell("""Adb\adb.exe"" reboot recovery", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_rbt_Edl_Click(sender As Object, e As EventArgs) Handles Btn_rbt_Edl.Click
        Shell("""Adb\adb.exe"" reboot edl", AppWinStyle.NormalFocus, True, 30000)
        Shell("""Adb\fastboot.exe"" oem edl", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_CHG_SlotA_Click(sender As Object, e As EventArgs) Handles Btn_CHG_SlotA.Click
        Shell("""Adb\fastboot.exe"" --set-active=a", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_CHG_SlotB_Click(sender As Object, e As EventArgs) Handles Btn_CHG_SlotB.Click
        Shell("""Adb\fastboot.exe"" --set-active=b", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_Check_CurrentSlot_Click(sender As Object, e As EventArgs) Handles Btn_Check_CurrentSlot.Click
        Dim CMD As New Process
        CMD.StartInfo.FileName = "adb\CheckActiveSlot.bat"
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

    Private Sub Btn_Apk_Install_Click(sender As Object, e As EventArgs) Handles Btn_Apk_SELECT.Click
        Dim FolderBrowse As New FolderBrowserDialog
        FolderBrowse.Description = "Select the folder containing your APK files."
        FolderBrowse.RootFolder = Environment.SpecialFolder.DesktopDirectory
        FolderBrowse.ShowNewFolderButton = False
        Dim DialogRes As DialogResult = FolderBrowse.ShowDialog()
        If DialogRes = System.Windows.Forms.DialogResult.OK Then
            For Each Item As String In My.Computer.FileSystem.GetFiles(FolderBrowse.SelectedPath)
                List_Apk.Items.Add(Item)
            Next
        End If
    End Sub
    Private Sub Btn_FilePush_Click(sender As Object, e As EventArgs) Handles Btn_File_Select.Click
        Dim FolderBrowse As New FolderBrowserDialog
        FolderBrowse.Description = "Select the folder containing the file/s you want to push to the device..."
        FolderBrowse.ShowNewFolderButton = False
        FolderBrowse.RootFolder = Environment.SpecialFolder.DesktopDirectory
        Dim DialogRes As DialogResult = FolderBrowse.ShowDialog()
        If DialogRes = System.Windows.Forms.DialogResult.OK Then
            For Each Item As String In My.Computer.FileSystem.GetFiles(FolderBrowse.SelectedPath)
                List_Push.Items.Add(Item)
            Next
        End If
    End Sub

    Private Sub Btn_DeviceManager_Click(sender As Object, e As EventArgs) Handles Btn_DeviceManager.Click
        Process.Start("devmgmt.msc")
    End Sub

    Private Sub Btn_AdbRestart_Click(sender As Object, e As EventArgs) Handles Btn_AdbRestart.Click
        Shell("""Adb\adb.exe"" kill-server", AppWinStyle.NormalFocus, True, 30000)
        System.Threading.Thread.Sleep(3000)
        Shell("""Adb\adb.exe"" start-server", AppWinStyle.NormalFocus, True, 30000)

    End Sub

    Private Sub Btn_Frp_Click(sender As Object, e As EventArgs) Handles Btn_Frp.Click
        Dim x As Object = MessageBox.Show("Are you sure?", "Confirmation

",
                         MessageBoxButtons.OKCancel,
                         MessageBoxIcon.Question)

        If x = System.Windows.Forms.DialogResult.OK Then
            Shell("""Adb\fastboot.exe"" erase config", AppWinStyle.NormalFocus, True, 30000)
        ElseIf x = system.Windows.Forms.DialogResult.Cancel Then
        End If
    End Sub

    Private Sub Btn_filePush_Click_1(sender As Object, e As EventArgs) Handles Btn_filePush.Click
        If TxtBox_Push.Text = String.Empty Then
            MsgBox("Push Location Empty Returned To Default Location Try Again!", MessageBoxIcon.Exclamation, "Warning!")
            TxtBox_Push.Text = "/mnt/sdcard/"
        Else
            Shell("""Adb\adb.exe"" push " & List_Push.SelectedItem & " " & TxtBox_Push.Text, AppWinStyle.NormalFocus, True, 30000)
        End If
    End Sub

    Private Sub TxtBox_Push_Click(sender As Object, e As EventArgs) Handles TxtBox_Push.Click

    End Sub

    Private Sub Btn_Apk_Install_Click_1(sender As Object, e As EventArgs) Handles Btn_Apk_Install.Click
        If List_Apk.Text = String.Empty Then
            MsgBox(" No APK Selected!", MessageBoxIcon.Exclamation, "Warning!")
        Else
            Shell("""Adb\adb.exe"" install " & List_Apk.SelectedItem.ToString, AppWinStyle.NormalFocus, True, 30000)
        End If
    End Sub
    Private Sub Btn_Recov_Boot_Click(sender As Object, e As EventArgs) Handles Btn_Recov_Boot.Click
        If TxtBox_Img.Text = String.Empty Then
            MsgBox("Please Select Img File First!", MessageBoxIcon.Exclamation, "Warning!")
        Else
            Shell("""Adb\fastboot.exe"" boot " & TxtBox_Img.Text.ToString, AppWinStyle.NormalFocus, True, 30000)
        End If
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles Btn_FileImgBrowse.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Img File (*IMG*)|*IMG*"
            ofd.Title = "Select File IMG"

            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.TxtBox_Img.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub MenuAwal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Mendeteksi Foldeer Jika tidak ada folder Adb Membuat folder
        If Not Directory.Exists("Adb") Then
            Directory.CreateDirectory("Adb")

            'Mendeteksi Adb Jika tidak Ada Akan Menggunakan Default Adb yang ada di resource
            If Not File.Exists("Adb\adb.exe") Then
                File.WriteAllBytes("Adb\adb.exe", My.Resources.adb)
            End If
            If Not File.Exists("Adb\AdbWinApi.dll") Then
                File.WriteAllBytes("Adb\AdbWinApi.dll", My.Resources.AdbWinApi)
            End If
            If Not File.Exists("Adb\AdbWinUsbApi.dll") Then
                File.WriteAllBytes("Adb\AdbWinUsbApi.dll", My.Resources.AdbWinUsbApi)
            End If
            If Not File.Exists("Adb\fastboot.exe") Then
                File.WriteAllBytes("Adb\fastboot.exe", My.Resources.fastboot)
            End If
        End If
    End Sub

    Private Sub Btn_Recov_Flash_Click(sender As Object, e As EventArgs) Handles Btn_Recov_Flash.Click
        If TxtBox_Img.Text = String.Empty Then
            MsgBox("Please Select Img File First!", MessageBoxIcon.Exclamation, "Warning!")
        Else
            Shell("""Adb\fastboot.exe"" flash " & TxtBox_Img.Text.ToString, AppWinStyle.NormalFocus, True, 30000)
        End If
    End Sub

    Private Sub Btn_Installed_App_Click(sender As Object, e As EventArgs) Handles Btn_Installed_App.Click
        'Menampilkan App yang telah Di install user
        Dim oProcess As New Process()
        Dim oStartInfo As New ProcessStartInfo("adb\adb.exe", "shell pm list packages -3 ")
        oStartInfo.UseShellExecute = False
        oStartInfo.RedirectStandardOutput = True
        oProcess.StartInfo = oStartInfo
        oProcess.Start()

        Dim sOutput As String
        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
            sOutput = oStreamReader.ReadToEnd()
        End Using
        Console.WriteLine(sOutput)
        TextBox_Info.Text = sOutput
    End Sub
End Class