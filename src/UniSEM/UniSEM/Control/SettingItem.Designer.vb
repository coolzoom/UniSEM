<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingItem
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtEnvName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.lblCurrent = New MetroFramework.Controls.MetroLabel()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'txtEnvName
        '
        '
        '
        '
        Me.txtEnvName.CustomButton.Image = Nothing
        Me.txtEnvName.CustomButton.Location = New System.Drawing.Point(147, 1)
        Me.txtEnvName.CustomButton.Name = ""
        Me.txtEnvName.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.txtEnvName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEnvName.CustomButton.TabIndex = 1
        Me.txtEnvName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEnvName.CustomButton.UseSelectable = True
        Me.txtEnvName.CustomButton.Visible = False
        Me.txtEnvName.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtEnvName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtEnvName.Lines = New String(-1) {}
        Me.txtEnvName.Location = New System.Drawing.Point(3, 6)
        Me.txtEnvName.MaxLength = 32767
        Me.txtEnvName.Name = "txtEnvName"
        Me.txtEnvName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEnvName.PromptText = "变量名/Env Name"
        Me.txtEnvName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEnvName.SelectedText = ""
        Me.txtEnvName.SelectionLength = 0
        Me.txtEnvName.SelectionStart = 0
        Me.txtEnvName.ShortcutsEnabled = True
        Me.txtEnvName.Size = New System.Drawing.Size(179, 33)
        Me.txtEnvName.TabIndex = 0
        Me.MetroToolTip1.SetToolTip(Me.txtEnvName, "变量名/Env Name")
        Me.txtEnvName.UseSelectable = True
        Me.txtEnvName.WaterMark = "变量名/Env Name"
        Me.txtEnvName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEnvName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 24
        Me.MetroComboBox1.Location = New System.Drawing.Point(306, 9)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.PromptText = "可选变量/Optional"
        Me.MetroComboBox1.Size = New System.Drawing.Size(334, 30)
        Me.MetroComboBox1.TabIndex = 1
        Me.MetroToolTip1.SetToolTip(Me.MetroComboBox1, "可选变量/Optional")
        Me.MetroComboBox1.UseSelectable = True
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(306, 51)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(15, 20)
        Me.lblCurrent.TabIndex = 2
        Me.lblCurrent.Text = "-"
        Me.MetroToolTip1.SetToolTip(Me.lblCurrent, "当前设置/Current Settings")
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(190, 19)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(92, 20)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "可选/options:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(190, 51)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(92, 20)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "当前/current:"
        '
        'SettingItem
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.txtEnvName)
        Me.Name = "SettingItem"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Size = New System.Drawing.Size(653, 79)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEnvName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents lblCurrent As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
