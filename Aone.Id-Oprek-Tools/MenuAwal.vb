Imports System.IO
Imports System.Threading
Imports System.IO.Compression
Imports System.Net

Public Class MenuAwal
    'Sumber Pembelajaran Bagi Dev Lain!
    'UI MetroFramework  http://thielj.github.io/MetroFramework
    'sebagian Tutorial ada disini  https://forum.xda-developers.com/showthread.php?t=2315695
    'Turorial Menjalankan Shell dan Mendapatkan Output nya https://stackoverflow.com/questions/8809194/get-the-output-of-a-shell-command-in-vb-net
    'Tutorial Pesam Box http://rani-irsan.blogspot.com/2015/12/vbnet-bekerja-dengan-messagebox.html
    'Tutorial Ekstak zip https://youtu.be/Yokq-N3iTA4
    'Mengatasi Error SSL https://stackoverflow.com/questions/46825387/vb-net-the-request-was-aborted-could-not-create-ssl-tls-secure-channel
    'Mendapatkan text dari url https://stackoverflow.com/questions/16655735/vb-net-read-text-from-web-txt-file-and-show-it-in-textbox
    'Mengecek Koneksi  Internet pc https://stackoverflow.com/questions/19669248/check-internet-connection-vb-net
    'Menhide Komponen jika tidak di perlukan https://stackoverflow.com/questions/21015331/how-to-make-a-textbox-and-or-a-listbox-disappear-when-not-needed-in-visual-basic
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

    Private Sub Btn_Dmseg_Click(sender As Object, e As EventArgs)
        Shell("""ADB\adb.exe"" logcat >log.text", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_Logcat_Click(sender As Object, e As EventArgs)
        Shell("""ADB\adb.exe"" shell su -c dmesg >logdmseg.text", AppWinStyle.NormalFocus, True, 30000)
    End Sub

    Private Sub Btn_rbt_System_Click(sender As Object, e As EventArgs) Handles Btn_rbt_System.Click
        Dim x As Object = MessageBox.Show("Are You In Fastboot Mode?", "Confirmation Position!",
                         MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Question)

        If x = System.Windows.Forms.DialogResult.No Then
            Shell("""ADB\adb.exe"" reboot system", AppWinStyle.NormalFocus, True, 30000)
        ElseIf x = System.Windows.Forms.DialogResult.Yes Then
            Shell("""ADB\fastboot.exe"" reboot", AppWinStyle.NormalFocus, True, 30000)
        Else
            'kosong karena cancel
        End If
    End Sub

    Private Sub Btn_rbt_Bootloader_Click(sender As Object, e As EventArgs) Handles Btn_rbt_Bootloader.Click
        Dim x As Object = MessageBox.Show("Are You In System mode ?", "Confirmation Position!",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question)
        If x = System.Windows.Forms.DialogResult.Yes Then
            Shell("""Adb\adb.exe"" reboot bootloader", AppWinStyle.NormalFocus, True, 30000)
        Else
            'kosong karena no ngak jadi
        End If
    End Sub

    Private Sub Btn_rbt_Recovery_Click(sender As Object, e As EventArgs) Handles Btn_rbt_Recovery.Click
        Dim x As Object = MessageBox.Show("Are You In System mode ?", "Confirmation Position!",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question)
        If x = System.Windows.Forms.DialogResult.Yes Then
            Shell("""Adb\adb.exe"" reboot recovery", AppWinStyle.NormalFocus, True, 30000)
        Else
            'kosong karena no ngak jadi
        End If
    End Sub

    Private Sub Btn_rbt_Edl_Click(sender As Object, e As EventArgs) Handles Btn_rbt_Edl.Click
        Dim x As Object = MessageBox.Show("Are You In Fastboot Mode?", "Confirmation Position!",
                         MessageBoxButtons.YesNoCancel,
                         MessageBoxIcon.Question)

        If x = System.Windows.Forms.DialogResult.No Then
            Shell("""Adb\adb.exe"" reboot edl", AppWinStyle.NormalFocus, True, 30000)
        ElseIf x = System.Windows.Forms.DialogResult.Yes Then
            Shell("""Adb\fastboot.exe"" oem edl", AppWinStyle.NormalFocus, True, 30000)
        Else
            'kosong karena cancel
        End If
    End Sub

    Private Sub Btn_CHG_SlotA_Click(sender As Object, e As EventArgs) Handles Btn_CHG_SlotA.Click
        Dim x As Object = MessageBox.Show("Are You In Fastboot mode ?", "Confirmation Position!",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question)
        If x = System.Windows.Forms.DialogResult.Yes Then
            Shell("""Adb\fastboot.exe"" --set-active=a", AppWinStyle.NormalFocus, True, 30000)
        Else
            'kosong karena no ngak jadi
        End If
    End Sub

    Private Sub Btn_CHG_SlotB_Click(sender As Object, e As EventArgs) Handles Btn_CHG_SlotB.Click
        Dim x As Object = MessageBox.Show("Are You In Fastboot mode ?", "Confirmation Position!",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question)
        If x = System.Windows.Forms.DialogResult.Yes Then
            Shell("""Adb\fastboot.exe"" --set-active=b", AppWinStyle.NormalFocus, True, 30000)
        Else
            'kosong karena no ngak jadi
        End If
    End Sub

    Private Sub Btn_Check_CurrentSlot_Click(sender As Object, e As EventArgs) Handles Btn_Check_CurrentSlot.Click
        MsgBox("Goto Tab Device Check, In Device Info Press Bootloader You Will Know You Current Slot!", MessageBoxIcon.Information, "Info!")
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
            Shell("""Adb\fastboot.exe""erase config", AppWinStyle.NormalFocus, True, 30000)
        ElseIf x = System.Windows.Forms.DialogResult.Cancel Then
        End If
    End Sub

    Private Sub Btn_filePush_Click_1(sender As Object, e As EventArgs) Handles Btn_filePush.Click
        If TxtBox_Push.Text = String.Empty Then
            MsgBox("Push Location Empty Returned To Default Location Try Again!", MessageBoxIcon.Exclamation, "Warning!")
            TxtBox_Push.Text = "/mnt/sdcard/"

        ElseIf List_Push.Text = String.Empty Then
            MsgBox("No Selected Folder And File To Push!", MessageBoxIcon.Exclamation, "Warning!")
        Else
            Shell("""Adb\adb.exe"" push " & List_Push.SelectedItem & " " & TxtBox_Push.Text, AppWinStyle.NormalFocus, True, 30000)
        End If
    End Sub

    Private Sub TxtBox_Push_Click(sender As Object, e As EventArgs) Handles TxtBox_Push.Click

    End Sub

    Private Sub Btn_Apk_Install_Click_1(sender As Object, e As EventArgs) Handles Btn_Apk_Install.Click
        If List_Apk.Text = String.Empty Then
            MsgBox(" No Selected Folder And APK!", MessageBoxIcon.Exclamation, "Warning!")
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

            'Mendeteksi jika ada minimal adb sudah  terpasang pada sistem
            If File.Exists("C:\Program Files (x86)\Minimal ADB and Fastboot\unins000.exe") Then
                My.Computer.FileSystem.CopyDirectory("C:\Program Files (x86)\Minimal ADB and Fastboot\", "Adb\", True)
                MsgBox("Detected Minimal Adb And Fastboot Installed!", MessageBoxIcon.Information, "Information!")
            Else
                MsgBox("No Detected Minimal Adb And Fastboot Installed! Select Platfrom Tools Zip FIle!", MessageBoxIcon.Warning, "Information!")

                Using PlatfromTools As New OpenFileDialog
                    PlatfromTools.Filter = "Zip File (*Zip*)|*Zip*"
                    PlatfromTools.Title = "Select Platfrom Tools File Zip "
                    If PlatfromTools.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Dim LksFile As String = PlatfromTools.FileName
                        Dim LksAdb As String = "Adb\"
                        ZipFile.ExtractToDirectory(LksFile, LksAdb)
                        If File.Exists("Adb\platform-tools\adb.exe") Then
                            My.Computer.FileSystem.CopyDirectory("Adb\platform-tools", "Adb\", True)
                            If Not File.Exists("platfromdel.bat") Then
                                File.WriteAllText("platfromdel.bat", My.Resources.platfromdel)
                                Process.Start("platfromdel.bat")
                            End If
                        Else
                            MsgBox("Wrong FIle Platfrom Tools", MessageBoxIcon.Warning, "Wrong File!")
                            If Not File.Exists("Del.bat") Then
                                File.WriteAllText("Del.bat", My.Resources.Del)
                            End If
                            Process.Start("Del.bat")
                            Application.Exit()

                        End If
                    Else
                        MsgBox("This Tool Wil Not Work Wihout Adb Or Platfrom Tools", MessageBoxIcon.Error, "Fatal Missing ADB!")
                        If Not File.Exists("Del.bat") Then
                            File.WriteAllText("Del.bat", My.Resources.Del)
                        End If
                        Process.Start("Del.bat")
                        Application.Exit()
                        End
                    End If
                End Using
            End If
        End If
        'Cek Koneksi Internet Pada Pc
        Try
            If My.Computer.Network.Ping("www.google.com") Then
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 'Mengatasi Error Ssl 
                Dim address As String = "https://aone-id.github.io/ota/Aone.Id.Oprek.Tools/Pesan.txt"
                Dim client As WebClient = New WebClient()
                Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
                TxtBox_PesanUrl.Text = reader.ReadToEnd
            End If

        Catch ex As Exception

            '' Else ''

            TxtBox_PesanUrl.Visible = False
        End Try



    End Sub

    Private Sub Btn_Recov_Flash_Click(sender As Object, e As EventArgs) Handles Btn_Recov_Flash.Click
        If TxtBox_Img.Text = String.Empty Then
            MsgBox("Please Select Img File First!", MessageBoxIcon.Exclamation, "Warning!")
        Else
            If ChkBox_FlashModeUnlock.Checked Then
                Shell("""Adb\fastboot.exe"" flash " & TxtBox_Img.Text.ToString, AppWinStyle.NormalFocus, True, 30000)
            Else
                MsgBox("Please Checked Flash Mode = Allow For Use flash Method!", MessageBoxIcon.Information, "Information!")
                MsgBox("If Your Phone Is Xiaomi MI A1 / MI A2 / MI A3 Dont Use Flash Mode To Install TWRP Or Any Recovery!", MessageBoxIcon.Information, "Information!")
            End If
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

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chkbox_Oem.CheckedChanged
        ''berlaku 1 tidak 3 opsi jadi jika user menceklist 1 checkbox yang lain nya akan tidak terchecklist
        If Chkbox_Oem.Checked Then
            Chkbox_Flashing_Critical.CheckState = CheckState.Unchecked
            Chkbox_Flashing.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub Chkbox_Flashing_Critical_CheckedChanged(sender As Object, e As EventArgs) Handles Chkbox_Flashing_Critical.CheckedChanged
        ''berlaku 1 tidak 3 opsi jadi jika user menceklist 1 checkbox yang lain nya akan tidak terchecklist
        If Chkbox_Flashing_Critical.Checked Then
            Chkbox_Oem.CheckState = CheckState.Unchecked
            Chkbox_Flashing.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub Btn_Unlock_Click(sender As Object, e As EventArgs) Handles Btn_Unlock.Click

        If Chkbox_Oem.Checked Then
            Dim oProcess As New Process()
            Dim oStartInfo As New ProcessStartInfo("adb\fastboot.exe", "oem unlock")
            oStartInfo.UseShellExecute = False
            oStartInfo.RedirectStandardOutput = True
            oProcess.StartInfo = oStartInfo
            oProcess.Start()

            Dim sOutput As String
            Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
                sOutput = oStreamReader.ReadToEnd()
            End Using
            Console.WriteLine(sOutput)
            TxtBox_Bootloader.Text = sOutput

        ElseIf Chkbox_Flashing_Critical.Checked Then
            Dim pProcess As New Process()
            Dim pStartInfo As New ProcessStartInfo("adb\fastboot.exe", "flashing unlock_critical")
            pStartInfo.UseShellExecute = False
            pStartInfo.RedirectStandardOutput = True
            pProcess.StartInfo = pStartInfo
            pProcess.Start()

            Dim pOutput As String
            Using oStreamReader As System.IO.StreamReader = pProcess.StandardOutput
                pOutput = oStreamReader.ReadToEnd()
            End Using
            Console.WriteLine(pOutput)
            TxtBox_Bootloader.Text = pOutput

        ElseIf Chkbox_Flashing.Checked Then
            Dim pProcess As New Process()
            Dim pStartInfo As New ProcessStartInfo("adb\fastboot.exe", "flashing unlock")
            pStartInfo.UseShellExecute = False
            pStartInfo.RedirectStandardOutput = True
            pProcess.StartInfo = pStartInfo
            pProcess.Start()

            Dim pOutput As String
            Using oStreamReader As System.IO.StreamReader = pProcess.StandardOutput
                pOutput = oStreamReader.ReadToEnd()
            End Using
            Console.WriteLine(pOutput)
            TxtBox_Bootloader.Text = pOutput
        Else
            MsgBox("Please Select Option Frist !", MessageBoxIcon.Exclamation, "Warning!")

        End If

    End Sub

    Private Sub Btn_Lock_Click(sender As Object, e As EventArgs) Handles Btn_Lock.Click
        If Chkbox_Oem.Checked Then
            Dim oProcess As New Process()
            Dim oStartInfo As New ProcessStartInfo("adb\fastboot.exe", "oem lock")
            oStartInfo.UseShellExecute = False
            oStartInfo.RedirectStandardOutput = True
            oProcess.StartInfo = oStartInfo
            oProcess.Start()

            Dim sOutput As String
            Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
                sOutput = oStreamReader.ReadToEnd()
            End Using
            Console.WriteLine(sOutput)
            TxtBox_Bootloader.Text = sOutput

        ElseIf Chkbox_Flashing_Critical.Checked Then
            Dim pProcess As New Process()
            Dim pStartInfo As New ProcessStartInfo("adb\fastboot.exe", "flashing lock_critical")
            pStartInfo.UseShellExecute = False
            pStartInfo.RedirectStandardOutput = True
            pProcess.StartInfo = pStartInfo
            pProcess.Start()

            Dim pOutput As String
            Using oStreamReader As System.IO.StreamReader = pProcess.StandardOutput
                pOutput = oStreamReader.ReadToEnd()
            End Using
            Console.WriteLine(pOutput)
            TxtBox_Bootloader.Text = pOutput

        ElseIf Chkbox_Flashing.Checked Then
            Dim pProcess As New Process()
            Dim pStartInfo As New ProcessStartInfo("adb\fastboot.exe", "flashing lock")
            pStartInfo.UseShellExecute = False
            pStartInfo.RedirectStandardOutput = True
            pProcess.StartInfo = pStartInfo
            pProcess.Start()

            Dim pOutput As String
            Using oStreamReader As System.IO.StreamReader = pProcess.StandardOutput
                pOutput = oStreamReader.ReadToEnd()
            End Using
            Console.WriteLine(pOutput)
            TxtBox_Bootloader.Text = pOutput
        Else
            MsgBox("Please Select Option Frist !", MessageBoxIcon.Exclamation, "Warning!")
        End If
    End Sub

    Private Sub Chkbox_Flashing_CheckedChanged(sender As Object, e As EventArgs) Handles Chkbox_Flashing.CheckedChanged
        ''berlaku 1 tidak 3 opsi jadi jika user menceklist 1 checkbox yang lain nya akan tidak terchecklist
        If Chkbox_Flashing.Checked Then
            Chkbox_Flashing_Critical.CheckState = CheckState.Unchecked
            Chkbox_Oem.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub Btn_SelectFile_Click(sender As Object, e As EventArgs) Handles Btn_SelectFile.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Zip File (*ZIP*) Then|*ZIP*"
            ofd.Title = "Select File ZIP"

            If ofd.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.TxtBox_Sideload.Text = ofd.FileName
            End If
        End Using
    End Sub

    Private Sub Btn_AdbSideload_Click(sender As Object, e As EventArgs) Handles Btn_AdbSideload.Click
        If TxtBox_Sideload.Text = String.Empty Then
            MsgBox("Please Select File Sideload!", MessageBoxIcon.Exclamation, "Warning!")
        Else
            Shell("""Adb\fastboot.exe""sideload" & TxtBox_Sideload.Text.ToString, AppWinStyle.NormalFocus, True, 30000)
        End If
    End Sub
    Private Sub MetroToggle1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroToggle1.CheckedChanged
        If MetroToggle1.CheckState = 1 Then
            '''Bahasa indonesia
            Lbel_Dashboard.Text = "Aone.Id Oprek Tools Adalah Sebuah Program Yang dibuat Untuk Memudahkan,
User Untuk Root,Pasang Twrp Dan Dsb"
            Btn_Web.Text = "SITUS WEB"
            Btn_License.Text = "LISENSI"
            Lbl_version.Text = "Versi"

        ElseIf MetroToggle1.CheckState = 0 Then
            ''' Balik Ke English
            Lbel_Dashboard.Text = "Aone.Id Oprek Tools is a program created to make it easier for users to root, 
install Twrp, open bootloaders and much more."
            Btn_Web.Text = "WEBSITE"
            Btn_License.Text = "LICENSE"
            Lbl_version.Text = "Version"
        End If

    End Sub

    Private Sub Lbl_Pesan_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Btn_ChkUpdate_Click(sender As Object, e As EventArgs) Handles Btn_ChkUpdate.Click
        Dim update As New Update
        update.Show()
    End Sub

End Class