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
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
