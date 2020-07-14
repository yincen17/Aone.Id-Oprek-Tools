<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Update
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Update))
        Me.RichTxtBox_Chagelog = New System.Windows.Forms.RichTextBox()
        Me.Btn_Download = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.Lbl_Psn_Terbaru = New MetroFramework.Controls.MetroLabel()
        Me.Lbl_Psn_Lama = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.lbl_version = New MetroFramework.Controls.MetroLabel()
        Me.TxtBox_VersiUrl = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'RichTxtBox_Chagelog
        '
        Me.RichTxtBox_Chagelog.Location = New System.Drawing.Point(182, 79)
        Me.RichTxtBox_Chagelog.Name = "RichTxtBox_Chagelog"
        Me.RichTxtBox_Chagelog.ReadOnly = True
        Me.RichTxtBox_Chagelog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.RichTxtBox_Chagelog.Size = New System.Drawing.Size(211, 173)
        Me.RichTxtBox_Chagelog.TabIndex = 0
        Me.RichTxtBox_Chagelog.Text = ""
        '
        'Btn_Download
        '
        Me.Btn_Download.Location = New System.Drawing.Point(23, 212)
        Me.Btn_Download.Name = "Btn_Download"
        Me.Btn_Download.Size = New System.Drawing.Size(132, 32)
        Me.Btn_Download.TabIndex = 2
        Me.Btn_Download.Text = "DOWNLOAD UPDATE "
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(244, 57)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "CHANGELOG"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(7, 71)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(104, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "NEW VERSION :"
        '
        'Lbl_Psn_Terbaru
        '
        Me.Lbl_Psn_Terbaru.AutoSize = True
        Me.Lbl_Psn_Terbaru.BackColor = System.Drawing.Color.Lime
        Me.Lbl_Psn_Terbaru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Psn_Terbaru.ForeColor = System.Drawing.Color.DarkGreen
        Me.Lbl_Psn_Terbaru.Location = New System.Drawing.Point(7, 135)
        Me.Lbl_Psn_Terbaru.Name = "Lbl_Psn_Terbaru"
        Me.Lbl_Psn_Terbaru.Size = New System.Drawing.Size(159, 38)
        Me.Lbl_Psn_Terbaru.TabIndex = 5
        Me.Lbl_Psn_Terbaru.Text = "You Are Using The Latest " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version"
        Me.Lbl_Psn_Terbaru.Visible = False
        '
        'Lbl_Psn_Lama
        '
        Me.Lbl_Psn_Lama.BackColor = System.Drawing.Color.Red
        Me.Lbl_Psn_Lama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Psn_Lama.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Psn_Lama.Location = New System.Drawing.Point(7, 135)
        Me.Lbl_Psn_Lama.Name = "Lbl_Psn_Lama"
        Me.Lbl_Psn_Lama.Size = New System.Drawing.Size(159, 43)
        Me.Lbl_Psn_Lama.TabIndex = 0
        Me.Lbl_Psn_Lama.Text = "You Are Using The " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Old Version"
        Me.Lbl_Psn_Lama.Visible = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(200, 30)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(132, 19)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "CURRENT VERSION :"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(329, 30)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(32, 19)
        Me.lbl_version.TabIndex = 7
        Me.lbl_version.Text = "v0.1"
        '
        'TxtBox_VersiUrl
        '
        Me.TxtBox_VersiUrl.Location = New System.Drawing.Point(117, 71)
        Me.TxtBox_VersiUrl.Name = "TxtBox_VersiUrl"
        Me.TxtBox_VersiUrl.ReadOnly = True
        Me.TxtBox_VersiUrl.Size = New System.Drawing.Size(38, 23)
        Me.TxtBox_VersiUrl.TabIndex = 8
        '
        'Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 275)
        Me.Controls.Add(Me.TxtBox_VersiUrl)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.Lbl_Psn_Terbaru)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Btn_Download)
        Me.Controls.Add(Me.RichTxtBox_Chagelog)
        Me.Controls.Add(Me.Lbl_Psn_Lama)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Update"
        Me.Resizable = False
        Me.Text = "UPDATE CHECK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTxtBox_Chagelog As RichTextBox
    Friend WithEvents Btn_Download As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Lbl_Psn_Terbaru As MetroFramework.Controls.MetroLabel
    Friend WithEvents Lbl_Psn_Lama As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lbl_version As MetroFramework.Controls.MetroLabel
    Friend WithEvents TxtBox_VersiUrl As MetroFramework.Controls.MetroTextBox
End Class
