
Imports System.IO

Module ConfigMapping
    Public THIS_CONFIG_FILE_PATCH As String = "./UniSEM.conf"
    Public THIS_CONFIG_TABLENAME As String = "UniSEM"
    Public THIS_CONFIG_LANG As CONST_LANG_ENUM = CONST_LANG_ENUM.LANG_ENUS

    ''' <summary>
    ''' ConfigDictionary read from config file
    ''' </summary>
    Public ConfigDictionary As Dictionary(Of String, ConfigLine)

    Public UniSEMConfHelper As ConfigHelper

    ''' <summary>
    ''' Used to build the user control list
    ''' </summary>
    Public DICT_ENV As Dictionary(Of String, Dictionary(Of String, String))

    ''' <summary>
    ''' Public sub to read config via config helper
    ''' </summary>
    Public Function ReadConfig() As Boolean
        'load config
        ConfigDictionary = New Dictionary(Of String, ConfigLine)

        UniSEMConfHelper = New ConfigHelper
        UniSEMConfHelper.CONST_LANG = THIS_CONFIG_LANG
        UniSEMConfHelper.ResultTableName = THIS_CONFIG_TABLENAME
        UniSEMConfHelper.ConfigFilePath = THIS_CONFIG_FILE_PATCH

        ConfigDictionary = UniSEMConfHelper.dictConfigKeyWordAsKeyDetailAsValue

        BuildControlList()
        Return True
    End Function
    ''' <summary>
    ''' Used to build the user control list
    ''' </summary>
    Public Sub BuildControlList()
        DICT_ENV = New Dictionary(Of String, Dictionary(Of String, String))

        For Each subKeyPair In ConfigDictionary
            If subKeyPair.Key = "SYS_ENV_LIST" Then
                'SYS_ENV_LIST == ACE_ROOT,BOOST_ROOT,TBB_ROOT
                Dim arr As String() = subKeyPair.Value.ConfigVALUE.Split(",")
                For Each subString In arr
                    Dim dictTemp As New Dictionary(Of String, String)
                    If Not DICT_ENV.ContainsKey(subString) Then
                        DICT_ENV.Add(subString, dictTemp)
                    End If
                Next
            Else
                'ACE_ROOT|1 == C:\ACE_wrappers
                Dim arr As String() = subKeyPair.Key.Split("|")
                If DICT_ENV.ContainsKey(arr(0)) Then
                    DICT_ENV(arr(0)).Add(subKeyPair.Value.ConfigVALUE, subKeyPair.Value.ConfigVALUE)
                End If
            End If

        Next

        MainForm.FlowLayoutPanel1.Controls.Clear()
        If DICT_ENV.Count > 0 Then
            For Each subKeyPair In DICT_ENV
                Dim cItem As New SettingItem
                cItem.ENV_NAME = subKeyPair.Key
                cItem.txtEnvName.Text = subKeyPair.Key
                cItem.MetroComboBox1.Items.Clear()
                If subKeyPair.Value.Count > 0 Then
                    For Each subOptions In subKeyPair.Value
                        cItem.MetroComboBox1.Items.Add(subOptions.Value)
                    Next
                End If
                MainForm.FlowLayoutPanel1.Controls.Add(cItem)
            Next
        End If
    End Sub
    Public Function SaveConfig() As Boolean

        UniSEMConfHelper.dictConfigKeyWordAsKeyDetailAsValue = ConfigDictionary

        UniSEMConfHelper.SaveConfigFromDictToFile()

        'refresh
        ReadConfig()
    End Function

End Module
