<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuAwal
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Tab_Menu = New MetroFramework.Controls.MetroTabControl()
        Me.Tab_Dashboard = New MetroFramework.Controls.MetroTabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btn_License = New MetroFramework.Controls.MetroButton()
        Me.Btn_Web = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Tab_deviceCheck = New MetroFramework.Controls.MetroTabPage()
        Me.Btn_Save_Info = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.Btn_Check = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Btn_info_System = New MetroFramework.Controls.MetroButton()
        Me.Btn_Info_Bootloader = New MetroFramework.Controls.MetroButton()
        Me.TextBox_Info = New MetroFramework.Controls.MetroTextBox()
        Me.Tab_Reboot = New MetroFramework.Controls.MetroTabPage()
        Me.Btn_Check_CurrentSlot = New MetroFramework.Controls.MetroButton()
        Me.Btn_CHG_SlotB = New MetroFramework.Controls.MetroButton()
        Me.Btn_CHG_SlotA = New MetroFramework.Controls.MetroButton()
        Me.Btn_rbt_Bootloader = New MetroFramework.Controls.MetroButton()
        Me.Btn_rbt_Edl = New MetroFramework.Controls.MetroButton()
        Me.Btn_rbt_Recovery = New MetroFramework.Controls.MetroButton()
        Me.Btn_rbt_System = New MetroFramework.Controls.MetroButton()
        Me.Tab_Recovery = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Textbox_Status_Recovery = New MetroFramework.Controls.MetroTextBox()
        Me.Btn_AdbSideload = New MetroFramework.Controls.MetroButton()
        Me.Btn_Recov_Boot = New MetroFramework.Controls.MetroButton()
        Me.Btn_Recov_Flash = New MetroFramework.Controls.MetroButton()
        Me.Tab_Log = New MetroFramework.Controls.MetroTabPage()
        Me.Btn_InfoSave_txt = New MetroFramework.Controls.MetroButton()
        Me.Btn_Logcat = New MetroFramework.Controls.MetroButton()
        Me.Btn_Dmseg = New MetroFramework.Controls.MetroButton()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.Tab_Misc = New MetroFramework.Controls.MetroTabPage()
        Me.Btn_Frp = New MetroFramework.Controls.MetroButton()
        Me.Btn_AdbRestart = New MetroFramework.Controls.MetroButton()
        Me.Btn_DeviceManager = New MetroFramework.Controls.MetroButton()
        Me.Btn_Apk_Install = New MetroFramework.Controls.MetroButton()
        Me.List_Apk = New System.Windows.Forms.ListBox()
        Me.Tab_Apk_Push = New MetroFramework.Controls.MetroTabPage()
        Me.Btn_FilePush = New MetroFramework.Controls.MetroButton()
        Me.List_Push = New System.Windows.Forms.ListBox()
        Me.TxtBox_Push = New MetroFramework.Controls.MetroTextBox()
        Me.Tab_Oem = New MetroFramework.Controls.MetroTabPage()
        Me.Btn_Unlock = New MetroFramework.Controls.MetroButton()
        Me.Btn_UnlockCritical = New MetroFramework.Controls.MetroButton()
        Me.Btn_Lock = New MetroFramework.Controls.MetroButton()
        Me.TxtBox_Oem = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.Tab_Menu.SuspendLayout()
        Me.Tab_Dashboard.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_deviceCheck.SuspendLayout()
        Me.Tab_Reboot.SuspendLayout()
        Me.Tab_Recovery.SuspendLayout()
        Me.Tab_Log.SuspendLayout()
        Me.Tab_Misc.SuspendLayout()
        Me.Tab_Apk_Push.SuspendLayout()
        Me.Tab_Oem.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Menu
        '
        Me.Tab_Menu.Controls.Add(Me.Tab_Dashboard)
        Me.Tab_Menu.Controls.Add(Me.Tab_deviceCheck)
        Me.Tab_Menu.Controls.Add(Me.Tab_Reboot)
        Me.Tab_Menu.Controls.Add(Me.Tab_Oem)
        Me.Tab_Menu.Controls.Add(Me.Tab_Recovery)
        Me.Tab_Menu.Controls.Add(Me.Tab_Apk_Push)
        Me.Tab_Menu.Controls.Add(Me.Tab_Misc)
        Me.Tab_Menu.Controls.Add(Me.Tab_Log)
        Me.Tab_Menu.Location = New System.Drawing.Point(3, 77)
        Me.Tab_Menu.Name = "Tab_Menu"
        Me.Tab_Menu.SelectedIndex = 0
        Me.Tab_Menu.Size = New System.Drawing.Size(543, 259)
        Me.Tab_Menu.TabIndex = 0
        '
        'Tab_Dashboard
        '
        Me.Tab_Dashboard.Controls.Add(Me.PictureBox1)
        Me.Tab_Dashboard.Controls.Add(Me.Btn_License)
        Me.Tab_Dashboard.Controls.Add(Me.Btn_Web)
        Me.Tab_Dashboard.Controls.Add(Me.MetroLabel1)
        Me.Tab_Dashboard.HorizontalScrollbarBarColor = True
        Me.Tab_Dashboard.Location = New System.Drawing.Point(4, 35)
        Me.Tab_Dashboard.Name = "Tab_Dashboard"
        Me.Tab_Dashboard.Size = New System.Drawing.Size(535, 220)
        Me.Tab_Dashboard.TabIndex = 4
        Me.Tab_Dashboard.Text = "Dashboard"
        Me.Tab_Dashboard.VerticalScrollbarBarColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 61)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 126)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Btn_License
        '
        Me.Btn_License.Location = New System.Drawing.Point(373, 123)
        Me.Btn_License.Name = "Btn_License"
        Me.Btn_License.Size = New System.Drawing.Size(120, 32)
        Me.Btn_License.TabIndex = 3
        Me.Btn_License.Text = "LICENSE"
        '
        'Btn_Web
        '
        Me.Btn_Web.Location = New System.Drawing.Point(230, 123)
        Me.Btn_Web.Name = "Btn_Web"
        Me.Btn_Web.Size = New System.Drawing.Size(120, 32)
        Me.Btn_Web.TabIndex = 2
        Me.Btn_Web.Text = "WEBSITE"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(465, 57)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "Aone.Id Oprek Tools is a program created to make it easier for users to root, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "i" &
    "nstall Twrp, open bootloaders and much more." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'Tab_deviceCheck
        '
        Me.Tab_deviceCheck.Controls.Add(Me.Btn_Save_Info)
        Me.Tab_deviceCheck.Controls.Add(Me.MetroLabel4)
        Me.Tab_deviceCheck.Controls.Add(Me.Btn_Check)
        Me.Tab_deviceCheck.Controls.Add(Me.MetroLabel3)
        Me.Tab_deviceCheck.Controls.Add(Me.MetroLabel2)
        Me.Tab_deviceCheck.Controls.Add(Me.Btn_info_System)
        Me.Tab_deviceCheck.Controls.Add(Me.Btn_Info_Bootloader)
        Me.Tab_deviceCheck.Controls.Add(Me.TextBox_Info)
        Me.Tab_deviceCheck.HorizontalScrollbarBarColor = True
        Me.Tab_deviceCheck.Location = New System.Drawing.Point(4, 35)
        Me.Tab_deviceCheck.Name = "Tab_deviceCheck"
        Me.Tab_deviceCheck.Size = New System.Drawing.Size(535, 220)
        Me.Tab_deviceCheck.TabIndex = 0
        Me.Tab_deviceCheck.Text = "Device Check"
        Me.Tab_deviceCheck.VerticalScrollbarBarColor = True
        '
        'Btn_Save_Info
        '
        Me.Btn_Save_Info.Location = New System.Drawing.Point(3, 186)
        Me.Btn_Save_Info.Name = "Btn_Save_Info"
        Me.Btn_Save_Info.Size = New System.Drawing.Size(275, 21)
        Me.Btn_Save_Info.TabIndex = 10
        Me.Btn_Save_Info.Text = "Save TO File"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "INFO :"
        '
        'Btn_Check
        '
        Me.Btn_Check.Location = New System.Drawing.Point(359, 159)
        Me.Btn_Check.Name = "Btn_Check"
        Me.Btn_Check.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Check.TabIndex = 7
        Me.Btn_Check.Text = "CHECK"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(350, 119)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(117, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "CONNECT CHECK"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(359, 37)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "DEVICE INFO"
        '
        'Btn_info_System
        '
        Me.Btn_info_System.Location = New System.Drawing.Point(415, 71)
        Me.Btn_info_System.Name = "Btn_info_System"
        Me.Btn_info_System.Size = New System.Drawing.Size(104, 32)
        Me.Btn_info_System.TabIndex = 4
        Me.Btn_info_System.Text = "SYSTEM"
        '
        'Btn_Info_Bootloader
        '
        Me.Btn_Info_Bootloader.Location = New System.Drawing.Point(295, 71)
        Me.Btn_Info_Bootloader.Name = "Btn_Info_Bootloader"
        Me.Btn_Info_Bootloader.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Info_Bootloader.TabIndex = 3
        Me.Btn_Info_Bootloader.Text = "BOOTLOADER"
        '
        'TextBox_Info
        '
        Me.TextBox_Info.Location = New System.Drawing.Point(3, 22)
        Me.TextBox_Info.Multiline = True
        Me.TextBox_Info.Name = "TextBox_Info"
        Me.TextBox_Info.ReadOnly = True
        Me.TextBox_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_Info.Size = New System.Drawing.Size(275, 158)
        Me.TextBox_Info.TabIndex = 2
        Me.TextBox_Info.UseStyleColors = True
        '
        'Tab_Reboot
        '
        Me.Tab_Reboot.Controls.Add(Me.Btn_Check_CurrentSlot)
        Me.Tab_Reboot.Controls.Add(Me.Btn_CHG_SlotB)
        Me.Tab_Reboot.Controls.Add(Me.Btn_CHG_SlotA)
        Me.Tab_Reboot.Controls.Add(Me.Btn_rbt_Bootloader)
        Me.Tab_Reboot.Controls.Add(Me.Btn_rbt_Edl)
        Me.Tab_Reboot.Controls.Add(Me.Btn_rbt_Recovery)
        Me.Tab_Reboot.Controls.Add(Me.Btn_rbt_System)
        Me.Tab_Reboot.HorizontalScrollbarBarColor = True
        Me.Tab_Reboot.Location = New System.Drawing.Point(4, 35)
        Me.Tab_Reboot.Name = "Tab_Reboot"
        Me.Tab_Reboot.Size = New System.Drawing.Size(535, 220)
        Me.Tab_Reboot.TabIndex = 1
        Me.Tab_Reboot.Text = "Reboot Menu"
        Me.Tab_Reboot.VerticalScrollbarBarColor = True
        '
        'Btn_Check_CurrentSlot
        '
        Me.Btn_Check_CurrentSlot.Location = New System.Drawing.Point(402, 121)
        Me.Btn_Check_CurrentSlot.Name = "Btn_Check_CurrentSlot"
        Me.Btn_Check_CurrentSlot.Size = New System.Drawing.Size(117, 30)
        Me.Btn_Check_CurrentSlot.TabIndex = 8
        Me.Btn_Check_CurrentSlot.Text = "CHECK ACTIVE SLOT"
        '
        'Btn_CHG_SlotB
        '
        Me.Btn_CHG_SlotB.Location = New System.Drawing.Point(277, 151)
        Me.Btn_CHG_SlotB.Name = "Btn_CHG_SlotB"
        Me.Btn_CHG_SlotB.Size = New System.Drawing.Size(117, 30)
        Me.Btn_CHG_SlotB.TabIndex = 7
        Me.Btn_CHG_SlotB.Text = "TO SLOT B"
        '
        'Btn_CHG_SlotA
        '
        Me.Btn_CHG_SlotA.Location = New System.Drawing.Point(277, 93)
        Me.Btn_CHG_SlotA.Name = "Btn_CHG_SlotA"
        Me.Btn_CHG_SlotA.Size = New System.Drawing.Size(117, 30)
        Me.Btn_CHG_SlotA.TabIndex = 6
        Me.Btn_CHG_SlotA.Text = "TO SLOT A"
        '
        'Btn_rbt_Bootloader
        '
        Me.Btn_rbt_Bootloader.Location = New System.Drawing.Point(17, 151)
        Me.Btn_rbt_Bootloader.Name = "Btn_rbt_Bootloader"
        Me.Btn_rbt_Bootloader.Size = New System.Drawing.Size(108, 30)
        Me.Btn_rbt_Bootloader.TabIndex = 5
        Me.Btn_rbt_Bootloader.Text = "BOOTLOADER"
        '
        'Btn_rbt_Edl
        '
        Me.Btn_rbt_Edl.Location = New System.Drawing.Point(143, 151)
        Me.Btn_rbt_Edl.Name = "Btn_rbt_Edl"
        Me.Btn_rbt_Edl.Size = New System.Drawing.Size(108, 30)
        Me.Btn_rbt_Edl.TabIndex = 4
        Me.Btn_rbt_Edl.Text = "EDL "
        '
        'Btn_rbt_Recovery
        '
        Me.Btn_rbt_Recovery.Location = New System.Drawing.Point(143, 93)
        Me.Btn_rbt_Recovery.Name = "Btn_rbt_Recovery"
        Me.Btn_rbt_Recovery.Size = New System.Drawing.Size(108, 30)
        Me.Btn_rbt_Recovery.TabIndex = 3
        Me.Btn_rbt_Recovery.Text = "RECOVERY"
        '
        'Btn_rbt_System
        '
        Me.Btn_rbt_System.Location = New System.Drawing.Point(17, 93)
        Me.Btn_rbt_System.Name = "Btn_rbt_System"
        Me.Btn_rbt_System.Size = New System.Drawing.Size(108, 30)
        Me.Btn_rbt_System.TabIndex = 2
        Me.Btn_rbt_System.Text = "SYSTEM"
        '
        'Tab_Recovery
        '
        Me.Tab_Recovery.Controls.Add(Me.MetroLabel5)
        Me.Tab_Recovery.Controls.Add(Me.Textbox_Status_Recovery)
        Me.Tab_Recovery.Controls.Add(Me.Btn_AdbSideload)
        Me.Tab_Recovery.Controls.Add(Me.Btn_Recov_Boot)
        Me.Tab_Recovery.Controls.Add(Me.Btn_Recov_Flash)
        Me.Tab_Recovery.HorizontalScrollbarBarColor = True
        Me.Tab_Recovery.Location = New System.Drawing.Point(4, 35)
        Me.Tab_Recovery.Name = "Tab_Recovery"
        Me.Tab_Recovery.Size = New System.Drawing.Size(535, 220)
        Me.Tab_Recovery.TabIndex = 2
        Me.Tab_Recovery.Text = "Recovery"
        Me.Tab_Recovery.VerticalScrollbarBarColor = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 9)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "STATUS :"
        '
        'Textbox_Status_Recovery
        '
        Me.Textbox_Status_Recovery.Location = New System.Drawing.Point(3, 31)
        Me.Textbox_Status_Recovery.Multiline = True
        Me.Textbox_Status_Recovery.Name = "Textbox_Status_Recovery"
        Me.Textbox_Status_Recovery.Size = New System.Drawing.Size(275, 160)
        Me.Textbox_Status_Recovery.TabIndex = 5
        '
        'Btn_AdbSideload
        '
        Me.Btn_AdbSideload.Location = New System.Drawing.Point(363, 139)
        Me.Btn_AdbSideload.Name = "Btn_AdbSideload"
        Me.Btn_AdbSideload.Size = New System.Drawing.Size(94, 37)
        Me.Btn_AdbSideload.TabIndex = 4
        Me.Btn_AdbSideload.Text = "ADB SIDELOAD"
        '
        'Btn_Recov_Boot
        '
        Me.Btn_Recov_Boot.Location = New System.Drawing.Point(414, 84)
        Me.Btn_Recov_Boot.Name = "Btn_Recov_Boot"
        Me.Btn_Recov_Boot.Size = New System.Drawing.Size(94, 37)
        Me.Btn_Recov_Boot.TabIndex = 3
        Me.Btn_Recov_Boot.Text = "BOOT ONLY"
        '
        'Btn_Recov_Flash
        '
        Me.Btn_Recov_Flash.Location = New System.Drawing.Point(296, 84)
        Me.Btn_Recov_Flash.Name = "Btn_Recov_Flash"
        Me.Btn_Recov_Flash.Size = New System.Drawing.Size(94, 37)
        Me.Btn_Recov_Flash.TabIndex = 2
        Me.Btn_Recov_Flash.Text = "FLASH"
        '
        'Tab_Log
        '
        Me.Tab_Log.Controls.Add(Me.MetroTextBox1)
        Me.Tab_Log.Controls.Add(Me.Btn_InfoSave_txt)
        Me.Tab_Log.Controls.Add(Me.Btn_Logcat)
        Me.Tab_Log.Controls.Add(Me.Btn_Dmseg)
        Me.Tab_Log.HorizontalScrollbarBarColor = True
        Me.Tab_Log.Location = New System.Drawing.Point(4, 35)
        Me.Tab_Log.Name = "Tab_Log"
        Me.Tab_Log.Size = New System.Drawing.Size(535, 220)
        Me.Tab_Log.TabIndex = 5
        Me.Tab_Log.Text = "Log"
        Me.Tab_Log.VerticalScrollbarBarColor = True
        '
        'Btn_InfoSave_txt
        '
        Me.Btn_InfoSave_txt.Location = New System.Drawing.Point(193, 161)
        Me.Btn_InfoSave_txt.Name = "Btn_InfoSave_txt"
        Me.Btn_InfoSave_txt.Size = New System.Drawing.Size(123, 37)
        Me.Btn_InfoSave_txt.TabIndex = 6
        Me.Btn_InfoSave_txt.Text = "Save Log To File"
        '
        'Btn_Logcat
        '
        Me.Btn_Logcat.Location = New System.Drawing.Point(272, 97)
        Me.Btn_Logcat.Name = "Btn_Logcat"
        Me.Btn_Logcat.Size = New System.Drawing.Size(123, 37)
        Me.Btn_Logcat.TabIndex = 4
        Me.Btn_Logcat.Text = "LOGCAT"
        '
        'Btn_Dmseg
        '
        Me.Btn_Dmseg.Location = New System.Drawing.Point(93, 97)
        Me.Btn_Dmseg.Name = "Btn_Dmseg"
        Me.Btn_Dmseg.Size = New System.Drawing.Size(123, 37)
        Me.Btn_Dmseg.TabIndex = 3
        Me.Btn_Dmseg.Text = "DMSEG "
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Location = New System.Drawing.Point(105, 42)
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.Size = New System.Drawing.Size(290, 27)
        Me.MetroTextBox1.TabIndex = 7
        Me.MetroTextBox1.Text = "MetroTextBox1"
        '
        'Tab_Misc
        '
        Me.Tab_Misc.Controls.Add(Me.Btn_Frp)
        Me.Tab_Misc.Controls.Add(Me.Btn_AdbRestart)
        Me.Tab_Misc.Controls.Add(Me.Btn_DeviceManager)
        Me.Tab_Misc.HorizontalScrollbarBarColor = True
        Me.Tab_Misc.Location = New System.Drawing.Point(4, 35)
        Me.Tab_Misc.Name = "Tab_Misc"
        Me.Tab_Misc.Size = New System.Drawing.Size(535, 220)
        Me.Tab_Misc.TabIndex = 7
        Me.Tab_Misc.Text = "Misc"
        Me.Tab_Misc.VerticalScrollbarBarColor = True
        '
        'Btn_Frp
        '
        Me.Btn_Frp.Location = New System.Drawing.Point(206, 146)
        Me.Btn_Frp.Name = "Btn_Frp"
        Me.Btn_Frp.Size = New System.Drawing.Size(123, 29)
        Me.Btn_Frp.TabIndex = 10
        Me.Btn_Frp.Text = "RESET FRP"
        '
        'Btn_AdbRestart
        '
        Me.Btn_AdbRestart.Location = New System.Drawing.Point(206, 98)
        Me.Btn_AdbRestart.Name = "Btn_AdbRestart"
        Me.Btn_AdbRestart.Size = New System.Drawing.Size(123, 29)
        Me.Btn_AdbRestart.TabIndex = 9
        Me.Btn_AdbRestart.Text = "RESTART ADB"
        '
        'Btn_DeviceManager
        '
        Me.Btn_DeviceManager.Location = New System.Drawing.Point(206, 46)
        Me.Btn_DeviceManager.Name = "Btn_DeviceManager"
        Me.Btn_DeviceManager.Size = New System.Drawing.Size(123, 29)
        Me.Btn_DeviceManager.TabIndex = 8
        Me.Btn_DeviceManager.Text = "DEVICE MANAGER"
        '
        'Btn_Apk_Install
        '
        Me.Btn_Apk_Install.Location = New System.Drawing.Point(52, 178)
        Me.Btn_Apk_Install.Name = "Btn_Apk_Install"
        Me.Btn_Apk_Install.Size = New System.Drawing.Size(123, 29)
        Me.Btn_Apk_Install.TabIndex = 4
        Me.Btn_Apk_Install.Text = "INSTALL APK"
        '
        'List_Apk
        '
        Me.List_Apk.FormattingEnabled = True
        Me.List_Apk.ItemHeight = 16
        Me.List_Apk.Location = New System.Drawing.Point(12, 31)
        Me.List_Apk.Name = "List_Apk"
        Me.List_Apk.Size = New System.Drawing.Size(218, 100)
        Me.List_Apk.TabIndex = 8
        '
        'Tab_Apk_Push
        '
        Me.Tab_Apk_Push.Controls.Add(Me.TxtBox_Push)
        Me.Tab_Apk_Push.Controls.Add(Me.List_Push)
        Me.Tab_Apk_Push.Controls.Add(Me.Btn_FilePush)
        Me.Tab_Apk_Push.Controls.Add(Me.List_Apk)
        Me.Tab_Apk_Push.Controls.Add(Me.Btn_Apk_Install)
        Me.Tab_Apk_Push.HorizontalScrollbarBarColor = True
        Me.Tab_Apk_Push.Location = New System.Drawing.Point(4, 35)
        Me.Tab_Apk_Push.Name = "Tab_Apk_Push"
        Me.Tab_Apk_Push.Size = New System.Drawing.Size(535, 220)
        Me.Tab_Apk_Push.TabIndex = 6
        Me.Tab_Apk_Push.Text = "Apk/Push"
        Me.Tab_Apk_Push.VerticalScrollbarBarColor = True
        '
        'Btn_FilePush
        '
        Me.Btn_FilePush.Location = New System.Drawing.Point(360, 178)
        Me.Btn_FilePush.Name = "Btn_FilePush"
        Me.Btn_FilePush.Size = New System.Drawing.Size(123, 29)
        Me.Btn_FilePush.TabIndex = 9
        Me.Btn_FilePush.Text = "FILE PUSH"
        '
        'List_Push
        '
        Me.List_Push.FormattingEnabled = True
        Me.List_Push.ItemHeight = 16
        Me.List_Push.Location = New System.Drawing.Point(302, 31)
        Me.List_Push.Name = "List_Push"
        Me.List_Push.Size = New System.Drawing.Size(218, 100)
        Me.List_Push.TabIndex = 10
        '
        'TxtBox_Push
        '
        Me.TxtBox_Push.Location = New System.Drawing.Point(302, 137)
        Me.TxtBox_Push.Name = "TxtBox_Push"
        Me.TxtBox_Push.Size = New System.Drawing.Size(218, 28)
        Me.TxtBox_Push.TabIndex = 11
        Me.TxtBox_Push.Text = "/mnt/sdcard/"
        '
        'Tab_Oem
        '
        Me.Tab_Oem.Controls.Add(Me.MetroLabel6)
        Me.Tab_Oem.Controls.Add(Me.TxtBox_Oem)
        Me.Tab_Oem.Controls.Add(Me.Btn_Lock)
        Me.Tab_Oem.Controls.Add(Me.Btn_UnlockCritical)
        Me.Tab_Oem.Controls.Add(Me.Btn_Unlock)
        Me.Tab_Oem.HorizontalScrollbarBarColor = True
        Me.Tab_Oem.Location = New System.Drawing.Point(4, 35)
        Me.Tab_Oem.Name = "Tab_Oem"
        Me.Tab_Oem.Size = New System.Drawing.Size(535, 220)
        Me.Tab_Oem.TabIndex = 8
        Me.Tab_Oem.Text = "Oem"
        Me.Tab_Oem.VerticalScrollbarBarColor = True
        '
        'Btn_Unlock
        '
        Me.Btn_Unlock.Location = New System.Drawing.Point(320, 28)
        Me.Btn_Unlock.Name = "Btn_Unlock"
        Me.Btn_Unlock.Size = New System.Drawing.Size(176, 40)
        Me.Btn_Unlock.TabIndex = 3
        Me.Btn_Unlock.Text = "UNLOCK (BASIC)"
        '
        'Btn_UnlockCritical
        '
        Me.Btn_UnlockCritical.Location = New System.Drawing.Point(320, 87)
        Me.Btn_UnlockCritical.Name = "Btn_UnlockCritical"
        Me.Btn_UnlockCritical.Size = New System.Drawing.Size(176, 40)
        Me.Btn_UnlockCritical.TabIndex = 4
        Me.Btn_UnlockCritical.Text = "UNLOCK CRITICAL"
        '
        'Btn_Lock
        '
        Me.Btn_Lock.Location = New System.Drawing.Point(320, 145)
        Me.Btn_Lock.Name = "Btn_Lock"
        Me.Btn_Lock.Size = New System.Drawing.Size(176, 40)
        Me.Btn_Lock.TabIndex = 5
        Me.Btn_Lock.Text = "LOCK"
        '
        'TxtBox_Oem
        '
        Me.TxtBox_Oem.Location = New System.Drawing.Point(3, 27)
        Me.TxtBox_Oem.Multiline = True
        Me.TxtBox_Oem.Name = "TxtBox_Oem"
        Me.TxtBox_Oem.ReadOnly = True
        Me.TxtBox_Oem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBox_Oem.Size = New System.Drawing.Size(275, 158)
        Me.TxtBox_Oem.TabIndex = 6
        Me.TxtBox_Oem.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 5)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel6.TabIndex = 10
        Me.MetroLabel6.Text = "INFO :"
        '
        'MenuAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 338)
        Me.Controls.Add(Me.Tab_Menu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "MenuAwal"
        Me.Padding = New System.Windows.Forms.Padding(30, 74, 30, 25)
        Me.Text = "Aone.Id Oprek Tools"
        Me.Tab_Menu.ResumeLayout(False)
        Me.Tab_Dashboard.ResumeLayout(False)
        Me.Tab_Dashboard.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab_deviceCheck.ResumeLayout(False)
        Me.Tab_deviceCheck.PerformLayout()
        Me.Tab_Reboot.ResumeLayout(False)
        Me.Tab_Recovery.ResumeLayout(False)
        Me.Tab_Recovery.PerformLayout()
        Me.Tab_Log.ResumeLayout(False)
        Me.Tab_Misc.ResumeLayout(False)
        Me.Tab_Apk_Push.ResumeLayout(False)
        Me.Tab_Oem.ResumeLayout(False)
        Me.Tab_Oem.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab_Menu As MetroFramework.Controls.MetroTabControl
    Friend WithEvents Tab_Dashboard As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Tab_deviceCheck As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Tab_Reboot As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Tab_Recovery As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Tab_Log As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Btn_License As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Web As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_info_System As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Info_Bootloader As MetroFramework.Controls.MetroButton
    Friend WithEvents TextBox_Info As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Btn_rbt_Bootloader As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_rbt_Edl As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_rbt_Recovery As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_rbt_System As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Recov_Boot As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Recov_Flash As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Logcat As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Dmseg As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Check As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Btn_InfoSave_txt As MetroFramework.Controls.MetroButton
    Friend WithEvents Textbox_Status_Recovery As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Btn_AdbSideload As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Btn_Check_CurrentSlot As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_CHG_SlotB As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_CHG_SlotA As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Btn_Save_Info As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Tab_Misc As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Btn_Frp As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_AdbRestart As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_DeviceManager As MetroFramework.Controls.MetroButton
    Friend WithEvents Tab_Apk_Push As MetroFramework.Controls.MetroTabPage
    Friend WithEvents List_Push As ListBox
    Friend WithEvents Btn_FilePush As MetroFramework.Controls.MetroButton
    Friend WithEvents List_Apk As ListBox
    Friend WithEvents Btn_Apk_Install As MetroFramework.Controls.MetroButton
    Friend WithEvents TxtBox_Push As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Tab_Oem As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents TxtBox_Oem As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Btn_Lock As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_UnlockCritical As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Unlock As MetroFramework.Controls.MetroButton
End Class
