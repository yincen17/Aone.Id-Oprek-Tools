﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Btn_Installed_App = New MetroFramework.Controls.MetroButton()
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
        Me.Tab_Oem = New MetroFramework.Controls.MetroTabPage()
        Me.Lbel_Modefastboot1 = New MetroFramework.Controls.MetroLabel()
        Me.TxtBox_Bootloader = New MetroFramework.Controls.MetroTextBox()
        Me.Chkbox_Flashing_Critical = New MetroFramework.Controls.MetroCheckBox()
        Me.Chkbox_Oem = New MetroFramework.Controls.MetroCheckBox()
        Me.Btn_Lock = New MetroFramework.Controls.MetroButton()
        Me.Btn_Unlock = New MetroFramework.Controls.MetroButton()
        Me.Tab_Recovery = New MetroFramework.Controls.MetroTabPage()
        Me.Lbel_Modefastboot2 = New MetroFramework.Controls.MetroLabel()
        Me.Btn_FileImgBrowse = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.Lbel_Slect_IMG = New MetroFramework.Controls.MetroLabel()
        Me.TxtBox_Img = New MetroFramework.Controls.MetroTextBox()
        Me.Btn_Recov_Boot = New MetroFramework.Controls.MetroButton()
        Me.Btn_Recov_Flash = New MetroFramework.Controls.MetroButton()
        Me.Tab_Apk_Push = New MetroFramework.Controls.MetroTabPage()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.Btn_Apk_Install = New MetroFramework.Controls.MetroButton()
        Me.Btn_filePush = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.TxtBox_Push = New MetroFramework.Controls.MetroTextBox()
        Me.List_Push = New System.Windows.Forms.ListBox()
        Me.Btn_File_Select = New MetroFramework.Controls.MetroButton()
        Me.List_Apk = New System.Windows.Forms.ListBox()
        Me.Btn_Apk_SELECT = New MetroFramework.Controls.MetroButton()
        Me.Tab_Misc = New MetroFramework.Controls.MetroTabPage()
        Me.Btn_AdbSideload = New MetroFramework.Controls.MetroButton()
        Me.Btn_Frp = New MetroFramework.Controls.MetroButton()
        Me.Btn_AdbRestart = New MetroFramework.Controls.MetroButton()
        Me.Btn_DeviceManager = New MetroFramework.Controls.MetroButton()
        Me.Tab_Log = New MetroFramework.Controls.MetroTabPage()
        Me.TxtBox_DmsegLogcat = New MetroFramework.Controls.MetroTextBox()
        Me.Btn_InfoSave_txt = New MetroFramework.Controls.MetroButton()
        Me.Btn_Logcat = New MetroFramework.Controls.MetroButton()
        Me.Btn_Dmseg = New MetroFramework.Controls.MetroButton()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Lbel_Bootloader = New MetroFramework.Controls.MetroLabel()
        Me.Chkbox_Flashing = New MetroFramework.Controls.MetroCheckBox()
        Me.Tab_Menu.SuspendLayout()
        Me.Tab_Dashboard.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab_deviceCheck.SuspendLayout()
        Me.Tab_Reboot.SuspendLayout()
        Me.Tab_Oem.SuspendLayout()
        Me.Tab_Recovery.SuspendLayout()
        Me.Tab_Apk_Push.SuspendLayout()
        Me.Tab_Misc.SuspendLayout()
        Me.Tab_Log.SuspendLayout()
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
        Me.Tab_Menu.SelectedIndex = 3
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
        Me.Tab_deviceCheck.Controls.Add(Me.Btn_Installed_App)
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
        'Btn_Installed_App
        '
        Me.Btn_Installed_App.Location = New System.Drawing.Point(359, 103)
        Me.Btn_Installed_App.Name = "Btn_Installed_App"
        Me.Btn_Installed_App.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Installed_App.TabIndex = 11
        Me.Btn_Installed_App.Text = "INSTALLED APP"
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
        Me.Btn_Check.Location = New System.Drawing.Point(359, 174)
        Me.Btn_Check.Name = "Btn_Check"
        Me.Btn_Check.Size = New System.Drawing.Size(104, 33)
        Me.Btn_Check.TabIndex = 7
        Me.Btn_Check.Text = "CHECK"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(359, 152)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(117, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "CONNECT CHECK"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(359, 22)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(87, 19)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "DEVICE INFO"
        '
        'Btn_info_System
        '
        Me.Btn_info_System.Location = New System.Drawing.Point(415, 56)
        Me.Btn_info_System.Name = "Btn_info_System"
        Me.Btn_info_System.Size = New System.Drawing.Size(104, 32)
        Me.Btn_info_System.TabIndex = 4
        Me.Btn_info_System.Text = "SYSTEM"
        '
        'Btn_Info_Bootloader
        '
        Me.Btn_Info_Bootloader.Location = New System.Drawing.Point(295, 56)
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
        'Tab_Oem
        '
        Me.Tab_Oem.Controls.Add(Me.Chkbox_Flashing)
        Me.Tab_Oem.Controls.Add(Me.Lbel_Bootloader)
        Me.Tab_Oem.Controls.Add(Me.Lbel_Modefastboot1)
        Me.Tab_Oem.Controls.Add(Me.TxtBox_Bootloader)
        Me.Tab_Oem.Controls.Add(Me.Chkbox_Flashing_Critical)
        Me.Tab_Oem.Controls.Add(Me.Chkbox_Oem)
        Me.Tab_Oem.Controls.Add(Me.Btn_Lock)
        Me.Tab_Oem.Controls.Add(Me.Btn_Unlock)
        Me.Tab_Oem.HorizontalScrollbarBarColor = True
        Me.Tab_Oem.Location = New System.Drawing.Point(4, 35)
        Me.Tab_Oem.Name = "Tab_Oem"
        Me.Tab_Oem.Size = New System.Drawing.Size(535, 220)
        Me.Tab_Oem.TabIndex = 8
        Me.Tab_Oem.Text = "Bootloader"
        Me.Tab_Oem.VerticalScrollbarBarColor = True
        '
        'Lbel_Modefastboot1
        '
        Me.Lbel_Modefastboot1.AutoSize = True
        Me.Lbel_Modefastboot1.Location = New System.Drawing.Point(-4, 201)
        Me.Lbel_Modefastboot1.Name = "Lbel_Modefastboot1"
        Me.Lbel_Modefastboot1.Size = New System.Drawing.Size(293, 19)
        Me.Lbel_Modefastboot1.TabIndex = 14
        Me.Lbel_Modefastboot1.Text = "Device Must Be In Fastboot / Bootloader Mode !"
        '
        'TxtBox_Bootloader
        '
        Me.TxtBox_Bootloader.Location = New System.Drawing.Point(14, 34)
        Me.TxtBox_Bootloader.Name = "TxtBox_Bootloader"
        Me.TxtBox_Bootloader.Size = New System.Drawing.Size(269, 164)
        Me.TxtBox_Bootloader.TabIndex = 13
        '
        'Chkbox_Flashing_Critical
        '
        Me.Chkbox_Flashing_Critical.AutoSize = True
        Me.Chkbox_Flashing_Critical.Location = New System.Drawing.Point(401, 58)
        Me.Chkbox_Flashing_Critical.Name = "Chkbox_Flashing_Critical"
        Me.Chkbox_Flashing_Critical.Size = New System.Drawing.Size(107, 15)
        Me.Chkbox_Flashing_Critical.TabIndex = 12
        Me.Chkbox_Flashing_Critical.Text = "Flashing Critical"
        Me.Chkbox_Flashing_Critical.UseVisualStyleBackColor = True
        '
        'Chkbox_Oem
        '
        Me.Chkbox_Oem.AutoSize = True
        Me.Chkbox_Oem.Location = New System.Drawing.Point(312, 58)
        Me.Chkbox_Oem.Name = "Chkbox_Oem"
        Me.Chkbox_Oem.Size = New System.Drawing.Size(49, 15)
        Me.Chkbox_Oem.TabIndex = 11
        Me.Chkbox_Oem.Text = "OEM"
        Me.Chkbox_Oem.UseVisualStyleBackColor = True
        '
        'Btn_Lock
        '
        Me.Btn_Lock.Location = New System.Drawing.Point(312, 166)
        Me.Btn_Lock.Name = "Btn_Lock"
        Me.Btn_Lock.Size = New System.Drawing.Size(196, 32)
        Me.Btn_Lock.TabIndex = 5
        Me.Btn_Lock.Text = "LOCK"
        '
        'Btn_Unlock
        '
        Me.Btn_Unlock.Location = New System.Drawing.Point(312, 111)
        Me.Btn_Unlock.Name = "Btn_Unlock"
        Me.Btn_Unlock.Size = New System.Drawing.Size(196, 32)
        Me.Btn_Unlock.TabIndex = 3
        Me.Btn_Unlock.Text = "UNLOCK"
        '
        'Tab_Recovery
        '
        Me.Tab_Recovery.Controls.Add(Me.Lbel_Modefastboot2)
        Me.Tab_Recovery.Controls.Add(Me.Btn_FileImgBrowse)
        Me.Tab_Recovery.Controls.Add(Me.MetroLabel10)
        Me.Tab_Recovery.Controls.Add(Me.Lbel_Slect_IMG)
        Me.Tab_Recovery.Controls.Add(Me.TxtBox_Img)
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
        'Lbel_Modefastboot2
        '
        Me.Lbel_Modefastboot2.AutoSize = True
        Me.Lbel_Modefastboot2.Location = New System.Drawing.Point(0, 201)
        Me.Lbel_Modefastboot2.Name = "Lbel_Modefastboot2"
        Me.Lbel_Modefastboot2.Size = New System.Drawing.Size(293, 19)
        Me.Lbel_Modefastboot2.TabIndex = 9
        Me.Lbel_Modefastboot2.Text = "Device Must Be In Fastboot / Bootloader Mode !"
        '
        'Btn_FileImgBrowse
        '
        Me.Btn_FileImgBrowse.Location = New System.Drawing.Point(409, 69)
        Me.Btn_FileImgBrowse.Name = "Btn_FileImgBrowse"
        Me.Btn_FileImgBrowse.Size = New System.Drawing.Size(111, 37)
        Me.Btn_FileImgBrowse.TabIndex = 8
        Me.Btn_FileImgBrowse.Text = "Browse Img File"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(37, 69)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(82, 19)
        Me.MetroLabel10.TabIndex = 7
        Me.MetroLabel10.Text = "File Location"
        '
        'Lbel_Slect_IMG
        '
        Me.Lbel_Slect_IMG.AutoSize = True
        Me.Lbel_Slect_IMG.Location = New System.Drawing.Point(160, 27)
        Me.Lbel_Slect_IMG.Name = "Lbel_Slect_IMG"
        Me.Lbel_Slect_IMG.Size = New System.Drawing.Size(201, 19)
        Me.Lbel_Slect_IMG.TabIndex = 6
        Me.Lbel_Slect_IMG.Text = "Select File IMG  For Flash / Boot "
        '
        'TxtBox_Img
        '
        Me.TxtBox_Img.Location = New System.Drawing.Point(125, 69)
        Me.TxtBox_Img.Name = "TxtBox_Img"
        Me.TxtBox_Img.ReadOnly = True
        Me.TxtBox_Img.Size = New System.Drawing.Size(266, 23)
        Me.TxtBox_Img.TabIndex = 5
        '
        'Btn_Recov_Boot
        '
        Me.Btn_Recov_Boot.Location = New System.Drawing.Point(297, 120)
        Me.Btn_Recov_Boot.Name = "Btn_Recov_Boot"
        Me.Btn_Recov_Boot.Size = New System.Drawing.Size(94, 37)
        Me.Btn_Recov_Boot.TabIndex = 3
        Me.Btn_Recov_Boot.Text = "BOOT ONLY"
        '
        'Btn_Recov_Flash
        '
        Me.Btn_Recov_Flash.Location = New System.Drawing.Point(125, 120)
        Me.Btn_Recov_Flash.Name = "Btn_Recov_Flash"
        Me.Btn_Recov_Flash.Size = New System.Drawing.Size(94, 37)
        Me.Btn_Recov_Flash.TabIndex = 2
        Me.Btn_Recov_Flash.Text = "FLASH"
        '
        'Tab_Apk_Push
        '
        Me.Tab_Apk_Push.Controls.Add(Me.MetroLabel9)
        Me.Tab_Apk_Push.Controls.Add(Me.MetroLabel8)
        Me.Tab_Apk_Push.Controls.Add(Me.Btn_Apk_Install)
        Me.Tab_Apk_Push.Controls.Add(Me.Btn_filePush)
        Me.Tab_Apk_Push.Controls.Add(Me.MetroLabel7)
        Me.Tab_Apk_Push.Controls.Add(Me.TxtBox_Push)
        Me.Tab_Apk_Push.Controls.Add(Me.List_Push)
        Me.Tab_Apk_Push.Controls.Add(Me.Btn_File_Select)
        Me.Tab_Apk_Push.Controls.Add(Me.List_Apk)
        Me.Tab_Apk_Push.Controls.Add(Me.Btn_Apk_SELECT)
        Me.Tab_Apk_Push.HorizontalScrollbarBarColor = True
        Me.Tab_Apk_Push.Location = New System.Drawing.Point(4, 35)
        Me.Tab_Apk_Push.Name = "Tab_Apk_Push"
        Me.Tab_Apk_Push.Size = New System.Drawing.Size(535, 220)
        Me.Tab_Apk_Push.TabIndex = 6
        Me.Tab_Apk_Push.Text = "Apk/Push"
        Me.Tab_Apk_Push.VerticalScrollbarBarColor = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(302, 14)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel9.TabIndex = 16
        Me.MetroLabel9.Text = "FILE LIST"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(14, 14)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel8.TabIndex = 15
        Me.MetroLabel8.Text = "APK LIST"
        '
        'Btn_Apk_Install
        '
        Me.Btn_Apk_Install.Location = New System.Drawing.Point(14, 178)
        Me.Btn_Apk_Install.Name = "Btn_Apk_Install"
        Me.Btn_Apk_Install.Size = New System.Drawing.Size(218, 29)
        Me.Btn_Apk_Install.TabIndex = 14
        Me.Btn_Apk_Install.Text = "INSTALL  APK"
        '
        'Btn_filePush
        '
        Me.Btn_filePush.Location = New System.Drawing.Point(416, 178)
        Me.Btn_filePush.Name = "Btn_filePush"
        Me.Btn_filePush.Size = New System.Drawing.Size(108, 29)
        Me.Btn_filePush.TabIndex = 13
        Me.Btn_filePush.Text = "PUSH FILE "
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(344, 123)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(140, 19)
        Me.MetroLabel7.TabIndex = 12
        Me.MetroLabel7.Text = "To Location On Phone"
        '
        'TxtBox_Push
        '
        Me.TxtBox_Push.Location = New System.Drawing.Point(302, 142)
        Me.TxtBox_Push.Name = "TxtBox_Push"
        Me.TxtBox_Push.Size = New System.Drawing.Size(218, 28)
        Me.TxtBox_Push.TabIndex = 11
        Me.TxtBox_Push.Text = "/mnt/sdcard/"
        '
        'List_Push
        '
        Me.List_Push.FormattingEnabled = True
        Me.List_Push.ItemHeight = 16
        Me.List_Push.Location = New System.Drawing.Point(302, 36)
        Me.List_Push.Name = "List_Push"
        Me.List_Push.ScrollAlwaysVisible = True
        Me.List_Push.Size = New System.Drawing.Size(218, 84)
        Me.List_Push.TabIndex = 10
        '
        'Btn_File_Select
        '
        Me.Btn_File_Select.Location = New System.Drawing.Point(302, 178)
        Me.Btn_File_Select.Name = "Btn_File_Select"
        Me.Btn_File_Select.Size = New System.Drawing.Size(108, 29)
        Me.Btn_File_Select.TabIndex = 9
        Me.Btn_File_Select.Text = "SELECT FOLDER "
        '
        'List_Apk
        '
        Me.List_Apk.FormattingEnabled = True
        Me.List_Apk.ItemHeight = 16
        Me.List_Apk.Location = New System.Drawing.Point(14, 36)
        Me.List_Apk.Name = "List_Apk"
        Me.List_Apk.ScrollAlwaysVisible = True
        Me.List_Apk.Size = New System.Drawing.Size(218, 100)
        Me.List_Apk.TabIndex = 8
        '
        'Btn_Apk_SELECT
        '
        Me.Btn_Apk_SELECT.Location = New System.Drawing.Point(14, 142)
        Me.Btn_Apk_SELECT.Name = "Btn_Apk_SELECT"
        Me.Btn_Apk_SELECT.Size = New System.Drawing.Size(218, 29)
        Me.Btn_Apk_SELECT.TabIndex = 4
        Me.Btn_Apk_SELECT.Text = "SELECT APK FOLDER"
        '
        'Tab_Misc
        '
        Me.Tab_Misc.Controls.Add(Me.Btn_AdbSideload)
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
        'Btn_AdbSideload
        '
        Me.Btn_AdbSideload.Location = New System.Drawing.Point(347, 46)
        Me.Btn_AdbSideload.Name = "Btn_AdbSideload"
        Me.Btn_AdbSideload.Size = New System.Drawing.Size(123, 29)
        Me.Btn_AdbSideload.TabIndex = 11
        Me.Btn_AdbSideload.Text = "ADB SIDELOAD"
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
        'Tab_Log
        '
        Me.Tab_Log.Controls.Add(Me.TxtBox_DmsegLogcat)
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
        'TxtBox_DmsegLogcat
        '
        Me.TxtBox_DmsegLogcat.Location = New System.Drawing.Point(3, 22)
        Me.TxtBox_DmsegLogcat.Multiline = True
        Me.TxtBox_DmsegLogcat.Name = "TxtBox_DmsegLogcat"
        Me.TxtBox_DmsegLogcat.ReadOnly = True
        Me.TxtBox_DmsegLogcat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBox_DmsegLogcat.Size = New System.Drawing.Size(260, 185)
        Me.TxtBox_DmsegLogcat.TabIndex = 7
        '
        'Btn_InfoSave_txt
        '
        Me.Btn_InfoSave_txt.Location = New System.Drawing.Point(328, 170)
        Me.Btn_InfoSave_txt.Name = "Btn_InfoSave_txt"
        Me.Btn_InfoSave_txt.Size = New System.Drawing.Size(123, 37)
        Me.Btn_InfoSave_txt.TabIndex = 6
        Me.Btn_InfoSave_txt.Text = "Save Log To File"
        '
        'Btn_Logcat
        '
        Me.Btn_Logcat.Location = New System.Drawing.Point(400, 92)
        Me.Btn_Logcat.Name = "Btn_Logcat"
        Me.Btn_Logcat.Size = New System.Drawing.Size(123, 37)
        Me.Btn_Logcat.TabIndex = 4
        Me.Btn_Logcat.Text = "LOGCAT"
        '
        'Btn_Dmseg
        '
        Me.Btn_Dmseg.Location = New System.Drawing.Point(271, 92)
        Me.Btn_Dmseg.Name = "Btn_Dmseg"
        Me.Btn_Dmseg.Size = New System.Drawing.Size(123, 37)
        Me.Btn_Dmseg.TabIndex = 3
        Me.Btn_Dmseg.Text = "DMSEG "
        '
        'Lbel_Bootloader
        '
        Me.Lbel_Bootloader.AutoSize = True
        Me.Lbel_Bootloader.Location = New System.Drawing.Point(334, 25)
        Me.Lbel_Bootloader.Name = "Lbel_Bootloader"
        Me.Lbel_Bootloader.Size = New System.Drawing.Size(137, 19)
        Me.Lbel_Bootloader.TabIndex = 15
        Me.Lbel_Bootloader.Text = "Unlock / Lock Options"
        '
        'Chkbox_Flashing
        '
        Me.Chkbox_Flashing.AutoSize = True
        Me.Chkbox_Flashing.Location = New System.Drawing.Point(312, 79)
        Me.Chkbox_Flashing.Name = "Chkbox_Flashing"
        Me.Chkbox_Flashing.Size = New System.Drawing.Size(67, 15)
        Me.Chkbox_Flashing.TabIndex = 16
        Me.Chkbox_Flashing.Text = "Flashing"
        Me.Chkbox_Flashing.UseVisualStyleBackColor = True
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
        Me.Tab_Oem.ResumeLayout(False)
        Me.Tab_Oem.PerformLayout()
        Me.Tab_Recovery.ResumeLayout(False)
        Me.Tab_Recovery.PerformLayout()
        Me.Tab_Apk_Push.ResumeLayout(False)
        Me.Tab_Apk_Push.PerformLayout()
        Me.Tab_Misc.ResumeLayout(False)
        Me.Tab_Log.ResumeLayout(False)
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
    Friend WithEvents Btn_Recov_Flash As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Logcat As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Dmseg As MetroFramework.Controls.MetroButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btn_Check As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Btn_InfoSave_txt As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Btn_Check_CurrentSlot As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_CHG_SlotB As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_CHG_SlotA As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Save_Info As MetroFramework.Controls.MetroButton
    Friend WithEvents TxtBox_DmsegLogcat As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Tab_Misc As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Btn_Frp As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_AdbRestart As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_DeviceManager As MetroFramework.Controls.MetroButton
    Friend WithEvents Tab_Apk_Push As MetroFramework.Controls.MetroTabPage
    Friend WithEvents List_Push As ListBox
    Friend WithEvents Btn_File_Select As MetroFramework.Controls.MetroButton
    Friend WithEvents List_Apk As ListBox
    Friend WithEvents Btn_Apk_SELECT As MetroFramework.Controls.MetroButton
    Friend WithEvents TxtBox_Push As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Tab_Oem As MetroFramework.Controls.MetroTabPage
    Friend WithEvents Btn_Lock As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Unlock As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Apk_Install As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_filePush As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Btn_Installed_App As MetroFramework.Controls.MetroButton
    Friend WithEvents Lbel_Slect_IMG As MetroFramework.Controls.MetroLabel
    Friend WithEvents TxtBox_Img As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Btn_AdbSideload As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_FileImgBrowse As MetroFramework.Controls.MetroButton
    Friend WithEvents Btn_Recov_Boot As MetroFramework.Controls.MetroButton
    Friend WithEvents TxtBox_Bootloader As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Chkbox_Flashing_Critical As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Chkbox_Oem As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Lbel_Modefastboot1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Lbel_Modefastboot2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Lbel_Bootloader As MetroFramework.Controls.MetroLabel
    Friend WithEvents Chkbox_Flashing As MetroFramework.Controls.MetroCheckBox
End Class
