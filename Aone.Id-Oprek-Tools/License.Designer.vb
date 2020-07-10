<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class License
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(License))
        Me.RichText_License = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'RichText_License
        '
        Me.RichText_License.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichText_License.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichText_License.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichText_License.Location = New System.Drawing.Point(14, 30)
        Me.RichText_License.Name = "RichText_License"
        Me.RichText_License.ReadOnly = True
        Me.RichText_License.Size = New System.Drawing.Size(669, 423)
        Me.RichText_License.TabIndex = 1
        Me.RichText_License.Text = resources.GetString("RichText_License.Text")
        '
        'License
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 460)
        Me.Controls.Add(Me.RichText_License)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "License"
        Me.Resizable = False
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichText_License As RichTextBox
End Class
