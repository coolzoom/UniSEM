<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits MetroFramework.Forms.MetroForm 'System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnReload = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.txtEnvName = New MetroFramework.Controls.MetroTextBox()
        Me.txtEnvValue = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(24, 95)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(753, 300)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btnReload
        '
        Me.btnReload.Location = New System.Drawing.Point(582, 502)
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(195, 41)
        Me.btnReload.TabIndex = 1
        Me.btnReload.Text = "重启CMAKE / Reload CMAKE"
        Me.btnReload.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.DimGray
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MetroPanel1.Controls.Add(Me.btnAdd)
        Me.MetroPanel1.Controls.Add(Me.txtEnvName)
        Me.MetroPanel1.Controls.Add(Me.txtEnvValue)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 406)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(756, 90)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackgroundImage = Global.UniSEM.My.Resources.Resources.add_new_200px
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.Location = New System.Drawing.Point(691, 26)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(58, 57)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.UseSelectable = True
        '
        'txtEnvName
        '
        '
        '
        '
        Me.txtEnvName.CustomButton.Image = Nothing
        Me.txtEnvName.CustomButton.Location = New System.Drawing.Point(193, 1)
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
        Me.txtEnvName.Location = New System.Drawing.Point(13, 35)
        Me.txtEnvName.MaxLength = 32767
        Me.txtEnvName.Name = "txtEnvName"
        Me.txtEnvName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEnvName.PromptText = "变量名|序号/Env Name|Number"
        Me.txtEnvName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEnvName.SelectedText = ""
        Me.txtEnvName.SelectionLength = 0
        Me.txtEnvName.SelectionStart = 0
        Me.txtEnvName.ShortcutsEnabled = True
        Me.txtEnvName.Size = New System.Drawing.Size(225, 33)
        Me.txtEnvName.TabIndex = 5
        Me.txtEnvName.UseSelectable = True
        Me.txtEnvName.WaterMark = "变量名|序号/Env Name|Number"
        Me.txtEnvName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEnvName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtEnvValue
        '
        '
        '
        '
        Me.txtEnvValue.CustomButton.Image = Nothing
        Me.txtEnvValue.CustomButton.Location = New System.Drawing.Point(404, 1)
        Me.txtEnvValue.CustomButton.Name = ""
        Me.txtEnvValue.CustomButton.Size = New System.Drawing.Size(31, 31)
        Me.txtEnvValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEnvValue.CustomButton.TabIndex = 1
        Me.txtEnvValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEnvValue.CustomButton.UseSelectable = True
        Me.txtEnvValue.CustomButton.Visible = False
        Me.txtEnvValue.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtEnvValue.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.txtEnvValue.Lines = New String(-1) {}
        Me.txtEnvValue.Location = New System.Drawing.Point(249, 35)
        Me.txtEnvValue.MaxLength = 32767
        Me.txtEnvValue.Name = "txtEnvValue"
        Me.txtEnvValue.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEnvValue.PromptText = "值/Value"
        Me.txtEnvValue.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEnvValue.SelectedText = ""
        Me.txtEnvValue.SelectionLength = 0
        Me.txtEnvValue.SelectionStart = 0
        Me.txtEnvValue.ShortcutsEnabled = True
        Me.txtEnvValue.Size = New System.Drawing.Size(436, 33)
        Me.txtEnvValue.TabIndex = 6
        Me.txtEnvValue.UseSelectable = True
        Me.txtEnvValue.WaterMark = "值/Value"
        Me.txtEnvValue.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEnvValue.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(13, 12)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(130, 20)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "添加设置/Add Item"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 64)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(145, 20)
        Me.MetroLabel1.TabIndex = 3
        Me.MetroLabel1.Text = "当前设置/Current List"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 523)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(109, 20)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "v1.0 by ylg 2020"
        '
        'MainForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(800, 552)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.btnReload)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "优设UniSEM - Universal Windows System Enviroment Manager"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnReload As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEnvName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtEnvValue As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
End Class
