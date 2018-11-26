<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DLTool_Form
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DLTool_Form))
        Me.SPMachineList = New System.Windows.Forms.ListBox()
        Me.DestDir = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Download_Button = New System.Windows.Forms.Button()
        Me.HypModelList = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Compile_Button = New System.Windows.Forms.Button()
        Me.NotificationLabel = New System.Windows.Forms.Label()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.DirSearch = New System.Windows.Forms.Button()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.NotificationLable2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MachineConfigData = New System.Data.DataSet()
        Me.BackgroundWorker3 = New System.ComponentModel.BackgroundWorker()
        Me.EditConfigButton = New System.Windows.Forms.Button()
        CType(Me.MachineConfigData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPMachineList
        '
        Me.SPMachineList.BackColor = System.Drawing.Color.Snow
        resources.ApplyResources(Me.SPMachineList, "SPMachineList")
        Me.SPMachineList.FormattingEnabled = True
        Me.SPMachineList.Items.AddRange(New Object() {resources.GetString("SPMachineList.Items"), resources.GetString("SPMachineList.Items1"), resources.GetString("SPMachineList.Items2")})
        Me.SPMachineList.Name = "SPMachineList"
        '
        'DestDir
        '
        Me.DestDir.BackColor = System.Drawing.Color.Snow
        resources.ApplyResources(Me.DestDir, "DestDir")
        Me.DestDir.Name = "DestDir"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Name = "Label1"
        '
        'Download_Button
        '
        Me.Download_Button.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Download_Button, "Download_Button")
        Me.Download_Button.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Download_Button.FlatAppearance.BorderSize = 10
        Me.Download_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Download_Button.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Download_Button.Name = "Download_Button"
        Me.Download_Button.UseVisualStyleBackColor = False
        '
        'HypModelList
        '
        Me.HypModelList.BackColor = System.Drawing.Color.Snow
        resources.ApplyResources(Me.HypModelList, "HypModelList")
        Me.HypModelList.ForeColor = System.Drawing.SystemColors.WindowText
        Me.HypModelList.FormattingEnabled = True
        Me.HypModelList.Items.AddRange(New Object() {resources.GetString("HypModelList.Items"), resources.GetString("HypModelList.Items1")})
        Me.HypModelList.Name = "HypModelList"
        '
        'Compile_Button
        '
        Me.Compile_Button.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Compile_Button, "Compile_Button")
        Me.Compile_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Compile_Button.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.Compile_Button.Name = "Compile_Button"
        Me.Compile_Button.UseVisualStyleBackColor = False
        '
        'NotificationLabel
        '
        resources.ApplyResources(Me.NotificationLabel, "NotificationLabel")
        Me.NotificationLabel.BackColor = System.Drawing.Color.Transparent
        Me.NotificationLabel.ForeColor = System.Drawing.Color.MintCream
        Me.NotificationLabel.Name = "NotificationLabel"
        '
        'DirSearch
        '
        Me.DirSearch.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.DirSearch, "DirSearch")
        Me.DirSearch.Name = "DirSearch"
        Me.DirSearch.UseVisualStyleBackColor = False
        '
        'NotificationLable2
        '
        resources.ApplyResources(Me.NotificationLable2, "NotificationLable2")
        Me.NotificationLable2.BackColor = System.Drawing.Color.Transparent
        Me.NotificationLable2.ForeColor = System.Drawing.Color.MintCream
        Me.NotificationLable2.Name = "NotificationLable2"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Name = "Label3"
        '
        'MachineConfigData
        '
        Me.MachineConfigData.DataSetName = "MachineConfigData"
        '
        'EditConfigButton
        '
        Me.EditConfigButton.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.EditConfigButton, "EditConfigButton")
        Me.EditConfigButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.EditConfigButton.FlatAppearance.BorderSize = 10
        Me.EditConfigButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.EditConfigButton.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.EditConfigButton.Name = "EditConfigButton"
        Me.EditConfigButton.UseVisualStyleBackColor = False
        '
        'DLTool_Form
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SlateGray
        Me.BackgroundImage = Global.EI_DLTool.My.Resources.Resources.beautiful_color_gradients_backgrounds_100_vicious_stance
        Me.Controls.Add(Me.EditConfigButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NotificationLable2)
        Me.Controls.Add(Me.DirSearch)
        Me.Controls.Add(Me.NotificationLabel)
        Me.Controls.Add(Me.Compile_Button)
        Me.Controls.Add(Me.Download_Button)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DestDir)
        Me.Controls.Add(Me.HypModelList)
        Me.Controls.Add(Me.SPMachineList)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Green
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.Name = "DLTool_Form"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        CType(Me.MachineConfigData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SPMachineList As ListBox
    Friend WithEvents DestDir As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Download_Button As Button
    Friend WithEvents HypModelList As ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Compile_Button As Button
    Friend WithEvents NotificationLabel As Label
    Friend WithEvents FBD As FolderBrowserDialog
    Friend WithEvents DirSearch As Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents NotificationLable2 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MachineConfigData As DataSet
    Friend WithEvents BackgroundWorker3 As System.ComponentModel.BackgroundWorker
    Friend WithEvents EditConfigButton As Button
End Class
