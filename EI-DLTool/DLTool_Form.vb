Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml

Public Class DLTool_Form
    Dim MModel As String
    Dim HModel As String
    Dim Destination As String
    Public ArgURL As String = ""
    Public ArgDir As String
    Public ArgConfig As String
    Dim URL_SP600XPR As String = "http://wiki.inovkh.com/doku.php?id=xpr_component_table"
    Dim URL_SP600HPR As String = "http://wiki.inovkh.com/doku.php?id=hpr_compoenent_table"
    Dim URL_SP700XPR As String = ""
    Dim URL_SP900XPR As String = "http://wiki.inovkh.com/doku.php?id=xpr_component_table_9x"
    Dim URL_SP900HPR As String = "http://wiki.inovkh.com/doku.php?id=hpr_component_table_9h"
    Dim startInfo As New ProcessStartInfo("C:\Users\Joe\Desktop\Work\Inovatech Engineering Corp\GitHub\Project\IE-DlTools\IE-DlTools\EI-DLTool\EIFindURL.exe")
    Dim DataPath As String = "http://inovkh.com:8001/SPM/MachineConfig.xml"
    Dim ConfigDoc As New System.Xml.XmlDocument()
    Public Build As Integer
    Dim CheckConfig As String = ""

    Private Sub DLTool_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfigDoc.Load(DataPath)
        SPMachineList.SelectedIndex = 0
        HypModelList.SelectedIndex = 0
        MModel = SPMachineList.SelectedItem.ToString()
        HModel = HypModelList.SelectedItem.ToString()
        PullSort(DestDir.Text, MModel, HModel)

        NotificationLabel.Text = "Table data from: " & ArgURL
        NotificationLable2.Text = "Destination Folder " & DestDir.Text
        NotificationLabel.Visible = True
        NotificationLable2.Visible = True

    End Sub


    Private Sub Download_Button_Click(sender As Object, e As EventArgs) Handles Download_Button.Click
        MModel = SPMachineList.SelectedItem.ToString()
        HModel = HypModelList.SelectedItem.ToString()
        ArgDir = DestDir.Text
        NotificationLabel.Visible = True
        NotificationLable2.Visible = True

        If ArgDir = "" Then
            MsgBox("Please choose a package save location, the field cannot be empty", MessageBoxButtons.OK, "Error 010")
        Else
            PullSort(ArgDir, MModel, HModel)
            If CheckConfig = "" Then
                MsgBox(MModel & " " & HModel & " Machine Configuration does not exist", MessageBoxButtons.OK, "Error 110")
            Else
                If ArgURL = "" Then
                    MsgBox(MModel & " " & HModel & " Does not have an associated Table", MessageBoxButtons.OK, "Error 111")
                ElseIf ArgConfig = "" Then
                    MsgBox(MModel & " " & HModel & " Machine Configuration has not been set", MessageBoxButtons.OK, "Error 112")
                Else
                    Launch(ArgDir, ArgURL, ArgConfig, Build)
                End If
            End If
        End If
    End Sub

    Public Sub Launch(ByVal ArgDir As String, ByVal ArgURL As String, ByVal ArgConfig As String, ByVal BuildNum As Integer)
        NotificationLabel.Visible = True
        NotificationLable2.Visible = True

        NotificationLabel.Text = "Table data from: " & ArgURL
        NotificationLable2.Text = "Destination Folder " & ArgDir

        startInfo.WindowStyle = ProcessWindowStyle.Normal
        startInfo.Arguments = Chr(34) & ArgURL & Chr(34) & " " & Chr(34) & ArgDir & Chr(34) & " " & Chr(34) & ArgConfig & Chr(34) & " " & Chr(34) & BuildNum & Chr(34)
        Process.Start(startInfo)
    End Sub

    Public Sub PullSort(ByVal ArgDir As String, ByVal HModel As String, ByVal MModel As String)

        Dim SelectedConfig As String = MModel & HModel

        For Each machine As System.Xml.XmlElement In ConfigDoc.DocumentElement.ChildNodes
            For Each field As System.Xml.XmlElement In machine.ChildNodes
                If field.InnerText = SelectedConfig Then
                    CheckConfig = field.InnerText
                    ArgConfig = field.NextSibling.InnerText
                    ArgURL = field.NextSibling.NextSibling.InnerText
                    Build = Conversion.Int(field.NextSibling.NextSibling.NextSibling.InnerText)
                    ArgDir = ArgDir & "\" & SelectedConfig
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
