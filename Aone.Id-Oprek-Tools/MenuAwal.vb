Public Class MenuAwal
    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click

    End Sub

    Private Sub Btn_License_Click(sender As Object, e As EventArgs) Handles Btn_License.Click
        Dim lisensi As New License
        lisensi.Show()
    End Sub
End Class