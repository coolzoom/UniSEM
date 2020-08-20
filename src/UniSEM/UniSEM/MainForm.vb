Public Class MainForm

    'STEP
    'load conf
    'parse SYS_ENV_LIST == ACE_ROOT|1,BOOST_ROOT|2,TBB_ROOT|1    #NAME|CURRENTSETTING
    'ACE_ROOT_1 == C\ACE_wrappers
    'BOOST_ROOT_1_BOOST1.59 == E:\local\boost_1_59_0    #NAME_optionnumber[_alias]
    'BOOST_ROOT_2 == E:\local\boost_1_66_0
    'TBB_ROOT_1 == C:\tbb

    'get each settings list and assign to the correct dictionary

    'read the current system settings and compare with the conf, see if they are match. if not match, should promot whether if change it  or not


    'Settings
    'use customized control to show the settings
    '[ENV NAME TEXT BOX] [ CURRENT SETTINGS LABEL ] [AVAILABLE SETTINGS COMBO BOX] [+ BUTTON FOR ADD MORE SETTINGS]

    Private Sub ENVTEST()
        Dim sPath As String = Environment.GetEnvironmentVariable("SAP_CODEPAGE")

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
End Class
