Public Class SettingItem
    Public ENV_NAME As String

    Private Sub SettingItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrent.Text = Environment.GetEnvironmentVariable(ENV_NAME)
    End Sub

    Private Sub MetroComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MetroComboBox1.SelectedIndexChanged
        txtEnvName.Text = ENV_NAME
        Try
            System.Environment.SetEnvironmentVariable(ENV_NAME, MetroComboBox1.Text, EnvironmentVariableTarget.Machine)
            lblCurrent.Text = Environment.GetEnvironmentVariable(ENV_NAME)
            Me.Invalidate()
            form_alert.Show("设置成功/Success", form_alert.AlertType.success)
        Catch ex As Exception
            form_alert.Show("设置失败/Fail " & ex.Message, form_alert.AlertType.[error])
        End Try

    End Sub
End Class
