Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml
Imports System.Net

Public Class DLTool_Form
    Dim MModel As String
    Dim HModel As String
    Dim Destination As String
    Public ArgURL As String = ""
    Public ArgDir As String
    Public ArgConfig As String
    Dim startInfo As New ProcessStartInfo("C:\Users\Joe_T\OneDrive\Documents\GitHub\IE-DLTool\IE-DlTools\EI-DLTool\EIFindURL.exe")
    Dim DataPath As String = "\\192.168.5.4\Public\SteelPRO_Builds\SPM\MachineConfig.xml"
    Dim ConfigDoc As New System.Xml.XmlDocument()
    Public Build As Integer
    Dim CheckConfig As String = ""

    Private Sub DLTool_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckForInternetConnection() = True Then
            Dim result As DialogResult = MsgBox("Connection to the IEC Server is not established, please check your connection and try again", MessageBoxButtons.RetryCancel, "Error 001")
            If result = DialogResult.Retry Then
                Me.Controls.Clear()
                InitializeComponent()
                DLTool_Form_Load(e, e)
            ElseIf result = DialogResult.Retry Then
                Close()
            End If
            Download_Button.Enabled = False
            EditConfigButton.Enabled = False
        Else
            Download_Button.Enabled = True
            EditConfigButton.Enabled = True
            ConfigDoc.Load(DataPath)
            SPMachineList.SelectedIndex = 0
            HypModelList.SelectedIndex = 0
            MModel = SPMachineList.SelectedItem.ToString()
            HModel = HypModelList.SelectedItem.ToString()
            PullSort(DestDir.Text)

            NotificationLabel.Text = "Table data from: " & ArgURL
            NotificationLable2.Text = "Destination Folder " & DestDir.Text
            NotificationLabel.Visible = True
            NotificationLable2.Visible = True
        End If
    End Sub

    Public Shared Function CheckForInternetConnection() As Boolean
        Try
            Using client = New WebClient()
                Using stream = client.OpenRead("http://wiki.inovkh.com/doku.php")
                    Return True
                End Using
            End Using
        Catch
            Return False
        End Try
    End Function

    Private Sub Download_Button_Click(sender As Object, e As EventArgs) Handles Download_Button.Click
        If Not CheckForInternetConnection() = True Then
            Dim result As DialogResult = MsgBox("Connection to the IEC Server is not established, please check your connection and try again", MessageBoxButtons.RetryCancel, "Error 001")
            If result = DialogResult.Retry Then
                Me.Controls.Clear()
                InitializeComponent()
                DLTool_Form_Load(e, e)
            ElseIf result = DialogResult.Retry Then
                Close()
            End If
            Download_Button.Enabled = False
            EditConfigButton.Enabled = False
        Else
            MModel = SPMachineList.SelectedItem.ToString()
            HModel = HypModelList.SelectedItem.ToString()
            ArgDir = DestDir.Text
            NotificationLabel.Visible = True
            NotificationLable2.Visible = True

            If ArgDir = "" Then
                MsgBox("Please choose a package save location, the field cannot be empty", MessageBoxButtons.OK, "Error 010")
            Else
                PullSort(ArgDir)
                If CheckConfig = "" Then
                    MsgBox(MModel & " " & HModel & " Machine Configuration does not exist", MessageBoxButtons.OK, "Error 110")
                Else
                    If ArgURL = "" Then
                        MsgBox(MModel & " " & HModel & " Does not have an associated Table", MessageBoxButtons.OK, "Error 111")
                    Else
                        If ArgConfig = "" Then
                            MsgBox(MModel & " " & HModel & " Machine Configuration has not been set", MessageBoxButtons.OK, "Error 112")
                        Else
                            Launch(ArgDir & "\" & CheckConfig, ArgURL, ArgConfig, Build)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub Launch(ByVal ArgDir As String, ByVal ArgURL As String, ByVal ArgConfig As String, ByVal BuildNum As Integer)
        NotificationLabel.Visible = True
        NotificationLable2.Visible = True

        NotificationLabel.Text = "Table data from: " & ArgURL
        NotificationLable2.Text = "Destination Folder " & ArgDir

        Try
            startInfo.WorkingDirectory = "C:\Windows\System32"
            startInfo.UseShellExecute = False
            startInfo.WindowStyle = ProcessWindowStyle.Normal
            startInfo.Arguments = Chr(34) & ArgURL & Chr(34) & " " & Chr(34) & ArgDir & Chr(34) & " " & Chr(34) & ArgConfig & Chr(34) & " " & Chr(34) & BuildNum & Chr(34)
            Process.Start(startInfo)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub PullSort(ByVal ArgDir As String)
        ConfigDoc.Load(DataPath)
        Dim SelectedConfig As String = SPMachineList.SelectedItem.ToString() & HypModelList.SelectedItem.ToString()

        For Each machine As System.Xml.XmlElement In ConfigDoc.DocumentElement.ChildNodes
            For Each field As System.Xml.XmlElement In machine.ChildNodes
                If field.InnerText = SelectedConfig Then
                    CheckConfig = field.InnerText
                    ArgConfig = field.NextSibling.InnerText
                    ArgURL = field.NextSibling.NextSibling.InnerText
                    Build = Conversion.Int(field.NextSibling.NextSibling.NextSibling.InnerText)
                    ArgDir = ArgDir
                End If
            Next
        Next

        'MsgBox(MModel & " " & HModel & " is not a valid machine configuration", MessageBoxButtons.OK, "Error 011")
    End Sub


    Private Sub DirSearch_Click(sender As Object, e As EventArgs) Handles DirSearch.Click
        If (FBD.ShowDialog() = DialogResult.OK) Then
            DestDir.Text = FBD.SelectedPath
        End If
    End Sub

    Private Sub DestDir_TextChanged(sender As Object, e As EventArgs) Handles DestDir.TextChanged
        NotificationLable2.Text = "Destination Folder " & DestDir.Text
    End Sub

    Private Sub EditConfigButton_Click(sender As Object, e As EventArgs) Handles EditConfigButton.Click
        Dim DLTEdit = New DLTEdit
        DLTEdit.Show()
    End Sub
End Class
