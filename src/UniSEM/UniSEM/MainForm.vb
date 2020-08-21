Public Class MainForm

    'STEP
    'load conf
    'SYS_ENV_LIST == ACE_ROOT,BOOST_ROOT,TBB_ROOT
    'ACE_ROOT|1 == C:\ACE_wrappers
    'BOOST_ROOT|1 == E:\local\boost_1_59_0
    'BOOST_ROOT|2 == E:\local\boost_1_66_0
    'TBB_ROOT|1 == C:\tbb
    'get each settings list and assign to the correct dictionary

    'read the current system settings and compare with the conf, see if they are match. if not match, should promot whether if change it  or not


    'Settings
    'use customized control to show the settings
    '[ENV NAME TEXT BOX] [ CURRENT SETTINGS LABEL ] [AVAILABLE SETTINGS COMBO BOX] [+ BUTTON FOR ADD MORE SETTINGS]

    Private Sub ENVTEST()
        Dim sPath As String = Environment.GetEnvironmentVariable("SAP_CODEPAGE", EnvironmentVariableTarget.Machine)

        If sPath <> "8400" Then
            System.Environment.SetEnvironmentVariable("SAP_CODEPAGE", "8400", EnvironmentVariableTarget.Machine)
            MessageBox.Show("env add success")
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        ENVTEST()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadConfig()
    End Sub

    Private Sub MetroButton1_Click_1(sender As Object, e As EventArgs) Handles btnReload.Click
        Dim sPath As String = Environment.GetEnvironmentVariable("BOOST_ROOT", EnvironmentVariableTarget.Machine)
        MsgBox(sPath)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        '
        Dim strEnv As String = ""
        If Not txtEnvName.Text.Contains("|") Then
            form_alert.Show("请按照 变量名|别称设置/Format Env|Alias " & txtEnvName.Text, form_alert.AlertType.[error])
            Exit Sub
        Else
            strEnv = txtEnvName.Text.Split("|")(0)
        End If

        'if already exists
        If ConfigDictionary.ContainsKey(txtEnvName.Text) Then
            form_alert.Show("该设置项目已经存在/Item already exists " & txtEnvName.Text, form_alert.AlertType.[error])
            Exit Sub
        End If

        'if not 
        ConfigDictionary("SYS_ENV_LIST").ConfigVALUE = ConfigDictionary("SYS_ENV_LIST").ConfigVALUE & "," & strEnv
        Dim configLineTemp As ConfigLine = New ConfigLine With {
            .ConfigKeyWord = txtEnvName.Text,
            .ConfigVALUE = txtEnvValue.Text
        }
        ConfigDictionary.Add(txtEnvName.Text, configLineTemp)
        SaveConfig()
        Try
            System.Environment.SetEnvironmentVariable(txtEnvName.Text, txtEnvValue.Text, EnvironmentVariableTarget.Machine)
            form_alert.Show("设置成功/Success", form_alert.AlertType.success)
        Catch ex As Exception
            form_alert.Show("设置失败/Fail " & ex.Message, form_alert.AlertType.[error])
        End Try
    End Sub
End Class
