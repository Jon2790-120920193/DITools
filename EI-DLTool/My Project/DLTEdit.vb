Imports System.Net

Public Class DLTEdit
    Dim DataPath As String = "http://inovkh.com:8001/SPM/MachineConfig.xml"
    Dim ConfigDoc As New System.Xml.XmlDocument()
    Dim CheckConfig As String
    Dim ArgConfig As String
    Dim ArgURL As String
    Dim Build As Integer

    Private Sub DLTEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not CheckForInternetConnection() = True Then
            Dim result As DialogResult = MsgBox("Connection to the IEC Server is not established, please check your connection and try again", MessageBoxButtons.RetryCancel, "Error 001")
            If result = DialogResult.Retry Then
                Me.Controls.Clear()
                InitializeComponent()
                DLTEdit_Load(e, e)
            ElseIf result = DialogResult.Retry Then
                Close()
            End If
        Else
            ConfigDoc.Load(DataPath)
            MachineModelTextBox.Text = DLTool_Form.SPMachineList.SelectedItem.ToString()
            HyperthermTypeTextBox.Text = DLTool_Form.HypModelList.SelectedItem.ToString()

            Dim SelectedConfig As String = MachineModelTextBox.Text & HyperthermTypeTextBox.Text

            For Each machine As System.Xml.XmlElement In ConfigDoc.DocumentElement.ChildNodes
                For Each field As System.Xml.XmlElement In machine.ChildNodes
                    If field.InnerText = SelectedConfig Then
                        CheckConfig = field.InnerText
                        TkNameTextBox.Text = field.NextSibling.InnerText
                        URLTextBox.Text = field.NextSibling.NextSibling.InnerText
                        BuildTextBox.Text = Conversion.Int(field.NextSibling.NextSibling.NextSibling.InnerText)
                    End If
                Next
            Next
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
    Private Sub MachineModelTextBox_TextChanged(sender As Object, e As EventArgs) Handles MachineModelTextBox.TextChanged

        Dim NewSelectedConfig As String = MachineModelTextBox.Text & HyperthermTypeTextBox.Text
        Dim CheckCount As Integer = 0

        For Each machine As System.Xml.XmlElement In ConfigDoc.DocumentElement.ChildNodes
            For Each field As System.Xml.XmlElement In machine.ChildNodes
                If field.InnerText = NewSelectedConfig Then
                    CheckCount = CheckCount + 1
                    CheckConfig = field.InnerText
                    TkNameTextBox.Text = field.NextSibling.InnerText
                    URLTextBox.Text = field.NextSibling.NextSibling.InnerText
                    BuildTextBox.Text = Conversion.Int(field.NextSibling.NextSibling.NextSibling.InnerText)
                    Exit For
                    Exit For
                End If
            Next
        Next

        If CheckCount = 0 Then
            CheckConfig = ""
            TkNameTextBox.Text = ""
            URLTextBox.Text = ""
        End If
    End Sub
End Class